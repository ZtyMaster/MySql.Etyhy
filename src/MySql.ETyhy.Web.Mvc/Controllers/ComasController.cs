using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.ETyhy.Authorization;
using MySql.ETyhy.ComPay;
using MySql.ETyhy.ComPay.Dtos;
using MySql.ETyhy.Controllers;

namespace MySql.ETyhy.Web.Mvc.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Comas)]
    public class ComasController : ETyhyControllerBase
    {
        private readonly IComasAppService  _comasapp;

        public ComasController(IComasAppService AppService)
        {
            _comasapp = AppService;
        }
        public async Task<IActionResult> Index(GetComassInput pt)
        {
            var dot = await _comasapp.GetPaged(pt);
            return View(dot);
        }
       
    }
}