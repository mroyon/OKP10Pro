using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.CustomHelper.HelperClasses;
using KAF.WebFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KAF.CustomFilters.Filters
{
    public class RequestValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool flg = false;
            string token = string.Empty;

            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;

            if (filterContext.ActionParameters != null && filterContext.ActionParameters.Count > 0)
            {
                if (filterContext.ActionParameters.Where(p => p.Key == "input").FirstOrDefault().Value != null)
                {
                    KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity obj = (KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity)(filterContext.ActionParameters.Where(p => p.Key == "input").FirstOrDefault().Value);
                    if (obj != null)
                    {
                        token = obj.token;
                        EncryptionHelper obje = new EncryptionHelper();
                        clsPrivateKeys objS = new clsPrivateKeys();
                        token = token.Replace(" ", "+");
                        if (token == "-99")
                        {
                            flg = false;
                        }

                        token = obje.Decrypt(token, true, objS.GetKeys());

                        if (actionName == "DoLogin" || actionName == "LoadQuestionCombo" || actionName == "ForgetPasswordLoad" || actionName == "ForgetPassword" || actionName == "ForgetPasswordRequest" || actionName == "CallLanguageShifter")
                        {
                            flg = true;
                        }
                        else
                        {
                            HttpCookie myCookie = HttpContext.Current.Request.Cookies["_KAFCoockies_Auth@" + token];
                            if (myCookie != null)
                            {
                                clsObjectUCaseIndentification objUser = objS.GetDecCookieUser(myCookie);
                                if (objUser != null)
                                {
                                    var claimsIdentity = filterContext.HttpContext.User.Identity as ClaimsIdentity;
                                    if (claimsIdentity != null)
                                    {
                                        string val = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;
                                        val = obje.Decrypt(val, true, objS.GetKeys());
                                        string coval = obje.Decrypt(objUser._stkn, true, objS.GetKeys());

                                        if (String.Compare(val, token) == 0 && String.Compare(token, coval) == 0)
                                            flg = true;
                                        else
                                            flg = false;
                                        //var roles = claims.Where(c => c.Type == roleClaimType).ToList();
                                    }
                                }
                            }
                        }
                    }
                }

                else if (filterContext.ActionParameters.Where(p => p.Key == "input").FirstOrDefault().Value == null)
                {
                    var headers = filterContext.HttpContext.Request.Headers;
                    var tokenheader = headers["token"];
                    var userinfo = headers["userinfo"];
                    var useripaddress = headers["useripaddress"];
                    var sessionid = headers["sessionid"];
                    var methodname = headers["methodname"];
                    var currenturl = headers["currenturl"];

                    //KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity obj = (KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity)(filterContext.ActionParameters.Where(p => p.Key == "input").FirstOrDefault().Value);
                    //BaseEntity obj = new BaseEntity();
                    KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity obj = new KAF.BusinessDataObjects.owin_roleEntity();
                    obj.token = tokenheader;
                    obj.userinfo = userinfo;
                    obj.useripaddress = useripaddress;
                    obj.sessionid = sessionid;
                    obj.methodname = methodname;
                    obj.currenturl = currenturl;
                    if (obj != null)
                    {
                        token = obj.token;
                        EncryptionHelper obje = new EncryptionHelper();
                        clsPrivateKeys objS = new clsPrivateKeys();
                        token = token.Replace(" ", "+");
                        if (token == "-99")
                        {
                            flg = false;
                        }

                        token = obje.Decrypt(token, true, objS.GetKeys());

                        if (actionName == "DoLogin" || actionName == "LoadQuestionCombo" || actionName == "ForgetPassword" || actionName == "ForgetPasswordRequest" || actionName == "CallLanguageShifter")
                        {
                            flg = true;
                        }
                        else
                        {
                            HttpCookie myCookie = HttpContext.Current.Request.Cookies["_KAFCoockies_Auth@" + token];
                            if (myCookie != null)
                            {
                                clsObjectUCaseIndentification objUser = objS.GetDecCookieUser(myCookie);
                                if (objUser != null)
                                {
                                    var claimsIdentity = filterContext.HttpContext.User.Identity as ClaimsIdentity;
                                    if (claimsIdentity != null)
                                    {
                                        string val = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;
                                        val = obje.Decrypt(val, true, objS.GetKeys());
                                        string coval = obje.Decrypt(objUser._stkn, true, objS.GetKeys());

                                        if (String.Compare(val, token) == 0 && String.Compare(token, coval) == 0)
                                            flg = true;
                                        else
                                            flg = false;
                                        //var roles = claims.Where(c => c.Type == roleClaimType).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            base.OnActionExecuting(filterContext);

            if (!flg)
            {
                var isAjaxRequest = filterContext.HttpContext.Request.IsAjaxRequest();
                var redirectUrl = DomainUrl.GetDomainUrl() + "login/index";

                if (isAjaxRequest)
                {
                    filterContext.HttpContext.Response.StatusCode = 403;
                    filterContext.HttpContext.Response.StatusDescription = redirectUrl;
                    filterContext.Result = new JsonResult
                    {
                        Data = new { status = "success", redirectUrl = redirectUrl },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };
                }
                else
                {
                    filterContext.Result = new RedirectResult(redirectUrl, true);
                }
                return;
            }
        }
    }
}