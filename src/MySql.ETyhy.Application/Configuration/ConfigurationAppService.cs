using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MySql.ETyhy.Configuration.Dto;

namespace MySql.ETyhy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ETyhyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
