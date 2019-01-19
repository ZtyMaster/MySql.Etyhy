

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using MySql.ETyhy.ComPay;
using MySql.ETyhy.Bumen;
using MySql.ETyhy.Authorization.Users;
using System.Collections.Generic;

namespace MySql.ETyhy.ComPay.Dtos
{
    public class ComasListDto : FullAuditedEntityDto 
    {

        
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