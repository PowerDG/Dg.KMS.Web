using System.Threading.Tasks;
using Abp.Application.Services;
using dgPower.KMS.Sessions.Dto;

namespace dgPower.KMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
