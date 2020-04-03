using powerDg.KMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace powerDg.KMS.Controllers
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