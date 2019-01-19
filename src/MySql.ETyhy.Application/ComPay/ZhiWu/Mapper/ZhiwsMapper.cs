
using AutoMapper;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;
using MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.Mapper
{

	/// <summary>
    /// 配置Zhiws的AutoMapper
    /// </summary>
	internal static class ZhiwsMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Zhiws,ZhiwsListDto>();
            configuration.CreateMap <ZhiwsListDto,Zhiws>();

            configuration.CreateMap <ZhiwsEditDto,Zhiws>();
            configuration.CreateMap <Zhiws,ZhiwsEditDto>();

        }
	}
}
