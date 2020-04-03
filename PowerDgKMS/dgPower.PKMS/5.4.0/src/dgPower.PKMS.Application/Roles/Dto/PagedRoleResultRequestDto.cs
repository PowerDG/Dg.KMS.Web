using Abp.Application.Services.Dto;

namespace dgPower.PKMS.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

