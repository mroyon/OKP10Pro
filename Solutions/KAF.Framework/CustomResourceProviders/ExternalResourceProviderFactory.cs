using System;
using System.Web.Compilation;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using KAF.WebFramework;

namespace CustomResourceProviders
{

    /// <summary>
    /// Provider factory implementation for external resources. Only supports
    /// global resources. 
    /// </summary>
    public class ExternalResourceProviderFactory : ResourceProviderFactory
    {
        /// <summary>   When overridden in a derived class, creates a global resource provider. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="CreateGlobalResourceProvider" type="IResourceProvider">    CreateGlobalResourceProvider. </method>
        /// <param name="classKey" type="string"> The name of the resource class. </param>
        /// <returns>   A global resource provider. </returns>

        public override IResourceProvider CreateGlobalResourceProvider(string classKey)
        {
            Debug.WriteLine(String.Format(CultureInfo.InvariantCulture, "ExternalResourceProviderFactory.CreateGlobalResourceProvider({0})", classKey));

            return new GlobalExternalResourceProvider(classKey);
        }

        /// <summary>   When overridden in a derived class, creates a local resource provider. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="CreateLocalResourceProvider" type="IResourceProvider"> CreateLocalResourceProvider. </method>
        /// <exception cref="NotSupportedException">    Thrown when the requested operation is not
        ///                                             supported. </exception>
        /// <param name="virtualPath" type="string">  The path to a resource file. </param>
        /// <returns>   A local resource provider. </returns>

        public override IResourceProvider CreateLocalResourceProvider(string virtualPath)
        {
            throw new NotSupportedException(String.Format(Thread.CurrentThread.CurrentUICulture, KAF.WebFramework.Properties.Resources.Provider_LocalResourcesNotSupported, "ExternalResourceProviderFactory"));
        }
    }
}