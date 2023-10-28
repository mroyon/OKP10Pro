using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using Microsoft.Reporting.WebForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class DownloadOtherReports : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string searchText = string.Empty;

            string reporttype = "", masterid = "";

            if (Request.QueryString["reporttype"] != null)
            {
                reporttype = Request.QueryString["reporttype"].ToString();
                masterid = Request.QueryString["primariid"].ToString();
                LoadReport(reporttype, masterid);

            }

          

        }
    }

    private void LoadReport(string reporttype, string masterid)
    {
        if (reporttype == "1") //cutting
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { cuttingid = Convert.ToInt64(masterid)}).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rpt_CuttingDetl.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "2") //cutting
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { cuttingid = Convert.ToInt64(masterid) }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rpt_OtherCuttingDetl.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "3") //cutting
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { cuttingid = Convert.ToInt64(masterid) }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rpt_CuttingDetl_final.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "4") //cutting
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetCuttingInfo(new rpt_GetCuttingInfoEntity { cuttingid = Convert.ToInt64(masterid) }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rpt_OtherCuttingDetl_final.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }

        else if (reporttype == "5") //10%
        {
            var year =Convert.ToInt64( Request.QueryString["year"].ToString());
            var month = Convert.ToInt64(Request.QueryString["month"].ToString());



            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummary(new rpt_CuttingSummaryEntity { PayAllceID = 3,Year=year,MonthID=month }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_RegCuttingSummary.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "6") //10%
        {
            var year = Convert.ToInt64(Request.QueryString["year"].ToString());
            var month = Convert.ToInt64(Request.QueryString["month"].ToString());



            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummary(new rpt_CuttingSummaryEntity { PayAllceID = 4, Year = year, MonthID = month }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_RegCuttingSummary.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (reporttype == "7") //10%
        {
            var year = Convert.ToInt64(Request.QueryString["year"].ToString());
            var month = Convert.ToInt64(Request.QueryString["month"].ToString());



            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CuttingSummary(new rpt_CuttingSummaryEntity { PayAllceID = 5, Year = year, MonthID = month }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_RegCuttingSummary.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }



    }
}
