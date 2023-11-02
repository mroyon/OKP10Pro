
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
    public class RPTMAllReportInfoController : BaseController
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
        public async Task<ActionResult> RPTMAllReportInfo()
        {

            return View("RPTMAllReportInfoLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTMCuttingReportIndividual()
        {

            return View("RPTMCuttingIndividualRptLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTMCuttingReportInfo()
        {

            return View("RPTMCuttingReportInfoLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTMProcessReportInfo()
        {

            return View("RPTMProcessReportLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DateExpireReport()
        {

            return View("DateExpireReport");
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

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTMUserProfileReportInfo()
        {
            SecurityCapsule sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

            ViewBag.okpid = sec.okpid;

            return View("RPTMUserProfileReportInfoLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTMAllStrengthReportInfo()
        {

            return View("RPTMAllOkpStrengthLanding");
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTUserTrackingProfile()
        {
            var list = GetTableList();
            return View("RPTUserTrackingProfileLanding", list);
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTUserTrackingSetup()
        {
            var list = GetTableList();
            return View("RPTUserTrackingSetupLanding", list);
        }

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> RPTDynamicReport()
        {
            SecurityCapsule sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

            ViewBag.okpid = sec.okpid;
            return View("RPTDynamicReportLanding");
        }

        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GenerateDynamicReport(rpt_TableNameEntity input)
        {
            try
            {
                var list = GetDynamicData(input);
                ViewBag.list = list;
                return PartialView("_GenerateReport");
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        private DataTable GetDynamicData(rpt_TableNameEntity input)
        {
            DataTable dt = new DataTable();

            try
            {

                string strCols = "", strwhere = "";

                if (!string.IsNullOrEmpty(input.strWhere))
                    strwhere = input.strWhere.Substring(0, input.strWhere.LastIndexOf("AND"));

                if (!string.IsNullOrEmpty(input.strColumns))
                    strCols = input.strColumns.Substring(0, input.strColumns.LastIndexOf(","));

                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

                List<string> listacolumnas = new List<string>();
                using (SqlConnection connection = new SqlConnection(conString))
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = @"
                        " + (strCols.Length > 0 ? "SELECT " + strCols : "") + @"

                                        FROM   hr_basicprofile
                       LEFT OUTER JOIN hr_svcinfo
                                    ON hr_basicprofile.hrbasicid = hr_svcinfo.hrbasicid
                       left outer join (
					   select HrBasicID,max(RepatriationID) as MaxRepatID from Hr_RepatriationInfo group by HrBasicID 
					   ) maxrepat
					   on maxrepat.HrBasicID=Hr_SvcInfo.HrBasicID 

					   left outer join Hr_RepatriationInfo
					   on Hr_RepatriationInfo.RepatriationID=maxrepat.MaxRepatID 
                       LEFT OUTER JOIN stp_organization
                                    ON hr_svcinfo.organizationkey =
                                       stp_organization.organizationkey
                       LEFT OUTER JOIN stp_organizationentity
                                    ON hr_svcinfo.entitykey = stp_organizationentity.entitykey
                       LEFT OUTER JOIN gen_arms
                                    ON hr_svcinfo.armsid = gen_arms.armsid
                       LEFT OUTER JOIN gen_okp
                                    ON hr_svcinfo.OkpID = gen_okp.okpid
                       LEFT OUTER JOIN gen_rank AS rnk_kw
                                    ON hr_svcinfo.rankidkw = rnk_kw.rankid
                       LEFT OUTER JOIN gen_rank AS rnk_bd
                                    ON hr_svcinfo.rankidbd = rnk_bd.rankid
                       LEFT OUTER JOIN Gen_RankType AS rnk_type_kw
                                    ON rnk_type_kw.RankTypeID = rnk_kw.RankTypeID
                       LEFT OUTER JOIN Gen_RankType AS rnk_type_bd
                                    ON rnk_type_bd.RankTypeID = rnk_bd.RankTypeID
                       LEFT OUTER JOIN gen_trade AS trd_kw
                                    ON hr_svcinfo.tradeidkw = trd_kw.tradeid
                       LEFT OUTER JOIN gen_trade AS trd_bd
                                    ON hr_svcinfo.tradeidbd = trd_bd.tradeid
                       left outer join (
					   select HrBasicID,max(HrPersonalInfoID) as MaxHrPersonalInfoID from hr_personalinfo group by HrBasicID 
					   ) maxpersonalinfo
					   on maxpersonalinfo.HrBasicID=Hr_SvcInfo.HrBasicID 

					   left outer join hr_personalinfo
					   on hr_personalinfo.HrPersonalInfoID=maxpersonalinfo.MaxHrPersonalInfoID 
                       LEFT OUTER JOIN gen_bloodgroup
                                    ON hr_personalinfo.bloodgroupid =
                                       gen_bloodgroup.bloodgroupid
                       LEFT OUTER JOIN gen_religion
                                    ON hr_personalinfo.religionid = gen_religion.religionid
                       LEFT OUTER JOIN gen_maritalstatus
                                    ON hr_personalinfo.maritalstatusid =
                                       gen_maritalstatus.maritalstatusid
                       LEFT OUTER JOIN gen_country
                                    ON hr_personalinfo.nationalityid = gen_country.countryid
                       LEFT OUTER JOIN gen_gender
                                    ON hr_personalinfo.genderid = gen_gender.genderid
                       LEFT OUTER JOIN gen_building
                                    ON hr_personalinfo.buildingid = gen_building.buildingid
                       LEFT OUTER JOIN gen_divisiondistrict AS currdiv
                                    ON hr_personalinfo.bdcurdivid = currdiv.districtid
                       LEFT OUTER JOIN gen_divisiondistrict AS currcity
                                    ON hr_personalinfo.bdcurcityid = currcity.districtid
                       LEFT OUTER JOIN gen_thana AS CurThana
                                    ON hr_personalinfo.bdcurthanaid = CurThana.thanaid
                       LEFT OUTER JOIN gen_divisiondistrict AS perdiv
                                    ON hr_personalinfo.bdperdivid = perdiv.districtid
                       LEFT OUTER JOIN gen_divisiondistrict AS percity
                                    ON hr_personalinfo.bdpercityid = percity.districtid
                       LEFT OUTER JOIN gen_thana AS perThana
                                    ON hr_personalinfo.bdperthanaid = perThana.thanaid
                       LEFT OUTER JOIN gen_govcity AS KWGov
                                    ON hr_personalinfo.kwgovid = KWGov.cityid
                        left outer join (
					   select HrBasicID,max(PassportID) as MaxPassportID from Hr_PassportInfo group by HrBasicID 
					   ) maxPassportInfo
					   on maxPassportInfo.HrBasicID=Hr_SvcInfo.HrBasicID 

					   left outer join Hr_PassportInfo
					   on Hr_PassportInfo.PassportID=maxPassportInfo.MaxPassportID 		
                       LEFT OUTER JOIN gen_govcity AS KWArea
                                    ON hr_personalinfo.kwareaid = KWArea.cityid " + (strwhere.Length > 0 ? " WHERE " + strwhere : "") +

                    " ORDER BY hr_svcinfo.rankidkw,hr_svcinfo.MilNoKW  ";
                    //   " order by r.UpdatedDate";

                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();

                }
            }
            catch (Exception es)
            {
                var str = es.ToString();
            }

            return dt;
        }

        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> getTableColumnsNames(rpt_TableNameEntity input)
        {
            try
            {
                var list = getFilteredTableColumnsNames(input.TableName);

                return PartialView("_TableColumns", list.Where(p => p.DATA_TYPE.ToLower() == "nvarchar").Take(1).ToList());
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> getColumnData(rpt_TableNameEntity input)
        {
            JsonResult result = new JsonResult();
            try
            {
                DataTable dt = new DataTable();

                var listreference = getTableReference(input.TableName);

                //if (listreference.Where(p => p.ColumnName == input.strColumns).ToList().Count == 0)
                //{
                dt = getspecificColData(input.TableName, input.strColumns);
                //}
                //else
                //{
                //    var firsttextcol = getAllClumnsByTableName(listreference.FirstOrDefault().Referenced_TableName);
                //    dt = getspecificColData(listreference.FirstOrDefault().Referenced_TableName, firsttextcol.Where(p=>p.DATA_TYPE.ToLower().Contains("varchar")).FirstOrDefault().COLUMN_NAME);
                //}

                result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, records = JsonConvert.SerializeObject(dt) }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }

            return result;
        }

        private List<rpt_TableReferenceInfo> getTableReference(string Tablename)
        {
            List<rpt_TableReferenceInfo> list_tablecolumn = new List<rpt_TableReferenceInfo>();
            DataTable dt = new DataTable();
            // string conString = "Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

            List<string> listacolumnas = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
                                        SELECT
	                                         tab1.name AS [TableName],
                                            col1.name AS [ColumnName],
                                            tab2.name AS [Referenced_TableName],
                                            col2.name AS [Referenced_Column],
	                                        (select  Col_name(object_id('" + Tablename + @"'),2)) as ReferencedTextColumn
                                        FROM sys.foreign_key_columns fkc
                                        INNER JOIN sys.objects obj
                                            ON obj.object_id = fkc.constraint_object_id
                                        INNER JOIN sys.tables tab1
                                            ON tab1.object_id = fkc.parent_object_id
                                        INNER JOIN sys.schemas sch
                                            ON tab1.schema_id = sch.schema_id
                                        INNER JOIN sys.columns col1
                                            ON col1.column_id = parent_column_id AND col1.object_id = tab1.object_id
                                        INNER JOIN sys.tables tab2
                                            ON tab2.object_id = fkc.referenced_object_id
                                        INNER JOIN sys.columns col2
                                            ON col2.column_id = referenced_column_id AND col2.object_id = tab2.object_id
	                                        where tab1.name = '" + Tablename + "'";
                connection.Open();

                dt.Load(command.ExecuteReader());
                connection.Close();


                list_tablecolumn = ConvertDataTable<rpt_TableReferenceInfo>(dt);
            }
            return list_tablecolumn;
        }

        private DataTable getspecificColData(String Table, string colname)
        {
            List<rpt_TableColumn> list_tablecolumn = new List<rpt_TableColumn>();
            DataTable dt = new DataTable();
            // string conString = "Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

            List<string> listacolumnas = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT " + getPrimaryColumn(Table) + " as ColID," + colname + " as ColText FROM " + Table + " ORDER BY " + colname;
                connection.Open();

                dt.Load(command.ExecuteReader());
                connection.Close();

            }
            return dt;
        }

        private string getPrimaryColumn(string tablename)
        {
            List<rpt_TableColumn> list_tablecolumn = new List<rpt_TableColumn>();
            DataTable dt = new DataTable();
            // string conString = "Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

            List<string> listacolumnas = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @" select C.COLUMN_NAME FROM  INFORMATION_SCHEMA.TABLE_CONSTRAINTS T  
                                        JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE C  
                                        ON C.CONSTRAINT_NAME=T.CONSTRAINT_NAME  
                                        WHERE  
                                        C.TABLE_NAME='" + tablename + "'" + @"  
                                        and T.CONSTRAINT_TYPE='PRIMARY KEY'  ";
                connection.Open();

                dt.Load(command.ExecuteReader());
                connection.Close();

            }
            return dt.Rows.Count > 0 ? dt.Rows[0][0].ToString() : "";
        }


        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GenerateReport(rpt_TableNameEntity input)
        {
            try
            {
                var list = GetData(input);
                ViewBag.list = list;
                return PartialView("_GenerateReport");
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        private DataTable GetData(rpt_TableNameEntity input)
        {
            DataTable dt = new DataTable();

            try
            {
                //string MainTablename = input.TableName + "_History";
                string WhereCondition_milid = "", strbasicid = "", WhereCondition_user = "", strwhere = "", strTablecolfilter = ""; ;
                string Tablename = input.TableName + "_History";
                //string strcoulmns = input.strColumns.Substring(0, input.strColumns.Length - 1);
                if (input.lonVal2 != null)
                {
                    var objSvc = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { militarynokw = input.lonVal2 }).SingleOrDefault();

                    if (objSvc != null)
                    {
                        strbasicid = objSvc.hrbasicid.ToString();
                    }
                }

                if (!string.IsNullOrEmpty(input.strModelPrimaryKey) && input.strModelPrimaryKey != "-99")
                {
                    strTablecolfilter = " " + getPrimaryColumn(input.TableName) + " =  " + input.strModelPrimaryKey + " ";
                }

                if (input.lonVal1 != null)
                {
                    WhereCondition_user = " ( UpdatedBy=" + input.lonVal1 + " ) ";
                }

                var liscols = getAllClumnsByTableName(Tablename);

                if (liscols.Where(p => p.COLUMN_NAME.ToLower() == "hrbasicid").ToList().Count == 1 && !string.IsNullOrEmpty(strbasicid))
                {
                    WhereCondition_milid = " HRBasicID = " + strbasicid + " ";
                }

                if (!string.IsNullOrEmpty(WhereCondition_milid) || !string.IsNullOrEmpty(WhereCondition_user) || !string.IsNullOrEmpty(input.strModelPrimaryKey))
                {
                    strwhere = "";

                    if (!string.IsNullOrEmpty(WhereCondition_milid))
                    {
                        strwhere += strwhere.Length > 0 ? " AND " + WhereCondition_milid : WhereCondition_milid;
                    }
                    if (!string.IsNullOrEmpty(WhereCondition_user))
                    {
                        strwhere += strwhere.Length > 0 ? " AND " + WhereCondition_user : WhereCondition_user;  //(string.IsNullOrEmpty(WhereCondition_milid) ? " " : " AND ") + WhereCondition_user;
                    }

                    if (!string.IsNullOrEmpty(input.strModelPrimaryKey) && input.strModelPrimaryKey != "-99")
                    {
                        strwhere += strwhere.Length > 0 ? " AND " + strTablecolfilter : strTablecolfilter;
                    }
                }

                if (input.FromDate1 != null && input.ToDate1 != null)
                {
                    strwhere += string.IsNullOrEmpty(strwhere) ? " (UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "' )" : " AND  (UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "')";
                }

                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

                List<string> listacolumnas = new List<string>();
                using (SqlConnection connection = new SqlConnection(conString))
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = @"select * from
                    (

                        SELECT  " + input.strColumns + @",case when UpdatedByUserName is null then CreatedByUserName else UpdatedByUserName end as UpdatedByUserName, 
						case when UpdatedByUserName is null then CreatedDate else UpdatedDate end as UpdatedDate 
                        FROM  " + Tablename +
                         (strwhere.Length > 0 ? " WHERE " + strwhere : strwhere) +

                        " UNION " +
                        "SELECT  " + input.strColumns + @",case when UpdatedByUserName is null then CreatedByUserName else UpdatedByUserName end as UpdatedByUserName, 
						case when UpdatedByUserName is null then CreatedDate else UpdatedDate end as UpdatedDate 
                        FROM  " + input.TableName + " " + (strwhere.Length > 0 ? " WHERE " + strwhere : strwhere) +

                    " )r " +
                    " order by r.UpdatedDate";

                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();


                }
            }
            catch (Exception es)
            {
                var str = es.ToString();
            }


            //DataTable dtRendered = GetSingleColumnChanges(dt);
            //DataView dv = new DataView();
            //dv = dtRendered.DefaultView;
            //dv.Sort = "TimeStamp ASC";

            //DataTable sortedfinal = dv.ToTable();
            return dt;
        }

        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GenerateServiceReport(rpt_TableNameEntity input)
        {
            try
            {
                var list = GetServiceData(input);
                ViewBag.list = list;
                return PartialView("_GenerateReport");
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        private string GetJoinText(string strcolumn)
        {
            if (strcolumn == "RankIDKW")
                return "r.MilNoKW,r.RankNameKW";
            else if (strcolumn == "EntityKey")
                return "r.MilNoKW,r.EntityName";
            else if (strcolumn == "OrganizationKey")
                return "r.MilNoKW,r.OrganizationName";
            else if (strcolumn == "ArmsID")
                return "r.MilNoKW,r.ArmsName";
            else if (strcolumn == "OkpID")
                return "r.MilNoKW,r.OkpName";
            else if (strcolumn == "RankIDBD")
                return "r.MilNoKW,r.RankNameBD";
            else if (strcolumn == "TradeIDBD")
                return "r.MilNoKW,r.TradeNameBD";
            else if (strcolumn == "GroupID")
                return "r.MilNoKW,r.GroupName";
            else if (strcolumn == "TradeIDKW")
                return "r.MilNoKW,r.TradeNameKW";
            else
                //strcolumn = "r." + strcolumn;
                return "r.MilNoKW";
        }

        private DataTable GetServiceData(rpt_TableNameEntity input)
        {
            DataTable dt = new DataTable();
            string strusername = "";
            try
            {
                //string MainTablename = input.TableName + "_History";
                string WhereCondition_milid = "", strbasicid = "", WhereCondition_user = "", WhereCondition_user2 = "", strwhere = "", strwhere2 = "", strTablecolfilter = ""; ;

                //string strcoulmns = input.strColumns.Substring(0, input.strColumns.Length - 1);
                if (input.lonVal2 != null)
                {
                    var objSvc = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { militarynokw = input.lonVal2 }).SingleOrDefault();

                    if (objSvc != null)
                    {
                        strbasicid = objSvc.hrbasicid.ToString();
                    }
                }

                if (input.lonVal1 != null)
                {
                    WhereCondition_user = " (Hr_SvcInfo_History.UpdatedBy=" + input.lonVal1 + " ) ";
                    WhereCondition_user2 = " (Hr_SvcInfo_History.UpdatedBy<>" + input.lonVal1 + " ) ";
                    strusername = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity { masteruserid = input.lonVal1 }).FirstOrDefault().username;
                }


                if (!string.IsNullOrEmpty(strbasicid))
                {
                    WhereCondition_milid = " Hr_SvcInfo_History.HRBasicID = " + strbasicid + " ";
                }

                if (!string.IsNullOrEmpty(WhereCondition_milid) || !string.IsNullOrEmpty(WhereCondition_user) || !string.IsNullOrEmpty(input.strModelPrimaryKey))
                {
                    strwhere = ""; strwhere2 = "";

                    if (!string.IsNullOrEmpty(WhereCondition_milid))
                    {
                        strwhere += strwhere.Length > 0 ? " AND " + WhereCondition_milid : WhereCondition_milid;
                    }
                    if (!string.IsNullOrEmpty(WhereCondition_user))
                    {
                        strwhere += strwhere.Length > 0 ? " AND " + WhereCondition_user : WhereCondition_user;  //(string.IsNullOrEmpty(WhereCondition_milid) ? " " : " AND ") + WhereCondition_user;
                    }

                    if (strwhere.Length > 0)
                        strwhere = " Where " + strwhere;

                    if (!string.IsNullOrEmpty(WhereCondition_milid))
                    {
                        strwhere2 += strwhere2.Length > 0 ? " AND " + WhereCondition_milid : WhereCondition_milid;
                    }
                    if (!string.IsNullOrEmpty(WhereCondition_user2))
                    {
                        strwhere2 += strwhere2.Length > 0 ? " AND " + WhereCondition_user2 : WhereCondition_user2;  //(string.IsNullOrEmpty(WhereCondition_milid) ? " " : " AND ") + WhereCondition_user;
                    }

                    if (strwhere2.Length > 0)
                        strwhere2 = " Where " + strwhere2;
                }

                if (input.FromDate1 != null && input.ToDate1 != null)
                {
                    strwhere += string.IsNullOrEmpty(strwhere) ? " (Hr_SvcInfo_History.UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "' )" : " AND  (Hr_SvcInfo_History.UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "')";
                }

                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

                List<string> listacolumnas = new List<string>();
                using (SqlConnection connection = new SqlConnection(conString))
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = @" select " + (input.strModelPrimaryKey == "ALLChanges" ? " r.* " : GetJoinText(input.strModelPrimaryKey.Replace("r.", ""))) + @",r.UpdatedByUserName,r.UpdatedDate from  
                                            (
                                            SELECT         
                                                HR_BasicProfile.HRBasicID,
                                               HR_BasicProfile.MilNoBD,        
                                               HR_BasicProfile.CivilID,        
    
                                               HR_BasicProfile.PassportNo,        

                                               HR_BasicProfile.FullName,        
  
                                               HR_BasicProfile.DateofBirth,   
  
                                              
   

                                              Hr_SvcInfo_History.UpdatedBy, 
                                             Hr_SvcInfo_History.UpdatedByUserName, 
                                             Hr_SvcInfo_History.UpdatedDate,
                                             Hr_SvcInfo_History.CreatedBy, 
                                             Hr_SvcInfo_History.CreatedByUserName, 
                                             Hr_SvcInfo_History.CreatedDate,   

 
                                              
                                               Hr_SvcInfo_History.MilNoKW,        
 
                                               Hr_SvcInfo_History.JoinDateKw,        
                                               Hr_SvcInfo_History.ExpectedRetireDateKw,  
   
                                               CASE WHEN Hr_SvcInfo_History.Status = 1 THEN 'Selected'
                                               WHEN Hr_SvcInfo_History.Status = 2 THEN 'Canceled'
                                               WHEN Hr_SvcInfo_History.Status = 3 THEN 'Active'
                                               WHEN Hr_SvcInfo_History.Status = 4 THEN 'Repatriated'
                                               WHEN Hr_SvcInfo_History.Status = 4 THEN 'Arrived'
                                               ELSE ''
                                               END AS StatusName,
                                               Stp_Organization.OrganizationName,
                                               Stp_OrganizationEntity.EntityName,
                                               Gen_Arms.ArmsName,
                                               Gen_Okp.OkpName,
                                               rnk_kw.RankName as RankNameKW,
                                               rnk_bd.RankName as RankNameBD,
                                               trd_kw.TradeName as TradeNameKW,
                                               trd_bd.TradeName as TradeNameBD,

                                               CASE WHEN Hr_SvcInfo_History.GroupID = 1 THEN 'Technical'
                                               ELSE 'Support' END AS GroupName
 

                                              FROM HR_BasicProfile 
                                              left outer join Hr_SvcInfo_History on HR_BasicProfile.HRBasicID=Hr_SvcInfo_History.HRBasicID
  
                                              left outer join Stp_Organization on Hr_SvcInfo_History.OrganizationKey = Stp_Organization.OrganizationKey
                                              left outer join Stp_OrganizationEntity on Hr_SvcInfo_History.EntityKey = Stp_OrganizationEntity.EntityKey
                                              left outer join Gen_Arms on Hr_SvcInfo_History.ArmsID = Gen_Arms.ArmsID
                                              left outer join Gen_Okp on Hr_SvcInfo_History.OkpID = Gen_Okp.OkpID
                                              left outer join Gen_Rank rnk_kw on Hr_SvcInfo_History.RankIDKW = rnk_kw.RankID
                                              left outer join Gen_Rank rnk_bd on Hr_SvcInfo_History.RankIDBD = rnk_bd.RankID
                                              left outer join Gen_Trade trd_kw on Hr_SvcInfo_History.TradeIDKW = trd_kw.TradeID
                                              left outer join Gen_Trade trd_bd on Hr_SvcInfo_History.TradeIDBD = trd_bd.TradeID
                                               " + strwhere + @"


                                              union 

                                              SELECT         
                                               HR_BasicProfile.HRBasicID,
                                               HR_BasicProfile.MilNoBD,        
                                               HR_BasicProfile.CivilID,        
    
                                               HR_BasicProfile.PassportNo,        

                                               HR_BasicProfile.FullName,        
  
                                               HR_BasicProfile.DateofBirth,

                                                Hr_SvcInfo.UpdatedBy, 
                                             Hr_SvcInfo.UpdatedByUserName, 
                                             Hr_SvcInfo.UpdatedDate,
                                             Hr_SvcInfo.CreatedBy, 
                                             Hr_SvcInfo.CreatedByUserName, 
                                             Hr_SvcInfo.CreatedDate,   

                                         
                                               Hr_SvcInfo.MilNoKW,        
 
                                               Hr_SvcInfo.JoinDateKw,        
                                               Hr_SvcInfo.ExpectedRetireDateKw,  
   
                                               CASE WHEN Hr_SvcInfo.Status = 1 THEN 'Selected'
                                               WHEN Hr_SvcInfo.Status = 2 THEN 'Canceled'
                                               WHEN Hr_SvcInfo.Status = 3 THEN 'Active'
                                               WHEN Hr_SvcInfo.Status = 4 THEN 'Repatriated'
                                               WHEN Hr_SvcInfo.Status = 4 THEN 'Arrived'
                                               ELSE ''
                                               END AS StatusName,
                                               Stp_Organization.OrganizationName,
                                               Stp_OrganizationEntity.EntityName,
                                               Gen_Arms.ArmsName,
                                               Gen_Okp.OkpName,
                                               rnk_kw.RankName as RankNameKW,
                                               rnk_bd.RankName as RankNameBD,
                                               trd_kw.TradeName as TradeNameKW,
                                               trd_bd.TradeName as TradeNameBD,

                                               CASE WHEN Hr_SvcInfo.GroupID = 1 THEN 'Technical'
                                               ELSE 'Support' END AS GroupName
 

                                              FROM HR_BasicProfile 
                                              left outer join Hr_SvcInfo on HR_BasicProfile.HRBasicID=Hr_SvcInfo.HRBasicID
  
                                              left outer join Stp_Organization on Hr_SvcInfo.OrganizationKey = Stp_Organization.OrganizationKey
                                              left outer join Stp_OrganizationEntity on Hr_SvcInfo.EntityKey = Stp_OrganizationEntity.EntityKey
                                              left outer join Gen_Arms on Hr_SvcInfo.ArmsID = Gen_Arms.ArmsID
                                              left outer join Gen_Okp on Hr_SvcInfo.OkpID = Gen_Okp.OkpID
                                              left outer join Gen_Rank rnk_kw on Hr_SvcInfo.RankIDKW = rnk_kw.RankID
                                              left outer join Gen_Rank rnk_bd on Hr_SvcInfo.RankIDBD = rnk_bd.RankID
                                              left outer join Gen_Trade trd_kw on Hr_SvcInfo.TradeIDKW = trd_kw.TradeID
                                              left outer join Gen_Trade trd_bd on Hr_SvcInfo.TradeIDBD = trd_bd.TradeID
                                               " + strwhere.ToLower().Replace("_history", "") + @"

union

SELECT         
                                                HR_BasicProfile.HRBasicID,
                                               HR_BasicProfile.MilNoBD,        
                                               HR_BasicProfile.CivilID,        
    
                                               HR_BasicProfile.PassportNo,        

                                               HR_BasicProfile.FullName,        
  
                                               HR_BasicProfile.DateofBirth,   
  
                                              
   

                                              Hr_SvcInfo_History.UpdatedBy, 
                                             Hr_SvcInfo_History.UpdatedByUserName, 
                                             Hr_SvcInfo_History.UpdatedDate,
                                             Hr_SvcInfo_History.CreatedBy, 
                                             Hr_SvcInfo_History.CreatedByUserName, 
                                             Hr_SvcInfo_History.CreatedDate,   

 
                                              
                                               Hr_SvcInfo_History.MilNoKW,        
 
                                               Hr_SvcInfo_History.JoinDateKw,        
                                               Hr_SvcInfo_History.ExpectedRetireDateKw,  
   
                                               CASE WHEN Hr_SvcInfo_History.Status = 1 THEN 'Selected'
                                               WHEN Hr_SvcInfo_History.Status = 2 THEN 'Canceled'
                                               WHEN Hr_SvcInfo_History.Status = 3 THEN 'Active'
                                               WHEN Hr_SvcInfo_History.Status = 4 THEN 'Repatriated'
                                               WHEN Hr_SvcInfo_History.Status = 4 THEN 'Arrived'
                                               ELSE ''
                                               END AS StatusName,
                                               Stp_Organization.OrganizationName,
                                               Stp_OrganizationEntity.EntityName,
                                               Gen_Arms.ArmsName,
                                               Gen_Okp.OkpName,
                                               rnk_kw.RankName as RankNameKW,
                                               rnk_bd.RankName as RankNameBD,
                                               trd_kw.TradeName as TradeNameKW,
                                               trd_bd.TradeName as TradeNameBD,

                                               CASE WHEN Hr_SvcInfo_History.GroupID = 1 THEN 'Technical'
                                               ELSE 'Support' END AS GroupName
 

                                              FROM HR_BasicProfile 
                                              left outer join Hr_SvcInfo_History on HR_BasicProfile.HRBasicID=Hr_SvcInfo_History.HRBasicID
  
                                              left outer join Stp_Organization on Hr_SvcInfo_History.OrganizationKey = Stp_Organization.OrganizationKey
                                              left outer join Stp_OrganizationEntity on Hr_SvcInfo_History.EntityKey = Stp_OrganizationEntity.EntityKey
                                              left outer join Gen_Arms on Hr_SvcInfo_History.ArmsID = Gen_Arms.ArmsID
                                              left outer join Gen_Okp on Hr_SvcInfo_History.OkpID = Gen_Okp.OkpID
                                              left outer join Gen_Rank rnk_kw on Hr_SvcInfo_History.RankIDKW = rnk_kw.RankID
                                              left outer join Gen_Rank rnk_bd on Hr_SvcInfo_History.RankIDBD = rnk_bd.RankID
                                              left outer join Gen_Trade trd_kw on Hr_SvcInfo_History.TradeIDKW = trd_kw.TradeID
                                              left outer join Gen_Trade trd_bd on Hr_SvcInfo_History.TradeIDBD = trd_bd.TradeID
                                               " + strwhere2 + @"
                                               )r ";

                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();

                }
            }
            catch (Exception es)
            {
                var str = es.ToString();
            }
            DataView dv = new DataView();

            //dv.Sort = "UpdatedDate ASC";


            if (input.strModelPrimaryKey == "ALLChanges")
            {

                dv = new DataView();
                dv = dt.DefaultView;
                dv.Sort = "HrBasicID ASC,UpdatedDate ASC";

                DataTable dtRendered = GetDesiserOutput(dv.ToTable());

                dv = new DataView();
                dv = dtRendered.DefaultView;
                dv.Sort = "TimeStamp ASC";

                if (input.lonVal1 != null)
                {

                    dv.RowFilter = "User='" + strusername + "'";

                }

            }
            else
            {

                dv = new DataView();
                dv = dt.DefaultView;
                dv.Sort = "MilNoKW ASC,UpdatedDate ASC";
                DataTable dtRendered = GetSingleColumnChanges(dv.ToTable());
                dv = new DataView();
                dv = dtRendered.DefaultView;
                dv.Sort = "TimeStamp ASC";
            }


            DataTable sortedfinal = dv.ToTable();

            return sortedfinal;
        }

        private DataTable GetSingleColumnChanges(DataTable usertable)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MilNoKW");
            dt.Columns.Add("User");
            dt.Columns.Add("Activity");



            DataColumn colDateTime = new DataColumn("TimeStamp");
            colDateTime.DataType = System.Type.GetType("System.DateTime");
            dt.Columns.Add(colDateTime);

            //dt.Columns.AddRange(new DataColumn[] { dc1, dc2, dc3 });

            for (int i = 1; i < usertable.Rows.Count; i++)
            {
                string stractiviity = "";
                DataRow dr = dt.NewRow();
                try
                {
                    if (usertable.Rows[i][1].ToString() != usertable.Rows[i - 1][1].ToString() &&
                        usertable.Rows[i][0].ToString() == usertable.Rows[i - 1][0].ToString())
                    {
                        dr["Activity"] = usertable.Columns[1].ColumnName + ": <b style='color:red'>" + usertable.Rows[i - 1][1].ToString() + "</b>  ===>  <b style='color:green'>" + usertable.Rows[i][1].ToString() + "</b>";
                        dr["User"] = usertable.Rows[i]["UpdatedByUserName"].ToString();
                        dr["TimeStamp"] = usertable.Rows[i]["UpdatedDate"].ToString();
                        dr["MilNoKW"] = usertable.Rows[i][0].ToString();
                        dt.Rows.Add(dr);

                    }

                }
                catch (Exception es)
                {
                    var str = es.ToString();
                }



            }

            return dt;
        }

        private DataTable GetDesiserOutput(DataTable usertable)
        {
            DataTable dt = new DataTable();

            DataColumn colDateTime = new DataColumn("TimeStamp");
            colDateTime.DataType = System.Type.GetType("System.DateTime");
            dt.Columns.Add(colDateTime);
            dt.Columns.Add("User");
            dt.Columns.Add("MilNo");
            dt.Columns.Add("Activity");



            for (int i = 0; i < usertable.Rows.Count; i++)
            {
                string stractiviity = "";
                DataRow dr = dt.NewRow();
                try
                {
                    if (usertable.Rows[i]["UpdatedDate"] != null)
                    {
                        dr["TimeStamp"] = Convert.ToDateTime(usertable.Rows[i]["UpdatedDate"]);
                        dr["User"] = usertable.Rows[i]["UpdatedByUserName"].ToString();
                        dr["MilNo"] = usertable.Rows[i]["MilNoKW"].ToString();

                        if (i > 0)
                            stractiviity = GetUserChangeInfo(usertable, i);


                        if (!string.IsNullOrEmpty(stractiviity))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendFormat("{0}", stractiviity);
                            StringWriter tw = new StringWriter(sb);
                            HtmlTextWriter hw = new HtmlTextWriter(tw);

                            //ctrl.RenderControl(hw);

                            dr["Activity"] = sb.ToString(); ;
                            dt.Rows.Add(dr);
                        }
                    }
                    else
                    {
                        dr["TimeStamp"] = Convert.ToDateTime(usertable.Rows[i]["CreatedDate"]);
                        dr["User"] = usertable.Rows[i]["CreatedByUserName"].ToString();
                        dr["MilNo"] = usertable.Rows[i]["MilNoKW"].ToString();



                        if (!string.IsNullOrEmpty(stractiviity))
                        {


                            dr["Activity"] = "Created";
                            dt.Rows.Add(dr);
                        }
                    }
                }
                catch (Exception es)
                {
                    var str = es.ToString();
                }



            }

            return dt;
        }

        private DataTable GetProfileDesiserOutput(DataTable usertable, DataTable dt)
        {


            for (int i = 0; i < usertable.Rows.Count; i++)
            {
                string stractiviity = "";
                DataRow dr = dt.NewRow();
                try
                {
                    if (usertable.Rows[i]["ModifiedDate"] != null)
                    {
                        dr["TimeStamp"] = Convert.ToDateTime(usertable.Rows[i]["ModifiedDate"]);
                        dr["User"] = usertable.Rows[i]["ModifiedByUserName"].ToString();
                        dr["MilNo"] = usertable.Rows[i]["MilNoKW"].ToString();

                        if (i > 0)
                            stractiviity = GetUserChangeInfo(usertable, i);


                        if (!string.IsNullOrEmpty(stractiviity))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendFormat("{0}", stractiviity);
                            StringWriter tw = new StringWriter(sb);
                            HtmlTextWriter hw = new HtmlTextWriter(tw);

                            //ctrl.RenderControl(hw);

                            dr["Activity"] = sb.ToString(); ;
                            dt.Rows.Add(dr);
                        }
                    }
                    else
                    {
                        dr["TimeStamp"] = Convert.ToDateTime(usertable.Rows[i]["CreatedDate"]);
                        dr["User"] = usertable.Rows[i]["CreatedByUserName"].ToString();
                        dr["MilNo"] = usertable.Rows[i]["MilNoKW"].ToString();


                        stractiviity = "<b style='color:blue'>Created</b>";


                        if (!string.IsNullOrEmpty(stractiviity))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendFormat("{0}", stractiviity);
                            StringWriter tw = new StringWriter(sb);
                            HtmlTextWriter hw = new HtmlTextWriter(tw);

                            //ctrl.RenderControl(hw);

                            dr["Activity"] = sb.ToString(); ;
                            dt.Rows.Add(dr);
                        }
                    }
                }
                catch (Exception es)
                {
                    var str = es.ToString();
                }



            }

            return dt;
        }

        private String GetUserChangeInfo(DataTable usertable, int index)
        {
            string strActivity = "";
            for (int i = 0; i < usertable.Columns.Count; i++)
            {
                if (usertable.Rows[index][i].ToString().ToLower().Trim() != usertable.Rows[index - 1][i].ToString().ToLower().Trim())
                {
                    if (!usertable.Columns[i].ColumnName.ToLower().Contains("updatedby")
                        && !usertable.Columns[i].ColumnName.ToLower().Contains("updatedbyusername")
                         && !usertable.Columns[i].ColumnName.ToLower().Contains("modifiedbyusername")
                          && !usertable.Columns[i].ColumnName.ToLower().Contains("modifieddate")
                          && !usertable.Columns[i].ColumnName.ToLower().Contains("updateddate")
                        && !usertable.Columns[i].ColumnName.ToLower().Contains("createdby")
                         && !usertable.Columns[i].ColumnName.ToLower().Contains("createdbyusername")
                          && !usertable.Columns[i].ColumnName.ToLower().Contains("createddate")
                          && !usertable.Columns[i].ColumnName.ToLower().Contains("hrbasicid")


                         )
                    {
                        if (usertable.Rows[index]["MilNoKW"].ToString().ToLower().Trim() == usertable.Rows[index - 1]["MilNoKW"].ToString().ToLower().Trim())
                        {
                            strActivity += "<b style='color:black;'>" + usertable.Columns[i].ColumnName.Replace("EntityName", "Unit") + "</b> :  <span style='color:red;'>" + usertable.Rows[index - 1][i].ToString() + " </span> ===>   <span style='color:green;'>" + usertable.Rows[index][i].ToString() + "</span><br/>";
                        }
                    }
                }
            }
            return Server.HtmlDecode(strActivity);
        }

        [HttpPost]
        [ValidateInput(true)]
        [AllowCrossSiteJsonAttribute]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GenerateProfileReport(rpt_TableNameEntity input)
        {
            try
            {
                var list = GetProfileData(input);
                ViewBag.list = list;
                return PartialView("_GenerateReport");
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        private string GetProfileJoinText(string strcolumn)
        {
            if (strcolumn.ToLower().Contains("religionid"))
                return "r.Religion,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("bloodgroupid"))
                return "r.bloodgroup,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("maritalstatusid"))
                return "r.maritalstatus,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("genderid"))
                return "r.gender,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("nationalityid"))
                return "r.countryname,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("buildingid"))
                return "r.buildingname,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("kwgovid"))
                return "r.KWGovName,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("kwareaid"))
                return "r.KWAreaName,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("bdcurdivid"))
                return "r.BDCurDivName,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("bdcurcityid"))
                return "r.BDCurCityName,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("bdcurthanaid"))
                return "r.BDCurThanaName,r.MilNoKW";

            else if (strcolumn.ToLower().Contains("bdperdivid"))
                return "r.BDPerDivName,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("bdpercityid"))
                return "r.BDPerCityName,r.MilNoKW";
            else if (strcolumn.ToLower().Contains("bdperthanaid"))
                return "r.BDPerThanaName,r.MilNoKW";
            else
                return strcolumn;
        }

        private DataTable GetProfileData(rpt_TableNameEntity input)
        {
            DataTable dt = new DataTable();

            try
            {
                //string MainTablename = input.TableName + "_History";
                string WhereCondition_milid = "", strbasicid = "", WhereCondition1_user = "", WhereCondition2_user = "", strwhere1 = "", strwhere2 = "";

                //string strcoulmns = input.strColumns.Substring(0, input.strColumns.Length - 1);
                if (input.lonVal2 != null)
                {
                    var objSvc = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll(new hr_svcinfoEntity { militarynokw = input.lonVal2 }).SingleOrDefault();

                    if (objSvc != null)
                    {
                        strbasicid = objSvc.hrbasicid.ToString();
                    }
                }

                if (input.lonVal1 != null)
                {
                    WhereCondition1_user = " (hr_personalinfo_History.UpdatedBy=" + input.lonVal1 + ") ";
                    WhereCondition2_user = " (hr_basicprofile_History.UpdatedBy=" + input.lonVal1 + ") ";

                }


                if (!string.IsNullOrEmpty(strbasicid))
                {
                    WhereCondition_milid = " Hr_SvcInfo.HRBasicID = " + strbasicid + " ";

                }

                if (!string.IsNullOrEmpty(WhereCondition_milid) || !string.IsNullOrEmpty(WhereCondition1_user) || !string.IsNullOrEmpty(input.strModelPrimaryKey))
                {
                    strwhere1 = ""; strwhere2 = "";

                    if (!string.IsNullOrEmpty(WhereCondition_milid))
                    {
                        strwhere1 += strwhere1.Length > 0 ? " AND " + WhereCondition_milid : WhereCondition_milid;
                        strwhere2 += strwhere2.Length > 0 ? " AND " + WhereCondition_milid : WhereCondition_milid;
                    }
                    if (!string.IsNullOrEmpty(WhereCondition1_user))
                    {
                        strwhere1 += strwhere1.Length > 0 ? " AND " + WhereCondition1_user : WhereCondition1_user;  //(string.IsNullOrEmpty(WhereCondition_milid) ? " " : " AND ") + WhereCondition_user;
                        strwhere2 += strwhere2.Length > 0 ? " AND " + WhereCondition2_user : WhereCondition2_user;
                    }

                    if (strwhere1.Length > 0)
                    {
                        strwhere1 = " Where " + strwhere1;
                        strwhere2 = " Where " + strwhere2;
                    }
                }

                if (input.FromDate1 != null && input.ToDate1 != null)
                {
                    strwhere1 += string.IsNullOrEmpty(strwhere1) ? " (hr_personalinfo_History.UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "' )" : " AND  (hr_personalinfo_History.UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "')";
                    strwhere2 += string.IsNullOrEmpty(strwhere2) ? " (hr_basicprofile_History.UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "' )" : " AND  (hr_basicprofile_History.UpdatedDate BETWEEN '" + input.FromDate1.ToString() + "' AND '" + input.ToDate1.ToString() + "')";

                }


                dt = GetRowChanges(input.strModelPrimaryKey, strwhere1, strwhere2);
            }
            catch (Exception es)
            {
                var str = es.ToString();
            }




            return dt;
        }


        private DataTable GetRowChanges(string strselect, string strwhere1, string strwhere2)
        {
            DataTable dtReturn = new DataTable();
            DataView dv = new DataView();
            DataTable sortedDT = new DataTable();

            DataColumn colDateTime = new DataColumn("TimeStamp");
            colDateTime.DataType = System.Type.GetType("System.DateTime");
            dtReturn.Columns.Add(colDateTime);
            dtReturn.Columns.Add("User");
            dtReturn.Columns.Add("MilNo");
            dtReturn.Columns.Add("Activity");

            DataTable dt = new DataTable();

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString();//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";


            if (strselect.Contains("civilid") || strselect.Contains("passportno") || strselect.Contains("fullname") || strselect.Contains("ALLChanges"))
            {

                using (SqlConnection connection = new SqlConnection(conString))

                using (SqlCommand command = connection.CreateCommand())
                {
                    //GetProfileJoinText(input.strModelPrimaryKey.Replace("r.", ""))
                    command.CommandText = @" select " + (strselect == "ALLChanges" ? " r.*" : GetProfileJoinText(strselect.Replace("r.", ""))) + @", r.UpdatedByUserName as ModifiedByUserName,r.UpdatedDate as ModifiedDate from  
                                            (
                                                SELECT   Hr_SvcInfo.MilNoKW,                                                  
                                                hr_basicprofile_History.civilid, 
                                                hr_basicprofile_History.passportno, 
                                                hr_basicprofile_History.fullname ,
                                                hr_basicprofile_History.milnobd ,
                                                hr_basicprofile_History.dateofbirth ,
                                               
                                                hr_basicprofile_History.UpdatedBy, 
                                                hr_basicprofile_History.UpdatedByUserName, 
                                                hr_basicprofile_History.UpdatedDate,
                                                hr_basicprofile_History.CreatedBy, 
                                                hr_basicprofile_History.CreatedByUserName, 
                                                hr_basicprofile_History.CreatedDate    

                                                FROM   hr_basicprofile inner JOIN Hr_SvcInfo  ON hr_basicprofile.hrbasicid = Hr_SvcInfo.hrbasicid 
                                                inner JOIN hr_basicprofile_History  ON hr_basicprofile.hrbasicid = hr_basicprofile_History.hrbasicid
                                               
                                                " + strwhere2 + @"

                                                union

                                                SELECT   Hr_SvcInfo.MilNoKW,                                                  
                                                hr_basicprofile.civilid, 
                                                hr_basicprofile.passportno, 
                                                hr_basicprofile.fullname ,
                                                hr_basicprofile.milnobd ,
                                                hr_basicprofile.dateofbirth ,
                                               
                                                hr_basicprofile.UpdatedBy, 
                                                hr_basicprofile.UpdatedByUserName, 
                                                hr_basicprofile.UpdatedDate,
                                                hr_basicprofile.CreatedBy, 
                                                hr_basicprofile.CreatedByUserName, 
                                                hr_basicprofile.CreatedDate    

                                                FROM   hr_basicprofile inner JOIN Hr_SvcInfo  ON hr_basicprofile.hrbasicid = Hr_SvcInfo.hrbasicid 

                                               
                                                " + strwhere2.ToLower().Replace("_history", "") + @"

                                           )r ";


                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();

                }

                dv = dt.DefaultView;
                dv.Sort = "MilNoKW ASC, ModifiedDate ASC";
                sortedDT = dv.ToTable();

                dtReturn = GetProfileDesiserOutput(sortedDT, dtReturn);
            }
            if ((!strselect.Contains("civilid") && !strselect.Contains("passportno") && !strselect.Contains("fullname")) || strselect.Contains("ALLChanges"))
            {
                dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(conString))

                using (SqlCommand command = connection.CreateCommand())
                {
                    //GetProfileJoinText(input.strModelPrimaryKey.Replace("r.", ""))
                    command.CommandText = @" select  " + (strselect == "ALLChanges" ? " r.*" : GetProfileJoinText(strselect)) + @", r.UpdatedByUserName as ModifiedByUserName,r.UpdatedDate as ModifiedDate from  
                                            (
                                                 SELECT gen_bloodgroup.bloodgroup, Hr_SvcInfo.MilNoKW,  Gen_Religion.Religion,
                                                                           gen_maritalstatus.maritalstatus, 
                                                                           gen_country.countryname, 
                                                                           gen_gender.gender, 
                                                                           gen_building.buildingname, 
                                                                           KWGov.cityname        KWGovName, 
                                                                           KWArea.cityname       KWAreaName, 
                                                                           currdiv.districtname  BDCurDivName, 
                                                                           currcity.districtname BDCurCityName, 
                                                                           CurThana.thananame    BDCurThanaName, 
                                                                           perdiv.districtname   BDPerDivName, 
                                                                           percity.districtname  BDPerCityName, 
                                                                           perThana.thananame    BDPerThanaName, 
                                               
                                                                           Hr_PersonalInfo_History.hrbasicid, 
                                            
                                                                           Hr_PersonalInfo_History.kwblockno, 
                                                                           Hr_PersonalInfo_History.kwstreet, 
                                                                           Hr_PersonalInfo_History.kwhouseno, 
                                                                           Hr_PersonalInfo_History.kwflatno, 
                                                                           Hr_PersonalInfo_History.kwmobile, 
                                                                           Hr_PersonalInfo_History.kwviber, 
                                                                           Hr_PersonalInfo_History.personalemail, 
                                                                           Hr_PersonalInfo_History.officialemail, 
                                               
                                                                           Hr_PersonalInfo_History.bdcurpostoffice, 
                                                                           Hr_PersonalInfo_History.bdcurroad, 
                                                                           Hr_PersonalInfo_History.bdcurhouse, 
                                                                           Hr_PersonalInfo_History.bdcurflatno, 
                                                                           Hr_PersonalInfo_History.bdmob1, 
                                                                           Hr_PersonalInfo_History.bdmob2, 
                                                                           Hr_PersonalInfo_History.bdhomephone, 
                                               
                                                                           Hr_PersonalInfo_History.bdperpostoffice, 
                                                                           Hr_PersonalInfo_History.bdperroad, 
                                                                           Hr_PersonalInfo_History.bdperhouse, 
                                                                           Hr_PersonalInfo_History.bdperflatno, 
      
                                                                         Hr_PersonalInfo_History.UpdatedBy, 
                                                                         Hr_PersonalInfo_History.UpdatedByUserName, 
                                                                         Hr_PersonalInfo_History.UpdatedDate,
                                                                         Hr_PersonalInfo_History.CreatedBy, 
                                                                         Hr_PersonalInfo_History.CreatedByUserName, 
                                                                         Hr_PersonalInfo_History.CreatedDate    

                                                                        FROM    Hr_SvcInfo
                                                         
                                                                           inner JOIN Hr_PersonalInfo_History 
                                                                                        ON Hr_SvcInfo.hrbasicid = Hr_PersonalInfo_History.hrbasicid
                                             
                                                                           LEFT OUTER JOIN gen_bloodgroup 
                                                                                        ON Hr_PersonalInfo_History.bloodgroupid = 
                                                                                           gen_bloodgroup.bloodgroupid 
                                                                            LEFT OUTER JOIN Gen_Religion 
                                                                                        ON Hr_PersonalInfo_History.ReligionID = 
                                                                                           Gen_Religion.ReligionID 
                                                                           LEFT OUTER JOIN gen_maritalstatus 
                                                                                        ON Hr_PersonalInfo_History.maritalstatusid = 
                                                                                           gen_maritalstatus.maritalstatusid 
                                                                           LEFT OUTER JOIN gen_country 
                                                                                        ON Hr_PersonalInfo_History.nationalityid = gen_country.countryid 
                                                                           LEFT OUTER JOIN gen_gender 
                                                                                        ON Hr_PersonalInfo_History.genderid = gen_gender.genderid 
                                                                           LEFT OUTER JOIN gen_building 
                                                                                        ON Hr_PersonalInfo_History.buildingid = gen_building.buildingid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict currdiv 
                                                                                        ON Hr_PersonalInfo_History.bdcurdivid = currdiv.districtid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict currcity 
                                                                                        ON Hr_PersonalInfo_History.bdcurcityid = currcity.districtid 
                                                                           LEFT OUTER JOIN gen_thana CurThana 
                                                                                        ON Hr_PersonalInfo_History.bdcurthanaid = CurThana.thanaid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict perdiv 
                                                                                        ON Hr_PersonalInfo_History.bdperdivid = perdiv.districtid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict percity 
                                                                                        ON Hr_PersonalInfo_History.bdpercityid = percity.districtid 
                                                                           LEFT OUTER JOIN gen_thana perThana 
                                                                                        ON Hr_PersonalInfo_History.bdperthanaid = perThana.thanaid 
                                                                           LEFT OUTER JOIN gen_govcity AS KWGov 
                                                                                        ON Hr_PersonalInfo_History.kwgovid = KWGov.cityid 
                                                                           LEFT OUTER JOIN gen_govcity AS KWArea 
                                                                                        ON Hr_PersonalInfo_History.kwareaid = KWArea.cityid 
                                                                              " + strwhere1 + @"

												                             UNION

												                             SELECT  gen_bloodgroup.bloodgroup, Hr_SvcInfo.MilNoKW,  Gen_Religion.Religion,
                                                                           gen_maritalstatus.maritalstatus, 
                                                                           gen_country.countryname, 
                                                                           gen_gender.gender, 
                                                                           gen_building.buildingname, 
                                                                           KWGov.cityname        KWGovName, 
                                                                           KWArea.cityname       KWAreaName, 
                                                                           currdiv.districtname  BDCurDivName, 
                                                                           currcity.districtname BDCurCityName, 
                                                                           CurThana.thananame    BDCurThanaName, 
                                                                           perdiv.districtname   BDPerDivName, 
                                                                           percity.districtname  BDPerCityName, 
                                                                           perThana.thananame    BDPerThanaName, 
                                               
                                                                           Hr_PersonalInfo.hrbasicid, 
                                            
                                                                           Hr_PersonalInfo.kwblockno, 
                                                                           Hr_PersonalInfo.kwstreet, 
                                                                           Hr_PersonalInfo.kwhouseno, 
                                                                           Hr_PersonalInfo.kwflatno, 
                                                                           Hr_PersonalInfo.kwmobile, 
                                                                           Hr_PersonalInfo.kwviber, 
                                                                           Hr_PersonalInfo.personalemail, 
                                                                           Hr_PersonalInfo.officialemail, 
                                               
                                                                           Hr_PersonalInfo.bdcurpostoffice, 
                                                                           Hr_PersonalInfo.bdcurroad, 
											                               Hr_PersonalInfo.bdcurhouse, 
                                                                           Hr_PersonalInfo.bdcurflatno, 
                                                                           Hr_PersonalInfo.bdmob1, 
                                                                           Hr_PersonalInfo.bdmob2, 
                                                                           Hr_PersonalInfo.bdhomephone, 
                                               
                                                                           Hr_PersonalInfo.bdperpostoffice, 
                                                                           Hr_PersonalInfo.bdperroad, 
                                                                           Hr_PersonalInfo.bdperhouse, 
                                                                           Hr_PersonalInfo.bdperflatno, 
      
                                                                         Hr_PersonalInfo.UpdatedBy, 
                                                                         Hr_PersonalInfo.UpdatedByUserName, 
                                                                         Hr_PersonalInfo.UpdatedDate,
                                                                         Hr_PersonalInfo.CreatedBy, 
                                                                         Hr_PersonalInfo.CreatedByUserName, 
                                                                         Hr_PersonalInfo.CreatedDate    

                                                                        FROM    Hr_SvcInfo
                                                         
                                                                           inner JOIN Hr_PersonalInfo 
                                                                                        ON Hr_SvcInfo.hrbasicid = Hr_PersonalInfo.hrbasicid
                                             
                                                                           LEFT OUTER JOIN gen_bloodgroup 
                                                                                        ON Hr_PersonalInfo.bloodgroupid = 
                                                                                           gen_bloodgroup.bloodgroupid 
                                                                            LEFT OUTER JOIN Gen_Religion 
                                                                                        ON Hr_PersonalInfo.ReligionID = 
                                                                                           Gen_Religion.ReligionID 
                                                                           LEFT OUTER JOIN gen_maritalstatus 
                                                                                        ON Hr_PersonalInfo.maritalstatusid = 
                                                                                           gen_maritalstatus.maritalstatusid 
                                                                           LEFT OUTER JOIN gen_country 
                                                                                        ON Hr_PersonalInfo.nationalityid = gen_country.countryid 
                                                                           LEFT OUTER JOIN gen_gender 
                                                                                        ON Hr_PersonalInfo.genderid = gen_gender.genderid 
                                                                           LEFT OUTER JOIN gen_building 
                                                                                        ON Hr_PersonalInfo.buildingid = gen_building.buildingid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict currdiv 
                                                                                        ON Hr_PersonalInfo.bdcurdivid = currdiv.districtid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict currcity 
                                                                                        ON Hr_PersonalInfo.bdcurcityid = currcity.districtid 
                                                                           LEFT OUTER JOIN gen_thana CurThana 
                                                                                        ON Hr_PersonalInfo.bdcurthanaid = CurThana.thanaid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict perdiv 
                                                                                        ON Hr_PersonalInfo.bdperdivid = perdiv.districtid 
                                                                           LEFT OUTER JOIN gen_divisiondistrict percity 
                                                                                        ON Hr_PersonalInfo.bdpercityid = percity.districtid 
                                                                           LEFT OUTER JOIN gen_thana perThana 
                                                                                        ON Hr_PersonalInfo.bdperthanaid = perThana.thanaid 
                                                                           LEFT OUTER JOIN gen_govcity AS KWGov 
                                                                                        ON Hr_PersonalInfo.kwgovid = KWGov.cityid 
                                                                           LEFT OUTER JOIN gen_govcity AS KWArea 
                                                                                        ON Hr_PersonalInfo.kwareaid = KWArea.cityid 
                                                                             " + strwhere1.ToLower().Replace("_history", "") + @"

                                           )r ";

                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();

                }

                dv = dt.DefaultView;
                dv.Sort = "MilNoKW ASC, ModifiedDate ASC";
                sortedDT = dv.ToTable();

                dtReturn = GetProfileDesiserOutput(sortedDT, dtReturn);
            }

            dv = new DataView();
            dv = dtReturn.DefaultView;
            dv.Sort = "TimeStamp ASC";
            DataTable sortedfinal = dv.ToTable();

            return sortedfinal;
        }
        private List<rpt_TableColumn> getFilteredTableColumnsNames(String Table)
        {
            List<rpt_TableColumn> list_tablecolumn = new List<rpt_TableColumn>();
            DataTable dt = new DataTable();
            // string conString = "Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

            List<string> listacolumnas = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT        INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME, INFORMATION_SCHEMA.COLUMNS.DATA_TYPE, INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME AS COLUMN_NAME_Alias
                                    FROM            INFORMATION_SCHEMA.COLUMNS INNER JOIN
                                                             sys.sysobjects ON INFORMATION_SCHEMA.COLUMNS.TABLE_NAME = sys.sysobjects.name
                                    WHERE        (INFORMATION_SCHEMA.COLUMNS.TABLE_NAME = '" + Table + @"') AND (INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME NOT IN
                             (SELECT        name
                               FROM            sys.syscolumns
                               WHERE        (id IN
                                                             (SELECT        id
                                                               FROM            sys.sysobjects
                                                               WHERE        (name = '" + Table + @"'))) AND (colid IN
                                                             (SELECT        SIK.colid
                                                               FROM            sys.sysindexkeys AS SIK INNER JOIN
                                                                                         sys.sysobjects AS SO ON SIK.id = SO.id
                                                               WHERE        (SIK.indid = 1) AND (SO.name = '" + Table + @"'))))) AND (INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME NOT IN
                             (SELECT        cref.name
                               FROM            sys.foreign_key_columns AS fkc INNER JOIN
                                                         sys.columns AS c ON fkc.parent_column_id = c.column_id AND fkc.parent_object_id = c.object_id INNER JOIN
                                                         sys.columns AS cref ON fkc.referenced_column_id = cref.column_id AND fkc.referenced_object_id = cref.object_id
                               WHERE        (OBJECT_NAME(fkc.parent_object_id) = 'Gen_Bank'))) AND (INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME <> INFORMATION_SCHEMA.COLUMNS.TABLE_NAME + 'ID') AND 
                         (INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME NOT LIKE 'Ex_%') AND (INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME NOT IN ('Remarks','TransID', 'UserOrganizationKey', 'UserEntityKey', 'CreatedBy', 'CreatedByUserName', 
                         'CreatedDate', 'UpdatedBy', 'UpdatedByUserName', 'UpdatedDate', 'IPAddress', 'FormID', 'TS'))";
                connection.Open();

                dt.Load(command.ExecuteReader());
                connection.Close();


                list_tablecolumn = ConvertDataTable<rpt_TableColumn>(dt);
            }
            return list_tablecolumn;
        }

        private List<rpt_TableColumn> getAllClumnsByTableName(String Table)
        {
            List<rpt_TableColumn> list_tablecolumn = new List<rpt_TableColumn>();
            DataTable dt = new DataTable();
            // string conString = "Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

            List<string> listacolumnas = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT  COLUMN_NAME,DATA_TYPE,COLUMN_NAME as COLUMN_NAME_Alias
                                       FROM INFORMATION_SCHEMA.COLUMNS
                                        WHERE  INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME not like  'Ex_%' AND (INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME <> SUBSTRING( INFORMATION_SCHEMA.COLUMNS.TABLE_NAME ,CHARINDEX('_',INFORMATION_SCHEMA.COLUMNS.TABLE_NAME)+1,LEN(INFORMATION_SCHEMA.COLUMNS.TABLE_NAME)) + 'ID') AND   TABLE_NAME = '" + Table + "'" + @" 
                                        AND COLUMNS.COLUMN_NAME NOT IN ('Remarks','TransID', 'UserOrganizationKey', 'UserEntityKey', 'CreatedBy', 'CreatedByUserName', 
                                        'CreatedDate','HrBasicID', 'UpdatedBy', 'UpdatedByUserName', 'UpdatedDate', 'IPAddress', 'FormID', 'TS')";
                connection.Open();

                dt.Load(command.ExecuteReader());
                connection.Close();


                list_tablecolumn = ConvertDataTable<rpt_TableColumn>(dt);
            }
            return list_tablecolumn;
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        private List<rpt_TableNameEntity> GetTableList()
        {

            List<rpt_TableNameEntity> objList = new List<rpt_TableNameEntity>();

            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["KAFApplicationService"].ToString(); ;//"Data Source=192.168.25.190;User ID=sa;Password=121212@db;Initial Catalog=KAF_NationalServicePortal_V1.1;";

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT  Name from Sysobjects where xtype = 'u'  " +
                        " AND (Name like 'Gen_%'  " +
                        " OR  Name like 'Stp_%'  " +
                        " OR Name like 'Hr_%' ) " +

                        " AND Name not like '%_History%'  " +

                        "order by Name"

                        , con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {

                                objList.Add(new rpt_TableNameEntity
                                {
                                    TableName = dr[0].ToString(),
                                    TableName_Alias = dr[0].ToString().Replace("Gen_", "").Replace("Stp_", "").Replace("Hr_", "").Replace("HR_", "")
                                });
                            }
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception es)
            {

            }
            objList = objList.OrderBy(p => p.TableName_Alias).ToList();
            objList.Insert(0, new rpt_TableNameEntity { TableName = "PleaseSelect", TableName_Alias = "Please Select" }); ; ;
            return objList;
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



