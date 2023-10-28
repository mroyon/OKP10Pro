using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
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
    public class UserApprovalController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        // GET: UserApproval
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserApprovalView()
        {
            return View();
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
        public async Task<ActionResult> GetUserByName(owin_userEntity input)
        {
            string str = string.Empty;
            List<owin_userEntity> listobjUser = new List<owin_userEntity>();
            try
            {
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
                                      ex_nvarchar2 = "<button class='btn btn-primary btn-md' id='btnProcessCancel'>" + KAF.MsgContainer._Common._btnCancel + " <i class='fa fa-times'></i></button>"

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
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }

            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
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
        public async Task<ActionResult> UpdateApprovalStatus(owin_userEntity input)
        {
            string str = string.Empty;

            try
            {
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
                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.CurrentState = BaseEntity.EntityState.Changed;

                    Int64 ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UserApproveUpdate(input);
                    if (ret > 0)
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Common._updateInformation });
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
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
    }
}