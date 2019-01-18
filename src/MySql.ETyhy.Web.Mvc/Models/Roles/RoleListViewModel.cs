using System.Collections.Generic;
using MySql.ETyhy.Roles.Dto;

namespace MySql.ETyhy.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
