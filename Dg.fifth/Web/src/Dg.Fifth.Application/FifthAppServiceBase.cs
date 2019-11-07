using Abp.Application.Services;

namespace Dg.Fifth
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class FifthAppServiceBase : ApplicationService
    {
        protected FifthAppServiceBase()
        {
            LocalizationSourceName = FifthConsts.LocalizationSourceName;
        }
    }
}