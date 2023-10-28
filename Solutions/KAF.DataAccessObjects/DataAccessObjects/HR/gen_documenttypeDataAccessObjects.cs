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
	
	internal sealed partial class gen_documenttypeDataAccessObjects : BaseDataAccess, Igen_documenttypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_documenttypeDataAccessObjects";
        
		public gen_documenttypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_documenttypeEntity gen_documenttype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_documenttype.doctypeid.HasValue)
				Database.AddInParameter(cmd, "@DocTypeID", DbType.Int64, gen_documenttype.doctypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_documenttype.doctypename)))
				Database.AddInParameter(cmd, "@DocTypeName", DbType.String, gen_documenttype.doctypename);
			if (!(string.IsNullOrEmpty(gen_documenttype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_documenttype.remarks);
			if ((gen_documenttype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_documenttype.ex_date1);
			if ((gen_documenttype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_documenttype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_documenttype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_documenttype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_documenttype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_documenttype.ex_nvarchar2);
			if (gen_documenttype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_documenttype.ex_bigint1);
			if (gen_documenttype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_documenttype.ex_bigint2);
			if (gen_documenttype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_documenttype.ex_decimal1);
			if (gen_documenttype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_documenttype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_documenttypeDataAccessObjects.Add(gen_documenttypeEntity gen_documenttype  )
        {
            long returnCode = -99;
            const string SP = "gen_documenttype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_documenttype, cmd,Database);
                FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.Addgen_documenttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_documenttypeDataAccessObjects.Update(gen_documenttypeEntity gen_documenttype )
        {
           long returnCode = -99;
            const string SP = "gen_documenttype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_documenttype, cmd,Database);
                FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.Updategen_documenttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_documenttypeDataAccessObjects.Delete(gen_documenttypeEntity gen_documenttype)
        {
            long returnCode = -99;
           	const string SP = "gen_documenttype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_documenttype, cmd,Database, true);
                FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.Deletegen_documenttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_documenttypeDataAccessObjects.SaveList(IList<gen_documenttypeEntity> listAdded, IList<gen_documenttypeEntity> listUpdated, IList<gen_documenttypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_documenttype_Ins";
            const string SPUpdate = "gen_documenttype_Upd";
            const string SPDelete = "gen_documenttype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_documenttypeEntity gen_documenttype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_documenttype, cmd, Database, true);
                            FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_documenttypeEntity gen_documenttype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_documenttype, cmd, Database);
                            FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_documenttypeEntity gen_documenttype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_documenttype, cmd, Database);
                            FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.Save_gen_documenttype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_documenttypeEntity> listAdded, IList<gen_documenttypeEntity> listUpdated, IList<gen_documenttypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_documenttype_Ins";
            const string SPUpdate = "gen_documenttype_Upd";
            const string SPDelete = "gen_documenttype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_documenttypeEntity gen_documenttype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_documenttype, cmd, db, true);
                            FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_documenttypeEntity gen_documenttype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_documenttype, cmd, db);
                            FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_documenttypeEntity gen_documenttype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_documenttype, cmd, db);
                            FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.Save_gen_documenttype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_documenttypeEntity> Igen_documenttypeDataAccessObjects.GetAll(gen_documenttypeEntity gen_documenttype)
        {
           try
            {
				const string SP = "gen_documenttype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_documenttype.SortExpression);
                    FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_documenttype, cmd, Database);
                    
                    IList<gen_documenttypeEntity> itemList = new List<gen_documenttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_documenttypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.GetAllgen_documenttype"));
            }	
        }
		
		IList<gen_documenttypeEntity> Igen_documenttypeDataAccessObjects.GetAllByPages(gen_documenttypeEntity gen_documenttype)
        {
        try
            {
				const string SP = "gen_documenttype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_documenttype.SortExpression);
                    AddPageSizeParameter(cmd, gen_documenttype.PageSize);
                    AddCurrentPageParameter(cmd, gen_documenttype.CurrentPage);                    
                    FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_documenttype, cmd,Database);

                    IList<gen_documenttypeEntity> itemList = new List<gen_documenttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_documenttypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_documenttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.GetAllByPagesgen_documenttype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_documenttypeEntity Igen_documenttypeDataAccessObjects.GetSingle(gen_documenttypeEntity gen_documenttype)
        {
           try
            {
				const string SP = "gen_documenttype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_documenttype, cmd, Database);
                    
                    IList<gen_documenttypeEntity> itemList = new List<gen_documenttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_documenttypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.GetSinglegen_documenttype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_documenttypeEntity> Igen_documenttypeDataAccessObjects.GAPgListView(gen_documenttypeEntity gen_documenttype)
        {
        try
            {
				const string SP = "gen_documenttype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_documenttype.SortExpression);
                    AddPageSizeParameter(cmd, gen_documenttype.PageSize);
                    AddCurrentPageParameter(cmd, gen_documenttype.CurrentPage);                    
                    FillSequrityParameters(gen_documenttype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_documenttype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_documenttype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_documenttype.strCommonSerachParam);

                    IList<gen_documenttypeEntity> itemList = new List<gen_documenttypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_documenttypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_documenttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_documenttypeDataAccess.GAPgListViewgen_documenttype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}