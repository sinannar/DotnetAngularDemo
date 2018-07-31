using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DotnetAngularDemo.Configuration;
using DotnetAngularDemo.Web;

namespace DotnetAngularDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DotnetAngularDemoDbContextFactory : IDesignTimeDbContextFactory<DotnetAngularDemoDbContext>
    {
        public DotnetAngularDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DotnetAngularDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DotnetAngularDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DotnetAngularDemoConsts.ConnectionStringName));

            return new DotnetAngularDemoDbContext(builder.Options);
        }
    }
}
