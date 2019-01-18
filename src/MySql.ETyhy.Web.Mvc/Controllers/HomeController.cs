using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MySql.ETyhy.Controllers;

namespace MySql.ETyhy.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ETyhyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
