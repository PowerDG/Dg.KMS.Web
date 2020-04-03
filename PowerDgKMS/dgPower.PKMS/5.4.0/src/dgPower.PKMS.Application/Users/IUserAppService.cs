using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using dgPower.PKMS.Roles.Dto;
using dgPower.PKMS.Users.Dto;

namespace dgPower.PKMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
