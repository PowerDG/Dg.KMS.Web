using Abp.Authorization;
using dgPower.PKMS.Authorization.Roles;
using dgPower.PKMS.Authorization.Users;

namespace dgPower.PKMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
