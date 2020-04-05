using Abp.Application.Services;
using dgPower.PKMS.MultiTenancy.Dto;

namespace dgPower.PKMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

