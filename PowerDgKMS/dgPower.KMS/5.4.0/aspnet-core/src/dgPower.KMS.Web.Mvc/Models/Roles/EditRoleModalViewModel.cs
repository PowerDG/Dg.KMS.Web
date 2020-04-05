using Abp.AutoMapper;
using dgPower.KMS.Roles.Dto;
using dgPower.KMS.Web.Models.Common;

namespace dgPower.KMS.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
