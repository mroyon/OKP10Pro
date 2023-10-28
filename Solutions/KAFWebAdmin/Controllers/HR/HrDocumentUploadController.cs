
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
using KAF.AppConfiguration.Configuration;
using System.IO;
using Microsoft.Office.Interop.Excel;
using static System.Net.WebRequestMethods;

namespace KAFWebAdmin.Controllers.HR
{
    public class HrDocumentUploadController : BaseController
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
        public async Task<ActionResult> HrDocumentUpload(hr_documentuploadEntity model)
        {
            var hrpersonalinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrpersonalinfoid", model.strModelPrimaryKey).ToString());
            ViewBag.hrbasicid = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().GetAll(new hr_personalinfoEntity { hrpersonalinfoid = hrpersonalinfoid }).FirstOrDefault().hrbasicid;
            //model.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrpersonalinfoid", model.strModelPrimaryKey).ToString());
            return PartialView("HrDocumentUploadLanding");
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
        public async Task<ActionResult> HrDocumentUploadTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_documentuploadEntity input)
        {
            hr_documentuploadEntity objowin_hr_documentupload = new hr_documentuploadEntity();
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



                List<hr_documentuploadEntity> data = this.GetAllHrDocumentUploadData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.docuploadid,
                                   t.doctypeid,
                                   t.filetypeid,
                                   t.docname,
                                   t.hrbasicid,
                                   t.orderno,
                                   t.orderdate,
                                   t.filedescription,
                                   t.filepath,
                                   t.filename,
                                   t.filetype,
                                   t.extension,
                                   t.remarks,

                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.docuploadid.GetValueOrDefault(-99), "docuploadid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrDocumentUpload/HrDocumentUploadEdit", "HrDocumentUploadEdit",
                                   "HrDocumentUpload/HrDocumentUploadDelete", "HrDocumentUploadDelete",
                                   "HrDocumentUpload/HrDocumentUploadDetail", "HrDocumentUploadDetail")
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


        List<hr_documentuploadEntity> GetAllHrDocumentUploadData(hr_documentuploadEntity objhr_documentuploadEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_documentuploadEntity> listobjhr_documentuploadEntity = new List<hr_documentuploadEntity>();
            try
            {
                listobjhr_documentuploadEntity = KAF.FacadeCreatorObjects.hr_documentuploadFCC.GetFacadeCreate().GAPgListView((objhr_documentuploadEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_documentuploadEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "docuploadid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "doctypeid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "filetypeid" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "docname" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "orderno" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "orderdate" + " " + orderDir;
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
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "docuploadid" + " " + orderDir;
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



        #region Create HrDocumentUpload

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
        public async Task<ActionResult> HrDocumentUploadNew(hr_documentuploadEntity input)
        {
            try
            {
                ModelState.Clear();
                return PartialView("_HrDocumentUploadNew", input);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        public ActionResult RedirectToGoogle(string val)
        {
            return Redirect(val);
        }

        //Create Page Create Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        //[RequestValidationAttribute]
        //[ExceptionFilterAttribute]
        public async Task<ActionResult> HrDocumentUploadInsert(HttpPostedFileBase frmdata)
        {
            try
            {
                hr_documentuploadEntity input = new hr_documentuploadEntity();
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("hrbasicid");
                ModelState.Remove("docuploadid");
                ModelState.Remove("doctypeid");
                ModelState.Remove("filetypeid");
                ModelState.Remove("docname");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("orderno");
                ModelState.Remove("orderdate");
                ModelState.Remove("filedescription");
                ModelState.Remove("filepath");
                ModelState.Remove("filename");
                ModelState.Remove("filetype");
                ModelState.Remove("extension");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {

                    HttpPostedFileBase file = Request.Files[0];

                    input.token = Request.Form["token"].ToString();
                    input.userinfo = Request.Form["userinfo"].ToString();
                    input.useripaddress = Request.Form["useripaddress"].ToString();
                    input.sessionid = Request.Form["sessionid"].ToString();
                    input.methodname = Request.Form["methodname"].ToString();
                    input.currenturl = Request.Form["currenturl"].ToString();
                    input.doctypeid = Convert.ToInt64(Request.Form["doctypeid"].ToString());
                    input.hrbasicid = Convert.ToInt64(Request.Form["hrbasicid"].ToString());
                    input.remarks = Request.Form["remarks"].ToString();
                    //input.filedescription = Request.Form["filedescription"].ToString();
                    input.docname = Request.Form["docname"].ToString();
                    var militarynokw = Request.Form["militarynokw"].ToString();
                    input.filename = $"{militarynokw}{input.doctypeid}{DateTime.Now.ToString("MMddyyyyHHmmss")}{System.IO.Path.GetExtension(file.FileName).ToLower()}";
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;//new SecurityCapsule(); ;

                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    ret = KAF.FacadeCreatorObjects.hr_documentuploadFCC.GetFacadeCreate().Add(input);

                    if (ret > 0)
                    {
                        if (file != null && file.ContentLength > 0)
                        {
                            string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                            if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                                fileUploadDir = fileUploadDir + "/";
                            int iFileSize = file.ContentLength;
                            string filefullName = file.FileName;
                            string fileName = input.filename;//System.IO.Path.GetFileNameWithoutExtension(filefullName);
                            string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                            string filepath = Server.MapPath("~" + fileUploadDir);
                            if (!Directory.Exists(filepath))
                                Directory.CreateDirectory(filepath);
                            file.SaveAs(filepath + fileName);
                        }
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


        #region update HrDocumentUpload

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
        public async Task<ActionResult> HrDocumentUploadEdit(hr_documentuploadEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.docuploadid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("docuploadid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_documentuploadFCC.GetFacadeCreate().GetAll(new hr_documentuploadEntity { docuploadid = input.docuploadid }).FirstOrDefault();
                var hr_svcEntity = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrbasicid = model.hrbasicid }).FirstOrDefault();
                string _strMilitaryNo = string.Empty;
                if (hr_svcEntity != null)
                {
                    _strMilitaryNo = hr_svcEntity.militarynokw.ToString();
                }
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //var gen_documenttype = KAF.FacadeCreatorObjects.gen_documenttypeFCC.GetFacadeCreate().GetAll(new gen_documenttypeEntity { doctypeid = input.doctypeid }).FirstOrDefault();
                List<gen_documenttypeEntity> gen_documenttype = KAF.FacadeCreatorObjects.gen_documenttypeFCC.GetFacadeCreate().GetAll(new gen_documenttypeEntity { doctypeid = input.doctypeid }).ToList();
                var objgen_documenttype = (from t in gen_documenttype
                                           select new
                                           {
                                               comId = t.doctypeid,
                                               comText = t.doctypename
                                           }).ToList();
                ViewBag.preloadedGen_FileType = JsonConvert.SerializeObject(objgen_documenttype);

                string fileUploadDir = $"{System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString()}/{_strMilitaryNo}";
                if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                    fileUploadDir = fileUploadDir + "/";
                string filepath = Server.MapPath("~" + fileUploadDir);
                model.filepath = filepath;
                model.filename = filepath + model.filename;
                ModelState.Clear();
                return PartialView("_HrDocumentUploadEdit", model);
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
        //[RequestValidationAttribute]
        //[ExceptionFilterAttribute]
        public async Task<ActionResult> HrDocumentUploadUpdate(HttpPostedFileBase frmdata)
        {
            try
            {
                hr_documentuploadEntity input = new hr_documentuploadEntity();
                string redirectURL = "";
                string str = string.Empty;
                string _foldername = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                ModelState.Remove("docuploadid");
                ModelState.Remove("doctypeid");
                ModelState.Remove("filetypeid");
                ModelState.Remove("docname");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("orderno");
                ModelState.Remove("orderdate");
                ModelState.Remove("filedescription");
                ModelState.Remove("filepath");
                ModelState.Remove("filename");
                ModelState.Remove("filetype");
                ModelState.Remove("extension");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    string _eFileName = string.Empty;
                    var _existingFileFullPath = Request.Form["existingFileName"].ToString();
                    if (!string.IsNullOrEmpty(_existingFileFullPath)) _eFileName = Path.GetFileName(_existingFileFullPath);

                    input.docuploadid = Convert.ToInt64(Request.Form["docuploadid"]);
                    input.token = Request.Form["token"].ToString();
                    input.userinfo = Request.Form["userinfo"].ToString();
                    input.useripaddress = Request.Form["useripaddress"].ToString();
                    input.sessionid = Request.Form["sessionid"].ToString();
                    input.methodname = Request.Form["methodname"].ToString();
                    input.currenturl = Request.Form["currenturl"].ToString();
                    input.doctypeid = Convert.ToInt64(Request.Form["doctypeid"].ToString());
                    input.hrbasicid = Convert.ToInt64(Request.Form["hrbasicid"].ToString());
                    input.remarks = Request.Form["remarks"].ToString();
                    input.docname = Request.Form["docname"].ToString();
                    var militarynokw = Request.Form["militarynokw"].ToString();
                    input.filename = Request.Files.Count > 0 ? $"{militarynokw}{input.doctypeid}{DateTime.Now.ToString("MMddyyyyHHmmss")}{System.IO.Path.GetExtension(Request.Files[0].FileName).ToLower()}" : _eFileName;
                    _foldername = militarynokw;
                    ret = KAF.FacadeCreatorObjects.hr_documentuploadFCC.GetFacadeCreate().Update(input);

                    if (ret > 0)
                    {
                        if (Request.Files.Count > 0)
                        {
                            HttpPostedFileBase file = Request.Files[0];

                            if (System.IO.Path.GetFileNameWithoutExtension(_eFileName).ToLower() != System.IO.Path.GetFileNameWithoutExtension(file.FileName).ToLower())
                            {
                                if (System.IO.File.Exists(_existingFileFullPath)) System.IO.File.Delete(_existingFileFullPath);
                            }

                            string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString() + "/" + _foldername;// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                            if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                                fileUploadDir = fileUploadDir + "/";
                            int iFileSize = file.ContentLength;
                            string filefullName = file.FileName;
                            string fileName = input.filename;//System.IO.Path.GetFileNameWithoutExtension(filefullName);
                            string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                            string filepath = Server.MapPath("~" + fileUploadDir);
                            if (!Directory.Exists(filepath))
                                Directory.CreateDirectory(filepath);
                            file.SaveAs(filepath + fileName);
                        }


                        ModelState.Clear();
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._updateInformation });
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

        #region delete HrDocumentUpload

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
        public async Task<ActionResult> HrDocumentUploadDelete(hr_documentuploadEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("docuploadid"); */
                ModelState.Remove("doctypeid");
                ModelState.Remove("filetypeid");
                ModelState.Remove("docname");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("orderno");
                ModelState.Remove("orderdate");
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
                    input.docuploadid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("docuploadid", input.strModelPrimaryKey).ToString());


                    string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    input.strValue6 = userid;
                    input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                    //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
                    //{
                    // tablename = "Hr_DocumentUpload",
                    // folderid = long.Parse(input.strValue5),
                    // columnpkid = input.docuploadid
                    //}).ToList();

                    List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    //retArray = KAF.FacadeCreatorObjects.hr_documentuploadFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
                    // if (retArray != null && retArray.Count > 0)
                    //{
                    // clsFileHandler objFilehandler = new clsFileHandler();
                    // //ret = objFilehandler.ManageFiles_DeleteAll(System.Web.HttpContext.Current.Session, "Hr_DocumentUpload", input.docuploadid.GetValueOrDefault());
                    //}


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

        #region detail HrDocumentUpload

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
        public async Task<ActionResult> HrDocumentUploadDetail(hr_documentuploadEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.docuploadid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("docuploadid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_documentuploadFCC.GetFacadeCreate().GetAll(new hr_documentuploadEntity { docuploadid = input.docuploadid }).FirstOrDefault();
                var hr_svcEntity = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrbasicid = model.hrbasicid }).FirstOrDefault();
                string _strMilitaryNo = string.Empty;
                if (hr_svcEntity != null)
                {
                    _strMilitaryNo = hr_svcEntity.militarynokw.ToString();
                }
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //var gen_documenttype = KAF.FacadeCreatorObjects.gen_documenttypeFCC.GetFacadeCreate().GetAll(new gen_documenttypeEntity { doctypeid = input.doctypeid }).FirstOrDefault();
                List<gen_documenttypeEntity> gen_documenttype = KAF.FacadeCreatorObjects.gen_documenttypeFCC.GetFacadeCreate().GetAll(new gen_documenttypeEntity { doctypeid = input.doctypeid }).ToList();
                var objgen_documenttype = (from t in gen_documenttype
                                           select new
                                           {
                                               comId = t.doctypeid,
                                               comText = t.doctypename
                                           }).ToList();
                ViewBag.preloadedGen_FileType = JsonConvert.SerializeObject(objgen_documenttype);

                string fileUploadDir = $"{System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString()}/{_strMilitaryNo}";
                if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                    fileUploadDir = fileUploadDir + "/";
                string filepath = Server.MapPath("~" + fileUploadDir);
                model.filepath = filepath;
                model.filename = filepath + model.filename;
                ModelState.Clear();

                ModelState.Clear();
                return PartialView("_HrDocumentUploadDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        #region File Upload

        [HttpPost]
        //[AuthorizeFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[AllowCrossSiteJsonAttribute]
        //[ActionParameterInjector]
        //[ValidateInput(true)]
        //[SecurityFillerAttribute]
        ////[LoggingFilterAttribute]
        //[ExceptionFilterAttribute]
        //[RequestValidationAttribute]
        public async Task<JsonResult> UploadAttachment(
            //string token,
            //string userinfo,
            //string useripaddress,
            //string sessionid,
            //string methodname,
            //string currenturl, string militarynokw
            )
        {
            HttpPostedFileBase file = Request.Files[0];

            if (file != null && file.ContentLength > 0)
            {

                try
                {
                    transactioncodeGen obj = new transactioncodeGen();
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {

                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";

                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";

                        string firstimage = "";

                        int iFileSize = file.ContentLength;
                        string filefullName = file.FileName;
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(filefullName);
                        string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                        //string filetype = string.Empty;

                        string filepath = Server.MapPath("~" + fileUploadDir);
                        if (!Directory.Exists(filepath))
                            Directory.CreateDirectory(filepath);
                        file.SaveAs(filepath + fileName + fileExtension);

                        //firstimage = Path.Combine(DomainUrl.GetDomainUrl(), System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"], militarynokw + fileExtension); ;

                        //ViewBag.userprofilephoto = firstimage;

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = firstimage, redirectUrl = "", responsetext = fileExtension });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Bad Request! Upload Failed" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            else
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ActionParameterInjector]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<JsonResult> UploadAttachmentEdit(HttpPostedFileBase attachment,
            string token,
            string userinfo,
            string useripaddress,
            string sessionid,
            string methodname,
            string currenturl,
            string userid,
            string masteruserid)
        {
            HttpPostedFileBase file = Request.Files[0];

            if (file != null && file.ContentLength > 0)
            {
                transactioncodeGen obj = new transactioncodeGen();
                try
                {
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {
                        string HTMLString = ""; string firstimage = "";

                        int iFileSize = file.ContentLength;
                        string fileName = file.FileName;
                        string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                        string filetype = string.Empty;

                        string FileNamePrefix = obj.GetRandomAlphaNumericStringForTransactionActivity("UPLD", DateTime.Now);

                        string filepath = Server.MapPath("~/Uploads/");
                        file.SaveAs(filepath + userid + "/" + FileNamePrefix + fileExtension);

                        //objFTP.UploadFileFTP(buffer, fileUploadDir, FileNamePrefix, fileExtension);

                        firstimage = Path.Combine(DomainUrl.GetDomainUrl() + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"], userid, FileNamePrefix + fileExtension); ;


                        ViewBag.userprofilephoto = firstimage;



                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = firstimage, redirectUrl = "", responsetext = FileNamePrefix + fileExtension });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Bad Request! Upload Failed" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            else
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        //[ValidateInput(true)]
        //[AllowCrossSiteJsonAttribute]
        //[RequestValidationAttribute]
        //[LoggingFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[SecurityFillerAttribute]
        //[AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DeleteAttachment(hr_svcinfoEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("name1");
                ModelState.Remove("name2");
                ModelState.Remove("fullname");
                ModelState.Remove("hrbasicid");
                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                    if (!string.IsNullOrEmpty(input.profilephotofilepath))
                    {
                        string domainURL = DomainUrl.GetDomainUrl();

                        if (System.IO.File.Exists(Path.Combine(domainURL, Server.MapPath(input.profilephotofilepath))))
                        {
                            System.IO.File.Delete(Path.Combine(domainURL, Server.MapPath(input.profilephotofilepath)));
                        }
                    }

                    ViewBag.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";
                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = ViewBag.UserProfilePhoto, responsetext = KAF.MsgContainer._Common._deleteInformation });
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

    }
}



