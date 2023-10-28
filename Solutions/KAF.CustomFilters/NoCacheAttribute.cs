using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KAF.CustomFilters.Filters
{
    public class NoCacheAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var cache = GetCache(filterContext);

            cache.SetExpires(DateTime.UtcNow.AddDays(-1));
            cache.SetValidUntilExpires(false);
            cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
            cache.SetCacheability(HttpCacheability.NoCache);
            cache.SetAllowResponseInBrowserHistory(false);
            cache.SetNoStore();

            base.OnResultExecuting(filterContext);

        }

        protected virtual HttpCachePolicyBase GetCache(ResultExecutingContext filterContext)
        {
            return filterContext.HttpContext.Response.Cache;
        }
    }
}