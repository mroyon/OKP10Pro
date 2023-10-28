
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
    public class GenAuthorizeStrengthController : BaseController
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
        public async Task<ActionResult> GenAuthorizeStrength()
        {
            return View("GenAuthorizeStrengthLanding");
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
        public async Task<ActionResult> GenAuthorizeStrengthTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, gen_authorizestrengthEntity input)
        {
            gen_authorizestrengthEntity objowin_gen_authorizestrength = new gen_authorizestrengthEntity();
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
           
                List<gen_authorizestrengthEntity> data = this.GetAllGenAuthorizeStrengthData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var okpCache = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());

                    var tut = (from t in data
                               select new
                               {
									 //t.authstrengthid,
									 t.okpid,
                                     okpName = t.okpid != null && okpCache != null ? okpCache.Where(x => x.comId == t.okpid).FirstOrDefault().comText : "",


          //                         t.rankid,
									 //t.groupid,
									 //t.authstrength,
									 //t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.okpid.GetValueOrDefault(-99), "okpid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "GenAuthorizeStrength/GenAuthorizeStrengthEdit", "GenAuthorizeStrengthEdit", 
                                   "", "",
                                   "GenAuthorizeStrength/GenAuthorizeStrengthDetail", "GenAuthorizeStrengthDetail")
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
        
        
        List<gen_authorizestrengthEntity> GetAllGenAuthorizeStrengthData(gen_authorizestrengthEntity objgen_authorizestrengthEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<gen_authorizestrengthEntity> listobjgen_authorizestrengthEntity = new List<gen_authorizestrengthEntity>();
            try
            {
                listobjgen_authorizestrengthEntity = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().GAPgListView((objgen_authorizestrengthEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjgen_authorizestrengthEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "authstrengthid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "okpid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "rankid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "groupid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "authstrength" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "authstrengthid" + " " + orderDir;
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
        
        
        
         #region Create GenAuthorizeStrength

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
        public async Task<ActionResult> GenAuthorizeStrengthNew(gen_authorizestrengthEntity input)
        {
            try
            {
                ModelState.Clear();
                gen_authorizestrengthEntity model = new gen_authorizestrengthEntity();
                return PartialView("_GenAuthorizeStrengthNew", model);
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
        public async Task<ActionResult> GenAuthorizeStrengthInsert(gen_authorizestrengthEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("authstrengthid");
                ModelState.Remove("okpid");
                ModelState.Remove("rankid");
                ModelState.Remove("groupid");
                ModelState.Remove("authstrength");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update GenAuthorizeStrength

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
        public async Task<ActionResult> GenAuthorizeStrengthEdit(gen_authorizestrengthEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.okpid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("okpid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().GetAll(new gen_authorizestrengthEntity { okpid = input.okpid }).FirstOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                var okpCache = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                if (model.okpid != null)
                {
                    var objgen_okp = okpCache.Where(p => p.comId == model.okpid).Select(p => new { p.comId, p.comText }).ToList();
                    ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                }
      
                ModelState.Clear();
                return PartialView("_GenAuthorizeStrengthEdit", model);
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
        public async Task<ActionResult> GenAuthorizeStrengthUpdate(gen_authorizestrengthEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("authstrengthid");
				 ModelState.Remove("okpid");
				 ModelState.Remove("rankid");
				 ModelState.Remove("groupid");
				 ModelState.Remove("authstrength");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete GenAuthorizeStrength

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
        public async Task<ActionResult> GenAuthorizeStrengthDelete(gen_authorizestrengthEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("authstrengthid"); */
				 ModelState.Remove("okpid");
				 ModelState.Remove("rankid");
				 ModelState.Remove("groupid");
				 ModelState.Remove("authstrength");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.authstrengthid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("authstrengthid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail GenAuthorizeStrength

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
        public async Task<ActionResult> GenAuthorizeStrengthDetail(gen_authorizestrengthEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.authstrengthid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("authstrengthid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().GetAll(new gen_authorizestrengthEntity { authstrengthid = input.authstrengthid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 List<gen_okpEntity> listgen_okp = KAF.FacadeCreatorObjects.gen_okpFCC.GetFacadeCreate().GetAll(new gen_okpEntity { okpid = model.okpid }).ToList();
					 var objgen_okp = (from t in listgen_okp
					 select new
					 {
								 Id = t.okpid ,
								 Text = t.okpname 
					  }).ToList();
					 ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);

					 List<gen_rankEntity> listgen_rank = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankid }).ToList();
					 var objgen_rank = (from t in listgen_rank
					 select new
					 {
								 Id = t.rankid ,
								 Text = t.rankname 
					  }).ToList();
					 ViewBag.preloadedGen_Rank = JsonConvert.SerializeObject(objgen_rank);

                
                
                ModelState.Clear();
                return PartialView("_GenAuthorizeStrengthDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        #endregion

        #region Get Single row Information
        public async Task<ActionResult> GenAuthorizeStrengthSignleRow(gen_authorizestrengthEntity input)
        {
            try
            {
                ModelState.Clear();
                gen_authorizestrengthEntity model = new gen_authorizestrengthEntity();
                //model.authstrengthid = input.authstrengthid;

                if (input != null && input.rankid != null)
                {
                    List<gen_rankEntity> listgen_rankKW = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = input.rankid }).ToList();
                    var objgen_rankKW = (from t in listgen_rankKW
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_Rank = JsonConvert.SerializeObject(objgen_rankKW);
                }

                return PartialView("_SingleRowAuthorizeStrength", input);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

        //public async Task<ActionResult> GenAuthorizeStrengthDetailsByOKPID(gen_authorizestrengthEntity input)
        //{
        //    try
        //    {
        //        ModelState.Clear();
        //        gen_authorizestrengthEntity model = new gen_authorizestrengthEntity();
        //       // model.authstrengthid = input.authstrengthid;
        //        model = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().GetAll(new gen_authorizestrengthEntity { authstrengthid = input.authstrengthid }).SingleOrDefault();

        //        return PartialView("_SingleRowAuthorizeStrength", input);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
        //    }
        //}

        public async Task<ActionResult> GenAuthorizeStrengthDetailsByOKPID(gen_authorizestrengthEntity input)
        {
            JsonResult result = new JsonResult();
            try
            {
                if(input.strModelPrimaryKey != null) input.okpid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("okpid", input.strModelPrimaryKey).ToString());
               
                try
                {
                   var _objlist = KAF.FacadeCreatorObjects.gen_authorizestrengthFCC.GetFacadeCreate().GetAll(new gen_authorizestrengthEntity { okpid = input.okpid }).ToList();
                    if (_objlist != null && _objlist.Count > 0)
                    {
                        long totalRecords = _objlist.FirstOrDefault().RETURN_KEY;
                        var tut = (from t in _objlist
                                   select new
                                   {
                                       t.authstrengthid,
                                       t.rankid,
                                       t.groupid,
                                       t.okpid,
                                       t.authstrength,
                                       //t.ex_nvarchar2,
                                   }).ToList();
                        result = this.Json(new { recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
                    }
                    else
                        result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);

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



