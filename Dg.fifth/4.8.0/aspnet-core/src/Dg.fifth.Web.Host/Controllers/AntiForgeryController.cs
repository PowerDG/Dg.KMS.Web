using Microsoft.AspNetCore.Antiforgery;
using Dg.fifth.Controllers;

namespace Dg.fifth.Web.Host.Controllers
{
    public class AntiForgeryController : fifthControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
