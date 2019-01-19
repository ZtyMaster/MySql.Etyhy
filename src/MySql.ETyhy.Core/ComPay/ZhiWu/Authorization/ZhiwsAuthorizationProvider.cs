

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using MySql.ETyhy.Authorization;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="ZhiwsPermissions" /> for all permission names. Zhiws
    ///</summary>
    public class ZhiwsAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public ZhiwsAuthorizationProvider()
		{

		}

        public ZhiwsAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public ZhiwsAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了Zhiws 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(ZhiwsPermissions.Node , L("Zhiws"));
			entityPermission.CreateChildPermission(ZhiwsPermissions.Query, L("QueryZhiws"));
			entityPermission.CreateChildPermission(ZhiwsPermissions.Create, L("CreateZhiws"));
			entityPermission.CreateChildPermission(ZhiwsPermissions.Edit, L("EditZhiws"));
			entityPermission.CreateChildPermission(ZhiwsPermissions.Delete, L("DeleteZhiws"));
			entityPermission.CreateChildPermission(ZhiwsPermissions.BatchDelete, L("BatchDeleteZhiws"));
			entityPermission.CreateChildPermission(ZhiwsPermissions.ExportExcel, L("ExportExcelZhiws"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ETyhyConsts.LocalizationSourceName);
		}
    }
}