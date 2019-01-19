

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using MySql.ETyhy.Authorization;

namespace MySql.ETyhy.ComPay.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="ComasPermissions" /> for all permission names. Comas
    ///</summary>
    public class ComasAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public ComasAuthorizationProvider()
		{

		}

        public ComasAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public ComasAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了Comas 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(ComasPermissions.Node , L("Comas"));
			entityPermission.CreateChildPermission(ComasPermissions.Query, L("QueryComas"));
			entityPermission.CreateChildPermission(ComasPermissions.Create, L("CreateComas"));
			entityPermission.CreateChildPermission(ComasPermissions.Edit, L("EditComas"));
			entityPermission.CreateChildPermission(ComasPermissions.Delete, L("DeleteComas"));
			entityPermission.CreateChildPermission(ComasPermissions.BatchDelete, L("BatchDeleteComas"));
			entityPermission.CreateChildPermission(ComasPermissions.ExportExcel, L("ExportExcelComas"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ETyhyConsts.LocalizationSourceName);
		}
    }
}