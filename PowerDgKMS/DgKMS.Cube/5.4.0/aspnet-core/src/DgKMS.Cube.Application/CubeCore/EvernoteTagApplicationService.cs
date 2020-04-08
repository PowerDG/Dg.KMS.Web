
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using DgKMS.Cube.CubeCore;
using DgKMS.Cube.CubeCore.Dtos;
using DgKMS.Cube.CubeCore.Exporting;
using DgKMS.Cube.CubeCore.Domain;
using DgKMS.Cube.Authorization;

namespace DgKMS.Cube.CubeCore
{
    /// <summary>
    /// 应用层服务的接口实现方法
    ///</summary>
    [AbpAuthorize]
    public class EvernoteTagAppService : CubeAppServiceBase, IEvernoteTagAppService
    {
         private readonly IRepository<EvernoteTag, ulong>        _evernoteTagRepository;

 private readonly IEvernoteTagListExcelExporter _evernoteTagListExcelExporter;   

        private readonly IEvernoteTagManager _evernoteTagManager;
        /// <summary>
        /// 构造函数
        ///</summary>
        public EvernoteTagAppService(
		IRepository<EvernoteTag, ulong>  evernoteTagRepository
              ,IEvernoteTagManager evernoteTagManager       
,EvernoteTagListExcelExporter evernoteTagListExcelExporter
             )
            {
            _evernoteTagRepository = evernoteTagRepository;
             _evernoteTagManager=evernoteTagManager;;
_evernoteTagListExcelExporter = evernoteTagListExcelExporter;

            }


            /// <summary>
                /// 获取的分页列表信息
                ///      </summary>
            /// <param name="input"></param>
            /// <returns></returns>
            
            public async Task<PagedResultDto<EvernoteTagListDto>> GetPaged(GetEvernoteTagsInput input)
		{

		    var query = _evernoteTagRepository.GetAll()
                           
                            //模糊搜索Guid
                          .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.Guid.Contains(input.FilterText))                                                                                      
                            //模糊搜索Name
                          .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.Name.Contains(input.FilterText))                                                                                      
                            //模糊搜索ParentGuid
                          .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.ParentGuid.Contains(input.FilterText))                                                           
			;
			// TODO:根据传入的参数添加过滤条件

			var count = await query.CountAsync();

			var evernoteTagList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

		  var evernoteTagListDtos = ObjectMapper.Map<List<EvernoteTagListDto>>(evernoteTagList);

			return new PagedResultDto<EvernoteTagListDto>(count,evernoteTagListDtos);
		}


		/// <summary>
		/// 通过指定id获取EvernoteTagListDto信息
		/// </summary>
		
		public async Task<EvernoteTagListDto> GetById(EntityDto<ulong> input)
		{
			var entity = await _evernoteTagRepository.GetAsync(input.Id);

			var dto = ObjectMapper.Map<EvernoteTagListDto>(entity);
			return dto;
 		}

		/// <summary>
		/// 获取编辑 
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task<GetEvernoteTagForEditOutput> GetForEdit(NullableIdDto<ulong> input)
		{
			var output = new GetEvernoteTagForEditOutput();
EvernoteTagEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _evernoteTagRepository.GetAsync(input.Id.Value);
				editDto = ObjectMapper.Map<EvernoteTagEditDto>(entity);
			}
			else
			{
				editDto = new EvernoteTagEditDto();
			}
    


            output.EvernoteTag = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task CreateOrUpdate(CreateOrUpdateEvernoteTagInput input)
		{

			if (input.EvernoteTag.Id.HasValue)
			{
				await Update(input.EvernoteTag);
			}
			else
			{
				await Create(input.EvernoteTag);
			}
		}


		/// <summary>
		/// 新增
		/// </summary>
		
		protected virtual async Task<EvernoteTagEditDto> Create(EvernoteTagEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<EvernoteTag>(input);
            //调用领域服务
            entity = await _evernoteTagManager.CreateAsync(entity);

            var dto=ObjectMapper.Map<EvernoteTagEditDto>(entity);
            return dto;
		}

		/// <summary>
		/// 编辑
		/// </summary>
		
		protected virtual async Task Update(EvernoteTagEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

		 var entity = await _evernoteTagRepository.GetAsync(input.Id.Value);
          //  input.MapTo(entity);
          //将input属性的值赋值到entity中
             ObjectMapper.Map(input, entity);
            await _evernoteTagManager.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task Delete(EntityDto<ulong> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
            await _evernoteTagManager.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除EvernoteTag的方法
		/// </summary>
		
		public async Task BatchDelete(List<ulong> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
            await _evernoteTagManager.BatchDelete(input);
		}



		
		/// <summary>
		/// 导出为excel文件
		/// </summary>
		/// <returns></returns>
		
		//public async Task<FileDto> GetToExcelFile()
		//{
		//   var evernoteTags = await _evernoteTagManager.QueryEvernoteTags().ToListAsync();
  //          var evernoteTagListDtos = ObjectMapper.Map<List<EvernoteTagListDto>>(evernoteTags);
  //          return _evernoteTagListExcelExporter.ExportToExcelFile(evernoteTagListDtos);
		//}

		

							//// custom codes



							//// custom codes end

    }
}


