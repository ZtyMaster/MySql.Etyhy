using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MySql.ETyhy.Authorization;

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
