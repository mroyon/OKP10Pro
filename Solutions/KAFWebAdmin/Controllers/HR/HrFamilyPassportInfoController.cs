
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
    public class HrFamilyPassportInfoController : BaseController
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
        public async Task<ActionResult> HrFamilyPassportInfo()
        {
            return View("HrFamilyPassportInfoLanding");
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
        public async Task<ActionResult> HrFamilyPassportInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_familypassportinfoEntity input)
        {
            hr_familypassportinfoEntity objowin_hr_familypassportinfo = new hr_familypassportinfoEntity();
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
           
                List<hr_familypassportinfoEntity> data = this.GetAllHrFamilyPassportInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.familypassportid,
									 t.hrfamilyid,
									 t.hrbasicid,
									 t.familypassportno,
									 t.familypassportissuedate,
									 t.familypassportexpirydate,
									 t.familypassportissuecountryid,
									 t.isfamilyfamilypassport,
									 t.familypassportfiledescription,
									 t.familypassportfilepath,
									 t.familypassportfilename,
									 t.familypassportfiletype,
									 t.familypassportextension,
									 t.familypassportfileid,
									 t.remarks,
									 t.forreview,
									 t.iscurrent,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.familypassportid.GetValueOrDefault(-99), "familypassportid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrFamilyPassportInfo/HrFamilyPassportInfoEdit", "HrFamilyPassportInfoEdit", 
                                   "HrFamilyPassportInfo/HrFamilyPassportInfoDelete", "HrFamilyPassportInfoDelete",
                                   "HrFamilyPassportInfo/HrFamilyPassportInfoDetail", "HrFamilyPassportInfoDetail")
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
        
        
        List<hr_familypassportinfoEntity> GetAllHrFamilyPassportInfoData(hr_familypassportinfoEntity objhr_familypassportinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_familypassportinfoEntity> listobjhr_familypassportinfoEntity = new List<hr_familypassportinfoEntity>();
            try
            {
                listobjhr_familypassportinfoEntity = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().GAPgListView((objhr_familypassportinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_familypassportinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "familypassportid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrfamilyid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "familypassportno" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "familypassportissuedate" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "familypassportexpirydate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "familypassportissuecountryid" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "isfamilyfamilypassport" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "familypassportfiledescription" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "familypassportfilepath" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "familypassportfilename" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "familypassportfiletype" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "familypassportextension" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "familypassportfileid" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "iscurrent" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "familypassportid" + " " + orderDir;
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
        
        
        
         #region Create HrFamilyPassportInfo

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
        public async Task<ActionResult> HrFamilyPassportInfoNew(hr_familypassportinfoEntity input)
        {
            try
            {
                ModelState.Clear();
    //            hr_familypassportinfoEntity model = new hr_familypassportinfoEntity();
				//model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_HrFamilyPassportInfoNew", input);
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
        public async Task<ActionResult> HrFamilyPassportInfoInsert(hr_familypassportinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("familypassportid");
                ModelState.Remove("hrfamilyid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("familypassportno");
                ModelState.Remove("familypassportissuedate");
                ModelState.Remove("familypassportexpirydate");
                ModelState.Remove("familypassportissuecountryid");
                ModelState.Remove("isfamilyfamilypassport");
                ModelState.Remove("familypassportfiledescription");
                ModelState.Remove("familypassportfilepath");
                ModelState.Remove("familypassportfilename");
                ModelState.Remove("familypassportfiletype");
                ModelState.Remove("familypassportextension");
                ModelState.Remove("familypassportfileid");
                ModelState.Remove("remarks");
                ModelState.Remove("forreview");
                ModelState.Remove("iscurrent");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    //START OF NO CHANGE REGION
                    //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    //input.strValue6 = userid;
                    //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    ////Int64 ret = 0;
                    //List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
                    //objFileList = input.cor_foldercontentsList;
                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    //END OF NO CHANGE REGION
                    // CHANGE ThiS LINE TO MAKE A SAVE
                    ret = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().Add(input);

                    //START OF NO CHANGE REGION
      //              if (retArray != null && retArray.Count > 0)
					 //{
						// ret = 0;
						// KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						// if (objFileList != null && objFileList.Count > 0)
						// {
						//	 foreach (cor_foldercontentsEntity file in objFileList)
						//	 {
						//		 byte[] imageBytes = Convert.FromBase64String(file.comment);
						//		 objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
						//	 }
						// }
					 //ret = 1;
					 //}
					 //END OF NO CHANGE REGION
					 
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
        
        
        #region update HrFamilyPassportInfo

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
        public async Task<ActionResult> HrFamilyPassportInfoEdit(hr_familypassportinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.familypassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familypassportid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().GetAll(new hr_familypassportinfoEntity { familypassportid = input.familypassportid }).SingleOrDefault();
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

					 List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.familypassportissuecountryid }).ToList();
					 var objgen_country = (from t in listgen_country
					 select new
					 {
								 Id = t.countryid ,
								 Text = t.countryname 
					  }).ToList();
					 ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

                
                
					 //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_FamilyPassportInfo",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.familypassportid
					 //}).ToList();
					 //END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrFamilyPassportInfoEdit", model);
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
        public async Task<ActionResult> HrFamilyPassportInfoUpdate(hr_familypassportinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("familypassportid");
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familypassportno");
				 ModelState.Remove("familypassportissuedate");
				 ModelState.Remove("familypassportexpirydate");
				 ModelState.Remove("familypassportissuecountryid");
				 ModelState.Remove("isfamilyfamilypassport");
				 ModelState.Remove("familypassportfiledescription");
				 ModelState.Remove("familypassportfilepath");
				 ModelState.Remove("familypassportfilename");
				 ModelState.Remove("familypassportfiletype");
				 ModelState.Remove("familypassportextension");
				 ModelState.Remove("familypassportfileid");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
				 ModelState.Remove("iscurrent");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					//START OF NO CHANGE REGION
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 input.strValue6 = userid;
					 input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //Int64 ret = 0;
					 List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
					 objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == "deleted" || p.strValue1 == "added").ToList();
					 input.cor_foldercontentsList = objFileList;
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().Update_WithFiles(input).ToList();
					 
					 //START OF NO CHANGE REGION
					  if (retArray != null && retArray.Count > 0)
					 {
						 ret = 0;
						 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						 if (objFileList != null && objFileList.Count > 0)
						 {
						 List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						 List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();
						 objFileDeleteList = objFileList.Where(p => p.strValue1 == "deleted").ToList();
						 objFileAddList = objFileList.Where(p => p.strValue1 == "added").ToList();
						 foreach (cor_foldercontentsEntity file in objFileAddList)
						 {
						    byte[] imageBytes = Convert.FromBase64String(file.comment);
						    objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
						 }
						 
						 
						 foreach (cor_foldercontentsEntity file in objFileDeleteList)
						 {
						 objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						 }
						 }
					 ret = 1;
					 }
					 //END OF NO CHANGE REGION
					 
                 
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

        #region delete HrFamilyPassportInfo

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
        public async Task<ActionResult> HrFamilyPassportInfoDelete(hr_familypassportinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("familypassportid"); */
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familypassportno");
				 ModelState.Remove("familypassportissuedate");
				 ModelState.Remove("familypassportexpirydate");
				 ModelState.Remove("familypassportissuecountryid");
				 ModelState.Remove("isfamilyfamilypassport");
				 ModelState.Remove("familypassportfiledescription");
				 ModelState.Remove("familypassportfilepath");
				 ModelState.Remove("familypassportfilename");
				 ModelState.Remove("familypassportfiletype");
				 ModelState.Remove("familypassportextension");
				 ModelState.Remove("familypassportfileid");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
				 ModelState.Remove("iscurrent");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.familypassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familypassportid", input.strModelPrimaryKey).ToString());


                    ////START OF NO CHANGE REGION
                    string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    // input.strValue6 = userid;
                    // input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    // input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                    // input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
                    // {
                    //  tablename = "Hr_FamilyPassportInfo",
                    //  folderid = long.Parse(input.strValue5),
                    //  columnpkid = input.qualificationid
                    // }).ToList();

                    List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
					 
					 //START OF NO CHANGE REGION
					  if (retArray != null && retArray.Count > 0)
					 {
						 ret = 0;
						 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						 if (input.cor_foldercontentsList != null && input.cor_foldercontentsList.Count > 0)
						 {
						  List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						 objFileDeleteList = input.cor_foldercontentsList;
						 
						 foreach (cor_foldercontentsEntity file in objFileDeleteList)
						 {
						 objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						 }
						 }
					 ret = 1;
					 }
					 //END OF NO CHANGE REGION
					 
                 
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

        #region detail HrFamilyPassportInfo

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
        public async Task<ActionResult> HrFamilyPassportInfoDetail(hr_familypassportinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.familypassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familypassportid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().GetAll(new hr_familypassportinfoEntity { familypassportid = input.familypassportid }).SingleOrDefault();
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

					 List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.familypassportissuecountryid }).ToList();
					 var objgen_country = (from t in listgen_country
					 select new
					 {
								 Id = t.countryid ,
								 Text = t.countryname 
					  }).ToList();
					 ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_FamilyPassportInfo",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.familypassportid
					 //}).ToList();
					 //END OF NO CHANGE REGION
                
                ModelState.Clear();
                return PartialView("_HrFamilyPassportInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

        [SecurityFillerAttribute]
        public async Task<ActionResult> GetAllHrBasicProfileData(long? militaryNo)
        {
            JsonResult result = new JsonResult();
            SecurityCapsule sec = new SecurityCapsule();
            sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
            hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
            objhr_svcinfo.militarynokw = militaryNo;

            try
            {
                var data = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).ToList();
                if (data != null && data.Count > 0)
                {
                    if (sec.okpid != null && sec.okpid != data.FirstOrDefault().okpid)
                    {
                        return Json(new { data = data, status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Warning! Unauthorized search for Military No: " + militaryNo });
                    }
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.hrbasicid,
                                   t.militarynokw,
                                   t.militarynobd,
                                   t.civilid,
                                   t.passportno,
                                   t.fullname
                               }).ToList();

                    result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut, responsetext = "" }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { status = KAF.MsgContainer._Status._statusFailed, recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Data not found" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}



