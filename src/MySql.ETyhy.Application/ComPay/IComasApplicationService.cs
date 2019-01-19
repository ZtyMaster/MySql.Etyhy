
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


using MySql.ETyhy.ComPay.Dtos;
using MySql.ETyhy.ComPay;

namespace MySql.ETyhy.ComPay
{
    /// <summary>
    /// Comas应用层服务的接口方法
    ///</summary>
    public interface IComasAppService : IApplicationService
    {
        /// <summary>
		/// 获取Comas的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<ComasListDto>> GetPaged(GetComassInput input);


		/// <summary>
		/// 通过指定id获取ComasListDto信息
		/// </summary>
		Task<ComasListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetComasForEditOutput> GetForEdit(NullableIdDto<int> input);


        /// <summary>
        /// 添加或者修改Comas的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateComasInput input);


        /// <summary>
        /// 删除Comas信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<int> input);


        /// <summary>
        /// 批量删除Comas
        /// </summary>
        Task BatchDelete(List<int> input);


		/// <summary>
        /// 导出Comas为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetToExcel();

    }
}
