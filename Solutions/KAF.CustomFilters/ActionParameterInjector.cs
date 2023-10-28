using KAF.BusinessDataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KAF.CustomFilters.Filters
{
    public class ActionParameterInjector : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.ActionParameters.ContainsKey("input"))
            {
                if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    owin_userEntity input = new owin_userEntity()
                    {
                        token = filterContext.ActionParameters.Where(p => p.Key == "token") != null ? filterContext.ActionParameters.Where(p => p.Key == "token").FirstOrDefault().Value.ToString() : null,
                        userinfo = filterContext.ActionParameters.Where(p => p.Key == "userinfo") != null ? filterContext.ActionParameters.Where(p => p.Key == "userinfo").FirstOrDefault().Value.ToString() : null,
                        useripaddress = filterContext.ActionParameters.Where(p => p.Key == "useripaddress") != null ? filterContext.ActionParameters.Where(p => p.Key == "useripaddress").FirstOrDefault().Value.ToString() : null,
                        sessionid = filterContext.ActionParameters.Where(p => p.Key == "sessionid") != null ? filterContext.ActionParameters.Where(p => p.Key == "sessionid").FirstOrDefault().Value.ToString() : null,
                        methodname = filterContext.ActionParameters.Where(p => p.Key == "methodname") != null ? filterContext.ActionParameters.Where(p => p.Key == "methodname").FirstOrDefault().Value.ToString() : null,
                        currenturl = filterContext.ActionParameters.Where(p => p.Key == "currenturl") != null ? filterContext.ActionParameters.Where(p => p.Key == "currenturl").FirstOrDefault().Value.ToString() : null
                    };
                    filterContext.ActionParameters.Add("input", input);
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}