using System.Threading.Tasks;
using Abp.Application.Services;
using dgPower.PKMS.Sessions.Dto;

namespace dgPower.PKMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
