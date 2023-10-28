
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
    public class HrOkpTransferInfoController : BaseController
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
        public async Task<ActionResult> HrOkpTransferInfo()
        {
            return View("HrOkpTransferInfoLanding");
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
        public async Task<ActionResult> HrOkpTransferInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_okptransferinfoEntity input)
        {
            hr_okptransferinfoEntity objowin_hr_okptransferinfo = new hr_okptransferinfoEntity();
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

                List<hr_okptransferinfoEntity> data = this.GetAllHrOkpTransferInfoData(input);

                var okpCache = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data.OrderByDescending(x=>x.okptransferid)
                               select new
                               {
                                   t.okptransferid,
                                   t.hrbasicid,
                                   t.fromkopid,
                                   t.tookpid,
                                   t.subunitid,
                                   t.campid,
                                   t.transferdate,
                                   t.reason,
                                   t.letterno,
                                   t.letterdate,
                                   t.remarks,
                                   fromokp = okpCache.Where(x => x.comId == t.fromkopid).Select(m => m.comText),
                                   tookp = okpCache.Where(x => x.comId == t.tookpid).Select(m => m.comText),
                                   ex_nvarchar1 =CurrentPage==1&& t.okptransferid == data.Max(x => x.okptransferid)?
                                   objSecPanel.genButtonPanel(t.okptransferid.GetValueOrDefault(-99), "okptransferid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrOkpTransferInfo/HrOkpTransferInfoEdit", "HrOkpTransferInfoEdit",
                                   "HrOkpTransferInfo/HrOkpTransferInfoDelete", "HrOkpTransferInfoDelete",
                                   "HrOkpTransferInfo/HrOkpTransferInfoDetail", "HrOkpTransferInfoDetail")
                                   :
                                   objSecPanel.genButtonPanel(t.okptransferid.GetValueOrDefault(-99), "okptransferid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "", "",
                                   "", "",
                                   "HrOkpTransferInfo/HrOkpTransferInfoDetail", "HrOkpTransferInfoDetail")
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


        List<hr_okptransferinfoEntity> GetAllHrOkpTransferInfoData(hr_okptransferinfoEntity objhr_okptransferinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_okptransferinfoEntity> listobjhr_okptransferinfoEntity = new List<hr_okptransferinfoEntity>();
            try
            {
                listobjhr_okptransferinfoEntity = KAF.FacadeCreatorObjects.hr_okptransferinfoFCC.GetFacadeCreate().GAPgListView((objhr_okptransferinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_okptransferinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "okptransferid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "fromkopid" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "tookpid" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "subunitid" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "campid" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "transferdate" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "reason" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "letterno" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "letterdate" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "okptransferid" + " " + orderDir;
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



        #region Create HrOkpTransferInfo

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
        public async Task<ActionResult> HrOkpTransferInfoNew(hr_okptransferinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_okptransferinfoEntity model = new hr_okptransferinfoEntity();
                model.militarynokw = input.militarynokw;

                hr_svcinfoEntity objhr_svcinfoEntity = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(
                    new hr_svcinfoEntity
                    {
                        militarynokw = model.militarynokw
                    }).FirstOrDefault();
                model.fromkopid = objhr_svcinfoEntity.okpid;
                model.hrbasicid = objhr_svcinfoEntity.hrbasicid;

                var okpCache = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                var objgen_okp = okpCache.Where(x => x.comId == objhr_svcinfoEntity.okpid).Select(t => new { t.comId, t.comText }).ToList();
                ViewBag.preGen_fromOkp = JsonConvert.SerializeObject(objgen_okp);

                return PartialView("_HrOkpTransferInfoNew", model);
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
        public async Task<ActionResult> HrOkpTransferInfoInsert(hr_okptransferinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("okptransferid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("fromkopid");
                ModelState.Remove("tookpid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                ModelState.Remove("transferdate");
                ModelState.Remove("reason");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    ret = KAF.FacadeCreatorObjects.hr_okptransferinfoFCC.GetFacadeCreate().Add_Ext(input);
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


        #region update HrOkpTransferInfo

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
        public async Task<ActionResult> HrOkpTransferInfoEdit(hr_okptransferinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.okptransferid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("okptransferid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_okptransferinfoFCC.GetFacadeCreate().GetAll(new hr_okptransferinfoEntity { okptransferid = input.okptransferid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;
                var okpCache = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());

                if (model.fromkopid != null)
                {
                    var objgen_okp = okpCache.Where(x => x.comId == model.fromkopid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_fromOkp = JsonConvert.SerializeObject(objgen_okp);
                }
                if (model.tookpid != null)
                {
                    var objgen_okp = okpCache.Where(x => x.comId == model.tookpid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_toOkp = JsonConvert.SerializeObject(objgen_okp);
                }
                if (model.subunitid != null)
                {
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.subunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_SubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.campid != null)
                {
                    var objgen_camp = campCache.Where(x => x.comId == model.campid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_Camp = JsonConvert.SerializeObject(objgen_camp);
                }



                ModelState.Clear();
                return PartialView("_HrOkpTransferInfoEdit", model);
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
        public async Task<ActionResult> HrOkpTransferInfoUpdate(hr_okptransferinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                ModelState.Remove("okptransferid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("fromkopid");
                ModelState.Remove("tookpid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                ModelState.Remove("transferdate");
                ModelState.Remove("reason");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    ret = KAF.FacadeCreatorObjects.hr_okptransferinfoFCC.GetFacadeCreate().Update_Ext(input);

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

        #region delete HrOkpTransferInfo

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
        public async Task<ActionResult> HrOkpTransferInfoDelete(hr_okptransferinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("okptransferid"); */
                ModelState.Remove("hrbasicid");
                ModelState.Remove("fromkopid");
                ModelState.Remove("tookpid");
                ModelState.Remove("subunitid");
                ModelState.Remove("campid");
                ModelState.Remove("transferdate");
                ModelState.Remove("reason");
                ModelState.Remove("letterno");
                ModelState.Remove("letterdate");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.okptransferid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("okptransferid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_okptransferinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrOkpTransferInfo

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
        public async Task<ActionResult> HrOkpTransferInfoDetail(hr_okptransferinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.okptransferid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("okptransferid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_okptransferinfoFCC.GetFacadeCreate().GetAll(new hr_okptransferinfoEntity { okptransferid = input.okptransferid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;

                var okpCache = new DataCacheController().GetCacheData(clsDataCache.gen_okpEntity[0].ToString());
                var subUnitCache = new DataCacheController().GetCacheData(clsDataCache.gen_subunitEntity[0].ToString());
                var campCache = new DataCacheController().GetCacheData(clsDataCache.gen_campEntity[0].ToString());

                if (model.fromkopid != null)
                {
                    var objgen_okp = okpCache.Where(x => x.comId == model.fromkopid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_fromOkp = JsonConvert.SerializeObject(objgen_okp);
                }
                if (model.tookpid != null)
                {
                    var objgen_okp = okpCache.Where(x => x.comId == model.tookpid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_toOkp = JsonConvert.SerializeObject(objgen_okp);
                }
                if (model.subunitid != null)
                {
                    var objgen_subunit = subUnitCache.Where(x => x.comId == model.subunitid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_SubUnit = JsonConvert.SerializeObject(objgen_subunit);
                }
                if (model.campid != null)
                {
                    var objgen_camp = campCache.Where(x => x.comId == model.campid).Select(t => new { t.comId, t.comText }).ToList();
                    ViewBag.preGen_Camp = JsonConvert.SerializeObject(objgen_camp);
                }



                ModelState.Clear();
                return PartialView("_HrOkpTransferInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



