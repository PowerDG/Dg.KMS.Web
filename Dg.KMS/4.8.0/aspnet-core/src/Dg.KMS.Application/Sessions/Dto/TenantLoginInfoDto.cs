using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Dg.KMS.MultiTenancy;

namespace Dg.KMS.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
