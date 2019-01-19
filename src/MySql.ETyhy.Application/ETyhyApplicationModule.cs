using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MySql.ETyhy.Authorization;
using MySql.ETyhy.Bumen.Authorization;
using MySql.ETyhy.Bumen.Mapper;
using MySql.ETyhy.ComPay.Authorization;
using MySql.ETyhy.ComPay.Bumen.ZhiWu.Authorization;
using MySql.ETyhy.ComPay.Bumen.ZhiWu.Mapper;
using MySql.ETyhy.ComPay.Mapper;

namespace MySql.ETyhy
{
    [DependsOn(
        typeof(ETyhyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ETyhyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ETyhyAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
             
                // 只需要复制这一段
                ComasMapper.CreateMappings(configuration);
                BuMensMapper.CreateMappings(configuration);
                ZhiwsMapper.CreateMappings(configuration);

            });

            Configuration.Authorization.Providers.Add<ComasAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<BuMensAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<ZhiwsAuthorizationProvider>();

        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ETyhyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
