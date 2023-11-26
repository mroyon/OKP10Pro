
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
    public class HrFamilyCivilIDInfoController : BaseController
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
        public async Task<ActionResult> HrFamilyCivilIDInfo()
        {
            return View("HrFamilyCivilIDInfoLanding");
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
        public async Task<ActionResult> HrFamilyCivilIDInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_familycivilidinfoEntity input)
        {
            hr_familycivilidinfoEntity objowin_hr_familycivilidinfo = new hr_familycivilidinfoEntity();
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
           
                List<hr_familycivilidinfoEntity> data = this.GetAllHrFamilyCivilIDInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.familycivilid,
									 t.hrfamilyid,
									 t.hrbasicid,
									 t.familycivilidno,
									 t.serialno,
									 t.familycivilidissuedate,
									 t.familycivilidexpirydate,
									 t.familycivilidfiledescription,
									 t.familycivilidfilepath,
									 t.familycivilidfilename,
									 t.familycivilidfiletype,
									 t.familycivilidextension,
									 t.familycivilidfileid,
									 t.familycivilidfiledescription_2,
									 t.familycivilidfilepath_2,
									 t.familycivilidfilename_2,
									 t.familycivilidfiletype_2,
									 t.familycivilidextension_2,
									 t.familycivilidfileid_2,
									 t.remarks,
									 t.forreview,
									 t.iscurrent,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.familycivilid.GetValueOrDefault(-99), "familycivilid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrFamilyCivilIDInfo/HrFamilyCivilIDInfoEdit", "HrFamilyCivilIDInfoEdit", 
                                   "HrFamilyCivilIDInfo/HrFamilyCivilIDInfoDelete", "HrFamilyCivilIDInfoDelete",
                                   "HrFamilyCivilIDInfo/HrFamilyCivilIDInfoDetail", "HrFamilyCivilIDInfoDetail")
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
        
        
        List<hr_familycivilidinfoEntity> GetAllHrFamilyCivilIDInfoData(hr_familycivilidinfoEntity objhr_familycivilidinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_familycivilidinfoEntity> listobjhr_familycivilidinfoEntity = new List<hr_familycivilidinfoEntity>();
            try
            {
                listobjhr_familycivilidinfoEntity = KAF.FacadeCreatorObjects.hr_familycivilidinfoFCC.GetFacadeCreate().GAPgListView((objhr_familycivilidinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_familycivilidinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "familycivilid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrfamilyid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "familycivilidno" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "serialno" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "familycivilidissuedate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "familycivilidexpirydate" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "familycivilidfiledescription" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "familycivilidfilepath" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "familycivilidfilename" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "familycivilidfiletype" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "familycivilidextension" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "familycivilidfileid" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "familycivilidfiledescription_2" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "familycivilidfilepath_2" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "familycivilidfilename_2" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "familycivilidfiletype_2" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "familycivilidextension_2" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "familycivilidfileid_2" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "iscurrent" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "familycivilid" + " " + orderDir;
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
        
        
        
         #region Create HrFamilyCivilIDInfo

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
        public async Task<ActionResult> HrFamilyCivilIDInfoNew(hr_familycivilidinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_familycivilidinfoEntity model = new hr_familycivilidinfoEntity();
                return PartialView("_HrFamilyCivilIDInfoNew", model);
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
        public async Task<ActionResult> HrFamilyCivilIDInfoInsert(hr_familycivilidinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("familycivilid");
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familycivilidno");
				 ModelState.Remove("serialno");
				 ModelState.Remove("familycivilidissuedate");
				 ModelState.Remove("familycivilidexpirydate");
				 ModelState.Remove("familycivilidfiledescription");
				 ModelState.Remove("familycivilidfilepath");
				 ModelState.Remove("familycivilidfilename");
				 ModelState.Remove("familycivilidfiletype");
				 ModelState.Remove("familycivilidextension");
				 ModelState.Remove("familycivilidfileid");
				 ModelState.Remove("familycivilidfiledescription_2");
				 ModelState.Remove("familycivilidfilepath_2");
				 ModelState.Remove("familycivilidfilename_2");
				 ModelState.Remove("familycivilidfiletype_2");
				 ModelState.Remove("familycivilidextension_2");
				 ModelState.Remove("familycivilidfileid_2");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
				 ModelState.Remove("iscurrent");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_familycivilidinfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrFamilyCivilIDInfo

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
        public async Task<ActionResult> HrFamilyCivilIDInfoEdit(hr_familycivilidinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.familycivilid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familycivilid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_familycivilidinfoFCC.GetFacadeCreate().GetAll(new hr_familycivilidinfoEntity { familycivilid = input.familycivilid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 List<hr_familyinfoEntity> listhr_familyinfo = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GetAll(new hr_familyinfoEntity { hrfamilyid = model.hrfamilyid }).ToList();
					 var objhr_familyinfo = (from t in listhr_familyinfo
					 select new
					 {
								 Id = t.hrfamilyid ,
								 Text = t.familynationalid 
					  }).ToList();
					 ViewBag.preloadedHr_FamilyInfo = JsonConvert.SerializeObject(objhr_familyinfo);

					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t.milnobd 
					 // }).ToList();
					 //ViewBag.preloadedHr_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

                
                

                ModelState.Clear();
                return PartialView("_HrFamilyCivilIDInfoEdit", model);
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
        public async Task<ActionResult> HrFamilyCivilIDInfoUpdate(hr_familycivilidinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("familycivilid");
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familycivilidno");
				 ModelState.Remove("serialno");
				 ModelState.Remove("familycivilidissuedate");
				 ModelState.Remove("familycivilidexpirydate");
				 ModelState.Remove("familycivilidfiledescription");
				 ModelState.Remove("familycivilidfilepath");
				 ModelState.Remove("familycivilidfilename");
				 ModelState.Remove("familycivilidfiletype");
				 ModelState.Remove("familycivilidextension");
				 ModelState.Remove("familycivilidfileid");
				 ModelState.Remove("familycivilidfiledescription_2");
				 ModelState.Remove("familycivilidfilepath_2");
				 ModelState.Remove("familycivilidfilename_2");
				 ModelState.Remove("familycivilidfiletype_2");
				 ModelState.Remove("familycivilidextension_2");
				 ModelState.Remove("familycivilidfileid_2");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
				 ModelState.Remove("iscurrent");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_familycivilidinfoFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrFamilyCivilIDInfo

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
        public async Task<ActionResult> HrFamilyCivilIDInfoDelete(hr_familycivilidinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("familycivilid"); */
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familycivilidno");
				 ModelState.Remove("serialno");
				 ModelState.Remove("familycivilidissuedate");
				 ModelState.Remove("familycivilidexpirydate");
				 ModelState.Remove("familycivilidfiledescription");
				 ModelState.Remove("familycivilidfilepath");
				 ModelState.Remove("familycivilidfilename");
				 ModelState.Remove("familycivilidfiletype");
				 ModelState.Remove("familycivilidextension");
				 ModelState.Remove("familycivilidfileid");
				 ModelState.Remove("familycivilidfiledescription_2");
				 ModelState.Remove("familycivilidfilepath_2");
				 ModelState.Remove("familycivilidfilename_2");
				 ModelState.Remove("familycivilidfiletype_2");
				 ModelState.Remove("familycivilidextension_2");
				 ModelState.Remove("familycivilidfileid_2");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
				 ModelState.Remove("iscurrent");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.familycivilid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familycivilid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_familycivilidinfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrFamilyCivilIDInfo

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
        public async Task<ActionResult> HrFamilyCivilIDInfoDetail(hr_familycivilidinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.familycivilid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familycivilid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_familycivilidinfoFCC.GetFacadeCreate().GetAll(new hr_familycivilidinfoEntity { familycivilid = input.familycivilid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 List<hr_familyinfoEntity> listhr_familyinfo = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GetAll(new hr_familyinfoEntity { hrfamilyid = model.hrfamilyid }).ToList();
					 var objhr_familyinfo = (from t in listhr_familyinfo
					 select new
					 {
								 Id = t.hrfamilyid ,
								 Text = t.familynationalid 
					  }).ToList();
					 ViewBag.preloadedHr_FamilyInfo = JsonConvert.SerializeObject(objhr_familyinfo);

					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t.milnobd 
					 // }).ToList();
					 //ViewBag.preloadedHr_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

                
                
                ModelState.Clear();
                return PartialView("_HrFamilyCivilIDInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



