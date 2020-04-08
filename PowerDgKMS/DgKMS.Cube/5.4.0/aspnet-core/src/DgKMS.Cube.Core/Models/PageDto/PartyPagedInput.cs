using Abp.Runtime.Validation;

namespace PartyService.Host.Models.PageDto
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