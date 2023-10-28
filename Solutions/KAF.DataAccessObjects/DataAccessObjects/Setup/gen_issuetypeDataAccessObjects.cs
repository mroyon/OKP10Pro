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
	
	internal sealed partial class gen_issuetypeDataAccessObjects : BaseDataAccess, Igen_issuetypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_issuetypeDataAccessObjects";
        
		public gen_issuetypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_issuetypeEntity gen_issuetype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_issuetype.issuetypeid.HasValue)
				Database.AddInParameter(cmd, "@IssueTypeID", DbType.Int64, gen_issuetype.issuetypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_issuetype.issuetype)))
				Database.AddInParameter(cmd, "@IssueType", DbType.String, gen_issuetype.issuetype);
			if (!(string.IsNullOrEmpty(gen_issuetype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_issuetype.remarks);
			if ((gen_issuetype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_issuetype.ex_date1);
			if ((gen_issuetype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_issuetype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_issuetype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_issuetype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_issuetype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_issuetype.ex_nvarchar2);
			if (gen_issuetype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_issuetype.ex_bigint1);
			if (gen_issuetype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_issuetype.ex_bigint2);
			if (gen_issuetype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_issuetype.ex_decimal1);
			if (gen_issuetype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_issuetype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_issuetypeDataAccessObjects.Add(gen_issuetypeEntity gen_issuetype  )
        {
            long returnCode = -99;
            const string SP = "gen_issuetype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_issuetype, cmd,Database);
                FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.Addgen_issuetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_issuetypeDataAccessObjects.Update(gen_issuetypeEntity gen_issuetype )
        {
           long returnCode = -99;
            const string SP = "gen_issuetype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_issuetype, cmd,Database);
                FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.Updategen_issuetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_issuetypeDataAccessObjects.Delete(gen_issuetypeEntity gen_issuetype)
        {
            long returnCode = -99;
           	const string SP = "gen_issuetype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_issuetype, cmd,Database, true);
                FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.Deletegen_issuetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_issuetypeDataAccessObjects.SaveList(IList<gen_issuetypeEntity> listAdded, IList<gen_issuetypeEntity> listUpdated, IList<gen_issuetypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_issuetype_Ins";
            const string SPUpdate = "gen_issuetype_Upd";
            const string SPDelete = "gen_issuetype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_issuetypeEntity gen_issuetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_issuetype, cmd, Database, true);
                            FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_issuetypeEntity gen_issuetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_issuetype, cmd, Database);
                            FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_issuetypeEntity gen_issuetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_issuetype, cmd, Database);
                            FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.Save_gen_issuetype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_issuetypeEntity> listAdded, IList<gen_issuetypeEntity> listUpdated, IList<gen_issuetypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_issuetype_Ins";
            const string SPUpdate = "gen_issuetype_Upd";
            const string SPDelete = "gen_issuetype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_issuetypeEntity gen_issuetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_issuetype, cmd, db, true);
                            FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_issuetypeEntity gen_issuetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_issuetype, cmd, db);
                            FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_issuetypeEntity gen_issuetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_issuetype, cmd, db);
                            FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.Save_gen_issuetype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_issuetypeEntity> Igen_issuetypeDataAccessObjects.GetAll(gen_issuetypeEntity gen_issuetype)
        {
           try
            {
				const string SP = "gen_issuetype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_issuetype.SortExpression);
                    FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_issuetype, cmd, Database);
                    
                    IList<gen_issuetypeEntity> itemList = new List<gen_issuetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_issuetypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.GetAllgen_issuetype"));
            }	
        }
		
		IList<gen_issuetypeEntity> Igen_issuetypeDataAccessObjects.GetAllByPages(gen_issuetypeEntity gen_issuetype)
        {
        try
            {
				const string SP = "gen_issuetype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_issuetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_issuetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_issuetype.CurrentPage);                    
                    FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_issuetype, cmd,Database);

                    IList<gen_issuetypeEntity> itemList = new List<gen_issuetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_issuetypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_issuetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.GetAllByPagesgen_issuetype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_issuetypeEntity Igen_issuetypeDataAccessObjects.GetSingle(gen_issuetypeEntity gen_issuetype)
        {
           try
            {
				const string SP = "gen_issuetype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_issuetype, cmd, Database);
                    
                    IList<gen_issuetypeEntity> itemList = new List<gen_issuetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_issuetypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.GetSinglegen_issuetype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_issuetypeEntity> Igen_issuetypeDataAccessObjects.GAPgListView(gen_issuetypeEntity gen_issuetype)
        {
        try
            {
				const string SP = "gen_issuetype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_issuetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_issuetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_issuetype.CurrentPage);                    
                    FillSequrityParameters(gen_issuetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_issuetype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_issuetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_issuetype.strCommonSerachParam);

                    IList<gen_issuetypeEntity> itemList = new List<gen_issuetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_issuetypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_issuetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_issuetypeDataAccess.GAPgListViewgen_issuetype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}