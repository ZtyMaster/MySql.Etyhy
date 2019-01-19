
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


using MySql.ETyhy.Bumen;
using MySql.ETyhy.Bumen.Dtos;
using MySql.ETyhy.Bumen.DomainService;
using MySql.ETyhy.Bumen.Authorization;


namespace MySql.ETyhy.Bumen
{
    /// <summary>
    /// BuMens应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class BuMensAppService : ETyhyAppServiceBase, IBuMensAppService
    {
        private readonly IRepository<BuMens, int> _entityRepository;

        private readonly IBuMensManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public BuMensAppService(
        IRepository<BuMens, int> entityRepository
        ,IBuMensManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取BuMens的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(BuMensPermissions.Query)] 
        public async Task<PagedResultDto<BuMensListDto>> GetPaged(GetBuMenssInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<BuMensListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<BuMensListDto>>();

			return new PagedResultDto<BuMensListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取BuMensListDto信息
		/// </summary>
		[AbpAuthorize(BuMensPermissions.Query)] 
		public async Task<BuMensListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<BuMensListDto>();
		}

		/// <summary>
		/// 获取编辑 BuMens
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(BuMensPermissions.Create,BuMensPermissions.Edit)]
		public async Task<GetBuMensForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetBuMensForEditOutput();
BuMensEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<BuMensEditDto>();

				//buMensEditDto = ObjectMapper.Map<List<buMensEditDto>>(entity);
			}
			else
			{
				editDto = new BuMensEditDto();
			}

			output.BuMens = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改BuMens的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(BuMensPermissions.Create,BuMensPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateBuMensInput input)
		{

			if (input.BuMens.Id.HasValue)
			{
				await Update(input.BuMens);
			}
			else
			{
				await Create(input.BuMens);
			}
		}


		/// <summary>
		/// 新增BuMens
		/// </summary>
		[AbpAuthorize(BuMensPermissions.Create)]
		protected virtual async Task<BuMensEditDto> Create(BuMensEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <BuMens>(input);
            var entity=input.MapTo<BuMens>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<BuMensEditDto>();
		}

		/// <summary>
		/// 编辑BuMens
		/// </summary>
		[AbpAuthorize(BuMensPermissions.Edit)]
		protected virtual async Task Update(BuMensEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除BuMens信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(BuMensPermissions.Delete)]
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除BuMens的方法
		/// </summary>
		[AbpAuthorize(BuMensPermissions.BatchDelete)]
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出BuMens为excel表,等待开发。
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


