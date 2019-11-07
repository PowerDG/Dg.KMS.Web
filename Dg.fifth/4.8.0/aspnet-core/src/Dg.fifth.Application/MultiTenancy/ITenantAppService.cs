using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dg.fifth.MultiTenancy.Dto;

namespace Dg.fifth.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

