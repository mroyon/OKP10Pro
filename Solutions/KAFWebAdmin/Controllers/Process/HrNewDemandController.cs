
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
    public class HrNewDemandController : BaseController
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
        public async Task<ActionResult> HrNewDemand()
        {
            return View("HrNewDemandLanding");
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
        public async Task<ActionResult> HrNewDemandTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_newdemandEntity input)
        {
            hr_newdemandEntity objowin_hr_newdemand = new hr_newdemandEntity();
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
           
                List<hr_newdemandEntity> data = this.GetAllHrNewDemandData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.newdemandid,
									 t.demandletterno,
									 t.demandletterdate,
									 t.remarks,
                                     t.totalperson,
                                   t.LetterStatus,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.newdemandid.GetValueOrDefault(-99), "newdemandid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrNewDemand/HrNewDemandEdit", "HrNewDemandEdit", 
                                   "", "",
                                   "", "", "DownloadReport", 13)
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
        
        
        List<hr_newdemandEntity> GetAllHrNewDemandData(hr_newdemandEntity objhr_newdemandEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_newdemandEntity> listobjhr_newdemandEntity = new List<hr_newdemandEntity>();
            try
            {
                listobjhr_newdemandEntity = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().GAPgListView_Ext((objhr_newdemandEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_newdemandEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "newdemandid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "demandletterno" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "demandletterdate" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "newdemandid" + " " + orderDir;
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
        
        
        
         #region Create HrNewDemand

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
        public async Task<ActionResult> HrNewDemandNew(hr_newdemandEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_newdemandEntity model = new hr_newdemandEntity();
                //model.hr_newdemanddetl = new hr_newdemanddetlEntity();
                //model.hr_newdemanddetl.ex_nvarchar2 = "New";
                return PartialView("_HrNewDemandNew", model);
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
        public async Task<ActionResult> HrNewDemandInsert(hr_newdemandEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("newdemandid");
				 ModelState.Remove("demandletterno");
				 ModelState.Remove("demandletterdate");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().Add_Ext(input);
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
        
        
        #region update HrNewDemand

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
        public async Task<ActionResult> HrNewDemandEdit(hr_newdemandEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.newdemandid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("newdemandid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().GetAll(new hr_newdemandEntity { newdemandid = input.newdemandid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN

                
                ModelState.Clear();
                return PartialView("_HrNewDemandEdit", model);
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
        public async Task<ActionResult> HrNewDemandUpdate(hr_newdemandEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("newdemandid");
				 ModelState.Remove("demandletterno");
				 ModelState.Remove("demandletterdate");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.strValue1 = input.strValue1.Trim(',');
                    ret = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().Update_Ext(input);
                    
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

        #region delete HrNewDemand

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
        public async Task<ActionResult> HrNewDemandDelete(hr_newdemandEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("newdemandid"); */
				 ModelState.Remove("demandletterno");
				 ModelState.Remove("demandletterdate");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.newdemandid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("newdemandid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().Delete_Ext(input);
                 
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

        #region detail HrNewDemand

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
        public async Task<ActionResult> HrNewDemandDetail(hr_newdemandEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.newdemandid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("newdemandid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().GetAll(new hr_newdemandEntity { newdemandid = input.newdemandid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
                
                ModelState.Clear();
                return PartialView("_HrNewDemandDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion


        ////Create Single Row Replacement
        //[HttpPost]
        //[AuthorizeFilterAttribute]
        //[ValidateInput(true)]
        //[ValidateAntiForgeryToken]
        //[AllowCrossSiteJsonAttribute]
        //[SecurityFillerAttribute]
        //[LoggingFilterAttribute]
        //[RequestValidationAttribute]
        //[ExceptionFilterAttribute]
        public async Task<ActionResult> HrNewDemandSignleRow(hr_newdemandEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_newdemandEntity model = new hr_newdemandEntity();
                model.newdemandid = input.newdemandid;
                model.hr_newdemanddetl = input.hr_newdemanddetl;
                //if (input.hr_newdemanddetl == null) model.hr_newdemanddetl = null;
                if (input.hr_newdemanddetl != null && input.hr_newdemanddetl.rankid != null)
                {
                    List<gen_rankEntity> listgen_rankKW = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = input.hr_newdemanddetl.rankid }).ToList();
                    var objgen_rankKW = (from t in listgen_rankKW
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankKW = JsonConvert.SerializeObject(objgen_rankKW);
                }

                if (input.hr_newdemanddetl != null && input.hr_newdemanddetl.tradeid != null)
                {
                    List<gen_tradeEntity> listgen_tradeKW = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = input.hr_newdemanddetl.tradeid }).ToList();
                    var objgen_tradeKW = (from t in listgen_tradeKW
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeKW = JsonConvert.SerializeObject(objgen_tradeKW);
                }

                if (input.hr_newdemanddetl != null && input.hr_newdemanddetl.okpid != null)
                {
                    var Cachegen_okp = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                    if (input.hr_newdemanddetl.okpid != null)
                    {
                        var objgen_okp = Cachegen_okp.Where(p => p.comId == input.hr_newdemanddetl.okpid).Select(x => new { x.comId, x.comText }).ToList();
                        ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                    }
                }

                //model.hr_newdemanddetl.newdemanddetlid = input.hr_newdemanddetl.newdemanddetlid;
                //model.hr_newdemanddetl.noofvacancies = input.hr_newdemanddetl.noofvacancies;
                //model.hr_newdemanddetl.groupid = input.hr_newdemanddetl.groupid;

                return PartialView("_SingleRowNewDemand", input);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        public async Task<ActionResult> GetAllDataHrNewDemandDetails(hr_newdemandEntity input)
        {
            JsonResult result = new JsonResult();
            try
            {
                List<hr_newdemanddetlEntity> listobjhr_newdemandEntity = new List<hr_newdemanddetlEntity>();
                try
                {

                    listobjhr_newdemandEntity = KAF.FacadeCreatorObjects.hr_newdemanddetlFCC.GetFacadeCreate().GetAll_Ext(new hr_newdemanddetlEntity { newdemandid  = input.newdemandid}).ToList();

                    if (listobjhr_newdemandEntity != null && listobjhr_newdemandEntity.Count > 0)
                    {
                        long totalRecords = listobjhr_newdemandEntity.FirstOrDefault().RETURN_KEY;

                        var tut = (from t in listobjhr_newdemandEntity
                                   select new
                                   {
                                       t.newdemandid,
                                       t.newdemanddetlid,
                                       t.rankid,
                                       t.tradeid,
                                       t.groupid,
                                       t.okpid,
                                       t.hrbasicid,
                                       t.noofvacancies,
                                       t.totalperson,
                                       t.ex_nvarchar2,
                                   }).ToList();

                        result = this.Json(new { recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
                    }
                    else
                        result = this.Json(new {recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }
    }
}



