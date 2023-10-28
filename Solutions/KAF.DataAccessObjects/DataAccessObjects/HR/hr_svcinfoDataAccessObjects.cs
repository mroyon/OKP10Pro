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

    internal sealed partial class hr_svcinfoDataAccessObjects : BaseDataAccess, Ihr_svcinfoDataAccessObjects
    {

        #region Constructors

        private string ClassName = "hr_svcinfoDataAccessObjects";

        public hr_svcinfoDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(hr_svcinfoEntity hr_svcinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (hr_svcinfo.hrsvcid.HasValue)
                Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_svcinfo.hrsvcid);
            if (forDelete) return;
            if (hr_svcinfo.hrbasicid.HasValue)
                Database.AddInParameter(cmd, "@HRBasicID", DbType.Int64, hr_svcinfo.hrbasicid);
            if (hr_svcinfo.militarynokw.HasValue)
                Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, hr_svcinfo.militarynokw);
            if (!(string.IsNullOrEmpty(hr_svcinfo.passportno)))
                Database.AddInParameter(cmd, "@PassportNo", DbType.String, hr_svcinfo.passportno);
            if ((hr_svcinfo.joindatekw.HasValue))
                Database.AddInParameter(cmd, "@JoinDateKw", DbType.DateTime, hr_svcinfo.joindatekw);
            if ((hr_svcinfo.expectedretiredatekw.HasValue))
                Database.AddInParameter(cmd, "@ExpectedRetireDateKw", DbType.DateTime, hr_svcinfo.expectedretiredatekw);

            Database.AddInParameter(cmd, "@UserID", DbType.Guid, hr_svcinfo.userid);
            if (hr_svcinfo.entitykey.HasValue)
                Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, hr_svcinfo.entitykey);
            if (hr_svcinfo.armsid.HasValue)
                Database.AddInParameter(cmd, "@ArmsID", DbType.Int64, hr_svcinfo.armsid);
            if (hr_svcinfo.okpid.HasValue)
                Database.AddInParameter(cmd, "@OkpID", DbType.Int64, hr_svcinfo.okpid);
            if (hr_svcinfo.rankidkw.HasValue)
                Database.AddInParameter(cmd, "@RankIDKW", DbType.Int64, hr_svcinfo.rankidkw);
            if (hr_svcinfo.rankidbd.HasValue)
                Database.AddInParameter(cmd, "@RankIDBD", DbType.Int64, hr_svcinfo.rankidbd);
            if (hr_svcinfo.tradeidbd.HasValue)
                Database.AddInParameter(cmd, "@TradeIDBD", DbType.Int64, hr_svcinfo.tradeidbd);
            if (hr_svcinfo.tradeidkw.HasValue)
                Database.AddInParameter(cmd, "@TradeIDKW", DbType.Int64, hr_svcinfo.tradeidkw);
            if (hr_svcinfo.groupid.HasValue)
                Database.AddInParameter(cmd, "@GroupID", DbType.Int64, hr_svcinfo.groupid);

            if (hr_svcinfo.subunitid.HasValue)
                Database.AddInParameter(cmd, "@subunitid", DbType.Int64, hr_svcinfo.subunitid);
            if (hr_svcinfo.campid.HasValue)
                Database.AddInParameter(cmd, "@campid", DbType.Int64, hr_svcinfo.campid);

            if (hr_svcinfo.organizationkey.HasValue)
                Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, hr_svcinfo.organizationkey);
            if (hr_svcinfo.status.HasValue)
                Database.AddInParameter(cmd, "@Status", DbType.Int64, hr_svcinfo.status);
            if (!(string.IsNullOrEmpty(hr_svcinfo.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_svcinfo.remarks);
            if ((hr_svcinfo.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_svcinfo.ex_date1);
            if ((hr_svcinfo.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_svcinfo.ex_date2);
            if (!(string.IsNullOrEmpty(hr_svcinfo.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_svcinfo.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(hr_svcinfo.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_svcinfo.ex_nvarchar2);
            if (hr_svcinfo.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_svcinfo.ex_bigint1);
            if (hr_svcinfo.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_svcinfo.ex_bigint2);
            if (hr_svcinfo.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_svcinfo.ex_decimal1);
            if (hr_svcinfo.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_svcinfo.ex_decimal2);

        }


        #region Add Operation

        long Ihr_svcinfoDataAccessObjects.Add(hr_svcinfoEntity hr_svcinfo)
        {
            long returnCode = -99;
            const string SP = "hr_svcinfo_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_svcinfo, cmd, Database);
                FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Addhr_svcinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Ihr_svcinfoDataAccessObjects.Update(hr_svcinfoEntity hr_svcinfo)
        {
            long returnCode = -99;
            const string SP = "hr_svcinfo_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_svcinfo, cmd, Database);
                FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Updatehr_svcinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        long Ihr_svcinfoDataAccessObjects.Delete(hr_svcinfoEntity hr_svcinfo)
        {
            long returnCode = -99;
            const string SP = "hr_svcinfo_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_svcinfo, cmd, Database, true);
                FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Deletehr_svcinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        long Ihr_svcinfoDataAccessObjects.SaveList(IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_svcinfo_Ins";
            const string SPUpdate = "hr_svcinfo_Upd";
            const string SPDelete = "hr_svcinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_svcinfoEntity hr_svcinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_svcinfo, cmd, Database, true);
                            FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_svcinfoEntity hr_svcinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_svcinfo, cmd, Database);
                            FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_svcinfoEntity hr_svcinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_svcinfo, cmd, Database);
                            FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Save_hr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }



        public long SaveList(Database db, DbTransaction transaction, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_svcinfo_Ins";
            const string SPUpdate = "hr_svcinfo_Upd";
            const string SPDelete = "hr_svcinfo_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_svcinfoEntity hr_svcinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_svcinfo, cmd, db, true);
                            FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_svcinfoEntity hr_svcinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_svcinfo, cmd, db);
                            FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_svcinfoEntity hr_svcinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_svcinfo, cmd, db);
                            FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Save_hr_svcinfo"));
            }
            finally
            {

            }
            return returnCode;
        }

        public long Save_Single(Database db, DbTransaction transaction, hr_svcinfoEntity objSingle)
        {
            long returnCode = -99;

            const string SPInsert = "hr_svcinfo_Ins";
            const string SPUpdate = "hr_svcinfo_Upd";
            const string SPDelete = "hr_svcinfo_Del";



            try
            {
                if (objSingle.CurrentState == BaseEntity.EntityState.Deleted)
                {
                    using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                    {
                        FillParameters(objSingle, cmd, db, true);
                        FillSequrityParameters(objSingle.BaseSecurityParam, cmd, db);
                        AddOutputParameter(cmd);
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        if (returnCode < 0)
                        {
                            throw new ArgumentException("Error in transaction.");
                        }
                        cmd.Dispose();
                    }

                }
                if (objSingle.CurrentState == BaseEntity.EntityState.Changed)
                {
                    using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                    {
                        FillParameters(objSingle, cmd, db);
                        FillSequrityParameters(objSingle.BaseSecurityParam, cmd, db);
                        AddOutputParameter(cmd);
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        if (returnCode < 0)
                        {
                            throw new ArgumentException("Error in transaction.");
                        }
                        cmd.Dispose();
                    }

                }
                if (objSingle.CurrentState == BaseEntity.EntityState.Added)
                {
                    using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                    {
                        FillParameters(objSingle, cmd, db);
                        FillSequrityParameters(objSingle.BaseSecurityParam, cmd, db);
                        AddOutputParameter(cmd);

                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        if (returnCode < 0)
                        {
                            throw new ArgumentException("Error in transaction.");
                        }
                        cmd.Dispose();
                    }

                }


            }
            catch (Exception ex)
            {

                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Save_hr_svcinfo"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        IList<hr_svcinfoEntity> Ihr_svcinfoDataAccessObjects.GetAll(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                const string SP = "hr_svcinfo_GA";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, hr_svcinfo.SortExpression);
                    FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_svcinfo, cmd, Database);

                    IList<hr_svcinfoEntity> itemList = new List<hr_svcinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_svcinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.GetAllhr_svcinfo"));
            }
        }

        IList<hr_svcinfoEntity> Ihr_svcinfoDataAccessObjects.GetAllByPages(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                const string SP = "hr_svcinfo_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_svcinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_svcinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_svcinfo.CurrentPage);
                    FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_svcinfo, cmd, Database);

                    IList<hr_svcinfoEntity> itemList = new List<hr_svcinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_svcinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_svcinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.GetAllByPageshr_svcinfo"));
            }
        }

        #endregion

        #region Save Master/Details


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_arrivalinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_arrivalinfodetlEntity> listAdded,
        IList<hr_arrivalinfodetlEntity> listUpdated,
        IList<hr_arrivalinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_demanddetlpassport(hr_svcinfoEntity masterEntity,
        IList<hr_demanddetlpassportEntity> listAdded,
        IList<hr_demanddetlpassportEntity> listUpdated,
        IList<hr_demanddetlpassportEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_demanddetlpassportDataAccessObjects objhr_demanddetlpassport = new hr_demanddetlpassportDataAccessObjects(this.Context);
                        objhr_demanddetlpassport.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_flightinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_flightinfodetlEntity> listAdded,
        IList<hr_flightinfodetlEntity> listUpdated,
        IList<hr_flightinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_flightinfodetlDataAccessObjects objhr_flightinfodetl = new hr_flightinfodetlDataAccessObjects(this.Context);
                        objhr_flightinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_ptademanddetl(hr_svcinfoEntity masterEntity,
        IList<hr_ptademanddetlEntity> listAdded,
        IList<hr_ptademanddetlEntity> listUpdated,
        IList<hr_ptademanddetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_ptademanddetlDataAccessObjects objhr_ptademanddetl = new hr_ptademanddetlDataAccessObjects(this.Context);
                        objhr_ptademanddetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_repatriationinfo(hr_svcinfoEntity masterEntity,
        IList<hr_repatriationinfoEntity> listAdded,
        IList<hr_repatriationinfoEntity> listUpdated,
        IList<hr_repatriationinfoEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_repatriationinfoDataAccessObjects objhr_repatriationinfo = new hr_repatriationinfoDataAccessObjects(this.Context);
                        objhr_repatriationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_replacementinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_replacementinfodetlEntity> listAdded,
        IList<hr_replacementinfodetlEntity> listUpdated,
        IList<hr_replacementinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_replacementinfodetlDataAccessObjects objhr_replacementinfodetl = new hr_replacementinfodetlDataAccessObjects(this.Context);
                        objhr_replacementinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_reppassportinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_reppassportinfodetlEntity> listAdded,
        IList<hr_reppassportinfodetlEntity> listUpdated,
        IList<hr_reppassportinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_reppassportinfodetlDataAccessObjects objhr_reppassportinfodetl = new hr_reppassportinfodetlDataAccessObjects(this.Context);
                        objhr_reppassportinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_visademandinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_visademandinfodetlEntity> listAdded,
        IList<hr_visademandinfodetlEntity> listUpdated,
        IList<hr_visademandinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_visademandinfodetlDataAccessObjects objhr_visademandinfodetl = new hr_visademandinfodetlDataAccessObjects(this.Context);
                        objhr_visademandinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_visaissueinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_visaissueinfodetlEntity> listAdded,
        IList<hr_visaissueinfodetlEntity> listUpdated,
        IList<hr_visaissueinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_visaissueinfodetlDataAccessObjects objhr_visaissueinfodetl = new hr_visaissueinfodetlDataAccessObjects(this.Context);
                        objhr_visaissueinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        long Ihr_svcinfoDataAccessObjects.SaveMasterDethr_visasentinfodetl(hr_svcinfoEntity masterEntity,
        IList<hr_visasentinfodetlEntity> listAdded,
        IList<hr_visasentinfodetlEntity> listUpdated,
        IList<hr_visasentinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "hr_svcinfo_Ins";
            const string MasterSPUpdate = "hr_svcinfo_Upd";
            const string MasterSPDelete = "hr_svcinfo_Del";


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
                                item.hrsvcid = PrimaryKeyMaster;
                            }
                        }
                        hr_visasentinfodetlDataAccessObjects objhr_visasentinfodetl = new hr_visasentinfodetlDataAccessObjects(this.Context);
                        objhr_visasentinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.SaveDshr_svcinfo"));
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
        hr_svcinfoEntity Ihr_svcinfoDataAccessObjects.GetSingle(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                const string SP = "hr_svcinfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_svcinfo, cmd, Database);

                    IList<hr_svcinfoEntity> itemList = new List<hr_svcinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_svcinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.GetSinglehr_svcinfo"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<hr_svcinfoEntity> Ihr_svcinfoDataAccessObjects.GAPgListView(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                const string SP = "hr_svcinfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_svcinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_svcinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_svcinfo.CurrentPage);
                    FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_svcinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(hr_svcinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_svcinfo.strCommonSerachParam);

                    IList<hr_svcinfoEntity> itemList = new List<hr_svcinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_svcinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_svcinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.GAPgListViewhr_svcinfo"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion
    }
}