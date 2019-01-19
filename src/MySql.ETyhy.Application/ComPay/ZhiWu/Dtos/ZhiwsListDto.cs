

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;
using MySql.ETyhy.Bumen;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos
{
    public class ZhiwsListDto : FullAuditedEntityDto 
    {

        
		/// <summary>
		/// TName
		/// </summary>
[MaxLength(ETyhyConsts.Maxlength_255)]
[MinLength(ETyhyConsts.Minlength_3)]
		[Required(ErrorMessage="TName不能为空")]
		public string TName { get; set; }



		/// <summary>
		/// BumensId
		/// </summary>
		public int BumensId { get; set; }



		/// <summary>
		/// Bumens
		/// </summary>
		public BuMens Bumens { get; set; }



		/// <summary>
		/// Shot
		/// </summary>
		public int Shot { get; set; }




    }
}