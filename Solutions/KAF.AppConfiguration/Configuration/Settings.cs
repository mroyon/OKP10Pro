using System.Configuration;


namespace KAF.AppConfiguration.Configuration
{
    public static class Settings
    {
        public static TypeInfo TypeInfo
        {
            [System.Diagnostics.DebuggerStepThrough()]
            get
            {
                return ConfigurationManager.GetSection(ConfigurationSectionHandler.SectionName) as TypeInfo;
            }
        }
    }
}
