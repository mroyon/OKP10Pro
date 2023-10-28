
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
using System.Web.Script.Serialization;
using KAF.ConstantTypes;

namespace KAFWebAdmin.Controllers.HR
{
    public class HrLeaveModificationController : BaseController
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
        public async Task<ActionResult> HrLeaveModification()
        {
            return View("HrLeaveModificationLanding");
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
        public async Task<ActionResult> HrLeaveModificationTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_leaveinfoEntity input)
        {
            hr_leaveinfoEntity objowin_hr_leaveinfo_history = new hr_leaveinfoEntity();
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

                List<hr_leaveinfoEntity> data = this.GetAllHrLeaveModificationData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {

                                   t.leaveinfoid,
                                   t.hrbasicid,
                                   t.leavetypeid,
                                   t.startdate,
                                   t.enddate,
                                   t.noofdays,
                                   t.leavestartdate,
                                   t.leaveenddate,
                                   t.leavedays,
                                   t.letterno,
                                   t.letterdate,
                                   t.withgovtticket,
                                   t.iscancel,
                                   t.ismodified,
                                   t.isreturn,
                                   t.returndate,
                                   t.returnletterno,
                                   t.returnletterdate,
                                   t.remarks,
                                   strcancel = t.iscancel == true ? "Yes" : "No",
                                   strmodified = t.iscancel == true ? "Yes" : "No",
                                   strreturn = t.isreturn == true ? "Yes" : "No",
                                   leavetype = t.ex_nvarchar1,
                                   modifiedleavedays=t.ex_bigint2,
                                   ex_nvarchar1 = genButtonPanel(t.leaveinfoid.GetValueOrDefault(-99), "leaveinfoid", t.ex_bigint1.GetValueOrDefault(-99), "leavemodificationid", this.HttpContext.User.Identity as ClaimsIdentity,
                                    t.ex_bigint1.GetValueOrDefault(-99) == -99 && t.iscancel != true && t.isreturn != true && t.leaveinfoid == data.Select(x => x.leaveinfoid).Max() ? "HrLeaveModification/HrLeaveModificationNew" : "", "HrLeaveModificationNew",
                                    t.ex_bigint1.GetValueOrDefault(-99) != -99 && t.iscancel != true && t.isreturn != true && t.leaveinfoid == data.Select(x => x.leaveinfoid).Max() ? "HrLeaveModification/HrLeaveModificationEdit" : "", "HrLeaveModificationEdit",
                                   "HrLeaveModification/HrLeaveModificationDetail", "HrLeaveModificationDetail")
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

        public string genButtonPanel(long menuId, string menuName, long modifId, string modfiName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
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

                                strValue += "<button  class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> Add </button> ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDelete))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameDelete)))
                            {
                                strValue += "<button class='btn btn-danger btn-md' onclick='" + deleteMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(modfiName, modifId.ToString()) + "&quot;)'><i class='fa fa-trash'></i> Update</button>  ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameView))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {
                                if (modifId.ToString() != "-99")
                                {
                                    strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(modfiName, modifId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
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
                    else if (data.FirstOrDefault().status != 3)
                    {
                        return Json(new { data = data, status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Person is not Active." });
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
        [HttpPost]
        //[AuthorizeFilterAttribute]
        [ValidateInput(true)]
        // [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GetLeaveBalance(KAF_GetLeaveBalanceEntity input)
        {
            hr_leaveinfoEntity objowin_hr_leaveinfo_history = new hr_leaveinfoEntity();
            JsonResult result = new JsonResult();
            try
            {

                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                var data = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().
                    GET_KAF_GetLeaveBalance(input).ToList();

                if (data != null && data.Count > 0)
                {

                    result = this.Json(new { data = data }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }
        List<hr_leaveinfoEntity> GetAllHrLeaveModificationData(hr_leaveinfoEntity objhr_leaveinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_leaveinfoEntity> listobjhr_leaveinfoEntity = new List<hr_leaveinfoEntity>();
            try
            {
                objhr_leaveinfoEntity.isExt = 1;
                listobjhr_leaveinfoEntity = KAF.FacadeCreatorObjects.hr_leaveinfoFCC.GetFacadeCreate().GAPgListView((objhr_leaveinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_leaveinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "leaveinfoid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "leaveinfoid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "leavetypeid" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "startdate" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "enddate" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "noofdays" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "leavestartdate" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "leaveenddate" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "leavedays" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "letterno" + " " + orderDir;
                        break;
                    case "11":
                        sortingVal = "letterdate" + " " + orderDir;
                        break;
                    case "12":
                        sortingVal = "withgovtticket" + " " + orderDir;
                        break;
                    case "13":
                        sortingVal = "iscancel" + " " + orderDir;
                        break;
                    case "14":
                        sortingVal = "ismodified" + " " + orderDir;
                        break;
                    case "15":
                        sortingVal = "isreturn" + " " + orderDir;
                        break;
                    case "16":
                        sortingVal = "returndate" + " " + orderDir;
                        break;
                    case "17":
                        sortingVal = "returnletterno" + " " + orderDir;
                        break;
                    case "18":
                        sortingVal = "returnletterdate" + " " + orderDir;
                        break;
                    case "19":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "leaveinfoid" + " " + orderDir;
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

        #region Create HrLeaveModification

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
        public async Task<ActionResult> HrLeaveModificationNew(hr_leaveinfoEntity input)
        {
            try
            {
                SecurityCapsule sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.leaveinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("leaveinfoid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_leaveinfoFCC.GetFacadeCreate().GetAll(new hr_leaveinfoEntity { leaveinfoid = input.leaveinfoid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
                var list_leavetype = KAF.FacadeCreatorObjects.gen_leavetypeFCC.GetFacadeCreate().GetAll(new gen_leavetypeEntity { leavetypeid = model.leavetypeid }).ToList();
                var objleavetype = (from t in list_leavetype
                                    select new
                                    {
                                        Id = t.leavetypeid,
                                        Text = t.leavetype
                                    }).ToList();
                ViewBag.preloaded_leavetype = JsonConvert.SerializeObject(objleavetype);

                ModelState.Clear();
                return PartialView("_HrLeaveModificationNew", model);
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
        public async Task<ActionResult> HrLeaveModificationInsert(hr_leaveinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST

                ModelState.Remove("hrbasicid");
                ModelState.Remove("leavetypeid");
                ModelState.Remove("startdate");
                ModelState.Remove("enddate");
                ModelState.Remove("noofdays");
                ModelState.Remove("leavestartdate");
                ModelState.Remove("leaveenddate");
                ModelState.Remove("leavedays");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("withgovtticket");
                ModelState.Remove("iscancel");
                ModelState.Remove("ismodified");
                ModelState.Remove("isreturn");
                ModelState.Remove("returndate");
                ModelState.Remove("returnletterno");
                ModelState.Remove("returnletterdate");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                    JavaScriptSerializer JsonConvert = new JavaScriptSerializer();
                    string serializeString = JsonConvert.Serialize(input);
                    hr_leavemodificationEntity objLeaveCancell = JsonConvert.Deserialize<hr_leavemodificationEntity>(serializeString);

                    objLeaveCancell.modificationdate = DateTime.Now;
                    objLeaveCancell.modificationtype = input.modificationtype;
                    objLeaveCancell.BaseSecurityParam = sec;
                    objLeaveCancell.isExt = 1;
                    ret = KAF.FacadeCreatorObjects.hr_leavemodificationFCC.GetFacadeCreate().Add(objLeaveCancell);

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

        #region update HrLeaveModification

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
        public async Task<ActionResult> HrLeaveModificationEdit(hr_leavemodificationEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.leavemodificationid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("leavemodificationid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_leavemodificationFCC.GetFacadeCreate().GetAll(new hr_leavemodificationEntity { leavemodificationid = input.leavemodificationid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;

                model.objleave= KAF.FacadeCreatorObjects.hr_leaveinfoFCC.GetFacadeCreate().GetAll(new hr_leaveinfoEntity { leaveinfoid = model.leaveinfoid }).SingleOrDefault();

                var list_leavetype = KAF.FacadeCreatorObjects.gen_leavetypeFCC.GetFacadeCreate().GetAll(new gen_leavetypeEntity { leavetypeid = model.leavetypeid }).ToList();
                
                var objleavetype = (from t in list_leavetype
                                    select new
                                    {
                                        Id = t.leavetypeid,
                                        Text = t.leavetype
                                    }).ToList();
                ViewBag.preloaded_leavetype = JsonConvert.SerializeObject(objleavetype);

                ModelState.Clear();
                return PartialView("_HrLeaveModificationEdit", model);
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
        public async Task<ActionResult> HrLeaveModificationUpdate(hr_leavemodificationEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                ModelState.Remove("modificationdate");
                ModelState.Remove("modificationtype");
                ModelState.Remove("noofdays");
                ModelState.Remove("leavemodificationid");
                ModelState.Remove("leaveinfoid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("leavetypeid");

                ModelState.Remove("startdate");
                ModelState.Remove("enddate");

                ModelState.Remove("leavestartdate");
                ModelState.Remove("leaveenddate");
                ModelState.Remove("leavedays");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("withgovtticket");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                    JavaScriptSerializer JsonConvert = new JavaScriptSerializer();
                    string serializeString = JsonConvert.Serialize(input);
                    hr_leavemodificationEntity objLeaveCancell = JsonConvert.Deserialize<hr_leavemodificationEntity>(serializeString);

                    objLeaveCancell.modificationdate = DateTime.Now;
                    objLeaveCancell.modificationtype = input.modificationtype;
                    objLeaveCancell.BaseSecurityParam = sec;
                    objLeaveCancell.isExt = 1;
                    ret = KAF.FacadeCreatorObjects.hr_leavemodificationFCC.GetFacadeCreate().Update(objLeaveCancell);

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

        #region delete HrLeaveModification

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
        public async Task<ActionResult> HrLeaveModificationDelete(hr_leaveinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("leaveinfoid"); */
                ModelState.Remove("leaveinfoid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("leavetypeid");
                ModelState.Remove("startdate");
                ModelState.Remove("enddate");
                ModelState.Remove("noofdays");
                ModelState.Remove("leavestartdate");
                ModelState.Remove("leaveenddate");
                ModelState.Remove("leavedays");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("withgovtticket");
                ModelState.Remove("iscancel");
                ModelState.Remove("ismodified");
                ModelState.Remove("isreturn");
                ModelState.Remove("returndate");
                ModelState.Remove("returnletterno");
                ModelState.Remove("returnletterdate");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.leaveinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("leaveinfoid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_leaveinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrLeaveModification

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
        public async Task<ActionResult> HrLeaveModificationDetail(hr_leaveinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                Int64 leavemodid = -99;
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.leaveinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("leaveinfoid", input.strModelPrimaryKey).ToString());

                if (input.leaveinfoid == -99)
                {
                    leavemodid = Convert.ToInt64(objClsPrivate.GetUrlParamValMVCOnlyParam("leavemodificationid", input.strModelPrimaryKey).ToString());

                }

                hr_leaveinfoEntity objLeave = new hr_leaveinfoEntity();
                hr_leavemodificationEntity objLeaveMod = new hr_leavemodificationEntity();

                if (input.leaveinfoid != -99)
                    objLeave = KAF.FacadeCreatorObjects.hr_leaveinfoFCC.GetFacadeCreate().GetAll(new hr_leaveinfoEntity { leaveinfoid = input.leaveinfoid }).SingleOrDefault();


                if (leavemodid != -99)
                {
                    objLeaveMod = KAF.FacadeCreatorObjects.hr_leavemodificationFCC.GetFacadeCreate().GetAll(new hr_leavemodificationEntity { leavemodificationid = leavemodid }).SingleOrDefault();

                    objLeave = KAF.FacadeCreatorObjects.hr_leaveinfoFCC.GetFacadeCreate().GetAll(new hr_leaveinfoEntity { leaveinfoid = objLeaveMod.leaveinfoid }).SingleOrDefault();

                    objLeave.ex_nvarchar1 = objLeaveMod.letterno;
                    objLeave.ex_nvarchar2 = objLeaveMod.letterdate.HasValue ? objLeaveMod.letterdate.Value.ToString("dd-MM-yyyy") : "";
                }

                var list_leavetype = KAF.FacadeCreatorObjects.gen_leavetypeFCC.GetFacadeCreate().GetAll(new gen_leavetypeEntity { leavetypeid = objLeave.leavetypeid }).ToList();
                var objleavetype = (from t in list_leavetype
                                    select new
                                    {
                                        Id = t.leavetypeid,
                                        Text = t.leavetype
                                    }).ToList();
                ViewBag.preloaded_leavetype = JsonConvert.SerializeObject(objleavetype);


                ModelState.Clear();
                return PartialView("_HrLeaveModificationDetail", objLeave);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



