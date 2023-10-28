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
using KAF.DataAccessObjects.DataAccessObjectsPartial;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

namespace KAF.DataAccessObjects
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class hr_replacementinfoDataAccessObjects : BaseDataAccess, Ihr_replacementinfoDataAccessObjects
    {

        #region Constructors

        private string ClassName = "hr_replacementinfoDataAccessObjects";

        public hr_replacementinfoDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(hr_replacementinfoEntity hr_replacementinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (hr_replacementinfo.replacementid.HasValue)
                Database.AddInParameter(cmd, "@ReplacementID", DbType.Int64, hr_replacementinfo.replacementid);
            if (forDelete) return;
            if (!(string.IsNullOrEmpty(hr_replacementinfo.letterno)))
                Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_replacementinfo.letterno);
            if ((hr_replacementinfo.letterdate.HasValue))
                Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_replacementinfo.letterdate);
            if (!(string.IsNullOrEmpty(hr_replacementinfo.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_replacementinfo.remarks);
            if ((hr_replacementinfo.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_replacementinfo.ex_date1);
            if ((hr_replacementinfo.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_replacementinfo.ex_date2);
            if (!(string.IsNullOrEmpty(hr_replacementinfo.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_replacementinfo.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(hr_replacementinfo.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_replacementinfo.ex_nvarchar2);
            if (hr_replacementinfo.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_replacementinfo.ex_bigint1);
            if (hr_replacementinfo.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_replacementinfo.ex_bigint2);
            if (hr_replacementinfo.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_replacementinfo.ex_decimal1);
            if (hr_replacementinfo.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_replacementinfo.ex_decimal2);

        }


        #region Add Operation

        long Ihr_replacementinfoDataAccessObjects.Add(hr_replacementinfoEntity hr_replacementinfo)
        {
            long returnCode = -99;
            const string SP = "hr_replacementinfo_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_replacementinfo, cmd, Database);
                FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.Addhr_replacementinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Ihr_replacementinfoDataAccessObjects.Update(hr_replacementinfoEntity hr_replacementinfo)
        {
            long returnCode = -99;
            const string SP = "hr_replacementinfo_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_replacementinfo, cmd, Database);
                FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.Updatehr_replacementinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        long Ihr_replacementinfoDataAccessObjects.Delete(hr_replacementinfoEntity hr_replacementinfo)
        {
            long returnCode = -99;
            const string SP = "hr_replacementinfo_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_replacementinfo, cmd, Database, true);
                FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.Deletehr_replacementinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        long Ihr_replacementinfoDataAccessObjects.SaveList(IList<hr_replacementinfoEntity> listAdded, IList<hr_replacementinfoEntity> listUpdated, IList<hr_replacementinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_replacementinfo_Ins";
            const string SPUpdate = "hr_replacementinfo_Upd";
            const string SPDelete = "hr_replacementinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_replacementinfoEntity hr_replacementinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_replacementinfo, cmd, Database, true);
                            FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_replacementinfoEntity hr_replacementinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_replacementinfo, cmd, Database);
                            FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_replacementinfoEntity hr_replacementinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_replacementinfo, cmd, Database);
                            FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.Save_hr_replacementinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }



        public long SaveList(Database db, DbTransaction transaction, IList<hr_replacementinfoEntity> listAdded, IList<hr_replacementinfoEntity> listUpdated, IList<hr_replacementinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_replacementinfo_Ins";
            const string SPUpdate = "hr_replacementinfo_Upd";
            const string SPDelete = "hr_replacementinfo_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_replacementinfoEntity hr_replacementinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_replacementinfo, cmd, db, true);
                            FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_replacementinfoEntity hr_replacementinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_replacementinfo, cmd, db);
                            FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_replacementinfoEntity hr_replacementinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_replacementinfo, cmd, db);
                            FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.Save_hr_replacementinfo"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        IList<hr_replacementinfoEntity> Ihr_replacementinfoDataAccessObjects.GetAll(hr_replacementinfoEntity hr_replacementinfo)
        {
            try
            {
                const string SP = "hr_replacementinfo_GA";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, hr_replacementinfo.SortExpression);
                    FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_replacementinfo, cmd, Database);

                    IList<hr_replacementinfoEntity> itemList = new List<hr_replacementinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.GetAllhr_replacementinfo"));
            }
        }

        IList<hr_replacementinfoEntity> Ihr_replacementinfoDataAccessObjects.GetAllByPages(hr_replacementinfoEntity hr_replacementinfo)
        {
            try
            {
                const string SP = "hr_replacementinfo_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_replacementinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_replacementinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_replacementinfo.CurrentPage);
                    FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_replacementinfo, cmd, Database);

                    IList<hr_replacementinfoEntity> itemList = new List<hr_replacementinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_replacementinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.GetAllByPageshr_replacementinfo"));
            }
        }

        #endregion

        #region Save Master/Details


        long Ihr_replacementinfoDataAccessObjects.SaveMasterDethr_replacementinfodetl(hr_replacementinfoEntity masterEntity,
        IList<hr_replacementinfodetlEntity> listAdded,
        IList<hr_replacementinfodetlEntity> listUpdated,
        IList<hr_replacementinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_replacementinfo_Ins";
            const string MasterSPUpdate = "hr_replacementinfo_Upd";
            const string MasterSPDelete = "hr_replacementinfo_Del";


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
                                item.replacementid = PrimaryKeyMaster;
                            }
                        }
                        hr_replacementinfodetlDataAccessObjects objhr_replacementinfodetl = new hr_replacementinfodetlDataAccessObjects(this.Context);
                        objhr_replacementinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        ReportExtensionDataAccess objReport = new ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new KAFProcess_UpdateLetterStatusEntity
                            {
                                LetterID = PrimaryKeyMaster,
                                LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                                LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.Initiated),
                            }

                        );
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.SaveDshr_replacementinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_replacementinfoDataAccessObjects.SaveMasterDethr_reppassportinfo(hr_replacementinfoEntity masterEntity,
        IList<hr_reppassportinfoEntity> listAdded,
        IList<hr_reppassportinfoEntity> listUpdated,
        IList<hr_reppassportinfoEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_replacementinfo_Ins";
            const string MasterSPUpdate = "hr_replacementinfo_Upd";
            const string MasterSPDelete = "hr_replacementinfo_Del";


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
                                item.replacementid = PrimaryKeyMaster;
                            }
                        }
                        hr_reppassportinfoDataAccessObjects objhr_reppassportinfo = new hr_reppassportinfoDataAccessObjects(this.Context);
                        objhr_reppassportinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.SaveDshr_replacementinfo"));
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
        hr_replacementinfoEntity Ihr_replacementinfoDataAccessObjects.GetSingle(hr_replacementinfoEntity hr_replacementinfo)
        {
            try
            {
                const string SP = "hr_replacementinfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_replacementinfo, cmd, Database);

                    IList<hr_replacementinfoEntity> itemList = new List<hr_replacementinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.GetSinglehr_replacementinfo"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<hr_replacementinfoEntity> Ihr_replacementinfoDataAccessObjects.GAPgListView(hr_replacementinfoEntity hr_replacementinfo)
        {
            try
            {
                const string SP = "hr_replacementinfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_replacementinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_replacementinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_replacementinfo.CurrentPage);
                    FillSequrityParameters(hr_replacementinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_replacementinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(hr_replacementinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_replacementinfo.strCommonSerachParam);

                    IList<hr_replacementinfoEntity> itemList = new List<hr_replacementinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_replacementinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfoDataAccess.GAPgListViewhr_replacementinfo"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion
    }
}