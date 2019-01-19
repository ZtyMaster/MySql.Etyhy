
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using MySql.ETyhy.Bumen;
using MySql.ETyhy.ComPay;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace  MySql.ETyhy.Bumen.Dtos
{
    public class BuMensEditDto
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
		/// IsTopBm
		/// </summary>
		public bool IsTopBm { get; set; }



		/// <summary>
		/// ComasId
		/// </summary>
		public int ComasId { get; set; }



		/// <summary>
		/// Comas
		/// </summary>
		public Comas Comas { get; set; }



		/// <summary>
		/// Zhiws
		/// </summary>
		public List<Zhiws> Zhiws { get; set; }



		/// <summary>
		/// Shot
		/// </summary>
		public int Shot { get; set; }




    }
}