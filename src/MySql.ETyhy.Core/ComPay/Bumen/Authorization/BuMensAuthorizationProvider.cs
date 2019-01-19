

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using MySql.ETyhy.Authorization;

namespace MySql.ETyhy.Bumen.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="BuMensPermissions" /> for all permission names. BuMens
    ///</summary>
    public class BuMensAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public BuMensAuthorizationProvider()
		{

		}

        public BuMensAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public BuMensAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了BuMens 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(BuMensPermissions.Node , L("BuMens"));
			entityPermission.CreateChildPermission(BuMensPermissions.Query, L("QueryBuMens"));
			entityPermission.CreateChildPermission(BuMensPermissions.Create, L("CreateBuMens"));
			entityPermission.CreateChildPermission(BuMensPermissions.Edit, L("EditBuMens"));
			entityPermission.CreateChildPermission(BuMensPermissions.Delete, L("DeleteBuMens"));
			entityPermission.CreateChildPermission(BuMensPermissions.BatchDelete, L("BatchDeleteBuMens"));
			entityPermission.CreateChildPermission(BuMensPermissions.ExportExcel, L("ExportExcelBuMens"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ETyhyConsts.LocalizationSourceName);
		}
    }
}