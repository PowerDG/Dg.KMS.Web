using Microsoft.AspNetCore.Mvc;

namespace Dg.Fifth.Web.Controllers
{
    public class HomeController : FifthControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}