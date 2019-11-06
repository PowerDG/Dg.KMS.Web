using System.Threading.Tasks;
using Abp.Application.Services;
using Dg.KMS.Authorization.Accounts.Dto;

namespace Dg.KMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
