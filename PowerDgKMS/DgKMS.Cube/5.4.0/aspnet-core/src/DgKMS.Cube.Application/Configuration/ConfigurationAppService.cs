using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DgKMS.Cube.Configuration.Dto;

namespace DgKMS.Cube.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CubeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
