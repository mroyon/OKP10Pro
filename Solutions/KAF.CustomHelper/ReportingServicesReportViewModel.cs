using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace KAF.CustomHelper.HelperClasses
{
    [Serializable]
    public class ReportingServicesReportViewModel
    {
        #region Constructor

        string ReportServerUser = System.Configuration.ConfigurationManager.AppSettings["reportserveruser"].ToString();
        string ReportServerPassword = System.Configuration.ConfigurationManager.AppSettings["reportserverpassword"].ToString();
        string ReportServerDomain = System.Configuration.ConfigurationManager.AppSettings["reportserverdomain"].ToString();

        public ReportingServicesReportViewModel(String reportPath, List<ReportParameter> Parameters)
        {
            ReportPath = reportPath;
            parameters = Parameters.ToArray();
            DataSourceList = new Dictionary<string, object>();
        }

        public ReportingServicesReportViewModel()
        {
        }

        #endregion Constructor


        public ReportServerCredentials ServerCredentials { get { return new ReportServerCredentials(ReportServerUser, ReportServerPassword, ReportServerDomain); } }
        public String ReportPath { get; set; }

        public Uri ReportServerURL
        {
            get { return new Uri(WebConfigurationManager.AppSettings["ReportServerUrl"]); }
        }

        public ReportParameter[] parameters { get; set; }
        private string UploadDirectory = HttpContext.Current.Server.MapPath("~/App_Data/UploadTemp/");
        private string TempDirectory = HttpContext.Current.Server.MapPath("~/tempFiles/");
        public Dictionary<string, object> DataSourceList { get; set; }
    }
}

