
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
using System.Drawing.Imaging;

namespace KAFWebAdmin.Controllers.HR
{
    public class HrSvcInfoController : BaseController
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
        public async Task<ActionResult> HrSvcInfo()
        {

            // Retrieve the user's claims
            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {
                // Get specific claim types
                var role = claimsIdentity.FindFirst(p => p.Type == "http://http://localhost:2005//CuttingEdge.Security.Role").Value;
                var militaryid = claimsIdentity.FindFirst(p => p.Type == "militaryid").Value;
                ViewBag.Role = role;
                ViewBag.militaryid = militaryid;
            }

            return View("HrSvcInfoLanding");
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
        public async Task<ActionResult> HrSvcInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_svcinfoEntity input)
        {
            hr_svcinfoEntity objowin_hr_svcinfo = new hr_svcinfoEntity();
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


                List<hr_svcinfoEntity> data = this.GetAllHrSvcInfoData(input);

                if (data != null && data.Count > 0)
                {
                    #region Check if Military person exists

                    if (sec.okpid != null && sec.okpid != data.FirstOrDefault().okpid)
                    {
                        throw new Exception("Warning! Unauthorized searching.");
                    }
                    else
                    {
                        long totalRecords = data.FirstOrDefault().RETURN_KEY;

                        var tut = (from t in data
                                   select new
                                   {
                                       t.militarynokw,
                                       t.fullname,
                                       t.hrsvcid,
                                       t.hrbasicid,
                                       t.passportno,
                                       t.joindatekw,
                                       t.expectedretiredatekw,
                                       t.userid,
                                       t.entitykey,
                                       t.armsid,
                                       t.okpid,
                                       t.rankidkw,
                                       t.rankidbd,
                                       t.tradeidbd,
                                       t.tradeidkw,
                                       t.groupid,
                                       t.status,
                                       statusStr = KAF.ConstantTypes.clsSystemConstantTypes.GetStats(t.status),

                                       t.remarks,

                                       ex_nvarchar1 = (t.status == 3 || t.status == 5) ?
                                       (genButtonPanel(t.hrsvcid.GetValueOrDefault(-99), "hrsvcid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "HrSvcInfo/HrSvcInfoEdit", "HrSvcInfoEdit",
                                       "", "",
                                       "HrSvcInfo/HrSvcInfoDetail", "HrSvcInfoDetail"))
                                       :
                                       (genButtonPanel(t.hrsvcid.GetValueOrDefault(-99), "hrsvcid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "", "",
                                       "", "",
                                       "HrSvcInfo/HrSvcInfoDetail", "HrSvcInfoDetail"))
                                   }).ToList();

                        result = this.Json(new { draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
                    }
                    #endregion
                }
                else
                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message, data = "" });
            }
            return result;
        }
        public string genButtonPanel(long menuId, string menuName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
           string actionNameDelete, string deleteMethodName, string actionNameView, string viewMethodName, string actionNameDownload = "", Int64? letterstatus = -99)
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            string strValue = string.Empty;
            string strJson = string.Empty;
            try
            {

                if (claimsIdentity != null)
                {
                    List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(Session["jsonList"].ToString());
                    if (itemList != null && itemList.Count > 0)
                    {
                        strValue += "<div class='btn-toolbar pull-right' role='toolbar'>";
                        if (!String.IsNullOrEmpty(actionNameEdit))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameEdit)))
                            {
                                if (actionNameEdit == "GenOSInfo/GenOSInfoUpdate")
                                {
                                    strValue += "<button  data-target='#EditOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + editMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button>";
                                }

                                else
                                {
                                    strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";

                                    strValue += "<button class='btn btn-primary btn-md' onclick ='updatecampsubunit(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> Update Camp/SubUnit</button> ";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDelete))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameDelete)))
                            {
                                strValue += "<button class='btn btn-danger btn-md' onclick='" + deleteMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-trash'></i> " + KAF.MsgContainer._Common._btnDelete + "</button>  ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameView))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {
                                if (actionNameView == "GenOSInfo/GenOSInfoDetails")
                                {
                                    strValue += "<button  data-target='#DisplayOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + viewMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                                else
                                {
                                    strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDownload))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {

                                strValue += "<button class='btn btn-info btn-md' onclick='DownloadData(&quot;" + menuId.ToString() + "&quot;,&quot;" + letterstatus.ToString() + "&quot;)'><i class='fa fa-info-circle'></i>Download Report</button>";

                            }
                        }
                        strValue += "</div>";
                    }
                }
                else
                    throw new Exception("Login required");
            }
            catch (Exception ex)
            {
                strValue = ex.Message;
            }
            return strValue;
        }


        List<hr_svcinfoEntity> GetAllHrSvcInfoData(hr_svcinfoEntity objhr_svcinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_svcinfoEntity> listobjhr_svcinfoEntity = new List<hr_svcinfoEntity>();
            try
            {
                listobjhr_svcinfoEntity = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext((objhr_svcinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_svcinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "hrsvcid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "passportno" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "joindatekw" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "expectedretiredatekw" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "userid" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "entitykey" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "armsid" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "okpid" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "rankidkw" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "rankidbd" + " " + orderDir;
                        break;
                    case "11":
                        sortingVal = "tradeidbd" + " " + orderDir;
                        break;
                    case "12":
                        sortingVal = "tradeidkw" + " " + orderDir;
                        break;
                    case "13":
                        sortingVal = "groupid" + " " + orderDir;
                        break;
                    case "14":
                        sortingVal = "status" + " " + orderDir;
                        break;
                    case "15":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "hrsvcid" + " " + orderDir;
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



        #region Create HrSvcInfo

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
        public async Task<ActionResult> HrSvcInfoNew(hr_svcinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_svcinfoEntity model = new hr_svcinfoEntity();
                model.status = 5;
                //ViewBag.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";

                return PartialView("_HrSvcInfoNew", model);
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
        public async Task<ActionResult> HrSvcInfoInsert(hr_svcinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                string filepath = string.Empty;
                string sourcepath = string.Empty;
                string fileExtension = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("hrbasicid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                /*				 ModelState.Remove("hrsvcid");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("passportno");
                                 ModelState.Remove("joindatekw");
                                 ModelState.Remove("expectedretiredatekw");
                                 ModelState.Remove("userid");
                                 ModelState.Remove("entitykey");
                                 ModelState.Remove("armsid");
                                 ModelState.Remove("okpid");
                                 ModelState.Remove("rankidkw");
                                 ModelState.Remove("rankidbd");
                                 ModelState.Remove("tradeidbd");
                                 ModelState.Remove("tradeidkw");
                                 ModelState.Remove("groupid");
                                 ModelState.Remove("status");
                                 ModelState.Remove("remarks");
                */
                ModelState.Remove("fullname");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    try
                    {
                        if (input.profilephotofilepath != null)
                        {
                            string[] strImage = input.profilephotofilepath.Split('/');
                            string fileName = strImage[3].ToString();
                            fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                            sourcepath = input.profilephotofilepath;
                            filepath = Path.Combine(Path.GetDirectoryName(input.profilephotofilepath), input.militarynokw.ToString() + fileExtension);
                            input.profilephotofilename = input.militarynokw.ToString();
                            input.profilephotofileextension = fileExtension;
                            input.profilephotofiletype = strImage[3].ToString().Split('.')[1].ToString();
                            input.profilephotofilepath = filepath;
                        }

                    }
                    catch { }

                    ret = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().Add_Ext(input);

                    if (ret > 0)
                    {

                        try
                        {
                            if (System.IO.File.Exists(Server.MapPath(sourcepath))) System.IO.File.Move(Server.MapPath(sourcepath), Server.MapPath(filepath));
                        }
                        catch { }

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


        #region update HrSvcInfo

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
        public async Task<ActionResult> HrSvcInfoEdit(hr_svcinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrsvcid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrsvcid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(new hr_svcinfoEntity { hrsvcid = input.hrsvcid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN

                if (model.profilephotofilename != null)
                {
                    string domainURL = DomainUrl.GetDomainUrl();
                    string profileImagesFolder = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString();

                    string filepath = Path.Combine(domainURL, profileImagesFolder, model.profilephotofilename + model.profilephotofileextension);
                    ViewBag.UserProfilePhoto = filepath;
                }
                if (model.subunitid != null)
                {
                    var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.subunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_SubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.campid != null)
                {
                    var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());
                    var objgen_camp = campCache.Where(x => x.comId == model.campid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_Camp = JsonConvert.SerializeObject(objgen_camp);
                }
                if (model.organizationkey != null)
                {
                    List<stp_organizationEntity> liststp_organization = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GetAll(new stp_organizationEntity { organizationkey = model.organizationkey }).ToList();
                    var objstp_organization = (from t in liststp_organization
                                               select new
                                               {
                                                   comId = t.organizationkey,
                                                   comText = t.organizationname
                                               }).ToList();
                    ViewBag.preloadedStp_Organization = JsonConvert.SerializeObject(objstp_organization);
                }
                if (model.entitykey != null)
                {
                    List<stp_organizationentityEntity> liststp_organizationentity = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = model.entitykey }).ToList();
                    var objstp_organizationentity = (from t in liststp_organizationentity
                                                     select new
                                                     {
                                                         Id = t.entitykey,
                                                         Text = t.entityname
                                                     }).ToList();
                    ViewBag.preloadedStp_OrganizationEntity = JsonConvert.SerializeObject(objstp_organizationentity);
                }
                if (model.armsid != null)
                {
                    List<gen_armsEntity> listgen_arms = KAF.FacadeCreatorObjects.gen_armsFCC.GetFacadeCreate().GetAll(new gen_armsEntity { armsid = model.armsid }).ToList();
                    var objgen_arms = (from t in listgen_arms
                                       select new
                                       {
                                           comId = t.armsid,
                                           comText = t.armsname
                                       }).ToList();
                    ViewBag.preloadedGen_Arms = JsonConvert.SerializeObject(objgen_arms);
                }
                if (model.rankidkw != null)
                {
                    List<gen_rankEntity> listgen_rankKW = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankidkw }).ToList();
                    var objgen_rankKW = (from t in listgen_rankKW
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankKW = JsonConvert.SerializeObject(objgen_rankKW);
                }
                if (model.rankidbd != null)
                {
                    List<gen_rankEntity> listgen_rankBD = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankidbd }).ToList();
                    var objgen_rankBD = (from t in listgen_rankBD
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankBD = JsonConvert.SerializeObject(objgen_rankBD);
                }
                if (model.tradeidbd != null)
                {
                    List<gen_tradeEntity> listgen_tradeBD = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = model.tradeidbd }).ToList();
                    var objgen_tradeBD = (from t in listgen_tradeBD
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeBD = JsonConvert.SerializeObject(objgen_tradeBD);
                }

                if (model.tradeidkw != null)
                {
                    List<gen_tradeEntity> listgen_tradeKW = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = model.tradeidkw }).ToList();
                    var objgen_tradeKW = (from t in listgen_tradeKW
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeKW = JsonConvert.SerializeObject(objgen_tradeKW);
                }
                if (model.okpid != null)
                {
                    var Cachegen_okp = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                    if (model.okpid != null)
                    {
                        var objgen_okp = Cachegen_okp.Where(p => p.comId == model.okpid).Select(x => new { x.comId, x.comText }).ToList();
                        ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                    }
                }


                ModelState.Clear();
                return PartialView("_HrSvcInfoEdit", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        [HttpPost]

        [SecurityFillerAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [LoggingFilterAttribute]

        [ExceptionFilterAttribute]
        public async Task<ActionResult> HrSvcInfoEdit_Temp(hr_svcinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrsvcid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrsvcid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(new hr_svcinfoEntity { hrsvcid = input.hrsvcid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN

                if (model.profilephotofilename != null)
                {
                    string domainURL = DomainUrl.GetDomainUrl();
                    string profileImagesFolder = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString();

                    string filepath = Path.Combine(domainURL, profileImagesFolder, model.profilephotofilename + model.profilephotofileextension);
                    ViewBag.UserProfilePhoto = filepath;
                }
                if (model.subunitid != null)
                {
                    var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.subunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_SubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.campid != null)
                {
                    var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());
                    var objgen_camp = campCache.Where(x => x.comId == model.campid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_Camp = JsonConvert.SerializeObject(objgen_camp);
                }
                if (model.organizationkey != null)
                {
                    List<stp_organizationEntity> liststp_organization = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GetAll(new stp_organizationEntity { organizationkey = model.organizationkey }).ToList();
                    var objstp_organization = (from t in liststp_organization
                                               select new
                                               {
                                                   comId = t.organizationkey,
                                                   comText = t.organizationname
                                               }).ToList();
                    ViewBag.preloadedStp_Organization = JsonConvert.SerializeObject(objstp_organization);
                }
                if (model.entitykey != null)
                {
                    List<stp_organizationentityEntity> liststp_organizationentity = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = model.entitykey }).ToList();
                    var objstp_organizationentity = (from t in liststp_organizationentity
                                                     select new
                                                     {
                                                         Id = t.entitykey,
                                                         Text = t.entityname
                                                     }).ToList();
                    ViewBag.preloadedStp_OrganizationEntity = JsonConvert.SerializeObject(objstp_organizationentity);
                }
                if (model.armsid != null)
                {
                    List<gen_armsEntity> listgen_arms = KAF.FacadeCreatorObjects.gen_armsFCC.GetFacadeCreate().GetAll(new gen_armsEntity { armsid = model.armsid }).ToList();
                    var objgen_arms = (from t in listgen_arms
                                       select new
                                       {
                                           comId = t.armsid,
                                           comText = t.armsname
                                       }).ToList();
                    ViewBag.preloadedGen_Arms = JsonConvert.SerializeObject(objgen_arms);
                }
                if (model.rankidkw != null)
                {
                    List<gen_rankEntity> listgen_rankKW = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankidkw }).ToList();
                    var objgen_rankKW = (from t in listgen_rankKW
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankKW = JsonConvert.SerializeObject(objgen_rankKW);
                }
                if (model.rankidbd != null)
                {
                    List<gen_rankEntity> listgen_rankBD = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankidbd }).ToList();
                    var objgen_rankBD = (from t in listgen_rankBD
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankBD = JsonConvert.SerializeObject(objgen_rankBD);
                }
                if (model.tradeidbd != null)
                {
                    List<gen_tradeEntity> listgen_tradeBD = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = model.tradeidbd }).ToList();
                    var objgen_tradeBD = (from t in listgen_tradeBD
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeBD = JsonConvert.SerializeObject(objgen_tradeBD);
                }

                if (model.tradeidkw != null)
                {
                    List<gen_tradeEntity> listgen_tradeKW = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = model.tradeidkw }).ToList();
                    var objgen_tradeKW = (from t in listgen_tradeKW
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeKW = JsonConvert.SerializeObject(objgen_tradeKW);
                }
                if (model.okpid != null)
                {
                    var Cachegen_okp = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                    if (model.okpid != null)
                    {
                        var objgen_okp = Cachegen_okp.Where(p => p.comId == model.okpid).Select(x => new { x.comId, x.comText }).ToList();
                        ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                    }
                }


                ModelState.Clear();
                return PartialView("_HrSvcInfoEdit_Temp", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        [HttpPost]

        [SecurityFillerAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [LoggingFilterAttribute]

        [ExceptionFilterAttribute]
        public async Task<ActionResult> HrSvcInfoUpdateTemp(hr_svcinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                string filepath = string.Empty;
                string sourcepath = string.Empty;
                string fileExtension = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;


                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.BaseSecurityParam = sec;

                var model = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { hrbasicid=input.hrbasicid }).FirstOrDefault();

                model.subunitid = input.subunitid;
                model.campid = input.campid;
                model.BaseSecurityParam = sec;

                ret = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().Update(model);

                if (ret > 0)
                {
                    try
                    {
                        if (System.IO.File.Exists(Server.MapPath(sourcepath))) System.IO.File.Move(Server.MapPath(sourcepath), Server.MapPath(filepath));
                    }
                    catch { }

                    ModelState.Clear();
                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._saveInformation });
                }
                else
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });

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
        public async Task<ActionResult> HrSvcInfoUpdate(hr_svcinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                string filepath = string.Empty;
                string sourcepath = string.Empty;
                string fileExtension = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("hrsvcid");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("passportno");
                                 ModelState.Remove("joindatekw");
                                 ModelState.Remove("expectedretiredatekw");
                                 ModelState.Remove("userid");
                                 ModelState.Remove("entitykey");
                                 ModelState.Remove("armsid");
                                 ModelState.Remove("okpid");
                                 ModelState.Remove("rankidkw");
                                 ModelState.Remove("rankidbd");
                                 ModelState.Remove("tradeidbd");
                                 ModelState.Remove("tradeidkw");
                                 ModelState.Remove("groupid");
                                 ModelState.Remove("status");
                                 ModelState.Remove("remarks");
                */
                ModelState.Remove("hrbasicid");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    try
                    {
                        if (input.profilephotofilepath != null)
                        {
                            string[] strImage = input.profilephotofilepath.Split('/');
                            string fileName = strImage[3].ToString();
                            fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                            sourcepath = input.profilephotofilepath;
                            filepath = Path.Combine(Path.GetDirectoryName(input.profilephotofilepath), input.militarynokw.ToString() + fileExtension);
                            input.profilephotofilename = input.militarynokw.ToString();
                            input.profilephotofileextension = fileExtension;
                            input.profilephotofiletype = strImage[3].ToString().Split('.')[1].ToString();
                            input.profilephotofilepath = filepath;
                        }

                    }
                    catch { }

                    ret = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().Update_Ext(input);

                    if (ret > 0)
                    {
                        try
                        {
                            if (System.IO.File.Exists(Server.MapPath(sourcepath))) System.IO.File.Move(Server.MapPath(sourcepath), Server.MapPath(filepath));
                        }
                        catch { }

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

        #region delete HrSvcInfo

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
        public async Task<ActionResult> HrSvcInfoDelete(hr_svcinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("hrsvcid"); */
                ModelState.Remove("hrbasicid");
                ModelState.Remove("passportno");
                ModelState.Remove("joindatekw");
                ModelState.Remove("expectedretiredatekw");
                ModelState.Remove("userid");
                ModelState.Remove("entitykey");
                ModelState.Remove("armsid");
                ModelState.Remove("okpid");
                ModelState.Remove("rankidkw");
                ModelState.Remove("rankidbd");
                ModelState.Remove("tradeidbd");
                ModelState.Remove("tradeidkw");
                ModelState.Remove("groupid");
                ModelState.Remove("status");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.hrsvcid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrsvcid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrSvcInfo

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
        public async Task<ActionResult> HrSvcInfoDetail(hr_svcinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrsvcid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrsvcid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(new hr_svcinfoEntity { hrsvcid = input.hrsvcid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;

                if (model.profilephotofilename != null)
                {
                    string domainURL = DomainUrl.GetDomainUrl();
                    string profileImagesFolder = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString();

                    string filepath = Path.Combine(domainURL, profileImagesFolder, model.profilephotofilename + model.profilephotofileextension);
                    ViewBag.UserProfilePhoto = filepath;
                }
                if (model.subunitid != null)
                {
                    var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.subunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_SubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.campid != null)
                {
                    var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());
                    var objgen_camp = campCache.Where(x => x.comId == model.campid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_Camp = JsonConvert.SerializeObject(objgen_camp);
                }
                if (model.organizationkey != null)
                {
                    List<stp_organizationEntity> liststp_organization = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GetAll(new stp_organizationEntity { organizationkey = model.organizationkey }).ToList();
                    var objstp_organization = (from t in liststp_organization
                                               select new
                                               {
                                                   comId = t.organizationkey,
                                                   comText = t.organizationname
                                               }).ToList();
                    ViewBag.preloadedStp_Organization = JsonConvert.SerializeObject(objstp_organization);
                }
                if (model.entitykey != null)
                {
                    List<stp_organizationentityEntity> liststp_organizationentity = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = model.entitykey }).ToList();
                    var objstp_organizationentity = (from t in liststp_organizationentity
                                                     select new
                                                     {
                                                         Id = t.entitykey,
                                                         Text = t.entityname
                                                     }).ToList();
                    ViewBag.preloadedStp_OrganizationEntity = JsonConvert.SerializeObject(objstp_organizationentity);
                }
                if (model.armsid != null)
                {
                    List<gen_armsEntity> listgen_arms = KAF.FacadeCreatorObjects.gen_armsFCC.GetFacadeCreate().GetAll(new gen_armsEntity { armsid = model.armsid }).ToList();
                    var objgen_arms = (from t in listgen_arms
                                       select new
                                       {
                                           comId = t.armsid,
                                           comText = t.armsname
                                       }).ToList();
                    ViewBag.preloadedGen_Arms = JsonConvert.SerializeObject(objgen_arms);
                }
                if (model.rankidkw != null)
                {
                    List<gen_rankEntity> listgen_rankKW = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankidkw }).ToList();
                    var objgen_rankKW = (from t in listgen_rankKW
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankKW = JsonConvert.SerializeObject(objgen_rankKW);
                }
                if (model.rankidbd != null)
                {
                    List<gen_rankEntity> listgen_rankBD = KAF.FacadeCreatorObjects.gen_rankFCC.GetFacadeCreate().GetAll(new gen_rankEntity { rankid = model.rankidbd }).ToList();
                    var objgen_rankBD = (from t in listgen_rankBD
                                         select new
                                         {
                                             Id = t.rankid,
                                             Text = t.rankname
                                         }).ToList();
                    ViewBag.preloadedGen_RankBD = JsonConvert.SerializeObject(objgen_rankBD);
                }
                if (model.tradeidbd != null)
                {
                    List<gen_tradeEntity> listgen_tradeBD = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = model.tradeidbd }).ToList();
                    var objgen_tradeBD = (from t in listgen_tradeBD
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeBD = JsonConvert.SerializeObject(objgen_tradeBD);
                }

                if (model.tradeidkw != null)
                {
                    List<gen_tradeEntity> listgen_tradeKW = KAF.FacadeCreatorObjects.gen_tradeFCC.GetFacadeCreate().GetAll(new gen_tradeEntity { tradeid = model.tradeidkw }).ToList();
                    var objgen_tradeKW = (from t in listgen_tradeKW
                                          select new
                                          {
                                              Id = t.tradeid,
                                              Text = t.tradename
                                          }).ToList();
                    ViewBag.preloadedGen_TradeKW = JsonConvert.SerializeObject(objgen_tradeKW);
                }
                if (model.okpid != null)
                {
                    var Cachegen_okp = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                    if (model.okpid != null)
                    {
                        var objgen_okp = Cachegen_okp.Where(p => p.comId == model.okpid).Select(x => new { x.comId, x.comText }).ToList();
                        ViewBag.preloadedGen_Okp = JsonConvert.SerializeObject(objgen_okp);
                    }
                }



                ModelState.Clear();
                return PartialView("_HrSvcInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion


        #region FILE HANDLING
        [HttpPost]
        //[AuthorizeFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[AllowCrossSiteJsonAttribute]
        //[ActionParameterInjector]
        //[ValidateInput(true)]
        //[SecurityFillerAttribute]
        //[LoggingFilterAttribute]
        //[ExceptionFilterAttribute]
        //[RequestValidationAttribute]
        public async Task<JsonResult> UploadAttachment(HttpPostedFileBase attachment,
            string token,
            string userinfo,
            string useripaddress,
            string sessionid,
            string methodname,
            string currenturl,
            string imagesrc)
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
                        string fileName = file.FileName;
                        string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                        string FileNamePrefix = obj.GetRandomAlphaNumericStringForTransactionActivity("UPLD", DateTime.Now);
                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString();
                        string rootfileUploadDir = Server.MapPath(fileUploadDir);
                        string imageURL = Path.Combine(rootfileUploadDir, FileNamePrefix + fileExtension);

                        objFTP.UploadPhoto(file, imageURL);

                        string domainURL = DomainUrl.GetDomainUrl();
                        string uploadedURL = Path.Combine(domainURL, fileUploadDir, FileNamePrefix + fileExtension);

                        try
                        {
                            if (System.IO.File.Exists(Path.Combine(domainURL, Server.MapPath(imagesrc))))
                            {
                                System.IO.File.Delete(Path.Combine(domainURL, Server.MapPath(imagesrc)));
                            }
                        }
                        catch { }

                        //firstimage = Path.Combine(uploadedURL); ;

                        //ViewBag.UserProfilePhoto = uploadedURL;

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = uploadedURL, redirectUrl = "", responsetext = HTMLString });
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



