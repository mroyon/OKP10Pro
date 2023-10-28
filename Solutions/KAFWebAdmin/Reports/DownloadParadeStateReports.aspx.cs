using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using Microsoft.Reporting.WebForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class DownloadParadeStateReports : Page
{
    public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string searchText = string.Empty;

            string reporttype = "", masterid = "";

            if (Request.QueryString["reporttype"] != null)
            {
                reporttype = Request.QueryString["reporttype"].ToString();
                masterid = Request.QueryString["masterid"].ToString();
                LoadReport(reporttype, masterid);

            }

          

        }
    }

    private void LoadReport(string reporttype, string masterid)
    {
        if (reporttype == "1") //paradestate_report
        {
            var manpowerstateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("manpowerstateid", masterid).ToString());

            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_ManpoewrState(new rpt_ManpoewrStateEntity { ManpowerStateID = Convert.ToInt64(manpowerstateid) }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ManpowerState.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();            }
        }
       


    }
}
