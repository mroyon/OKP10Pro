
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
    public class GenBuildingController : BaseController
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
        public async Task<ActionResult> GenBuilding()
        {
            return View("GenBuildingLanding");
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
        public async Task<ActionResult> GenBuildingTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, gen_buildingEntity input)
        {
            gen_buildingEntity objowin_gen_building = new gen_buildingEntity();
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
           
                List<gen_buildingEntity> data = this.GetAllGenBuildingData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.buildingid,
									 t.buildingname,
									 t.kwgovid,
									 t.kwareaid,
									 t.kwblockno,
									 t.kwstreet,
									 t.kwhouseno,
									 t.isactive,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.buildingid.GetValueOrDefault(-99), "buildingid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "GenBuilding/GenBuildingEdit", "GenBuildingEdit", 
                                   "GenBuilding/GenBuildingDelete", "GenBuildingDelete",
                                   "GenBuilding/GenBuildingDetail", "GenBuildingDetail")
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
        
        
        List<gen_buildingEntity> GetAllGenBuildingData(gen_buildingEntity objgen_buildingEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<gen_buildingEntity> listobjgen_buildingEntity = new List<gen_buildingEntity>();
            try
            {
                listobjgen_buildingEntity = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().GAPgListView((objgen_buildingEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjgen_buildingEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "buildingid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "buildingname" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "kwgovid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "kwareaid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "kwblockno" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "kwstreet" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "kwhouseno" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "isactive" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "buildingid" + " " + orderDir;
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
        
        
        
         #region Create GenBuilding

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
        public async Task<ActionResult> GenBuildingNew(gen_buildingEntity input)
        {
            try
            {
                ModelState.Clear();
                gen_buildingEntity model = new gen_buildingEntity();
                return PartialView("_GenBuildingNew", model);
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
        public async Task<ActionResult> GenBuildingInsert(gen_buildingEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("buildingid");
				 ModelState.Remove("buildingname");
				 ModelState.Remove("kwgovid");
				 ModelState.Remove("kwareaid");
				 ModelState.Remove("kwblockno");
				 ModelState.Remove("kwstreet");
				 ModelState.Remove("kwhouseno");
				 ModelState.Remove("isactive");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update GenBuilding

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
        public async Task<ActionResult> GenBuildingEdit(gen_buildingEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.buildingid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("buildingid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().GetAll(new gen_buildingEntity { buildingid = input.buildingid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
				List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwgovid }).ToList();
				var objgen_govcity = (from t in listgen_govcity
                                      select new
				{
							Id = t.cityid ,
							Text = t.cityname 
				}).ToList();
				ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                List<gen_govcityEntity> listgen_govarea = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwareaid }).ToList();
                var objgen_govarea = (from t in listgen_govarea
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovArea = JsonConvert.SerializeObject(objgen_govarea);
                
                ModelState.Clear();
                return PartialView("_GenBuildingEdit", model);
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
        public async Task<ActionResult> GenBuildingUpdate(gen_buildingEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("buildingid");
				 ModelState.Remove("buildingname");
				 ModelState.Remove("kwgovid");
				 ModelState.Remove("kwareaid");
				 ModelState.Remove("kwblockno");
				 ModelState.Remove("kwstreet");
				 ModelState.Remove("kwhouseno");
				 ModelState.Remove("isactive");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete GenBuilding

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
        public async Task<ActionResult> GenBuildingDelete(gen_buildingEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("buildingid"); */
				 ModelState.Remove("buildingname");
				 ModelState.Remove("kwgovid");
				 ModelState.Remove("kwareaid");
				 ModelState.Remove("kwblockno");
				 ModelState.Remove("kwstreet");
				 ModelState.Remove("kwhouseno");
				 ModelState.Remove("isactive");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.buildingid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("buildingid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail GenBuilding

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
        public async Task<ActionResult> GenBuildingDetail(gen_buildingEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.buildingid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("buildingid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().GetAll(new gen_buildingEntity { buildingid = input.buildingid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;

                List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwgovid }).ToList();
                var objgen_govcity = (from t in listgen_govcity
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                List<gen_govcityEntity> listgen_govarea = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwareaid }).ToList();
                var objgen_govarea = (from t in listgen_govarea
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovArea = JsonConvert.SerializeObject(objgen_govarea);


                ModelState.Clear();
                return PartialView("_GenBuildingDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



