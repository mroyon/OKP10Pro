﻿
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
    public class TranCuttingInfoPaymentController : BaseController
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
        public async Task<ActionResult> TranCuttingInfoPayment()
        {
            SecurityCapsule sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

            ViewBag.okpid = sec.okpid;

            return View("TranCuttingInfoPaymentLanding");
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
        public async Task<ActionResult> TranCuttingInfoPaymentTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, tran_cuttinginfo_GAPgListView_ExtEntity input)
        {
            tran_cuttinginfoEntity objowin_tran_cuttinginfo = new tran_cuttinginfoEntity();
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

                var data = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_tran_cuttinginfo_GAPgListView_Ext(input).ToList();

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    foreach(var objsingle in data)
                    {
                       var objtemp= KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_Kaf_tran_cuttinginfo_ProcessCount
                            (new Kaf_tran_cuttinginfo_ProcessCountEntity { CuttingInfoID=objsingle.CuttingInfoID}).FirstOrDefault();

                        if(objtemp!=null)
                        {
                            if (objtemp.Total == objtemp.TotalProcess)
                                objsingle.IsSelected = true;
                            else
                                objsingle.IsSelected = false;
                        }
                    }

                    var tut = (from t in data
                               select new
                               {
                                   t.CuttingInfoID,
                                   t.OkpID,
                                   t.MonthID,
                                   t.Year,
                                   t.ProcessDate,
                                   t.ReviewDate,
                                   t.ReviewRemarks,
                                   t.IsApproved,
                                   t.ApproveDate,
                                   t.ApproveBy,
                                   t.IsReviewed,
                                   t.ApproveRemarks,
                                   t.Total,
                                   t.TotalPaid,
                                   t.TotalNotPaid,
                                   t.TotalPaidAmount,
                                   t.OkpName,
                                   t.month,
                                   t.ItemName,
                                   t.PayAllceID,
                                   strIsApproved = t.IsApproved == null ? "" : (t.IsApproved == true ? "Yes" : "No"),
                                   ex_nvarchar1 = genButtonPanel(t.CuttingInfoID.GetValueOrDefault(-99), "cuttinginfoid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   t.IsReviewed == true ? "" : "TranCuttingInfoPayment/TranCuttingInfoPaymentEdit", "TranCuttingInfoPaymentEdit",
                                   "", "TranCuttingInfoPaymentDelete",
                                   t.IsReviewed == true ? "" : t.IsSelected==true?"TranCuttingInfoPayment/TranCuttingInfoPaymentSubmitNew":"", "TranCuttingInfoPaymentSubmitNew", "DownloadReport", t.PayAllceID == 3 ? 3 : 4)
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
        public async Task<ActionResult> TranCuttingInfoPaymentDetailTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, rpt_GetCuttingInfo_ExtEntity input)
        {
            tran_cuttinginfoEntity objowin_tran_cuttinginfo = new tran_cuttinginfoEntity();
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

                var data = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo_Ext(input).ToList();

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   //t.CuttingInfoID,
                                   t.GroupName,
                                   t.rankname,
                                   t.milnokw,
                                   t.fullname,

                                   t.prevbalgovtcutting,
                                   t.govtcutting,
                                   totalpayable = (t.prevbalgovtcutting == null ? 0 : t.prevbalgovtcutting) + (t.govtcutting == null ? 0 : t.govtcutting),
                                   t.ispaid,
                                   strpaid = "<input class='chkispaid' onclick='makechanges(this);' type='checkbox'  CuttingInfoDetlID='" + objClsPrivate.BuildUrlMVCOnlyParams("CuttingInfoDetlID", t.CuttingInfoDetlID.GetValueOrDefault(-99).ToString()) + "' class='chkispaid' " + (t.ispaid == true ? "checked='checked'" : "") + " />",
                                   //strpaiddate = t.ispaid == true ? t.paiddate.Value.ToString("dd-MMM-yyyy") : "",
                                   strpaiddate = @"<div class='input-group date dateonly' id='' style='width:100%;'>
                                                     <input value = '" + (t.ispaid == true && t.paiddate != null ? t.paiddate.Value.ToString("dd-MM-yyyy") : "") + @"' class='form-control text-box single-line txtsinglepayDate'  type='text'>
                                                        <span class='input-group-addon'>
                                                            <span class='glyphicon glyphicon-calendar'></span>
                                                        </span>
                                                    </div>",
                                   t.unpaidremarks,
                                   strunpaidremarks = "<input type='text' class='form-control unpaidremarks' value='" + t.unpaidremarks + "' />",


                                   ex_nvarchar1 = genButtonPanel(t.CuttingInfoDetlID.GetValueOrDefault(-99), "CuttingInfoDetlID", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "TranCuttingInfoPayment/TranCuttingInfoPaymentEdit", "UpdatePaymentInfo",
                                   "", "TranCuttingInfoPaymentDelete",
                                   "", "TranCuttingInfoPaymentDetail")
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


        [HttpPost]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GetSummaryData(tran_cuttinginfoEntity input)
        {

            JsonResult result = new JsonResult();
            try
            {

                var model = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_tran_cuttinginfo_GAPgListView_Ext(
                     new tran_cuttinginfo_GAPgListView_ExtEntity { CuttingInfoID = input.cuttinginfoid, CurrentPage = 1, PageSize = 10 }).FirstOrDefault();

                if (model != null)
                {

                    result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, recordsTotal = model.TotalPaid, data = model }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { status = KAF.MsgContainer._Status._statusFailed, recordsTotal = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }
        public string genButtonPanel(long menuId, string menuName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
        string actionNameDelete, string deleteMethodName, string actionNameView, string viewMethodName, string reportDownload1 = "", Int64? reporttype1 = -99)
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

                                strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;,this);return false;'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";

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


                                strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> Submit</button>";

                            }
                        }
                        if (!String.IsNullOrEmpty(reportDownload1))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {

                                strValue += "<button class='btn btn-info btn-md' onclick='DownloadData(&quot;" + menuId.ToString() + "&quot;,&quot;" + reporttype1.ToString() + "&quot;)'><i class='fa fa-info-circle'></i>Report</button>";

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


        List<tran_cuttinginfoEntity> GetAllTranCuttingInfoPaymentData(tran_cuttinginfoEntity objtran_cuttinginfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<tran_cuttinginfoEntity> listobjtran_cuttinginfoEntity = new List<tran_cuttinginfoEntity>();
            try
            {
                listobjtran_cuttinginfoEntity = KAF.FacadeCreatorObjects.tran_cuttinginfoFCC.GetFacadeCreate().GAPgListView((objtran_cuttinginfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjtran_cuttinginfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "cuttinginfoid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "okpid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "monthid" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "year" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "processdate" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "reviewdate" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "reviewremarks" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "isapproved" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "approvedate" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "approveby" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "approveremarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "cuttinginfoid" + " " + orderDir;
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



        #region Create TranCuttingPayment

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
        public async Task<ActionResult> TranCuttingInfoPaymentSubmitNew(tran_cuttinginfo_GAPgListView_ExtEntity input)
        {
            try
            {
                input.CuttingInfoID = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("cuttinginfoid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_tran_cuttinginfo_GAPgListView_Ext(
                            new tran_cuttinginfo_GAPgListView_ExtEntity { 
                            CuttingInfoID = input.CuttingInfoID, CurrentPage = 1, PageSize = 10 }).FirstOrDefault();


                ModelState.Clear();
                return PartialView("_TranCuttingInfoPaymentSubmitNew", model);
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
        public async Task<ActionResult> TranCuttingInfoPaymentInsert(tran_cuttinginfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                ModelState.Remove("ProcessDate");

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.reviewedby = sec.createdby;
                    input.reviewdate = DateTime.Now;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    ret = KAF.FacadeCreatorObjects.tran_cuttinginfoFCC.GetFacadeCreate().UpdateReviewed(input);
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


        #region update TranCuttingPayment

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
        public async Task<ActionResult> TranCuttingInfoPaymentEdit(tran_cuttinginfo_GAPgListView_ExtEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.CuttingInfoID = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("cuttinginfoid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_tran_cuttinginfo_GAPgListView_Ext(
                    new tran_cuttinginfo_GAPgListView_ExtEntity { CuttingInfoID = input.CuttingInfoID, CurrentPage = 1, PageSize = 10 }).FirstOrDefault();


                ModelState.Clear();
                return PartialView("_TranCuttingInfoPaymentEdit", model);
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
        public async Task<ActionResult> TranCuttingInfoPaymentUpdate(tran_cuttinginfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.BaseSecurityParam = sec;

                var model = KAF.FacadeCreatorObjects.tran_cuttinginfoFCC.GetFacadeCreate().GetAll(new tran_cuttinginfoEntity { cuttinginfoid=input.cuttinginfoid}).FirstOrDefault();

                if (model != null)
                {
                    model.isreviewed = input.isreviewed;
                    model.reviewedby = sec.createdby;
                    model.reviewremarks = input.reviewremarks;
                    model.reviewdate = DateTime.Now;
                    model.isProcess = true;
                    ret = KAF.FacadeCreatorObjects.tran_cuttinginfoFCC.GetFacadeCreate().Update(model);
                }

                if (ret > 0)
                {
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
        #endregion


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
        public async Task<ActionResult> TranCuttingInfoPaymentUpdatePayment(tran_cuttinginfodetlEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                ModelState.Remove("groupid");
                ModelState.Remove("cuttinginfoid");
                ModelState.Remove("hrbasicid");
                ModelState.Remove("rankid");
                ModelState.Remove("processdate");
                ModelState.Remove("basicsalary");
                ModelState.Remove("regimentalcutting");
                ModelState.Remove("govtcutting");


                if (input != null && ModelState.IsValid == true)
                {
                    if (input.paymenttype == 1 && input.cuttinginfoid == null)
                    {
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
                    }
                    else if (input.paymenttype == 3 && input.cuttinginfoid == null)
                    {
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
                    }
                    else if (input.paymenttype == 2)
                    {
                        input.cuttinginfodetlid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("CuttingInfoDetlID", input.strModelPrimaryKey).ToString());
                        input.govtcutting = 0;
                        if (string.IsNullOrEmpty(input.strModelPrimaryKey) || (input.paiddate == null && input.ispaid == true))
                            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
                    }


                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.paidby = sec.createdby;

                    ret = KAF.FacadeCreatorObjects.tran_cuttinginfodetlFCC.GetFacadeCreate().Update(input);

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
        public async Task<ActionResult> TranCuttingInfoPaymentDetail(tran_cuttinginfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.cuttinginfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("cuttinginfoid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.tran_cuttinginfoFCC.GetFacadeCreate().GetAll(new tran_cuttinginfoEntity { cuttinginfoid = input.cuttinginfoid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;


                ModelState.Clear();
                return PartialView("_TranCuttingInfoPaymentDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


    }
}



