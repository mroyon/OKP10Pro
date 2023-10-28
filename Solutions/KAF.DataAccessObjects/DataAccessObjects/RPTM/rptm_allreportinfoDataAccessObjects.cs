using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using KAF.DataAccessObjects;
using KAF.BusinessDataObjects;
using KAF.IDataAccessObjects;
using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;


namespace KAF.DataAccessObjects
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class rptm_allreportinfoDataAccessObjects : BaseDataAccess, Irptm_allreportinfoDataAccessObjects
    {

        #region Constructors

        private string ClassName = "rptm_allreportinfoDataAccessObjects";

        public rptm_allreportinfoDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(rptm_allreportinfoEntity rptm_allreportinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (rptm_allreportinfo.reportid.HasValue)
                Database.AddInParameter(cmd, "@ReportID", DbType.Int64, rptm_allreportinfo.reportid);
            if (forDelete) return;
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.modulename)))
                Database.AddInParameter(cmd, "@ModuleName", DbType.String, rptm_allreportinfo.modulename);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.reportname)))
                Database.AddInParameter(cmd, "@ReportName", DbType.String, rptm_allreportinfo.reportname);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.reportnameeng)))
                Database.AddInParameter(cmd, "@ReportNameEng", DbType.String, rptm_allreportinfo.reportnameeng);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.reporturl)))
                Database.AddInParameter(cmd, "@ReportURL", DbType.String, rptm_allreportinfo.reporturl);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.reportspname)))
                Database.AddInParameter(cmd, "@ReportSPName", DbType.String, rptm_allreportinfo.reportspname);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.reportspnameeng)))
                Database.AddInParameter(cmd, "@ReportSPNameEng", DbType.String, rptm_allreportinfo.reportspnameeng);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.reportdescription)))
                Database.AddInParameter(cmd, "@ReportDescription", DbType.String, rptm_allreportinfo.reportdescription);
            if ((rptm_allreportinfo.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, rptm_allreportinfo.ex_date1);
            if ((rptm_allreportinfo.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, rptm_allreportinfo.ex_date2);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, rptm_allreportinfo.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(rptm_allreportinfo.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, rptm_allreportinfo.ex_nvarchar2);
            if (rptm_allreportinfo.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, rptm_allreportinfo.ex_bigint1);
            if (rptm_allreportinfo.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, rptm_allreportinfo.ex_bigint2);
            if (rptm_allreportinfo.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, rptm_allreportinfo.ex_decimal1);
            if (rptm_allreportinfo.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, rptm_allreportinfo.ex_decimal2);

        }


        #region Add Operation

        long Irptm_allreportinfoDataAccessObjects.Add(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            long returnCode = -99;
            const string SP = "rptm_allreportinfo_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(rptm_allreportinfo, cmd, Database);
                FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.Addrptm_allreportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Irptm_allreportinfoDataAccessObjects.Update(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            long returnCode = -99;
            const string SP = "rptm_allreportinfo_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(rptm_allreportinfo, cmd, Database);
                FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.Updaterptm_allreportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        long Irptm_allreportinfoDataAccessObjects.Delete(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            long returnCode = -99;
            const string SP = "rptm_allreportinfo_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(rptm_allreportinfo, cmd, Database, true);
                FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.Deleterptm_allreportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        long Irptm_allreportinfoDataAccessObjects.SaveList(IList<rptm_allreportinfoEntity> listAdded, IList<rptm_allreportinfoEntity> listUpdated, IList<rptm_allreportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "rptm_allreportinfo_Ins";
            const string SPUpdate = "rptm_allreportinfo_Upd";
            const string SPDelete = "rptm_allreportinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (rptm_allreportinfoEntity rptm_allreportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(rptm_allreportinfo, cmd, Database, true);
                            FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listUpdated.Count > 0)
                {
                    foreach (rptm_allreportinfoEntity rptm_allreportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(rptm_allreportinfo, cmd, Database);
                            FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listAdded.Count > 0)
                {
                    foreach (rptm_allreportinfoEntity rptm_allreportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(rptm_allreportinfo, cmd, Database);
                            FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);

                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.Save_rptm_allreportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }



        public long SaveList(Database db, DbTransaction transaction, IList<rptm_allreportinfoEntity> listAdded, IList<rptm_allreportinfoEntity> listUpdated, IList<rptm_allreportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "rptm_allreportinfo_Ins";
            const string SPUpdate = "rptm_allreportinfo_Upd";
            const string SPDelete = "rptm_allreportinfo_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (rptm_allreportinfoEntity rptm_allreportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(rptm_allreportinfo, cmd, db, true);
                            FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listUpdated.Count > 0)
                {
                    foreach (rptm_allreportinfoEntity rptm_allreportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(rptm_allreportinfo, cmd, db);
                            FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listAdded.Count > 0)
                {
                    foreach (rptm_allreportinfoEntity rptm_allreportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(rptm_allreportinfo, cmd, db);
                            FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);

                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.Save_rptm_allreportinfo"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        IList<rptm_allreportinfoEntity> Irptm_allreportinfoDataAccessObjects.GetAll(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                const string SP = "rptm_allreportinfo_GA";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, rptm_allreportinfo.SortExpression);
                    FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(rptm_allreportinfo, cmd, Database);

                    IList<rptm_allreportinfoEntity> itemList = new List<rptm_allreportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_allreportinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.GetAllrptm_allreportinfo"));
            }
        }

        IList<rptm_allreportinfoEntity> Irptm_allreportinfoDataAccessObjects.GetAllByPages(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                const string SP = "rptm_allreportinfo_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, rptm_allreportinfo.SortExpression);
                    AddPageSizeParameter(cmd, rptm_allreportinfo.PageSize);
                    AddCurrentPageParameter(cmd, rptm_allreportinfo.CurrentPage);
                    FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(rptm_allreportinfo, cmd, Database);

                    IList<rptm_allreportinfoEntity> itemList = new List<rptm_allreportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_allreportinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        rptm_allreportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.GetAllByPagesrptm_allreportinfo"));
            }
        }

        #endregion

        #region Save Master/Details


        long Irptm_allreportinfoDataAccessObjects.SaveMasterDetrptm_reportdatasource(rptm_allreportinfoEntity masterEntity,
        IList<rptm_reportdatasourceEntity> listAdded,
        IList<rptm_reportdatasourceEntity> listUpdated,
        IList<rptm_reportdatasourceEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "rptm_allreportinfo_Ins";
            const string MasterSPUpdate = "rptm_allreportinfo_Upd";
            const string MasterSPDelete = "rptm_allreportinfo_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.reportid = PrimaryKeyMaster;
                            }
                        }
                        rptm_reportdatasourceDataAccessObjects objrptm_reportdatasource = new rptm_reportdatasourceDataAccessObjects(this.Context);
                        objrptm_reportdatasource.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.SaveDsrptm_allreportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Irptm_allreportinfoDataAccessObjects.SaveMasterDetrptm_reportparameter(rptm_allreportinfoEntity masterEntity,
        IList<rptm_reportparameterEntity> listAdded,
        IList<rptm_reportparameterEntity> listUpdated,
        IList<rptm_reportparameterEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "rptm_allreportinfo_Ins";
            const string MasterSPUpdate = "rptm_allreportinfo_Upd";
            const string MasterSPDelete = "rptm_allreportinfo_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.reportid = PrimaryKeyMaster;
                            }
                        }
                        rptm_reportparameterDataAccessObjects objrptm_reportparameter = new rptm_reportparameterDataAccessObjects(this.Context);
                        objrptm_reportparameter.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.SaveDsrptm_allreportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        long Irptm_allreportinfoDataAccessObjects.SaveMasterDetrptm_allreportinfo(rptm_allreportinfoEntity masterEntity,
      IList<rptm_reportdatasourceEntity> listAdded,
      IList<rptm_reportdatasourceEntity> listUpdated,
      IList<rptm_reportdatasourceEntity> listDeleted,

      IList<rptm_reportparameterEntity> secondlistAdded,
      IList<rptm_reportparameterEntity> secondlistUpdated,
      IList<rptm_reportparameterEntity> secondlistDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "rptm_allreportinfo_Ins";
            const string MasterSPUpdate = "rptm_allreportinfo_Upd";
            const string MasterSPDelete = "rptm_allreportinfo_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.reportid = PrimaryKeyMaster;
                            }
                            foreach (var seconditem in secondlistAdded)
                            {
                                seconditem.reportid = PrimaryKeyMaster;
                            }
                        }
                        rptm_reportdatasourceDataAccessObjects objrptm_reportdatasource = new rptm_reportdatasourceDataAccessObjects(this.Context);
                        objrptm_reportdatasource.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        rptm_reportparameterDataAccessObjects objrptm_reportparameter = new rptm_reportparameterDataAccessObjects(this.Context);
                        objrptm_reportparameter.SaveList(Database, transaction, secondlistAdded, secondlistUpdated, secondlistDeleted);

                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.SaveDsrptm_allreportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        #endregion


        #region Simple load Single Row
        rptm_allreportinfoEntity Irptm_allreportinfoDataAccessObjects.GetSingle(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                const string SP = "rptm_allreportinfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(rptm_allreportinfo, cmd, Database);

                    IList<rptm_allreportinfoEntity> itemList = new List<rptm_allreportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_allreportinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.GetSinglerptm_allreportinfo"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<rptm_allreportinfoEntity> Irptm_allreportinfoDataAccessObjects.GAPgListView(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                const string SP = "rptm_allreportinfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, rptm_allreportinfo.SortExpression);
                    AddPageSizeParameter(cmd, rptm_allreportinfo.PageSize);
                    AddCurrentPageParameter(cmd, rptm_allreportinfo.CurrentPage);
                    FillSequrityParameters(rptm_allreportinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(rptm_allreportinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(rptm_allreportinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, rptm_allreportinfo.strCommonSerachParam);

                    IList<rptm_allreportinfoEntity> itemList = new List<rptm_allreportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_allreportinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        rptm_allreportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_allreportinfoDataAccess.GAPgListViewrptm_allreportinfo"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion
    }
}