using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace dgPower.PKMS.Controllers
{
    public abstract class PKMSControllerBase: AbpController
    {
        protected PKMSControllerBase()
        {
            LocalizationSourceName = PKMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
