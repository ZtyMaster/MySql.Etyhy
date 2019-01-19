
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


using MySql.ETyhy.ComPay.Bumen.ZhiWu;
using MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos;
using MySql.ETyhy.ComPay.Bumen.ZhiWu.DomainService;
using MySql.ETyhy.ComPay.Bumen.ZhiWu.Authorization;


namespace MySql.ETyhy.ComPay.Bumen.ZhiWu
{
    /// <summary>
    /// Zhiws应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class ZhiwsAppService : ETyhyAppServiceBase, IZhiwsAppService
    {
        private readonly IRepository<Zhiws, int> _entityRepository;

        private readonly IZhiwsManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public ZhiwsAppService(
        IRepository<Zhiws, int> entityRepository
        ,IZhiwsManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取Zhiws的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(ZhiwsPermissions.Query)] 
        public async Task<PagedResultDto<ZhiwsListDto>> GetPaged(GetZhiwssInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<ZhiwsListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<ZhiwsListDto>>();

			return new PagedResultDto<ZhiwsListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取ZhiwsListDto信息
		/// </summary>
		[AbpAuthorize(ZhiwsPermissions.Query)] 
		public async Task<ZhiwsListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<ZhiwsListDto>();
		}

		/// <summary>
		/// 获取编辑 Zhiws
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ZhiwsPermissions.Create,ZhiwsPermissions.Edit)]
		public async Task<GetZhiwsForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetZhiwsForEditOutput();
ZhiwsEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<ZhiwsEditDto>();

				//zhiwsEditDto = ObjectMapper.Map<List<zhiwsEditDto>>(entity);
			}
			else
			{
				editDto = new ZhiwsEditDto();
			}

			output.Zhiws = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改Zhiws的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ZhiwsPermissions.Create,ZhiwsPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateZhiwsInput input)
		{

			if (input.Zhiws.Id.HasValue)
			{
				await Update(input.Zhiws);
			}
			else
			{
				await Create(input.Zhiws);
			}
		}


		/// <summary>
		/// 新增Zhiws
		/// </summary>
		[AbpAuthorize(ZhiwsPermissions.Create)]
		protected virtual async Task<ZhiwsEditDto> Create(ZhiwsEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <Zhiws>(input);
            var entity=input.MapTo<Zhiws>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<ZhiwsEditDto>();
		}

		/// <summary>
		/// 编辑Zhiws
		/// </summary>
		[AbpAuthorize(ZhiwsPermissions.Edit)]
		protected virtual async Task Update(ZhiwsEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除Zhiws信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ZhiwsPermissions.Delete)]
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除Zhiws的方法
		/// </summary>
		[AbpAuthorize(ZhiwsPermissions.BatchDelete)]
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出Zhiws为excel表,等待开发。
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


