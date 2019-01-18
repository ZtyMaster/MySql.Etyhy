using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MySql.ETyhy.Controllers
{
    public abstract class ETyhyControllerBase: AbpController
    {
        protected ETyhyControllerBase()
        {
            LocalizationSourceName = ETyhyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
