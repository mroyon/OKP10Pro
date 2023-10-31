﻿
using DataTables.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials.MenuModel;
using KAF.WebFramework;
using System.Threading.Tasks;
using KAF.CustomHelper.HelperClasses;
using KAF.CustomFilters.Filters;
using KAF.MVC.Common;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;		
using KAF.CustomHelper;
    
namespace KAFWebAdmin.Controllers.HR
{
    public class OwinUserRoleDetlEntityMapController : BaseController
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
        public async Task<ActionResult> OwinUserRoleDetlEntityMap()
        {
            return View("OwinUserRoleDetlEntityMapLanding");
        }


        //Datatable load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserRoleDetlEntityMapTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userroledetlentitymapEntity input)
        {
            owin_userroledetlentitymapEntity objowin_owin_userroledetlentitymap = new owin_userroledetlentitymapEntity();
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
                    input.strCommonSerachParam = "%" + search + "%";
                }
           
                List<owin_userroledetlentitymapEntity> data = this.GetAllOwinUserRoleDetlEntityMapData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.userroledetentitymaplid,
									 t.userroledetlid,
									 t.userroleid,
									 t.userid,
									 t.roleid,
									 t.entitykey,
									 t.allchild,
									 t.isunitadmin,
									 t.allunit,
									 t.allprofile,
									 t.remarks,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.userroledetentitymaplid.GetValueOrDefault(-99), "userroledetentitymaplid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "OwinUserRoleDetlEntityMap/OwinUserRoleDetlEntityMapEdit", "OwinUserRoleDetlEntityMapEdit", 
                                   "OwinUserRoleDetlEntityMap/OwinUserRoleDetlEntityMapDelete", "OwinUserRoleDetlEntityMapDelete",
                                   "OwinUserRoleDetlEntityMap/OwinUserRoleDetlEntityMapDetail", "OwinUserRoleDetlEntityMapDetail")
                               }).ToList();

                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }
        
        
        List<owin_userroledetlentitymapEntity> GetAllOwinUserRoleDetlEntityMapData(owin_userroledetlentitymapEntity objowin_userroledetlentitymapEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_userroledetlentitymapEntity> listobjowin_userroledetlentitymapEntity = new List<owin_userroledetlentitymapEntity>();
            try
            {
                listobjowin_userroledetlentitymapEntity = KAF.FacadeCreatorObjects.owin_userroledetlentitymapFCC.GetFacadeCreate().GAPgListView((objowin_userroledetlentitymapEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjowin_userroledetlentitymapEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "userroledetentitymaplid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "userroledetlid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "userroleid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "userid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "roleid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "entitykey" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "allchild" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "isunitadmin" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "allunit" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "allprofile" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "userroledetentitymaplid" + " " + orderDir;
							 break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sortingVal;
        }

        #endregion 
        
        
        
         #region Create OwinUserRoleDetlEntityMap

        //Create Page Load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserRoleDetlEntityMapNew(owin_userroledetlentitymapEntity input)
        {
            try
            {
                ModelState.Clear();
                owin_userroledetlentitymapEntity model = new owin_userroledetlentitymapEntity();
                return PartialView("_OwinUserRoleDetlEntityMapNew", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


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
        public async Task<ActionResult> OwinUserRoleDetlEntityMapInsert(owin_userroledetlentitymapEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("userroledetentitymaplid");
				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("entitykey");
				 ModelState.Remove("allchild");
				 ModelState.Remove("isunitadmin");
				 ModelState.Remove("allunit");
				 ModelState.Remove("allprofile");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.owin_userroledetlentitymapFCC.GetFacadeCreate().Add(input);
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
        #endregion
        
        
        #region update OwinUserRoleDetlEntityMap

        //Update Page Load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserRoleDetlEntityMapEdit(owin_userroledetlentitymapEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.userroledetentitymaplid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("userroledetentitymaplid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.owin_userroledetlentitymapFCC.GetFacadeCreate().GetAll(new owin_userroledetlentitymapEntity { userroledetentitymaplid = input.userroledetentitymaplid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_OwinUserRoleDetlEntityMapEdit", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        //Update Page Update Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserRoleDetlEntityMapUpdate(owin_userroledetlentitymapEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("userroledetentitymaplid");
				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("entitykey");
				 ModelState.Remove("allchild");
				 ModelState.Remove("isunitadmin");
				 ModelState.Remove("allunit");
				 ModelState.Remove("allprofile");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.owin_userroledetlentitymapFCC.GetFacadeCreate().Update(input);
                 
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
        #endregion

        #region delete OwinUserRoleDetlEntityMap

        //Delete Page Delete Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserRoleDetlEntityMapDelete(owin_userroledetlentitymapEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("userroledetentitymaplid"); */
				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("entitykey");
				 ModelState.Remove("allchild");
				 ModelState.Remove("isunitadmin");
				 ModelState.Remove("allunit");
				 ModelState.Remove("allprofile");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.userroledetentitymaplid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("userroledetentitymaplid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.owin_userroledetlentitymapFCC.GetFacadeCreate().Delete(input);
                 
                    if (ret > 0)
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._deleteInformation });
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
        #endregion

        #region detail OwinUserRoleDetlEntityMap

        //Detail Page Load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserRoleDetlEntityMapDetail(owin_userroledetlentitymapEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.userroledetentitymaplid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("userroledetentitymaplid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.owin_userroledetlentitymapFCC.GetFacadeCreate().GetAll(new owin_userroledetlentitymapEntity { userroledetentitymaplid = input.userroledetentitymaplid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_OwinUserRoleDetlEntityMapDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}


