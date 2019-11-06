﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dg.KMS.Configuration.Dto;

namespace Dg.KMS.Configuration
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
