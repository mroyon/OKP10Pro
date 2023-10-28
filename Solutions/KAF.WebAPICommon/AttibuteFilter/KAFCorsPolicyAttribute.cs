using KAF.WebAPICommon.HelperClass;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Cors;

namespace KAF.WebAPICommon.AttibuteFilter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]

    public class KAFCorsPolicyAttribute : Attribute, ICorsPolicyProvider
    {
        const string defaultKey = "cors:Origins";
        private readonly string rawOrigins;
        private CorsPolicy corsPolicy;


        /// <summary>
        /// By default uses "cors:AllowedOrigins" AppSetting key
        /// </summary>
        public KAFCorsPolicyAttribute() : this(defaultKey) // Use default AppSetting key
        {
        }

        /// <summary>
        /// Enables Cross Origin
        /// </summary>
        /// <param name="appSettingKey">AppSetting key that defines valid origins</param>
        public KAFCorsPolicyAttribute(string appSettingKey)
        {
            // Collect comma separated origins
            this.rawOrigins = ConfigurationManager.AppSettings[appSettingKey];
            this.BuildCorsPolicy();
        }

        /// <summary>
        /// Build Cors policy
        /// </summary>
        private void BuildCorsPolicy()
        {
            bool allowAnyHeader = String.IsNullOrEmpty(this.Headers) || this.Headers == "*";
            bool allowAnyMethod = String.IsNullOrEmpty(this.Methods) || this.Methods == "*";

            this.corsPolicy = new CorsPolicy
            {
                AllowAnyHeader = allowAnyHeader,
                AllowAnyMethod = allowAnyMethod,
                AllowAnyOrigin = false
            };

            // Add origins from app setting value
            this.corsPolicy.Origins.AddCommaSeperatedValues(this.rawOrigins);
            this.corsPolicy.Headers.AddCommaSeperatedValues(this.Headers);
            this.corsPolicy.Methods.AddCommaSeperatedValues(this.Methods);
        }

        public string Headers { get; set; }
        public string Methods { get; set; }


        public Task<CorsPolicy> GetCorsPolicyAsync(IOwinRequest request)
        {
            return Task.FromResult(this.corsPolicy);
        }
    }
}