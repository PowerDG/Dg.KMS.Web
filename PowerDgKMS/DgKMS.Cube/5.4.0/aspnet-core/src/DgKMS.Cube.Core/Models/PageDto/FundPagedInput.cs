using Abp.Runtime.Validation;
using System;

namespace DgKMS.Cube.PageDto
{
    public class FundPagedInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {
        public string QueryType { get; set; }

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (QueryType != null && QueryType.Equals("CurrentYear", StringComparison.OrdinalIgnoreCase))
            {
                FilterText = $" InsertTime >= \"{new DateTime(DateTime.Now.Year, 1, 1)}\"";
            }
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id desc";
            }
        }
    }
}