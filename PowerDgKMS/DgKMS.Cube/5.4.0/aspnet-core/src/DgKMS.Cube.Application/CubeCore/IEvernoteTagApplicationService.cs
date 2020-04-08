
using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using L._52ABP.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using DgKMS.Cube.CubeCore.Dtos;
using DgKMS.Cube.CubeCore;



namespace DgKMS.Cube.CubeCore
{
    /// <summary>
    /// 应用层服务的接口方法
    ///</summary>
    public interface IEvernoteTagAppService : IApplicationService
    {
        /// <summary>
		/// 获取的分页列表集合
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<EvernoteTagListDto>> GetPaged(GetEvernoteTagsInput input);


		/// <summary>
		/// 通过指定id获取ListDto信息
		/// </summary>
		Task<EvernoteTagListDto> GetById(EntityDto<ulong> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetEvernoteTagForEditOutput> GetForEdit(NullableIdDto<ulong> input);


        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateEvernoteTagInput input);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<ulong> input);

		
        /// <summary>
        /// 批量删除
        /// </summary>
        Task BatchDelete(List<ulong> input);


		
		
		/// <summary>
		/// 导出为excel文件
		/// </summary>
		/// <returns></returns>
		Task<FileDto> GetToExcelFile();
		
		
		
		
							//// custom codes
									
							

							//// custom codes end
    }
}
