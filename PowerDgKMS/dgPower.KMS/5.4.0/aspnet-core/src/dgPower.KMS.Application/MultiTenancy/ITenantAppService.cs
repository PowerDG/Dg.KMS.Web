using Abp.Application.Services;
using dgPower.KMS.MultiTenancy.Dto;

namespace dgPower.KMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

