
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
    public class HrCivilIDInfoController : BaseController
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
        public async Task<ActionResult> HrCivilIDInfo()
        {
            return View("HrCivilIDInfoLanding");
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
        public async Task<ActionResult> HrCivilIDInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_civilidinfoEntity input)
        {
            hr_civilidinfoEntity objowin_hr_civilidinfo = new hr_civilidinfoEntity();
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
           
                List<hr_civilidinfoEntity> data = this.GetAllHrCivilIDInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.civilid,
									 t.hrbasicid,
									 t.civilidno,
									 t.serialno,
									 t.civilidissuedate,
									 t.civilidexpirydate,
									 t.civilidfiledescription,
									 t.civilidfilepath,
									 t.civilidfilename,
									 t.civilidfiletype,
									 t.civilidextension,
									 t.civilidfileid,
									 t.civilidfiledescription_2,
									 t.civilidfilepath_2,
									 t.civilidfilename_2,
									 t.civilidfiletype_2,
									 t.civilidextension_2,
									 t.civilidfileid_2,
									 t.remarks,
									 t.forreview,
									 t.iscurrent,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.civilid.GetValueOrDefault(-99), "civilid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrCivilIDInfo/HrCivilIDInfoEdit", "HrCivilIDInfoEdit", 
                                   "", "",
                                   "HrCivilIDInfo/HrCivilIDInfoDetail", "HrCivilIDInfoDetail")
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
        
        
        List<hr_civilidinfoEntity> GetAllHrCivilIDInfoData(hr_civilidinfoEntity objhr_civilidinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_civilidinfoEntity> listobjhr_civilidinfoEntity = new List<hr_civilidinfoEntity>();
            try
            {
                listobjhr_civilidinfoEntity = KAF.FacadeCreatorObjects.hr_civilidinfoFCC.GetFacadeCreate().GAPgListView((objhr_civilidinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_civilidinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "civilid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "civilidno" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "serialno" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "civilidissuedate" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "civilidexpirydate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "civilidfiledescription" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "civilidfilepath" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "civilidfilename" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "civilidfiletype" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "civilidextension" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "civilidfileid" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "civilidfiledescription_2" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "civilidfilepath_2" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "civilidfilename_2" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "civilidfiletype_2" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "civilidextension_2" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "civilidfileid_2" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "iscurrent" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "civilid" + " " + orderDir;
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
        
        
        
         #region Create HrCivilIDInfo

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
        public async Task<ActionResult> HrCivilIDInfoNew(hr_civilidinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                //hr_civilidinfoEntity model = new hr_civilidinfoEntity();

                return PartialView("_HrCivilIDInfoNew", input);
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
        public async Task<ActionResult> HrCivilIDInfoInsert(hr_civilidinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("civilid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("civilidno");
                ModelState.Remove("serialno");
                ModelState.Remove("civilidissuedate");
                ModelState.Remove("civilidexpirydate");
                ModelState.Remove("civilidfiledescription");
                ModelState.Remove("civilidfilepath");
                ModelState.Remove("civilidfilename");
                ModelState.Remove("civilidfiletype");
                ModelState.Remove("civilidextension");
                ModelState.Remove("civilidfileid");
                ModelState.Remove("civilidfiledescription_2");
                ModelState.Remove("civilidfilepath_2");
                ModelState.Remove("civilidfilename_2");
                ModelState.Remove("civilidfiletype_2");
                ModelState.Remove("civilidextension_2");
                ModelState.Remove("civilidfileid_2");
                ModelState.Remove("remarks");
                ModelState.Remove("forreview");
                ModelState.Remove("iscurrent");

                ModelState.Remove("fullname");
                ModelState.Remove("hrbasicid");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

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

                        input.civilidfilepath = fileUploadDir;
                        input.civilidfilename = fileName;
                        input.civilidfiletype = contenttype;
                        input.civilidextension = fileExtension;
                        input.civilidfiledescription = "";
                    }

                    if (input.file2 != null && input.file2.ContentLength > 0)
                    {
                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";
                        int iFileSize = input.file2.ContentLength;
                        string contenttype = input.file2.ContentType;
                        string filefullName = input.file2.FileName;
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(filefullName);
                        string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                        string filepath = Server.MapPath("~" + fileUploadDir);
                        if (!Directory.Exists(filepath))
                            Directory.CreateDirectory(filepath);
                        input.file2.SaveAs(filepath + filefullName);

                        input.civilidfilepath_2 = fileUploadDir;
                        input.civilidfilename_2 = fileName;
                        input.civilidfiletype_2 = contenttype;
                        input.civilidextension_2 = fileExtension;
                        input.civilidfiledescription_2 = "";
                    }

                    ret = KAF.FacadeCreatorObjects.hr_civilidinfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrCivilIDInfo

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
        public async Task<ActionResult> HrCivilIDInfoEdit(hr_civilidinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.civilid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("civilid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_civilidinfoFCC.GetFacadeCreate().GetAll(new hr_civilidinfoEntity { civilid = input.civilid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                model.militarynokw = input.militarynokw;


                ModelState.Clear();
                return PartialView("_HrCivilIDInfoEdit", model);
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
        public async Task<ActionResult> HrCivilIDInfoUpdate(hr_civilidinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                ModelState.Remove("civilid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("civilidno");
                ModelState.Remove("serialno");
                ModelState.Remove("civilidissuedate");
                ModelState.Remove("civilidexpirydate");
                ModelState.Remove("civilidfiledescription");
                ModelState.Remove("civilidfilepath");
                ModelState.Remove("civilidfilename");
                ModelState.Remove("civilidfiletype");
                ModelState.Remove("civilidextension");
                ModelState.Remove("civilidfileid");
                ModelState.Remove("civilidfiledescription_2");
                ModelState.Remove("civilidfilepath_2");
                ModelState.Remove("civilidfilename_2");
                ModelState.Remove("civilidfiletype_2");
                ModelState.Remove("civilidextension_2");
                ModelState.Remove("civilidfileid_2");
                ModelState.Remove("remarks");
                ModelState.Remove("forreview");
                ModelState.Remove("iscurrent");

                ModelState.Remove("fullname");
                ModelState.Remove("hrbasicid");
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

                        input.civilidfilepath = fileUploadDir;
                        input.civilidfilename = fileName;
                        input.civilidfiletype = contenttype;
                        input.civilidextension = fileExtension;
                        input.civilidfiledescription = "";
                    }

                    if (input.file2 != null && input.file2.ContentLength > 0)
                    {
                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["OtherDocumentFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";
                        int iFileSize = input.file2.ContentLength;
                        string contenttype = input.file2.ContentType;
                        string filefullName = input.file2.FileName;
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(filefullName);
                        string fileExtension = System.IO.Path.GetExtension(filefullName).ToLower();
                        string filepath = Server.MapPath("~" + fileUploadDir);
                        if (!Directory.Exists(filepath))
                            Directory.CreateDirectory(filepath);
                        input.file2.SaveAs(filepath + filefullName);

                        input.civilidfilepath_2 = fileUploadDir;
                        input.civilidfilename_2 = fileName;
                        input.civilidfiletype_2 = contenttype;
                        input.civilidextension_2 = fileExtension;
                        input.civilidfiledescription_2 = "";
                    }
                    ret = KAF.FacadeCreatorObjects.hr_civilidinfoFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrCivilIDInfo

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
        public async Task<ActionResult> HrCivilIDInfoDelete(hr_civilidinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("civilid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("civilidno");
				 ModelState.Remove("serialno");
				 ModelState.Remove("civilidissuedate");
				 ModelState.Remove("civilidexpirydate");
				 ModelState.Remove("civilidfiledescription");
				 ModelState.Remove("civilidfilepath");
				 ModelState.Remove("civilidfilename");
				 ModelState.Remove("civilidfiletype");
				 ModelState.Remove("civilidextension");
				 ModelState.Remove("civilidfileid");
				 ModelState.Remove("civilidfiledescription_2");
				 ModelState.Remove("civilidfilepath_2");
				 ModelState.Remove("civilidfilename_2");
				 ModelState.Remove("civilidfiletype_2");
				 ModelState.Remove("civilidextension_2");
				 ModelState.Remove("civilidfileid_2");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
				 ModelState.Remove("iscurrent");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.civilid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("civilid", input.strModelPrimaryKey).ToString());
               
               
					 var model = KAF.FacadeCreatorObjects.hr_civilidinfoFCC.GetFacadeCreate().Delete(input); 
                 
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

        #region detail HrCivilIDInfo

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
        public async Task<ActionResult> HrCivilIDInfoDetail(hr_civilidinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.civilid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("civilid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_civilidinfoFCC.GetFacadeCreate().GetAll(new hr_civilidinfoEntity { civilid = input.civilid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
                
                ModelState.Clear();
                return PartialView("_HrCivilIDInfoDetail", model);
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



