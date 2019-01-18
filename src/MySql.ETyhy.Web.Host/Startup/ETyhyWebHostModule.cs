using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MySql.ETyhy.Configuration;

namespace MySql.ETyhy.Web.Host.Startup
{
    [DependsOn(
       typeof(ETyhyWebCoreModule))]
    public class ETyhyWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ETyhyWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ETyhyWebHostModule).GetAssembly());
        }
    }
}
