
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
    public class HrResidentVisaController : BaseController
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
        public async Task<ActionResult> HrResidentVisa()
        {
            return View("HrResidentVisaLanding");
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
        public async Task<ActionResult> HrResidentVisaTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_residentvisaEntity input)
        {
            hr_residentvisaEntity objowin_hr_residentvisa = new hr_residentvisaEntity();
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
           
                List<hr_residentvisaEntity> data = this.GetAllHrResidentVisaData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.residentid,
									 t.hrbasicid,
									 t.passportid,
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
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.residentid.GetValueOrDefault(-99), "residentid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrResidentVisa/HrResidentVisaEdit", "HrResidentVisaEdit", 
                                   "HrResidentVisa/HrResidentVisaDelete", "HrResidentVisaDelete",
                                   "HrResidentVisa/HrResidentVisaDetail", "HrResidentVisaDetail")
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
        
        
        List<hr_residentvisaEntity> GetAllHrResidentVisaData(hr_residentvisaEntity objhr_residentvisaEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_residentvisaEntity> listobjhr_residentvisaEntity = new List<hr_residentvisaEntity>();
            try
            {
                listobjhr_residentvisaEntity = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().GAPgListView((objhr_residentvisaEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_residentvisaEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "residentid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "passportid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "residencynumber" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "issuedate" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "expirydate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "isfamilyvisa" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "filedescription" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "filepath" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "filename" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "filetype" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "extension" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "fileno" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "residentid" + " " + orderDir;
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
        
        
        
         #region Create HrResidentVisa

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
        public async Task<ActionResult> HrResidentVisaNew(hr_residentvisaEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_residentvisaEntity model = new hr_residentvisaEntity();
				model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_HrResidentVisaNew", model);
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
        public async Task<ActionResult> HrResidentVisaInsert(hr_residentvisaEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("residentid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("passportid");
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
                    //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    //input.strValue6 = userid;
                    //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    //Int64 ret = 0;
                    //List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
                    //objFileList = input.cor_foldercontentsList;
                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    ////END OF NO CHANGE REGION
                    //// CHANGE ThiS LINE TO MAKE A SAVE
                    ////retArray = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().Add_WithFiles(input).ToList();

                    ////START OF NO CHANGE REGION
                    // if (retArray != null && retArray.Count > 0)
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
                    ret = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrResidentVisa

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
        public async Task<ActionResult> HrResidentVisaEdit(hr_residentvisaEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.residentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("residentid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().GetAll(new hr_residentvisaEntity { residentid = input.residentid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_passportinfoEntity> listhr_passportinfo = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GetAll(new hr_passportinfoEntity { passportid = model.passportid }).ToList();
					 //var objhr_passportinfo = (from t in listhr_passportinfo
					 //select new
					 //{
						//		 Id = t.passportid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_PassportInfo = JsonConvert.SerializeObject(objhr_passportinfo);

                
                
					 //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_ResidentVisa",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.residentid
					 //}).ToList();
					 ////END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrResidentVisaEdit", model);
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
        public async Task<ActionResult> HrResidentVisaUpdate(hr_residentvisaEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("residentid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("passportid");
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
					 //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //input.strValue6 = userid;
					 //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 ////Int64 ret = 0;
					 //List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
					 //objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == "deleted" || p.strValue1 == "added").ToList();
					 //input.cor_foldercontentsList = objFileList;
					 //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 ////END OF NO CHANGE REGION
					 //// CHANGE ThiS LINE TO MAKE A SAVE
					 ////retArray = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().Update_WithFiles(input).ToList();
					 
					 ////START OF NO CHANGE REGION
					 // if (retArray != null && retArray.Count > 0)
					 //{
						// ret = 0;
						// KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						// if (objFileList != null && objFileList.Count > 0)
						// {
						// List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						// List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();
						// objFileDeleteList = objFileList.Where(p => p.strValue1 == "deleted").ToList();
						// objFileAddList = objFileList.Where(p => p.strValue1 == "added").ToList();
						// foreach (cor_foldercontentsEntity file in objFileAddList)
						// {
						//    byte[] imageBytes = Convert.FromBase64String(file.comment);
						//    objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
						// }
						 
						 
						// foreach (cor_foldercontentsEntity file in objFileDeleteList)
						// {
						// objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						// }
						// }
					 //ret = 1;
					 //}
					 //END OF NO CHANGE REGION
					 
                    ret = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().Update(input);

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

        #region delete HrResidentVisa

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
        public async Task<ActionResult> HrResidentVisaDelete(hr_residentvisaEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("residentid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("passportid");
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
                    input.residentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("residentid", input.strModelPrimaryKey).ToString());
               
               
					//START OF NO CHANGE REGION
					 //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //input.strValue6 = userid;
					 //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 // tablename = "Hr_ResidentVisa",
					 // folderid = long.Parse(input.strValue5),
					 // columnpkid = input.qualificationid
					 //}).ToList();
					 
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
					 
					 //START OF NO CHANGE REGION
					 // if (retArray != null && retArray.Count > 0)
					 //{
						// ret = 0;
						// KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						// if (input.cor_foldercontentsList != null && input.cor_foldercontentsList.Count > 0)
						// {
						//  List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						// objFileDeleteList = input.cor_foldercontentsList;
						 
						// foreach (cor_foldercontentsEntity file in objFileDeleteList)
						// {
						// objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						// }
						// }
					 //ret = 1;
					 //}
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

        #region detail HrResidentVisa

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
        public async Task<ActionResult> HrResidentVisaDetail(hr_residentvisaEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.residentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("residentid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_residentvisaFCC.GetFacadeCreate().GetAll(new hr_residentvisaEntity { residentid = input.residentid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_passportinfoEntity> listhr_passportinfo = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GetAll(new hr_passportinfoEntity { passportid = model.passportid }).ToList();
					 //var objhr_passportinfo = (from t in listhr_passportinfo
					 //select new
					 //{
						//		 Id = t.passportid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_PassportInfo = JsonConvert.SerializeObject(objhr_passportinfo);

                
					 //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_ResidentVisa",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.residentid
					 //}).ToList();
					 ////END OF NO CHANGE REGION
                
                ModelState.Clear();
                return PartialView("_HrResidentVisaDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



