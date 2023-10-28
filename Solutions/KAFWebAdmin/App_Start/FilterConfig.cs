using KAF.CustomFilters.Filters;
using System.Web;
using System.Web.Mvc;

namespace KAFWebAdmin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AllowCrossSiteJsonAttribute());
        }
    }
}
