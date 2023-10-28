
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
    public class HrRepPassportInfoDetlController : BaseController
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
        public async Task<ActionResult> HrRepPassportInfoDetl()
        {
            return View("HrRepPassportInfoDetlLanding");
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
        public async Task<ActionResult> HrRepPassportInfoDetlTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_reppassportinfodetlEntity input)
        {
            hr_reppassportinfodetlEntity objowin_hr_reppassportinfodetl = new hr_reppassportinfodetlEntity();
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
           
                List<hr_reppassportinfodetlEntity> data = this.GetAllHrRepPassportInfoDetlData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.reppassportdetlid,
									 t.reppassportid,
									 t.replacementdetlid,
									 t.hrbasicid,
									 t.hrsvcid,
									 t.newhrbasicid,
									 t.newhrsvcid,
									 t.newpassportno,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.reppassportdetlid.GetValueOrDefault(-99), "reppassportdetlid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrRepPassportInfoDetl/HrRepPassportInfoDetlEdit", "HrRepPassportInfoDetlEdit", 
                                   "HrRepPassportInfoDetl/HrRepPassportInfoDetlDelete", "HrRepPassportInfoDetlDelete",
                                   "HrRepPassportInfoDetl/HrRepPassportInfoDetlDetail", "HrRepPassportInfoDetlDetail")
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
        
        
        List<hr_reppassportinfodetlEntity> GetAllHrRepPassportInfoDetlData(hr_reppassportinfodetlEntity objhr_reppassportinfodetlEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_reppassportinfodetlEntity> listobjhr_reppassportinfodetlEntity = new List<hr_reppassportinfodetlEntity>();
            try
            {
                listobjhr_reppassportinfodetlEntity = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().GAPgListView((objhr_reppassportinfodetlEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_reppassportinfodetlEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "reppassportdetlid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "reppassportid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "replacementdetlid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "hrsvcid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "newhrbasicid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "newhrsvcid" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "newpassportno" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "reppassportdetlid" + " " + orderDir;
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
        
        
        
         #region Create HrRepPassportInfoDetl

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
        public async Task<ActionResult> HrRepPassportInfoDetlNew(hr_reppassportinfodetlEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_reppassportinfodetlEntity model = new hr_reppassportinfodetlEntity();
                return PartialView("_HrRepPassportInfoDetlNew", model);
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
        public async Task<ActionResult> HrRepPassportInfoDetlInsert(hr_reppassportinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("reppassportdetlid");
				 ModelState.Remove("reppassportid");
				 ModelState.Remove("replacementdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("newhrbasicid");
				 ModelState.Remove("newhrsvcid");
				 ModelState.Remove("newpassportno");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrRepPassportInfoDetl

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
        public async Task<ActionResult> HrRepPassportInfoDetlEdit(hr_reppassportinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.reppassportdetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("reppassportdetlid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().GetAll(new hr_reppassportinfodetlEntity { reppassportdetlid = input.reppassportdetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_reppassportinfoEntity> listhr_reppassportinfo = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().GetAll(new hr_reppassportinfoEntity { reppassportid = model.reppassportid }).ToList();
					 //var objhr_reppassportinfo = (from t in listhr_reppassportinfo
					 //select new
					 //{
						//		 Id = t.reppassportid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_RepPassportInfo = JsonConvert.SerializeObject(objhr_reppassportinfo);

					 //List<hr_replacementinfodetlEntity> listhr_replacementinfodetl = KAF.FacadeCreatorObjects.hr_replacementinfodetlFCC.GetFacadeCreate().GetAll(new hr_replacementinfodetlEntity { replacementdetlid = model.replacementdetlid }).ToList();
					 //var objhr_replacementinfodetl = (from t in listhr_replacementinfodetl
					 //select new
					 //{
						//		 Id = t.replacementdetlid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_ReplacementInfoDetl = JsonConvert.SerializeObject(objhr_replacementinfodetl);

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

					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.newhrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 //List<hr_svcinfoEntity> listhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrsvcid = model.newhrsvcid }).ToList();
					 //var objhr_svcinfo = (from t in listhr_svcinfo
					 //select new
					 //{
						//		 Id = t.hrsvcid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_SvcInfo = JsonConvert.SerializeObject(objhr_svcinfo);

                
                

                ModelState.Clear();
                return PartialView("_HrRepPassportInfoDetlEdit", model);
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
        public async Task<ActionResult> HrRepPassportInfoDetlUpdate(hr_reppassportinfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("reppassportdetlid");
				 ModelState.Remove("reppassportid");
				 ModelState.Remove("replacementdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("newhrbasicid");
				 ModelState.Remove("newhrsvcid");
				 ModelState.Remove("newpassportno");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrRepPassportInfoDetl

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
        public async Task<ActionResult> HrRepPassportInfoDetlDelete(hr_reppassportinfodetlEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("reppassportdetlid"); */
				 ModelState.Remove("reppassportid");
				 ModelState.Remove("replacementdetlid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("newhrbasicid");
				 ModelState.Remove("newhrsvcid");
				 ModelState.Remove("newpassportno");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.reppassportdetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("reppassportdetlid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrRepPassportInfoDetl

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
        public async Task<ActionResult> HrRepPassportInfoDetlDetail(hr_reppassportinfodetlEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.reppassportdetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("reppassportdetlid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().GetAll(new hr_reppassportinfodetlEntity { reppassportdetlid = input.reppassportdetlid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_reppassportinfoEntity> listhr_reppassportinfo = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().GetAll(new hr_reppassportinfoEntity { reppassportid = model.reppassportid }).ToList();
					 //var objhr_reppassportinfo = (from t in listhr_reppassportinfo
					 //select new
					 //{
						//		 Id = t.reppassportid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_RepPassportInfo = JsonConvert.SerializeObject(objhr_reppassportinfo);

					 //List<hr_replacementinfodetlEntity> listhr_replacementinfodetl = KAF.FacadeCreatorObjects.hr_replacementinfodetlFCC.GetFacadeCreate().GetAll(new hr_replacementinfodetlEntity { replacementdetlid = model.replacementdetlid }).ToList();
					 //var objhr_replacementinfodetl = (from t in listhr_replacementinfodetl
					 //select new
					 //{
						//		 Id = t.replacementdetlid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_ReplacementInfoDetl = JsonConvert.SerializeObject(objhr_replacementinfodetl);

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

					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.newhrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 //List<hr_svcinfoEntity> listhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrsvcid = model.newhrsvcid }).ToList();
					 //var objhr_svcinfo = (from t in listhr_svcinfo
					 //select new
					 //{
						//		 Id = t.hrsvcid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_SvcInfo = JsonConvert.SerializeObject(objhr_svcinfo);

                
                
                ModelState.Clear();
                return PartialView("_HrRepPassportInfoDetlDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



