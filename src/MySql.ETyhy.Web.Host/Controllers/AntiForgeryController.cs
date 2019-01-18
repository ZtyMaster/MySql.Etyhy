using Microsoft.AspNetCore.Antiforgery;
using MySql.ETyhy.Controllers;

namespace MySql.ETyhy.Web.Host.Controllers
{
    public class AntiForgeryController : ETyhyControllerBase
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
