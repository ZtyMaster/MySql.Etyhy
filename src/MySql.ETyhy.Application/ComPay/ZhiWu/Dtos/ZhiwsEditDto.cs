
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using MySql.ETyhy.Bumen;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace  MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos
{
    public class ZhiwsEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
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