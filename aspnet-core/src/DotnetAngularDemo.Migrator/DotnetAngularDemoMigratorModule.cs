using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotnetAngularDemo.Configuration;
using DotnetAngularDemo.EntityFrameworkCore;
using DotnetAngularDemo.Migrator.DependencyInjection;

namespace DotnetAngularDemo.Migrator
{
    [DependsOn(typeof(DotnetAngularDemoEntityFrameworkModule))]
    public class DotnetAngularDemoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DotnetAngularDemoMigratorModule(DotnetAngularDemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(DotnetAngularDemoMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                DotnetAngularDemoConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DotnetAngularDemoMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
