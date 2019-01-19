
using AutoMapper;
using MySql.ETyhy.ComPay;
using MySql.ETyhy.ComPay.Dtos;

namespace MySql.ETyhy.ComPay.Mapper
{

	/// <summary>
    /// 配置Comas的AutoMapper
    /// </summary>
	internal static class ComasMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Comas,ComasListDto>();
            configuration.CreateMap <ComasListDto,Comas>();

            configuration.CreateMap <ComasEditDto,Comas>();
            configuration.CreateMap <Comas,ComasEditDto>();

        }
	}
}
