using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MySql.ETyhy.Localization
{
    public static class ETyhyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ETyhyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ETyhyLocalizationConfigurer).GetAssembly(),
                        "MySql.ETyhy.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
