using powerDg.M.KMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace powerDg.M.KMS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class KMSController : AbpController
    {
        protected KMSController()
        {
            LocalizationResource = typeof(KMSResource);
        }
    }
}