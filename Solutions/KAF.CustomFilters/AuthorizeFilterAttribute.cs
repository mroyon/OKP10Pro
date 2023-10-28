using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;

namespace KAF.CustomFilters.Filters
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AuthorizeFilterAttribute : AuthorizeAttribute
    {
        //Custom named parameters for annotation
        public string ResourceKey { get; set; }
        public string OperationKey { get; set; }

        public bool authorizationFailed { get; set; }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
             

            KAF.BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule sec = new KAF.BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule();
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;


            if (!filterContext.HttpContext.Request.IsAuthenticated)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    // For AJAX requests, we're overriding the returned JSON result with a simple string,
                    // indicating to the calling JavaScript code that a redirect should be performed.
                    filterContext.Result = new JsonResult { Data = "_Logon_" };
                }
                else
                {
                    // For round-trip posts, we're forcing a redirect to Home/TimeoutRedirect/, which
                    // simply displays a temporary 5 second notification that they have timed out, and
                    // will, in turn, redirect to the logon page.
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary {
                        { "Controller", "Home" },
                        { "Action", "TimeoutRedirect" }
                    });
                }
            }
            authorizationFailed = true;
            base.OnAuthorization(filterContext);

            var claimsIdentity = filterContext.HttpContext.User.Identity as ClaimsIdentity;

            if (claimsIdentity.Name != "")
            {
                string val = string.Empty;
                val = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;

                if (filterContext.HttpContext.Session["jsonList"] != null)
                {
                    List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(filterContext.HttpContext.Session["jsonList"].ToString());
                    if (itemList != null && itemList.Count > 0)
                    {
                        controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
                        actionName = filterContext.ActionDescriptor.ActionName;
                        if (actionName.ToUpper() != "INDEX")
                            if (!itemList.Exists(p => p.ActionName.Contains(controllerName + "/" + actionName)))
                            {
                                authorizationFailed = false;
                                HandleUnauthorizedRequest(filterContext);
                            }
                    }
                    else
                    {
                        authorizationFailed = false;
                        HandleUnauthorizedRequest(filterContext);
                    }
                }
                filterContext.Controller.ViewBag.usertoken = val;
            }
            else
            {
                authorizationFailed = false;
                HandleUnauthorizedRequest(filterContext);
            }
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var claimsIdentity = filterContext.HttpContext.User.Identity as ClaimsIdentity;
            if (claimsIdentity.Name != "")
            {
                if (claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault() == null)
                {
                    filterContext.Result = new RedirectToRouteResult(
                     new RouteValueDictionary {
                        { "Controller", "login" },
                        { "Action", "index" }
                 });
                    authorizationFailed = true;
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                 new RouteValueDictionary {
                        { "Controller", "login" },
                        { "Action", "index" }
             });
                authorizationFailed = true;
            }

            if (authorizationFailed == false)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    //filterContext.HttpContext.Response.StatusCode = 500;
                    //filterContext.HttpContext.Response.Write("Error: You Don't Have The Permission, Please Go Back!");
                    //filterContext.Result = new JsonResult
                    //{
                    //};
                    //filterContext.Result = new RedirectResult("~/Home/Error");
                    //filterContext.Result = new System.Web.Mvc.HttpStatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
                    throw new HttpException(401, "You Don't Have The Permission");
                    //filterContext.Controller.ViewData["OpenAuthorizationPopup"] = false;

                    //filterContext.Result = new JsonResult()
                    //{
                    //    Data = new
                    //    {
                    //        errorMessage = "Permission Denied"
                    //    },
                    //    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    //};
                }
                else
                {

                    //filterContext.HttpContext.Response.StatusCode = 500;
                    //filterContext.HttpContext.Response.Write("Error: You Don't Have The Permission,Please Go Back!");
                    //filterContext.Result = new JsonResult
                    //{
                    //};
                    //filterContext.Result = new RedirectResult("~/Home/Error");
                    //filterContext.Result = new System.Web.Mvc.HttpStatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
                    throw new HttpException(401, "You Don't Have The Permission");
                    //filterContext.Controller.ViewData["OpenAuthorizationPopup"] = false;

                    //filterContext.Result = new JsonResult()
                    //{
                    //    Data = new
                    //    {
                    //        errorMessage = "Permission Denied"
                    //    },
                    //    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    //};
                }
            }
        }


        //Core authentication, called before each action
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException("httpContext");

            IPrincipal user = httpContext.User;
            if (!user.Identity.IsAuthenticated)
                return false;



            //if (_usersSplit.Length > 0 && !_usersSplit.Contains(user.Identity.Name, StringComparer.OrdinalIgnoreCase))
            //    return false;

            //if (_rolesSplit.Length > 0 && !_rolesSplit.Any(user.IsInRole))
            //    return false;

            return true;


            //var b = httpContext .Instance.Member().IsLoggedIn;
            ////Is user logged in?
            //if (b)
            //    //If user is logged in and we need a custom check:
            //    if (ResourceKey != null && OperationKey != null)
            //        return ecMembership.Instance.Member().ActivePermissions.Where(x => x.operation == OperationKey && x.resource == ResourceKey).Count() > 0;
            ////Returns true or false, meaning allow or deny. False will call HandleUnauthorizedRequest above
            //return b;
        }

        private SecurityCapsule FillSec(AuthorizationContext aceObject)
        {
            SecurityCapsule _securityCapsule = new SecurityCapsule();
            var claimsIdentity = aceObject.HttpContext.User.Identity as ClaimsIdentity;
            

            try
            {
                if (claimsIdentity != null)
                {
                    _securityCapsule.username = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").FirstOrDefault().Value;
                    _securityCapsule.usernumber = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone").FirstOrDefault().Value;
                    _securityCapsule.userorganizationkey = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince").FirstOrDefault().Value);
                    _securityCapsule.userentitykey = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress").FirstOrDefault().Value);

                    _securityCapsule.pageurl = aceObject.HttpContext.Request.Url.AbsoluteUri.ToString();
                    _securityCapsule.ipaddress = aceObject.HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                    _securityCapsule.controllername = aceObject.ActionDescriptor.ControllerDescriptor.ControllerName;
                    _securityCapsule.actioname = aceObject.ActionDescriptor.ActionName;

                    _securityCapsule.createdby = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber").FirstOrDefault().Value);
                    _securityCapsule.updatedby = _securityCapsule.createdby;
                    _securityCapsule.createdbyusername = _securityCapsule.username;
                    _securityCapsule.updatedbyusername = _securityCapsule.username;
                    _securityCapsule.userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);

                    _securityCapsule.fullname = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                    _securityCapsule.email = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                    _securityCapsule.hitfrom = KAF.ConstantTypes.clsSystemConstantTypes.LoggedModeWeb;
                    _securityCapsule.actiondate = DateTime.Now;
                    _securityCapsule.usertoken = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;

                    KAF.AppConfiguration.Configuration.transactioncodeGen objTranIDGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();

                    _securityCapsule.sessionid = HttpContext.Current.Session.SessionID;
                    _securityCapsule.transid = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRN", _securityCapsule.createddate.GetValueOrDefault(DateTime.Now));
                    _securityCapsule.raisingevent = aceObject.ActionDescriptor.ActionName;
                    //_securityCapsule.appformid = itemList.Where(p=> p.ParentID != null && )
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