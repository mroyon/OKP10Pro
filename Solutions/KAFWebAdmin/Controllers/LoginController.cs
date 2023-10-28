using KAF.AppConfiguration.Configuration;
using KAF.AppConfiguration.EncryptionHandler;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using log4net;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace KAFWebAdmin.Controllers
{
    public class LoginController : LoginBaseControllerController
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        clsMongoLog objLog = new clsMongoLog();
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        // GET: Logink

        [System.Web.Mvc.AllowAnonymous]
        [ExceptionFilter]
        public async Task<ActionResult> Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            if (User.Identity.IsAuthenticated)
                ViewBag.Message = "You Dont have enough Permissions.";
            // ViewBag.baseURL = System.Configuration.ConfigurationManager.AppSettings[].ToString();

            ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();

            KAF.AppConfiguration.Configuration.transactioncodeGen objTrans = new KAF.AppConfiguration.Configuration.transactioncodeGen();
            string token = string.Empty;
            try
            {
                HttpContext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                HttpContext.User = null;
                Session.Abandon();

                token = objTrans.GetRandomAlphaNumericStringForTransactionActivity(Session.SessionID + "_", DateTime.Now);
                objTrans.Dispose();
                MemoryStream ms = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(string));
                ser.WriteObject(ms, token);
                EncryptionHelper obje = new EncryptionHelper();
                clsPrivateKeys objS = new clsPrivateKeys();
                byte[] json = ms.ToArray();
                ms.Close();
                string encString = Encoding.UTF8.GetString(json, 0, json.Length);
                string strEnc = obje.Encrypt(encString, true, objS.GetKeys());

                ViewBag.usertoken = strEnc;

                string xmlData = Server.MapPath("~/LanguagesFiles/_Common.xml");
                System.Data.DataSet ds = new System.Data.DataSet();//Using dataset to read xml file  
                ds.ReadXml(xmlData);
                Session.Add("comlanguage", JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented));

                // Save culture in a cookie
                HttpCookie cookie = Request.Cookies["_culture"];
                if (cookie == null)
                {
                    cookie = new HttpCookie("_culture");
                    cookie.Value = "en-us";
                    cookie.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(cookie);
                }

                var obj = clsUtil.ToSelectList<KAF.ConstantTypes.clsSystemConstantTypes.Gen_family_relationship>(typeof(KAF.ConstantTypes.clsSystemConstantTypes.Gen_family_relationship));
                var obj2 = clsUtil.ToSelectList<KAF.ConstantTypes.clsSystemConstantTypes.HR_Personal_Type>(typeof(KAF.ConstantTypes.clsSystemConstantTypes.HR_Personal_Type));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View();
        }

        //var okpsummary = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_BMCStrengthSummary(
        [HttpPost]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [ExceptionFilter]
        public async Task<JsonResult> LoadAllStrngth(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            try
            {

                var okpsummary = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_BMCStrengthSummary(
                                 new rpt_BMCStrengthSummaryEntity { }).Where(p=>p.OkpName!="N/A").ToList();
                var result = new JsonResult
                {
                    Data = okpsummary
                };
                return result;

            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        [HttpPost]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [ExceptionFilter]
        public async Task<JsonResult> LoadQuestionCombo(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            try
            {
                ModelState.Remove("emailaddress");
                ModelState.Remove("username");
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("loweredusername");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("useripaddress");
                ModelState.Remove("locked");
                ModelState.Remove("approved");

                if (this.ModelState.IsValid)
                {
                    List<SelectListItem> objList = new List<SelectListItem>();

                    objList = clsDataCache.GetSecurityQuestions();

                    if (objList != null && objList.Count > 0)
                    {
                        str = Newtonsoft.Json.JsonConvert.SerializeObject(objList, Newtonsoft.Json.Formatting.None);
                    }
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return result;
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        //[SecurityFillerAttribute]
        [ExceptionFilter]
        [AllowAnonymous]
        public async Task<ActionResult> ForgetPasswordLoad(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            try
            {
                ModelState.Clear();
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
                return PartialView("_forgetpassword", input);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [ExceptionFilter]
        [AllowAnonymous]
        public async Task<ActionResult> ForgetPassword(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = "";// urlBuilder.Action("Index", "Home");
            try
            {
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                    string[] linkUser = new string[] { "token", input.token };

                    Request.RequestContext.HttpContext.Items["Ttoken"] = input.token;
                    url = objClsPrivate.BuildUrlMVCFromController("ForgetPassword", "ForgetPassword", linkUser);

                    transactioncodeGen objTrans = new transactioncodeGen();
                    input.strValue2 = objTrans.GetRandomAlphaNumericString(12);
                    input.strValue1 = objTrans.GetRandomAlphaNumericStringForTransactionActivity("CP", DateTime.Now);
                    input.strValue3 = input.token;

                    long i = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().ForgetPasswordRequest(input);

                    if (i > 0) //Check the database
                    {
                        url = DomainUrl.GetDomainUrl() + "ForgetPassword/ForgetPassword/?KAF=" + objClsPrivate.BuildUrlMVCOnlyParams("token", input.token);

                        clsMailComponent objmail = new clsMailComponent();
                        objmail.ForgetPassword(new MailEntity()
                        {
                            ToEmail = input.emailaddress,
                            strValue2 = input.strValue2,
                            strValue3 = url,
                        });

                        url = DomainUrl.GetDomainUrl() + "Login";
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Responses._resforgetPasswordReply });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resinvalidCredential });
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        [HttpPost]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilter]
        [AllowAnonymous]
        public async Task<ActionResult> DoLogin(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = "";// urlBuilder.Action("Index", "Home");
            try
            {
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                ModelState.Remove("applicationid");
                ModelState.Remove("masteruserid");
                ModelState.Remove("isanonymous");
                ModelState.Remove("masprivatekey");
                ModelState.Remove("maspublickey");

                if (this.ModelState.IsValid)
                {
                    string decr_uname = AESEncrytDecry.DecryptStringAES(input.username);
                    string decr_pwd = AESEncrytDecry.DecryptStringAES(input.password);

                    string[] linkUser = new string[] { "token", input.token };

                    Request.RequestContext.HttpContext.Items["Ttoken"] = input.token;
                    url = objClsPrivate.BuildUrlMVCFromController("Home", "Index", linkUser);
                    KAF_GetUserInfoByCredentialEntity objUserInfo = new KAF_GetUserInfoByCredentialEntity();
                    objUserInfo = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().ValidateInfoByUserNameAndPassword(decr_uname, decr_pwd, "");

                    if (objUserInfo != null) //Check the database
                    {

                        if (objUserInfo.istwosetepauthenable.GetValueOrDefault(false))
                        {
                            //return PartialView("_indexTSV", objUserInfo);
                        }

                        List<Claim> claims = await GetClaims(input, objUserInfo, decr_pwd); //Get the claims from the headers or db or your user store
                        if (null != claims)
                        {
                            SignIn(claims, objUserInfo, input);

                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Status._statusSuccess });
                        }
                        else
                            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resinvalidCredential });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resinvalidCredential });
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        //[RequestValidationAttribute]
        //[ValidateAntiForgeryToken]
        // [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilter]
        public async Task<ActionResult> SignOut(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = DomainUrl.GetDomainUrl() + "Login/index";
            try
            {
                ModelState.Remove("username");
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordkey");
                ModelState.Remove("loweredusername");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                ModelState.Remove("applicationid");
                ModelState.Remove("isanonymous");
                ModelState.Remove("masteruserid");
                ModelState.Remove("masprivatekey");
                ModelState.Remove("maspublickey");
                if (this.ModelState.IsValid)
                {
                    Request.GetOwinContext().Authentication.SignOut(Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie);
                    EncryptionHelper obje = new EncryptionHelper();
                    clsPrivateKeys objS = new clsPrivateKeys();
                    string token = input.token;
                    token = token.Replace(" ", "+");
                    token = obje.Decrypt(token, true, objS.GetKeys());

                    if (Request.Cookies["_KAFCoockies_Auth@" + token] != null)
                    {
                        HttpCookie myCookie = new HttpCookie("_KAFCoockies_Auth@" + token);
                        myCookie.Expires = DateTime.Now.AddDays(-1d);
                        myCookie.Value = "blablabla";
                        Response.Cookies.Add(myCookie);
                    }
                    HttpContext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                    HttpContext.User = null;
                    Session.Abandon();

                    string[] myCookies = Request.Cookies.AllKeys;
                    foreach (string cookie in myCookies)
                    {
                        string cookieName = Request.Cookies[cookie].Name;
                        HttpCookie aCookie = new HttpCookie(cookieName);
                        aCookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(aCookie);
                    }

                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = str });
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        private async Task<List<Claim>> GetClaims(KAF.BusinessDataObjects.owin_userEntity input, KAF_GetUserInfoByCredentialEntity objUser, string decr_pwd)
        {
            try
            {
                List<Owin_ProcessGetFormActionistEntity_Ext> itemList = new List<Owin_ProcessGetFormActionistEntity_Ext>();
                itemList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().GetOwin_ProcessGetFormActionistEntityExt(objUser.masteruserid.GetValueOrDefault()).ToList();


                KAF.AppConfiguration.Configuration.transactioncodeGen objTranIDGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Email, objUser.emailaddress));
                string domURL = DomainUrl.GetDomainUrl();
                claims.Add(new Claim(clsIdentity.IPClaimType.Replace("{}", domURL), input.useripaddress));
                claims.Add(new Claim(clsIdentity.IdClaimType.Replace("{}", domURL), objUser.username));

                claims.Add(new Claim(ClaimTypes.GivenName, objUser.username));
                claims.Add(new Claim(ClaimTypes.SerialNumber, objUser.masteruserid.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.MobilePhone, objUser.mobilenumber == null ? "-99" : objUser.mobilenumber));
                claims.Add(new Claim(ClaimTypes.Name, objUser.loweredusername));
                claims.Add(new Claim(ClaimTypes.Gender, objUser.userid.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.PrimarySid, input.token));
                claims.Add(new Claim(ClaimTypes.StateOrProvince, objUser.userorganizationkey.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.StreetAddress, objUser.userentitykey.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.Uri, input.currenturl));

                claims.Add(new Claim(type: "OkpID", value: objUser.okpid.ToString()));


                string str = string.Empty;
                List<Dictionary<string, string>> objAPIResponse = null;
                using (var client = new HttpClient())
                {

                    try
                    {
                        string baseUri = System.Configuration.ConfigurationManager.AppSettings["webapi"] + "oauth2/token";
                        client.BaseAddress = new Uri(baseUri);
                        var postData = new List<KeyValuePair<string, string>>();
                        postData.Add(new KeyValuePair<string, string>("username", objUser.username));
                        postData.Add(new KeyValuePair<string, string>("password", decr_pwd));
                        postData.Add(new KeyValuePair<string, string>("grant_type", "password"));
                        HttpContent content = new FormUrlEncodedContent(postData);
                        var response1 = await client.PostAsync(baseUri, content);
                        if (response1.IsSuccessStatusCode)
                            str = response1.Content.ReadAsStringAsync().Result;

                        if (str.Length > 0)
                            objAPIResponse = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>("[" + str + "]");
                        else
                            throw new Exception("WEB API AUTH FAILED");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

                claims.Add(new Claim(ClaimTypes.PostalCode, "bearer " + objAPIResponse[0]["access_token"].ToString()));
                claims.Add(new Claim(ClaimTypes.HomePhone, objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRN", DateTime.Now)));
                claims.Add(new Claim(ClaimTypes.Surname, objUser.userprofilephoto));
                claims.Add(new Claim(ClaimTypes.Upn, Session.SessionID));

                //var json = objClsPrivate.GetMenuWritten(itemList, DomainUrl.GetDomainUrl());
                var json = objClsPrivate.GetMenuWritten(itemList, DomainUrl.GetDomainUrl());
                Session.Add("json", json);
                Session.Add("jsonList", Newtonsoft.Json.JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.None));

                //claims.Add(new Claim(ClaimTypes.NameIdentifier, Newtonsoft.Json.JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.None)));

                var roles = new[] { "admin", "citizin", "worker" };
                var groups = new[] { "User" };

                foreach (var item in roles)
                {
                    claims.Add(new Claim(clsIdentity.RolesClaimType.Replace("{}", domURL), item));
                }
                foreach (var item in groups)
                {
                    claims.Add(new Claim(clsIdentity.GroupClaimType.Replace("{}", domURL), item));
                }

                return claims;
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        private void SignIn(List<Claim> claims, KAF_GetUserInfoByCredentialEntity objUser, KAF.BusinessDataObjects.owin_userEntity input)
        {
            try
            {
                DateTime dot = DateTime.Now;
                var claimsIdentity = new clsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
                AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = true, ExpiresUtc = DateTime.UtcNow.AddMinutes(20) }, claimsIdentity);
                HttpContext.User = new clsPrinciple(AuthenticationManager.AuthenticationResponseGrant.Principal);

                clsObjectUCaseIndentification objUs = new clsObjectUCaseIndentification();

                objUs._userid = objUser.userid;
                objUs._stkn = input.token;
                objUs._emailaddress = objUser.emailaddress;
                objUs._ipaddress = input.useripaddress;
                objUs._username = objUser.username;
                objUs._logdate = dot;
                MemoryStream ms = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(clsObjectUCaseIndentification));
                ser.WriteObject(ms, objUs);
                EncryptionHelper obje = new EncryptionHelper();
                clsPrivateKeys objS = new clsPrivateKeys();
                byte[] json = ms.ToArray();
                ms.Close();
                string encString = Encoding.UTF8.GetString(json, 0, json.Length);
                string strEnc = obje.Encrypt(encString, true, objS.GetKeys());

                string token = input.token; //sessionid + date
                token = obje.Decrypt(token, true, objS.GetKeys());

                HttpCookie appCookie = new HttpCookie("_KAFCoockies_Auth@" + token);
                appCookie.Name = "_KAFCoockies_Auth@" + token;
                appCookie.Value = strEnc;
                appCookie.Expires = DateTime.MinValue;
              
                appCookie.Domain = System.Configuration.ConfigurationManager.AppSettings["appdomaincookie"].ToString();
                appCookie.Shareable = false;
                appCookie.Path = "/";
                appCookie.Secure = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["appdomaincookiesecured"].ToString());
                Response.Cookies.Add(appCookie);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }


        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AllowAnonymous]
        [ExceptionFilter]
        public async Task<ActionResult> CallLanguageShifter(owin_userEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                    string culture = input.password;
                    // Validate input
                    culture = CultureHelper.GetImplementedCulture(culture);

                    RouteData.Values["culture"] = culture;

                    // Save culture in a cookie
                    HttpCookie cookie = Request.Cookies["_culture"];
                    if (cookie != null)
                        cookie.Value = culture;   // update cookie value
                    else
                    {
                        cookie = new HttpCookie("_culture");
                        cookie.Value = culture;
                        cookie.Expires = DateTime.Now.AddYears(1);
                    }
                    Response.Cookies.Add(cookie);

                    return RedirectToAction("Index");
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = KAF.MsgContainer._Status._statusFailed,
                    title = KAF.MsgContainer._Status._titleGenericError,
                    redirectUrl = "",
                    responsetext = ex.Message
                });
            }
        }




        public async Task<ActionResult> OpenLoginModal(KAF.BusinessDataObjects.owin_userEntity input)
        {
            try
            {
                ModelState.Clear();
                owin_userEntity model = new owin_userEntity();
                return PartialView("_Login", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
    }
}