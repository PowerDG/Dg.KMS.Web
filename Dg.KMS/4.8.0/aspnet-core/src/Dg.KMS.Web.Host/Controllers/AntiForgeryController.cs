using Microsoft.AspNetCore.Antiforgery;
using Dg.KMS.Controllers;

namespace Dg.KMS.Web.Host.Controllers
{
    public class AntiForgeryController : KMSControllerBase
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
