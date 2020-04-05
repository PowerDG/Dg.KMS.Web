using Abp.AspNetCore.Mvc.ViewComponents;

namespace dgPower.KMS.Web.Views
{
    public abstract class KMSViewComponent : AbpViewComponent
    {
        protected KMSViewComponent()
        {
            LocalizationSourceName = KMSConsts.LocalizationSourceName;
        }
    }
}
