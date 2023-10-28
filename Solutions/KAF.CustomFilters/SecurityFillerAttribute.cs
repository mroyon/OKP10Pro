using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.CustomHelper.HelperClasses;

namespace KAF.CustomFilters.Filters
{
    public class SecurityFillerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            KAF.BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule sec = new KAF.BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule();
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            if (actionName != "DoLogin" && actionName != "ForgetPassword" && actionName != "ForgetPasswordRequest" && actionName != "CallLanguageShifter")
            {
                sec = FillSec(filterContext);
                filterContext.HttpContext.Items["CurrentSec"] = sec;
            }
            base.OnActionExecuting(filterContext);
        }

        private SecurityCapsule FillSec(ActionExecutingContext aceObject)
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
                    _securityCapsule.transid = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone").FirstOrDefault().Value;
                    _securityCapsule.raisingevent = aceObject.ActionDescriptor.ActionName;
                    //_securityCapsule.currentsessionid = listSession.Where(p => p.rasessionstatus == true).SingleOrDefault().rasessionid;

                    var okpid = claimsIdentity.Claims.Where(p => p.Type == "OkpID").FirstOrDefault().Value;
                    _securityCapsule.okpid = (okpid != "") ? long.Parse(okpid) : (long?)null;

                    if (aceObject.HttpContext.Session["jsonList"] != null)
                    {
                        List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(aceObject.HttpContext.Session["jsonList"].ToString());
                        if (itemList != null)
                        {
                            if (itemList.Exists(p => p.ActionName == _securityCapsule.controllername + "/" + _securityCapsule.actioname))
                                _securityCapsule.appformid = itemList.Where(p => p.ActionName == _securityCapsule.controllername + "/" + _securityCapsule.actioname).FirstOrDefault().FormActionID.GetValueOrDefault(0);
                        }
                    }
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