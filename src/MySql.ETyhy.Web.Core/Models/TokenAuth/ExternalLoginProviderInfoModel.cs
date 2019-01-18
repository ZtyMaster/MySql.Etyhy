using Abp.AutoMapper;
using MySql.ETyhy.Authentication.External;

namespace MySql.ETyhy.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
