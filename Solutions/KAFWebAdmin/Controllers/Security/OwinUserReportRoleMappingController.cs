using DataTables.Mvc;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using KAF.WebFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using KAF.MVC.Common;

namespace KAFWebAdmin.Controllers.Setup
{
    public class OwinUserReportRoleMappingController : Controller
    {

        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        clsSecurityPanel objSecPanel = new clsSecurityPanel();
        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();

        #region LANDING LOAD
        //Landing page caller

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserReportRoleMapping()
        {
            return View("OwinUserReportRoleMappingLanding");
        }

        #endregion

        #region Create User Report Role Mapping

        //Create Page Create Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserReportRoleMappingInsert(owin_reportpermissionEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("masteruserid");
                ModelState.Remove("reportid");
                ModelState.Remove("isaccessible");
                ModelState.Remove("isprintable");
                ModelState.Remove("userid");
                ModelState.Remove("reportroleid");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    Int64 ret = 0;
                    ret = KAF.FacadeCreatorObjects.owin_reportpermissionFCC.GetFacadeCreate().Add(input);
                    if (ret > 0)
                    {
                        ModelState.Clear();
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._saveInformation });
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
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion Create User Report Role Mapping


        public async Task<ActionResult> GetReportRoleByUser(owin_reportpermissionEntity input)
        {
            owin_reportpermissionEntity model = new owin_reportpermissionEntity();
            JsonResult result = new JsonResult();
            try
            {
                var ReportRoleCache = new DataCacheController().GetCacheData(clsDataCache.owin_reportrole[0].ToString());
                var user_reportrole_list = KAF.FacadeCreatorObjects.owin_reportpermissionFCC.GetFacadeCreate().GetAll(new owin_reportpermissionEntity { masteruserid = Convert.ToInt64(input.masteruserid) })
                    .GroupBy(k => new { k.masteruserid, k.reportroleid }).Select(m => new { m.Key.masteruserid, m.Key.reportroleid }).ToList();

                if (user_reportrole_list != null)
                {
                    var data = (from t in ReportRoleCache
                                join c in user_reportrole_list on t.comId equals c.reportroleid
                                select new
                                {
                                    t.comId,
                                    t.comText
                                }).ToList();


                    result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = data, redirectUrl = "", responsetext = "" }, JsonRequestBehavior.AllowGet);
                }
                return result;
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
    }
}