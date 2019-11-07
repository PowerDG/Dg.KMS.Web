using Abp.Application.Services.Dto;

namespace Dg.fifth.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

