using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.CustomHelper.HelperClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KAF.CustomFilters.Filters
{
    public class ExceptionFilterAttribute : HandleErrorAttribute
    {
        clsMongoLog errorlog = new clsMongoLog();
        private bool IsAjax(ExceptionContext filterContext)
        {
            return filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }


        public override void OnException(ExceptionContext filterContext)
        {

            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();

            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

            SecurityCapsule sec = new SecurityCapsule();
            if (filterContext.HttpContext.Items["CurrentSec"] != null)
                sec = (SecurityCapsule)filterContext.HttpContext.Items["CurrentSec"];
            else
                sec = FillSec(filterContext);

            errorlog.SetLog(sec, null, filterContext.Exception.Message, LOGLevel.Error);
            if (IsAjax(filterContext))
            {
                filterContext.HttpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
                filterContext.Result = new JsonResult()
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new
                    {
                        Error = filterContext.Exception.Message
                    }
                };
                filterContext.ExceptionHandled = true;
            }
            else
            {
                //filterContext.Result = new RedirectToRouteResult(
                //new RouteValueDictionary
                //{
                //    { "controller", "Login" },
                //    { "action", "Index" }
                //});
            }
        }
        private SecurityCapsule FillSec(ExceptionContext aceObject)
        {
            SecurityCapsule _securityCapsule = new SecurityCapsule();
            try
            {
                _securityCapsule.username = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.usernumber = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.userorganizationkey = -99;
                _securityCapsule.userentitykey = -99;

                _securityCapsule.pageurl = aceObject.HttpContext.Request.Url.AbsoluteUri.ToString();
                _securityCapsule.ipaddress = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.controllername = aceObject.RouteData.Values["controller"].ToString();
                _securityCapsule.actioname = aceObject.RouteData.Values["action"].ToString();

                _securityCapsule.createdby = -99;
                _securityCapsule.updatedby = -99;
                _securityCapsule.createdbyusername = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.updatedbyusername = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.userid = new Guid();

                _securityCapsule.fullname = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.email = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                _securityCapsule.hitfrom = KAF.ConstantTypes.clsSystemConstantTypes.LoggedModeWeb;
                _securityCapsule.actiondate = DateTime.Now;
                _securityCapsule.usertoken = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];

                KAF.AppConfiguration.Configuration.transactioncodeGen objTranIDGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();

                _securityCapsule.sessionid = HttpContext.Current.Session.SessionID;
                _securityCapsule.transid = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRN", _securityCapsule.createddate.GetValueOrDefault(DateTime.Now));
                _securityCapsule.raisingevent = aceObject.RouteData.Values["action"].ToString();
                //_securityCapsule.currentsessionid = listSession.Where(p => p.rasessionstatus == true).SingleOrDefault().rasessionid;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _securityCapsule;
        }

    }
}