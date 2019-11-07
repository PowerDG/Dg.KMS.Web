using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dg.fifth.Controllers
{
    public abstract class fifthControllerBase: AbpController
    {
        protected fifthControllerBase()
        {
            LocalizationSourceName = fifthConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
