using System.Threading.Tasks;
using Abp.Application.Services;
using DgKMS.Cube.Sessions.Dto;

namespace DgKMS.Cube.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
