using Abp.Runtime.Validation;

namespace DgKMS.Cube.PageDto
{
    public class PartyPagedInput : PagedSortedAndFilteredInputDto, IGroupByRequest, IShouldNormalize
    {
        public string GroupText { get; set; }

        public string QueryType { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id desc";
            }
        }
    }
}