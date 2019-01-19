using Abp.Domain.Entities.Auditing;
using MySql.ETyhy.Authorization.Users;
using MySql.ETyhy.Bumen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySql.ETyhy.ComPay
{
   public  class Comas: FullAuditedEntity
    {
        [Required]
        [MaxLength(ETyhyConsts.Maxlength_255)]
        [MinLength(ETyhyConsts.Minlength_3)]
        public string TName { get; set; }
        [DefaultValue(typeof(DateTime), ETyhyConsts.Overtime)]
        public DateTime OverTime { get; set; }
        [DefaultValue(100)]
        public int MaxPersons { get; set; }
        public ICollection<BuMens> BuMens { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
