using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Upwork.Configuration;

namespace Upwork.Web.Host.Startup
{
    [DependsOn(
       typeof(UpworkWebCoreModule))]
    public class UpworkWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UpworkWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UpworkWebHostModule).GetAssembly());
        }
    }
}
