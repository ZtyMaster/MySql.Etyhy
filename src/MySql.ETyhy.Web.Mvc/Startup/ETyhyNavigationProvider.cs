using Abp.Application.Navigation;
using Abp.Localization;
using MySql.ETyhy.Authorization;

namespace MySql.ETyhy.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class ETyhyNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                  new MenuItemDefinition(
                        "AdminMenu",
                        L("AdminMenu"),
                        icon: "menu"
                      ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                ).AddItem(
                      new MenuItemDefinition(
                          PageNames.Comas,
                          L("Comas"),
                          url:"Comas",
                          icon: "business",
                          requiredPermissionName:PermissionNames.Pages_Comas)
                      ).AddItem(
                      new MenuItemDefinition(
                          PageNames.BuMens,
                          L("BuMens"),
                          url: "BuMens",
                          icon: "poll",
                          requiredPermissionName: PermissionNames.Pages_BuMens)
                      ).AddItem(
                      new MenuItemDefinition(
                          PageNames.Zhiwus,
                          L("Zhiws"),
                          url: "Zhiws",
                          icon: "label",
                          requiredPermissionName: PermissionNames.Pages_Zhiws)
                      ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info"
                    )
                )
                );
                //.AddItem(
                //    new MenuItemDefinition(
                //        PageNames.Tenants,
                //        L("Tenants"),
                //        url: "Tenants",
                //        icon: "business",
                //        requiredPermissionName: PermissionNames.Pages_Tenants
                //    )
                //)
               
                
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ETyhyConsts.LocalizationSourceName);
        }
    }
}
