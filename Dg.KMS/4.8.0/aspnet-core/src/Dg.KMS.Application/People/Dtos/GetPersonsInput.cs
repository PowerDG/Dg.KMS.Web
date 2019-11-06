
using Abp.Runtime.Validation;
using Dg.KMS.Dtos;
using Dg.KMS.People;

namespace Dg.KMS.People.Dtos
{
    public class GetPersonsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
