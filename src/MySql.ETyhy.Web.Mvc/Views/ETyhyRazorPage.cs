using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MySql.ETyhy.Web.Views
{
    public abstract class ETyhyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ETyhyRazorPage()
        {
            LocalizationSourceName = ETyhyConsts.LocalizationSourceName;
        }
    }
}
