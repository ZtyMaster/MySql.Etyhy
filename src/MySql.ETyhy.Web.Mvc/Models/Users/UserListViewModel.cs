using System.Collections.Generic;
using MySql.ETyhy.Roles.Dto;
using MySql.ETyhy.Users.Dto;

namespace MySql.ETyhy.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
