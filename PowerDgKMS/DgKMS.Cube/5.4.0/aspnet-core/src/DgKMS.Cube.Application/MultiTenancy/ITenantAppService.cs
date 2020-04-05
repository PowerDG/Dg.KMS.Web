using Abp.Application.Services;
using DgKMS.Cube.MultiTenancy.Dto;

namespace DgKMS.Cube.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

