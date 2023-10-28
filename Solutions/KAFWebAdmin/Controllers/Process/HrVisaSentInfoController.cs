
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
    public class HrVisaSentInfoController : BaseController
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
        public async Task<ActionResult> HrVisaSentInfo()
        {
            return View("HrVisaSentInfoLanding");
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
        public async Task<ActionResult> HrVisaSentInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_visasentinfoEntity input)
        {
            hr_visasentinfoEntity objowin_hr_visasentinfo = new hr_visasentinfoEntity();
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
           
                List<hr_visasentinfoEntity> data = this.GetAllHrVisaSentInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach (hr_visasentinfoEntity objsingle in data)
                    {
                        objsingle.totalperson = KAF.FacadeCreatorObjects.hr_visasentinfodetlFCC.GetFacadeCreate().GetAll(new hr_visasentinfodetlEntity{ visasentid = objsingle.visasentid }).ToList().Count().ToString();
                    }

                    var tut = (from t in data
                               select new
                               {
									 t.visasentid,
									 t.visaissueid,
									 t.visasentdate,
									 t.visasentletterdate,
									 t.visasentletterno,
									 t.remarks,
                                     t.totalperson,
                                   t.ex_nvarchar2,

                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.visasentid.GetValueOrDefault(-99), "visasentid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrVisaSentInfo/HrVisaSentInfoEdit", "HrVisaSentInfoEdit", 
                                   "", "HrVisaSentInfoDelete",
                                   "", "HrVisaSentInfoDetail", "DownloadReport", 5)
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
        
        
        List<hr_visasentinfoEntity> GetAllHrVisaSentInfoData(hr_visasentinfoEntity objhr_visasentinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_visasentinfoEntity> listobjhr_visasentinfoEntity = new List<hr_visasentinfoEntity>();
            try
            {
                listobjhr_visasentinfoEntity = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().GAPgListView((objhr_visasentinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_visasentinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "visasentid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "visaissueid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "visasentdate" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "visasentletterdate" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "visasentletterno" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "visasentid" + " " + orderDir;
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
        
        
        
         #region Create HrVisaSentInfo

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
        public async Task<ActionResult> HrVisaSentInfoNew(hr_visasentinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_visasentinfoEntity model = new hr_visasentinfoEntity();
                return PartialView("_HrVisaSentInfoNew", model);
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
        public async Task<ActionResult> HrVisaSentInfoInsert(hr_visasentinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_visasentList.Count; ind++)
                {
                    ModelState.Remove("hr_visasentList[" + ind + "].visasentdetlid");
                    ModelState.Remove("hr_visasentList[" + ind + "].visasentid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                   
					ret = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().SaveMasterDethr_visasentinfodetl(input,input.hr_visasentList);

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
        
        
        #region update HrVisaSentInfo

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
        public async Task<ActionResult> HrVisaSentInfoEdit(hr_visasentinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visasentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visasentid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().GetAll(new hr_visasentinfoEntity { visasentid = input.visasentid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_visaissueinfoEntity> listhr_visaissueinfo = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GetAll(new hr_visaissueinfoEntity { visaissueid = model.visaissueid }).ToList();
					 //var objhr_visaissueinfo = (from t in listhr_visaissueinfo
					 //select new
					 //{
						//		 Id = t.visaissueid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaIssueInfo = JsonConvert.SerializeObject(objhr_visaissueinfo);

                
                

                ModelState.Clear();
                return PartialView("_HrVisaSentInfoEdit", model);
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
        public async Task<ActionResult> HrVisaSentInfoUpdate(hr_visasentinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                if(input.hr_visasentList!=null && input.hr_visasentList.Count>0)
                for (int ind = 0; ind < input.hr_visasentList.Count; ind++)
                {
                    ModelState.Remove("hr_visasentList[" + ind + "].visasentdetlid");
                    ModelState.Remove("hr_visasentList[" + ind + "].visasentid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.hr_visasentList != null && input.hr_visasentList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().SaveMasterDethr_visasentinfodetl(input, input.hr_visasentList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().Update(input);

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

        #region delete HrVisaSentInfo

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
        public async Task<ActionResult> HrVisaSentInfoDelete(hr_visasentinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("visasentid"); */
				 ModelState.Remove("visaissueid");
				 ModelState.Remove("visasentdate");
				 ModelState.Remove("visasentletterdate");
				 ModelState.Remove("visasentletterno");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.visasentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visasentid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrVisaSentInfo

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
        public async Task<ActionResult> HrVisaSentInfoDetail(hr_visasentinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visasentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visasentid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_visasentinfoFCC.GetFacadeCreate().GetAll(new hr_visasentinfoEntity { visasentid = input.visasentid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_visaissueinfoEntity> listhr_visaissueinfo = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GetAll(new hr_visaissueinfoEntity { visaissueid = model.visaissueid }).ToList();
					 //var objhr_visaissueinfo = (from t in listhr_visaissueinfo
					 //select new
					 //{
						//		 Id = t.visaissueid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_VisaIssueInfo = JsonConvert.SerializeObject(objhr_visaissueinfo);

                
                
                ModelState.Clear();
                return PartialView("_HrVisaSentInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



