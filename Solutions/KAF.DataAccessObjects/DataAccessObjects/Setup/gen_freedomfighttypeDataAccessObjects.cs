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
	
	internal sealed partial class gen_freedomfighttypeDataAccessObjects : BaseDataAccess, Igen_freedomfighttypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_freedomfighttypeDataAccessObjects";
        
		public gen_freedomfighttypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_freedomfighttypeEntity gen_freedomfighttype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_freedomfighttype.freedomfighttype.HasValue)
				Database.AddInParameter(cmd, "@FreedomFightType", DbType.Int64, gen_freedomfighttype.freedomfighttype);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_freedomfighttype.freedomfight)))
				Database.AddInParameter(cmd, "@FreedomFight", DbType.String, gen_freedomfighttype.freedomfight);
			if (gen_freedomfighttype.priority.HasValue)
				Database.AddInParameter(cmd, "@Priority", DbType.Int64, gen_freedomfighttype.priority);
			if (!(string.IsNullOrEmpty(gen_freedomfighttype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_freedomfighttype.remarks);
			if ((gen_freedomfighttype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_freedomfighttype.ex_date1);
			if ((gen_freedomfighttype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_freedomfighttype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_freedomfighttype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_freedomfighttype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_freedomfighttype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_freedomfighttype.ex_nvarchar2);
			if (gen_freedomfighttype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_freedomfighttype.ex_bigint1);
			if (gen_freedomfighttype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_freedomfighttype.ex_bigint2);
			if (gen_freedomfighttype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_freedomfighttype.ex_decimal1);
			if (gen_freedomfighttype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_freedomfighttype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_freedomfighttypeDataAccessObjects.Add(gen_freedomfighttypeEntity gen_freedomfighttype  )
        {
            long returnCode = -99;
            const string SP = "gen_freedomfighttype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_freedomfighttype, cmd,Database);
                FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.Addgen_freedomfighttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_freedomfighttypeDataAccessObjects.Update(gen_freedomfighttypeEntity gen_freedomfighttype )
        {
           long returnCode = -99;
            const string SP = "gen_freedomfighttype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_freedomfighttype, cmd,Database);
                FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.Updategen_freedomfighttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_freedomfighttypeDataAccessObjects.Delete(gen_freedomfighttypeEntity gen_freedomfighttype)
        {
            long returnCode = -99;
           	const string SP = "gen_freedomfighttype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_freedomfighttype, cmd,Database, true);
                FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.Deletegen_freedomfighttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_freedomfighttypeDataAccessObjects.SaveList(IList<gen_freedomfighttypeEntity> listAdded, IList<gen_freedomfighttypeEntity> listUpdated, IList<gen_freedomfighttypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_freedomfighttype_Ins";
            const string SPUpdate = "gen_freedomfighttype_Upd";
            const string SPDelete = "gen_freedomfighttype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_freedomfighttypeEntity gen_freedomfighttype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_freedomfighttype, cmd, Database, true);
                            FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_freedomfighttypeEntity gen_freedomfighttype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_freedomfighttype, cmd, Database);
                            FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_freedomfighttypeEntity gen_freedomfighttype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_freedomfighttype, cmd, Database);
                            FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.Save_gen_freedomfighttype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_freedomfighttypeEntity> listAdded, IList<gen_freedomfighttypeEntity> listUpdated, IList<gen_freedomfighttypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_freedomfighttype_Ins";
            const string SPUpdate = "gen_freedomfighttype_Upd";
            const string SPDelete = "gen_freedomfighttype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_freedomfighttypeEntity gen_freedomfighttype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_freedomfighttype, cmd, db, true);
                            FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_freedomfighttypeEntity gen_freedomfighttype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_freedomfighttype, cmd, db);
                            FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_freedomfighttypeEntity gen_freedomfighttype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_freedomfighttype, cmd, db);
                            FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.Save_gen_freedomfighttype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeDataAccessObjects.GetAll(gen_freedomfighttypeEntity gen_freedomfighttype)
        {
           try
            {
				const string SP = "gen_freedomfighttype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_freedomfighttype.SortExpression);
                    FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_freedomfighttype, cmd, Database);
                    
                    IList<gen_freedomfighttypeEntity> itemList = new List<gen_freedomfighttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_freedomfighttypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.GetAllgen_freedomfighttype"));
            }	
        }
		
		IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeDataAccessObjects.GetAllByPages(gen_freedomfighttypeEntity gen_freedomfighttype)
        {
        try
            {
				const string SP = "gen_freedomfighttype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_freedomfighttype.SortExpression);
                    AddPageSizeParameter(cmd, gen_freedomfighttype.PageSize);
                    AddCurrentPageParameter(cmd, gen_freedomfighttype.CurrentPage);                    
                    FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_freedomfighttype, cmd,Database);

                    IList<gen_freedomfighttypeEntity> itemList = new List<gen_freedomfighttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_freedomfighttypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_freedomfighttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.GetAllByPagesgen_freedomfighttype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_freedomfighttypeEntity Igen_freedomfighttypeDataAccessObjects.GetSingle(gen_freedomfighttypeEntity gen_freedomfighttype)
        {
           try
            {
				const string SP = "gen_freedomfighttype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_freedomfighttype, cmd, Database);
                    
                    IList<gen_freedomfighttypeEntity> itemList = new List<gen_freedomfighttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_freedomfighttypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.GetSinglegen_freedomfighttype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeDataAccessObjects.GAPgListView(gen_freedomfighttypeEntity gen_freedomfighttype)
        {
        try
            {
				const string SP = "gen_freedomfighttype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_freedomfighttype.SortExpression);
                    AddPageSizeParameter(cmd, gen_freedomfighttype.PageSize);
                    AddCurrentPageParameter(cmd, gen_freedomfighttype.CurrentPage);                    
                    FillSequrityParameters(gen_freedomfighttype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_freedomfighttype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_freedomfighttype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_freedomfighttype.strCommonSerachParam);

                    IList<gen_freedomfighttypeEntity> itemList = new List<gen_freedomfighttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_freedomfighttypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_freedomfighttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_freedomfighttypeDataAccess.GAPgListViewgen_freedomfighttype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}