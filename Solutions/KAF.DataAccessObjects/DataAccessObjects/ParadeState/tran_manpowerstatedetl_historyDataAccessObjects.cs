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
	
	internal sealed partial class tran_manpowerstatedetl_historyDataAccessObjects : BaseDataAccess, Itran_manpowerstatedetl_historyDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_manpowerstatedetl_historyDataAccessObjects";
        
		public tran_manpowerstatedetl_historyDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_manpowerstatedetl_history.tran_manpowerstatedetl_historyid.HasValue)
				Database.AddInParameter(cmd, "@Tran_ManpowerStateDetl_HistoryID", DbType.Int64, tran_manpowerstatedetl_history.tran_manpowerstatedetl_historyid);
            if (forDelete) return;
			if (tran_manpowerstatedetl_history.manpowerstatedetlid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStateDetlID", DbType.Int64, tran_manpowerstatedetl_history.manpowerstatedetlid);
			if (tran_manpowerstatedetl_history.manpowerstateid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStateID", DbType.Int64, tran_manpowerstatedetl_history.manpowerstateid);
			if (tran_manpowerstatedetl_history.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, tran_manpowerstatedetl_history.hrbasicid);
			if (tran_manpowerstatedetl_history.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, tran_manpowerstatedetl_history.hrsvcid);
			if (tran_manpowerstatedetl_history.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, tran_manpowerstatedetl_history.rankid);
			if (tran_manpowerstatedetl_history.groupid.HasValue)
				Database.AddInParameter(cmd, "@GroupID", DbType.Int64, tran_manpowerstatedetl_history.groupid);
			if (tran_manpowerstatedetl_history.subunitid.HasValue)
				Database.AddInParameter(cmd, "@SubUnitID", DbType.Int64, tran_manpowerstatedetl_history.subunitid);
			if (tran_manpowerstatedetl_history.campid.HasValue)
				Database.AddInParameter(cmd, "@CampID", DbType.Int64, tran_manpowerstatedetl_history.campid);
			if (tran_manpowerstatedetl_history.manpowerstatusid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStatusID", DbType.Int64, tran_manpowerstatedetl_history.manpowerstatusid);
			if ((tran_manpowerstatedetl_history.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, tran_manpowerstatedetl_history.ex_date1);
			if ((tran_manpowerstatedetl_history.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, tran_manpowerstatedetl_history.ex_date2);
			if (!(string.IsNullOrEmpty(tran_manpowerstatedetl_history.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, tran_manpowerstatedetl_history.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(tran_manpowerstatedetl_history.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, tran_manpowerstatedetl_history.ex_nvarchar2);
			if (tran_manpowerstatedetl_history.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, tran_manpowerstatedetl_history.ex_bigint1);
			if (tran_manpowerstatedetl_history.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, tran_manpowerstatedetl_history.ex_bigint2);
			if (tran_manpowerstatedetl_history.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, tran_manpowerstatedetl_history.ex_decimal1);
			if (tran_manpowerstatedetl_history.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, tran_manpowerstatedetl_history.ex_decimal2);

        }
		
        
		#region Add Operation

        long Itran_manpowerstatedetl_historyDataAccessObjects.Add(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history  )
        {
            long returnCode = -99;
            const string SP = "tran_manpowerstatedetl_history_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_manpowerstatedetl_history, cmd,Database);
                FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.Addtran_manpowerstatedetl_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Itran_manpowerstatedetl_historyDataAccessObjects.Update(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history )
        {
           long returnCode = -99;
            const string SP = "tran_manpowerstatedetl_history_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_manpowerstatedetl_history, cmd,Database);
                FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.Updatetran_manpowerstatedetl_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Itran_manpowerstatedetl_historyDataAccessObjects.Delete(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
        {
            long returnCode = -99;
           	const string SP = "tran_manpowerstatedetl_history_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_manpowerstatedetl_history, cmd,Database, true);
                FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.Deletetran_manpowerstatedetl_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Itran_manpowerstatedetl_historyDataAccessObjects.SaveList(IList<tran_manpowerstatedetl_historyEntity> listAdded, IList<tran_manpowerstatedetl_historyEntity> listUpdated, IList<tran_manpowerstatedetl_historyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstatedetl_history_Ins";
            const string SPUpdate = "tran_manpowerstatedetl_history_Upd";
            const string SPDelete = "tran_manpowerstatedetl_history_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstatedetl_history, cmd, Database, true);
                            FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
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
                if (listUpdated.Count > 0 )
                {
                    foreach (tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstatedetl_history, cmd, Database);
                            FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
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
                if (listAdded.Count > 0 )
                {
                    foreach (tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstatedetl_history, cmd, Database);
                            FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.Save_tran_manpowerstatedetl_history"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<tran_manpowerstatedetl_historyEntity> listAdded, IList<tran_manpowerstatedetl_historyEntity> listUpdated, IList<tran_manpowerstatedetl_historyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstatedetl_history_Ins";
            const string SPUpdate = "tran_manpowerstatedetl_history_Upd";
            const string SPDelete = "tran_manpowerstatedetl_history_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstatedetl_history, cmd, db, true);
                            FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, db);
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
                if (listUpdated.Count > 0 )
                {
                    foreach (tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstatedetl_history, cmd, db);
                            FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, db);
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
                if (listAdded.Count > 0 )
                {
                    foreach (tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstatedetl_history, cmd, db);
                            FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.Save_tran_manpowerstatedetl_history"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyDataAccessObjects.GetAll(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
        {
           try
            {
				const string SP = "tran_manpowerstatedetl_history_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_manpowerstatedetl_history.SortExpression);
                    FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstatedetl_history, cmd, Database);
                    
                    IList<tran_manpowerstatedetl_historyEntity> itemList = new List<tran_manpowerstatedetl_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetl_historyEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.GetAlltran_manpowerstatedetl_history"));
            }	
        }
		
		IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyDataAccessObjects.GetAllByPages(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
        {
        try
            {
				const string SP = "tran_manpowerstatedetl_history_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstatedetl_history.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstatedetl_history.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstatedetl_history.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstatedetl_history, cmd,Database);

                    IList<tran_manpowerstatedetl_historyEntity> itemList = new List<tran_manpowerstatedetl_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetl_historyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstatedetl_history.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.GetAllByPagestran_manpowerstatedetl_history"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        tran_manpowerstatedetl_historyEntity Itran_manpowerstatedetl_historyDataAccessObjects.GetSingle(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
        {
           try
            {
				const string SP = "tran_manpowerstatedetl_history_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstatedetl_history, cmd, Database);
                    
                    IList<tran_manpowerstatedetl_historyEntity> itemList = new List<tran_manpowerstatedetl_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetl_historyEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    
                    if(itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.GetSingletran_manpowerstatedetl_history"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyDataAccessObjects.GAPgListView(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
        {
        try
            {
				const string SP = "tran_manpowerstatedetl_history_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstatedetl_history.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstatedetl_history.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstatedetl_history.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstatedetl_history.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstatedetl_history, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_manpowerstatedetl_history.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_manpowerstatedetl_history.strCommonSerachParam);

                    IList<tran_manpowerstatedetl_historyEntity> itemList = new List<tran_manpowerstatedetl_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetl_historyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstatedetl_history.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetl_historyDataAccess.GAPgListViewtran_manpowerstatedetl_history"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}