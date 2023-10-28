using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using KAF.MVC.Common;

namespace KAFWebAdmin.Controllers.Security
{
    public class EmailResetController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        // GET: UserPasswordReset
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserEmailReset()
        {
            return View();
        }


        #region Get User
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> GetUserByName(owin_userEntity input)
        {
            string str = string.Empty;
            List<owin_userEntity> listobjUser = new List<owin_userEntity>();
            try
            {
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");

                ModelState.Remove("passwordkey");

                ModelState.Remove("emailaddress");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    listobjUser = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll((new owin_userEntity() { username = input.username })).ToList();
                    if (listobjUser != null && listobjUser.Count > 0)
                    {
                        var dl = (from d in listobjUser
                                  select new
                                  {
                                      d.userid,
                                      d.masteruserid,
                                      d.username,
                                      d.loweredusername,
                                      d.emailaddress,
                                      d.mobilenumber,
                                      d.locked,
                                      d.approved,
                                      d.isreviewed,
                                      comment = d.comment == null ? string.Empty : d.comment,
                                      UserProfilePhoto = d.UserProfilePhoto == null ? string.Empty : d.UserProfilePhoto,
                                      ex_nvarchar1 = "<button class='btn btn-primary btn-md' id='btnProcess'>" + KAF.MsgContainer._Common._btnProcess + " <i class='fa fa-save'></i></button>",
                                      ex_nvarchar2 = "<button class='btn btn-primary btn-md' id='btnProcessCancel'>"+ KAF.MsgContainer._Common._btnCancel +" <i class='fa fa-times'></i></button>"
                                  }).ToList().FirstOrDefault();

                        return this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = dl }, JsonRequestBehavior.AllowGet);
                    }
                    else
                        return this.Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "User not found as per search." }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status =  KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }

            catch (Exception ex)
            {
                return Json(new { status =  KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> GetEmailVerfication(owin_userEntity input)
        {
            string str = string.Empty;
            List<owin_userEntity> listobjUser = new List<owin_userEntity>();
            try
            {
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");
                ModelState.Remove("username");
                ModelState.Remove("passwordkey");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.emailaddress = input.emailaddress.Replace("+", "");
                    listobjUser = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll((new owin_userEntity() { emailaddress = input.emailaddress })).ToList();
                    if (listobjUser != null && listobjUser.Count > 0)
                    {
                        return this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = "failed" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                        return this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = "passed" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status =  KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }

            catch (Exception ex)
            {
                return Json(new { status =  KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> ResetUserEmail(owin_userEntity input)
        {
            string str = string.Empty;
            List<owin_userEntity> listobjUser = new List<owin_userEntity>();
            ModelState.Remove("password");
            ModelState.Remove("passwordsalt");
            ModelState.Remove("passwordvector");
            ModelState.Remove("emailaddress");
            ModelState.Remove("passwordkey");
            ModelState.Remove("mobilenumber");
            ModelState.Remove("passwordquestion");
            ModelState.Remove("passwordanswer");
            ModelState.Remove("loweredusername");
            ModelState.Remove("locked");
            ModelState.Remove("approved");
            try
            {
                if (this.ModelState.IsValid)
                {
                    string newpass = string.Empty;
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.CurrentState = BaseEntity.EntityState.Changed;

                    KAF.AppConfiguration.Configuration.transactioncodeGen objTransCode = new KAF.AppConfiguration.Configuration.transactioncodeGen();
                    newpass = objTransCode.GetRandomAlphaNumericString(6);
                    input.password = newpass;
                    input.ex_nvarchar2 = Session.SessionID;

                    Int64 ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UserEmailUpdate(input);
                    if (ret > 0)
                    {
                        GetCountAsync(input);
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, newpass = newpass, redirectUrl = "", responsetext = KAF.MsgContainer._Common._updateInformation });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status =  KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status =  KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        public async Task<string> GetCountAsync(owin_userEntity input)
        {
            string mailFlag = string.Empty;
            try
            {
                owin_userEntity objUser = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity
                {
                    masteruserid = input.masteruserid,
                    userid = input.userid
                }).FirstOrDefault();

                if (objUser != null)
                {
                    clsMailComponent objMail = new clsMailComponent();
                    MailEntity obmail = new MailEntity();
                    obmail.ToEmail = objUser.emailaddress;
                    obmail.strValue4 = "Your application email has been changed from admin. Please collect your credential from admin.";
                    obmail.subject = "Your application email has been reset.";
                    mailFlag = objMail.SendMail(obmail);
                    objMail.Dispose();
                }

                objUser = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mailFlag;
        }


    }
}