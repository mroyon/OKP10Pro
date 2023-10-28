using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using Microsoft.Reporting.WebForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class DownloadReport : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string searchText = string.Empty;

            string letterstatus = "", masterid = "";

            if (Request.QueryString["letterstatus"] != null)
            {
                letterstatus = Request.QueryString["letterstatus"].ToString();
                masterid = Request.QueryString["masterid"].ToString();
                LoadReport(letterstatus, masterid);

            }

          

        }
    }

    private void LoadReport(string letterstatus, string masterid)
    {
        if (letterstatus == "1") //replacement
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().Get_KAF_GetReplacementListByREplacementID(new KAF_GetReplacementListByREplacementIDEntity { ReplacementID = Convert.ToInt64(masterid),IsAll=1 }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "2") //replacement passport
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetReplacementPassportInfo(new rpt_GetReplacementPassportInfoEntity { RepPassportID = Convert.ToInt64(masterid)}).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplPassportReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }

        else if (letterstatus == "3" && Request.QueryString["demandtype"] !=null) //visa demand
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetRepPassportListByRepPassportID(new KAF_GetRepPassportListByRepPassportIDEntity { DemandID = Convert.ToInt64(masterid),DemandTypeID=Convert.ToInt64(Request.QueryString["demandtype"].ToString()), IsAll = 5 }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "4") //visa issue
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_issueofvisaandpta(new rpt_issueofvisaandptaEntity { VisaIssueID = Convert.ToInt64(masterid) }).ToList();

            if (list.Count > 0)
            {
                if(list[0].DemandType==1)
                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_issueofvisaandpta_replacement.rdlc");
                else
                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_issueofvisaandpta_newdemand.rdlc");

                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "5") //visa sent
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_visareceivedpersonnel(new rpt_visareceivedpersonnelEntity { VisaSentID = Convert.ToInt64(masterid)}).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_visareceived.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "6") //pta demand
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetVisaSentListByVisaSentID(new KAF_GetVisaSentListByVisaSentIDEntity { PTIID = Convert.ToInt64(masterid), IsAll = 5 }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "7") //pta received
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetPTADemandListByPTADemandID(new KAF_GetPTADemandListByPTADemandIDEntity { PTARecivedID = Convert.ToInt64(masterid), IsAll = 5 }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "8") //flight ingo
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetPTAReceivedListByPTAReceiveID(new KAF_GetPTAReceivedListByPTAReceiveIDEntity { FlightID = Convert.ToInt64(masterid), IsAll = 5 }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "9") //arrival
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_arrivalreport(new rpt_arrivalreportEntity { ArrivalID = Convert.ToInt64(masterid) }).ToList();

            if (list.Count > 0)
            {
                if (list[0].DemandType == 1)
                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_arrivalreport_replacement.rdlc");
                else
                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_arrivalreport_newdemand.rdlc");

                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "10") //flight canceled
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetPTAReceivedListByPTAReceiveID(new KAF_GetPTAReceivedListByPTAReceiveIDEntity { FlightID = Convert.ToInt64(masterid), IsAll = 7 }).Where(p=>p.IsCancel==true).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "11") //flight reissue
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetFlightListByFlightID(new KAF_GetFlightListByFlightIDEntity { FlightID = Convert.ToInt64(masterid), IsAll = 4 }).ToList();

            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }

        else if (letterstatus == "13") //new demand
        {
           var list= KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_newdemanddetails(new rpt_newdemanddetailsEntity { NewDemandID = Convert.ToInt64(masterid) }).ToList();
            if (list.Count > 0)
            {

                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_newdemanddetails.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
        }
        else if (letterstatus == "14") //new demand passport
        {
            var objList = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll_Ext(new hr_demanddetlpassportEntity { letterno=Request.QueryString["letterno"],newdemandid = Convert.ToInt64(masterid),isall=1}).Where(p=>p.passportno!=null && p.passportno.Length>0).ToList();
          
            if (objList != null && objList.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplacementReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", objList);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }

        }

    }
}
