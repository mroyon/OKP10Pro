
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
    public class GenCurrencyExchageRateController : BaseController
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
        public async Task<ActionResult> GenCurrencyExchageRate()
        {
            return View("GenCurrencyExchageRateLanding");
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
        public async Task<ActionResult> GenCurrencyExchageRateTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, gen_currencyexchagerateEntity input)
        {
            gen_currencyexchagerateEntity objowin_gen_currencyexchagerate = new gen_currencyexchagerateEntity();
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
           
                List<gen_currencyexchagerateEntity> data = this.GetAllGenCurrencyExchageRateData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    long? maxid = data.OrderByDescending(p => p.currencyexchagerateid).FirstOrDefault().currencyexchagerateid;

                    var tut = (from t in data
                               select new
                               {
									 t.currencyexchagerateid,
									 t.fromcurrencyname,
									 t.tocurrencyname,
									 t.rate,
									 t.ratedatefrom,
									 t.ratedateto,
									 t.remarks,
                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.currencyexchagerateid.GetValueOrDefault(-99), "currencyexchagerateid", this.HttpContext.User.Identity as ClaimsIdentity,
                                  t.currencyexchagerateid==maxid? "GenCurrencyExchageRate/GenCurrencyExchageRateEdit":"", "GenCurrencyExchageRateEdit", 
                                   "", "GenCurrencyExchageRateDelete",
                                   "", "GenCurrencyExchageRateDetail")
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
        
        
        List<gen_currencyexchagerateEntity> GetAllGenCurrencyExchageRateData(gen_currencyexchagerateEntity objgen_currencyexchagerateEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<gen_currencyexchagerateEntity> listobjgen_currencyexchagerateEntity = new List<gen_currencyexchagerateEntity>();
            try
            {
                listobjgen_currencyexchagerateEntity = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().GAPgListView((objgen_currencyexchagerateEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjgen_currencyexchagerateEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "currencyexchagerateid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "fromcurrencyname" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "tocurrencyname" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "rate" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "ratedatefrom" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "ratedateto" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "currencyexchagerateid" + " " + orderDir;
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
        
        
        
         #region Create GenCurrencyExchageRate

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
        public async Task<ActionResult> GenCurrencyExchageRateNew(gen_currencyexchagerateEntity input)
        {
            try
            {
                ModelState.Clear();
                gen_currencyexchagerateEntity model = new gen_currencyexchagerateEntity();

                var objLast = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().GetAll(new gen_currencyexchagerateEntity { 
                
                }).OrderByDescending(p=>p.currencyexchagerateid).ToList().FirstOrDefault();
                
                if(objLast!=null )
                {
                   
                    if (objLast.ratedateto != null)
                    {
                        model.ratedatefrom = objLast.ratedateto.Value.AddDays(1);
                        model.strValue1 = objLast.ratedateto.Value.AddDays(1).ToString("dd-MM-yyyy");
                    }
                    else if (objLast.ratedateto==null && objLast.ratedatefrom != null)
                    {
                        model.ratedatefrom = objLast.ratedatefrom.Value.AddDays(30);
                        model.strValue1 = objLast.ratedatefrom.Value.AddDays(10).ToString("dd-MM-yyyy");
                    }
                }

                return PartialView("_GenCurrencyExchageRateNew", model);
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
        public async Task<ActionResult> GenCurrencyExchageRateInsert(gen_currencyexchagerateEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("currencyexchagerateid");
				 ModelState.Remove("fromcurrencyname");
				 ModelState.Remove("tocurrencyname");
				 ModelState.Remove("rate");
				 ModelState.Remove("ratedatefrom");
				 ModelState.Remove("ratedateto");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update GenCurrencyExchageRate

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
        public async Task<ActionResult> GenCurrencyExchageRateEdit(gen_currencyexchagerateEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.currencyexchagerateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("currencyexchagerateid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().GetAll(new gen_currencyexchagerateEntity { currencyexchagerateid = input.currencyexchagerateid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                var objLast = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().GetAll(new gen_currencyexchagerateEntity
                {

                }).OrderByDescending(p => p.currencyexchagerateid).Where(p => p.currencyexchagerateid < input.currencyexchagerateid).ToList().FirstOrDefault();

                if (objLast != null)
                {

                    if (objLast.ratedateto != null)
                    {
                        model.ratedatefrom = objLast.ratedateto.Value.AddDays(1);
                        model.strValue1 = objLast.ratedateto.Value.AddDays(1).ToString("dd-MM-yyyy");
                    }
                    else if (objLast.ratedateto == null && objLast.ratedatefrom != null)
                    {
                        model.ratedatefrom = objLast.ratedatefrom.Value.AddDays(30);
                        model.strValue1 = objLast.ratedatefrom.Value.AddDays(10).ToString("dd-MM-yyyy");
                    }
                }



                ModelState.Clear();
                return PartialView("_GenCurrencyExchageRateEdit", model);
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
        public async Task<ActionResult> GenCurrencyExchageRateUpdate(gen_currencyexchagerateEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("currencyexchagerateid");
				 ModelState.Remove("fromcurrencyname");
				 ModelState.Remove("tocurrencyname");
				 ModelState.Remove("rate");
				 ModelState.Remove("ratedatefrom");
				 ModelState.Remove("ratedateto");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete GenCurrencyExchageRate

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
        public async Task<ActionResult> GenCurrencyExchageRateDelete(gen_currencyexchagerateEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("currencyexchagerateid"); */
				 ModelState.Remove("fromcurrencyname");
				 ModelState.Remove("tocurrencyname");
				 ModelState.Remove("rate");
				 ModelState.Remove("ratedatefrom");
				 ModelState.Remove("ratedateto");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.currencyexchagerateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("currencyexchagerateid", input.strModelPrimaryKey).ToString());
               
					var model = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().Delete(input); 
                 
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

        #region detail GenCurrencyExchageRate

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
        public async Task<ActionResult> GenCurrencyExchageRateDetail(gen_currencyexchagerateEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.currencyexchagerateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("currencyexchagerateid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.gen_currencyexchagerateFCC.GetFacadeCreate().GetAll(new gen_currencyexchagerateEntity { currencyexchagerateid = input.currencyexchagerateid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
                
                ModelState.Clear();
                return PartialView("_GenCurrencyExchageRateDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



