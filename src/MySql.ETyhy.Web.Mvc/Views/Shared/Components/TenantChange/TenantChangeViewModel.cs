using Abp.AutoMapper;
using MySql.ETyhy.Sessions.Dto;

namespace MySql.ETyhy.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
