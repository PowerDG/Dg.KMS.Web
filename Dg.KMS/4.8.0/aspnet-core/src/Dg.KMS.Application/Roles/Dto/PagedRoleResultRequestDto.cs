using Abp.Application.Services.Dto;

namespace Dg.KMS.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

