

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos
{
    public class CreateOrUpdateZhiwsInput
    {
        [Required]
        public ZhiwsEditDto Zhiws { get; set; }

    }
}