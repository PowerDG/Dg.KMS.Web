using System.Collections.Generic;
using dgPower.KMS.Roles.Dto;

namespace dgPower.KMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
