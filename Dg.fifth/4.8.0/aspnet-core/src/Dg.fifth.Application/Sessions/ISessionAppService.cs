using System.Threading.Tasks;
using Abp.Application.Services;
using Dg.fifth.Sessions.Dto;

namespace Dg.fifth.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
