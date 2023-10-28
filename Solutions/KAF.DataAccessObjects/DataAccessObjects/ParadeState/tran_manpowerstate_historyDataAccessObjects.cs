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
	
	internal sealed partial class tran_manpowerstate_historyDataAccessObjects : BaseDataAccess, Itran_manpowerstate_historyDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_manpowerstate_historyDataAccessObjects";
        
		public tran_manpowerstate_historyDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_manpowerstate_historyEntity tran_manpowerstate_history, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_manpowerstate_history.tran_manpowerstate_historyid.HasValue)
				Database.AddInParameter(cmd, "@Tran_ManpowerState_HistoryID", DbType.Int64, tran_manpowerstate_history.tran_manpowerstate_historyid);
            if (forDelete) return;
			if (tran_manpowerstate_history.manpowerstateid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStateID", DbType.Int64, tran_manpowerstate_history.manpowerstateid);
			if (tran_manpowerstate_history.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, tran_manpowerstate_history.okpid);
			if ((tran_manpowerstate_history.manpowerstatedate.HasValue))
				Database.AddInParameter(cmd, "@ManpowerStateDate", DbType.DateTime, tran_manpowerstate_history.manpowerstatedate);
			if ((tran_manpowerstate_history.isprepared != null))
				Database.AddInParameter(cmd, "@IsPrepared", DbType.Boolean, tran_manpowerstate_history.isprepared);
			if ((tran_manpowerstate_history.prepareddate.HasValue))
				Database.AddInParameter(cmd, "@PreparedDate", DbType.DateTime, tran_manpowerstate_history.prepareddate);
			if (tran_manpowerstate_history.preparedby.HasValue)
				Database.AddInParameter(cmd, "@PreparedBy", DbType.Int64, tran_manpowerstate_history.preparedby);
			if ((tran_manpowerstate_history.isreviewed != null))
				Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, tran_manpowerstate_history.isreviewed);
			if ((tran_manpowerstate_history.reviewdate.HasValue))
				Database.AddInParameter(cmd, "@ReviewDate", DbType.DateTime, tran_manpowerstate_history.reviewdate);
			if (tran_manpowerstate_history.reviewedby.HasValue)
				Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, tran_manpowerstate_history.reviewedby);
			if (!(string.IsNullOrEmpty(tran_manpowerstate_history.reviewremarks)))
				Database.AddInParameter(cmd, "@ReviewRemarks", DbType.String, tran_manpowerstate_history.reviewremarks);
			if ((tran_manpowerstate_history.isapproved != null))
				Database.AddInParameter(cmd, "@IsApproved", DbType.Boolean, tran_manpowerstate_history.isapproved);
			if ((tran_manpowerstate_history.approvedate.HasValue))
				Database.AddInParameter(cmd, "@ApproveDate", DbType.DateTime, tran_manpowerstate_history.approvedate);
			if (tran_manpowerstate_history.approveby.HasValue)
				Database.AddInParameter(cmd, "@ApproveBy", DbType.Int64, tran_manpowerstate_history.approveby);
			if (!(string.IsNullOrEmpty(tran_manpowerstate_history.approveremarks)))
				Database.AddInParameter(cmd, "@ApproveRemarks", DbType.String, tran_manpowerstate_history.approveremarks);
			if ((tran_manpowerstate_history.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, tran_manpowerstate_history.ex_date1);
			if ((tran_manpowerstate_history.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, tran_manpowerstate_history.ex_date2);
			if (!(string.IsNullOrEmpty(tran_manpowerstate_history.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, tran_manpowerstate_history.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(tran_manpowerstate_history.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, tran_manpowerstate_history.ex_nvarchar2);
			if (tran_manpowerstate_history.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, tran_manpowerstate_history.ex_bigint1);
			if (tran_manpowerstate_history.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, tran_manpowerstate_history.ex_bigint2);
			if (tran_manpowerstate_history.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, tran_manpowerstate_history.ex_decimal1);
			if (tran_manpowerstate_history.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, tran_manpowerstate_history.ex_decimal2);

        }
		
        
		#region Add Operation

        long Itran_manpowerstate_historyDataAccessObjects.Add(tran_manpowerstate_historyEntity tran_manpowerstate_history  )
        {
            long returnCode = -99;
            const string SP = "tran_manpowerstate_history_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_manpowerstate_history, cmd,Database);
                FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.Addtran_manpowerstate_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Itran_manpowerstate_historyDataAccessObjects.Update(tran_manpowerstate_historyEntity tran_manpowerstate_history )
        {
           long returnCode = -99;
            const string SP = "tran_manpowerstate_history_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_manpowerstate_history, cmd,Database);
                FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.Updatetran_manpowerstate_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Itran_manpowerstate_historyDataAccessObjects.Delete(tran_manpowerstate_historyEntity tran_manpowerstate_history)
        {
            long returnCode = -99;
           	const string SP = "tran_manpowerstate_history_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_manpowerstate_history, cmd,Database, true);
                FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.Deletetran_manpowerstate_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Itran_manpowerstate_historyDataAccessObjects.SaveList(IList<tran_manpowerstate_historyEntity> listAdded, IList<tran_manpowerstate_historyEntity> listUpdated, IList<tran_manpowerstate_historyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstate_history_Ins";
            const string SPUpdate = "tran_manpowerstate_history_Upd";
            const string SPDelete = "tran_manpowerstate_history_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstate_historyEntity tran_manpowerstate_history in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstate_history, cmd, Database, true);
                            FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_manpowerstate_historyEntity tran_manpowerstate_history in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstate_history, cmd, Database);
                            FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_manpowerstate_historyEntity tran_manpowerstate_history in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstate_history, cmd, Database);
                            FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.Save_tran_manpowerstate_history"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<tran_manpowerstate_historyEntity> listAdded, IList<tran_manpowerstate_historyEntity> listUpdated, IList<tran_manpowerstate_historyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstate_history_Ins";
            const string SPUpdate = "tran_manpowerstate_history_Upd";
            const string SPDelete = "tran_manpowerstate_history_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstate_historyEntity tran_manpowerstate_history in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstate_history, cmd, db, true);
                            FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, db);
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
                    foreach (tran_manpowerstate_historyEntity tran_manpowerstate_history in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstate_history, cmd, db);
                            FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, db);
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
                    foreach (tran_manpowerstate_historyEntity tran_manpowerstate_history in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstate_history, cmd, db);
                            FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.Save_tran_manpowerstate_history"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyDataAccessObjects.GetAll(tran_manpowerstate_historyEntity tran_manpowerstate_history)
        {
           try
            {
				const string SP = "tran_manpowerstate_history_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_manpowerstate_history.SortExpression);
                    FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstate_history, cmd, Database);
                    
                    IList<tran_manpowerstate_historyEntity> itemList = new List<tran_manpowerstate_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstate_historyEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.GetAlltran_manpowerstate_history"));
            }	
        }
		
		IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyDataAccessObjects.GetAllByPages(tran_manpowerstate_historyEntity tran_manpowerstate_history)
        {
        try
            {
				const string SP = "tran_manpowerstate_history_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstate_history.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstate_history.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstate_history.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstate_history, cmd,Database);

                    IList<tran_manpowerstate_historyEntity> itemList = new List<tran_manpowerstate_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstate_historyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstate_history.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.GetAllByPagestran_manpowerstate_history"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        tran_manpowerstate_historyEntity Itran_manpowerstate_historyDataAccessObjects.GetSingle(tran_manpowerstate_historyEntity tran_manpowerstate_history)
        {
           try
            {
				const string SP = "tran_manpowerstate_history_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstate_history, cmd, Database);
                    
                    IList<tran_manpowerstate_historyEntity> itemList = new List<tran_manpowerstate_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstate_historyEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.GetSingletran_manpowerstate_history"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyDataAccessObjects.GAPgListView(tran_manpowerstate_historyEntity tran_manpowerstate_history)
        {
        try
            {
				const string SP = "tran_manpowerstate_history_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstate_history.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstate_history.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstate_history.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstate_history, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_manpowerstate_history.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_manpowerstate_history.strCommonSerachParam);

                    IList<tran_manpowerstate_historyEntity> itemList = new List<tran_manpowerstate_historyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstate_historyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstate_history.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.GAPgListViewtran_manpowerstate_history"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_manpowerstate_historyDataAccessObjects.UpdateReviewed(tran_manpowerstate_historyEntity tran_manpowerstate_history )
        {
           long returnCode = -99;
            const string SP = "tran_manpowerstate_history_UpdRev";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_manpowerstate_history, cmd,Database);
                FillSequrityParameters(tran_manpowerstate_history.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstate_historyDataAccess.UpdateReviewedtran_manpowerstate_history"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }                        
        #endregion
	}
}