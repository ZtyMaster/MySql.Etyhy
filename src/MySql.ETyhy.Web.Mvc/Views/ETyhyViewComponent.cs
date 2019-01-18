using Abp.AspNetCore.Mvc.ViewComponents;

namespace MySql.ETyhy.Web.Views
{
    public abstract class ETyhyViewComponent : AbpViewComponent
    {
        protected ETyhyViewComponent()
        {
            LocalizationSourceName = ETyhyConsts.LocalizationSourceName;
        }
    }
}
