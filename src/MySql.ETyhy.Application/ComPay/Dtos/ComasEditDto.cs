
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using MySql.ETyhy.Authorization.Users;
using MySql.ETyhy.Bumen;
using MySql.ETyhy.ComPay;

namespace  MySql.ETyhy.ComPay.Dtos
{
    public class ComasEditDto
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
		/// OverTime
		/// </summary>
		public DateTime OverTime { get; set; }



		/// <summary>
		/// MaxPersons
		/// </summary>
		public int MaxPersons { get; set; }



		/// <summary>
		/// BuMens
		/// </summary>
		public List<BuMens> BuMens { get; set; }



		/// <summary>
		/// Users
		/// </summary>
		public List<User> Users { get; set; }




    }
}