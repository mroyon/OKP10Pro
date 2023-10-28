using System;
using System.IO;
using System.Web;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace KAF.AppConfiguration.Configuration
{
    public class ClsSQLCSV
    {
        #region Protected Attributes
        protected SqlConnection conn = null;
        protected SqlCommand cmd = null;
        //System.Data.Odbc.OdbcDataAdapter obj_oledb_da = null;
        #endregion

        #region Class Constructor
        public ClsSQLCSV()
        {
            GetConfigSettings();
        }
        /// <summary>
        /// get config settings
        /// </summary>
        /// <method name="GetConfigSettings" type="void"></method>
        private void GetConfigSettings()
        {
            NameValueCollection config = (NameValueCollection)ConfigurationSettings.GetConfig("appSettings");
            ConnSQL = config["connSQL"];
            ConnCSV = config["connxls"];
        }
        #endregion

        #region Variable Declaration
        private string ConnSQL = "";
        private string ConnCSV = "";
        string strTableName = "";
        string strServerPath = "";
        string strCsvDirOnServer = "";
        private string strExportCSV = "";
        private string strExportTable = "";
        private string strExportCSVDir = "";
        private string strExportAsCsvOrText = "";
        bool blnDropExistingTable = false;
        bool blnSaveFileOnServer = false;
        FileInfo fi;
        #endregion

        #region Import Functionality
        //, bool SplitYN, int RecordCountPerCSV
        /// <summary>
        /// generate table
        /// </summary>
        /// <method name="GenerateTable" type="DataSet"></method>
        /// <param name="Properties" type="SetProperties"></param>
        /// <returns>DataSet</returns>
        /// <remarks> generate dataset table</remarks>
        public DataSet GenerateTable(SetProperties Properties)
        {
            //string strreturn = "";
            blnSaveFileOnServer = Properties.SaveFileOnServer;
            blnDropExistingTable = Properties.DropExistingTable;
            strCsvDirOnServer = Properties.CsvDirOnServer;
            strTableName = Properties.TableName;
            fi = Properties.FileInformation;

            DataSet dsCSV = new DataSet();
            dsCSV = ConnectCSV(fi.Name, Properties.FilePath);
            DataColumnCollection tableColumns = dsCSV.Tables[0].Columns;
            DataRowCollection tableRows = dsCSV.Tables[0].Rows;

            //BLL.Interfare.DataExportImport obj = new BLL.Interfare.DataExportImport();
            //o = obj.ImportProductInfo(dsCSV, dsTemp);

            return dsCSV;
        }



        #region LOAD DATA FROM CSV FILE
        /// <summary>
        /// connect CSV
        /// </summary>
        /// <method name="ConnectCSV" type="DataSet"></method>
        /// <param name="filetable" type="string"></param>
        /// <param name="path" type="string"></param>
        /// <returns>DataSet</returns>
        /// <remarks>Connect CSV</remarks>
        public DataSet ConnectCSV(string filetable, string path)
        {
            DataSet ds = new DataSet();
            ////Try
            //// You can get connected to driver either by using DSN or connection string

            //// Create a connection string as below, if you want to use DSN less connection. The DBQ attribute sets the path of directory which contains CSV files
            //string strConnString = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + HttpRuntime.AppDomainAppPath.Trim() + "UploadFile\\" + ";Extensions=asc,csv,tab,txt;Persist Security Info=False";
            //string sql_select = null;
            //System.Data.Odbc.OdbcConnection conn = null;

            ////Create connection to CSV file
            //conn = new System.Data.Odbc.OdbcConnection(strConnString.Trim());

            //// For creating a connection using DSN, use following line
            ////conn	=	new System.Data.Odbc.OdbcConnection(DSN="MyDSN");

            ////Open the connection 
            //conn.Open();
            ////Fetch records from CSV
            //sql_select = "select * from [" + filetable + "]";

            //obj_oledb_da = new System.Data.Odbc.OdbcDataAdapter(sql_select, conn);
            ////Fill dataset with the records from CSV file
            //obj_oledb_da.Fill(ds, "Productr");

            ////Session["dsImportYearMakeMode"] = ds;
            ////Close Connection to CSV file
            //conn.Close();
            ////Catch e As Exception 'Error

            ////End Try


            string strConnString = path + filetable;
            DataTable dt = CSVReader.ReadCSVFile( strConnString, true);
            ds.Tables.Add(dt.Copy());
            return ds;
        }
        /// <summary>
        /// Connect File
        /// </summary>
        /// <method name="ConnectFile" type="DataSet"></method>
        /// <param name="filetable" type="FileInfo"></param>
        /// <returns>DataSet</returns>
        /// <remarks>Connect file</remarks>
        private DataSet ConnectFile(FileInfo filetable)
        {
            DataSet ds = new DataSet();
            string str;
            try
            {
                ConnCSV = ConnCSV + filetable.DirectoryName.ToString();
                string sqlSelect;
                OleDbConnection objOleDBConn;
                OleDbDataAdapter objOleDBDa;
                objOleDBConn = new OleDbConnection(ConnCSV);
                objOleDBConn.Open();
                sqlSelect = "select * from [" + filetable.Name.ToString() + "]";
                objOleDBDa = new OleDbDataAdapter(sqlSelect, objOleDBConn);
                objOleDBDa.Fill(ds);
                objOleDBConn.Close();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            return ds;
        }
        #endregion LOAD DATA FROM CSV FILE

        #region Table Handler
        /// <summary>
        /// Table row count
        /// </summary>
        /// <method name="TableExists" type="int"></method>
        /// <returns>int</returns>
        /// <remarks>table row count</remarks>
        private int TableExists()
        {
            OpenConnection();
            string strTable = "select table_name from information_schema.tables ";
            strTable = strTable + " where table_name = '" + strTableName + "'";
            int cmdReturn = 0;
            cmd = new SqlCommand(strTable, conn);

            try
            {
                SqlDataReader Reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (Reader.Read())
                {
                    cmdReturn++;
                }
                Reader.Close();
            }
            catch { }
            finally { CloseConnection(); }

            return cmdReturn;
        }

        /// <summary>
        /// drop table
        /// </summary>
        /// <method name="DropTable" type="void"></method>
        private void DropTable()
        {
            OpenConnection();

            string sqldrop = "DROP TABLE " + strTableName;
            cmd = new SqlCommand(sqldrop, conn);

            try { cmd.ExecuteNonQuery(); }
            catch { }
            finally { CloseConnection(); }

        }

        /// <summary>
        /// create table
        /// </summary>
        /// <method name="CreateTable" type="void"></method>
        /// <param name="tableColumns" type="DataColumnCollection"></param>
        private void CreateTable(DataColumnCollection tableColumns)
        {
            OpenConnection();

            string sqlcreate = "CREATE TABLE " + strTableName + " (";
            foreach (DataColumn dc in tableColumns)
            {
                sqlcreate += "[" + dc.ColumnName.ToString() + "]" + " varchar(255), ";
            }

            sqlcreate = sqlcreate.Substring(0, sqlcreate.Length - 2);
            sqlcreate += ")";

            cmd = new SqlCommand(sqlcreate, conn);

            try { cmd.ExecuteNonQuery(); }
            catch { }
            finally { CloseConnection(); }
        }

        /// <summary>
        /// Insert Records
        /// </summary>
        /// <method name="InsertRecords" type="string"></method>
        /// <param name="tableColumns" type="DataColumnCollection"></param>
        /// <param name="tableRows" type="DataRowCollection"></param>
        /// <returns>string</returns>
        private string InsertRecords(DataColumnCollection tableColumns, DataRowCollection tableRows)
        {
            string strreturn = "";
            int rowscreated = 0;

            OpenConnection();

            try
            {
                foreach (DataRow row in tableRows)
                {
                    //Build Insert Query string to insert records
                    string sqlinsert = "INSERT INTO " + strTableName + "(";
                    string sqlvalues = "VALUES (";

                    object[] rowItems = row.ItemArray;
                    // loop through each column in a specific DataTable.
                    int ctrColumn = 0;
                    foreach (DataColumn dc in tableColumns)
                    {
                        if (ctrColumn < tableColumns.Count - 1)
                            sqlinsert += "[" + dc.ColumnName.ToString() + "]" + ",";
                        else
                            sqlinsert += "[" + dc.ColumnName.ToString() + "]" + ") ";


                        //Prepare string of a record to be inserted
                        if (ctrColumn < tableColumns.Count - 1)
                            sqlvalues += "'" + rowItems[ctrColumn].ToString().Replace("'", "''") + "',";
                        else
                            sqlvalues += "'" + rowItems[ctrColumn].ToString().Replace("'", "''") + "') ";

                        ctrColumn++;
                    }

                    sqlinsert = sqlinsert + sqlvalues;
                    //Execute the command
                    cmd = new SqlCommand(sqlinsert, conn);
                    rowscreated += cmd.ExecuteNonQuery();
                }
                strreturn = "Records Imported Successfully!<br>";
                strreturn += rowscreated.ToString();
                strreturn += " rows created in table " + strTableName;
            }
            catch (SqlException ae)
            {
                strreturn = "Error at Record Number: ";
                strreturn += rowscreated.ToString();
                strreturn += "<br>Message: " + ae.Message.ToString();
                strreturn += "<br>" + "Error importing. Please try again";
            }
            finally
            {
                CloseConnection();
            }

            return strreturn;
        }


        private void OpenConnection()
        {
            conn = new SqlConnection(ConnSQL);
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }


        private void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
        #endregion Table Handler

        #region Save File To Server
        /// <summary>
        /// Save File To Server
        /// </summary>
        /// <method name="SaveFileToServer" type="string"></method>
        /// <param name="filetable" type="FileInfo"></param>
        /// <returns>string</returns>
        /// <remarks> Save File To Server</remarks>
        private string SaveFileToServer(FileInfo filetable)
        {
            string strFilename;
            strServerPath = HttpContext.Current.Server.MapPath(strCsvDirOnServer);

            if (!Directory.Exists(strServerPath))
                Directory.CreateDirectory(strServerPath);

            strFilename = strServerPath + "/" + filetable.Name.ToString();
            filetable.CopyTo(strFilename, true);

            return strFilename;
        }
        #endregion Save File To Server


        #endregion

        #region Export Functionality
        /// <summary>
        /// Generate CSV file
        /// </summary>
        /// <method name="GenerateCSVFile" type="string"></method>
        /// <param name="Properties" type="SetProperties"></param>
        /// <returns></returns>
        /// <remarks>Generate CSV file</remarks>
        public string GenerateCSVFile(SetProperties Properties)
        {
            strExportCSV = Properties.ExportCSVasName;
            strExportTable = Properties.ExportTableName;
            strExportCSVDir = Properties.ExportCSVDirOnServer;
            strExportAsCsvOrText = Properties.ExportAsCsvOrText;

            string strReturn = "";
            DataSet dsSQL = new DataSet();
            dsSQL = ConnectSQLTable(strExportTable);
            DataColumnCollection tableColumns = dsSQL.Tables[0].Columns;
            DataRowCollection tableRows = dsSQL.Tables[0].Rows;

            string strPath = CreateCSVFileOnServer();
            strReturn = WriteInExportedFile(strPath, tableColumns, tableRows);

            return strReturn;
        }

        /// <summary>
        /// Connect SQL table
        /// </summary>
        /// <method name="ConnectSQLTable" type="DataSet"></method>
        /// <param name="filetable" type="string"></param>
        /// <returns>DataSet</returns>
        public DataSet ConnectSQLTable(string filetable)
        {
            DataSet dsAccess = new DataSet();
            try
            {
                string sqlSelect;
                OpenConnection();
                SqlDataAdapter objSQLDa;
                sqlSelect = "Select * from [" + filetable + "]";
                objSQLDa = new SqlDataAdapter(sqlSelect, conn);
                objSQLDa.Fill(dsAccess);
            }
            catch { }
            finally { CloseConnection(); }

            return dsAccess;
        }

        /// <summary>
        /// create svc file on server
        /// </summary>
        /// <method name="CreateCSVFileOnServer" type="string"></method>
        /// <returns></returns>
        private string CreateCSVFileOnServer()
        {
            string strFilename;
            strServerPath = HttpContext.Current.Server.MapPath(strExportCSVDir);

            if (!Directory.Exists(strServerPath))
                Directory.CreateDirectory(strServerPath);

            strFilename = strServerPath + "/" + strExportCSV + ".csv";
            if (strExportAsCsvOrText.ToUpper() == "T")
                strFilename = strServerPath + "/" + strExportCSV + ".txt";

            if (strExportCSV.Substring(strExportCSV.Length - 3, 3) == "csv" || strExportCSV.Substring(strExportCSV.Length - 3, 3) == "txt")
                strFilename = strServerPath + "/" + strExportCSV;


            FileStream newFile = new FileStream(strFilename, FileMode.Create, FileAccess.ReadWrite);
            newFile.Close();

            return strFilename;
        }

        /// <summary>
        /// write exported file
        /// </summary>
        /// <method name="WriteInExportedFile" type="string"></method>
        /// <param name="strPath" type="string"></param>
        /// <param name="tableColumns" type="DataColumnCollection"></param>
        /// <param name="tableRows" type="DataRowCollection"></param>
        /// <returns></returns>
        private string WriteInExportedFile(string strPath, DataColumnCollection tableColumns, DataRowCollection tableRows)
        {
            string strReturn = "";
            System.IO.StreamWriter File = new System.IO.StreamWriter(strPath);

            int rowscreated = 0;
            string sqlinsert = "";
            try
            {
                //Loop through columns of table to generate first row of CSV file
                int ctrColumn = 0;
                foreach (DataColumn dc in tableColumns)
                {
                    if (ctrColumn < tableColumns.Count - 1)
                        sqlinsert += dc.ColumnName.ToString() + ",";
                    else
                        sqlinsert += dc.ColumnName.ToString();

                    ctrColumn++;
                }
                File.WriteLine(sqlinsert);

                foreach (DataRow row in tableRows)
                {
                    sqlinsert = "";
                    string sqlvalues = "";
                    object[] rowItems = row.ItemArray;

                    ctrColumn = 0;
                    foreach (DataColumn dcol in tableColumns)
                    {
                        if (ctrColumn < tableColumns.Count - 1)
                            sqlvalues += rowItems[ctrColumn].ToString().Replace("''", "'") + ",";
                        else
                            sqlvalues += rowItems[ctrColumn].ToString().Replace("''", "'");

                        ctrColumn++;
                    }

                    sqlinsert = sqlinsert + sqlvalues;
                    File.WriteLine(sqlinsert);

                    rowscreated++;
                }
                strReturn = "Records Exported Successfully!<br>";
                strReturn += rowscreated.ToString();
                strReturn += " rows created in CSV file ";
                strReturn += "<a target=_blank href='" + strPath + "'>" + strPath + "</a>";
                File.Close();
            }
            catch (SqlException ae) //Error
            {
                strReturn = "Error at Record Number: ";
                strReturn += rowscreated.ToString();
                strReturn += "<br>Message: " + ae.Message.ToString() + "<br>";
                strReturn += "Error importing. Please try again";
            }
            finally
            {
                File.Close();
            }

            return strReturn;
        }

        #endregion


    }
}
