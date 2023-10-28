
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
    public class HrLanguageProficiencyController : BaseController
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
        public async Task<ActionResult> HrLanguageProficiency()
        {
            return View("HrLanguageProficiencyLanding");
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
        public async Task<ActionResult> HrLanguageProficiencyTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_languageproficiencyEntity input)
        {
            hr_languageproficiencyEntity objowin_hr_languageproficiency = new hr_languageproficiencyEntity();
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
           
                List<hr_languageproficiencyEntity> data = this.GetAllHrLanguageProficiencyData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.languageproficiencyid,
									 t.hrbasicid,
									 t.languageid,
									 t.readingproficiencyid,
									 t.writingproficiencyid,
									 t.speakingproficiencyid,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.languageproficiencyid.GetValueOrDefault(-99), "languageproficiencyid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrLanguageProficiency/HrLanguageProficiencyEdit", "HrLanguageProficiencyEdit", 
                                   "HrLanguageProficiency/HrLanguageProficiencyDelete", "HrLanguageProficiencyDelete",
                                   "HrLanguageProficiency/HrLanguageProficiencyDetail", "HrLanguageProficiencyDetail")
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
        
        
        List<hr_languageproficiencyEntity> GetAllHrLanguageProficiencyData(hr_languageproficiencyEntity objhr_languageproficiencyEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_languageproficiencyEntity> listobjhr_languageproficiencyEntity = new List<hr_languageproficiencyEntity>();
            try
            {
                listobjhr_languageproficiencyEntity = KAF.FacadeCreatorObjects.hr_languageproficiencyFCC.GetFacadeCreate().GAPgListView((objhr_languageproficiencyEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_languageproficiencyEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "languageproficiencyid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "languageid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "readingproficiencyid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "writingproficiencyid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "speakingproficiencyid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "languageproficiencyid" + " " + orderDir;
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
        
        
        
         #region Create HrLanguageProficiency

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
        public async Task<ActionResult> HrLanguageProficiencyNew(hr_languageproficiencyEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_languageproficiencyEntity model = new hr_languageproficiencyEntity();
                return PartialView("_HrLanguageProficiencyNew", model);
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
        public async Task<ActionResult> HrLanguageProficiencyInsert(hr_languageproficiencyEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("languageproficiencyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("languageid");
				 ModelState.Remove("readingproficiencyid");
				 ModelState.Remove("writingproficiencyid");
				 ModelState.Remove("speakingproficiencyid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_languageproficiencyFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrLanguageProficiency

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
        public async Task<ActionResult> HrLanguageProficiencyEdit(hr_languageproficiencyEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.languageproficiencyid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("languageproficiencyid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_languageproficiencyFCC.GetFacadeCreate().GetAll(new hr_languageproficiencyEntity { languageproficiencyid = input.languageproficiencyid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 List<gen_languageEntity> listgen_language = KAF.FacadeCreatorObjects.gen_languageFCC.GetFacadeCreate().GetAll(new gen_languageEntity { languageid = model.languageid }).ToList();
					 var objgen_language = (from t in listgen_language
					 select new
					 {
								 Id = t.languageid ,
								 Text = t.languagename 
					  }).ToList();
					 ViewBag.preloadedGen_Language = JsonConvert.SerializeObject(objgen_language);

					 List<gen_languageproficiencyEntity> listgen_languageproficiency = KAF.FacadeCreatorObjects.gen_languageproficiencyFCC.GetFacadeCreate().GetAll(new gen_languageproficiencyEntity { proficiencyid = model.readingproficiencyid }).ToList();
					 var objgen_languageproficiency = (from t in listgen_languageproficiency
					 select new
					 {
								 Id = t.proficiencyid ,
								 Text = t.proficiencyname 
					  }).ToList();
					 ViewBag.preloadedGen_LanguageProficiency = JsonConvert.SerializeObject(objgen_languageproficiency);

					 //List<gen_languageproficiencyEntity> listgen_languageproficiency = KAF.FacadeCreatorObjects.gen_languageproficiencyFCC.GetFacadeCreate().GetAll(new gen_languageproficiencyEntity { proficiencyid = model.writingproficiencyid }).ToList();
					 //var objgen_languageproficiency = (from t in listgen_languageproficiency
					 //select new
					 //{
						//		 Id = t.proficiencyid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_LanguageProficiency = JsonConvert.SerializeObject(objgen_languageproficiency);

					 //List<gen_languageproficiencyEntity> listgen_languageproficiency = KAF.FacadeCreatorObjects.gen_languageproficiencyFCC.GetFacadeCreate().GetAll(new gen_languageproficiencyEntity { proficiencyid = model.speakingproficiencyid }).ToList();
					 //var objgen_languageproficiency = (from t in listgen_languageproficiency
					 //select new
					 //{
						//		 Id = t.proficiencyid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_LanguageProficiency = JsonConvert.SerializeObject(objgen_languageproficiency);

                
                

                ModelState.Clear();
                return PartialView("_HrLanguageProficiencyEdit", model);
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
        public async Task<ActionResult> HrLanguageProficiencyUpdate(hr_languageproficiencyEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("languageproficiencyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("languageid");
				 ModelState.Remove("readingproficiencyid");
				 ModelState.Remove("writingproficiencyid");
				 ModelState.Remove("speakingproficiencyid");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_languageproficiencyFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrLanguageProficiency

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
        public async Task<ActionResult> HrLanguageProficiencyDelete(hr_languageproficiencyEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("languageproficiencyid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("languageid");
				 ModelState.Remove("readingproficiencyid");
				 ModelState.Remove("writingproficiencyid");
				 ModelState.Remove("speakingproficiencyid");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.languageproficiencyid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("languageproficiencyid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_languageproficiencyFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrLanguageProficiency

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
        public async Task<ActionResult> HrLanguageProficiencyDetail(hr_languageproficiencyEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.languageproficiencyid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("languageproficiencyid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_languageproficiencyFCC.GetFacadeCreate().GetAll(new hr_languageproficiencyEntity { languageproficiencyid = input.languageproficiencyid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 List<gen_languageEntity> listgen_language = KAF.FacadeCreatorObjects.gen_languageFCC.GetFacadeCreate().GetAll(new gen_languageEntity { languageid = model.languageid }).ToList();
					 var objgen_language = (from t in listgen_language
					 select new
					 {
								 Id = t.languageid ,
								 Text = t.languagename 
					  }).ToList();
					 ViewBag.preloadedGen_Language = JsonConvert.SerializeObject(objgen_language);

					 List<gen_languageproficiencyEntity> listgen_languageproficiency = KAF.FacadeCreatorObjects.gen_languageproficiencyFCC.GetFacadeCreate().GetAll(new gen_languageproficiencyEntity { proficiencyid = model.readingproficiencyid }).ToList();
					 var objgen_languageproficiency = (from t in listgen_languageproficiency
					 select new
					 {
								 Id = t.proficiencyid ,
								 Text = t.proficiencyname
                     }).ToList();
					 ViewBag.preloadedGen_LanguageProficiency = JsonConvert.SerializeObject(objgen_languageproficiency);

					 //List<gen_languageproficiencyEntity> listgen_languageproficiency = KAF.FacadeCreatorObjects.gen_languageproficiencyFCC.GetFacadeCreate().GetAll(new gen_languageproficiencyEntity { proficiencyid = model.writingproficiencyid }).ToList();
					 //var objgen_languageproficiency = (from t in listgen_languageproficiency
					 //select new
					 //{
						//		 Id = t.proficiencyid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_LanguageProficiency = JsonConvert.SerializeObject(objgen_languageproficiency);

					 //List<gen_languageproficiencyEntity> listgen_languageproficiency = KAF.FacadeCreatorObjects.gen_languageproficiencyFCC.GetFacadeCreate().GetAll(new gen_languageproficiencyEntity { proficiencyid = model.speakingproficiencyid }).ToList();
					 //var objgen_languageproficiency = (from t in listgen_languageproficiency
					 //select new
					 //{
						//		 Id = t.proficiencyid ,
						//		 Text = t.proficiencyname 
					 // }).ToList();
					 //ViewBag.preloadedGen_LanguageProficiency = JsonConvert.SerializeObject(objgen_languageproficiency);

                
                
                ModelState.Clear();
                return PartialView("_HrLanguageProficiencyDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



