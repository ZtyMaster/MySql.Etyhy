using System.Collections.Generic;
using MySql.ETyhy.Roles.Dto;

namespace MySql.ETyhy.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}