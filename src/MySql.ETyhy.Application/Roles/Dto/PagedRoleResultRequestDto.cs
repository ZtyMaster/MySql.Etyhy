using Abp.Application.Services.Dto;

namespace MySql.ETyhy.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

