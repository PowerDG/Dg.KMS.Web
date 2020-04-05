using Volo.Abp.Settings;

namespace powerDg.KMS.Settings
{
    public class KMSSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(KMSSettings.MySetting1));
        }
    }
}
