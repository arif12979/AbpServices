using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Upwork.EntityFrameworkCore;
using Upwork.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Upwork.Web.Tests
{
    [DependsOn(
        typeof(UpworkWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class UpworkWebTestModule : AbpModule
    {
        public UpworkWebTestModule(UpworkEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UpworkWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(UpworkWebMvcModule).Assembly);
        }
    }
}