using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using Microsoft.Reporting.WebForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ParadeStateReport : Page
{
    List<KAF_GetProfileInfoEntity> objProfilList = new List<KAF_GetProfileInfoEntity>();
    clsPrivateKeys objutil = new clsPrivateKeys();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            string reporttype = "", passportno = "", militaryno = "", letterno = "", letterid = "";

            if (Request.QueryString["reporttype"] != null)
            {
                reporttype = Request.QueryString["reporttype"].ToString();
                
                LoadReport(reporttype);

            }


        }
    }

    
    private void LoadReport(string reporttype)
    {
       
        if (reporttype == "1")
        {
            DateTime? CurDate = objutil.getDateFromString(Request.QueryString["date"].ToString());

            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/DailyManpowerState.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();

            ReportParameter parameter = new ReportParameter("curdate", CurDate.Value.ToString("dd MMM yyyy"));
            CustomerListReportViewer.LocalReport.SetParameters(parameter);


            var Dataset1 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_OkpWiseManpowerState(
            new rpt_OkpWiseManpowerStateEntity
            {
                StateDate = CurDate
            }).ToList();

            if (Dataset1.Count > 0)
            {
                SetDefaultZero(Dataset1, null, null, null);

                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                var Dataset2 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_OkpWiseManpowerStateHeld(
               new rpt_OkpWiseManpowerStateHeldEntity
               {
                   StateDate = CurDate
               }).ToList();

                SetDefaultZero(null, Dataset2, null, null);

                ReportDataSource rdc2 = new ReportDataSource("DataSet2", Dataset2);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }

            //CustomerListReportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessingEventHandler);
            //CustomerListReportViewer.LocalReport.Refresh();

        }
        else if (reporttype == "2")
        {
            DateTime? CurDate = objutil.getDateFromString(Request.QueryString["date"].ToString());

            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/HeldStateCampWise.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();

         
            var Dataset1 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_CampWiseManpowerStateHeld(
            new rpt_CampWiseManpowerStateHeldEntity
            {
                StateDate = CurDate
            }).ToList();

            if (Dataset1.Count > 0)
            {
                SetDefaultZero(null, null, Dataset1, null);

                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }


        }
        else if (reporttype == "3")
        {
            rpt_LeaveInfoEntity objLeave = new rpt_LeaveInfoEntity();

            objLeave.LeaveStartFromDate = Request.QueryString["leavestartdatefrom"]!=null? objutil.getDateFromString(Request.QueryString["leavestartdatefrom"].ToString()):null;
            objLeave.LeaveStartToDate= Request.QueryString["leavestartdateto"]!=null?objutil.getDateFromString(Request.QueryString["leavestartdateto"].ToString()):null;

            objLeave.LeaveEndFromDate = Request.QueryString["leaveenddatefrom"]!=null? objutil.getDateFromString(Request.QueryString["leaveenddatefrom"].ToString()):null;
            objLeave.LeaveEndToDate = Request.QueryString["leaveenddateto"] != null ? objutil.getDateFromString(Request.QueryString["leaveenddateto"].ToString()):null;

            objLeave.LeaveReturnFromDate = Request.QueryString["leavereturndatefrom"] != null ? objutil.getDateFromString(Request.QueryString["leavereturndatefrom"].ToString()):null;
            objLeave.LeaveReturnToDate = Request.QueryString["leavereturndateto"] != null ? objutil.getDateFromString(Request.QueryString["leavereturndateto"].ToString()):null;

            objLeave.OkpID = Request.QueryString["okpid"] != null ? Convert.ToInt64(Request.QueryString["okpid"].ToString()) : (long?)null;
            objLeave.InLeave = Request.QueryString["InLeave"] != null ? true : (bool?)null;
            objLeave.LeaveTypeID = Request.QueryString["leavetypeid"] != null ? Convert.ToInt64(Request.QueryString["leavetypeid"].ToString()) : (long?)null;


            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/LeaveStateDetails.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();


            var Dataset1 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_LeaveInfo(objLeave).ToList();
            if (Dataset1.Count() > 0)
            {
                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }


        }
        else if (reporttype == "4")
        {
            rpt_HospitalInfoEntity objLeave = new rpt_HospitalInfoEntity();

            objLeave.AdmissionFromDate = Request.QueryString["admissiondatefrom"] != null ? objutil.getDateFromString(Request.QueryString["admissiondatefrom"].ToString()) : null;
            objLeave.AdmissionToDate = Request.QueryString["admissiondateto"] != null ? objutil.getDateFromString(Request.QueryString["admissiondateto"].ToString()) : null;

            objLeave.ReleaseFromDate = Request.QueryString["releasedatefrom"] != null ? objutil.getDateFromString(Request.QueryString["releasedatefrom"].ToString()) : null;
            objLeave.ReleaseToDate = Request.QueryString["releasedateto"] != null ? objutil.getDateFromString(Request.QueryString["releasedateto"].ToString()) : null;

            
            objLeave.OkpID = Request.QueryString["okpid"] != null ? Convert.ToInt64(Request.QueryString["okpid"].ToString()) : (long?)null;
            objLeave.CountryID = Request.QueryString["countryid"] != null ? Convert.ToInt64(Request.QueryString["countryid"].ToString()) : (long?)null;
            objLeave.IsAdmitted = Request.QueryString["Isadmitted"] != null ? true : (bool?)null;


            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/HospitalState.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();


            var Dataset1 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_HospitalInfo(objLeave).ToList();
            if (Dataset1.Count > 0)
            {
                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }


        }
        else if (reporttype == "5")
        {
            rpt_RepatriationInfoEntity objLeave = new rpt_RepatriationInfoEntity();

            objLeave.SODFromDate = Request.QueryString["soddatefrom"] != null ? objutil.getDateFromString(Request.QueryString["soddatefrom"].ToString()) : null;
            objLeave.SODToDate = Request.QueryString["soddateto"] != null ? objutil.getDateFromString(Request.QueryString["soddateto"].ToString()) : null;

            objLeave.FlightFromDate = Request.QueryString["flightdatefrom"] != null ? objutil.getDateFromString(Request.QueryString["flightdatefrom"].ToString()) : null;
            objLeave.FlightToDate = Request.QueryString["flightdateto"] != null ? objutil.getDateFromString(Request.QueryString["flightdateto"].ToString()) : null;

            objLeave.SalaryReceivedFromDate = Request.QueryString["lastsalaryreceivefrom"] != null ? objutil.getDateFromString(Request.QueryString["lastsalaryreceivefrom"].ToString()) : null;
            objLeave.SalaryReceivedToDate = Request.QueryString["lastsalaryreceiveto"] != null ? objutil.getDateFromString(Request.QueryString["lastsalaryreceiveto"].ToString()) : null;

            objLeave.RewardAvailFromDate = Request.QueryString["rewardavailfrom"] != null ? objutil.getDateFromString(Request.QueryString["rewardavailfrom"].ToString()) : null;
            objLeave.RewardAvailToDate = Request.QueryString["rewardavailto"] != null ? objutil.getDateFromString(Request.QueryString["rewardavailto"].ToString()) : null;

            objLeave.OkpID = Request.QueryString["okpid"] != null ? Convert.ToInt64(Request.QueryString["okpid"].ToString()) : (long?)null;
           

            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/RepatriationState.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();


            var Dataset1 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_RepatriationInfo(objLeave).ToList();
            if (Dataset1.Count > 0)
            {
                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }


        }
        else if (reporttype == "6")
        {
            rpt_DeploymentStateEntity objLeave = new rpt_DeploymentStateEntity();

          
            objLeave.OkpID = Request.QueryString["okpid"] != null ? Convert.ToInt64(Request.QueryString["okpid"].ToString()) : (long?)null;
            objLeave.DeployedSubUNitID = Request.QueryString["subunitid"] != null ? Convert.ToInt64(Request.QueryString["subunitid"].ToString()) : (long?)null;
            objLeave.DeployedCampID = Request.QueryString["campid"] != null ? Convert.ToInt64(Request.QueryString["campid"].ToString()) : (long?)null;
            objLeave.IsDeployed = Request.QueryString["IsDeployed"] != null ? true : (bool?)null;


            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/DeploymentState.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();


            var Dataset1 = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_DeploymentState(objLeave).ToList();
            if (Dataset1.Count > 0)
            {
                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }

        }
        else if (reporttype == "7")
        {
            DateTime? CurDate = objutil.getDateFromString(Request.QueryString["date"].ToString());
            Int64? okpid = Convert.ToInt64(Request.QueryString["okpid"].ToString());

            CustomerListReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/ParadeStateRDLC/rpt_OkpWiseManpowerStateHeldAuth.rdlc");
            CustomerListReportViewer.LocalReport.DataSources.Clear();

            ReportParameter parameter = new ReportParameter("curdate", CurDate.Value.ToString("dd MMM yyyy"));
            CustomerListReportViewer.LocalReport.SetParameters(parameter);


            var data = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_rpt_OkpWiseManpowerStateHeldAuth(
            new rpt_OkpWiseManpowerStateHeldAuthEntity
            {
                StateDate = CurDate,OkpID= okpid
            }).ToList();

            var Dataset1 = data.Where(p => p.seq <= 6).ToList();

            if (Dataset1.Count > 0)
            {

                SetDefaultZero(null, null, null, Dataset1);

                ReportDataSource rdc1 = new ReportDataSource("DataSet1", Dataset1);
                CustomerListReportViewer.LocalReport.DataSources.Add(rdc1);

                var Dataset2 = data.Where(p => p.seq > 6).ToList();

                SetDefaultZero(null, null, null, Dataset2);

                Session["rpt_OkpWiseManpowerStateHeldAuthEntity"] = Dataset2;

                //ReportDataSource rdc2 = new ReportDataSource("DataSet2", Dataset2);
                //CustomerListReportViewer.LocalReport.DataSources.Add(rdc2);

                CustomerListReportViewer.LocalReport.Refresh();
                CustomerListReportViewer.DataBind();
                CustomerListReportViewer.LocalReport.Refresh();

                CustomerListReportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessingEventHandler);
                CustomerListReportViewer.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "No Data Found";
            }

        }

    }

    private static void SetDefaultZero(List<rpt_OkpWiseManpowerStateEntity> Dataset1=null, List<rpt_OkpWiseManpowerStateHeldEntity> Dataset2 = null, List<rpt_CampWiseManpowerStateHeldEntity> Dataset3 = null, List<rpt_OkpWiseManpowerStateHeldAuthEntity> Dataset4 = null)
    {
        if (Dataset1 != null)
        {
            foreach (var obj in Dataset1)
            {
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    var Key = property.Name;
                    var Value = property.GetValue(obj, null);
                    var Type = property.GetType();
                    //Console.WriteLine("{0}={1}", Key, Value);
                    var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    if (type == typeof(Int64) || type == typeof(Int32))
                    {
                        if (Value == null)
                            property.SetValue(obj, 0);
                    }

                }
            }
        }
        else
        if (Dataset2 != null)
        {
            foreach (var obj in Dataset2)
            {
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    var Key = property.Name;
                    var Value = property.GetValue(obj, null);
                    var Type = property.GetType();
                    //Console.WriteLine("{0}={1}", Key, Value);
                    var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    if (type == typeof(Int64) || type == typeof(Int32))
                    {
                        if (Value == null)
                            property.SetValue(obj, 0);
                    }

                }
            }
        }
        else if (Dataset3 != null)
        {
            foreach (var obj in Dataset3)
            {
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    var Key = property.Name;
                    var Value = property.GetValue(obj, null);
                    var Type = property.GetType();
                    //Console.WriteLine("{0}={1}", Key, Value);
                    var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    if (type == typeof(Int64) || type == typeof(Int32))
                    {
                        if (Value == null)
                            property.SetValue(obj, 0);
                    }

                }
            }
        }
        else if (Dataset4 != null)
        {
            foreach (var obj in Dataset4)
            {
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    var Key = property.Name;
                    var Value = property.GetValue(obj, null);
                    var Type = property.GetType();
                    //Console.WriteLine("{0}={1}", Key, Value);
                    var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    if (type == typeof(Int64) || type == typeof(Int32))
                    {
                        if (Value == null)
                            property.SetValue(obj, 0);
                    }

                }
            }
        }
    }

    protected void LocalReport_SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
    {
        try
        {
            string reportpath = e.ReportPath;

            if (reportpath == "rpt_OkpWiseManpowerStateHeldAuth-sub")
            {
                if (Session["rpt_OkpWiseManpowerStateHeldAuthEntity"] != null)
                {
                    List<rpt_OkpWiseManpowerStateHeldAuthEntity> data =(List<rpt_OkpWiseManpowerStateHeldAuthEntity>) Session["rpt_OkpWiseManpowerStateHeldAuthEntity"];
                    e.DataSources.Add(new ReportDataSource("DataSet1", data));
                }
                   
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
