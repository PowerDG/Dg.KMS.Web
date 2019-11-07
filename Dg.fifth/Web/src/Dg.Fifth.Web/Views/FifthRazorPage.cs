using Abp.AspNetCore.Mvc.Views;

namespace Dg.Fifth.Web.Views
{
    public abstract class FifthRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FifthRazorPage()
        {
            LocalizationSourceName = FifthConsts.LocalizationSourceName;
        }
    }
}
