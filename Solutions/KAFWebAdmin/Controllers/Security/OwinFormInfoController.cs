
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
    public class OwinFormInfoController : BaseController
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
        public async Task<ActionResult> OwinFormInfo()
        {
            return View("OwinFormInfoLanding");
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
        public async Task<ActionResult> OwinFormInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_forminfoEntity input)
        {
            owin_forminfoEntity objowin_owin_forminfo = new owin_forminfoEntity();
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
           
                List<owin_forminfoEntity> data = this.GetAllOwinFormInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.appformid,
									 t.formname,
									 t.parentid,
									 t.levelid,
									 t.menulevel,
									 t.formnamear,
									 t.hasdirectchild,
									 t.icon,
									 t.classicon,
									 t.sequence,
									 t.url,
									 t.isview,
									 t.isdynamic,
									 t.issuperadmin,
									 t.isvisibleinmenu,
									 t.organizationkey,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.appformid.GetValueOrDefault(-99), "appformid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "OwinFormInfo/OwinFormInfoEdit", "OwinFormInfoEdit", 
                                   "OwinFormInfo/OwinFormInfoDelete", "OwinFormInfoDelete",
                                   "OwinFormInfo/OwinFormInfoDetail", "OwinFormInfoDetail")
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
        
        
        List<owin_forminfoEntity> GetAllOwinFormInfoData(owin_forminfoEntity objowin_forminfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_forminfoEntity> listobjowin_forminfoEntity = new List<owin_forminfoEntity>();
            try
            {
                listobjowin_forminfoEntity = KAF.FacadeCreatorObjects.owin_forminfoFCC.GetFacadeCreate().GAPgListView((objowin_forminfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjowin_forminfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "appformid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "formname" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "parentid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "levelid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "menulevel" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "formnamear" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "hasdirectchild" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "icon" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "classicon" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "sequence" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "url" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "isview" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "isdynamic" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "issuperadmin" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "isvisibleinmenu" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "organizationkey" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "appformid" + " " + orderDir;
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
        
        
        
         #region Create OwinFormInfo

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
        public async Task<ActionResult> OwinFormInfoNew(owin_forminfoEntity input)
        {
            try
            {
                ModelState.Clear();
                owin_forminfoEntity model = new owin_forminfoEntity();
                return PartialView("_OwinFormInfoNew", model);
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
        public async Task<ActionResult> OwinFormInfoInsert(owin_forminfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("appformid");
				 ModelState.Remove("formname");
				 ModelState.Remove("parentid");
				 ModelState.Remove("levelid");
				 ModelState.Remove("menulevel");
				 ModelState.Remove("formnamear");
				 ModelState.Remove("hasdirectchild");
				 ModelState.Remove("icon");
				 ModelState.Remove("classicon");
				 ModelState.Remove("sequence");
				 ModelState.Remove("url");
				 ModelState.Remove("isview");
				 ModelState.Remove("isdynamic");
				 ModelState.Remove("issuperadmin");
				 ModelState.Remove("isvisibleinmenu");
				 ModelState.Remove("organizationkey");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.owin_forminfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update OwinFormInfo

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
        public async Task<ActionResult> OwinFormInfoEdit(owin_forminfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.appformid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("appformid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.owin_forminfoFCC.GetFacadeCreate().GetAll(new owin_forminfoEntity { appformid = input.appformid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_OwinFormInfoEdit", model);
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
        public async Task<ActionResult> OwinFormInfoUpdate(owin_forminfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("appformid");
				 ModelState.Remove("formname");
				 ModelState.Remove("parentid");
				 ModelState.Remove("levelid");
				 ModelState.Remove("menulevel");
				 ModelState.Remove("formnamear");
				 ModelState.Remove("hasdirectchild");
				 ModelState.Remove("icon");
				 ModelState.Remove("classicon");
				 ModelState.Remove("sequence");
				 ModelState.Remove("url");
				 ModelState.Remove("isview");
				 ModelState.Remove("isdynamic");
				 ModelState.Remove("issuperadmin");
				 ModelState.Remove("isvisibleinmenu");
				 ModelState.Remove("organizationkey");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.owin_forminfoFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete OwinFormInfo

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
        public async Task<ActionResult> OwinFormInfoDelete(owin_forminfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("appformid"); */
				 ModelState.Remove("formname");
				 ModelState.Remove("parentid");
				 ModelState.Remove("levelid");
				 ModelState.Remove("menulevel");
				 ModelState.Remove("formnamear");
				 ModelState.Remove("hasdirectchild");
				 ModelState.Remove("icon");
				 ModelState.Remove("classicon");
				 ModelState.Remove("sequence");
				 ModelState.Remove("url");
				 ModelState.Remove("isview");
				 ModelState.Remove("isdynamic");
				 ModelState.Remove("issuperadmin");
				 ModelState.Remove("isvisibleinmenu");
				 ModelState.Remove("organizationkey");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.appformid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("appformid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.owin_forminfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail OwinFormInfo

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
        public async Task<ActionResult> OwinFormInfoDetail(owin_forminfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.appformid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("appformid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.owin_forminfoFCC.GetFacadeCreate().GetAll(new owin_forminfoEntity { appformid = input.appformid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_OwinFormInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



