using System.Threading.Tasks;
using Abp.Application.Services;
using dgPower.KMS.Authorization.Accounts.Dto;

namespace dgPower.KMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
