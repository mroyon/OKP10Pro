
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
    public class HrBasicFileController : BaseController
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
        public async Task<ActionResult> HrBasicFile()
        {
            return View("HrBasicFileLanding");
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
        public async Task<ActionResult> HrBasicFileTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_basicfileEntity input)
        {
            hr_basicfileEntity objowin_hr_basicfile = new hr_basicfileEntity();
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
           
                List<hr_basicfileEntity> data = this.GetAllHrBasicFileData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.fileuploadid,
									 t.hrbasicid,
									 t.filetypeid,
									 t.filedescription,
									 t.filepath,
									 t.filename,
									 t.filetype,
									 t.extension,
									 t.remarks,
                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.fileuploadid.GetValueOrDefault(-99), "fileuploadid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrBasicFile/HrBasicFileEdit", "HrBasicFileEdit", 
                                   "HrBasicFile/HrBasicFileDelete", "HrBasicFileDelete",
                                   "HrBasicFile/HrBasicFileDetail", "HrBasicFileDetail")
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
        
        
        List<hr_basicfileEntity> GetAllHrBasicFileData(hr_basicfileEntity objhr_basicfileEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_basicfileEntity> listobjhr_basicfileEntity = new List<hr_basicfileEntity>();
            try
            {
                listobjhr_basicfileEntity = KAF.FacadeCreatorObjects.hr_basicfileFCC.GetFacadeCreate().GAPgListView((objhr_basicfileEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_basicfileEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "fileuploadid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "filetypeid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "filedescription" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "filepath" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "filename" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "filetype" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "extension" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "fileuploadid" + " " + orderDir;
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
        
        
        
         #region Create HrBasicFile

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
        public async Task<ActionResult> HrBasicFileNew(hr_basicfileEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_basicfileEntity model = new hr_basicfileEntity();
				//model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_HrBasicFileNew", model);
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
        public async Task<ActionResult> HrBasicFileInsert(hr_basicfileEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("fileuploadid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("filetypeid");
				 ModelState.Remove("filedescription");
				 ModelState.Remove("filepath");
				 ModelState.Remove("filename");
				 ModelState.Remove("filetype");
				 ModelState.Remove("extension");
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
					 //retArray = KAF.FacadeCreatorObjects.hr_basicfileFCC.GetFacadeCreate().Add_WithFiles(input).ToList();
					 
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
        
        
        #region update HrBasicFile

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
        public async Task<ActionResult> HrBasicFileEdit(hr_basicfileEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.fileuploadid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("fileuploadid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_basicfileFCC.GetFacadeCreate().GetAll(new hr_basicfileEntity { fileuploadid = input.fileuploadid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 List<gen_filetypeEntity> listgen_filetype = KAF.FacadeCreatorObjects.gen_filetypeFCC.GetFacadeCreate().GetAll(new gen_filetypeEntity { filetypeid = model.filetypeid }).ToList();
					 var objgen_filetype = (from t in listgen_filetype
					 select new
					 {
								 Id = t.filetypeid ,
								 Text = t.filetypename 
					  }).ToList();
					 ViewBag.preloadedGen_FileType = JsonConvert.SerializeObject(objgen_filetype);

                
                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 model.strValue6 = userid;
					 model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_BasicFile",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.fileuploadid
					 //}).ToList();
					 //END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrBasicFileEdit", model);
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
        public async Task<ActionResult> HrBasicFileUpdate(hr_basicfileEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("fileuploadid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("filetypeid");
				 ModelState.Remove("filedescription");
				 ModelState.Remove("filepath");
				 ModelState.Remove("filename");
				 ModelState.Remove("filetype");
				 ModelState.Remove("extension");
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
                    //retArray = KAF.FacadeCreatorObjects.hr_basicfileFCC.GetFacadeCreate().Update_WithFiles(input).ToList();

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

        #region delete HrBasicFile

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
        public async Task<ActionResult> HrBasicFileDelete(hr_basicfileEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("fileuploadid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("filetypeid");
				 ModelState.Remove("filedescription");
				 ModelState.Remove("filepath");
				 ModelState.Remove("filename");
				 ModelState.Remove("filetype");
				 ModelState.Remove("extension");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.fileuploadid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("fileuploadid", input.strModelPrimaryKey).ToString());
               
               
					//START OF NO CHANGE REGION
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 input.strValue6 = userid;
					 input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 // tablename = "Hr_BasicFile",
					 // folderid = long.Parse(input.strValue5),
					 // columnpkid = input.qualificationid
					 //}).ToList();
					 
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_basicfileFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
					 
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

        #region detail HrBasicFile

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
        public async Task<ActionResult> HrBasicFileDetail(hr_basicfileEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.fileuploadid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("fileuploadid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_basicfileFCC.GetFacadeCreate().GetAll(new hr_basicfileEntity { fileuploadid = input.fileuploadid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 List<gen_filetypeEntity> listgen_filetype = KAF.FacadeCreatorObjects.gen_filetypeFCC.GetFacadeCreate().GetAll(new gen_filetypeEntity { filetypeid = model.filetypeid }).ToList();
					 var objgen_filetype = (from t in listgen_filetype
					 select new
					 {
								 Id = t.filetypeid ,
								 Text = t.filetypename 
					  }).ToList();
					 ViewBag.preloadedGen_FileType = JsonConvert.SerializeObject(objgen_filetype);

                
					 //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 //model.strValue6 = userid;
					 //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_BasicFile",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.fileuploadid
					 //}).ToList();
					 //END OF NO CHANGE REGION
                
                ModelState.Clear();
                return PartialView("_HrBasicFileDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



