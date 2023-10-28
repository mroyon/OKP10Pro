
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
    public class OwinUserRoleDetlController : BaseController
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
        public async Task<ActionResult> OwinUserRoleDetl()
        {
            return View("OwinUserRoleDetlLanding");
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
        public async Task<ActionResult> OwinUserRoleDetlTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userroledetlEntity input)
        {
            owin_userroledetlEntity objowin_owin_userroledetl = new owin_userroledetlEntity();
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
           
                List<owin_userroledetlEntity> data = this.GetAllOwinUserRoleDetlData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.userroledetlid,
									 t.userroleid,
									 t.userid,
									 t.roleid,
									 t.fromdate,
									 t.todate,
									 t.iscurrent,
									 t.iscentraladmin,
									 t.allchild,
									 t.isunitadmin,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.userroledetlid.GetValueOrDefault(-99), "userroledetlid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "OwinUserRoleDetl/OwinUserRoleDetlEdit", "OwinUserRoleDetlEdit", 
                                   "OwinUserRoleDetl/OwinUserRoleDetlDelete", "OwinUserRoleDetlDelete",
                                   "OwinUserRoleDetl/OwinUserRoleDetlDetail", "OwinUserRoleDetlDetail")
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
        
        
        List<owin_userroledetlEntity> GetAllOwinUserRoleDetlData(owin_userroledetlEntity objowin_userroledetlEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_userroledetlEntity> listobjowin_userroledetlEntity = new List<owin_userroledetlEntity>();
            try
            {
                listobjowin_userroledetlEntity = KAF.FacadeCreatorObjects.owin_userroledetlFCC.GetFacadeCreate().GAPgListView((objowin_userroledetlEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjowin_userroledetlEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "userroledetlid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "userroleid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "userid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "roleid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "fromdate" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "todate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "iscurrent" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "iscentraladmin" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "allchild" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "isunitadmin" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "userroledetlid" + " " + orderDir;
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
        
        
        
         #region Create OwinUserRoleDetl

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
        public async Task<ActionResult> OwinUserRoleDetlNew(owin_userroledetlEntity input)
        {
            try
            {
                ModelState.Clear();
                owin_userroledetlEntity model = new owin_userroledetlEntity();
                return PartialView("_OwinUserRoleDetlNew", model);
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
        public async Task<ActionResult> OwinUserRoleDetlInsert(owin_userroledetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("fromdate");
				 ModelState.Remove("todate");
				 ModelState.Remove("iscurrent");
				 ModelState.Remove("iscentraladmin");
				 ModelState.Remove("allchild");
				 ModelState.Remove("isunitadmin");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.owin_userroledetlFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update OwinUserRoleDetl

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
        public async Task<ActionResult> OwinUserRoleDetlEdit(owin_userroledetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.userroledetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("userroledetlid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.owin_userroledetlFCC.GetFacadeCreate().GetAll(new owin_userroledetlEntity { userroledetlid = input.userroledetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_OwinUserRoleDetlEdit", model);
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
        public async Task<ActionResult> OwinUserRoleDetlUpdate(owin_userroledetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("userroledetlid");
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("fromdate");
				 ModelState.Remove("todate");
				 ModelState.Remove("iscurrent");
				 ModelState.Remove("iscentraladmin");
				 ModelState.Remove("allchild");
				 ModelState.Remove("isunitadmin");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.owin_userroledetlFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete OwinUserRoleDetl

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
        public async Task<ActionResult> OwinUserRoleDetlDelete(owin_userroledetlEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("userroledetlid"); */
				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("fromdate");
				 ModelState.Remove("todate");
				 ModelState.Remove("iscurrent");
				 ModelState.Remove("iscentraladmin");
				 ModelState.Remove("allchild");
				 ModelState.Remove("isunitadmin");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.userroledetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("userroledetlid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.owin_userroledetlFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail OwinUserRoleDetl

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
        public async Task<ActionResult> OwinUserRoleDetlDetail(owin_userroledetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.userroledetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("userroledetlid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.owin_userroledetlFCC.GetFacadeCreate().GetAll(new owin_userroledetlEntity { userroledetlid = input.userroledetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_OwinUserRoleDetlDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



