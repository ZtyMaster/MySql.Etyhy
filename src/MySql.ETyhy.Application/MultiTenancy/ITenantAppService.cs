using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MySql.ETyhy.MultiTenancy.Dto;

namespace MySql.ETyhy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

