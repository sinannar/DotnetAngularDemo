using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DotnetAngularDemo.Localization
{
    public static class DotnetAngularDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DotnetAngularDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DotnetAngularDemoLocalizationConfigurer).GetAssembly(),
                        "DotnetAngularDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
