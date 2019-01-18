using System.Threading.Tasks;
using MySql.ETyhy.Configuration.Dto;

namespace MySql.ETyhy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
