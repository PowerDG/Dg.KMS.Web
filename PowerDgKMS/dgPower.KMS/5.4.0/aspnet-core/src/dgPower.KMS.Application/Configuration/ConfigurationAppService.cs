using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using dgPower.KMS.Configuration.Dto;

namespace dgPower.KMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
