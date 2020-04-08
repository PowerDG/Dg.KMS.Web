
using System.Collections.Generic;
using L._52ABP.Application.Dtos;
using DgKMS.Cube.CubeCore.Dtos;

namespace DgKMS.Cube.CubeCore.Exporting
{
    public interface IEvernoteTagListExcelExporter
    {
        /// <summary>
        /// 导出为Excel文件
        /// </summary>
        /// <param name="evernoteTagListDtos">传入的数据集合</param>
        /// <returns></returns>
        FileDto ExportToExcelFile(List<EvernoteTagListDto> evernoteTagListDtos);

		
							//// custom codes
									
							

							//// custom codes end
    }
}