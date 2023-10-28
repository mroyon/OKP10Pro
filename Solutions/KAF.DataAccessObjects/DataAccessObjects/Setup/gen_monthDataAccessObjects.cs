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
	
	internal sealed partial class gen_monthDataAccessObjects : BaseDataAccess, Igen_monthDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_monthDataAccessObjects";
        
		public gen_monthDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_monthEntity gen_month, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_month.monthid.HasValue)
				Database.AddInParameter(cmd, "@MonthID", DbType.Int64, gen_month.monthid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_month.month)))
				Database.AddInParameter(cmd, "@Month", DbType.String, gen_month.month);
			if (!(string.IsNullOrEmpty(gen_month.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_month.remarks);
			if ((gen_month.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_month.ex_date1);
			if ((gen_month.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_month.ex_date2);
			if (!(string.IsNullOrEmpty(gen_month.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_month.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_month.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_month.ex_nvarchar2);
			if (gen_month.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_month.ex_bigint1);
			if (gen_month.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_month.ex_bigint2);
			if (gen_month.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_month.ex_decimal1);
			if (gen_month.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_month.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_monthDataAccessObjects.Add(gen_monthEntity gen_month  )
        {
            long returnCode = -99;
            const string SP = "gen_month_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_month, cmd,Database);
                FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.Addgen_month"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_monthDataAccessObjects.Update(gen_monthEntity gen_month )
        {
           long returnCode = -99;
            const string SP = "gen_month_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_month, cmd,Database);
                FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.Updategen_month"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_monthDataAccessObjects.Delete(gen_monthEntity gen_month)
        {
            long returnCode = -99;
           	const string SP = "gen_month_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_month, cmd,Database, true);
                FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.Deletegen_month"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_monthDataAccessObjects.SaveList(IList<gen_monthEntity> listAdded, IList<gen_monthEntity> listUpdated, IList<gen_monthEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_month_Ins";
            const string SPUpdate = "gen_month_Upd";
            const string SPDelete = "gen_month_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_monthEntity gen_month in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_month, cmd, Database, true);
                            FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_monthEntity gen_month in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_month, cmd, Database);
                            FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_monthEntity gen_month in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_month, cmd, Database);
                            FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.Save_gen_month"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_monthEntity> listAdded, IList<gen_monthEntity> listUpdated, IList<gen_monthEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_month_Ins";
            const string SPUpdate = "gen_month_Upd";
            const string SPDelete = "gen_month_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_monthEntity gen_month in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_month, cmd, db, true);
                            FillSequrityParameters(gen_month.BaseSecurityParam, cmd, db);
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
                    foreach (gen_monthEntity gen_month in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_month, cmd, db);
                            FillSequrityParameters(gen_month.BaseSecurityParam, cmd, db);
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
                    foreach (gen_monthEntity gen_month in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_month, cmd, db);
                            FillSequrityParameters(gen_month.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.Save_gen_month"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_monthEntity> Igen_monthDataAccessObjects.GetAll(gen_monthEntity gen_month)
        {
           try
            {
				const string SP = "gen_month_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_month.SortExpression);
                    FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_month, cmd, Database);
                    
                    IList<gen_monthEntity> itemList = new List<gen_monthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_monthEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.GetAllgen_month"));
            }	
        }
		
		IList<gen_monthEntity> Igen_monthDataAccessObjects.GetAllByPages(gen_monthEntity gen_month)
        {
        try
            {
				const string SP = "gen_month_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_month.SortExpression);
                    AddPageSizeParameter(cmd, gen_month.PageSize);
                    AddCurrentPageParameter(cmd, gen_month.CurrentPage);                    
                    FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_month, cmd,Database);

                    IList<gen_monthEntity> itemList = new List<gen_monthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_monthEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_month.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.GetAllByPagesgen_month"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_monthEntity Igen_monthDataAccessObjects.GetSingle(gen_monthEntity gen_month)
        {
           try
            {
				const string SP = "gen_month_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_month, cmd, Database);
                    
                    IList<gen_monthEntity> itemList = new List<gen_monthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_monthEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.GetSinglegen_month"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_monthEntity> Igen_monthDataAccessObjects.GAPgListView(gen_monthEntity gen_month)
        {
        try
            {
				const string SP = "gen_month_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_month.SortExpression);
                    AddPageSizeParameter(cmd, gen_month.PageSize);
                    AddCurrentPageParameter(cmd, gen_month.CurrentPage);                    
                    FillSequrityParameters(gen_month.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_month, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_month.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_month.strCommonSerachParam);

                    IList<gen_monthEntity> itemList = new List<gen_monthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_monthEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_month.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_monthDataAccess.GAPgListViewgen_month"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}