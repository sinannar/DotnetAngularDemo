using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotnetAngularDemo.Configuration;

namespace DotnetAngularDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(DotnetAngularDemoWebCoreModule))]
    public class DotnetAngularDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DotnetAngularDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DotnetAngularDemoWebHostModule).GetAssembly());
        }
    }
}
