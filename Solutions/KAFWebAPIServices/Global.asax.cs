using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KAFWebAPIServices
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //var fileInfo = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "Log4Net.config");
            //if (fileInfo.Exists)
            //    log4net.Config.XmlConfigurator.Configure(fileInfo);
            //else
            //    throw new InvalidOperationException("No log config file found");


            
            // GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);


        }

        //protected void Application_BeginRequest()
        //{
        //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        //}
    }
}
