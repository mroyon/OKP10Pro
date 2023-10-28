using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAFWebAPIServices.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace KAFWebAPIServices.Filter
{
    public class LoggingFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

            string actionname = ((System.Web.Http.Controllers.ReflectedHttpActionDescriptor)actionContext.ActionDescriptor).ActionName;
            string controllername = actionContext.ControllerContext.ControllerDescriptor.ControllerName;
            WebUserInfo secmodel = (WebUserInfo)actionContext.ActionArguments["claimsUser"];
            if (secmodel != null)
            {
                SecurityCapsule sec = secmodel._securityCapsule;
                if (sec != null)
                {
                    try
                    {
                        clsMongoLog objLog = new clsMongoLog();
                        objLog.SetLog(FillSec(sec, actionContext, actionname, controllername), new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), controllername + "/" + actionname, LOGLevel.Info);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        private SecurityCapsule FillSec(SecurityCapsule sec, HttpActionContext context,
            string actionname, string controllername)
        {
            KAF.AppConfiguration.Configuration.transactioncodeGen objTranIDGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();
            try
            {
                sec.pageurl = context.Request.RequestUri.AbsoluteUri;//((System.Web.HttpRequestWrapper)context.Request).FilePath;// claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").FirstOrDefault().Value;
                sec.controllername = controllername;
                sec.actioname = actionname;
                sec.actiondate = DateTime.Now;
                sec.raisingevent = controllername + "/" + actionname;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sec;
        }
    }
}