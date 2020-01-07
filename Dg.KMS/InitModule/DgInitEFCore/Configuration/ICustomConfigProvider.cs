using System.Collections.Generic;

namespace DgInitEFCore.Configuration.Startup
{
    public interface ICustomConfigProvider
    {
        Dictionary<string, object> GetConfig(CustomConfigProviderContext customConfigProviderContext);
    }
}
