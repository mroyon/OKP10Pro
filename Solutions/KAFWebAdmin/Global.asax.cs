using KAF.CustomHelper.HelperClasses;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KAFWebAdmin
{ 
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Error(object sender, EventArgs e)
        {
            string msg = e.ToString();
            try
            {
                //ronty
            }
            catch (Exception ex)
            {
                string ms = ex.Message;
            }
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log4net.Config.XmlConfigurator.Configure();


            clsDataCache.LoadDataCache();
        }
    }
}
