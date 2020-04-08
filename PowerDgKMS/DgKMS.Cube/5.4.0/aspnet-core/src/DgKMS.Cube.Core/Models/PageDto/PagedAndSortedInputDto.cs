using Abp.Application.Services.Dto;

namespace DgKMS.Cube.PageDto
{
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; }
    }
}