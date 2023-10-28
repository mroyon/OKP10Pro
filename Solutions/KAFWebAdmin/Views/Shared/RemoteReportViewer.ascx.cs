
using KAF.CustomHelper.HelperClasses;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETMVC_SSRS_Demo.Views.Shared
{
    public partial class RemoteReportViewer : System.Web.Mvc.ViewUserControl
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            // Required for report events to be handled properly.
            //reportViewer.ServerReport.ReportServerCredentials = new ReportServerCredentials();
            Context.Handler = Page;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportingServicesReportViewModel model = (ReportingServicesReportViewModel)Model;
                this.reportViewer.ServerReport.ReportServerCredentials = model.ServerCredentials;
                ReportParameter[] RptParameters = model.parameters;

                reportViewer.ServerReport.ReportPath = $"/{WebConfigurationManager.AppSettings["SSRSReportsFolder"]}/{model.ReportPath}";
                reportViewer.ServerReport.ReportServerUrl = model.ReportServerURL;

                if (RptParameters.Count() > 0)
                    this.reportViewer.ServerReport.SetParameters(RptParameters);
                this.reportViewer.ServerReport.Refresh();
            }
        }
    }
}