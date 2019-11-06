using Abp.Authorization;
using Dg.fifth.Authorization.Roles;
using Dg.fifth.Authorization.Users;

namespace Dg.fifth.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
