using Abp.Application.Services.Dto;

namespace DgKMS.Cube.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

