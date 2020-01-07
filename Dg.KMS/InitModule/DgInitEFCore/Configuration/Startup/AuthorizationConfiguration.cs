using Abp.Authorization;
using Abp.Collections;

namespace DgInitEFCore.Configuration.Startup
{
    internal class AuthorizationConfiguration : IAuthorizationConfiguration
    {
        public ITypeList<AuthorizationProvider> Providers { get; }

        public bool IsEnabled { get; set; }

        public AuthorizationConfiguration()
        {
            Providers = new TypeList<AuthorizationProvider>();
            IsEnabled = true;
        }
    }
}