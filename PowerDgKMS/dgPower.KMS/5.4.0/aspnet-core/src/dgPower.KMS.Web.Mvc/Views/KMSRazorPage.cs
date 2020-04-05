using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace dgPower.KMS.Web.Views
{
    public abstract class KMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected KMSRazorPage()
        {
            LocalizationSourceName = KMSConsts.LocalizationSourceName;
        }
    }
}
