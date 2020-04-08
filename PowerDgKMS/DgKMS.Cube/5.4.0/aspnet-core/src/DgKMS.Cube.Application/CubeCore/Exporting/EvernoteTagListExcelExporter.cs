
using System;
using System.Collections.Generic;
using Abp.Application.Services;
using L._52ABP.Application.Dtos;
using L._52ABP.Common.Extensions.Enums;

using DgKMS.Cube.DataExporting.Excel.Epplus;
using DgKMS.Cube.DataFileObjects.DataTempCache;
using DgKMS.Cube.CubeCore.Dtos;


namespace DgKMS.Cube.CubeCore.Exporting
{
    /// <summary>
    /// 的视图模型根据业务需要可以导出为Excel文件
    /// </summary>
	[RemoteService(IsEnabled = false)]
    public class EvernoteTagListExcelExporter : EpplusExcelExporterBase, IEvernoteTagListExcelExporter
    {       
        /// <summary>
        /// 构造函数，需要继承父类
        /// </summary>
        /// <param name="dataTempFileCacheManager"></param>
        public EvernoteTagListExcelExporter(IDataTempFileCacheManager dataTempFileCacheManager):base(dataTempFileCacheManager)
        {

        }
        public FileDto ExportToExcelFile(List<EvernoteTagListDto> evernoteTagListDtos)
        {

    var fileExportName = L("EvernoteTagList") + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";

            var excel =
                 CreateExcelPackage(fileExportName, excelpackage =>
               {
                   var sheet = excelpackage.Workbook.Worksheets.Add(L("EvernoteTags"));

                   sheet.OutLineApplyStyle = true;
			AddHeader(sheet,L("Id"),L("EvernoteTagGuid"),L("EvernoteTagName"),L("EvernoteTagParentGuid"),L("UpdateSequenceNum"),L("IsActive"),L("CreationTime"),L("LastModificationTime"));
            AddObject(sheet, 2, evernoteTagListDtos
             ,ex => ex.Id 
             ,ex => ex.Guid 
             ,ex => ex.Name 
             ,ex => ex.ParentGuid 
             ,ex => ex.UpdateSequenceNum 
             ,ex => ex.IsActive 
             ,ex => ex.CreationTime 
             ,ex => ex.LastModificationTime 
                   );
            sheet.Column(7).Style.Numberformat.Format = "yyyy-mm-dd";              

							//// custom codes
									
							

							//// custom codes end
	  });
    return excel;
        }
    }
}
