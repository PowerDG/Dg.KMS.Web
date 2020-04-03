using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace dgPower.KMS.Controllers
{
    public abstract class KMSControllerBase: AbpController
    {
        protected KMSControllerBase()
        {
            LocalizationSourceName = KMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
