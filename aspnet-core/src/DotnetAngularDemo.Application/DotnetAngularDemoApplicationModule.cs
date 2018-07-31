using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotnetAngularDemo.Authorization;

namespace DotnetAngularDemo
{
    [DependsOn(
        typeof(DotnetAngularDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DotnetAngularDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DotnetAngularDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DotnetAngularDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
