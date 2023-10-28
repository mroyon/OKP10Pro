
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
    public class HrPTIInfoController : BaseController
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
        public async Task<ActionResult> HrPTIInfo()
        {
            return View("HrPTIInfoLanding");
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
        public async Task<ActionResult> HrPTIInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_ptademandEntity input)
        {
            hr_ptademandEntity objowin_hr_ptademand = new hr_ptademandEntity();
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
           
                List<hr_ptademandEntity> data = this.GetAllHrPTIInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach (hr_ptademandEntity objsingle in data)
                    {
                        objsingle.totalperson = KAF.FacadeCreatorObjects.hr_ptademanddetlFCC.GetFacadeCreate().GetAll(new hr_ptademanddetlEntity { ptademandid = objsingle.ptademandid }).ToList().Count().ToString();
                    }


                    var tut = (from t in data
                               select new
                               {
									 t.ptademandid,
									 t.visasentid,
									 t.ptidate,
									 t.ptiletterdate,
									 t.ptiletterno,
									 t.remarks,
                                     t.totalperson,
                                   t.ex_nvarchar2,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.ptademandid.GetValueOrDefault(-99), "ptademandid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrPTIInfo/HrPTIInfoEdit", "HrPTIInfoEdit", 
                                   "", "HrPTIInfoDelete",
                                   "", "HrPTIInfoDetail", "DownloadReport", 6)
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
        
        
        List<hr_ptademandEntity> GetAllHrPTIInfoData(hr_ptademandEntity objhr_ptademandEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_ptademandEntity> listobjhr_ptademandEntity = new List<hr_ptademandEntity>();
            try
            {
                listobjhr_ptademandEntity = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().GAPgListView((objhr_ptademandEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_ptademandEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "ptademandid" + " " + orderDir;
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
							 sortingVal = "ptademandid" + " " + orderDir;
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
        
        
        
         #region Create HrPTIInfo

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
        public async Task<ActionResult> HrPTIInfoNew(hr_ptademandEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_ptademandEntity model = new hr_ptademandEntity();
                return PartialView("_HrPTIInfoNew", model);
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
        public async Task<ActionResult> HrPTIInfoInsert(hr_ptademandEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_ptademandList.Count; ind++)
                {
                    ModelState.Remove("hr_ptademandList[" + ind + "].ptidemanddetlid");
                    ModelState.Remove("hr_ptademandList[" + ind + "].ptademandid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    
					 ret = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().SaveMasterDethr_ptademanddetl(input,input.hr_ptademandList);
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
        
        
        #region update HrPTIInfo

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
        public async Task<ActionResult> HrPTIInfoEdit(hr_ptademandEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.ptademandid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("ptademandid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().GetAll(new hr_ptademandEntity { ptademandid = input.ptademandid }).SingleOrDefault();
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
                return PartialView("_HrPTIInfoEdit", model);
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
        public async Task<ActionResult> HrPTIInfoUpdate(hr_ptademandEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                if(input.hr_ptademandList !=null && input.hr_ptademandList.Count>0)
                    for (int ind = 0; ind < input.hr_ptademandList.Count; ind++)
                    {
                        ModelState.Remove("hr_ptademandList[" + ind + "].ptidemanddetlid");
                        ModelState.Remove("hr_ptademandList[" + ind + "].ptademandid");
                    }


                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.hr_ptademandList != null && input.hr_ptademandList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().SaveMasterDethr_ptademanddetl(input, input.hr_ptademandList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().Update(input);

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

        #region delete HrPTIInfo

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
        public async Task<ActionResult> HrPTIInfoDelete(hr_ptademandEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("ptademandid"); */
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
                    input.ptademandid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("ptademandid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrPTIInfo

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
        public async Task<ActionResult> HrPTIInfoDetail(hr_ptademandEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.ptademandid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("ptademandid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().GetAll(new hr_ptademandEntity { ptademandid = input.ptademandid }).SingleOrDefault();
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
                return PartialView("_HrPTIInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



