using Abp.Authorization;
using Upwork.Authorization.Roles;
using Upwork.Authorization.Users;

namespace Upwork.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
