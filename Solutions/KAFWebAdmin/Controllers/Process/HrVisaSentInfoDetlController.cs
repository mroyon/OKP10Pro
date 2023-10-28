
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
    public class HrVisaSentInfoDetlController : BaseController
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
        public async Task<ActionResult> HrVisaSentInfoDetl()
        {
            return View("HrVisaSentInfoDetlLanding");
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
        public async Task<ActionResult> HrVisaSentInfoDetlTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_visasentinfodetlEntity input)
        {
            hr_visasentinfodetlEntity objowin_hr_visasentinfodetl = new hr_visasentinfodetlEntity();
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
           
                List<hr_visasentinfodetlEntity> data = this.GetAllHrVisaSentInfoDetlData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.visasentdetlid,
									 t.visasentid,
									 t.visaissuedetlid,
									 t.hrbasicid,
									 t.hrsvcid,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.visasentdetlid.GetValueOrDefault(-99), "visasentdetlid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrVisaSentInfoDetl/HrVisaSentInfoDetlEdit", "HrVisaSentInfoDetlEdit", 
                                   "HrVisaSentInfoDetl/HrVisaSentInfoDetlDelete", "HrVisaSentInfoDetlDelete",
                                   "HrVisaSentInfoDetl/HrVisaSentInfoDetlDetail", "HrVisaSentInfoDetlDetail")
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
        
        
        List<hr_visasentinfodetlEntity> GetAllHrVisaSentInfoDetlData(hr_visasentinfodetlEntity objhr_visasentinfodetlEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_visasentinfodetlEntity> listobjhr_visasentinfodetlEntity = new List<hr_visasentinfodetlEntity>();
            try
            {
                listobjhr_visasentinfodetlEntity = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().GAPgListView((objhr_visasentinfodetlEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_visasentinfodetlEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "visasentdetlid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "visasentid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "visaissuedetlid" + " " + orderDir;
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
							 sortingVal = "visasentdetlid" + " " + orderDir;
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
        
        
        
         #region Create HrVisaSentInfoDetl

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
        public async Task<ActionResult> HrVisaSentInfoDetlNew(hr_visasentinfodetlEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_visasentinfodetlEntity model = new hr_visasentinfodetlEntity();
                return PartialView("_HrVisaSentInfoDetlNew", model);
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
        public async Task<ActionResult> HrVisaSentInfoDetlInsert(hr_visasentinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("visasentdetlid");
				 ModelState.Remove("visasentid");
				 ModelState.Remove("visaissuedetlid");
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
                    
					 ret = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrVisaSentInfoDetl

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
        public async Task<ActionResult> HrVisaSentInfoDetlEdit(hr_visasentinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visasentdetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visasentdetlid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().GetAll(new hr_visasentinfodetlEntity { visasentdetlid = input.visasentdetlid }).SingleOrDefault();
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

					 //List<hr_visaissueinfodetlEntity> listhr_visaissueinfodetl = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().GetAll(new hr_visaissueinfodetlEntity { visaissuedetlid = model.visaissuedetlid }).ToList();
					 //var objhr_visaissueinfodetl = (from t in listhr_visaissueinfodetl
					 //select new
					 //{
						//		 Id = t.visaissuedetlid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaIssueInfoDetl = JsonConvert.SerializeObject(objhr_visaissueinfodetl);

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
                return PartialView("_HrVisaSentInfoDetlEdit", model);
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
        public async Task<ActionResult> HrVisaSentInfoDetlUpdate(hr_visasentinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("visasentdetlid");
				 ModelState.Remove("visasentid");
				 ModelState.Remove("visaissuedetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrVisaSentInfoDetl

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
        public async Task<ActionResult> HrVisaSentInfoDetlDelete(hr_visasentinfodetlEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("visasentdetlid"); */
				 ModelState.Remove("visasentid");
				 ModelState.Remove("visaissuedetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.visasentdetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visasentdetlid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrVisaSentInfoDetl

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
        public async Task<ActionResult> HrVisaSentInfoDetlDetail(hr_visasentinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visasentdetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visasentdetlid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().GetAll(new hr_visasentinfodetlEntity { visasentdetlid = input.visasentdetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_visasentinfoEntity> listhr_visasentinfo = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().GetAll(new hr_visasentinfoEntity { visasentid = model.visasentid }).ToList();
					 //var objhr_visasentinfo = (from t in listhr_visasentinfo
					 //select new
					 //{
						//		 Id = t.visasentid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaSentInfo = JsonConvert.SerializeObject(objhr_visasentinfo);

					 //List<hr_visaissueinfodetlEntity> listhr_visaissueinfodetl = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().GetAll(new hr_visaissueinfodetlEntity { visaissuedetlid = model.visaissuedetlid }).ToList();
					 //var objhr_visaissueinfodetl = (from t in listhr_visaissueinfodetl
					 //select new
					 //{
						//		 Id = t.visaissuedetlid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaIssueInfoDetl = JsonConvert.SerializeObject(objhr_visaissueinfodetl);

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
                return PartialView("_HrVisaSentInfoDetlDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



