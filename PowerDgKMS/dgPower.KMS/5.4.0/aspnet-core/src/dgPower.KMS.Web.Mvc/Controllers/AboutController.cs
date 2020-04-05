using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using dgPower.KMS.Controllers;

namespace dgPower.KMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : KMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
