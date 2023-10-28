
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
    public class HrRepPassportInfoController : BaseController
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
        public async Task<ActionResult> HrRepPassportInfo()
        {
            return View("HrRepPassportInfoLanding");
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
        public async Task<ActionResult> HrRepPassportInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_reppassportinfoEntity input)
        {
            hr_reppassportinfoEntity objowin_hr_reppassportinfo = new hr_reppassportinfoEntity();
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

                List<hr_reppassportinfoEntity> data = this.GetAllHrRepPassportInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach (hr_reppassportinfoEntity objsingle in data)
                    {
                        objsingle.totalperson = KAF.FacadeCreatorObjects.hr_reppassportinfodetlFCC.GetFacadeCreate().GetAll(new hr_reppassportinfodetlEntity { reppassportid = objsingle.reppassportid }).ToList().Count().ToString();
                    }

                    var tut = (from t in data
                               select new
                               {
                                   t.reppassportid,
                                   t.replacementid,
                                   t.passportrecvdate,
                                   t.passportletterdate,
                                   t.passportletterno,
                                   t.remarks,
                                   t.totalperson,
                                   t.ex_nvarchar2,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.reppassportid.GetValueOrDefault(-99), "reppassportid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrRepPassportInfo/HrRepPassportInfoEdit", "HrRepPassportInfoEdit",
                                   "", "HrRepPassportInfoDelete",
                                   "HrRepPassportInfo/HrRepPassportInfoDetail", "HrRepPassportInfoDetail", "DownloadReport", 2)
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


        List<hr_reppassportinfoEntity> GetAllHrRepPassportInfoData(hr_reppassportinfoEntity objhr_reppassportinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_reppassportinfoEntity> listobjhr_reppassportinfoEntity = new List<hr_reppassportinfoEntity>();
            try
            {
                listobjhr_reppassportinfoEntity = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().GAPgListView((objhr_reppassportinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_reppassportinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "reppassportid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "replacementid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "passportrecvdate" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "passportletterdate" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "passportletterno" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "reppassportid" + " " + orderDir;
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

        #region Create HrRepPassportInfo

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
        public async Task<ActionResult> HrRepPassportInfoNew(hr_reppassportinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_reppassportinfoEntity model = new hr_reppassportinfoEntity();
                return PartialView("_HrRepPassportInfoNew", model);
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
        public async Task<ActionResult> HrRepPassportInfoInsert(hr_reppassportinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_passportList.Count; ind++)
                {
                    ModelState.Remove("hr_passportList[" + ind + "].newhrbasicid");
                    ModelState.Remove("hr_passportList[" + ind + "].newhrsvcid");
                    ModelState.Remove("hr_passportList[" + ind + "].hrbasicid");
                    ModelState.Remove("hr_passportList[" + ind + "].hrsvcid");
                    ModelState.Remove("hr_passportList[" + ind + "].reppassportdetlid");
                    ModelState.Remove("hr_passportList[" + ind + "].reppassportid");
                }


                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    ret = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().SaveMasterDethr_reppassportinfodetl(input, input.hr_passportList);
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


        #region update HrRepPassportInfo

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
        public async Task<ActionResult> HrRepPassportInfoEdit(hr_reppassportinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.reppassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("reppassportid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().GetAll(new hr_reppassportinfoEntity { reppassportid = input.reppassportid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                //List<hr_replacementinfoEntity> listhr_replacementinfo = KAF.FacadeCreatorObjects.hr_replacementinfoFCC.GetFacadeCreate().GetAll(new hr_replacementinfoEntity { replacementid = model.replacementid }).ToList();
                //var objhr_replacementinfo = (from t in listhr_replacementinfo
                //select new
                //{
                //		 Id = t.replacementid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedHr_ReplacementInfo = JsonConvert.SerializeObject(objhr_replacementinfo);




                ModelState.Clear();
                return PartialView("_HrRepPassportInfoEdit", model);
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
        public async Task<ActionResult> HrRepPassportInfoUpdate(hr_reppassportinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                if (input.hr_passportList != null && input.hr_passportList.Count > 0)
                    for (int ind = 0; ind < input.hr_passportList.Count; ind++)
                    {
                        ModelState.Remove("hr_passportList[" + ind + "].newhrbasicid");
                        ModelState.Remove("hr_passportList[" + ind + "].newhrsvcid");
                        ModelState.Remove("hr_passportList[" + ind + "].hrbasicid");
                        ModelState.Remove("hr_passportList[" + ind + "].hrsvcid");
                        ModelState.Remove("hr_passportList[" + ind + "].reppassportdetlid");
                        ModelState.Remove("hr_passportList[" + ind + "].reppassportid");
                        ModelState.Remove("hr_passportList[" + ind + "].newpassportno");
                    }


                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    if (input.hr_passportList != null && input.hr_passportList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().SaveMasterDethr_reppassportinfodetl(input, input.hr_passportList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().Update(input);

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

        #region delete HrRepPassportInfo

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
        public async Task<ActionResult> HrRepPassportInfoDelete(hr_reppassportinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("reppassportid"); */
                ModelState.Remove("replacementid");
                ModelState.Remove("passportrecvdate");
                ModelState.Remove("passportletterdate");
                ModelState.Remove("passportletterno");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.reppassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("reppassportid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrRepPassportInfo

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
        public async Task<ActionResult> HrRepPassportInfoDetail(hr_reppassportinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.reppassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("reppassportid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().GetAll(new hr_reppassportinfoEntity { reppassportid = input.reppassportid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //List<hr_replacementinfoEntity> listhr_replacementinfo = KAF.FacadeCreatorObjects.hr_replacementinfoFCC.GetFacadeCreate().GetAll(new hr_replacementinfoEntity { replacementid = model.replacementid }).ToList();
                //var objhr_replacementinfo = (from t in listhr_replacementinfo
                //select new
                //{
                //		 Id = t.replacementid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedHr_ReplacementInfo = JsonConvert.SerializeObject(objhr_replacementinfo);



                ModelState.Clear();
                return PartialView("_HrRepPassportInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



