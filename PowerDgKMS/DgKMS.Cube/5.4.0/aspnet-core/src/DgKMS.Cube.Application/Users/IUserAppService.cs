using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DgKMS.Cube.Roles.Dto;
using DgKMS.Cube.Users.Dto;

namespace DgKMS.Cube.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
