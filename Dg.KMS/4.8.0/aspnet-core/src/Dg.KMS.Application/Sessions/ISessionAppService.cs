using System.Threading.Tasks;
using Abp.Application.Services;
using Dg.KMS.Sessions.Dto;

namespace Dg.KMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
