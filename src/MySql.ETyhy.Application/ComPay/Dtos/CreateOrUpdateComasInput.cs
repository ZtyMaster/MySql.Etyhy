

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MySql.ETyhy.ComPay;

namespace MySql.ETyhy.ComPay.Dtos
{
    public class CreateOrUpdateComasInput
    {
        [Required]
        public ComasEditDto Comas { get; set; }

    }
}