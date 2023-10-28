using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using KAF.MVC.Common;

namespace KAFWebAdmin.Controllers
{
    public class ForgetPasswordController : LoginBaseControllerController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        public async Task<ActionResult> ForgetPassword(string KAF)
        {
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
                    cookie.Value = "ar-kw";
                    cookie.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(cookie);
                }

                ViewBag.usertoken = objClsPrivate.GetUrlParamValMVCOnlyParam("token", KAF).Replace(" ", "+"); ;
                return View();

            }
            catch (Exception ex)
            {
                throw ex;
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
        public async Task<ActionResult> ForgetPasswordRequest(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = "";
            try
            {
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                ModelState.Remove("loweredusername");
                if (this.ModelState.IsValid)
                {
                    transactioncodeGen objTrans = new transactioncodeGen();
                    input.strValue1 = objTrans.GetRandomAlphaNumericStringForTransactionActivity("CP", DateTime.Now);

                    long i = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().ForgetPasswordRequestProcess(input);

                    if (i > 0) //Check the database
                    {
                        url = DomainUrl.GetDomainUrl() + "Login";
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = "Your password has been changed successfully, please login." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid user credentials." });
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

    }
}