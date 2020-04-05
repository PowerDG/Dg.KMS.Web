using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using dgPower.PKMS.Configuration.Dto;

namespace dgPower.PKMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PKMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
