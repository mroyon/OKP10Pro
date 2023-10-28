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

    internal sealed partial class hr_reppassportinfoDataAccessObjects : BaseDataAccess, Ihr_reppassportinfoDataAccessObjects
    {

        #region Constructors

        private string ClassName = "hr_reppassportinfoDataAccessObjects";

        public hr_reppassportinfoDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(hr_reppassportinfoEntity hr_reppassportinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (hr_reppassportinfo.reppassportid.HasValue)
                Database.AddInParameter(cmd, "@RepPassportID", DbType.Int64, hr_reppassportinfo.reppassportid);
            if (forDelete) return;
            if (hr_reppassportinfo.replacementid.HasValue)
                Database.AddInParameter(cmd, "@ReplacementID", DbType.Int64, hr_reppassportinfo.replacementid);
            if ((hr_reppassportinfo.passportrecvdate.HasValue))
                Database.AddInParameter(cmd, "@PassportRecvDate", DbType.DateTime, hr_reppassportinfo.passportrecvdate);
            if ((hr_reppassportinfo.passportletterdate.HasValue))
                Database.AddInParameter(cmd, "@PassportLetterDate", DbType.DateTime, hr_reppassportinfo.passportletterdate);
            if (!(string.IsNullOrEmpty(hr_reppassportinfo.passportletterno)))
                Database.AddInParameter(cmd, "@PassportLetterNo", DbType.String, hr_reppassportinfo.passportletterno);
            if (!(string.IsNullOrEmpty(hr_reppassportinfo.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_reppassportinfo.remarks);
            if ((hr_reppassportinfo.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_reppassportinfo.ex_date1);
            if ((hr_reppassportinfo.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_reppassportinfo.ex_date2);
            if (!(string.IsNullOrEmpty(hr_reppassportinfo.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_reppassportinfo.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(hr_reppassportinfo.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_reppassportinfo.ex_nvarchar2);
            if (hr_reppassportinfo.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_reppassportinfo.ex_bigint1);
            if (hr_reppassportinfo.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_reppassportinfo.ex_bigint2);
            if (hr_reppassportinfo.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_reppassportinfo.ex_decimal1);
            if (hr_reppassportinfo.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_reppassportinfo.ex_decimal2);

        }


        #region Add Operation

        long Ihr_reppassportinfoDataAccessObjects.Add(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            long returnCode = -99;
            const string SP = "hr_reppassportinfo_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_reppassportinfo, cmd, Database);
                FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.Addhr_reppassportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Ihr_reppassportinfoDataAccessObjects.Update(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            long returnCode = -99;
            const string SP = "hr_reppassportinfo_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_reppassportinfo, cmd, Database);
                FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.Updatehr_reppassportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        long Ihr_reppassportinfoDataAccessObjects.Delete(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            long returnCode = -99;
            const string SP = "hr_reppassportinfo_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_reppassportinfo, cmd, Database, true);
                FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.Deletehr_reppassportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        long Ihr_reppassportinfoDataAccessObjects.SaveList(IList<hr_reppassportinfoEntity> listAdded, IList<hr_reppassportinfoEntity> listUpdated, IList<hr_reppassportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_reppassportinfo_Ins";
            const string SPUpdate = "hr_reppassportinfo_Upd";
            const string SPDelete = "hr_reppassportinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_reppassportinfoEntity hr_reppassportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_reppassportinfo, cmd, Database, true);
                            FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_reppassportinfoEntity hr_reppassportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_reppassportinfo, cmd, Database);
                            FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_reppassportinfoEntity hr_reppassportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_reppassportinfo, cmd, Database);
                            FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.Save_hr_reppassportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }



        public long SaveList(Database db, DbTransaction transaction, IList<hr_reppassportinfoEntity> listAdded, IList<hr_reppassportinfoEntity> listUpdated, IList<hr_reppassportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_reppassportinfo_Ins";
            const string SPUpdate = "hr_reppassportinfo_Upd";
            const string SPDelete = "hr_reppassportinfo_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (hr_reppassportinfoEntity hr_reppassportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_reppassportinfo, cmd, db, true);
                            FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_reppassportinfoEntity hr_reppassportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_reppassportinfo, cmd, db);
                            FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_reppassportinfoEntity hr_reppassportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_reppassportinfo, cmd, db);
                            FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.Save_hr_reppassportinfo"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        IList<hr_reppassportinfoEntity> Ihr_reppassportinfoDataAccessObjects.GetAll(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            try
            {
                const string SP = "hr_reppassportinfo_GA";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, hr_reppassportinfo.SortExpression);
                    FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_reppassportinfo, cmd, Database);

                    IList<hr_reppassportinfoEntity> itemList = new List<hr_reppassportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.GetAllhr_reppassportinfo"));
            }
        }

        IList<hr_reppassportinfoEntity> Ihr_reppassportinfoDataAccessObjects.GetAllByPages(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            try
            {
                const string SP = "hr_reppassportinfo_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_reppassportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_reppassportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_reppassportinfo.CurrentPage);
                    FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_reppassportinfo, cmd, Database);

                    IList<hr_reppassportinfoEntity> itemList = new List<hr_reppassportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_reppassportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.GetAllByPageshr_reppassportinfo"));
            }
        }

        #endregion

        #region Save Master/Details


        long Ihr_reppassportinfoDataAccessObjects.SaveMasterDethr_reppassportinfodetl(hr_reppassportinfoEntity masterEntity,
        IList<hr_reppassportinfodetlEntity> listAdded,
        IList<hr_reppassportinfodetlEntity> listUpdated,
        IList<hr_reppassportinfodetlEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;


            string SP = "";
            const string MasterSPInsert = "hr_reppassportinfo_Ins";
            const string MasterSPUpdate = "hr_reppassportinfo_Upd";
            const string MasterSPDelete = "hr_reppassportinfo_Del";


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

                        foreach (var item in listAdded)
                        {
                            item.reppassportid = PrimaryKeyMaster;

                            hr_basicprofileDataAccessObjects objHrBasic = new hr_basicprofileDataAccessObjects(this.Context);
                            hr_svcinfoDataAccessObjects objHrSvc = new hr_svcinfoDataAccessObjects(this.Context);

                            var hr_basicid = objHrBasic.Save_Single(Database, transaction, new hr_basicprofileEntity
                            {
                                name1 = item.firstname,
                                name2 = item.surname,
                                fullname= item.firstname +" "+ item.surname,
                                passportno = item.newpassportno,
                                CurrentState = BaseEntity.EntityState.Added,
                                BaseSecurityParam = masterEntity.BaseSecurityParam
                            });

                            var hr_svcid = objHrSvc.Save_Single(Database, transaction, new hr_svcinfoEntity
                            {
                                hrbasicid = hr_basicid,
                                passportno = item.newpassportno,
                                CurrentState = BaseEntity.EntityState.Added,
                                BaseSecurityParam = masterEntity.BaseSecurityParam
                            });

                            if (hr_basicid > 0 && hr_svcid > 0)
                            {
                                item.newhrbasicid = hr_basicid;
                                item.newhrsvcid = hr_svcid;
                            }
                        }

                        foreach (var item in listUpdated)
                        {
                            hr_basicprofileDataAccessObjects objHrBasic = new hr_basicprofileDataAccessObjects(this.Context);
                            hr_svcinfoDataAccessObjects objHrSvc = new hr_svcinfoDataAccessObjects(this.Context);

                            var hr_basicid = objHrBasic.Save_Single(Database, transaction, new hr_basicprofileEntity
                            {
                                hrbasicid = item.newhrbasicid,
                                name1 = item.firstname,
                                name2 = item.surname,
                                fullname = item.firstname + " " + item.surname,
                                passportno = item.newpassportno,
                                CurrentState = BaseEntity.EntityState.Changed,
                                BaseSecurityParam = masterEntity.BaseSecurityParam
                            });

                            var hr_svcid = objHrSvc.Save_Single(Database, transaction, new hr_svcinfoEntity
                            {
                                hrsvcid = item.newhrsvcid,
                                passportno = item.newpassportno,
                                CurrentState = BaseEntity.EntityState.Changed,
                                BaseSecurityParam = masterEntity.BaseSecurityParam
                            });

                            if (hr_basicid > 0 && hr_svcid > 0)
                            {
                                item.newhrbasicid = hr_basicid;
                                item.newhrsvcid = hr_svcid;
                            }
                        }

                        foreach (var item in listDeleted)
                        {
                            hr_basicprofileDataAccessObjects objHrBasic = new hr_basicprofileDataAccessObjects(this.Context);
                            hr_svcinfoDataAccessObjects objHrSvc = new hr_svcinfoDataAccessObjects(this.Context);

                            var hr_basicid = objHrBasic.Save_Single(Database, transaction, new hr_basicprofileEntity
                            {
                                hrbasicid = item.newhrbasicid,
                                name1 = item.firstname,
                                name2 = item.surname,
                                fullname = item.firstname + " " + item.surname,
                                passportno = item.newpassportno,
                                CurrentState = BaseEntity.EntityState.Deleted,
                                BaseSecurityParam = masterEntity.BaseSecurityParam
                            });

                            var hr_svcid = objHrSvc.Save_Single(Database, transaction, new hr_svcinfoEntity
                            {
                                hrsvcid = item.newhrsvcid,
                                passportno = item.newpassportno,
                                CurrentState = BaseEntity.EntityState.Deleted,
                                BaseSecurityParam = masterEntity.BaseSecurityParam
                            });
                            if (hr_basicid > 0 && hr_svcid > 0)
                            {
                                item.newhrbasicid = hr_basicid;
                                item.newhrsvcid = hr_svcid;
                            }

                        }

                        hr_reppassportinfodetlDataAccessObjects objhr_reppassportinfodetl = new hr_reppassportinfodetlDataAccessObjects(this.Context);

                        objhr_reppassportinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                            {
                                LetterID = PrimaryKeyMaster,
                                LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                                LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.PassportReceived),
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.SaveDshr_reppassportinfo"));
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
        hr_reppassportinfoEntity Ihr_reppassportinfoDataAccessObjects.GetSingle(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            try
            {
                const string SP = "hr_reppassportinfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_reppassportinfo, cmd, Database);

                    IList<hr_reppassportinfoEntity> itemList = new List<hr_reppassportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.GetSinglehr_reppassportinfo"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<hr_reppassportinfoEntity> Ihr_reppassportinfoDataAccessObjects.GAPgListView(hr_reppassportinfoEntity hr_reppassportinfo)
        {
            try
            {
                const string SP = "hr_reppassportinfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_reppassportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_reppassportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_reppassportinfo.CurrentPage);
                    FillSequrityParameters(hr_reppassportinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_reppassportinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(hr_reppassportinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_reppassportinfo.strCommonSerachParam);

                    IList<hr_reppassportinfoEntity> itemList = new List<hr_reppassportinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfoEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_reppassportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfoDataAccess.GAPgListViewhr_reppassportinfo"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion
    }
}