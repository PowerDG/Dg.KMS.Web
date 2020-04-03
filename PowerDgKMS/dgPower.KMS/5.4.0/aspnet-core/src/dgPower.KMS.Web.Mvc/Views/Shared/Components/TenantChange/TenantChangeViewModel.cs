using Abp.AutoMapper;
using dgPower.KMS.Sessions.Dto;

namespace dgPower.KMS.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
