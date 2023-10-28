using DataTables.Mvc;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials.MenuModel;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KAF.MVC.Common;

namespace KAFWebAdmin.Controllers.Security
{
    public class RoleManagementController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        clsSecurityPanel objSecPanel = new clsSecurityPanel();
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> Role()
        {
            return View("Role");
        }

        #region CREATE ROLE
        // Get Method for Create Role page load       
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> CreateRole()
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                var model = new owin_roleEntity();
                return View("CreateRole", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        //POST Method for Role Create      
        [HttpPost]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        public async Task<ActionResult> CreateRole(owin_roleEntity input)
        {
            try
            {
                string str = string.Empty;
                string url = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "RoleManagement", "Role", input.currenturl);
                SecurityCapsule sec = new SecurityCapsule();

                if (ModelState.IsValid)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    Int64 ret = 0;
                    ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().CreateRole_Ext(input);
                    if (ret > 0)
                    {
                        ModelState.Clear();
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Common._saveInformation });
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
        #endregion

        #region UPDATE ROLE
        [HttpPost]
        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> Role_UpdateGet(owin_roleEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                string strid = objClsPrivate.GetUrlParamValMVCOnlyParam("roleid", input.rolename);
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                var model = KAF.FacadeCreatorObjects.owin_roleFCC.GetFacadeCreate().GetAll(new owin_roleEntity { roleid = long.Parse(strid) }).SingleOrDefault();
                ModelState.Clear();
                return PartialView("_UpdateRole", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> Role_Update(owin_roleEntity input)
        {

            try
            {
                string redirectURL = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "RoleManagement", "Role", input.currenturl);
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();

                if (ModelState.IsValid)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    Int64 ret = 0;
                    ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UpdateRole_Ext(input);
                    if (ret > 0)
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._updateInformation });
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
        #endregion UPDATE ROLE

        #region DELETE ROLE
        [HttpPost]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> Role_Delete(owin_roleEntity input)
        {
            string str = string.Empty;

            try
            {
                ModelState.Remove("roleid");
                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.roleid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("roleid", input.rolename));
                    string url = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "RoleManagement", "Role", input.currenturl);
                    var model = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().DeleteRole_Ext(input);
                    if (model > 0)
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Common._deleteInformation });
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
            finally
            {

            }
        }
        #endregion DELETE ROLE

        #region GET ROLE
        [HttpPost]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GetRoleData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_roleEntity input)
        {
            owin_roleEntity objowin_roleEntity = new owin_roleEntity();
            // Initialization.  
            JsonResult result = new JsonResult();
            try
            {
                string search = Request.Form.GetValues("search[value]")[0];

                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                int CurrentPage = 0;
                if (requestModel.Start == 0)
                {
                    CurrentPage = 1;
                }
                else
                {
                    CurrentPage = requestModel.Start / requestModel.Length + 1;
                }
                input.CurrentPage = CurrentPage;
                input.PageSize = requestModel.Length;
                input.SortExpression = SortByColumnWithOrder((Request.Form.GetValues("order[0][column]"))[0], (Request.Form.GetValues("order[0][dir]"))[0]);

                if (search != "")
                {
                    input.rolename = "%" + search + "%";
                }

                List<owin_roleEntity> data = this.GetAllRoleData(input);
                long totalRecords = data.FirstOrDefault().RETURN_KEY;

                var tut = (from t in data
                           select new
                           {
                               t.roleid,
                               t.rolename,
                               t.description,
                               ex_nvarchar1 = objSecPanel.genButtonPanel(t.roleid.GetValueOrDefault(-99), "roleid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "RoleManagement/Role_UpdateGet", "EditRole", "RoleManagement/Role_Delete", "DeleteRole",
                                   "RoleManagement/Role_Details", "RoleDetails")
                           }).ToList();


                result = this.Json(new { draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            { return Json(new { status = KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }); }
            return result;
        }
        List<owin_roleEntity> GetAllRoleData(owin_roleEntity objroleEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_roleEntity> listobjRole = new List<owin_roleEntity>();
            try
            {
                listobjRole = KAF.FacadeCreatorObjects.owin_roleFCC.GetFacadeCreate().GetAllByPages((objroleEntity)).ToList();
            }
            catch (Exception ex)
            {
                //return Json(new { status =  KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }

            return listobjRole;
        }
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "rolename" + " " + orderDir;
                        break;
                    //case "1":
                    //    sortingVal = "description" + " " + orderDir;
                    //    break;
                    default:
                        sortingVal = "rolename" + " " + orderDir;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sortingVal;
        }
        #endregion GET ROLE

        #region ROLE DETAILS

        [AllowCrossSiteJsonAttribute]
        [LoggingFilterAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> Role_Details(string input)
        {
            string str = string.Empty;
            // List<owin_rolepermissionEntity> rolePermissionList = new List<owin_rolepermissionEntity>();
            try
            {
                if (string.IsNullOrEmpty(input))
                    return new HttpUnauthorizedResult("Unauthorized");
                else
                {
                    str = objClsPrivate.GetUrlParamValMVCOnlyParam("roleid", input);

                    var model = KAF.FacadeCreatorObjects.owin_roleFCC.GetFacadeCreate().GetAll(new owin_roleEntity { roleid = long.Parse(str) }).FirstOrDefault();
                    var rolePermissionList = KAF.FacadeCreatorObjects.owin_rolepermissionFCC.GetFacadeCreate().GetAll_Ext(new owin_rolepermissionEntity { roleid = long.Parse(str) });
                    RoleWithPermission rolepermission = new RoleWithPermission();
                    rolepermission.RoleEntity = model;
                    rolepermission.RolePermissionList = rolePermissionList;
                    return PartialView("_DetailsRole", rolepermission);
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, data = "", title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
    }
}