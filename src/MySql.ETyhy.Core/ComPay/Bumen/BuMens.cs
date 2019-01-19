using Abp.Domain.Entities.Auditing;
using MySql.ETyhy.ComPay;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySql.ETyhy.Bumen
{
    public class BuMens: FullAuditedEntity
    {
        [Required]
        [MaxLength(ETyhyConsts.Maxlength_255)]
        [MinLength(ETyhyConsts.Minlength_3)]
        public string TName { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [DefaultValue(1)]
        public int Shot { get; set; }
        /// <summary>
        /// 是否顶级部门
        /// </summary>        
        [DefaultValue(false)]
        public bool IsTopBm { get; set; }
        /// <summary>
        /// 上级部门
        /// </summary>       
        public int ComasId { get; set; }
        public Comas Comas { get; set; }
        public ICollection<Zhiws> Zhiws { get; set; }
    }
}
