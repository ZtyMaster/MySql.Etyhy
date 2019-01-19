
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using MySql.ETyhy.ComPay;
using MySql.ETyhy.ComPay.Dtos;
using MySql.ETyhy.ComPay.DomainService;
using MySql.ETyhy.ComPay.Authorization;


namespace MySql.ETyhy.ComPay
{
    /// <summary>
    /// Comas应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class ComasAppService : ETyhyAppServiceBase, IComasAppService
    {
        private readonly IRepository<Comas, int> _entityRepository;

        private readonly IComasManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public ComasAppService(
        IRepository<Comas, int> entityRepository
        ,IComasManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取Comas的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(ComasPermissions.Query)] 
        public async Task<PagedResultDto<ComasListDto>> GetPaged(GetComassInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<ComasListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<ComasListDto>>();

			return new PagedResultDto<ComasListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取ComasListDto信息
		/// </summary>
		[AbpAuthorize(ComasPermissions.Query)] 
		public async Task<ComasListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<ComasListDto>();
		}

		/// <summary>
		/// 获取编辑 Comas
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ComasPermissions.Create,ComasPermissions.Edit)]
		public async Task<GetComasForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetComasForEditOutput();
ComasEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<ComasEditDto>();

				//comasEditDto = ObjectMapper.Map<List<comasEditDto>>(entity);
			}
			else
			{
				editDto = new ComasEditDto();
			}

			output.Comas = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改Comas的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ComasPermissions.Create,ComasPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateComasInput input)
		{

			if (input.Comas.Id.HasValue)
			{
				await Update(input.Comas);
			}
			else
			{
				await Create(input.Comas);
			}
		}


		/// <summary>
		/// 新增Comas
		/// </summary>
		[AbpAuthorize(ComasPermissions.Create)]
		protected virtual async Task<ComasEditDto> Create(ComasEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <Comas>(input);
            var entity=input.MapTo<Comas>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<ComasEditDto>();
		}

		/// <summary>
		/// 编辑Comas
		/// </summary>
		[AbpAuthorize(ComasPermissions.Edit)]
		protected virtual async Task Update(ComasEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除Comas信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ComasPermissions.Delete)]
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除Comas的方法
		/// </summary>
		[AbpAuthorize(ComasPermissions.BatchDelete)]
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出Comas为excel表,等待开发。
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}

    }
}


