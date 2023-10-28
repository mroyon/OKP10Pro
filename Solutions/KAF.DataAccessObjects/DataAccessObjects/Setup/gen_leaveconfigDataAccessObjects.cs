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
	
	internal sealed partial class gen_leaveconfigDataAccessObjects : BaseDataAccess, Igen_leaveconfigDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_leaveconfigDataAccessObjects";
        
		public gen_leaveconfigDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_leaveconfigEntity gen_leaveconfig, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_leaveconfig.leaveconfigid.HasValue)
				Database.AddInParameter(cmd, "@LeaveConfigID", DbType.Int64, gen_leaveconfig.leaveconfigid);
            if (forDelete) return;
			if (gen_leaveconfig.leavetypeid.HasValue)
				Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, gen_leaveconfig.leavetypeid);
			if ((gen_leaveconfig.startdate.HasValue))
				Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, gen_leaveconfig.startdate);
			if ((gen_leaveconfig.enddate.HasValue))
				Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, gen_leaveconfig.enddate);
			if (gen_leaveconfig.noofdays.HasValue)
				Database.AddInParameter(cmd, "@NoOfDays", DbType.Int64, gen_leaveconfig.noofdays);
			if (!(string.IsNullOrEmpty(gen_leaveconfig.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_leaveconfig.remarks);
			if ((gen_leaveconfig.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_leaveconfig.ex_date1);
			if ((gen_leaveconfig.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_leaveconfig.ex_date2);
			if (!(string.IsNullOrEmpty(gen_leaveconfig.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_leaveconfig.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_leaveconfig.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_leaveconfig.ex_nvarchar2);
			if (gen_leaveconfig.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_leaveconfig.ex_bigint1);
			if (gen_leaveconfig.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_leaveconfig.ex_bigint2);
			if (gen_leaveconfig.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_leaveconfig.ex_decimal1);
			if (gen_leaveconfig.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_leaveconfig.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_leaveconfigDataAccessObjects.Add(gen_leaveconfigEntity gen_leaveconfig  )
        {
            long returnCode = -99;
            const string SP = "gen_leaveconfig_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_leaveconfig, cmd,Database);
                FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.Addgen_leaveconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_leaveconfigDataAccessObjects.Update(gen_leaveconfigEntity gen_leaveconfig )
        {
           long returnCode = -99;
            const string SP = "gen_leaveconfig_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_leaveconfig, cmd,Database);
                FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.Updategen_leaveconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_leaveconfigDataAccessObjects.Delete(gen_leaveconfigEntity gen_leaveconfig)
        {
            long returnCode = -99;
           	const string SP = "gen_leaveconfig_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_leaveconfig, cmd,Database, true);
                FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.Deletegen_leaveconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_leaveconfigDataAccessObjects.SaveList(IList<gen_leaveconfigEntity> listAdded, IList<gen_leaveconfigEntity> listUpdated, IList<gen_leaveconfigEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_leaveconfig_Ins";
            const string SPUpdate = "gen_leaveconfig_Upd";
            const string SPDelete = "gen_leaveconfig_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_leaveconfigEntity gen_leaveconfig in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_leaveconfig, cmd, Database, true);
                            FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_leaveconfigEntity gen_leaveconfig in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_leaveconfig, cmd, Database);
                            FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_leaveconfigEntity gen_leaveconfig in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_leaveconfig, cmd, Database);
                            FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.Save_gen_leaveconfig"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_leaveconfigEntity> listAdded, IList<gen_leaveconfigEntity> listUpdated, IList<gen_leaveconfigEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_leaveconfig_Ins";
            const string SPUpdate = "gen_leaveconfig_Upd";
            const string SPDelete = "gen_leaveconfig_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_leaveconfigEntity gen_leaveconfig in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_leaveconfig, cmd, db, true);
                            FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, db);
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
                    foreach (gen_leaveconfigEntity gen_leaveconfig in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_leaveconfig, cmd, db);
                            FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, db);
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
                    foreach (gen_leaveconfigEntity gen_leaveconfig in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_leaveconfig, cmd, db);
                            FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.Save_gen_leaveconfig"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_leaveconfigEntity> Igen_leaveconfigDataAccessObjects.GetAll(gen_leaveconfigEntity gen_leaveconfig)
        {
           try
            {
				const string SP = "gen_leaveconfig_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_leaveconfig.SortExpression);
                    FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_leaveconfig, cmd, Database);
                    
                    IList<gen_leaveconfigEntity> itemList = new List<gen_leaveconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leaveconfigEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.GetAllgen_leaveconfig"));
            }	
        }
		
		IList<gen_leaveconfigEntity> Igen_leaveconfigDataAccessObjects.GetAllByPages(gen_leaveconfigEntity gen_leaveconfig)
        {
        try
            {
				const string SP = "gen_leaveconfig_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_leaveconfig.SortExpression);
                    AddPageSizeParameter(cmd, gen_leaveconfig.PageSize);
                    AddCurrentPageParameter(cmd, gen_leaveconfig.CurrentPage);                    
                    FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_leaveconfig, cmd,Database);

                    IList<gen_leaveconfigEntity> itemList = new List<gen_leaveconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leaveconfigEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_leaveconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.GetAllByPagesgen_leaveconfig"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_leaveconfigEntity Igen_leaveconfigDataAccessObjects.GetSingle(gen_leaveconfigEntity gen_leaveconfig)
        {
           try
            {
				const string SP = "gen_leaveconfig_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_leaveconfig, cmd, Database);
                    
                    IList<gen_leaveconfigEntity> itemList = new List<gen_leaveconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leaveconfigEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.GetSinglegen_leaveconfig"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_leaveconfigEntity> Igen_leaveconfigDataAccessObjects.GAPgListView(gen_leaveconfigEntity gen_leaveconfig)
        {
        try
            {
				const string SP = "gen_leaveconfig_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_leaveconfig.SortExpression);
                    AddPageSizeParameter(cmd, gen_leaveconfig.PageSize);
                    AddCurrentPageParameter(cmd, gen_leaveconfig.CurrentPage);                    
                    FillSequrityParameters(gen_leaveconfig.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_leaveconfig, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_leaveconfig.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_leaveconfig.strCommonSerachParam);

                    IList<gen_leaveconfigEntity> itemList = new List<gen_leaveconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leaveconfigEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_leaveconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_leaveconfigDataAccess.GAPgListViewgen_leaveconfig"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}