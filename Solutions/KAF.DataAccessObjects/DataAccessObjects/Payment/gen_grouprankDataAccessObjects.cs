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
	
	internal sealed partial class gen_grouprankDataAccessObjects : BaseDataAccess, Igen_grouprankDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_grouprankDataAccessObjects";
        
		public gen_grouprankDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_grouprankEntity gen_grouprank, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_grouprank.grouprankid.HasValue)
				Database.AddInParameter(cmd, "@GroupRankID", DbType.Int64, gen_grouprank.grouprankid);
            if (forDelete) return;
			if (gen_grouprank.groupid.HasValue)
				Database.AddInParameter(cmd, "@GroupID", DbType.Int64, gen_grouprank.groupid);
			if (gen_grouprank.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, gen_grouprank.rankid);
			if (gen_grouprank.ranksl.HasValue)
				Database.AddInParameter(cmd, "@RankSL", DbType.Int64, gen_grouprank.ranksl);
			if (!(string.IsNullOrEmpty(gen_grouprank.comments)))
				Database.AddInParameter(cmd, "@Comments", DbType.String, gen_grouprank.comments);
			if (!(string.IsNullOrEmpty(gen_grouprank.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_grouprank.remarks);
			if ((gen_grouprank.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_grouprank.ex_date1);
			if ((gen_grouprank.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_grouprank.ex_date2);
			if (!(string.IsNullOrEmpty(gen_grouprank.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_grouprank.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_grouprank.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_grouprank.ex_nvarchar2);
			if (gen_grouprank.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_grouprank.ex_bigint1);
			if (gen_grouprank.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_grouprank.ex_bigint2);
			if (gen_grouprank.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_grouprank.ex_decimal1);
			if (gen_grouprank.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_grouprank.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_grouprankDataAccessObjects.Add(gen_grouprankEntity gen_grouprank  )
        {
            long returnCode = -99;
            const string SP = "gen_grouprank_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_grouprank, cmd,Database);
                FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.Addgen_grouprank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_grouprankDataAccessObjects.Update(gen_grouprankEntity gen_grouprank )
        {
           long returnCode = -99;
            const string SP = "gen_grouprank_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_grouprank, cmd,Database);
                FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.Updategen_grouprank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_grouprankDataAccessObjects.Delete(gen_grouprankEntity gen_grouprank)
        {
            long returnCode = -99;
           	const string SP = "gen_grouprank_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_grouprank, cmd,Database, true);
                FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.Deletegen_grouprank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_grouprankDataAccessObjects.SaveList(IList<gen_grouprankEntity> listAdded, IList<gen_grouprankEntity> listUpdated, IList<gen_grouprankEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_grouprank_Ins";
            const string SPUpdate = "gen_grouprank_Upd";
            const string SPDelete = "gen_grouprank_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_grouprankEntity gen_grouprank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_grouprank, cmd, Database, true);
                            FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_grouprankEntity gen_grouprank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_grouprank, cmd, Database);
                            FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_grouprankEntity gen_grouprank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_grouprank, cmd, Database);
                            FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.Save_gen_grouprank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_grouprankEntity> listAdded, IList<gen_grouprankEntity> listUpdated, IList<gen_grouprankEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_grouprank_Ins";
            const string SPUpdate = "gen_grouprank_Upd";
            const string SPDelete = "gen_grouprank_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_grouprankEntity gen_grouprank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_grouprank, cmd, db, true);
                            FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_grouprankEntity gen_grouprank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_grouprank, cmd, db);
                            FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_grouprankEntity gen_grouprank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_grouprank, cmd, db);
                            FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.Save_gen_grouprank"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_grouprankEntity> Igen_grouprankDataAccessObjects.GetAll(gen_grouprankEntity gen_grouprank)
        {
           try
            {
				const string SP = "gen_grouprank_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_grouprank.SortExpression);
                    FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_grouprank, cmd, Database);
                    
                    IList<gen_grouprankEntity> itemList = new List<gen_grouprankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_grouprankEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.GetAllgen_grouprank"));
            }	
        }
		
		IList<gen_grouprankEntity> Igen_grouprankDataAccessObjects.GetAllByPages(gen_grouprankEntity gen_grouprank)
        {
        try
            {
				const string SP = "gen_grouprank_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_grouprank.SortExpression);
                    AddPageSizeParameter(cmd, gen_grouprank.PageSize);
                    AddCurrentPageParameter(cmd, gen_grouprank.CurrentPage);                    
                    FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_grouprank, cmd,Database);

                    IList<gen_grouprankEntity> itemList = new List<gen_grouprankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_grouprankEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_grouprank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.GetAllByPagesgen_grouprank"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_grouprankEntity Igen_grouprankDataAccessObjects.GetSingle(gen_grouprankEntity gen_grouprank)
        {
           try
            {
				const string SP = "gen_grouprank_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_grouprank, cmd, Database);
                    
                    IList<gen_grouprankEntity> itemList = new List<gen_grouprankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_grouprankEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.GetSinglegen_grouprank"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_grouprankEntity> Igen_grouprankDataAccessObjects.GAPgListView(gen_grouprankEntity gen_grouprank)
        {
        try
            {
				const string SP = "gen_grouprank_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_grouprank.SortExpression);
                    AddPageSizeParameter(cmd, gen_grouprank.PageSize);
                    AddCurrentPageParameter(cmd, gen_grouprank.CurrentPage);                    
                    FillSequrityParameters(gen_grouprank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_grouprank, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_grouprank.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_grouprank.strCommonSerachParam);

                    IList<gen_grouprankEntity> itemList = new List<gen_grouprankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_grouprankEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_grouprank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_grouprankDataAccess.GAPgListViewgen_grouprank"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}