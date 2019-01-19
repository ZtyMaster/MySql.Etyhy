
using AutoMapper;
using MySql.ETyhy.Bumen;
using MySql.ETyhy.Bumen.Dtos;

namespace MySql.ETyhy.Bumen.Mapper
{

	/// <summary>
    /// 配置BuMens的AutoMapper
    /// </summary>
	internal static class BuMensMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <BuMens,BuMensListDto>();
            configuration.CreateMap <BuMensListDto,BuMens>();

            configuration.CreateMap <BuMensEditDto,BuMens>();
            configuration.CreateMap <BuMens,BuMensEditDto>();

        }
	}
}
