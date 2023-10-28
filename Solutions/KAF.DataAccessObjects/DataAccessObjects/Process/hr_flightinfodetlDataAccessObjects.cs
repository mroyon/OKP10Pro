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

    internal sealed partial class hr_flightinfodetlDataAccessObjects : BaseDataAccess, Ihr_flightinfodetlDataAccessObjects
    {

        #region Constructors

        private string ClassName = "hr_flightinfodetlDataAccessObjects";

        public hr_flightinfodetlDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(hr_flightinfodetlEntity hr_flightinfodetl, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (hr_flightinfodetl.flightdetlid.HasValue)
                Database.AddInParameter(cmd, "@FlightDetlID", DbType.Int64, hr_flightinfodetl.flightdetlid);
            if (forDelete) return;

            if (hr_flightinfodetl.prevflightdetlid.HasValue)
                Database.AddInParameter(cmd, "@PrevFlightDetlID", DbType.Int64, hr_flightinfodetl.prevflightdetlid);
            if ((hr_flightinfodetl.reissued != null))
                Database.AddInParameter(cmd, "@ReIssued", DbType.Boolean, hr_flightinfodetl.reissued);

            if (hr_flightinfodetl.flightid.HasValue)
                Database.AddInParameter(cmd, "@FlightID", DbType.Int64, hr_flightinfodetl.flightid);
            if (hr_flightinfodetl.ptidetlid.HasValue)
                Database.AddInParameter(cmd, "@PTIDetlID", DbType.Int64, hr_flightinfodetl.ptidetlid);
            if (hr_flightinfodetl.hrbasicid.HasValue)
                Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_flightinfodetl.hrbasicid);
            if (hr_flightinfodetl.hrsvcid.HasValue)
                Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_flightinfodetl.hrsvcid);
            if (!(string.IsNullOrEmpty(hr_flightinfodetl.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_flightinfodetl.remarks);
            if ((hr_flightinfodetl.iscancel != null))
                Database.AddInParameter(cmd, "@IsCancel", DbType.Boolean, hr_flightinfodetl.iscancel);
            if ((hr_flightinfodetl.canceldate.HasValue))
                Database.AddInParameter(cmd, "@CancelDate", DbType.DateTime, hr_flightinfodetl.canceldate);
            if ((hr_flightinfodetl.cancelletterdate.HasValue))
                Database.AddInParameter(cmd, "@CancelLetterDate", DbType.DateTime, hr_flightinfodetl.cancelletterdate);
            if (!(string.IsNullOrEmpty(hr_flightinfodetl.cancelletterno)))
                Database.AddInParameter(cmd, "@CancelLetterNo", DbType.String, hr_flightinfodetl.cancelletterno);
            if (!(string.IsNullOrEmpty(hr_flightinfodetl.reason)))
                Database.AddInParameter(cmd, "@Reason", DbType.String, hr_flightinfodetl.reason);
            if ((hr_flightinfodetl.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_flightinfodetl.ex_date1);
            if ((hr_flightinfodetl.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_flightinfodetl.ex_date2);
            if (!(string.IsNullOrEmpty(hr_flightinfodetl.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_flightinfodetl.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(hr_flightinfodetl.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_flightinfodetl.ex_nvarchar2);
            if (hr_flightinfodetl.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_flightinfodetl.ex_bigint1);
            if (hr_flightinfodetl.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_flightinfodetl.ex_bigint2);
            if (hr_flightinfodetl.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_flightinfodetl.ex_decimal1);
            if (hr_flightinfodetl.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_flightinfodetl.ex_decimal2);

        }


        #region Add Operation

        long Ihr_flightinfodetlDataAccessObjects.Add(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            long returnCode = -99;
            const string SP = "hr_flightinfodetl_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_flightinfodetl, cmd, Database);
                FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Addhr_flightinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Ihr_flightinfodetlDataAccessObjects.Update(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            long returnCode = -99;
            const string SP = "hr_flightinfodetl_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_flightinfodetl, cmd, Database);
                FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Updatehr_flightinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation
        
         long Ihr_flightinfodetlDataAccessObjects.Delete_ReIssue(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            long returnCode = -99;
            const string SP = "hr_flightinfodet_Del_ReIssuedFlight";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_flightinfodetl, cmd, Database, true);
                FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Deletehr_flightinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        long Ihr_flightinfodetlDataAccessObjects.Delete(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            long returnCode = -99;
            const string SP = "hr_flightinfodetl_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_flightinfodetl, cmd, Database, true);
                FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Deletehr_flightinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        long Ihr_flightinfodetlDataAccessObjects.SaveList(IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_flightinfodetl_Ins";
            const string SPUpdate = "hr_flightinfodetl_Upd";
            const string SPDelete = "hr_flightinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_flightinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_flightinfodetl, cmd, Database);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_flightinfodetl, cmd, Database);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Save_hr_flightinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        long Ihr_flightinfodetlDataAccessObjects.SaveCancelReIssueList(IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPUpdate = "hr_flightinfodetl_Upd_CancelReIssue";
            const string SPDelete = "hr_flightinfodetl_Del_CancelReIssue";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_flightinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_flightinfodetl, cmd, Database);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Save_hr_flightinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        public long SaveList(Database db, DbTransaction transaction, IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_flightinfodetl_Ins";
            string SPUpdate = "hr_flightinfodetl_Upd";
            const string SPDelete = "hr_flightinfodetl_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_flightinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, db);
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


                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listUpdated)
                    {

                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {

                            if (hr_flightinfodetl.flightdetlid.HasValue)
                                Database.AddInParameter(cmd, "@FlightDetlID", DbType.Int64, hr_flightinfodetl.flightdetlid);

                            if (hr_flightinfodetl.flightid.HasValue)
                                Database.AddInParameter(cmd, "@FlightID", DbType.Int64, hr_flightinfodetl.flightid);
                            if (hr_flightinfodetl.ptidetlid.HasValue)
                                Database.AddInParameter(cmd, "@PTIDetlID", DbType.Int64, hr_flightinfodetl.ptidetlid);
                            if (hr_flightinfodetl.hrbasicid.HasValue)
                                Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_flightinfodetl.hrbasicid);
                            if (hr_flightinfodetl.hrsvcid.HasValue)
                                Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_flightinfodetl.hrsvcid);
                            if (!(string.IsNullOrEmpty(hr_flightinfodetl.remarks)))
                                Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_flightinfodetl.remarks);
                            if (hr_flightinfodetl.iscancel == false)
                            {
                                Database.AddInParameter(cmd, "@IsCancel", DbType.Boolean, null);
                                Database.AddInParameter(cmd, "@CancelDate", DbType.DateTime, null);
                                Database.AddInParameter(cmd, "@CancelLetterDate", DbType.DateTime, null);
                                Database.AddInParameter(cmd, "@CancelLetterNo", DbType.String, null);
                                Database.AddInParameter(cmd, "@Reason", DbType.String, null);

                            }
                            else
                            {

                                Database.AddInParameter(cmd, "@IsCancel", DbType.Boolean, hr_flightinfodetl.iscancel);
                                Database.AddInParameter(cmd, "@CancelDate", DbType.DateTime, hr_flightinfodetl.canceldate);
                                Database.AddInParameter(cmd, "@CancelLetterDate", DbType.DateTime, hr_flightinfodetl.cancelletterdate);
                                Database.AddInParameter(cmd, "@CancelLetterNo", DbType.String, hr_flightinfodetl.cancelletterno);
                                Database.AddInParameter(cmd, "@Reason", DbType.String, hr_flightinfodetl.reason);
                            }

                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_flightinfodetlEntity hr_flightinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_flightinfodetl, cmd, db);
                            FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.Save_hr_flightinfodetl"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        IList<hr_flightinfodetlEntity> Ihr_flightinfodetlDataAccessObjects.GetAll(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            try
            {
                const string SP = "hr_flightinfodetl_GA";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, hr_flightinfodetl.SortExpression);
                    FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_flightinfodetl, cmd, Database);

                    IList<hr_flightinfodetlEntity> itemList = new List<hr_flightinfodetlEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfodetlEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.GetAllhr_flightinfodetl"));
            }
        }

        IList<hr_flightinfodetlEntity> Ihr_flightinfodetlDataAccessObjects.GetAllByPages(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            try
            {
                const string SP = "hr_flightinfodetl_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_flightinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_flightinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_flightinfodetl.CurrentPage);
                    FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_flightinfodetl, cmd, Database);

                    IList<hr_flightinfodetlEntity> itemList = new List<hr_flightinfodetlEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfodetlEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_flightinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.GetAllByPageshr_flightinfodetl"));
            }
        }

        #endregion

        #region Save Master/Details


        long Ihr_flightinfodetlDataAccessObjects.SaveMasterDethr_arrivalinfodetl(hr_flightinfodetlEntity masterEntity,
        IList<hr_arrivalinfodetlEntity> listAdded,
        IList<hr_arrivalinfodetlEntity> listUpdated,
        IList<hr_arrivalinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_flightinfodetl_Ins";
            const string MasterSPUpdate = "hr_flightinfodetl_Upd";
            const string MasterSPDelete = "hr_flightinfodetl_Del";


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
                                item.flightdetlid = PrimaryKeyMaster;
                            }
                        }
                        hr_arrivalinfodetlDataAccessObjects objhr_arrivalinfodetl = new hr_arrivalinfodetlDataAccessObjects(this.Context);
                        objhr_arrivalinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.SaveDshr_flightinfodetl"));
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
        hr_flightinfodetlEntity Ihr_flightinfodetlDataAccessObjects.GetSingle(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            try
            {
                const string SP = "hr_flightinfodetl_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_flightinfodetl, cmd, Database);

                    IList<hr_flightinfodetlEntity> itemList = new List<hr_flightinfodetlEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.GetSinglehr_flightinfodetl"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<hr_flightinfodetlEntity> Ihr_flightinfodetlDataAccessObjects.GAPgListView(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            try
            {
                const string SP = "hr_flightinfodetl_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_flightinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_flightinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_flightinfodetl.CurrentPage);
                    FillSequrityParameters(hr_flightinfodetl.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_flightinfodetl, cmd, Database);

                    if (!string.IsNullOrEmpty(hr_flightinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_flightinfodetl.strCommonSerachParam);

                    IList<hr_flightinfodetlEntity> itemList = new List<hr_flightinfodetlEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfodetlEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_flightinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfodetlDataAccess.GAPgListViewhr_flightinfodetl"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion
    }
}