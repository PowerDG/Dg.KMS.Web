using System.Threading.Tasks;
using Abp.Application.Services;
using Dg.fifth.Authorization.Accounts.Dto;

namespace Dg.fifth.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
