using System.Collections.Generic;
using System.Collections.Immutable;
//using Abp.Configuration.Startup;
//using Abp.Dependency;
using DgInitEFCore.Application;
using DgInitEFCore.Configuration.Startup;

namespace Abp.Localization
{
    public class DefaultLanguageProvider : ILanguageProvider, ITransientDependency
    {
        private readonly ILocalizationConfiguration _configuration;

        public DefaultLanguageProvider(ILocalizationConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IReadOnlyList<LanguageInfo> GetLanguages()
        {
            return _configuration.Languages.ToImmutableList();
        }
    }
}