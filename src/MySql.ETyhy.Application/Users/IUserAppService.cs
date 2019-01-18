using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MySql.ETyhy.Roles.Dto;
using MySql.ETyhy.Users.Dto;

namespace MySql.ETyhy.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
