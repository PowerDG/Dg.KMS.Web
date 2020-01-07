using Abp.Collections;

namespace DgInitEFCore.Configuration.Startup
{
    /// <summary>
    /// Used to configure setting system.
    /// </summary>
    public interface ISettingsConfiguration
    {
        /// <summary>
        /// List of settings providers.
        /// </summary>
        ITypeList<SettingProvider> Providers { get; }
    }
}
