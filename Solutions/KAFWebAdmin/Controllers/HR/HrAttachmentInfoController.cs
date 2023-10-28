
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
    public class HrAttachmentInfoController : BaseController
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
        public async Task<ActionResult> HrAttachmentInfo()
        {
            return View("HrAttachmentInfoLanding");
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
        public async Task<ActionResult> HrAttachmentInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_attachmentinfoEntity input)
        {
            hr_attachmentinfoEntity objowin_hr_attachmentinfo = new hr_attachmentinfoEntity();
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

                List<hr_attachmentinfoEntity> data = this.GetAllHrAttachmentInfoData(input);

                var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data.OrderByDescending(x => x.attachmentid)
                               select new
                               {
                                   t.attachmentid,
                                   t.hrbasicid,
                                   t.fromsubunitid,
                                   t.fromcampid,
                                   t.subunitid,
                                   t.campid,
                                   t.fromdate,
                                   t.todate,
                                   t.reason,
                                   t.letterno,
                                   t.letterdate,
                                   t.returndate,
                                   t.returnletterno,
                                   t.returnletterdate,
                                   t.countryid,
                                   t.remarks,
                                   fromcamp = campCache.Where(x => x.comId == t.fromcampid).Select(m => m.comText),
                                   camp = campCache.Where(x => x.comId == t.campid).Select(m => m.comText),
                                   fromsubunit = subUnitCache.Where(x => x.comId == t.fromsubunitid).Select(m => m.comText),
                                   subunit = subUnitCache.Where(x => x.comId == t.subunitid).Select(m => m.comText),
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.attachmentid.GetValueOrDefault(-99), "attachmentid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrAttachmentInfo/HrAttachmentInfoEdit", "HrAttachmentInfoEdit",
                                   "HrAttachmentInfo/HrAttachmentInfoDelete", "HrAttachmentInfoDelete",
                                   "HrAttachmentInfo/HrAttachmentInfoDetail", "HrAttachmentInfoDetail")
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


        List<hr_attachmentinfoEntity> GetAllHrAttachmentInfoData(hr_attachmentinfoEntity objhr_attachmentinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_attachmentinfoEntity> listobjhr_attachmentinfoEntity = new List<hr_attachmentinfoEntity>();
            try
            {
                listobjhr_attachmentinfoEntity = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().GAPgListView((objhr_attachmentinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_attachmentinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "attachmentid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "fromsubunitid" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "fromcampid" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "subunitid" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "campid" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "fromdate" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "todate" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "reason" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "letterno" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "letterdate" + " " + orderDir;
                        break;
                    case "11":
                        sortingVal = "returndate" + " " + orderDir;
                        break;
                    case "12":
                        sortingVal = "returnletterno" + " " + orderDir;
                        break;
                    case "13":
                        sortingVal = "returnletterdate" + " " + orderDir;
                        break;
                    case "14":
                        sortingVal = "countryid" + " " + orderDir;
                        break;
                    case "15":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "attachmentid" + " " + orderDir;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sortingVal;
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
                                   t.fullname,
                                   t.okpid
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



        #region Create HrAttachmentInfo

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
        public async Task<ActionResult> HrAttachmentInfoNew(hr_attachmentinfoEntity input)
        {
            try
            {
                ModelState.Clear();


                hr_attachmentinfoEntity objhr_Attachmentinfo = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().GetAll(new hr_attachmentinfoEntity { hrbasicid = input.hrbasicid }).OrderByDescending(x => x.attachmentid).FirstOrDefault();
                if (objhr_Attachmentinfo != null && objhr_Attachmentinfo.returndate == null)
                {
                    throw new Exception("Please Return The Previous Attachment");
                }

                hr_attachmentinfoEntity model = new hr_attachmentinfoEntity();
                model.militarynokw = input.militarynokw;
                hr_svcinfoEntity objhr_svcinfoEntity = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(
                    new hr_svcinfoEntity
                    {
                        militarynokw = model.militarynokw
                    }).FirstOrDefault();

                if (!objhr_svcinfoEntity.campid.HasValue) {
                    throw new Exception("No Camp Information Found");
                }
                if (!objhr_svcinfoEntity.subunitid.HasValue)
                {
                    throw new Exception("No Subunit Information Found");
                }

                model.okpid = objhr_svcinfoEntity.okpid;
                model.hrbasicid = objhr_svcinfoEntity.hrbasicid;
                model.fromcampid = objhr_svcinfoEntity.campid;
                model.fromsubunitid = objhr_svcinfoEntity.subunitid;

                var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                var objgen_subunit = subUnitCache.Where(x => x.comId == model.fromsubunitid).Select(t => new { t.comId, t.comText }).ToList();
                ViewBag.preGen_FromSubUnit = JsonConvert.SerializeObject(objgen_subunit);

                var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());
                var objgen_camp = campCache.Where(x => x.comId == model.fromcampid).Select(t => new { t.comId, t.comText }).ToList();
                ViewBag.preGen_FromCamp = JsonConvert.SerializeObject(objgen_camp);

                return PartialView("_HrAttachmentInfoNew", model);
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
        public async Task<ActionResult> HrAttachmentInfoInsert(hr_attachmentinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("attachmentid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("fromsubunitid");
                ModelState.Remove("fromcampid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                ModelState.Remove("fromdate");
                ModelState.Remove("todate");
                ModelState.Remove("reason");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("returndate");
                ModelState.Remove("returnletterno");
                ModelState.Remove("returnletterdate");
                ModelState.Remove("countryid");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    ret = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().Add_Ext(input);
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


        #region update HrAttachmentInfo

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
        public async Task<ActionResult> HrAttachmentInfoEdit(hr_attachmentinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.attachmentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("attachmentid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().GetAll(new hr_attachmentinfoEntity { attachmentid = input.attachmentid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;
                model.okpid = input.okpid;
                if (model.fromsubunitid != null)
                {
                    var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.fromsubunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_FromSubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.fromcampid != null)
                {
                    var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());
                    var objgen_camp = campCache.Where(x => x.comId == model.fromcampid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_FromCamp = JsonConvert.SerializeObject(objgen_camp);
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


                ModelState.Clear();
                return PartialView("_HrAttachmentInfoEdit", model);
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
        public async Task<ActionResult> HrAttachmentInfoUpdate(hr_attachmentinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                ModelState.Remove("attachmentid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("fromsubunitid");
                ModelState.Remove("fromcampid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                ModelState.Remove("fromdate");
                ModelState.Remove("todate");
                ModelState.Remove("reason");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("returndate");
                ModelState.Remove("returnletterno");
                ModelState.Remove("returnletterdate");
                ModelState.Remove("countryid");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    ret = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().Update_Ext(input);

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

        #region delete HrAttachmentInfo

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
        public async Task<ActionResult> HrAttachmentInfoDelete(hr_attachmentinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("attachmentid"); */
                ModelState.Remove("hrbasicid");
                ModelState.Remove("fromsubunitid");
                ModelState.Remove("fromcampid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                ModelState.Remove("fromdate");
                ModelState.Remove("todate");
                ModelState.Remove("reason");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("returndate");
                ModelState.Remove("returnletterno");
                ModelState.Remove("returnletterdate");
                ModelState.Remove("countryid");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.attachmentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("attachmentid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrAttachmentInfo

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
        public async Task<ActionResult> HrAttachmentInfoDetail(hr_attachmentinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.attachmentid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("attachmentid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_attachmentinfoFCC.GetFacadeCreate().GetAll(new hr_attachmentinfoEntity { attachmentid = input.attachmentid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;

                model.okpid = input.okpid;
                if (model.fromsubunitid != null)
                {
                    var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.fromsubunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_FromSubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.fromcampid != null)
                {
                    var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());
                    var objgen_camp = campCache.Where(x => x.comId == model.fromcampid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_FromCamp = JsonConvert.SerializeObject(objgen_camp);
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

                ModelState.Clear();
                return PartialView("_HrAttachmentInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



