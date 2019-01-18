using Abp.Authorization;
using MySql.ETyhy.Authorization.Roles;
using MySql.ETyhy.Authorization.Users;

namespace MySql.ETyhy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
