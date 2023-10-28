using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.CustomHelper.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace KAF.CustomFilters.Filters
{
    public class LoggingFilterAttribute : ActionFilterAttribute
    {
       
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Trace.Write("(Logging Filter)Action Executing: " +
                filterContext.ActionDescriptor.ActionName);

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            SecurityCapsule sec = (SecurityCapsule)filterContext.HttpContext.Request.RequestContext.HttpContext.Items["CurrentSec"];
            clsMongoLog objLog = new clsMongoLog();
            string ac = filterContext.ActionDescriptor.ActionName;
            string co = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            if (filterContext.Exception != null)
            {
                filterContext.HttpContext.Trace.Write("(Logging Filter)Exception thrown");
                if (sec != null)
                {
                    objLog.SetLog(sec, new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), filterContext.Exception.Message,LOGLevel.Error);
                }
            }
            if (sec != null)
            {
                objLog.SetLog(sec, new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), "performing " + sec.actioname + " from " + sec.controllername + " controller by user:" + sec.username, LOGLevel.Info);
            }

            base.OnActionExecuted(filterContext);
        }

        //public override void OnResultExecuted(ResultExecutedContext filterContext)
        //{
        //    SecurityCapsule sec = (SecurityCapsule)filterContext.HttpContext.Request.RequestContext.HttpContext.Items["CurrentSec"];
        //    clsMongoLog objLog = new clsMongoLog();
            
        //    if (filterContext.Exception != null)
        //    {
        //        filterContext.HttpContext.Trace.Write("(Logging Filter)Exception thrown");
        //        if (sec != null)
        //        {
        //            objLog.SetLog(sec, new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), filterContext.Exception.Message, LOGLevel.Error);
        //        }
        //    }

        //    if (sec != null)
        //    {
        //        objLog.SetLog(sec, new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), "performing " + sec.actioname + " from " + sec.controllername + " controller by user:" + sec.username, LOGLevel.Info);
        //    }


        //    base.OnResultExecuted(filterContext);
        //}

        
    }
}