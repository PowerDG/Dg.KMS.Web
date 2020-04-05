using System;
using System.Collections.Generic;
using System.Text;
using powerDg.KMS.Localization;
using Volo.Abp.Application.Services;

namespace powerDg.KMS
{
    /* Inherit your application services from this class.
     */
    public abstract class KMSAppService : ApplicationService
    {
        protected KMSAppService()
        {
            LocalizationResource = typeof(KMSResource);
        }
    }
}
