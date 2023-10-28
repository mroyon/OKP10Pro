using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace KAF.CustomFilters.Filters
{
    public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //if (filterContext.HttpContext.Request.UrlReferrer.Host == filterContext.HttpContext.Request.Url.Host)
            //{ }

                //// We'd normally just use "*" for the allow-origin header, 
                //// but Chrome (and perhaps others) won't allow you to use authentication if
                //// the header is set to "*".
                //// TODO: Check elsewhere to see if the origin is actually on the list of trusted domains.
                //string domain = ConfigurationManager.AppSettings["Domain"];

                //var ctx = filterContext.RequestContext.HttpContext;
                //var origin = ctx.Request.UrlReferrer.Authority;

                //// var allowOrigin = !string.IsNullOrWhiteSpace(origin) ? origin : "*";
                //var allowOrigin = origin == domain ? true : false;
                //if (allowOrigin)
                //{
                //    string allowOriginurl = origin;
                //    ctx.Response.AddHeader("Access-Control-Allow-Origin", allowOriginurl);
                //    ctx.Response.AddHeader("Access-Control-Allow-Headers", "*");
                //    ctx.Response.AddHeader("Access-Control-Allow-Credentials", "true");
                //}
                //else
                //{
                //    filterContext.HttpContext.Response.StatusCode = 401;
                //    filterContext.Result = new JsonResult
                //    {
                //        Data = new { Success = false, Data = "Unauthorized" },
                //        ContentEncoding = System.Text.Encoding.UTF8,
                //        ContentType = "application/json",
                //        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                //    };
                //}

                base.OnActionExecuting(filterContext);

        }

        //private string[] origins;
        //private string methods;

        //public AllowCrossSiteJsonAttribute(string[] origins = null, string methods = "*")
        //{
        //    this.origins = origins;
        //    this.methods = methods;
        //}

        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    if (this.origins == null || !this.origins.Any())
        //    {
        //        //Allow all  
        //        HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*");
        //    }
        //    else if (this.origins.Contains(HttpContext.Current.Request.Url.Host, StringComparer.InvariantCultureIgnoreCase))
        //    {
        //        //Allow only if matching  
        //        HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", HttpContext.Current.Request.Url.Host);
        //    }

        //    if (string.IsNullOrWhiteSpace(this.methods))
        //    {
        //        //Allow all  
        //        HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Methods", "*");
        //    }
        //    else
        //    {
        //        //Allow only specified  
        //        HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Methods", this.methods);
        //    }
        //}
    }
}