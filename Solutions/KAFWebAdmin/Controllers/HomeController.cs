using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml;
using static KAF.WebFramework.RedisLogActivity;
using log4net;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using KAF.MVC.Common;
using System.Net;
using System.Net.Sockets;
using DataTables.Mvc;
using KAF.CustomHelper;

namespace KAFWebAdmin.Controllers
{
    public class HomeController : BaseController
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        SecurityCapsule sec = new SecurityCapsule();

        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> Index()
        {
            string str = string.Empty;
            var model = new owin_userEntity();
            try
            {
                var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                if (claimsIdentity != null)
                {
                    model.masteruserid = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber").FirstOrDefault().Value);
                    model.username = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").FirstOrDefault().Value;
                    model.userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);
                    model.loweredusername = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                    //model.UserProfilePhoto = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname").FirstOrDefault().Value;
                    model.emailaddress = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                    model.comment = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode").FirstOrDefault().Value;

                    var identity = (ClaimsIdentity)User.Identity;
                    var strhrbasicid = identity.Claims.Where(c => c.Type == ClaimTypes.OtherPhone)
                        .Select(c => c.Value).SingleOrDefault();
                    var struserid = identity.Claims.Where(c => c.Type == ClaimTypes.Gender)
                     .Select(c => c.Value).SingleOrDefault();

                    var objModel = KAF.FacadeCreatorObjects.owin_userroleFCC.GetFacadeCreate().GetAll(new owin_userroleEntity { masteruserid=model.masteruserid}).FirstOrDefault();

                    if(objModel!=null)
                    {
                        model.blValue1 = true;
                     
                        string[] strokprole = System.Configuration.ConfigurationManager.AppSettings["UserRoleID"].ToString().Split(',');

                        foreach(string strsingle in strokprole)
                        {
                            if(strsingle.Trim().Length>0 &&  strsingle == objModel.roleid.ToString())
                            {
                                model.blValue1 = false;
                                break;
                            }
                        }
                       
                    }

                    model.UserProfilePhoto = "";// System.Configuration.ConfigurationManager.AppSettings["uploadfolderServices"].ToString() + cor_foldercontentsList[0].filepath + cor_foldercontentsList[0].filename + cor_foldercontentsList[0].extension;
                    Session.Add("UserModel", model);


                    if (Session["comlanguage"] == null)
                    {
                        string xmlData = Server.MapPath("~/LanguagesFiles/_Common.xml");
                        System.Data.DataSet ds = new System.Data.DataSet();//Using dataset to read xml file  
                        ds.ReadXml(xmlData);
                        Session.Add("comlanguage", JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented));
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }

            return View(model);
        }


        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> hrOffIndex()
        {
            string str = string.Empty;
            var model = new owin_userEntity();
            try
            {
                var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                if (claimsIdentity != null)
                {
                    model.masteruserid = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber").FirstOrDefault().Value);
                    model.username = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").FirstOrDefault().Value;
                    model.userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);
                    model.loweredusername = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                    model.UserProfilePhoto = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname").FirstOrDefault().Value;
                    model.emailaddress = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                    model.comment = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode").FirstOrDefault().Value;
                    Session.Add("UserModel", model);


                    if (Session["comlanguage"] == null)
                    {
                        string xmlData = Server.MapPath("~/LanguagesFiles/_Common.xml");
                        System.Data.DataSet ds = new System.Data.DataSet();//Using dataset to read xml file  
                        ds.ReadXml(xmlData);
                        Session.Add("comlanguage", JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented));
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }

            return View(model);
        }

        [HttpPost]
        [ExceptionFilterAttribute]
        public JsonResult HomeLoadMenu()
        {
            try
            {
                var result = new JsonResult
                {
                    Data = Session["json"]
                };
                return result;
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }

        }

        public string LoadTokenValue()
        {
            string str = string.Empty;
            var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
            str = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;
            return str;
        }

        #region UPDATE PROFILE
        //[AuthorizeFilterAttribute]
        //[SecurityFillerAttribute]
        //[ExceptionFilterAttribute]
        //public ActionResult ModalFormActionUpdateProfile(int Id)
        //{
        //    KAF.BusinessDataObjects.owin_userEntity objUserProfileModel = new KAF.BusinessDataObjects.owin_userEntity();
        //    try
        //    {
        //        var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
        //        ViewBag.Id = Id;
        //        ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
        //        objUserProfileModel = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new KAF.BusinessDataObjects.owin_userEntity()
        //        {
        //            userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value)
        //        }).FirstOrDefault();

        //        if (string.IsNullOrEmpty(objUserProfileModel.UserProfilePhoto))
        //            objUserProfileModel.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";


        //        objUserProfileModel.password = "blablabla";
        //        objUserProfileModel.passwordkey = "blablabla";
        //        objUserProfileModel.passwordsalt = "blablabla";
        //        objUserProfileModel.passwordvector = "blablabla";

        //        ViewBag.tempUserProfilePhoto = objUserProfileModel.UserProfilePhoto;
        //        ViewBag.UserProfilePhoto = objUserProfileModel.UserProfilePhoto;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
        //    }
        //    return PartialView("_ProfileView", objUserProfileModel);
        //}

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> ModalFormActionUpdateProfile(owin_userEntity input)
        {
            KAF.BusinessDataObjects.owin_userEntity objUserProfileModel = new KAF.BusinessDataObjects.owin_userEntity();
            try
            {
                ModelState.Clear();

                var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                ViewBag.Id = input.masteruserid;
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();


                objUserProfileModel = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new KAF.BusinessDataObjects.owin_userEntity()
                {
                    userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value)
                }).FirstOrDefault();

                //if (string.IsNullOrEmpty(objUserProfileModel.UserProfilePhoto))
                //    objUserProfileModel.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";


                //START OF NO CHANGE REGION

                var identity = (ClaimsIdentity)User.Identity;
                var strhrbasicid = identity.Claims.Where(c => c.Type == ClaimTypes.OtherPhone)
                    .Select(c => c.Value).SingleOrDefault();
                var struserid = identity.Claims.Where(c => c.Type == ClaimTypes.Gender)
                 .Select(c => c.Value).SingleOrDefault();


                //END OF NO CHANGE REGION
                objUserProfileModel.UserProfilePhoto = "";// System.Configuration.ConfigurationManager.AppSettings["uploadfolderServices"].ToString() + cor_foldercontentsList[0].filepath + cor_foldercontentsList[0].filename + cor_foldercontentsList[0].extension;

                objUserProfileModel.password = "blablabla";
                objUserProfileModel.passwordkey = "blablabla";
                objUserProfileModel.passwordsalt = "blablabla";
                objUserProfileModel.passwordvector = "blablabla";

                ViewBag.tempUserProfilePhoto = objUserProfileModel.UserProfilePhoto;
                ViewBag.UserProfilePhoto = objUserProfileModel.UserProfilePhoto;
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            return PartialView("_ProfileView", objUserProfileModel);
        }

        //[HttpPost]
        //[AuthorizeFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[AllowCrossSiteJsonAttribute]
        //[ActionParameterInjector]
        //[ValidateInput(true)]
        //[SecurityFillerAttribute]
        //[LoggingFilterAttribute]
        //[ExceptionFilterAttribute]
        //[RequestValidationAttribute]
        //public async Task<JsonResult> UploadProfileImage(HttpPostedFileBase attachment,
        //    string token,
        //    string userinfo,
        //    string useripaddress,
        //    string sessionid,
        //    string methodname,
        //    string currenturl,
        //    string existingImageURL)
        //{
        //    if (attachment != null && attachment.ContentLength > 0)
        //    {
        //        try
        //        {
        //            var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
        //            if (claimsIdentity != null)
        //            {
        //                Guid userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);


        //                var dirPath = Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"] + "/" + userid.ToString() + '/');

        //                if (!Directory.Exists(dirPath))
        //                {
        //                    Directory.CreateDirectory(dirPath);
        //                }

        //                string HTMLString = ""; string firstimage = "";

        //                byte[] FileByteArray = new byte[attachment.ContentLength];
        //                attachment.InputStream.Read(FileByteArray, 0, attachment.ContentLength);
        //                EmailAttachment newAttchment = new EmailAttachment();
        //                newAttchment.FileName = attachment.FileName;
        //                newAttchment.FileType = attachment.ContentType;
        //                newAttchment.FileContent = FileByteArray;
        //                newAttchment.ID = 1;
        //                var file = Request.Files;
        //                var fileName = Path.GetFileName(file[0].FileName);
        //                var path = Path.Combine(Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"] + "/" + userid.ToString() + '/'), fileName);
        //                file[0].SaveAs(path);

        //                firstimage = System.Configuration.ConfigurationManager.AppSettings["DomainURL"] + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"] + "/" + userid.ToString() + '/' + fileName;

        //                ViewBag.UserProfilePhoto = firstimage;

        //                return Json(new { title = firstimage, redirectUrl = "", status = KAF.MsgContainer._Status._statusSuccess, responsetext = HTMLString });
        //            }
        //            else
        //                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resbadRequest }, JsonRequestBehavior.AllowGet);
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = KAF.MsgContainer._Responses._resbadRequest }, JsonRequestBehavior.AllowGet);
        //}

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
        public async Task<JsonResult> UploadProfileImage(HttpPostedFileBase attachment,
       string token,
       string userinfo,
       string useripaddress,
       string sessionid,
       string methodname,
       string currenturl,
       string existingImageURL)
        {
            if (attachment != null && attachment.ContentLength > 0)
            {
                try
                {
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {
                        Guid userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);

                        var identity = (ClaimsIdentity)User.Identity;
                        var strhrbasicid = identity.Claims.Where(c => c.Type == ClaimTypes.OtherPhone)
                            .Select(c => c.Value).SingleOrDefault();
                        var struserid = identity.Claims.Where(c => c.Type == ClaimTypes.Gender)
                         .Select(c => c.Value).SingleOrDefault();

                        var dirPath = Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"] + "/" + userid.ToString() + '/');
                        string HTMLString = "";
                        string firstimage = "";

                        //clsFileHandler objFilehandler = new clsFileHandler();
                        //var ret = objFilehandler.ManageFiles(input.cor_foldercontentsList, System.Web.HttpContext.Current.Session);
                        

                        //byte[] binaryData;
                        //binaryData = new Byte[product.BrochureFile.InputStream.Length];
                        //long bytesRead = product.BrochureFile.InputStream.Read(binaryData, 0, (int)product.BrochureFile.InputStream.Length);

                        byte[] FileByteArray = new byte[attachment.ContentLength];
                        attachment.InputStream.Read(FileByteArray, 0, attachment.ContentLength);
                        attachment.InputStream.Close();
                        string base64String = System.Convert.ToBase64String(FileByteArray, 0, FileByteArray.Length);

                        

                        clsFileHandler objFilehandler = new clsFileHandler();
                       

                        firstimage = "";//

                        ViewBag.UserProfilePhoto = firstimage;

                        return Json(new { title = firstimage, redirectUrl = "", status = KAF.MsgContainer._Status._statusSuccess, responsetext = HTMLString });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resbadRequest }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = KAF.MsgContainer._Responses._resbadRequest }, JsonRequestBehavior.AllowGet);
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
            try
            {
                SecurityCapsule sec = new SecurityCapsule();
                string filename = System.IO.Path.GetFileName(input.UserProfilePhoto);
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                var dirPath = Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"] + "/" + sec.userid + '/' + filename);
                if (!dirPath.Contains("NoProfileImage.png"))
                {
                    if (System.IO.File.Exists(dirPath))
                    {
                        System.IO.File.Delete(dirPath);
                    }
                }

                ViewBag.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";

                return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = ViewBag.UserProfilePhoto, responsetext = KAF.MsgContainer._Common._deleteInformation });
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        public async Task<JsonResult> PostModalUpdateProfile(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = urlBuilder.Action("Index", "Login");
            try
            {
                ModelState.Remove("username");
                ModelState.Remove("password");
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");
                ModelState.Remove("passwordkey");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {
                        input.masteruserid = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber").FirstOrDefault().Value);
                        input.username = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").FirstOrDefault().Value;
                        input.userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);
                        input.sessionid = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn").FirstOrDefault().Value;
                        input.token = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;
                        input.BaseSecurityParam = new SecurityCapsule();
                        input.BaseSecurityParam = HttpContext.Items["CurrentSec"] as SecurityCapsule;


                        if (input.UserProfilePhoto != input.ex_nvarchar1)
                        {
                            if (input.ex_nvarchar1 != null) {
                                input.ex_nvarchar1 = "~/" + input.ex_nvarchar1.Remove(0, DomainUrl.GetDomainUrl().Length);
                                var dirPath = Server.MapPath(input.ex_nvarchar1);
                                if (!dirPath.Contains("NoProfileImage.png"))
                                {
                                    if (System.IO.File.Exists(dirPath))
                                    {
                                        System.IO.File.Delete(dirPath);
                                    }
                                }
                            }
                        }

                        long i = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().Owin_UserProfileUpdate(input);

                        if (i >= 0)
                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Common._updateInformation });
                        else
                            throw new Exception(KAF.MsgContainer._Responses._resgeneralErrorInformation);
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleUnAuthorizedUser, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resbadRequest });
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
        #endregion UPDATE PROFILE


        #region CHANGE PASSWORD

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> ModalFormActionChangePassword(owin_userEntity input)
        {
            KAF.BusinessDataObjects.owin_userEntity objUserProfileModel = new KAF.BusinessDataObjects.owin_userEntity();
            try
            {
                ModelState.Clear();

                var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                ViewBag.Id = input.masteruserid;
                ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
                objUserProfileModel = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new KAF.BusinessDataObjects.owin_userEntity()
                {
                    userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value)
                }).FirstOrDefault();

                objUserProfileModel.password = string.Empty;
                objUserProfileModel.passwordsalt = string.Empty;
                objUserProfileModel.passwordvector = string.Empty;

            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return PartialView("_ChangePassword", objUserProfileModel);
        }

        //[AuthorizeFilterAttribute]
        //[SecurityFillerAttribute]
        //[ExceptionFilterAttribute]
        //public ActionResult ModalFormActionChangePassword(int Id)
        //{
        //    KAF.BusinessDataObjects.owin_userEntity objUserProfileModel = new KAF.BusinessDataObjects.owin_userEntity();
        //    try
        //    {
        //        var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
        //        ViewBag.Id = Id;
        //        ViewBag.SecQuestns = clsDataCache.GetSecurityQuestions();
        //        objUserProfileModel = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new KAF.BusinessDataObjects.owin_userEntity()
        //        {
        //            userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value)
        //        }).FirstOrDefault();

        //        objUserProfileModel.password = string.Empty;
        //        objUserProfileModel.passwordsalt = string.Empty;
        //        objUserProfileModel.passwordvector = string.Empty;

        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
        //    }
        //    return PartialView("_ChangePassword", objUserProfileModel);
        //}

        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> PostModalChangePassword(KAF.BusinessDataObjects.owin_userEntity input)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = urlBuilder.Action("Index", "Login");
            try
            {
                ModelState.Remove("username");
                ModelState.Remove("password");
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {
                        input.masteruserid = long.Parse(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber").FirstOrDefault().Value);
                        input.username = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").FirstOrDefault().Value;
                        input.userid = new Guid(claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);
                        input.sessionid = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn").FirstOrDefault().Value;
                        input.token = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").FirstOrDefault().Value;
                        input.BaseSecurityParam = new SecurityCapsule();
                        input.BaseSecurityParam = HttpContext.Items["CurrentSec"] as SecurityCapsule;

                        long i = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().Owin_UserPasswordChange(input);

                        if (i >= 0)
                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = url, responsetext = KAF.MsgContainer._Common._updateInformation });
                        else
                            throw new Exception(KAF.MsgContainer._Responses._resgeneralErrorInformation);
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Responses._resbadRequest });
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

        #endregion CHANGE PASSWORD



        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> CallLanguageShifterRoot(owin_userEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                ModelState.Remove("applicationid");
                ModelState.Remove("isanonymous");
                ModelState.Remove("masteruserid");
                ModelState.Remove("masprivatekey");
                ModelState.Remove("maspublickey");
                if (this.ModelState.IsValid)
                {
                    string culture = input.password;
                    // Validate input
                    culture = CultureHelper.GetImplementedCulture(culture);

                    RouteData.Values["culture"] = culture;

                    // Save culture in a cookie
                    HttpCookie cookie = Request.Cookies["_culture"];
                    if (cookie != null)
                        cookie.Value = culture;   // update cookie value
                    else
                    {
                        cookie = new HttpCookie("_culture");
                        cookie.Value = culture;
                        cookie.Expires = DateTime.Now.AddYears(1);
                    }
                    Response.Cookies.Add(cookie);

                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responseText = "Data" });
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
                return Json(new
                {
                    status = KAF.MsgContainer._Status._statusFailed,
                    title = KAF.MsgContainer._Status._titleGenericError,
                    redirectUrl = "",
                    responsetext = ex.Message
                });
            }
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
        public async Task<ActionResult> CallLanguageCommon(owin_userEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordkey");
                ModelState.Remove("passwordvector");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");

                if (this.ModelState.IsValid)
                {
                    string xmlData = Server.MapPath("~/LanguagesFiles/_Common.xml");
                    System.Data.DataSet ds = new System.Data.DataSet();//Using dataset to read xml file  
                    ds.ReadXml(xmlData);
                    string json = JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented);
                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responseText = json });
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
                return Json(new
                {
                    status = KAF.MsgContainer._Status._statusFailed,
                    title = KAF.MsgContainer._Status._titleGenericError,
                    redirectUrl = "",
                    responsetext = ex.Message
                });
            }
        }





        [ExceptionFilterAttribute]
        public async Task<ActionResult> ReloadCache()
        {

            try
            {
                clsDataCache.LoadDataCache();
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = KAF.MsgContainer._Status._statusFailed,
                    title = KAF.MsgContainer._Status._titleGenericError,
                    redirectUrl = "",
                    responsetext = ex.Message
                });
            }

            return Redirect(Request.UrlReferrer.ToString());
        }

        public async Task<ActionResult> Error()//(int statusCode, Exception exception)
        {
            try
            {
                Response.StatusCode = 500;
                ViewBag.StatusCode = 500 + " Error";
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        public ActionResult GetClientIPAddress()
        {
            try
            {
                var ip = GetClientIpAddress();
                return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", data = ip, JsonRequestBehavior.AllowGet });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = KAF.MsgContainer._Status._statusFailed,
                    title = KAF.MsgContainer._Status._titleGenericError,
                    redirectUrl = "",
                    responsetext = ex.Message
                });
            }
        }
        protected virtual string GetClientIpAddress()
        {
            var httpContext = System.Web.HttpContext.Current;
            if (httpContext?.Request.ServerVariables == null)
            {
                return null;
            }

            var clientIp = httpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ??
            httpContext.Request.ServerVariables["REMOTE_ADDR"];

            try
            {
                foreach (var hostAddress in Dns.GetHostAddresses(clientIp))
                {
                    if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return hostAddress!=null ? hostAddress.ToString(): System.Configuration.ConfigurationManager.AppSettings["Domain"].ToString();
                    }
                }

                foreach (var hostAddress in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return hostAddress != null ? hostAddress.ToString() : System.Configuration.ConfigurationManager.AppSettings["Domain"].ToString();
                       
                    }
                }
            }
            catch (Exception ex)
            {
                return System.Configuration.ConfigurationManager.AppSettings["Domain"].ToString();
            }

            return clientIp.Length>0?clientIp: System.Configuration.ConfigurationManager.AppSettings["Domain"].ToString();
        }
        protected virtual string GetComputerName()
        {
            var httpContext = System.Web.HttpContext.Current;
            if (httpContext == null || !httpContext.Request.IsLocal)
            {
                return null;
            }

            try
            {
                var clientIp = httpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ??
                httpContext.Request.ServerVariables["REMOTE_ADDR"];
                return Dns.GetHostEntry(IPAddress.Parse(clientIp)).HostName;
            }
            catch
            {
                return null;
            }
        }






    }
}

