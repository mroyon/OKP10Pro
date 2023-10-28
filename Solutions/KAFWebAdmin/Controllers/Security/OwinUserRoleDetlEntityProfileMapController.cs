
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
    public class OwinUserRoleDetlEntityProfileMapController : BaseController
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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMap()
        {
            return View("OwinUserRoleDetlEntityProfileMapLanding");
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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userroledetlentityprofilemapEntity input)
        {
            owin_userroledetlentityprofilemapEntity objowin_owin_userroledetlentityprofilemap = new owin_userroledetlentityprofilemapEntity();
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
           
                List<owin_userroledetlentityprofilemapEntity> data = this.GetAllOwinUserRoleDetlEntityProfileMapData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.entityprofiletypeid,
									 t.userroledetentitymaplid,
									 t.userroledetlid,
									 t.userroleid,
									 t.userid,
									 t.roleid,
									 t.profiletype,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.entityprofiletypeid.GetValueOrDefault(-99), "entityprofiletypeid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "OwinUserRoleDetlEntityProfileMap/OwinUserRoleDetlEntityProfileMapEdit", "OwinUserRoleDetlEntityProfileMapEdit", 
                                   "OwinUserRoleDetlEntityProfileMap/OwinUserRoleDetlEntityProfileMapDelete", "OwinUserRoleDetlEntityProfileMapDelete",
                                   "OwinUserRoleDetlEntityProfileMap/OwinUserRoleDetlEntityProfileMapDetail", "OwinUserRoleDetlEntityProfileMapDetail")
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
        
        
        List<owin_userroledetlentityprofilemapEntity> GetAllOwinUserRoleDetlEntityProfileMapData(owin_userroledetlentityprofilemapEntity objowin_userroledetlentityprofilemapEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_userroledetlentityprofilemapEntity> listobjowin_userroledetlentityprofilemapEntity = new List<owin_userroledetlentityprofilemapEntity>();
            try
            {
                listobjowin_userroledetlentityprofilemapEntity = KAF.FacadeCreatorObjects.owin_userroledetlentityprofilemapFCC.GetFacadeCreate().GAPgListView((objowin_userroledetlentityprofilemapEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjowin_userroledetlentityprofilemapEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "entityprofiletypeid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "userroledetentitymaplid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "userroledetlid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "userroleid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "userid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "roleid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "profiletype" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "entityprofiletypeid" + " " + orderDir;
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
        
        
        
         #region Create OwinUserRoleDetlEntityProfileMap

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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapNew(owin_userroledetlentityprofilemapEntity input)
        {
            try
            {
                ModelState.Clear();
                owin_userroledetlentityprofilemapEntity model = new owin_userroledetlentityprofilemapEntity();
                return PartialView("_OwinUserRoleDetlEntityProfileMapNew", model);
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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapInsert(owin_userroledetlentityprofilemapEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("entityprofiletypeid");
				 ModelState.Remove("userroledetentitymaplid");
				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("profiletype");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.owin_userroledetlentityprofilemapFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update OwinUserRoleDetlEntityProfileMap

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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapEdit(owin_userroledetlentityprofilemapEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.entityprofiletypeid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("entityprofiletypeid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.owin_userroledetlentityprofilemapFCC.GetFacadeCreate().GetAll(new owin_userroledetlentityprofilemapEntity { entityprofiletypeid = input.entityprofiletypeid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_OwinUserRoleDetlEntityProfileMapEdit", model);
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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapUpdate(owin_userroledetlentityprofilemapEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("entityprofiletypeid");
				 ModelState.Remove("userroledetentitymaplid");
				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("profiletype");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.owin_userroledetlentityprofilemapFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete OwinUserRoleDetlEntityProfileMap

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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapDelete(owin_userroledetlentityprofilemapEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("entityprofiletypeid"); */
				 ModelState.Remove("userroledetentitymaplid");
				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("profiletype");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.entityprofiletypeid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("entityprofiletypeid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.owin_userroledetlentityprofilemapFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail OwinUserRoleDetlEntityProfileMap

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
        public async Task<ActionResult> OwinUserRoleDetlEntityProfileMapDetail(owin_userroledetlentityprofilemapEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.entityprofiletypeid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("entityprofiletypeid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.owin_userroledetlentityprofilemapFCC.GetFacadeCreate().GetAll(new owin_userroledetlentityprofilemapEntity { entityprofiletypeid = input.entityprofiletypeid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_OwinUserRoleDetlEntityProfileMapDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



