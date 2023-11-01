
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
using System.IO;

namespace KAFWebAdmin.Controllers.HR
{
    public class HrPassportInfoController : BaseController
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
        public async Task<ActionResult> HrPassportInfo()
        {
            return View("HrPassportInfoLanding");
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
        public async Task<ActionResult> HrPassportInfoTableData(hr_passportinfoEntity input)
        {
            hr_passportinfoEntity objowin_hr_passportinfo = new hr_passportinfoEntity();
            JsonResult result = new JsonResult();
            try
            {
                //string search = Request.Form.GetValues("search[value]")[0];
                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                #region Check if Military person exists
                hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
                objhr_svcinfo.militarynokw = input.militarynokw;
                objhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).SingleOrDefault();

                if (objhr_svcinfo != null)
                {
                    if (sec.okpid != null && sec.okpid != objhr_svcinfo.okpid)
                    {
                        result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Warning! Unauthorized search." }, JsonRequestBehavior.AllowGet);
                        return result;
                    }
                }

                #endregion


                //int CurrentPage = 0;
                //if (requestModel.Start == 0)
                //{
                //    CurrentPage = 1;
                //}
                //else
                //{
                //    CurrentPage = requestModel.Start / requestModel.Length + 1;
                //}

                //input.CurrentPage = CurrentPage;
                //input.PageSize = requestModel.Length;
                //input.SortExpression = SortByColumnWithOrder((Request.Form.GetValues("order[0][column]"))[0], (Request.Form.GetValues("order[0][dir]"))[0]);

                //if (search != "")
                //{
                //    input.strCommonSerachParam = "%" + search + "%";
                //}

                List<hr_passportinfoEntity> data = this.GetAllHrPassportInfoData(input);



                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.militarynokw,
                                   t.militarynobd,
                                   t.civilid,
                                   t.fullname,
                                   t.dateofbirth,
                                   t.passportid,
                                   t.hrbasicid,
                                   t.passportno,
                                   t.passportissuedate,
                                   t.passportexpirydate,
                                   t.passportissuecountryid,
                                   t.isfamilypassport,
                                   t.passportfiledescription,
                                   t.passportfilepath,
                                   t.passportfilename,
                                   t.passportfiletype,
                                   t.passportextension,
                                   t.passportfileid,
                                   t.remarks,
                                   t.forreview,
                                   t.iscurrent,

                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.passportid.GetValueOrDefault(-99), "passportid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrPassportInfo/HrPassportInfoEdit", "HrPassportInfoEdit",
                                   "", "",
                                   "HrPassportInfo/HrPassportInfoDetail", "HrPassportInfoDetail")
                               }).ToList();

                    result = this.Json(new { recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut, responsetext = "" }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Data not found." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }


        List<hr_passportinfoEntity> GetAllHrPassportInfoData(hr_passportinfoEntity objhr_passportinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_passportinfoEntity> listobjhr_passportinfoEntity = new List<hr_passportinfoEntity>();
            try
            {
                listobjhr_passportinfoEntity = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GetAll((objhr_passportinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_passportinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "passportid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "passportno" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "passportissuedate" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "passportexpirydate" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "passportissuecountryid" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "isfamilypassport" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "passportfiledescription" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "passportfilepath" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "passportfilename" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "passportfiletype" + " " + orderDir;
                        break;
                    case "11":
                        sortingVal = "passportextension" + " " + orderDir;
                        break;
                    case "12":
                        sortingVal = "passportfileid" + " " + orderDir;
                        break;
                    case "13":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    case "14":
                        sortingVal = "forreview" + " " + orderDir;
                        break;
                    case "15":
                        sortingVal = "iscurrent" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "passportid" + " " + orderDir;
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



        #region Create HrPassportInfo

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
        public async Task<ActionResult> HrPassportInfoNew(hr_passportinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_passportinfoEntity model = new hr_passportinfoEntity();
                //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                //List<hr_passportinfoEntity> listobjhr_passportinfoEntity = new List<hr_passportinfoEntity>();
                //model = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GetAll_Ext(input).SingleOrDefault();
                return PartialView("_HrPassportInfoNew", input);
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
        public async Task<ActionResult> HrPassportInfoInsert(hr_passportinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("passportid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("passportno");
                ModelState.Remove("passportissuedate");
                ModelState.Remove("passportexpirydate");
                ModelState.Remove("passportissuecountryid");
                ModelState.Remove("isfamilypassport");
                ModelState.Remove("passportfiledescription");
                ModelState.Remove("passportfilepath");
                ModelState.Remove("passportfilename");
                ModelState.Remove("passportfiletype");
                ModelState.Remove("passportextension");
                ModelState.Remove("passportfileid");
                ModelState.Remove("remarks");
                ModelState.Remove("forreview");
                ModelState.Remove("iscurrent");
                ModelState.Remove("fullname");
                ModelState.Remove("hrbasicid");

                ModelState.Remove("files");
                ModelState.Remove("token");
                ModelState.Remove("userinfo");
                ModelState.Remove("useripaddress");
                ModelState.Remove("sessionid");
                ModelState.Remove("methodname");
                ModelState.Remove("currenturl");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.file1 != null && input.file1.ContentLength > 0)
                    {
                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";
                        int iFileSize = input.file1.ContentLength;
                        string contenttype = input.file1.ContentType;
                        string filefullName = input.file1.FileName;
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(filefullName);
                        string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                        string filepath = Server.MapPath("~" + fileUploadDir);
                        if (!Directory.Exists(filepath))
                            Directory.CreateDirectory(filepath);
                        input.file1.SaveAs(filepath + fileName);

                        input.passportfilepath = fileUploadDir;
                        input.passportfilename = fileName;
                        input.passportfiletype = contenttype;
                        input.passportextension = fileExtension;
                        input.passportfiledescription = "";
                    }

                    if (input.file2 != null && input.file2.ContentLength > 0)
                    {
                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";
                        int iFileSize = input.file2.ContentLength;
                        string filefullName = input.file2.FileName;
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(filefullName);
                        string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                        string filepath = Server.MapPath("~" + fileUploadDir);
                        if (!Directory.Exists(filepath))
                            Directory.CreateDirectory(filepath);
                        input.file2.SaveAs(filepath + fileName + fileExtension);


                        input.passportfilepath_2 = fileUploadDir;
                        input.passportfilename_2 = fileName;
                        input.passportfiletype_2 = "";
                        input.passportextension_2 = fileExtension;
                        input.passportfiledescription_2 = "";
                    }

                    ret = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().Add(input);

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


        #region update HrPassportInfo

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
        public async Task<ActionResult> HrPassportInfoEdit(hr_passportinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.passportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("passportid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GetAll(new hr_passportinfoEntity { passportid = input.passportid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                //List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.passportissuecountryid }).ToList();
                //var objgen_country = (from t in listgen_country
                //select new
                //{
                //		 Id = t.countryid ,
                //		 Text = t.countryname 
                // }).ToList();
                //ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);



                //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                //model.strValue6 = userid;
                //model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                //model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
                //{
                //     tablename = "Hr_PassportInfo",
                //     folderid = long.Parse(model.strValue5),
                //     columnpkid = model.passportid
                //}).ToList();
                //END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrPassportInfoEdit", model);
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
        public async Task<ActionResult> HrPassportInfoUpdate(hr_passportinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("passportid");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("passportno");
                                 ModelState.Remove("passportissuedate");
                                 ModelState.Remove("passportexpirydate");
                                 ModelState.Remove("passportissuecountryid");
                                 ModelState.Remove("isfamilypassport");
                                 ModelState.Remove("passportfiledescription");
                                 ModelState.Remove("passportfilepath");
                                 ModelState.Remove("passportfilename");
                                 ModelState.Remove("passportfiletype");
                                 ModelState.Remove("passportextension");
                                 ModelState.Remove("passportfileid");
                                 ModelState.Remove("remarks");
                                 ModelState.Remove("forreview");
                                 ModelState.Remove("iscurrent");
                */
                ModelState.Remove("passportno");
                ModelState.Remove("fullname");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    ////START OF NO CHANGE REGION
                    // string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    // input.strValue6 = userid;
                    // input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    // //Int64 ret = 0;
                    // List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
                    // objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == "deleted" || p.strValue1 == "added").ToList();
                    // input.cor_foldercontentsList = objFileList;
                    // List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    // //END OF NO CHANGE REGION
                    // // CHANGE ThiS LINE TO MAKE A SAVE
                    // //retArray = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().Update_WithFiles(input).ToList();

                    // //START OF NO CHANGE REGION
                    //  if (retArray != null && retArray.Count > 0)
                    // {
                    //	 ret = 0;
                    //	 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
                    //	 if (objFileList != null && objFileList.Count > 0)
                    //	 {
                    //	 List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
                    //	 List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();
                    //	 objFileDeleteList = objFileList.Where(p => p.strValue1 == "deleted").ToList();
                    //	 objFileAddList = objFileList.Where(p => p.strValue1 == "added").ToList();
                    //	 foreach (cor_foldercontentsEntity file in objFileAddList)
                    //	 {
                    //	    byte[] imageBytes = Convert.FromBase64String(file.comment);
                    //	    objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
                    //	 }


                    //	 foreach (cor_foldercontentsEntity file in objFileDeleteList)
                    //	 {
                    //	 objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
                    //	 }
                    //	 }
                    // ret = 1;
                    // }
                    // //END OF NO CHANGE REGION
                    ret = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().Update_Ext(input);

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

        #region delete HrPassportInfo

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
        public async Task<ActionResult> HrPassportInfoDelete(hr_passportinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("passportid"); */
                ModelState.Remove("hrbasicid");
                ModelState.Remove("passportno");
                ModelState.Remove("passportissuedate");
                ModelState.Remove("passportexpirydate");
                ModelState.Remove("passportissuecountryid");
                ModelState.Remove("isfamilypassport");
                ModelState.Remove("passportfiledescription");
                ModelState.Remove("passportfilepath");
                ModelState.Remove("passportfilename");
                ModelState.Remove("passportfiletype");
                ModelState.Remove("passportextension");
                ModelState.Remove("passportfileid");
                ModelState.Remove("remarks");
                ModelState.Remove("forreview");
                ModelState.Remove("iscurrent");
                ModelState.Remove("fullname");
                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.passportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("passportid", input.strModelPrimaryKey).ToString());


                    //START OF NO CHANGE REGION
                    //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    //input.strValue6 = userid;
                    //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    //input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                    ////input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
                    ////{
                    //// tablename = "Hr_PassportInfo",
                    //// folderid = long.Parse(input.strValue5),
                    //// columnpkid = input.qualificationid
                    ////}).ToList();

                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    ////END OF NO CHANGE REGION
                    //// CHANGE ThiS LINE TO MAKE A SAVE
                    ////retArray = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();

                    ////START OF NO CHANGE REGION
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

                    ret = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrPassportInfo

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
        public async Task<ActionResult> HrPassportInfoDetail(hr_passportinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.passportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("passportid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GetAll_Ext(input).SingleOrDefault();

                ////END OF NO CHANGE REGION

                ModelState.Clear();
                return PartialView("_HrPassportInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        #region Get Basic Profile Data
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

        #endregion
    }
}



