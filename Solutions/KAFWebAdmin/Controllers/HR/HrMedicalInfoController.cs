
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
    public class HrMedicalInfoController : BaseController
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
        public async Task<ActionResult> HrMedicalInfo()
        {
            return View("HrMedicalInfoLanding");
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
        public async Task<ActionResult> HrMedicalInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_medicalinfoEntity input)
        {
            hr_medicalinfoEntity objowin_hr_medicalinfo = new hr_medicalinfoEntity();
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
           
                List<hr_medicalinfoEntity> data = this.GetAllHrMedicalInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.miltmedicalid,
									 t.hrbasicid,
									 t.medcommissionno,
									 t.medcommsisiondate,
									 t.medcommissionfiledescription,
									 t.medcommissionfilepath,
									 t.medcommissionfilename,
									 t.medcommissionfiletype,
									 t.medcommissionextension,
									 t.medcommissionfileno,
									 t.medcommissiondesc,
									 t.docno,
									 t.docdate,
									 t.docfiledescription,
									 t.docfilepath,
									 t.docfilename,
									 t.docfiletype,
									 t.docextension,
									 t.docfileno,
									 t.medaction,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.miltmedicalid.GetValueOrDefault(-99), "miltmedicalid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrMedicalInfo/HrMedicalInfoEdit", "HrMedicalInfoEdit", 
                                   "HrMedicalInfo/HrMedicalInfoDelete", "HrMedicalInfoDelete",
                                   "HrMedicalInfo/HrMedicalInfoDetail", "HrMedicalInfoDetail")
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
        
        
        List<hr_medicalinfoEntity> GetAllHrMedicalInfoData(hr_medicalinfoEntity objhr_medicalinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_medicalinfoEntity> listobjhr_medicalinfoEntity = new List<hr_medicalinfoEntity>();
            try
            {
                listobjhr_medicalinfoEntity = KAF.FacadeCreatorObjects.hr_medicalinfoFCC.GetFacadeCreate().GAPgListView((objhr_medicalinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_medicalinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "miltmedicalid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "medcommissionno" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "medcommsisiondate" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "medcommissionfiledescription" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "medcommissionfilepath" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "medcommissionfilename" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "medcommissionfiletype" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "medcommissionextension" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "medcommissionfileno" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "medcommissiondesc" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "docno" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "docdate" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "docfiledescription" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "docfilepath" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "docfilename" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "docfiletype" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "docextension" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "docfileno" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "medaction" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "miltmedicalid" + " " + orderDir;
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
        
        
        
         #region Create HrMedicalInfo

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
        public async Task<ActionResult> HrMedicalInfoNew(hr_medicalinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_medicalinfoEntity model = new hr_medicalinfoEntity();
				//model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_HrMedicalInfoNew", model);
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
        public async Task<ActionResult> HrMedicalInfoInsert(hr_medicalinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("miltmedicalid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("medcommissionno");
				 ModelState.Remove("medcommsisiondate");
				 ModelState.Remove("medcommissionfiledescription");
				 ModelState.Remove("medcommissionfilepath");
				 ModelState.Remove("medcommissionfilename");
				 ModelState.Remove("medcommissionfiletype");
				 ModelState.Remove("medcommissionextension");
				 ModelState.Remove("medcommissionfileno");
				 ModelState.Remove("medcommissiondesc");
				 ModelState.Remove("docno");
				 ModelState.Remove("docdate");
				 ModelState.Remove("docfiledescription");
				 ModelState.Remove("docfilepath");
				 ModelState.Remove("docfilename");
				 ModelState.Remove("docfiletype");
				 ModelState.Remove("docextension");
				 ModelState.Remove("docfileno");
				 ModelState.Remove("medaction");
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
					 //objFileList = input.cor_foldercontentsList;
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_medicalinfoFCC.GetFacadeCreate().Add_WithFiles(input).ToList();
					 
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
        
        
        #region update HrMedicalInfo

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
        public async Task<ActionResult> HrMedicalInfoEdit(hr_medicalinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.miltmedicalid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("miltmedicalid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_medicalinfoFCC.GetFacadeCreate().GetAll(new hr_medicalinfoEntity { miltmedicalid = input.miltmedicalid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                
                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 model.strValue6 = userid;
					 model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_MedicalInfo",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.miltmedicalid
					 //}).ToList();
					 //END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrMedicalInfoEdit", model);
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
        public async Task<ActionResult> HrMedicalInfoUpdate(hr_medicalinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("miltmedicalid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("medcommissionno");
				 ModelState.Remove("medcommsisiondate");
				 ModelState.Remove("medcommissionfiledescription");
				 ModelState.Remove("medcommissionfilepath");
				 ModelState.Remove("medcommissionfilename");
				 ModelState.Remove("medcommissionfiletype");
				 ModelState.Remove("medcommissionextension");
				 ModelState.Remove("medcommissionfileno");
				 ModelState.Remove("medcommissiondesc");
				 ModelState.Remove("docno");
				 ModelState.Remove("docdate");
				 ModelState.Remove("docfiledescription");
				 ModelState.Remove("docfilepath");
				 ModelState.Remove("docfilename");
				 ModelState.Remove("docfiletype");
				 ModelState.Remove("docextension");
				 ModelState.Remove("docfileno");
				 ModelState.Remove("medaction");
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
					 //objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == "deleted" || p.strValue1 == "added").ToList();
					 //input.cor_foldercontentsList = objFileList;
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_medicalinfoFCC.GetFacadeCreate().Update_WithFiles(input).ToList();
					 
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

        #region delete HrMedicalInfo

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
        public async Task<ActionResult> HrMedicalInfoDelete(hr_medicalinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("miltmedicalid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("medcommissionno");
				 ModelState.Remove("medcommsisiondate");
				 ModelState.Remove("medcommissionfiledescription");
				 ModelState.Remove("medcommissionfilepath");
				 ModelState.Remove("medcommissionfilename");
				 ModelState.Remove("medcommissionfiletype");
				 ModelState.Remove("medcommissionextension");
				 ModelState.Remove("medcommissionfileno");
				 ModelState.Remove("medcommissiondesc");
				 ModelState.Remove("docno");
				 ModelState.Remove("docdate");
				 ModelState.Remove("docfiledescription");
				 ModelState.Remove("docfilepath");
				 ModelState.Remove("docfilename");
				 ModelState.Remove("docfiletype");
				 ModelState.Remove("docextension");
				 ModelState.Remove("docfileno");
				 ModelState.Remove("medaction");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.miltmedicalid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("miltmedicalid", input.strModelPrimaryKey).ToString());
               
               
					//START OF NO CHANGE REGION
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 input.strValue6 = userid;
					 input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 // tablename = "Hr_MedicalInfo",
					 // folderid = long.Parse(input.strValue5),
					 // columnpkid = input.qualificationid
					 //}).ToList();
					 
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_medicalinfoFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
					 
					 //START OF NO CHANGE REGION
					  if (retArray != null && retArray.Count > 0)
					 {
						 ret = 0;
						 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						 //if (input.cor_foldercontentsList != null && input.cor_foldercontentsList.Count > 0)
						 //{
						 // List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						 //objFileDeleteList = input.cor_foldercontentsList;
						 
						 //foreach (cor_foldercontentsEntity file in objFileDeleteList)
						 //{
						 //objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						 //}
						 //}
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

        #region detail HrMedicalInfo

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
        public async Task<ActionResult> HrMedicalInfoDetail(hr_medicalinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.miltmedicalid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("miltmedicalid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_medicalinfoFCC.GetFacadeCreate().GetAll(new hr_medicalinfoEntity { miltmedicalid = input.miltmedicalid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 model.strValue6 = userid;
					 model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_MedicalInfo",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.miltmedicalid
					 //}).ToList();
					 //END OF NO CHANGE REGION
                
                ModelState.Clear();
                return PartialView("_HrMedicalInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



