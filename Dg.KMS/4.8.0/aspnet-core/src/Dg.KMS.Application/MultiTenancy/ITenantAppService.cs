using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dg.KMS.MultiTenancy.Dto;

namespace Dg.KMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

