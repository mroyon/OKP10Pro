
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
    public class HrVisaIssueInfoDetlController : BaseController
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
        public async Task<ActionResult> HrVisaIssueInfoDetl()
        {
            return View("HrVisaIssueInfoDetlLanding");
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
        public async Task<ActionResult> HrVisaIssueInfoDetlTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_visaissueinfodetlEntity input)
        {
            hr_visaissueinfodetlEntity objowin_hr_visaissueinfodetl = new hr_visaissueinfodetlEntity();
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
           
                List<hr_visaissueinfodetlEntity> data = this.GetAllHrVisaIssueInfoDetlData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.visaissuedetlid,
									 t.visaissueid,
									 t.visademanddetlid,
									 t.hrbasicid,
									 t.hrsvcid,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.visaissuedetlid.GetValueOrDefault(-99), "visaissuedetlid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrVisaIssueInfoDetl/HrVisaIssueInfoDetlEdit", "HrVisaIssueInfoDetlEdit", 
                                   "HrVisaIssueInfoDetl/HrVisaIssueInfoDetlDelete", "HrVisaIssueInfoDetlDelete",
                                   "HrVisaIssueInfoDetl/HrVisaIssueInfoDetlDetail", "HrVisaIssueInfoDetlDetail")
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
        
        
        List<hr_visaissueinfodetlEntity> GetAllHrVisaIssueInfoDetlData(hr_visaissueinfodetlEntity objhr_visaissueinfodetlEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_visaissueinfodetlEntity> listobjhr_visaissueinfodetlEntity = new List<hr_visaissueinfodetlEntity>();
            try
            {
                listobjhr_visaissueinfodetlEntity = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().GAPgListView((objhr_visaissueinfodetlEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_visaissueinfodetlEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "visaissuedetlid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "visaissueid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "visademanddetlid" + " " + orderDir;
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
							 sortingVal = "visaissuedetlid" + " " + orderDir;
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
        
        
        
         #region Create HrVisaIssueInfoDetl

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
        public async Task<ActionResult> HrVisaIssueInfoDetlNew(hr_visaissueinfodetlEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_visaissueinfodetlEntity model = new hr_visaissueinfodetlEntity();
                return PartialView("_HrVisaIssueInfoDetlNew", model);
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
        public async Task<ActionResult> HrVisaIssueInfoDetlInsert(hr_visaissueinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("visaissuedetlid");
				 ModelState.Remove("visaissueid");
				 ModelState.Remove("visademanddetlid");
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
                    
					 ret = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrVisaIssueInfoDetl

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
        public async Task<ActionResult> HrVisaIssueInfoDetlEdit(hr_visaissueinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visaissuedetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visaissuedetlid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().GetAll(new hr_visaissueinfodetlEntity { visaissuedetlid = input.visaissuedetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
				//List<hr_visaissueinfoEntity> listhr_visaissueinfo = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GetAll(new hr_visaissueinfoEntity { visaissueid = model.visaissueid }).ToList();
				//var objhr_visaissueinfo = (from t in listhr_visaissueinfo
				//select new
				//{
				//			Id = t.visaissueid ,
				//			Text = t. 
				//}).ToList();
				//ViewBag.preloadedHr_VisaIssueInfo = JsonConvert.SerializeObject(objhr_visaissueinfo);

				//List<hr_visademandinfodetlEntity> listhr_visademandinfodetl = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().GetAll(new hr_visademandinfodetlEntity { visademanddetlid = model.visademanddetlid }).ToList();
				//var objhr_visademandinfodetl = (from t in listhr_visademandinfodetl
				//select new
				//{
				//			Id = t.visademanddetlid ,
				//			Text = t. 
				//}).ToList();
				//ViewBag.preloadedHr_VisaDemandInfoDetl = JsonConvert.SerializeObject(objhr_visademandinfodetl);

				//List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
				//var objhr_basicprofile = (from t in listhr_basicprofile
				//select new
				//{
				//			Id = t.hrbasicid ,
				//			Text = t. 
				//}).ToList();
				//ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

				//List<hr_svcinfoEntity> listhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrsvcid = model.hrsvcid }).ToList();
				//var objhr_svcinfo = (from t in listhr_svcinfo
				//select new
				//{
				//			Id = t.hrsvcid ,
				//			Text = t. 
				//}).ToList();
				//ViewBag.preloadedHr_SvcInfo = JsonConvert.SerializeObject(objhr_svcinfo);

                
                

                ModelState.Clear();
                return PartialView("_HrVisaIssueInfoDetlEdit", model);
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
        public async Task<ActionResult> HrVisaIssueInfoDetlUpdate(hr_visaissueinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("visaissuedetlid");
				 ModelState.Remove("visaissueid");
				 ModelState.Remove("visademanddetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrVisaIssueInfoDetl

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
        public async Task<ActionResult> HrVisaIssueInfoDetlDelete(hr_visaissueinfodetlEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("visaissuedetlid"); */
				 ModelState.Remove("visaissueid");
				 ModelState.Remove("visademanddetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.visaissuedetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visaissuedetlid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrVisaIssueInfoDetl

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
        public async Task<ActionResult> HrVisaIssueInfoDetlDetail(hr_visaissueinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visaissuedetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visaissuedetlid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().GetAll(new hr_visaissueinfodetlEntity { visaissuedetlid = input.visaissuedetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
				//List<hr_visaissueinfoEntity> listhr_visaissueinfo = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GetAll(new hr_visaissueinfoEntity { visaissueid = model.visaissueid }).ToList();
				//var objhr_visaissueinfo = (from t in listhr_visaissueinfo
				//select new
				//{
				//		 Id = t.visaissueid ,
				//		 Text = t. 
				// }).ToList();
				//ViewBag.preloadedHr_VisaIssueInfo = JsonConvert.SerializeObject(objhr_visaissueinfo);

				//List<hr_visademandinfodetlEntity> listhr_visademandinfodetl = KAF.FacadeCreatorObjects.hr_visademandinfodetlFCC.GetFacadeCreate().GetAll(new hr_visademandinfodetlEntity { visademanddetlid = model.visademanddetlid }).ToList();
				//var objhr_visademandinfodetl = (from t in listhr_visademandinfodetl
				//select new
				//{
				//		 Id = t.visademanddetlid ,
				//		 Text = t. 
				// }).ToList();
				//ViewBag.preloadedHr_VisaDemandInfoDetl = JsonConvert.SerializeObject(objhr_visademandinfodetl);

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
                return PartialView("_HrVisaIssueInfoDetlDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



