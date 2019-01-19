
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
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using Abp.Application.Services.Dto;


using MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu
{
    /// <summary>
    /// Zhiws应用层服务的接口方法
    ///</summary>
    public interface IZhiwsAppService : IApplicationService
    {
        /// <summary>
		/// 获取Zhiws的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<ZhiwsListDto>> GetPaged(GetZhiwssInput input);


		/// <summary>
		/// 通过指定id获取ZhiwsListDto信息
		/// </summary>
		Task<ZhiwsListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetZhiwsForEditOutput> GetForEdit(NullableIdDto<int> input);


        /// <summary>
        /// 添加或者修改Zhiws的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateZhiwsInput input);


        /// <summary>
        /// 删除Zhiws信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<int> input);


        /// <summary>
        /// 批量删除Zhiws
        /// </summary>
        Task BatchDelete(List<int> input);


		/// <summary>
        /// 导出Zhiws为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetToExcel();

    }
}
