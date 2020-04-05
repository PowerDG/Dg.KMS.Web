using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DgKMS.Cube.Controllers
{
    public abstract class CubeControllerBase: AbpController
    {
        protected CubeControllerBase()
        {
            LocalizationSourceName = CubeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
