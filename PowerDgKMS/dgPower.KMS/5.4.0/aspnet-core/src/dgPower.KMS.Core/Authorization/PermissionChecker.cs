using Abp.Authorization;
using dgPower.KMS.Authorization.Roles;
using dgPower.KMS.Authorization.Users;

namespace dgPower.KMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
