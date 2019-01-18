using System.Threading.Tasks;
using Abp.Application.Services;
using MySql.ETyhy.Sessions.Dto;

namespace MySql.ETyhy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
