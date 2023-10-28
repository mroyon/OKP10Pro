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

    internal sealed partial class tran_cuttinginfoDataAccessObjects : BaseDataAccess, Itran_cuttinginfoDataAccessObjects
    {

        #region Constructors

        private string ClassName = "tran_cuttinginfoDataAccessObjects";

        public tran_cuttinginfoDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(tran_cuttinginfoEntity tran_cuttinginfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (tran_cuttinginfo.cuttinginfoid.HasValue)
                Database.AddInParameter(cmd, "@CuttingInfoID", DbType.Int64, tran_cuttinginfo.cuttinginfoid);
            if (forDelete) return;
            if (tran_cuttinginfo.okpid.HasValue)
                Database.AddInParameter(cmd, "@OkpID", DbType.Int64, tran_cuttinginfo.okpid);
            if (tran_cuttinginfo.monthid.HasValue)
                Database.AddInParameter(cmd, "@MonthID", DbType.Int64, tran_cuttinginfo.monthid);
            if (tran_cuttinginfo.year.HasValue)
                Database.AddInParameter(cmd, "@Year", DbType.Int64, tran_cuttinginfo.year);
            if ((tran_cuttinginfo.processdate.HasValue))
                Database.AddInParameter(cmd, "@ProcessDate", DbType.DateTime, tran_cuttinginfo.processdate);

            if (tran_cuttinginfo.isfinal.HasValue)
                Database.AddInParameter(cmd, "@isfinal", DbType.Boolean, tran_cuttinginfo.isfinal);
            if (tran_cuttinginfo.finaldate.HasValue)
                Database.AddInParameter(cmd, "@finaldate", DbType.DateTime, tran_cuttinginfo.finaldate);
            if ((tran_cuttinginfo.finalby.HasValue))
                Database.AddInParameter(cmd, "@finalby", DbType.Int64, tran_cuttinginfo.finalby);

            Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, tran_cuttinginfo.isreviewed);

            Database.AddInParameter(cmd, "@ReviewDate", DbType.DateTime, tran_cuttinginfo.reviewdate);

            Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, tran_cuttinginfo.reviewedby);

            Database.AddInParameter(cmd, "@ReviewRemarks", DbType.String, tran_cuttinginfo.reviewremarks);

            Database.AddInParameter(cmd, "@IsApproved", DbType.Boolean, tran_cuttinginfo.isapproved);

            Database.AddInParameter(cmd, "@ApproveDate", DbType.DateTime, tran_cuttinginfo.approvedate);

            Database.AddInParameter(cmd, "@ApproveBy", DbType.Int64, tran_cuttinginfo.approveby);

            Database.AddInParameter(cmd, "@ApproveRemarks", DbType.String, tran_cuttinginfo.approveremarks);



            Database.AddInParameter(cmd, "@isrollback", DbType.Boolean, tran_cuttinginfo.isrollback);

            Database.AddInParameter(cmd, "@rollbackdate", DbType.DateTime, tran_cuttinginfo.rollbackdate);

            Database.AddInParameter(cmd, "@rollbackby", DbType.Int64, tran_cuttinginfo.rollbackby);

            Database.AddInParameter(cmd, "@rollbackremarks", DbType.String, tran_cuttinginfo.rollbackremarks);

            if ((tran_cuttinginfo.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, tran_cuttinginfo.ex_date1);
            if ((tran_cuttinginfo.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, tran_cuttinginfo.ex_date2);
            if (!(string.IsNullOrEmpty(tran_cuttinginfo.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, tran_cuttinginfo.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(tran_cuttinginfo.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, tran_cuttinginfo.ex_nvarchar2);
            if (tran_cuttinginfo.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, tran_cuttinginfo.ex_bigint1);
            if (tran_cuttinginfo.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, tran_cuttinginfo.ex_bigint2);
            if (tran_cuttinginfo.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, tran_cuttinginfo.ex_decimal1);
            if (tran_cuttinginfo.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, tran_cuttinginfo.ex_decimal2);

        }


        #region Add Operation

        long Itran_cuttinginfoDataAccessObjects.Add(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            long returnCode = -99;
            const string SP = "tran_cuttinginfo_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_cuttinginfo, cmd, Database);
                FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.Addtran_cuttinginfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Itran_cuttinginfoDataAccessObjects.Update(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            long returnCode = -99;
            string SP = "tran_cuttinginfo_Upd";

            if(tran_cuttinginfo.isReject==true)
            {
                SP = "tran_cuttinginfo_Upd_ReviewReject";
            }
            else if (tran_cuttinginfo.isProcess == true)
            {
                SP = "tran_cuttinginfo_Upd_Ext";
            }

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_cuttinginfo, cmd, Database);
                FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.Updatetran_cuttinginfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        long Itran_cuttinginfoDataAccessObjects.Delete(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            long returnCode = -99;
            const string SP = "tran_cuttinginfo_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_cuttinginfo, cmd, Database, true);
                FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.Deletetran_cuttinginfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        long Itran_cuttinginfoDataAccessObjects.SaveList(IList<tran_cuttinginfoEntity> listAdded, IList<tran_cuttinginfoEntity> listUpdated, IList<tran_cuttinginfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_cuttinginfo_Ins";
            const string SPUpdate = "tran_cuttinginfo_Upd";
            const string SPDelete = "tran_cuttinginfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_cuttinginfoEntity tran_cuttinginfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_cuttinginfo, cmd, Database, true);
                            FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_cuttinginfoEntity tran_cuttinginfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_cuttinginfo, cmd, Database);
                            FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_cuttinginfoEntity tran_cuttinginfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_cuttinginfo, cmd, Database);
                            FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.Save_tran_cuttinginfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }



        public long SaveList(Database db, DbTransaction transaction, IList<tran_cuttinginfoEntity> listAdded, IList<tran_cuttinginfoEntity> listUpdated, IList<tran_cuttinginfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_cuttinginfo_Ins";
            const string SPUpdate = "tran_cuttinginfo_Upd";
            const string SPDelete = "tran_cuttinginfo_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_cuttinginfoEntity tran_cuttinginfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_cuttinginfo, cmd, db, true);
                            FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, db);
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
                    foreach (tran_cuttinginfoEntity tran_cuttinginfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_cuttinginfo, cmd, db);
                            FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, db);
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
                    foreach (tran_cuttinginfoEntity tran_cuttinginfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_cuttinginfo, cmd, db);
                            FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.Save_tran_cuttinginfo"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        IList<tran_cuttinginfoEntity> Itran_cuttinginfoDataAccessObjects.GetAll(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            try
            {
                const string SP = "tran_cuttinginfo_GA";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_cuttinginfo.SortExpression);
                    FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_cuttinginfo, cmd, Database);

                    IList<tran_cuttinginfoEntity> itemList = new List<tran_cuttinginfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.GetAlltran_cuttinginfo"));
            }
        }

        IList<tran_cuttinginfoEntity> Itran_cuttinginfoDataAccessObjects.GetAllByPages(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            try
            {
                const string SP = "tran_cuttinginfo_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_cuttinginfo.SortExpression);
                    AddPageSizeParameter(cmd, tran_cuttinginfo.PageSize);
                    AddCurrentPageParameter(cmd, tran_cuttinginfo.CurrentPage);
                    FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_cuttinginfo, cmd, Database);

                    IList<tran_cuttinginfoEntity> itemList = new List<tran_cuttinginfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_cuttinginfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.GetAllByPagestran_cuttinginfo"));
            }
        }

        #endregion

        #region Save Master/Details


        long Itran_cuttinginfoDataAccessObjects.SaveMasterDettran_cuttinginfodetl(tran_cuttinginfoEntity masterEntity,
        IList<tran_cuttinginfodetlEntity> listAdded,
        IList<tran_cuttinginfodetlEntity> listUpdated,
        IList<tran_cuttinginfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "tran_cuttinginfo_Ins";
            const string MasterSPUpdate = "tran_cuttinginfo_Upd";
            const string MasterSPDelete = "tran_cuttinginfo_Del";


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
                                item.cuttinginfoid = PrimaryKeyMaster;
                            }
                        }
                        tran_cuttinginfodetlDataAccessObjects objtran_cuttinginfodetl = new tran_cuttinginfodetlDataAccessObjects(this.Context);
                        objtran_cuttinginfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.SaveDstran_cuttinginfo"));
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
        tran_cuttinginfoEntity Itran_cuttinginfoDataAccessObjects.GetSingle(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            try
            {
                const string SP = "tran_cuttinginfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_cuttinginfo, cmd, Database);

                    IList<tran_cuttinginfoEntity> itemList = new List<tran_cuttinginfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.GetSingletran_cuttinginfo"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<tran_cuttinginfoEntity> Itran_cuttinginfoDataAccessObjects.GAPgListView(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            try
            {
                const string SP = "tran_cuttinginfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_cuttinginfo.SortExpression);
                    AddPageSizeParameter(cmd, tran_cuttinginfo.PageSize);
                    AddCurrentPageParameter(cmd, tran_cuttinginfo.CurrentPage);
                    FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_cuttinginfo, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_cuttinginfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_cuttinginfo.strCommonSerachParam);

                    IList<tran_cuttinginfoEntity> itemList = new List<tran_cuttinginfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_cuttinginfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.GAPgListViewtran_cuttinginfo"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        long Itran_cuttinginfoDataAccessObjects.UpdateReviewed(tran_cuttinginfoEntity tran_cuttinginfo)
        {
            long returnCode = -99;
            const string SP = "tran_cuttinginfo_UpdRev";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_cuttinginfo, cmd, Database);
                FillSequrityParameters(tran_cuttinginfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfoDataAccess.UpdateReviewedtran_cuttinginfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        #endregion
    }
}