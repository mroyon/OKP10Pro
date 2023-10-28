using DataTables.Mvc;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials.MenuModel;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KAF.MVC.Common;

namespace KAFWebAdmin.Controllers.Security
{
    public class RolePermissionManagementController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        // GET: RolePermission
        [LoggingFilterAttribute]
        [AuthorizeFilterAttribute]
        public async Task<ActionResult> RolePermission()
        {
            return View();
        }

        #region Assign Permission
        [HttpPost]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        public async Task<ActionResult> AssignPermission(owin_rolepermissionEntity input, string listFromAction, string __RequestVerificationToken)
        {
            string str = string.Empty;
            SecurityCapsule sec = new SecurityCapsule();
            string url = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "RolePermissionManagement", "RolePermission", input.currenturl);

            string listaction = listFromAction.Substring(1, listFromAction.Length - 2);

            try
            {
                if (this.ModelState.IsValid)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.ex_nvarchar1 = listaction;
                    Int64 ret = 0;

                    ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().AssignRolePermission(input);
                    if (ret > 0)
                    {
                        ModelState.Clear();
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Common._saveInformation });
                    }
                    else
                        return Json(new { status = "failed", title = "Role Premission", redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
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

        #endregion


        #region GET MenuWiseFormAndAction
        [HttpPost]
        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        public async Task<ActionResult> GetAllMenuWiseFormAndAction(owin_rolepermissionEntity input)
        {
            // owin_menuEntity objmenuEntity = new owin_menuEntity();
            owin_forminfoEntity objforminfoEntity = new owin_forminfoEntity();
            owin_formactionEntity objformactionEntity = new owin_formactionEntity();

            JsonResult result = new JsonResult();
            List<owin_forminfoEntity> listobjForm = new List<owin_forminfoEntity>();
            List<owin_formactionEntity> listobjAction = new List<owin_formactionEntity>();
            List<owin_rolepermissionEntity> listobjRolePermission = new List<owin_rolepermissionEntity>();

            List<MenuWiseForm> menuinfo = new List<MenuWiseForm>();

            
            List<string> excludedfiles = new List<string>();
            excludedfiles.Add("Task Pending");
            excludedfiles.Add("Base");
            excludedfiles.Add("Common");
            excludedfiles.Add("Login");
            excludedfiles.Add("Login Base");
            excludedfiles.Add("UnAuthorize Access");
            excludedfiles.Add("Home");

            try
            {
                IEnumerable<Owin_ProcessGetFormActionistEntity> listProcessGetFormAction = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().GetOwin_ProcessGetFormActionistEntity(input.roleid);

                //var listRootMenus = listProcessGetFormAction.Where(test => test.ParentID == 0).Distinct();

                var listRootMenus = listProcessGetFormAction.Where(x => !excludedfiles.Contains(x.FormName) && x.ParentID == 0).Distinct();

                var listform = listProcessGetFormAction.GroupBy(test => test.AppFormID)
                   .Select(grp => grp.First())
                   .ToList();
                var listformaction = listProcessGetFormAction.GroupBy(test => test.FormActionID)
                    .Select(grp => grp.First())
                    .ToList();


                List<MenuWiseForm> kList = (from m in listRootMenus
                                            select new MenuWiseForm
                                            {
                                                appformid = m.AppFormID,
                                                formname = m.FormName,
                                                formList = (from f in listform
                                                            where m.AppFormID == f.ParentID
                                                            select new FormWiseAction
                                                            {
                                                                // menuid = f.MenuID,
                                                                appformid = f.AppFormID,
                                                                formname = f.FormName,
                                                                formActionList = (from a in listformaction
                                                                                  where f.AppFormID == a.ParentID && a.Ex_Nvarchar2 != "Internal Method"
                                                                                  select new FormAction
                                                                                  {
                                                                                      actionname = a.ActionName,
                                                                                      formactionid = a.FormActionID,
                                                                                      isview = Convert.ToBoolean(Convert.ToInt32(a.Status)),
                                                                                      action = string.Join(" ", (a.Ex_Nvarchar1 + " " + a.Ex_Nvarchar2).Split(' ').Distinct())
                                                                                  }).ToList()

                                                            }).ToList()
                                            }).ToList();



                var rootMenu = listProcessGetFormAction.Where(test => test.ParentID == 0).ToList();
                var subMenu = listProcessGetFormAction.Where(t => t.AppFormID != 0 && t.ParentID != 0).ToList();
                var listAction = listProcessGetFormAction.Where(t => t.AppFormID == 0).ToList();

                List<MenuWiseForm> cList = (from s in subMenu
                                            join c in subMenu on s.AppFormID equals c.ParentID
                                            select new MenuWiseForm
                                            {
                                                appformid = c.AppFormID,
                                                formname = c.FormName,
                                                formList = (from a in subMenu
                                                            where c.AppFormID == a.AppFormID
                                                            select new FormWiseAction
                                                            {
                                                                appformid = a.AppFormID,
                                                                formname = a.FormName,
                                                                formActionList = (from b in listAction
                                                                                  where a.AppFormID == b.ParentID && b.Ex_Nvarchar2 != "Internal Method"
                                                                                  select new FormAction
                                                                                  {
                                                                                      actionname = b.ActionName,
                                                                                      formactionid = b.FormActionID,
                                                                                      isview = Convert.ToBoolean(Convert.ToInt32(b.Status)),
                                                                                      action = string.Join(" ", (b.Ex_Nvarchar1 + " " + b.Ex_Nvarchar2).Split(' ').Distinct())
                                                                                  }).ToList()
                                                            }).ToList()
                                            }).ToList();
                var uList = kList.Concat(cList);

                result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = uList, redirectUrl = "", responsetext = "" }, JsonRequestBehavior.AllowGet);
                return result;


            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
    }
}