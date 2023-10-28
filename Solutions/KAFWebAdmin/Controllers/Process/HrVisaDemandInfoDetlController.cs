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
    public class HrVisaDemandInfoDetlController : BaseController
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
        public async Task<ActionResult> HrVisaDemandInfoDetl()
        {
            return View("HrVisaDemandInfoDetlLanding");
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
        public async Task<ActionResult> HrVisaDemandInfoDetlTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_visademandinfodetlEntity input)
        {
            hr_visademandinfodetlEntity objowin_hr_visademandinfodetl = new hr_visademandinfodetlEntity();
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
           
                List<hr_visademandinfodetlEntity> data = this.GetAllHrVisaDemandInfoDetlData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.visademanddetlid,
									 t.visademandid,
									 t.demandtype,
									 t.passportdetlid,
									 t.hrbasicid,
									 t.hrsvcid,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.visademanddetlid.GetValueOrDefault(-99), "visademanddetlid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrVisaDemandInfoDetl/HrVisaDemandInfoDetlEdit", "HrVisaDemandInfoDetlEdit", 
                                   "HrVisaDemandInfoDetl/HrVisaDemandInfoDetlDelete", "HrVisaDemandInfoDetlDelete",
                                   "HrVisaDemandInfoDetl/HrVisaDemandInfoDetlDetail", "HrVisaDemandInfoDetlDetail")
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
        
        
        List<hr_visademandinfodetlEntity> GetAllHrVisaDemandInfoDetlData(hr_visademandinfodetlEntity objhr_visademandinfodetlEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_visademandinfodetlEntity> listobjhr_visademandinfodetlEntity = new List<hr_visademandinfodetlEntity>();
            try
            {
                listobjhr_visademandinfodetlEntity = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().GAPgListView((objhr_visademandinfodetlEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_visademandinfodetlEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "visademanddetlid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "visademandid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "demandtype" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "passportdetlid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "hrsvcid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "visademanddetlid" + " " + orderDir;
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
        
        
        
         #region Create HrVisaDemandInfoDetl

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
        public async Task<ActionResult> HrVisaDemandInfoDetlNew(hr_visademandinfodetlEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_visademandinfodetlEntity model = new hr_visademandinfodetlEntity();
                return PartialView("_HrVisaDemandInfoDetlNew", model);
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
        public async Task<ActionResult> HrVisaDemandInfoDetlInsert(hr_visademandinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("visademanddetlid");
				 ModelState.Remove("visademandid");
				 ModelState.Remove("demandtype");
				 ModelState.Remove("passportdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrVisaDemandInfoDetl

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
        public async Task<ActionResult> HrVisaDemandInfoDetlEdit(hr_visademandinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visademanddetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visademanddetlid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().GetAll(new hr_visademandinfodetlEntity { visademanddetlid = input.visademanddetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_visademandinfoEntity> listhr_visademandinfo = KAF.FacadeCreatorObjects.hr_visademandinfoFCC.GetFacadeCreate().GetAll(new hr_visademandinfoEntity { visademandid = model.visademandid }).ToList();
					 //var objhr_visademandinfo = (from t in listhr_visademandinfo
					 //select new
					 //{
						//		 Id = t.visademandid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaDemandInfo = JsonConvert.SerializeObject(objhr_visademandinfo);

					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 //List<hr_svcinfoEntity> listhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrsvcid = model.hrsvcid }).ToList();
					 //var objhr_svcinfo = (from t in listhr_svcinfo
					 //select new
					 //{
						//		 Id = t.hrsvcid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_SvcInfo = JsonConvert.SerializeObject(objhr_svcinfo);

                
                

                ModelState.Clear();
                return PartialView("_HrVisaDemandInfoDetlEdit", model);
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
        public async Task<ActionResult> HrVisaDemandInfoDetlUpdate(hr_visademandinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("visademanddetlid");
				 ModelState.Remove("visademandid");
				 ModelState.Remove("demandtype");
				 ModelState.Remove("passportdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrVisaDemandInfoDetl

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
        public async Task<ActionResult> HrVisaDemandInfoDetlDelete(hr_visademandinfodetlEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("visademanddetlid"); */
				 ModelState.Remove("visademandid");
				 ModelState.Remove("demandtype");
				 ModelState.Remove("passportdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.visademanddetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visademanddetlid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrVisaDemandInfoDetl

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
        public async Task<ActionResult> HrVisaDemandInfoDetlDetail(hr_visademandinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visademanddetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visademanddetlid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().GetAll(new hr_visademandinfodetlEntity { visademanddetlid = input.visademanddetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_visademandinfoEntity> listhr_visademandinfo = KAF.FacadeCreatorObjects.hr_visademandinfoFCC.GetFacadeCreate().GetAll(new hr_visademandinfoEntity { visademandid = model.visademandid }).ToList();
					 //var objhr_visademandinfo = (from t in listhr_visademandinfo
					 //select new
					 //{
						//		 Id = t.visademandid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaDemandInfo = JsonConvert.SerializeObject(objhr_visademandinfo);

					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 //List<hr_svcinfoEntity> listhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrsvcid = model.hrsvcid }).ToList();
					 //var objhr_svcinfo = (from t in listhr_svcinfo
					 //select new
					 //{
						//		 Id = t.hrsvcid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_SvcInfo = JsonConvert.SerializeObject(objhr_svcinfo);

                
                
                ModelState.Clear();
                return PartialView("_HrVisaDemandInfoDetlDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



