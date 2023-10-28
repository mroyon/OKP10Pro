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
	
	internal sealed partial class gen_servicestatusDataAccessObjects : BaseDataAccess, Igen_servicestatusDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_servicestatusDataAccessObjects";
        
		public gen_servicestatusDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_servicestatusEntity gen_servicestatus, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_servicestatus.servicestatusid.HasValue)
				Database.AddInParameter(cmd, "@ServiceStatusID", DbType.Int64, gen_servicestatus.servicestatusid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_servicestatus.servicestatusname)))
				Database.AddInParameter(cmd, "@ServiceStatusName", DbType.String, gen_servicestatus.servicestatusname);
			if (!(string.IsNullOrEmpty(gen_servicestatus.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_servicestatus.remarks);
			if ((gen_servicestatus.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_servicestatus.ex_date1);
			if ((gen_servicestatus.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_servicestatus.ex_date2);
			if (!(string.IsNullOrEmpty(gen_servicestatus.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_servicestatus.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_servicestatus.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_servicestatus.ex_nvarchar2);
			if (gen_servicestatus.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_servicestatus.ex_bigint1);
			if (gen_servicestatus.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_servicestatus.ex_bigint2);
			if (gen_servicestatus.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_servicestatus.ex_decimal1);
			if (gen_servicestatus.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_servicestatus.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_servicestatusDataAccessObjects.Add(gen_servicestatusEntity gen_servicestatus  )
        {
            long returnCode = -99;
            const string SP = "gen_servicestatus_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_servicestatus, cmd,Database);
                FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Addgen_servicestatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_servicestatusDataAccessObjects.Update(gen_servicestatusEntity gen_servicestatus )
        {
           long returnCode = -99;
            const string SP = "gen_servicestatus_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_servicestatus, cmd,Database);
                FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Updategen_servicestatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_servicestatusDataAccessObjects.Delete(gen_servicestatusEntity gen_servicestatus)
        {
            long returnCode = -99;
           	const string SP = "gen_servicestatus_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_servicestatus, cmd,Database, true);
                FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Deletegen_servicestatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_servicestatusDataAccessObjects.SaveList(IList<gen_servicestatusEntity> listAdded, IList<gen_servicestatusEntity> listUpdated, IList<gen_servicestatusEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_servicestatus_Ins";
            const string SPUpdate = "gen_servicestatus_Upd";
            const string SPDelete = "gen_servicestatus_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicestatusEntity gen_servicestatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_servicestatus, cmd, Database, true);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_servicestatus, cmd, Database);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_servicestatus, cmd, Database);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Save_gen_servicestatus"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_servicestatusEntity> listAdded, IList<gen_servicestatusEntity> listUpdated, IList<gen_servicestatusEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_servicestatus_Ins";
            const string SPUpdate = "gen_servicestatus_Upd";
            const string SPDelete = "gen_servicestatus_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicestatusEntity gen_servicestatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_servicestatus, cmd, db, true);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_servicestatus, cmd, db);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_servicestatus, cmd, db);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Save_gen_servicestatus"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_servicestatusEntity> Igen_servicestatusDataAccessObjects.GetAll(gen_servicestatusEntity gen_servicestatus)
        {
           try
            {
				const string SP = "gen_servicestatus_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_servicestatus.SortExpression);
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_servicestatus, cmd, Database);
                    
                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GetAllgen_servicestatus"));
            }	
        }
		
		IList<gen_servicestatusEntity> Igen_servicestatusDataAccessObjects.GetAllByPages(gen_servicestatusEntity gen_servicestatus)
        {
        try
            {
				const string SP = "gen_servicestatus_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_servicestatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_servicestatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_servicestatus.CurrentPage);                    
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_servicestatus, cmd,Database);

                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_servicestatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GetAllByPagesgen_servicestatus"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_servicestatusEntity Igen_servicestatusDataAccessObjects.GetSingle(gen_servicestatusEntity gen_servicestatus)
        {
           try
            {
				const string SP = "gen_servicestatus_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_servicestatus, cmd, Database);
                    
                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GetSinglegen_servicestatus"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_servicestatusEntity> Igen_servicestatusDataAccessObjects.GAPgListView(gen_servicestatusEntity gen_servicestatus)
        {
        try
            {
				const string SP = "gen_servicestatus_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_servicestatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_servicestatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_servicestatus.CurrentPage);                    
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_servicestatus, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_servicestatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_servicestatus.strCommonSerachParam);

                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_servicestatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GAPgListViewgen_servicestatus"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}