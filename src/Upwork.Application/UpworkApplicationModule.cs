using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Upwork.Authorization;

namespace Upwork
{
    [DependsOn(
        typeof(UpworkCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UpworkApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UpworkAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UpworkApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
