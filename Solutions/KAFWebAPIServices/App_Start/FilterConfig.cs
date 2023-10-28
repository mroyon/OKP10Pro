using KAF.WebAPICommon.Filter;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace KAFWebAPIServices
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            GlobalConfiguration.Configuration.Filters.Add(new ExceptionFilter());
        }
    }
}
