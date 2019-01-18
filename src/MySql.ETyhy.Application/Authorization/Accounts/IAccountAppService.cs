using System.Threading.Tasks;
using Abp.Application.Services;
using MySql.ETyhy.Authorization.Accounts.Dto;

namespace MySql.ETyhy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
