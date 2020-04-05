using System.Collections.Generic;
using dgPower.KMS.Roles.Dto;

namespace dgPower.KMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}