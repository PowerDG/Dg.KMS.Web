using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Domain.Repositories;
using dgEvernote.Core;
using DgKMS.Cube.CubeCore;
using DgKMS.Cube.CubeCore.Domain;
using DgKMS.Cube.Sessions.Dto;

namespace DgKMS.Cube.Sessions
{
    public class SessionAppService : CubeAppServiceBase, ISessionAppService
    {

        private readonly IRepository<EvernoteTag, int> _evernoteTagRepository;



        private readonly IRepository<CubeTag, long> _tagRepository;
        //private readonly IEvernoteTagListExcelExporter _evernoteTagListExcelExporter;   

        private readonly IEvernoteTagManager _evernoteTagManager;

        private readonly EvernoteTagManager _manager;
        public SessionAppService(
             IRepository<CubeTag, long> tagRepository,
             //, IEvernoteTagManager evernoteTagManager
             //,EvernoteTagListExcelExporter evernoteTagListExcelExporter
               EvernoteTagManager manager
             )
        {
            _tagRepository = tagRepository;
            //_evernoteTagRepository = evernoteTagRepository;
            //_evernoteTagManager = evernoteTagManager; ;
            //_evernoteTagListExcelExporter = evernoteTagListExcelExporter;
            _manager = manager;

        }

        public List<CubeTag> ShowCubeTagAsync()
        {
            var remoteList = NoteManager.GetListTags();
            //entity.Id = await _evernoteTagRepository.InsertAndGetIdAsync(entity);
            var tagList = new List<CubeTag>();
            if (remoteList.Any())
            {
                var query = remoteList.Select(m => new CubeTag()
                {
                    Guid = m.Guid,
                    Name = m.Name,
                    ParentGuid = m.ParentGuid,
                    UpdateSequenceNum = m.UpdateSequenceNum
                });
                query.ToList().ForEach(async entity =>
                {
                    //entity.Id = null;
                    //entity.Id = null;
                    await _tagRepository.InsertAsync(entity);
                });
                tagList= query.OrderBy(x => x.Guid).TakeLast(50).ToList();
            }
            return tagList;
        }


        public async Task<IEnumerable<EvernoteTag>> ShowTagListAsync()
        {
            var list = await LoadRemoteListAsync();
            //await list.ForEachAsync(async x =>
            //{
            //    await CreateAsync(x);
            //});
            list.ToList().ForEach(async entity =>
            {
                //entity.Id = null;
                //entity.Id = null;
                await _evernoteTagRepository.InsertAsync(entity);
            });
            return list.OrderBy(x => x.Guid).TakeLast(50);
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
