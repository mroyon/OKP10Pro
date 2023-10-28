using System;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http;
using KAF.WebAPICommon;
using KAF.WebAPICommon.HelperClass;
using KAF.WebAPICommon.Provider;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using WebApi.OutputCache.V2;

[assembly: OwinStartup(typeof(KAFWebAPIServices.Startup))]

namespace KAFWebAPIServices
{
    public partial class Startup
    {
        public object AppSettingsConfig { get; private set; }


        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            ConfigureAuth(app, config);

            CorsOptions corsOptions = new CorsOptions();
            app.Map("/api", map =>
            {
                CorsPolicy corsPolicy = new CorsPolicy()
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true
                };
                string[] origins = System.Configuration.ConfigurationManager.AppSettings["cors:Origins"].ToString().Split(',');
                foreach (string origin in origins)
                {
                    corsPolicy.Origins.Add(origin);
                }
                corsOptions = new CorsOptions
                {
                    PolicyProvider = new CorsPolicyProvider
                    {
                        PolicyResolver = context => Task.FromResult(corsPolicy)
                    }
                };
                map.UseCors(corsOptions);
            });

            app.UseCors(corsOptions);
            app.UseWebApi(config);


            WebApiConfig.Register(config);
            SwaggerConfig.Register(config);

            GlobalConfiguration.Configure(WebApiConfig.Register);

           

            
        }


    }
}
