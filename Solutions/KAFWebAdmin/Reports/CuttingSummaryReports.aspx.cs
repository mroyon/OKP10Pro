using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAFWebAdmin.HelperClasses;
using Microsoft.Reporting.WebForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CuttingSummaryReports : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string searchText = string.Empty;

            string reporttype = "", masterid = "";

            string MilNoBD = "";
            string ExpireWithin = "";
            string ExpireFrom = "";
            string ExpireTo = "";

            if (Request.QueryString["reporttype"] != null)
            {
                reporttype = Request.QueryString["reporttype"].ToString();
                MilNoBD = Request.QueryString["MilNoBD"].ToString();
                ExpireWithin = Request.QueryString["ExpireWithin"].ToString();
                ExpireFrom = Request.QueryString["ExpireFrom"].ToString();
                ExpireTo = Request.QueryString["ExpireTo"].ToString();

                LoadReport(reporttype, MilNoBD, ExpireWithin, ExpireFrom, ExpireTo);
                //LoadReport(reporttype);

            }



        }
    }

    private void LoadReport(string reporttype)
    {
        if (reporttype == "3") //10%
        {
            var year = Convert.ToInt64(Request.QueryString["year"].ToString());
            var month = Convert.ToInt64(Request.QueryString["month"].ToString());

            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummary(new rpt_CuttingSummaryEntity { PayAllceID = 3, Year = year, MonthID = month }).ToList();
            var list_details = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { PayAllceID = 3, Year = year, MonthID = month }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_RegCuttingSummary.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);
                ReportDataSource rdc2 = new ReportDataSource("DataSet2", list_details);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "4") //10%
        {
            var year = Convert.ToInt64(Request.QueryString["year"].ToString());
            var month = Convert.ToInt64(Request.QueryString["month"].ToString());

            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummary(new rpt_CuttingSummaryEntity { PayAllceID = 4, Year = year, MonthID = month }).ToList();
            var list_details = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { PayAllceID = 4, Year = year, MonthID = month }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_RegCuttingSummary.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);
                ReportDataSource rdc2 = new ReportDataSource("DataSet2", list_details);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "5") //10%
        {
            var year = Convert.ToInt64(Request.QueryString["year"].ToString());
            var month = Convert.ToInt64(Request.QueryString["month"].ToString());

            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummary(new rpt_CuttingSummaryEntity { PayAllceID = 5, Year = year, MonthID = month }).ToList();
            var list_details = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { PayAllceID = 5, Year = year, MonthID = month }).ToList();


            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_RegCuttingSummary.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);
                ReportDataSource rdc2 = new ReportDataSource("DataSet2", list_details);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "6") //Individual
        {
            var milid = Convert.ToInt64(Request.QueryString["milid"].ToString());
            var payallceid = Convert.ToInt64(Request.QueryString["payallceid"].ToString());

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
                CustomerListReportViewer.DataBind();
            }
        }



    }
    private void LoadReport(string reporttype, string MilNoKW, string ExpireWithin, string ExpireFrom, string ExpireTo)
    {
       
        if (reporttype == "13") //10%
        {
            long? _expirewithin = !string.IsNullOrEmpty(ExpireWithin) ? Convert.ToInt64(ExpireWithin) : (long?)null;
            DateTime? _expirefrom = !string.IsNullOrEmpty(ExpireFrom) ? Convert.ToDateTime(ExpireFrom) : (DateTime?)null;
            DateTime? _expireto = !string.IsNullOrEmpty(ExpireTo) ? Convert.ToDateTime(ExpireTo) : (DateTime?)null;

            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().OfficersExpiryInfoData(new rptOfficersExpiryInfoEntity 
            { 
                MilNoKW = MilNoKW,
                ExpiredWithIn = _expirewithin,
                ExpiredFrom = _expirefrom,
                ExpiredTo = _expireto
            }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/OfficersNominalRollExpiryInfo.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }



    }
}
