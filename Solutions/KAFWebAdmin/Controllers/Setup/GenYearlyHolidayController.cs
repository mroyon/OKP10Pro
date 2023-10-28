
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
    public class GenYearlyHolidayController : BaseController
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
        public async Task<ActionResult> GenYearlyHoliday()
        {
            return View("GenYearlyHolidayLanding");
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
        public async Task<ActionResult> GenYearlyHolidayTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, gen_yearlyholidayEntity input)
        {
            gen_yearlyholidayEntity objowin_gen_yearlyholiday = new gen_yearlyholidayEntity();
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
           
                List<gen_yearlyholidayEntity> data = this.GetAllGenYearlyHolidayData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.holidayid,
									 t.holidaydate,
									 t.holidayname,
									 t.holidaytype,
									 t.holidaymonth,
									 t.holidayday,
									 t.holidayyear,
									 t.dayname,
									 t.monthname,
									 t.isfixedforallyear,
									 t.isweekday,
									 t.isbusinessday,
									 t.previousbusinessday,
									 t.nextbusinessday,
									 t.isleapyear,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.holidayid.GetValueOrDefault(-99), "holidayid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "GenYearlyHoliday/GenYearlyHolidayEdit", "GenYearlyHolidayEdit", 
                                   "GenYearlyHoliday/GenYearlyHolidayDelete", "GenYearlyHolidayDelete",
                                   "GenYearlyHoliday/GenYearlyHolidayDetail", "GenYearlyHolidayDetail")
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
        
        
        List<gen_yearlyholidayEntity> GetAllGenYearlyHolidayData(gen_yearlyholidayEntity objgen_yearlyholidayEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<gen_yearlyholidayEntity> listobjgen_yearlyholidayEntity = new List<gen_yearlyholidayEntity>();
            try
            {
                listobjgen_yearlyholidayEntity = KAF.FacadeCreatorObjects.gen_yearlyholidayFCC.GetFacadeCreate().GAPgListView((objgen_yearlyholidayEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjgen_yearlyholidayEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "holidayid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "holidaydate" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "holidayname" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "holidaytype" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "holidaymonth" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "holidayday" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "holidayyear" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "dayname" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "monthname" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "isfixedforallyear" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "isweekday" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "isbusinessday" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "previousbusinessday" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "nextbusinessday" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "isleapyear" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "holidayid" + " " + orderDir;
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
        
        
        
         #region Create GenYearlyHoliday

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
        public async Task<ActionResult> GenYearlyHolidayNew(gen_yearlyholidayEntity input)
        {
            try
            {
                ModelState.Clear();
                gen_yearlyholidayEntity model = new gen_yearlyholidayEntity();
                return PartialView("_GenYearlyHolidayNew", model);
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
        public async Task<ActionResult> GenYearlyHolidayInsert(gen_yearlyholidayEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("holidayid");
				 ModelState.Remove("holidaydate");
				 ModelState.Remove("holidayname");
				 ModelState.Remove("holidaytype");
				 ModelState.Remove("holidaymonth");
				 ModelState.Remove("holidayday");
				 ModelState.Remove("holidayyear");
				 ModelState.Remove("dayname");
				 ModelState.Remove("monthname");
				 ModelState.Remove("isfixedforallyear");
				 ModelState.Remove("isweekday");
				 ModelState.Remove("isbusinessday");
				 ModelState.Remove("previousbusinessday");
				 ModelState.Remove("nextbusinessday");
				 ModelState.Remove("isleapyear");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.gen_yearlyholidayFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update GenYearlyHoliday

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
        public async Task<ActionResult> GenYearlyHolidayEdit(gen_yearlyholidayEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.holidayid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("holidayid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.gen_yearlyholidayFCC.GetFacadeCreate().GetAll(new gen_yearlyholidayEntity { holidayid = input.holidayid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                
                

                ModelState.Clear();
                return PartialView("_GenYearlyHolidayEdit", model);
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
        public async Task<ActionResult> GenYearlyHolidayUpdate(gen_yearlyholidayEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("holidayid");
				 ModelState.Remove("holidaydate");
				 ModelState.Remove("holidayname");
				 ModelState.Remove("holidaytype");
				 ModelState.Remove("holidaymonth");
				 ModelState.Remove("holidayday");
				 ModelState.Remove("holidayyear");
				 ModelState.Remove("dayname");
				 ModelState.Remove("monthname");
				 ModelState.Remove("isfixedforallyear");
				 ModelState.Remove("isweekday");
				 ModelState.Remove("isbusinessday");
				 ModelState.Remove("previousbusinessday");
				 ModelState.Remove("nextbusinessday");
				 ModelState.Remove("isleapyear");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.gen_yearlyholidayFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete GenYearlyHoliday

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
        public async Task<ActionResult> GenYearlyHolidayDelete(gen_yearlyholidayEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("holidayid"); */
				 ModelState.Remove("holidaydate");
				 ModelState.Remove("holidayname");
				 ModelState.Remove("holidaytype");
				 ModelState.Remove("holidaymonth");
				 ModelState.Remove("holidayday");
				 ModelState.Remove("holidayyear");
				 ModelState.Remove("dayname");
				 ModelState.Remove("monthname");
				 ModelState.Remove("isfixedforallyear");
				 ModelState.Remove("isweekday");
				 ModelState.Remove("isbusinessday");
				 ModelState.Remove("previousbusinessday");
				 ModelState.Remove("nextbusinessday");
				 ModelState.Remove("isleapyear");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.holidayid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("holidayid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.gen_yearlyholidayFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail GenYearlyHoliday

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
        public async Task<ActionResult> GenYearlyHolidayDetail(gen_yearlyholidayEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.holidayid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("holidayid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.gen_yearlyholidayFCC.GetFacadeCreate().GetAll(new gen_yearlyholidayEntity { holidayid = input.holidayid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
                
                ModelState.Clear();
                return PartialView("_GenYearlyHolidayDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



