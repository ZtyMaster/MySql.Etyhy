using Abp.Domain.Entities.Auditing;
using MySql.ETyhy.Bumen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu
{
    public class Zhiws: FullAuditedEntity
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
           
        public int BumensId { get; set; }
        public BuMens Bumens { get; set; }

    }
}
