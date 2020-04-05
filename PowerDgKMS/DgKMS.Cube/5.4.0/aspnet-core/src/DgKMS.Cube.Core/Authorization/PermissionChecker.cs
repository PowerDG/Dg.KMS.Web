using Abp.Authorization;
using DgKMS.Cube.Authorization.Roles;
using DgKMS.Cube.Authorization.Users;

namespace DgKMS.Cube.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
