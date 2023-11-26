
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
    public class HrFamilyResidentVisaController : BaseController
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
        public async Task<ActionResult> HrFamilyResidentVisa()
        {
            return View("HrFamilyResidentVisaLanding");
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
        public async Task<ActionResult> HrFamilyResidentVisaTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_familyresidentvisaEntity input)
        {
            hr_familyresidentvisaEntity objowin_hr_familyresidentvisa = new hr_familyresidentvisaEntity();
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
           
                List<hr_familyresidentvisaEntity> data = this.GetAllHrFamilyResidentVisaData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.familyresidentid,
									 t.hrfamilyid,
									 t.hrbasicid,
									 t.familypassportid,
									 t.residencynumber,
									 t.issuedate,
									 t.expirydate,
									 t.isfamilyvisa,
									 t.filedescription,
									 t.filepath,
									 t.filename,
									 t.filetype,
									 t.extension,
									 t.fileno,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.familyresidentid.GetValueOrDefault(-99), "familyresidentid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrFamilyResidentVisa/HrFamilyResidentVisaEdit", "HrFamilyResidentVisaEdit", 
                                   "HrFamilyResidentVisa/HrFamilyResidentVisaDelete", "HrFamilyResidentVisaDelete",
                                   "HrFamilyResidentVisa/HrFamilyResidentVisaDetail", "HrFamilyResidentVisaDetail")
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
        
        
        List<hr_familyresidentvisaEntity> GetAllHrFamilyResidentVisaData(hr_familyresidentvisaEntity objhr_familyresidentvisaEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_familyresidentvisaEntity> listobjhr_familyresidentvisaEntity = new List<hr_familyresidentvisaEntity>();
            try
            {
                listobjhr_familyresidentvisaEntity = KAF.FacadeCreatorObjects.hr_familyresidentvisaFCC.GetFacadeCreate().GAPgListView((objhr_familyresidentvisaEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_familyresidentvisaEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "familyresidentid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrfamilyid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "familypassportid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "residencynumber" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "issuedate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "expirydate" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "isfamilyvisa" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "filedescription" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "filepath" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "filename" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "filetype" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "extension" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "fileno" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "familyresidentid" + " " + orderDir;
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
        
        
        
         #region Create HrFamilyResidentVisa

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
        public async Task<ActionResult> HrFamilyResidentVisaNew(hr_familyresidentvisaEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_familyresidentvisaEntity model = new hr_familyresidentvisaEntity();
				model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_HrFamilyResidentVisaNew", model);
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
        public async Task<ActionResult> HrFamilyResidentVisaInsert(hr_familyresidentvisaEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("familyresidentid");
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familypassportid");
				 ModelState.Remove("residencynumber");
				 ModelState.Remove("issuedate");
				 ModelState.Remove("expirydate");
				 ModelState.Remove("isfamilyvisa");
				 ModelState.Remove("filedescription");
				 ModelState.Remove("filepath");
				 ModelState.Remove("filename");
				 ModelState.Remove("filetype");
				 ModelState.Remove("extension");
				 ModelState.Remove("fileno");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					//START OF NO CHANGE REGION
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 input.strValue6 = userid;
					 input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //Int64 ret = 0;
					 List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
					 objFileList = input.cor_foldercontentsList;
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_familyresidentvisaFCC.GetFacadeCreate().Add_WithFiles(input).ToList();
					 
					 //START OF NO CHANGE REGION
					  if (retArray != null && retArray.Count > 0)
					 {
						 ret = 0;
						 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						 if (objFileList != null && objFileList.Count > 0)
						 {
							 foreach (cor_foldercontentsEntity file in objFileList)
							 {
								 byte[] imageBytes = Convert.FromBase64String(file.comment);
								 objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
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
        
        
        #region update HrFamilyResidentVisa

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
        public async Task<ActionResult> HrFamilyResidentVisaEdit(hr_familyresidentvisaEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.familyresidentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familyresidentid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_familyresidentvisaFCC.GetFacadeCreate().GetAll(new hr_familyresidentvisaEntity { familyresidentid = input.familyresidentid }).SingleOrDefault();
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

					 List<hr_familypassportinfoEntity> listhr_familypassportinfo = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().GetAll(new hr_familypassportinfoEntity { familypassportid = model.familypassportid }).ToList();
					 var objhr_familypassportinfo = (from t in listhr_familypassportinfo
					 select new
					 {
								 Id = t.familypassportid ,
								 Text = t.familypassportno 
					  }).ToList();
					 ViewBag.preloadedHr_FamilyPassportInfo = JsonConvert.SerializeObject(objhr_familypassportinfo);

                
                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_FamilyResidentVisa",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.familyresidentid
					 //}).ToList();
					 //END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrFamilyResidentVisaEdit", model);
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
        public async Task<ActionResult> HrFamilyResidentVisaUpdate(hr_familyresidentvisaEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("familyresidentid");
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familypassportid");
				 ModelState.Remove("residencynumber");
				 ModelState.Remove("issuedate");
				 ModelState.Remove("expirydate");
				 ModelState.Remove("isfamilyvisa");
				 ModelState.Remove("filedescription");
				 ModelState.Remove("filepath");
				 ModelState.Remove("filename");
				 ModelState.Remove("filetype");
				 ModelState.Remove("extension");
				 ModelState.Remove("fileno");
				 ModelState.Remove("remarks");
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
					 //retArray = KAF.FacadeCreatorObjects.hr_familyresidentvisaFCC.GetFacadeCreate().Update_WithFiles(input).ToList();
					 
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

        #region delete HrFamilyResidentVisa

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
        public async Task<ActionResult> HrFamilyResidentVisaDelete(hr_familyresidentvisaEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("familyresidentid"); */
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("familypassportid");
				 ModelState.Remove("residencynumber");
				 ModelState.Remove("issuedate");
				 ModelState.Remove("expirydate");
				 ModelState.Remove("isfamilyvisa");
				 ModelState.Remove("filedescription");
				 ModelState.Remove("filepath");
				 ModelState.Remove("filename");
				 ModelState.Remove("filetype");
				 ModelState.Remove("extension");
				 ModelState.Remove("fileno");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.familyresidentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familyresidentid", input.strModelPrimaryKey).ToString());
               
               
					//START OF NO CHANGE REGION
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //input.strValue6 = userid;
					 //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 // tablename = "Hr_FamilyResidentVisa",
					 // folderid = long.Parse(input.strValue5),
					 // columnpkid = input.qualificationid
					 //}).ToList();
					 
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_familyresidentvisaFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
					 
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

        #region detail HrFamilyResidentVisa

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
        public async Task<ActionResult> HrFamilyResidentVisaDetail(hr_familyresidentvisaEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.familyresidentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("familyresidentid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_familyresidentvisaFCC.GetFacadeCreate().GetAll(new hr_familyresidentvisaEntity { familyresidentid = input.familyresidentid }).SingleOrDefault();
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

					 List<hr_familypassportinfoEntity> listhr_familypassportinfo = KAF.FacadeCreatorObjects.hr_familypassportinfoFCC.GetFacadeCreate().GetAll(new hr_familypassportinfoEntity { familypassportid = model.familypassportid }).ToList();
					 var objhr_familypassportinfo = (from t in listhr_familypassportinfo
					 select new
					 {
								 Id = t.familypassportid ,
								 Text = t.familypassportno 
					  }).ToList();
					 ViewBag.preloadedHr_FamilyPassportInfo = JsonConvert.SerializeObject(objhr_familypassportinfo);

                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_FamilyResidentVisa",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.familyresidentid
					 //}).ToList();
					 //END OF NO CHANGE REGION
                
                ModelState.Clear();
                return PartialView("_HrFamilyResidentVisaDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



