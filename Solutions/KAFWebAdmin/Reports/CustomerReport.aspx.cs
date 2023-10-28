using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using Microsoft.Reporting.WebForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CustomerReport : Page
{
    List<KAF_GetProfileInfoEntity> objProfilList = new List<KAF_GetProfileInfoEntity>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string searchText = string.Empty;

            string reporttype = "", passportno = "", militaryno = "", letterno = "", letterid = "";

            if (Request.QueryString["reporttype"] != null)
            {
                reporttype = Request.QueryString["reporttype"].ToString();
                if (Convert.ToInt32(reporttype) != 11)
                {
                    if (reporttype == "1")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "2")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                        militaryno = Request.QueryString["militaryno"];
                    }
                    else if (reporttype == "3")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "4")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "5")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "6")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "7")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "8")
                    {
                        passportno = Request.QueryString["passportno"];
                        letterno = Request.QueryString["letterno"];
                        letterid = Request.QueryString["letterid"];
                    }
                    else if (reporttype == "9")
                    {
                        passportno = Request.QueryString["passportno"];
                        militaryno = Request.QueryString["militaryno"];
                        letterno = Request.QueryString["statuscol"];
                    }
                    else if (reporttype == "10")
                    {
                        passportno = Request.QueryString["passportno"];
                        militaryno = Request.QueryString["militaryno"];
                    }
                    else if (reporttype == "12")
                    {
                        passportno = Request.QueryString["okpid"];
                       
                    }

                    LoadReport(reporttype, passportno, letterno, militaryno, letterid);
                }
                else
                {
                    string fromdate = "", todate = "";
                    fromdate = Request.QueryString["fromdate"];
                    todate = Request.QueryString["todate"];
                    LoadReport(reporttype, fromdate, todate);

                }


            }


        }
    }

    private void LoadReport(string reporttype, string fromdate, string todate)
    {
        clsPrivateKeys objutil = new clsPrivateKeys();

        if (reporttype == "11")
        {


            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_passportheldbyspab(new rpt_passportheldbyspabEntity { FromDate = objutil.getDateFromString(fromdate), ToDate = objutil.getDateFromString(todate) }).ToList();

            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_spabpassportheld_replacement.rdlc");


                CustomerListReportViewer.LocalReport.EnableExternalImages = true;

                //ReportParameter parameter = new ReportParameter("parUploadFolder", imagePath);
                //CustomerListReportViewer.LocalReport.SetParameters(parameter);

                ReportDataSource rdc = new ReportDataSource("DataSet1", list);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }

        }
    }

    private void LoadReport(string reporttype, string passportno, string letterno, string militaryno, string letterid)
    {
        if (reporttype == "1")
        {
            //var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetNewDemandInfo(new KAF_GetNewDemandInfoEntity { NewDemandID = Convert.ToInt64(letterid), DemandLetterNo = letterno, PassportNo = passportno }).ToList();
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_newdemanddetails(new rpt_newdemanddetailsEntity { NewDemandID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_newdemanddetails.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "2")
        {
            //var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetReplacementInfo(new KAF_GetReplacementInfoEntity { ReplacementID = Convert.ToInt64(letterid), ReplacementLetterNo = letterno, PassportNo = passportno }).ToList();
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_GetReplacementPassportInfo(new rpt_GetReplacementPassportInfoEntity { RepPassportID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_ReplPassportReport.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "3")
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_issueofvisaandpta(new rpt_issueofvisaandptaEntity { VisaIssueID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_issueofvisaandpta_newdemand.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "4")
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_issueofvisaandpta(new rpt_issueofvisaandptaEntity { VisaIssueID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_issueofvisaandpta_replacement.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "5")
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_visareceivedpersonnel(new rpt_visareceivedpersonnelEntity { VisaSentID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_visareceived.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "6")
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_arrivalreport(new rpt_arrivalreportEntity { ArrivalID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_arrivalreport_newdemand.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "7")
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_arrivalreport(new rpt_arrivalreportEntity { ArrivalID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_arrivalreport_replacement.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "8")
        {
            var list = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_ptareceivedwithflightinfo(new rpt_ptareceivedwithflightinfoEntity { PTAReceivedID = Convert.ToInt64(letterid) }).ToList();
            if (list.Count > 0)
            {
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/rdlc_pta_demand.rdlc");
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DataSet1", list);

                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }
        }
        else if (reporttype == "9")
        {
            string strstatus = letterno;

            objProfilList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetProfileInfo(
                new KAF_GetProfileInfoEntity
                {
                    OKPID = Request.QueryString["okpid"] != "" ? Convert.ToInt64(Request.QueryString["okpid"]) : (Int64?)null,
                    PassportNo = passportno,
                    strStartus = strstatus,
                    MilNoKW = militaryno != null && militaryno.Length > 0 ? Convert.ToInt64(militaryno) : (Int64?)null,
                    BasePath=  System.Configuration.ConfigurationManager.AppSettings["DomainURL"].ToString()
        }
                ).ToList();

            //Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString())

            if (objProfilList.Count > 0)
            {
                //CustomerListReportViewer.LocalReport.DataSources.Clear();
                if ( !string.IsNullOrEmpty( militaryno))
                {
                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/ProfileAll.rdlc");
                    CustomerListReportViewer.LocalReport.DisplayName = "ProfileReport_" + DateTime.Now.ToString("ddMMyyyyhhmm");

                   
              
                }
                else
                {
                    CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/ProfileAllWithSummary.rdlc");
                    CustomerListReportViewer.LocalReport.DisplayName = "ProfileReport_" + DateTime.Now.ToString("ddMMyyyyhhmm");

                }
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                string imagePath = new Uri(Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString()) + objProfilList[0].ProfilePhoto).AbsoluteUri;
                //objProfilList[0].ProfilePhotoFilePath =Path.Combine(System.Configuration.ConfigurationManager.AppSettings["DomainURL"] ,objProfilList[0].ProfilePhotoFilePath);

                CustomerListReportViewer.LocalReport.EnableExternalImages = true;

                //ReportParameter parameter = new ReportParameter("parUploadFolder", imagePath);
                //CustomerListReportViewer.LocalReport.SetParameters(parameter);

                ReportDataSource rdc = new ReportDataSource("DataSet1", objProfilList.OrderBy(p => p.RankIDKW).ThenBy(p => p.FullName).ToList());
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);

                if (Request.QueryString["okpid"] != "")
                {
                    var okpsummary = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_OkpSummaryOkpwise(
                    new rpt_OkpSummaryOkpwiseEntity { okpid = Convert.ToInt64(Request.QueryString["okpid"]) }).ToList();
                    ReportDataSource rdc2 = new ReportDataSource("DataSet2", okpsummary);
                    CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);
                }
                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();

                CustomerListReportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessingEventHandler);
                CustomerListReportViewer.LocalReport.Refresh();

                //Warning[] warnings;
                //string[] streamIds;
                //string contentType;
                //string encoding;
                //string extension;

                //byte[] bytes = CustomerListReportViewer.LocalReport.Render("PDF", null, out contentType, out encoding, out extension, out streamIds, out warnings);

                //// Open generated PDF.
                //Response.Clear();
                //Response.Buffer = true;
                //Response.Charset = "";
                //Response.Cache.SetCacheability(HttpCacheability.NoCache);
                //Response.ContentType = contentType;
                //Response.BinaryWrite(bytes);
                //Response.Flush();
                //Response.End();

            }
            else
            {
                lblMessage.Text = "No Data Found";
            }

        }
        else if (reporttype == "10")
        {

            var newdemandinfolist = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetNewDemandInfo(new KAF_GetNewDemandInfoEntity { PassportNo = passportno, MilNoKW = militaryno != null && militaryno.Length > 0 ? Convert.ToInt64(militaryno) : (Int64?)null }).ToList().OrderByDescending(p => p.FlightID).Take(1).ToList();
            var replacementinfolist = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetReplacementInfo(new KAF_GetReplacementInfoEntity { NewPassportNo = passportno, MilNoKW = militaryno != null && militaryno.Length > 0 ? Convert.ToInt64(militaryno) : (Int64?)null }).ToList().OrderByDescending(p => p.FlightID).Take(1).ToList();
            string parhtml = "<div style='width:600px'>";

            var newdemandinfo = newdemandinfolist.OrderByDescending(p => p.FlightID).FirstOrDefault();
            var replacementinfo = replacementinfolist.OrderByDescending(p=>p.FlightID).FirstOrDefault();


            if (newdemandinfo != null)
            {
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/individualstat.rdlc");

                CustomerListReportViewer.LocalReport.EnableExternalImages = true;
                //parhtml += "<div>New Demand<div><div>" + "------------------------------------------------" + "</div>";
                //parhtml += "<div><b>Rank & Name : </b>" + newdemandinfo.RankName + " " + newdemandinfo.FullName + "</div>" +
                //            "<div><b>Passport Number : </b>" + newdemandinfo.PassportNo + " </div>" +
                //            "<div><b>Trade & OKP : </b>" + newdemandinfo.TradeName + " " + newdemandinfo.OkpName + "</div><div>" + "------------------------------------------------" + "</div>";

                if (newdemandinfo.VisaDemandID != null)
                {
                    newdemandinfolist[0].DemandLetterNo = "Visa Demand";
                    newdemandinfolist[0].VisaDemandLetterNo = "Done";
                }
                else
                {
                    newdemandinfolist[0].DemandLetterNo = "Visa Demand";
                    newdemandinfolist[0].VisaDemandLetterNo = "Not Done";
                }
                if (newdemandinfo.VisaIssueID != null)
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Visa Issue", VisaDemandLetterNo = "Done" });
                else
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Visa Issue", VisaDemandLetterNo = "Not Done" });

                if (newdemandinfo.VisaSentID != null)
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Visa Sent", VisaDemandLetterNo = "Done" });
                else
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Visa Sent", VisaDemandLetterNo = "Not Done" });

                if (newdemandinfo.PTADemandID != null)
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "PTA Demand", VisaDemandLetterNo = "Done" });
                else
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "PTA Demand", VisaDemandLetterNo = "Not Done" });

                if (newdemandinfo.PTIID != null)
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "PTA Received", VisaDemandLetterNo = "Done" });
                else
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "PTA Received", VisaDemandLetterNo = "Not Done" });


                if (newdemandinfo.FlightID != null)
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Flight Info", VisaDemandLetterNo = "Done" });
                else
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Flight Info", VisaDemandLetterNo = "Not Done" });

                if (newdemandinfo.ArrivallD != null)
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Arrival Info", VisaDemandLetterNo = "Done" });
                else
                    newdemandinfolist.Add(new KAF_GetNewDemandInfoEntity { DemandLetterNo = "Arrival Info", VisaDemandLetterNo = "Not Done" });


                //ReportParameter parameter = new ReportParameter("parhtml", parhtml);
                //CustomerListReportViewer.LocalReport.SetParameters(parameter);

                ReportDataSource rdc = new ReportDataSource("DataSet1", newdemandinfolist);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }
            else if (replacementinfo != null)
            {
                CustomerListReportViewer.LocalReport.DataSources.Clear();
                CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/individualstat_repl.rdlc");

                CustomerListReportViewer.LocalReport.EnableExternalImages = true;

               // newdemandinfolist = new List<KAF_GetNewDemandInfoEntity>(replacementinfolist.Cast<KAF_GetNewDemandInfoEntity>());

                //parhtml += "<div>Replacement<div><div>" + "------------------------------------------------" + "</div>";
                //parhtml += "<div><b>Rank & Name : </b>" + replacementinfo.RepKWRank + " " + replacementinfo.NewFullName + "</div>" +
                //            "<div><b>Passport Number : </b>" + replacementinfo.NewPassportNo + " </div>" +
                //            "<div><b>Trade & OKP : </b>" + replacementinfo.RepKWTradeName + " " + replacementinfo.RepOkpName + "</div><div>" + "------------------------------------------------" + "</div>";

                if (replacementinfo.VisaDemandID != null)
                {
                    replacementinfolist[0].LetterNo = "Visa Demand";
                    replacementinfolist[0].VisaDemandLetterNo = "Done";
                }
                else
                {
                    replacementinfolist[0].LetterNo = "Visa Demand";
                    replacementinfolist[0].VisaDemandLetterNo = "Not Done";
                }

                if (replacementinfo.VisaIssueID != null)
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Visa Issue", VisaDemandLetterNo = "Done" });
                else
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Visa Issue", VisaDemandLetterNo = "Not Done" });

                if (replacementinfo.VisaSentID != null)
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Visa Sent", VisaDemandLetterNo = "Done" });
                else
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Visa Sent", VisaDemandLetterNo = "Not Done" });

                if (replacementinfo.PTADemandID != null)
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "PTA Demand", VisaDemandLetterNo = "Done" });
                else
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "PTA Demand", VisaDemandLetterNo = "Not Done" });

                if (replacementinfo.PTIID != null)
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "PTA Received", VisaDemandLetterNo = "Done" });
                else
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "PTA Received", VisaDemandLetterNo = "Not Done" });


                if (replacementinfo.FlightID != null)
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Flight Info", VisaDemandLetterNo = "Done" });
                else
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Flight Info", VisaDemandLetterNo = "Not Done" });

                if (replacementinfo.ArrivallD != null)
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Arrival Info", VisaDemandLetterNo = "Done" });
                else
                    replacementinfolist.Add(new KAF_GetReplacementInfoEntity { LetterNo = "Arrival Info", VisaDemandLetterNo = "Not Done" });


                //ReportParameter parameter = new ReportParameter("parhtml", parhtml);
                //CustomerListReportViewer.LocalReport.SetParameters(parameter);

                ReportDataSource rdc = new ReportDataSource("DataSet1", replacementinfolist);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
            }

            else
            {
                lblMessage.Text = "No Data Found";
            }

        }
        else if (reporttype == "12")
        {



            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/ProfileStrengthSummary.rdlc");

            CustomerListReportViewer.LocalReport.DataSources.Clear();
            //string imagePath = new Uri(Server.MapPath("~/" + System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString()) + objProfilList[0].ProfilePhoto).AbsoluteUri;
            //objProfilList[0].ProfilePhotoFilePath =Path.Combine(System.Configuration.ConfigurationManager.AppSettings["DomainURL"] ,objProfilList[0].ProfilePhotoFilePath);

            CustomerListReportViewer.LocalReport.EnableExternalImages = true;
            var okpsummary = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_BMCStrengthSummary(
            new rpt_BMCStrengthSummaryEntity { okpid=!string.IsNullOrEmpty( passportno)? Convert.ToInt64(passportno):(long?)null }).ToList();
            ReportDataSource rdc2 = new ReportDataSource("DataSet1", okpsummary);
            CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);

            CustomerListReportViewer.LocalReport.Refresh();
            CustomerListReportViewer.DataBind();
            CustomerListReportViewer.LocalReport.Refresh();

            //CustomerListReportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessingEventHandler);
            //CustomerListReportViewer.LocalReport.Refresh();

        }


    }
    protected void LocalReport_SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
    {
        try
        {
            string reportpath = e.ReportPath;

            if (reportpath == "PersonalProfileSingle")
            {
               

                var hrbasicid = Convert.ToInt64(e.Parameters["hrbasicid"].Values.FirstOrDefault());

                if (objProfilList.Where(p => p.HRBasicID == hrbasicid).Count() > 0)
                {
                    var datasource = objProfilList.Where(p => p.HRBasicID == hrbasicid).ToList();

                    datasource[0].ProfilePhotoFilePath = System.Configuration.ConfigurationManager.AppSettings["ServerReportPath"] + datasource[0].ProfilePhotoFileName+ datasource[0].ProfilePhotoFileExtension;

                    e.DataSources.Add(new ReportDataSource("DataSet1", datasource));
                   

                  
                }
            }



        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
