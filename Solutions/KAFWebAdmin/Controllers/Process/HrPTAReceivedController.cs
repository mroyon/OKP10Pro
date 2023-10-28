
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
    public class HrPTAReceivedController : BaseController
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
        public async Task<ActionResult> HrPTAReceived()
        {
            return View("HrPTAReceivedLanding");
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
        public async Task<ActionResult> HrPTAReceivedTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_ptareceivedEntity input)
        {
            hr_ptareceivedEntity objowin_hr_ptareceived = new hr_ptareceivedEntity();
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
           
                List<hr_ptareceivedEntity> data = this.GetAllHrPTAReceivedData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach (hr_ptareceivedEntity objsingle in data)
                    {
                        objsingle.totalperson = KAF.FacadeCreatorObjects.hr_ptareceiveddetlFCC.GetFacadeCreate().GetAll(new hr_ptareceiveddetlEntity { ptiid = objsingle.ptiid }).ToList().Count().ToString();
                    }

                    var tut = (from t in data
                               select new
                               {
									 t.ptiid,
									 t.ptademandid,
									 t.ptidate,
									 t.ptiletterdate,
									 t.ptiletterno,
									 t.remarks,
                                     t.totalperson,
                                   t.ex_nvarchar2,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.ptiid.GetValueOrDefault(-99), "ptiid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrPTAReceived/HrPTAReceivedEdit", "HrPTAReceivedEdit", 
                                   "", "HrPTAReceivedDelete",
                                   "", "HrPTAReceivedDetail", "DownloadReport", 7)
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
        
        
        List<hr_ptareceivedEntity> GetAllHrPTAReceivedData(hr_ptareceivedEntity objhr_ptareceivedEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_ptareceivedEntity> listobjhr_ptareceivedEntity = new List<hr_ptareceivedEntity>();
            try
            {
                listobjhr_ptareceivedEntity = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().GAPgListView((objhr_ptareceivedEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_ptareceivedEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "ptiid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "visasentid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "ptidate" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "ptiletterdate" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "ptiletterno" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "ptiid" + " " + orderDir;
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
        
        
        
         #region Create HrPTAReceived

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
        public async Task<ActionResult> HrPTAReceivedNew(hr_ptareceivedEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_ptareceivedEntity model = new hr_ptareceivedEntity();
                return PartialView("_HrPTAReceivedNew", model);
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
        public async Task<ActionResult> HrPTAReceivedInsert(hr_ptareceivedEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_ptareceivedList.Count; ind++)
                {
                    ModelState.Remove("hr_ptareceivedList[" + ind + "].ptidetlid");
                    ModelState.Remove("hr_ptareceivedList[" + ind + "].ptiid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    
					 ret = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().SaveMasterDethr_ptareceiveddetl(input,input.hr_ptareceivedList);
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
        
        
        #region update HrPTAReceived

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
        public async Task<ActionResult> HrPTAReceivedEdit(hr_ptareceivedEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.ptiid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("ptiid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().GetAll(new hr_ptareceivedEntity { ptiid = input.ptiid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_visasentinfoEntity> listhr_visasentinfo = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().GetAll(new hr_visasentinfoEntity { visasentid = model.visasentid }).ToList();
					 //var objhr_visasentinfo = (from t in listhr_visasentinfo
					 //select new
					 //{
						//		 Id = t.visasentid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaSentInfo = JsonConvert.SerializeObject(objhr_visasentinfo);

                
                

                ModelState.Clear();
                return PartialView("_HrPTAReceivedEdit", model);
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
        public async Task<ActionResult> HrPTAReceivedUpdate(hr_ptareceivedEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                if(input.hr_ptareceivedList !=null && input.hr_ptareceivedList.Count>0)
                    for (int ind = 0; ind < input.hr_ptareceivedList.Count; ind++)
                    {
                        ModelState.Remove("hr_ptareceivedList[" + ind + "].ptidetlid");
                        ModelState.Remove("hr_ptareceivedList[" + ind + "].ptiid");
                    }


                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.hr_ptareceivedList != null && input.hr_ptareceivedList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().SaveMasterDethr_ptareceiveddetl(input, input.hr_ptareceivedList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().Update(input);

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

        #region delete HrPTAReceived

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
        public async Task<ActionResult> HrPTAReceivedDelete(hr_ptareceivedEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("ptiid"); */
				 ModelState.Remove("visasentid");
				 ModelState.Remove("ptidate");
				 ModelState.Remove("ptiletterdate");
				 ModelState.Remove("ptiletterno");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.ptiid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("ptiid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrPTAReceived

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
        public async Task<ActionResult> HrPTAReceivedDetail(hr_ptareceivedEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.ptiid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("ptiid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_ptareceivedFCC.GetFacadeCreate().GetAll(new hr_ptareceivedEntity { ptiid = input.ptiid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_visasentinfoEntity> listhr_visasentinfo = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().GetAll(new hr_visasentinfoEntity { visasentid = model.visasentid }).ToList();
					 //var objhr_visasentinfo = (from t in listhr_visasentinfo
					 //select new
					 //{
						//		 Id = t.visasentid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaSentInfo = JsonConvert.SerializeObject(objhr_visasentinfo);

                
                
                ModelState.Clear();
                return PartialView("_HrPTAReceivedDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



