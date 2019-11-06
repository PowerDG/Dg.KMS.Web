using Abp.Authorization;
using Dg.KMS.Authorization.Roles;
using Dg.KMS.Authorization.Users;

namespace Dg.KMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
