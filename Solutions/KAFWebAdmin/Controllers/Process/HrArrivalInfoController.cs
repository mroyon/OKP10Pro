
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
    public class HrArrivalInfoController : BaseController
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
        public async Task<ActionResult> HrArrivalInfo()
        {
            return View("HrArrivalInfoLanding");
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
        public async Task<ActionResult> HrArrivalInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_arrivalinfoEntity input)
        {
            hr_arrivalinfoEntity objowin_hr_arrivalinfo = new hr_arrivalinfoEntity();
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
           
                List<hr_arrivalinfoEntity> data = this.GetAllHrArrivalInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach (hr_arrivalinfoEntity objsingle in data)
                    {
                        objsingle.totalperson = KAF.FacadeCreatorObjects.hr_arrivalinfodetlFCC.GetFacadeCreate().GetAll(new hr_arrivalinfodetlEntity { arrivalld = objsingle.arrivalld }).ToList().Count().ToString();
                    }

                    var tut = (from t in data
                               select new
                               {
									 t.arrivalld,
									 t.flightid,
									 t.arrivaldate,
									 t.arrivalletterdate,
									 t.arrivalletterno,
									 t.remarks,
                                     t.totalperson,
                                   t.ex_nvarchar2,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.arrivalld.GetValueOrDefault(-99), "arrivalld", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrArrivalInfo/HrArrivalInfoEdit", "HrArrivalInfoEdit", 
                                   "", "HrArrivalInfoDelete",
                                   "", "HrArrivalInfoDetail", "DownloadReport", 9)
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
        
        
        List<hr_arrivalinfoEntity> GetAllHrArrivalInfoData(hr_arrivalinfoEntity objhr_arrivalinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_arrivalinfoEntity> listobjhr_arrivalinfoEntity = new List<hr_arrivalinfoEntity>();
            try
            {
                listobjhr_arrivalinfoEntity = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().GAPgListView((objhr_arrivalinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_arrivalinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "arrivalld" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "flightid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "arrivaldate" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "arrivalletterdate" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "arrivalletterno" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "arrivalld" + " " + orderDir;
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
        
        
        
         #region Create HrArrivalInfo

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
        public async Task<ActionResult> HrArrivalInfoNew(hr_arrivalinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_arrivalinfoEntity model = new hr_arrivalinfoEntity();
                return PartialView("_HrArrivalInfoNew", model);
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
        public async Task<ActionResult> HrArrivalInfoInsert(hr_arrivalinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_arrivalList.Count; ind++)
                {
                    ModelState.Remove("hr_arrivalList[" + ind + "].arrivaldetlld");
                    ModelState.Remove("hr_arrivalList[" + ind + "].arrivalld");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    
					ret = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().SaveMasterDethr_arrivalinfodetl(input,input.hr_arrivalList);
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
        
        
        #region update HrArrivalInfo

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
        public async Task<ActionResult> HrArrivalInfoEdit(hr_arrivalinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.arrivalld = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("arrivalld", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().GetAll(new hr_arrivalinfoEntity { arrivalld = input.arrivalld }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_flightinfoEntity> listhr_flightinfo = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().GetAll(new hr_flightinfoEntity { flightid = model.flightid }).ToList();
					 //var objhr_flightinfo = (from t in listhr_flightinfo
					 //select new
					 //{
						//		 Id = t.flightid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_FlightInfo = JsonConvert.SerializeObject(objhr_flightinfo);

                
                

                ModelState.Clear();
                return PartialView("_HrArrivalInfoEdit", model);
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
        public async Task<ActionResult> HrArrivalInfoUpdate(hr_arrivalinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                if(input.hr_arrivalList!=null && input.hr_arrivalList.Count>0)
                for (int ind = 0; ind < input.hr_arrivalList.Count; ind++)
                {
                    ModelState.Remove("hr_arrivalList[" + ind + "].arrivaldetlld");
                    ModelState.Remove("hr_arrivalList[" + ind + "].arrivalld");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.hr_arrivalList != null && input.hr_arrivalList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().SaveMasterDethr_arrivalinfodetl(input, input.hr_arrivalList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().Update(input);


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

        #region delete HrArrivalInfo

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
        public async Task<ActionResult> HrArrivalInfoDelete(hr_arrivalinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("arrivalld"); */
				 ModelState.Remove("flightid");
				 ModelState.Remove("arrivaldate");
				 ModelState.Remove("arrivalletterdate");
				 ModelState.Remove("arrivalletterno");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.arrivalld = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("arrivalld", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrArrivalInfo

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
        public async Task<ActionResult> HrArrivalInfoDetail(hr_arrivalinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.arrivalld = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("arrivalld", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().GetAll(new hr_arrivalinfoEntity { arrivalld = input.arrivalld }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_flightinfoEntity> listhr_flightinfo = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().GetAll(new hr_flightinfoEntity { flightid = model.flightid }).ToList();
					 //var objhr_flightinfo = (from t in listhr_flightinfo
					 //select new
					 //{
						//		 Id = t.flightid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_FlightInfo = JsonConvert.SerializeObject(objhr_flightinfo);

                
                
                ModelState.Clear();
                return PartialView("_HrArrivalInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



