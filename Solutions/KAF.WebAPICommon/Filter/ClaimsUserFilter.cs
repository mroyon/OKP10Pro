using KAF.WebAPICommon.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http.Controllers;

namespace KAF.WebAPICommon.Filter
{
    public class ClaimsUserFilter : System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var claims = HttpContext.Current.User.Identity as ClaimsIdentity;
            var user = new WebUserInfo(claims, HttpContext.Current);
            actionContext.ActionArguments["claimsUser"] = user;
            base.OnActionExecuting(actionContext);
        }
    }
}