using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dg.fifth.Configuration.Dto;

namespace Dg.fifth.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : fifthAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
