
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Services;


namespace DgKMS.Cube.CubeCore.Domain
{
    public interface IEvernoteTagManager : IDomainService
    {

		Task<IEnumerable<EvernoteTag>> LoadRemoteListAsync();
		Task<IEnumerable<EvernoteTag>> LoadAndShowListAsync();
		/// <summary>
		/// 返回表达式数的实体信息即IQueryable类型
		/// </summary>
		/// <returns></returns>
		IQueryable<EvernoteTag> QueryEvernoteTags();

		/// <summary>
		/// 返回性能更好的IQueryable类型，但不包含EF Core跟踪标记
		/// </summary>
		/// <returns></returns>

		IQueryable<EvernoteTag> QueryEvernoteTagsAsNoTracking();

		/// <summary>
		/// 根据Id查询实体信息
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<EvernoteTag> FindByIdAsync(int id);
	
		/// <summary>
		/// 检查实体是否存在
		/// </summary>
		/// <returns></returns>
		Task<bool> IsExistAsync(int id);


		/// <summary>
		/// 添加
		/// </summary>
		/// <param name="entity">实体</param>
		/// <returns></returns>
		Task<EvernoteTag> CreateAsync(EvernoteTag entity);

		/// <summary>
		/// 修改
		/// </summary>
		/// <param name="entity">实体</param>
		/// <returns></returns>
		Task UpdateAsync(EvernoteTag entity);

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task DeleteAsync(int id);
		/// <summary>
		/// 批量删除
		/// </summary>
		/// <param name="input">Id的集合</param>
		/// <returns></returns>
		Task BatchDelete(List<int> input);
		



		//// custom codes



		//// custom codes end





	}
}
