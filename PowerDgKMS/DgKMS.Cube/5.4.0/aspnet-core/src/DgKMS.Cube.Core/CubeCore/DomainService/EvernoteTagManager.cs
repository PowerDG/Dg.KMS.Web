

using Abp.Domain.Repositories;
using Abp.Domain.Services;
using dgEvernote.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DgKMS.Cube.CubeCore.Domain
{
    /// <summary>
    /// 领域服务层一个模块的核心业务逻辑
    ///</summary>
    public class EvernoteTagManager :  IEvernoteTagManager
    {
		
		private readonly IRepository<EvernoteTag, int> _evernoteTagRepository;

		/// <summary>
		/// EvernoteTag的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public EvernoteTagManager(IRepository<EvernoteTag, int> evernoteTagRepository)	{
			_evernoteTagRepository =  evernoteTagRepository;
		}


        #region MyRegion
        public async Task<IEnumerable<EvernoteTag>> LoadAndShowListAsync()
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


        public async Task<IEnumerable<EvernoteTag>> LoadRemoteListAsync( )
        {
            var remoteList = NoteManager.GetListTags();
            //entity.Id = await _evernoteTagRepository.InsertAndGetIdAsync(entity);
            var tagList = new List<EvernoteTag>();
            if (remoteList.Any())
            {
                //tagList= remoteList.ToList().Select
                //tagList = remoteList.ToList().ForEach(x =>
                // {

                // });

                var query = from m in remoteList
                            select new EvernoteTag
                            {
                                Guid = m.Guid,
                                Name = m.Name,
                                ParentGuid = m.ParentGuid,
                                UpdateSequenceNum = m.UpdateSequenceNum
                            };
                var result = query.ToList() as ICollection<EvernoteTag>;
                return result;
            }
            return tagList;
        }
        #endregion

        #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<EvernoteTag> QueryEvernoteTags()
        {
            return _evernoteTagRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<EvernoteTag> QueryEvernoteTagsAsNoTracking()
        {
            return _evernoteTagRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<EvernoteTag> FindByIdAsync(int id)
        {
            var entity = await _evernoteTagRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(int id)
        {
            var result = await _evernoteTagRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<EvernoteTag> CreateAsync(EvernoteTag entity)
        {
            entity.Id = await _evernoteTagRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(EvernoteTag entity)
        {
            await _evernoteTagRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _evernoteTagRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task BatchDelete(List<int> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _evernoteTagRepository.DeleteAsync(a => input.Contains(a.Id));
        }
	 
			
							//// custom codes
									
							

							//// custom codes end



		 
		  
		 

	}
}
