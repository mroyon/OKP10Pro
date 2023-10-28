using System;
using System.Configuration;
using System.Xml;


namespace KAF.AppConfiguration.Configuration
{
    public sealed class ConfigurationSectionHandler : IConfigurationSectionHandler
    {
        public const string SectionName = "dataAccessFactoryConfiguration";
        /// <summary>
        /// IConfigurationSectionHandler.Create
        /// </summary>
        /// <method name="IConfigurationSectionHandler.Create" type="object"></method>
        /// <param name="parent" type="object"></param>
        /// <param name="configContext" type="object"></param>
        /// <param name="section" type="XmlNode"></param>
        /// <returns></returns>
        object IConfigurationSectionHandler.Create(object parent,
        object configContext,
        XmlNode section)
        {
            if (section.ChildNodes.Count == 0)
            {
                throw new ConfigurationErrorsException("Please specify the dataAccessFactoryConfiguration.", section);
            }

            string typeName = null;
            string assemblyName = null;

            foreach (XmlNode xndChild in section.ChildNodes)
            {
                if (StringHelper.IsEqual(xndChild.LocalName, "DataAccessFactory"))
                {
                    typeName = GetAttributeValue(xndChild.Attributes["typeName"]);
                    assemblyName = GetAttributeValue(xndChild.Attributes["assemblyName"]);

                    if (!StringHelper.IsBlank(typeName) && !StringHelper.IsBlank(assemblyName))
                    {
                        break;
                    }
                }
            }

            if (StringHelper.IsBlank(typeName) || StringHelper.IsBlank(assemblyName))
            {
                throw new ConfigurationErrorsException("Please specify the data access factory.", section);
            }

            return new TypeInfo(typeName, assemblyName);
        }
        ///sasdfsadf
        //[System.Diagnostics.DebuggerStepThrough()]
        /// <summary>
        /// Get Attribute Value
        /// </summary>
        /// <method name="GetAttributeValue" type="string"></method>
        /// <param name="attribute" type="XmlNode"></param>
        /// <returns>string</returns>
        /// <remarks>Get Attribute Value</remarks>
        private static string GetAttributeValue(XmlNode attribute)
        {
            try
            {
                return attribute.Value.Trim();
            }
            catch (NullReferenceException)
            {
            }

            return string.Empty;
        }
    }
}
