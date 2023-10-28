using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KAF.CustomFilters.Filters
{
    public class ViewModelFillerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            var model = filterContext.Controller.ViewData.Model;

        }
    }
}