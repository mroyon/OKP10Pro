
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
using System.Data.SqlClient;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.Reflection;
using System.Text;
using System.IO;
using System.Web.UI;
using Microsoft.Reporting.WebForms;
using KAFWebAdmin.HelperClasses;

namespace KAFWebAdmin.Controllers.HR
{
    public class ParadeStateReportInfoController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        clsSecurityPanel objSecPanel = new clsSecurityPanel();
        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
        public List<rptm_reportdatasourceEntity> objListrptm_reportdatasource = new List<rptm_reportdatasourceEntity>();


        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DailyManpowerStateRankWise()
        {

            return View("DailyManpowerStateRankWiseLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DailyManpowerState()
        {

            return View("DailyManpowerStateLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DeploymentState()
        {

            return View("DeploymentStateLanding");
        }


        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DailyHeldState()
        {

            return View("DailyHeldStateLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> LeaveState()
        {

            return View("LeaveStateLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> HospitalState()
        {

            return View("HospitalStateLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RepatriationState()
        {

            return View("RepatriationStateLanding");
        }

        public ActionResult Export(long? MilitaryNoKW, long? PayAllceID)
        {
            List<byte[]> bytesArray = new List<byte[]>();
            List<string> fileNameArray = new List<string>();
            var milid = MilitaryNoKW;//Convert.ToInt64(Request.QueryString["milid"].ToString());
            var payallceid = PayAllceID;// Convert.ToInt64(Request.QueryString["payallceid"].ToString());
            ReportViewer CustomerListReportViewer = new ReportViewer();
            System.Web.UI.ScriptManager scriptManager = new ScriptManager();
            try
            {
                var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummeryIndividual(new rpt_CuttingSummeryIndividualEntity { PayAllceID = payallceid, MilitaryNoKW = milid }).ToList();


                if (list.Count > 0)
                {

                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_CuttingIndividual.rdlc");
                    CustomerListReportViewer.LocalReport.DataSources.Clear();
                    ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                    CurrencyToWords objCls = new CurrencyToWords();
                    ReportParameter[] param = new ReportParameter[4];

                    decimal totalbdtunpaid = Convert.ToDecimal(list.FirstOrDefault().TotalGovtCutting.Value) *
                       Convert.ToDecimal(list.FirstOrDefault().Rate.Value);
                    param[0] = new ReportParameter("strtotal", objCls.KDToWords(list.FirstOrDefault().TotalGovtCutting.Value), false);
                    param[1] = new ReportParameter("strtotalunpaid", objCls.KDToWords(list.FirstOrDefault().TotalUnPaidAmount.Value), false);
                    param[2] = new ReportParameter("strtotalpaid", objCls.KDToWords(list.FirstOrDefault().TotalPaidAmount.Value), false);
                    param[2] = new ReportParameter("strtotalpaid", objCls.KDToWords(list.FirstOrDefault().TotalPaidAmount.Value), false);
                    param[3] = new ReportParameter("strtotalunpaidbdt", objCls.BDTToWords(totalbdtunpaid), false);

                    CustomerListReportViewer.LocalReport.SetParameters(param);

                    CustomerListReportViewer.LocalReport.DataSources.Add(rdc);

                    CustomerListReportViewer.LocalReport.Refresh();
                   
                    string reportType = "PDF";
                    string mimeType = "", encoding = "", fileNameExtension = "";
                    string zipName = String.Format("{1}_{0}.pdf", DateTime.Now.ToString("yyyy_MMM_dd_HHmmss"), milid);
                    string deviceInfo =
                                        "<DeviceInfo>" +
                                        "   <OutputFormat>" + reportType + "</OutputFormat>" +
                                        "   <PageWidth>8.5in</PageWidth>" +
                                        "   <PageHeight>11in</PageHeight>" +
                                        "   <MarginTop>0.5in</MarginTop>" +
                                        "   <MarginLeft>0in</MarginLeft>" +
                                        "   <MarginRight>0in</MarginRight>" +
                                        "   <MarginBottom>0in</MarginBottom>" +
                                        "</DeviceInfo>";

                    Warning[] warnings;
                    string[] streams;
                    byte[] renderedBytes = CustomerListReportViewer.LocalReport.Render(reportType, deviceInfo, out mimeType, out encoding,
                                                                out fileNameExtension, out streams, out warnings);
                    //bytesArray.Add(renderedBytes);
                    //fileNameArray.Add(zipName);

                    return File(renderedBytes, "application/pdf", zipName);
                }
                else
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "" });

                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }


        }


       

        #region DateTime Helper
        public static string ConvertDateTimeToEpochTimestamp(DateTime dateToConvert)
        {
            DateTime epoch = new DateTime(1970, 1, 1);
            return Convert.ToString(dateToConvert.Subtract(epoch).TotalMilliseconds);
        }

        public static DateTime ConvertEpochTimestampToDateTime(string unixTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddMilliseconds(Convert.ToDouble(unixTimeStamp));
        }

        public static DateTime? ConvertEpochTimestampToNullableDateTime(string unixTimeStamp)
        {
            try
            {
                return new DateTime(1970, 1, 1, 0, 0, 0).AddMilliseconds(Convert.ToDouble(unixTimeStamp));
            }
            catch (Exception ex) { }
            return null;
        }

        public static string ConvertNullableDateTimeToEpochTimestamp(DateTime? nullableDateToConvert)
        {
            DateTime epoch = new DateTime(1970, 1, 1);
            DateTime dateToConvert = Convert.ToDateTime(nullableDateToConvert);
            return Convert.ToString(dateToConvert.Subtract(epoch).TotalMilliseconds);
        }
        #endregion
    }
}



