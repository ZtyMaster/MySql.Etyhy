

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MySql.ETyhy.Bumen;

namespace MySql.ETyhy.Bumen.Dtos
{
    public class CreateOrUpdateBuMensInput
    {
        [Required]
        public BuMensEditDto BuMens { get; set; }

    }
}