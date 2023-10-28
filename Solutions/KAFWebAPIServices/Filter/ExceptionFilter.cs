using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAFWebAPIServices.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http.Filters;

namespace KAFWebAPIServices.Filter
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            String message = String.Empty;

            string controllerName = actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName;
            string actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;


            var request = actionExecutedContext.Request;
            object value;
            if (request == null)
            { }
            else
            {
                var claims = HttpContext.Current.User.Identity as ClaimsIdentity;
                clsMongoLog objLog = new clsMongoLog();
                objLog.SetLog(FillSec(claims, actionExecutedContext, actionName, controllerName), new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), actionExecutedContext.Exception.Message, LOGLevel.Error);
            }

            var exceptionType = actionExecutedContext.Exception.GetType();
            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                message = "Access to the Web API is not authorized.";
                status = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(DivideByZeroException))
            {
                message = "Internal Server Error.";
                status = HttpStatusCode.InternalServerError;
            }
            else
            {
                message = actionExecutedContext.Exception.Message;
                status = HttpStatusCode.NotFound;
            }
            actionExecutedContext.Response = new HttpResponseMessage()
            {
                Content = new StringContent(message, System.Text.Encoding.UTF8, "text/plain"),
                StatusCode = status
            };
            base.OnException(actionExecutedContext);
        }

        private SecurityCapsule FillSec(ClaimsIdentity claims, HttpActionExecutedContext context,
            string actionname, string controllername)
        {
            SecurityCapsule _securityCapsule = new SecurityCapsule();
            KAF.AppConfiguration.Configuration.transactioncodeGen objTranIDGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();
            try
            {
                if (claims != null)
                {
                    _securityCapsule.username = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                    _securityCapsule.usernumber = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone").FirstOrDefault().Value;
                    _securityCapsule.userorganizationkey = long.Parse(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince").FirstOrDefault().Value);
                    _securityCapsule.userentitykey = long.Parse(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode").FirstOrDefault().Value);

                    _securityCapsule.pageurl = context.Request.RequestUri.AbsoluteUri;//((System.Web.HttpRequestWrapper)context.Request).FilePath;// claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").FirstOrDefault().Value;
                    //_securityCapsule.ipaddress = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone").FirstOrDefault().Value;
                    _securityCapsule.controllername = controllername;
                    _securityCapsule.actioname = actionname;

                    _securityCapsule.createdby = long.Parse(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress").FirstOrDefault().Value);
                    _securityCapsule.updatedby = _securityCapsule.createdby;
                    _securityCapsule.createdbyusername = _securityCapsule.username;
                    _securityCapsule.updatedbyusername = _securityCapsule.username;
                    _securityCapsule.userid = new Guid(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);

                    _securityCapsule.fullname = _securityCapsule.username;
                    _securityCapsule.email = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                    _securityCapsule.hitfrom = KAF.ConstantTypes.clsSystemConstantTypes.LoggedModeWeb;
                    _securityCapsule.actiondate = DateTime.Now;
                    _securityCapsule.usertoken = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country").FirstOrDefault().Value;

                    _securityCapsule.sessionid = _securityCapsule.username;
                    _securityCapsule.transid = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country").FirstOrDefault().Value;
                    _securityCapsule.raisingevent = "token";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _securityCapsule;
        }
    }
}