using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Domain.Repositories;
using DgKMS.Cube.CubeCore;
using DgKMS.Cube.CubeCore.Domain;
using DgKMS.Cube.Sessions.Dto;

namespace DgKMS.Cube.Sessions
{
    public class SessionAppService : CubeAppServiceBase, ISessionAppService
    {

        private readonly IRepository<EvernoteTag, int> _evernoteTagRepository;

        //private readonly IEvernoteTagListExcelExporter _evernoteTagListExcelExporter;   

        private readonly IEvernoteTagManager _evernoteTagManager;

        private readonly EvernoteTagManager _manager;
        public SessionAppService(
             //IRepository<EvernoteTag, ulong> evernoteTagRepository
             //, IEvernoteTagManager evernoteTagManager
             //,EvernoteTagListExcelExporter evernoteTagListExcelExporter
               EvernoteTagManager manager
             )
        {
            //_evernoteTagRepository = evernoteTagRepository;
            //_evernoteTagManager = evernoteTagManager; ;
            //_evernoteTagListExcelExporter = evernoteTagListExcelExporter;
            _manager = manager;

        }

        public async Task<List<EvernoteTag>> LoadAndShowListAsync()
        {
            var c = await _manager.LoadAndShowListAsync();
            return c.ToList();
        }

        public async Task<List<EvernoteTag>> LoadRemoteListAsync()
        {
            var c = await _manager.LoadRemoteListAsync();
            return c.ToList();
        }
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                Application = new ApplicationInfoDto
                {
                    Version = AppVersionHelper.Version,
                    ReleaseDate = AppVersionHelper.ReleaseDate,
                    Features = new Dictionary<string, bool>()
                }
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = ObjectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            if (AbpSession.UserId.HasValue)
            {
                output.User = ObjectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            return output;
        }
    }
}
