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
	
	internal sealed partial class gen_penaltytypeDataAccessObjects : BaseDataAccess, Igen_penaltytypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_penaltytypeDataAccessObjects";
        
		public gen_penaltytypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_penaltytypeEntity gen_penaltytype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_penaltytype.penaltytypeid.HasValue)
				Database.AddInParameter(cmd, "@PenaltyTypeID", DbType.Int64, gen_penaltytype.penaltytypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_penaltytype.penaltytype)))
				Database.AddInParameter(cmd, "@PenaltyType", DbType.String, gen_penaltytype.penaltytype);
			if (!(string.IsNullOrEmpty(gen_penaltytype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_penaltytype.remarks);
			if ((gen_penaltytype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_penaltytype.ex_date1);
			if ((gen_penaltytype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_penaltytype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_penaltytype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_penaltytype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_penaltytype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_penaltytype.ex_nvarchar2);
			if (gen_penaltytype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_penaltytype.ex_bigint1);
			if (gen_penaltytype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_penaltytype.ex_bigint2);
			if (gen_penaltytype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_penaltytype.ex_decimal1);
			if (gen_penaltytype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_penaltytype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_penaltytypeDataAccessObjects.Add(gen_penaltytypeEntity gen_penaltytype  )
        {
            long returnCode = -99;
            const string SP = "gen_penaltytype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_penaltytype, cmd,Database);
                FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.Addgen_penaltytype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_penaltytypeDataAccessObjects.Update(gen_penaltytypeEntity gen_penaltytype )
        {
           long returnCode = -99;
            const string SP = "gen_penaltytype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_penaltytype, cmd,Database);
                FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.Updategen_penaltytype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_penaltytypeDataAccessObjects.Delete(gen_penaltytypeEntity gen_penaltytype)
        {
            long returnCode = -99;
           	const string SP = "gen_penaltytype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_penaltytype, cmd,Database, true);
                FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.Deletegen_penaltytype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_penaltytypeDataAccessObjects.SaveList(IList<gen_penaltytypeEntity> listAdded, IList<gen_penaltytypeEntity> listUpdated, IList<gen_penaltytypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_penaltytype_Ins";
            const string SPUpdate = "gen_penaltytype_Upd";
            const string SPDelete = "gen_penaltytype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_penaltytypeEntity gen_penaltytype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_penaltytype, cmd, Database, true);
                            FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_penaltytypeEntity gen_penaltytype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_penaltytype, cmd, Database);
                            FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_penaltytypeEntity gen_penaltytype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_penaltytype, cmd, Database);
                            FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.Save_gen_penaltytype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_penaltytypeEntity> listAdded, IList<gen_penaltytypeEntity> listUpdated, IList<gen_penaltytypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_penaltytype_Ins";
            const string SPUpdate = "gen_penaltytype_Upd";
            const string SPDelete = "gen_penaltytype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_penaltytypeEntity gen_penaltytype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_penaltytype, cmd, db, true);
                            FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_penaltytypeEntity gen_penaltytype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_penaltytype, cmd, db);
                            FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_penaltytypeEntity gen_penaltytype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_penaltytype, cmd, db);
                            FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.Save_gen_penaltytype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_penaltytypeEntity> Igen_penaltytypeDataAccessObjects.GetAll(gen_penaltytypeEntity gen_penaltytype)
        {
           try
            {
				const string SP = "gen_penaltytype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_penaltytype.SortExpression);
                    FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_penaltytype, cmd, Database);
                    
                    IList<gen_penaltytypeEntity> itemList = new List<gen_penaltytypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_penaltytypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.GetAllgen_penaltytype"));
            }	
        }
		
		IList<gen_penaltytypeEntity> Igen_penaltytypeDataAccessObjects.GetAllByPages(gen_penaltytypeEntity gen_penaltytype)
        {
        try
            {
				const string SP = "gen_penaltytype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_penaltytype.SortExpression);
                    AddPageSizeParameter(cmd, gen_penaltytype.PageSize);
                    AddCurrentPageParameter(cmd, gen_penaltytype.CurrentPage);                    
                    FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_penaltytype, cmd,Database);

                    IList<gen_penaltytypeEntity> itemList = new List<gen_penaltytypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_penaltytypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_penaltytype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.GetAllByPagesgen_penaltytype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_penaltytypeEntity Igen_penaltytypeDataAccessObjects.GetSingle(gen_penaltytypeEntity gen_penaltytype)
        {
           try
            {
				const string SP = "gen_penaltytype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_penaltytype, cmd, Database);
                    
                    IList<gen_penaltytypeEntity> itemList = new List<gen_penaltytypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_penaltytypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.GetSinglegen_penaltytype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_penaltytypeEntity> Igen_penaltytypeDataAccessObjects.GAPgListView(gen_penaltytypeEntity gen_penaltytype)
        {
        try
            {
				const string SP = "gen_penaltytype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_penaltytype.SortExpression);
                    AddPageSizeParameter(cmd, gen_penaltytype.PageSize);
                    AddCurrentPageParameter(cmd, gen_penaltytype.CurrentPage);                    
                    FillSequrityParameters(gen_penaltytype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_penaltytype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_penaltytype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_penaltytype.strCommonSerachParam);

                    IList<gen_penaltytypeEntity> itemList = new List<gen_penaltytypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_penaltytypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_penaltytype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_penaltytypeDataAccess.GAPgListViewgen_penaltytype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}