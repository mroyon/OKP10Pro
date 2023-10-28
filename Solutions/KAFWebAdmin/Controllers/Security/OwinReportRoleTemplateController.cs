using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.CustomFilters.Filters;
using KAF.MVC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KAFWebAdmin.Controllers.Security
{
    public class OwinReportRoleTemplateController : BaseController
    {

        // GET: OwinReportRoleTemplate
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public ActionResult RoleTemplate()
        {
            return View("RoleTemplate");
        }

        #region Owin Report Role Data Get
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GetAllReportsWithPermission(owin_reportroletemplateEntity input)
        {
            try
            {
                string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLowerInvariant().ToLower();


                JsonResult result = new JsonResult();
                IEnumerable<rptm_allreportinfoEntity> listreportinfoentity = KAF.FacadeCreatorObjects.rptm_allreportinfoFCC.GetFacadeCreate().GetAll(
                    new rptm_allreportinfoEntity()
                    {
                        ex_bigint1 = null
                    });
                IEnumerable<owin_reportroletemplateEntity> listreporttemplate = KAF.FacadeCreatorObjects.owin_reportroletemplateFCC.GetFacadeCreate().GetAll(input);
                var joinresult = (from rpt in listreportinfoentity
                                  join tmp in listreporttemplate
                                  on rpt.reportid equals tmp.reportid into jd
                                  from x in jd.DefaultIfEmpty()
                                  select new rptm_allreportinfoEntity
                                  {
                                      reportid = rpt.reportid,
                                      modulename = (lang == "ar-kw" ? rpt.modulename : rpt.modulename),
                                      reportname = (lang == "ar-kw" ? rpt.reportdescription : rpt.reportname),
                                      reporturl = rpt.reporturl,
                                      ex_bigint1 = x?.reportroleid ?? null  // report role id
                                  }).ToList();

                var results = from p in joinresult
                              group p by p.modulename into g
                              select new { modulename = g.Key, reportlist = g.ToList() };


                result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = results, redirectUrl = "", responsetext = "" }, JsonRequestBehavior.AllowGet);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> SetReportRolePermission(owin_reportroletemplateEntity input)
        {
            try
            {
                JsonResult result = new JsonResult();
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();

                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.BaseSecurityParam = sec;
                Int64 ret = 0;

                ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().SetReportRolePermission(input);
                if (ret > 0)
                {
                    ModelState.Clear();
                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Common._saveInformation });
                }
                else

                    return Json(new { status = "failed", title = "Role Premission", redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}