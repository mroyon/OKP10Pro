
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
    public class HrArrivalInfoDetlController : BaseController
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
        public async Task<ActionResult> HrArrivalInfoDetl()
        {
            return View("HrArrivalInfoDetlLanding");
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
        public async Task<ActionResult> HrArrivalInfoDetlTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_arrivalinfodetlEntity input)
        {
            hr_arrivalinfodetlEntity objowin_hr_arrivalinfodetl = new hr_arrivalinfodetlEntity();
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
           
                List<hr_arrivalinfodetlEntity> data = this.GetAllHrArrivalInfoDetlData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.arrivaldetlld,
									 t.arrivalld,
									 t.flightdetlid,
									 t.hrbasicid,
									 t.hrsvcid,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.arrivaldetlld.GetValueOrDefault(-99), "arrivaldetlld", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrArrivalInfoDetl/HrArrivalInfoDetlEdit", "HrArrivalInfoDetlEdit", 
                                   "HrArrivalInfoDetl/HrArrivalInfoDetlDelete", "HrArrivalInfoDetlDelete",
                                   "HrArrivalInfoDetl/HrArrivalInfoDetlDetail", "HrArrivalInfoDetlDetail")
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
        
        
        List<hr_arrivalinfodetlEntity> GetAllHrArrivalInfoDetlData(hr_arrivalinfodetlEntity objhr_arrivalinfodetlEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_arrivalinfodetlEntity> listobjhr_arrivalinfodetlEntity = new List<hr_arrivalinfodetlEntity>();
            try
            {
                listobjhr_arrivalinfodetlEntity = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().GAPgListView((objhr_arrivalinfodetlEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_arrivalinfodetlEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "arrivaldetlld" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "arrivalld" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "flightdetlid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "hrsvcid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "arrivaldetlld" + " " + orderDir;
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
        
        
        
         #region Create HrArrivalInfoDetl

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
        public async Task<ActionResult> HrArrivalInfoDetlNew(hr_arrivalinfodetlEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_arrivalinfodetlEntity model = new hr_arrivalinfodetlEntity();
                return PartialView("_HrArrivalInfoDetlNew", model);
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
        public async Task<ActionResult> HrArrivalInfoDetlInsert(hr_arrivalinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("arrivaldetlld");
				 ModelState.Remove("arrivalld");
				 ModelState.Remove("flightdetlid");
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
                    
					 ret = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrArrivalInfoDetl

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
        public async Task<ActionResult> HrArrivalInfoDetlEdit(hr_arrivalinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.arrivaldetlld = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("arrivaldetlld", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().GetAll(new hr_arrivalinfodetlEntity { arrivaldetlld = input.arrivaldetlld }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_arrivalinfoEntity> listhr_arrivalinfo = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().GetAll(new hr_arrivalinfoEntity { arrivalld = model.arrivalld }).ToList();
					 //var objhr_arrivalinfo = (from t in listhr_arrivalinfo
					 //select new
					 //{
						//		 Id = t.arrivalld ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_ArrivalInfo = JsonConvert.SerializeObject(objhr_arrivalinfo);

					 //List<hr_flightinfodetlEntity> listhr_flightinfodetl = KAF.FacadeCreatorObjects.hr_flightinfodetlFCC.GetFacadeCreate().GetAll(new hr_flightinfodetlEntity { flightdetlid = model.flightdetlid }).ToList();
					 //var objhr_flightinfodetl = (from t in listhr_flightinfodetl
					 //select new
					 //{
						//		 Id = t.flightdetlid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_FlightInfoDetl = JsonConvert.SerializeObject(objhr_flightinfodetl);

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
                return PartialView("_HrArrivalInfoDetlEdit", model);
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
        public async Task<ActionResult> HrArrivalInfoDetlUpdate(hr_arrivalinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("arrivaldetlld");
				 ModelState.Remove("arrivalld");
				 ModelState.Remove("flightdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrArrivalInfoDetl

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
        public async Task<ActionResult> HrArrivalInfoDetlDelete(hr_arrivalinfodetlEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("arrivaldetlld"); */
				 ModelState.Remove("arrivalld");
				 ModelState.Remove("flightdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.arrivaldetlld = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("arrivaldetlld", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrArrivalInfoDetl

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
        public async Task<ActionResult> HrArrivalInfoDetlDetail(hr_arrivalinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.arrivaldetlld = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("arrivaldetlld", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().GetAll(new hr_arrivalinfodetlEntity { arrivaldetlld = input.arrivaldetlld }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_arrivalinfoEntity> listhr_arrivalinfo = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().GetAll(new hr_arrivalinfoEntity { arrivalld = model.arrivalld }).ToList();
					 //var objhr_arrivalinfo = (from t in listhr_arrivalinfo
					 //select new
					 //{
						//		 Id = t.arrivalld ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_ArrivalInfo = JsonConvert.SerializeObject(objhr_arrivalinfo);

					 //List<hr_flightinfodetlEntity> listhr_flightinfodetl = KAF.FacadeCreatorObjects.hr_flightinfodetlFCC.GetFacadeCreate().GetAll(new hr_flightinfodetlEntity { flightdetlid = model.flightdetlid }).ToList();
					 //var objhr_flightinfodetl = (from t in listhr_flightinfodetl
					 //select new
					 //{
						//		 Id = t.flightdetlid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_FlightInfoDetl = JsonConvert.SerializeObject(objhr_flightinfodetl);

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
                return PartialView("_HrArrivalInfoDetlDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



