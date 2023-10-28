
using KAF.BusinessDataObjects;
using KAF.WebFramework;
using KAF.CustomHelper.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Common;
using System.Collections;
using KAF.CustomFilters.Filters;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Security.Cryptography;
using DataTables.Mvc;
using System.Configuration;
using static KAF.WebFramework.RedisLogActivity;
using KAF.AppConfiguration.EncryptionHandler;
using System.Web.Routing;
using System.Threading;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using KAF.MVC.Common;
using KAF.AppConfiguration.Configuration;
using Newtonsoft.Json;

namespace KAFWebAdmin.Controllers.Security
{
    public class UserManagementController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        clsSecurityPanel objSecPanel = new clsSecurityPanel();
        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
        #region User List Page
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserPage()
        {
            return View("UserPage");
        }

        #endregion User List Page

        #region CREATE USER
        // Get Method for Create User page load  
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> CreateUser()
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
                var list = new DataCacheController().GetCacheData(clsDataCache.owin_role[0].ToString());// (IList)HttpRuntime.Cache[clsDataCache.owin_role[0]];
                ViewBag.rolelist = (List<KAFGenericComboEntity>)list;
                ViewBag.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
            return View();
        }

        private void CreateAllFolders(string userid, SecurityCapsule sec)
        {
            KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();

            //if (!objFTP.FolderCheckFTP(userid + "/"))
            //{
            string userfolderpath = userid + "/";

            objFTP.CreateFTPDir(userfolderpath);

            cor_folderstructureEntity objFolder = new cor_folderstructureEntity();
            objFolder.foldername = userid.ToString();
            objFolder.purpose = "Upload";
            objFolder.isshared = false;
            objFolder.userid = new Guid(userid);
            objFolder.BaseSecurityParam = new SecurityCapsule();
            objFolder.BaseSecurityParam = sec;
            objFolder.ex_bigint1 = 5; //1 for Taks,2 for Correspondance,3 for meeting,4 for notification,5-Uplaod
            //objFolder.ex_bigint2 = ret;
            //var FolderID = KAF.FacadeCreatorObjects.cor_folderstructureFCC.GetFacadeCreate().Add(objFolder);

            var otherfolderpath = userfolderpath + "Tasks/";

            objFTP.CreateFTPDir(otherfolderpath);

            otherfolderpath = userfolderpath + "Meeting/";
            objFTP.CreateFTPDir(otherfolderpath);

            otherfolderpath = userfolderpath + "Correspondance/";
            objFTP.CreateFTPDir(otherfolderpath);

            otherfolderpath = userfolderpath + "Upload/";
            objFTP.CreateFTPDir(otherfolderpath);

            // }

        }


        //POST Method for User Create      
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> SaveUser(KAF.BusinessDataObjects.owin_userEntity input)
        {
            KAF.AppConfiguration.Configuration.transactioncodeGen objTranCodeGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();

            string str = string.Empty;
            string url = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "UserManagement", "User", input.currenturl);
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                string tempImagePath = input.UserProfilePhoto;
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.applicationid = new Guid(System.Configuration.ConfigurationManager.AppSettings["appid"]);
                input.BaseSecurityParam = sec;
                input.isanonymous = false;
                //input.approved = input.approved != null ? input.approved : null;
                //input.locked = input.locked != null ? input.locked : null;
                input.approved = true;
                input.locked = false;
                input.isreviewed = false;

                string part = "R" + DateTime.Now.Ticks.ToString();
                input.userid = objTranCodeGen.StringToGUID(part);

                //Uri uri = new Uri(input.UserProfilePhoto);
                //string filename = Path.GetFileName(uri.LocalPath);
                //input.UserProfilePhoto = System.Configuration.ConfigurationManager.AppSettings["uploadfolderServices"] + input.userid + "/Upload/" + filename;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                input.masprivatekey = rsa.ToXmlString(true);
                input.maspublickey = rsa.ToXmlString(false);

                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("locked");
                ModelState.Remove("approved");

                if (ModelState.IsValid)
                {
                    Int64 ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().CreateUser(input);
                    if (ret > 0)
                    {
                        owin_userEntity objNewUser = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity() { masteruserid = ret }).FirstOrDefault();
                        if (objNewUser != null)
                        {

                            CreateAllFolders(objNewUser.userid.ToString(), sec);

                            //objFTP.MoveFTPFile(System.Configuration.ConfigurationManager.AppSettings["TempFolder"], objNewUser.userid.ToString(), filename);

                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = DomainUrl.GetDomainUrl() + "UserManagement/UserPage", responsetext = KAF.MsgContainer._Common._saveInformation });
                        }
                        else
                            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

        #region UPDATE USER
        //Get Method for update User page load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> EditUser_Get(owin_userEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                string strid = objClsPrivate.GetUrlParamValMVCOnlyParam("masteruserid", input.username);
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
                //var list = new DataCacheController().GetCacheData(clsDataCache.owin_role[0].ToString());// (IList)HttpRuntime.Cache[clsDataCache.owin_role[0]];
                // ViewBag.rolelist = (List<KAFGenericComboEntity>)list;
                var RoleCache = new DataCacheController().GetCacheData(clsDataCache.owin_role[0].ToString());

                var user_role_list = KAF.FacadeCreatorObjects.owin_userroleFCC.GetFacadeCreate().GetAll(new owin_userroleEntity { masteruserid = Convert.ToInt64(strid) }).ToList();

                var model = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity { masteruserid = Convert.ToInt64(strid) }).FirstOrDefault();
                ViewBag.UserProfilePhoto = model.UserProfilePhoto;
                ViewBag.tempUserProfilePhoto = model.UserProfilePhoto;
                if (user_role_list != null)
                {

                    //var objgenderlist = RoleCache.Where(p => p.comId == model.userroleid).Select(x => new { x.comId, x.comText }).ToList();
                    var rolelistcache = (from t in RoleCache
                                         join c in user_role_list on t.comId equals c.roleid
                                         select new
                                         {
                                             comId = t.comId,
                                             comText = t.comText
                                         }).ToList();



                    ViewBag.preloadedGen_Role = JsonConvert.SerializeObject(rolelistcache);
                }

                if (model.ex_bigint1 != null)
                {
                    List<gen_okpEntity> listgen_okp = KAF.FacadeCreatorObjects.gen_okpFCC.GetFacadeCreate().GetAll(new gen_okpEntity { okpid = model.ex_bigint1 }).ToList();
                    var objgen_okp = (from t in listgen_okp
                                      select new
                                      {
                                          comId = t.okpid,
                                          comText = t.okpname
                                      }).ToList();
                    ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                }
                ModelState.Clear();
                return PartialView("_EditUser", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> EditUser(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            string url = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "UserManagement", "User", input.currenturl);
            SecurityCapsule sec = new SecurityCapsule();

            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.applicationid = new Guid(System.Configuration.ConfigurationManager.AppSettings["appid"]);
                input.BaseSecurityParam = sec;
                input.isanonymous = false;
                input.approved = input.approved != null ? input.approved : null;
                input.locked = input.locked != null ? input.locked : null;

                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("userame");
                ModelState.Remove("locked");
                ModelState.Remove("approved");

                if (ModelState.IsValid)
                {
                    try
                    {
                        if (input.ex_nvarchar1 == input.UserProfilePhoto)
                            input.UserProfilePhoto = null;
                        else
                        {
                            input.ex_nvarchar1 = "~/" + input.ex_nvarchar1.Remove(0, DomainUrl.GetDomainUrl().Length);
                            var dirPath = Server.MapPath(input.ex_nvarchar1);
                            if (System.IO.File.Exists(dirPath))
                            {
                                System.IO.File.Delete(dirPath);
                            }
                        }
                    }
                    catch { }
                    Int64 ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UpdateUser(input);
                    if (ret > 0)
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Common._updateInformation });
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion UPDATE USER

        #region DELETE USER
        [HttpPost]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DeleteUser(owin_userEntity input)
        {
            string str = string.Empty;
            string url = objClsPrivate.GetURLGen(this.ControllerContext, RouteTable.Routes, "UserManagement", "User", input.currenturl);
            SecurityCapsule sec = new SecurityCapsule();

            try
            {
                string strid = objClsPrivate.GetUrlParamValMVCOnlyParam("masteruserid", input.username);
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.BaseSecurityParam = sec;

                ModelState.Remove("emailaddress");
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");

                if (ModelState.IsValid)
                {
                    owin_userEntity objUser = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity()
                    {
                        masteruserid = long.Parse(strid)
                    }).FirstOrDefault();

                    if (objUser != null)
                    {
                        long retVal = -99;
                        retVal = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().DeleteUser(objUser);

                        if (retVal > 0)
                        {
                            objUser.UserProfilePhoto = "~/" + objUser.UserProfilePhoto.Remove(0, DomainUrl.GetDomainUrl().Length);

                            var dirPath = Server.MapPath(input.ex_nvarchar1);
                            if (System.IO.File.Exists(dirPath))
                            {
                                System.IO.File.Delete(dirPath);
                            }
                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Common._deleteInformation });
                        }
                        else
                            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion DELETE USER

        #region Get USER SINGLE/LIST

        //Get Method for update User page load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> User_Get(owin_userEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                string strid = objClsPrivate.GetUrlParamValMVCOnlyParam("masteruserid", input.username);
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
                var RoleCache = new DataCacheController().GetCacheData(clsDataCache.owin_role[0].ToString());

                var user_role_list = KAF.FacadeCreatorObjects.owin_userroleFCC.GetFacadeCreate().GetAll(new owin_userroleEntity { masteruserid = Convert.ToInt64(strid) }).ToList();

                var model = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity { masteruserid = Convert.ToInt64(strid) }).FirstOrDefault();
                ViewBag.UserProfilePhoto = model.UserProfilePhoto;
                ViewBag.tempUserProfilePhoto = model.UserProfilePhoto;
                if (user_role_list != null)
                {

                    //var objgenderlist = RoleCache.Where(p => p.comId == model.userroleid).Select(x => new { x.comId, x.comText }).ToList();
                    var rolelistcache = (from t in RoleCache
                                         join c in user_role_list on t.comId equals c.roleid
                                         select new
                                         {
                                             comId = t.comId,
                                             comText = t.comText
                                         }).ToList();



                    ViewBag.preloadedGen_Role = JsonConvert.SerializeObject(rolelistcache);
                }
                if (model.ex_bigint1 != null)
                {
                    List<gen_okpEntity> listgen_okp = KAF.FacadeCreatorObjects.gen_okpFCC.GetFacadeCreate().GetAll(new gen_okpEntity { okpid = model.ex_bigint1 }).ToList();
                    var objgen_okp = (from t in listgen_okp
                                      select new
                                      {
                                          comId = t.okpid,
                                          comText = t.okpname
                                      }).ToList();
                    ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                }
                ModelState.Clear();
                return PartialView("_ViewUser", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }

        //Get Method for update User page load
        [HttpPost]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        [ValidateAntiForgeryToken]
        [RequestValidationAttribute]
        [ValidateInput(true)]
        public async Task<ActionResult> LoadUserDataTable([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userEntity input)
        {
            string redirectURL = Url.Action("User", "UserManagement");
            JsonResult result = new JsonResult();

            try
            {
                string search = Request.Form.GetValues("search[value]")[0];

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

                // Loading.  
                List<owin_userEntity> data = this.GetAlluser(input);
                if (data != null && data.Count > 0)
                {
                    // Total record count.  
                    Int64 totalRecords = data.FirstOrDefault().RETURN_KEY;
                    var filteredcols = (from t in data
                                        select new
                                        {
                                            t.loweredusername,
                                            t.username,
                                            t.mobilenumber,
                                            t.emailaddress,
                                            t.masteruserid,
                                            t.actionview,
                                            t.actionedit,
                                            t.actiondelete,
                                            ex_nvarchar1 = objSecPanel.genButtonPanel(t.masteruserid.GetValueOrDefault(-99), "masteruserid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "UserManagement/EditUser", "EditUser", "UserManagement/DeleteUser", "DeleteUser",
                                       "UserManagement/ViewUser", "UserDetails")
                                        }).ToList();

                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = filteredcols }, JsonRequestBehavior.AllowGet);
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

        //Column wise sorting
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "loweredusername" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "username" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "mobilenumber" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "emailaddress" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "loweredusername" + " " + orderDir;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sortingVal;
        }
        List<owin_userEntity> GetAlluser(owin_userEntity objUserEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_userEntity> listUserInfo = new List<owin_userEntity>();
            try
            {
                listUserInfo = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAllByPages((objUserEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listUserInfo;
        }

        #endregion Get USER LIST

        #region FILE HANDLING
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
        public async Task<JsonResult> UploadAttachment(HttpPostedFileBase attachment,
            string token,
            string userinfo,
            string useripaddress,
            string sessionid,
            string methodname,
            string currenturl)
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

                        string HTMLString = ""; string firstimage = "";

                        int iFileSize = file.ContentLength;
                        string fileName = file.FileName;
                        string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                        string filetype = string.Empty;

                        string FileNamePrefix = obj.GetRandomAlphaNumericStringForTransactionActivity("UPLD", DateTime.Now);

                        filetype = objClsPrivate.GetFileExtentionAndSizeValidated(currenturl, iFileSize, fileExtension);

                        string fileSize = file.ContentLength.ToString();
                        Stream streamObj = file.InputStream;
                        Byte[] buffer = new Byte[file.ContentLength];
                        streamObj.Read(buffer, 0, buffer.Length);
                        streamObj.Close();
                        streamObj = null;

                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["TempFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";

                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";


                        objFTP.UploadFileFTP(buffer, fileUploadDir, FileNamePrefix, fileExtension);

                        firstimage = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["uploadfolderServices"].ToString() + System.Configuration.ConfigurationManager.AppSettings["TempFolder"], FileNamePrefix + fileExtension); ;

                        ViewBag.UserProfilePhoto = firstimage;

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = firstimage, redirectUrl = "", responsetext = HTMLString });
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

                        filetype = objClsPrivate.GetFileExtentionAndSizeValidated(currenturl, iFileSize, fileExtension);

                        string fileSize = file.ContentLength.ToString();
                        Stream streamObj = file.InputStream;
                        Byte[] buffer = new Byte[file.ContentLength];
                        streamObj.Read(buffer, 0, buffer.Length);
                        streamObj.Close();
                        streamObj = null;

                        string fileUploadDir = userid;// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";

                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";

                        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
                        objFTP.UploadFileFTP(buffer, fileUploadDir, FileNamePrefix, fileExtension);

                        firstimage = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["uploadfolderServices"].ToString() + userid, FileNamePrefix + fileExtension); ;

                        ViewBag.UserProfilePhoto = firstimage;



                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = firstimage, redirectUrl = "", responsetext = HTMLString });
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
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DeleteAttachment(owin_userEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("username");
                ModelState.Remove("password");
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");
                ModelState.Remove("loweredusername");
                ModelState.Remove("approved");

                ModelState.Remove("locked");

                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                    if (!string.IsNullOrEmpty(input.UserProfilePhoto))
                    {
                        var userimagepath = input.UserProfilePhoto.Replace("\\", "/");
                        string strfile = userimagepath.Substring(userimagepath.LastIndexOf("/") + 1, userimagepath.Length - userimagepath.LastIndexOf("/") - 1);

                        //string strfile_ext ="."+ userimagepath.Substring(userimagepath.LastIndexOf(".") + 1, userimagepath.Length - userimagepath.LastIndexOf(".") - 1);

                        userimagepath = userimagepath.Replace("/" + strfile, "");

                        string userid = userimagepath.Substring(userimagepath.LastIndexOf("/") + 1, userimagepath.Length - userimagepath.LastIndexOf("/") - 1);
                        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();

                        objFTP.DeleteFileFTP(userid, strfile, "");
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

        //Get Method for View Single User page load
        [AllowCrossSiteJsonAttribute]
        [LoggingFilterAttribute]
        [AuthorizeFilterAttribute]
        public async Task<ActionResult> ViewUser(Int64 ID)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
                var list = (IList)HttpRuntime.Cache[clsDataCache.owin_role[0]];
                ViewBag.rolelist = (List<owin_roleEntity>)list;

                ViewBag.user_role_list = KAF.FacadeCreatorObjects.owin_userroleFCC.GetFacadeCreate().GetAll(new owin_userroleEntity { masteruserid = ID }).ToList();

                var model = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity { masteruserid = ID }).FirstOrDefault();
                return View(model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }




    }
}