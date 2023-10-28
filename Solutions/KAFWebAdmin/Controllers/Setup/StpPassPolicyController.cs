
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
    public class StpPassPolicyController : BaseController
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
        public async Task<ActionResult> StpPassPolicy()
        {
            return View("StpPassPolicyLanding");
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
        public async Task<ActionResult> StpPassPolicyTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, stp_passpolicyEntity input)
        {
            stp_passpolicyEntity objowin_stp_passpolicy = new stp_passpolicyEntity();
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
           
                List<stp_passpolicyEntity> data = this.GetAllStpPassPolicyData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.serialnopolicykey,
									 t.categoryid,
									 t.passexpiredays,
									 t.passexpiredaysis,
									 t.passmaxlength,
									 t.passminlength,
									 t.passmcontainchar,
									 t.passmcontainuchar,
									 t.passmcontainnum,
									 t.passmcontainspchar,
									 t.oldpasscom,
									 t.newpasscomoldpass,
									 t.regpasscontainchar,
									 t.regpasscontainuchar,
									 t.regpasscontainnum,
									 t.regpasscontainspchar,
									 t.organizationkey,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.serialnopolicykey.GetValueOrDefault(-99), "serialnopolicykey", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "StpPassPolicy/StpPassPolicyEdit", "StpPassPolicyEdit", 
                                   "StpPassPolicy/StpPassPolicyDelete", "StpPassPolicyDelete",
                                   "StpPassPolicy/StpPassPolicyDetail", "StpPassPolicyDetail")
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
        
        
        List<stp_passpolicyEntity> GetAllStpPassPolicyData(stp_passpolicyEntity objstp_passpolicyEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<stp_passpolicyEntity> listobjstp_passpolicyEntity = new List<stp_passpolicyEntity>();
            try
            {
                listobjstp_passpolicyEntity = KAF.FacadeCreatorObjects.stp_passpolicyFCC.GetFacadeCreate().GAPgListView((objstp_passpolicyEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjstp_passpolicyEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "serialnopolicykey" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "categoryid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "passexpiredays" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "passexpiredaysis" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "passmaxlength" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "passminlength" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "passmcontainchar" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "passmcontainuchar" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "passmcontainnum" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "passmcontainspchar" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "oldpasscom" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "newpasscomoldpass" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "regpasscontainchar" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "regpasscontainuchar" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "regpasscontainnum" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "regpasscontainspchar" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "organizationkey" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "serialnopolicykey" + " " + orderDir;
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
        
        
        
         #region Create StpPassPolicy

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
        public async Task<ActionResult> StpPassPolicyNew(stp_passpolicyEntity input)
        {
            try
            {
                ModelState.Clear();
                stp_passpolicyEntity model = new stp_passpolicyEntity();
                return PartialView("_StpPassPolicyNew", model);
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
        public async Task<ActionResult> StpPassPolicyInsert(stp_passpolicyEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("serialnopolicykey");
				 ModelState.Remove("categoryid");
				 ModelState.Remove("passexpiredays");
				 ModelState.Remove("passexpiredaysis");
				 ModelState.Remove("passmaxlength");
				 ModelState.Remove("passminlength");
				 ModelState.Remove("passmcontainchar");
				 ModelState.Remove("passmcontainuchar");
				 ModelState.Remove("passmcontainnum");
				 ModelState.Remove("passmcontainspchar");
				 ModelState.Remove("oldpasscom");
				 ModelState.Remove("newpasscomoldpass");
				 ModelState.Remove("regpasscontainchar");
				 ModelState.Remove("regpasscontainuchar");
				 ModelState.Remove("regpasscontainnum");
				 ModelState.Remove("regpasscontainspchar");
				 ModelState.Remove("organizationkey");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.stp_passpolicyFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update StpPassPolicy

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
        public async Task<ActionResult> StpPassPolicyEdit(stp_passpolicyEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.serialnopolicykey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("serialnopolicykey", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.stp_passpolicyFCC.GetFacadeCreate().GetAll(new stp_passpolicyEntity { serialnopolicykey = input.serialnopolicykey }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_StpPassPolicyEdit", model);
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
        public async Task<ActionResult> StpPassPolicyUpdate(stp_passpolicyEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("serialnopolicykey");
				 ModelState.Remove("categoryid");
				 ModelState.Remove("passexpiredays");
				 ModelState.Remove("passexpiredaysis");
				 ModelState.Remove("passmaxlength");
				 ModelState.Remove("passminlength");
				 ModelState.Remove("passmcontainchar");
				 ModelState.Remove("passmcontainuchar");
				 ModelState.Remove("passmcontainnum");
				 ModelState.Remove("passmcontainspchar");
				 ModelState.Remove("oldpasscom");
				 ModelState.Remove("newpasscomoldpass");
				 ModelState.Remove("regpasscontainchar");
				 ModelState.Remove("regpasscontainuchar");
				 ModelState.Remove("regpasscontainnum");
				 ModelState.Remove("regpasscontainspchar");
				 ModelState.Remove("organizationkey");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.stp_passpolicyFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete StpPassPolicy

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
        public async Task<ActionResult> StpPassPolicyDelete(stp_passpolicyEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("serialnopolicykey"); */
				 ModelState.Remove("categoryid");
				 ModelState.Remove("passexpiredays");
				 ModelState.Remove("passexpiredaysis");
				 ModelState.Remove("passmaxlength");
				 ModelState.Remove("passminlength");
				 ModelState.Remove("passmcontainchar");
				 ModelState.Remove("passmcontainuchar");
				 ModelState.Remove("passmcontainnum");
				 ModelState.Remove("passmcontainspchar");
				 ModelState.Remove("oldpasscom");
				 ModelState.Remove("newpasscomoldpass");
				 ModelState.Remove("regpasscontainchar");
				 ModelState.Remove("regpasscontainuchar");
				 ModelState.Remove("regpasscontainnum");
				 ModelState.Remove("regpasscontainspchar");
				 ModelState.Remove("organizationkey");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.serialnopolicykey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("serialnopolicykey", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.stp_passpolicyFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail StpPassPolicy

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
        public async Task<ActionResult> StpPassPolicyDetail(stp_passpolicyEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.serialnopolicykey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("serialnopolicykey", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.stp_passpolicyFCC.GetFacadeCreate().GetAll(new stp_passpolicyEntity { serialnopolicykey = input.serialnopolicykey }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_StpPassPolicyDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



