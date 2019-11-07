using Abp.AspNetCore.Mvc.Controllers;

namespace Dg.Fifth.Web.Controllers
{
    public abstract class FifthControllerBase: AbpController
    {
        protected FifthControllerBase()
        {
            LocalizationSourceName = FifthConsts.LocalizationSourceName;
        }
    }
}