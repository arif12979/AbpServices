using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Upwork.Configuration;
using Upwork.Web;

namespace Upwork.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class UpworkDbContextFactory : IDesignTimeDbContextFactory<UpworkDbContext>
    {
        public UpworkDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UpworkDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            UpworkDbContextConfigurer.Configure(builder, configuration.GetConnectionString(UpworkConsts.ConnectionStringName));

            return new UpworkDbContext(builder.Options);
        }
    }
}
