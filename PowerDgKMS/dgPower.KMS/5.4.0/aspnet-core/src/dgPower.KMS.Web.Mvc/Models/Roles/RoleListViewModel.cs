using System.Collections.Generic;
using dgPower.KMS.Roles.Dto;

namespace dgPower.KMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
