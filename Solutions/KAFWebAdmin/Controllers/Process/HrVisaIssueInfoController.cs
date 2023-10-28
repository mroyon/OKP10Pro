
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
    public class HrVisaIssueInfoController : BaseController
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
        public async Task<ActionResult> HrVisaIssueInfo()
        {
            return View("HrVisaIssueInfoLanding");
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
        public async Task<ActionResult> HrVisaIssueInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_visaissueinfoEntity input)
        {
            hr_visaissueinfoEntity objowin_hr_visaissueinfo = new hr_visaissueinfoEntity();
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

                List<hr_visaissueinfoEntity> data = this.GetAllHrVisaIssueInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach (hr_visaissueinfoEntity objsingle in data)
                    {
                        objsingle.totalperson = KAF.FacadeCreatorObjects.hr_visaissueinfodetlFCC.GetFacadeCreate().GetAll(new hr_visaissueinfodetlEntity { visaissueid = objsingle.visaissueid }).ToList().Count().ToString();


                    }


                    var tut = (from t in data
                               select new
                               {
                                   t.visaissueid,
                                   t.visademandid,
                                   t.visaissuedate,
                                   t.visaissueletterdate,
                                   t.visaissueletterno,
                                   t.remarks,
                                   t.totalperson,
                                   t.ex_nvarchar2,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.visaissueid.GetValueOrDefault(-99), "visaissueid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrVisaIssueInfo/HrVisaIssueInfoEdit", "HrVisaIssueInfoEdit",
                                   "", "HrVisaIssueInfoDelete",
                                   "", "HrVisaIssueInfoDetail", "DownloadReport", 4)
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


        List<hr_visaissueinfoEntity> GetAllHrVisaIssueInfoData(hr_visaissueinfoEntity objhr_visaissueinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_visaissueinfoEntity> listobjhr_visaissueinfoEntity = new List<hr_visaissueinfoEntity>();
            try
            {
                listobjhr_visaissueinfoEntity = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GAPgListView((objhr_visaissueinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_visaissueinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "visaissueid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "visademandid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "visaissuedate" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "visaissueletterdate" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "visaissueletterno" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "visaissueid" + " " + orderDir;
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



        #region Create HrVisaIssueInfo

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
        public async Task<ActionResult> HrVisaIssueInfoNew(hr_visaissueinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_visaissueinfoEntity model = new hr_visaissueinfoEntity();
                return PartialView("_HrVisaIssueInfoNew", model);
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
        public async Task<ActionResult> HrVisaIssueInfoInsert(hr_visaissueinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_visaissueList.Count; ind++)
                {
                    ModelState.Remove("hr_visaissueList[" + ind + "].visaissuedetlid");
                    ModelState.Remove("hr_visaissueList[" + ind + "].visaissueid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    
                    ret = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().SaveMasterDethr_visaissueinfodetl(input,input.hr_visaissueList);
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


        #region update HrVisaIssueInfo

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
        public async Task<ActionResult> HrVisaIssueInfoEdit(hr_visaissueinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visaissueid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visaissueid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GetAll(new hr_visaissueinfoEntity { visaissueid = input.visaissueid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                //List<hr_visademandinfoEntity> listhr_visademandinfo = KAF.FacadeCreatorObjects.hr_visademandinfoFCC.GetFacadeCreate().GetAll(new hr_visademandinfoEntity { visademandid = model.visademandid }).ToList();
                //var objhr_visademandinfo = (from t in listhr_visademandinfo
                //select new
                //{
                //		 Id = t.visademandid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedHr_VisaDemandInfo = JsonConvert.SerializeObject(objhr_visademandinfo);




                ModelState.Clear();
                return PartialView("_HrVisaIssueInfoEdit", model);
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
        public async Task<ActionResult> HrVisaIssueInfoUpdate(hr_visaissueinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                if (input.hr_visaissueList != null && input.hr_visaissueList.Count > 0)
                    for (int ind = 0; ind < input.hr_visaissueList.Count; ind++)
                {
                    ModelState.Remove("hr_visaissueList[" + ind + "].visaissuedetlid");
                    ModelState.Remove("hr_visaissueList[" + ind + "].visaissueid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.hr_visaissueList != null && input.hr_visaissueList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().SaveMasterDethr_visaissueinfodetl(input, input.hr_visaissueList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().Update(input);

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

        #region delete HrVisaIssueInfo

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
        public async Task<ActionResult> HrVisaIssueInfoDelete(hr_visaissueinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("visaissueid"); */
                ModelState.Remove("visademandid");
                ModelState.Remove("visaissuedate");
                ModelState.Remove("visaissueletterdate");
                ModelState.Remove("visaissueletterno");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.visaissueid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visaissueid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrVisaIssueInfo

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
        public async Task<ActionResult> HrVisaIssueInfoDetail(hr_visaissueinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.visaissueid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("visaissueid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GetAll(new hr_visaissueinfoEntity { visaissueid = input.visaissueid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //List<hr_visademandinfoEntity> listhr_visademandinfo = KAF.FacadeCreatorObjects.hr_visademandinfoFCC.GetFacadeCreate().GetAll(new hr_visademandinfoEntity { visademandid = model.visademandid }).ToList();
                //var objhr_visademandinfo = (from t in listhr_visademandinfo
                //select new
                //{
                //		 Id = t.visademandid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedHr_VisaDemandInfo = JsonConvert.SerializeObject(objhr_visademandinfo);



                ModelState.Clear();
                return PartialView("_HrVisaIssueInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



