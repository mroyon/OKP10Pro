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
	
	internal sealed partial class gen_authorizestrengthDataAccessObjects : BaseDataAccess, Igen_authorizestrengthDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_authorizestrengthDataAccessObjects";
        
		public gen_authorizestrengthDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_authorizestrengthEntity gen_authorizestrength, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_authorizestrength.authstrengthid.HasValue)
				Database.AddInParameter(cmd, "@AuthStrengthID", DbType.Int64, gen_authorizestrength.authstrengthid);
            if (forDelete) return;
			if (gen_authorizestrength.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, gen_authorizestrength.okpid);
			if (gen_authorizestrength.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, gen_authorizestrength.rankid);
			if (gen_authorizestrength.groupid.HasValue)
				Database.AddInParameter(cmd, "@GroupID", DbType.Int64, gen_authorizestrength.groupid);
			if (gen_authorizestrength.authstrength.HasValue)
				Database.AddInParameter(cmd, "@AuthStrength", DbType.Int64, gen_authorizestrength.authstrength);
			if (!(string.IsNullOrEmpty(gen_authorizestrength.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_authorizestrength.remarks);
			if ((gen_authorizestrength.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_authorizestrength.ex_date1);
			if ((gen_authorizestrength.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_authorizestrength.ex_date2);
			if (!(string.IsNullOrEmpty(gen_authorizestrength.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_authorizestrength.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_authorizestrength.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_authorizestrength.ex_nvarchar2);
			if (gen_authorizestrength.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_authorizestrength.ex_bigint1);
			if (gen_authorizestrength.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_authorizestrength.ex_bigint2);
			if (gen_authorizestrength.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_authorizestrength.ex_decimal1);
			if (gen_authorizestrength.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_authorizestrength.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_authorizestrengthDataAccessObjects.Add(gen_authorizestrengthEntity gen_authorizestrength  )
        {
            long returnCode = -99;
            const string SP = "gen_authorizestrength_InsExt";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_authorizestrength, cmd,Database);

                if (!(string.IsNullOrEmpty(gen_authorizestrength.strValue1))) Database.AddInParameter(cmd, "@String", DbType.String, gen_authorizestrength.strValue1);

                FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.Addgen_authorizestrength"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_authorizestrengthDataAccessObjects.Update(gen_authorizestrengthEntity gen_authorizestrength )
        {
           long returnCode = -99;
            const string SP = "gen_authorizestrength_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_authorizestrength, cmd,Database);
                FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.Updategen_authorizestrength"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_authorizestrengthDataAccessObjects.Delete(gen_authorizestrengthEntity gen_authorizestrength)
        {
            long returnCode = -99;
           	const string SP = "gen_authorizestrength_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_authorizestrength, cmd,Database, true);
                FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.Deletegen_authorizestrength"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_authorizestrengthDataAccessObjects.SaveList(IList<gen_authorizestrengthEntity> listAdded, IList<gen_authorizestrengthEntity> listUpdated, IList<gen_authorizestrengthEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_authorizestrength_Ins";
            const string SPUpdate = "gen_authorizestrength_Upd";
            const string SPDelete = "gen_authorizestrength_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_authorizestrengthEntity gen_authorizestrength in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_authorizestrength, cmd, Database, true);
                            FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_authorizestrengthEntity gen_authorizestrength in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_authorizestrength, cmd, Database);
                            FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_authorizestrengthEntity gen_authorizestrength in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_authorizestrength, cmd, Database);
                            FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.Save_gen_authorizestrength"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_authorizestrengthEntity> listAdded, IList<gen_authorizestrengthEntity> listUpdated, IList<gen_authorizestrengthEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_authorizestrength_Ins";
            const string SPUpdate = "gen_authorizestrength_Upd";
            const string SPDelete = "gen_authorizestrength_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_authorizestrengthEntity gen_authorizestrength in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_authorizestrength, cmd, db, true);
                            FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, db);
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
                    foreach (gen_authorizestrengthEntity gen_authorizestrength in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_authorizestrength, cmd, db);
                            FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, db);
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
                    foreach (gen_authorizestrengthEntity gen_authorizestrength in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_authorizestrength, cmd, db);
                            FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.Save_gen_authorizestrength"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_authorizestrengthEntity> Igen_authorizestrengthDataAccessObjects.GetAll(gen_authorizestrengthEntity gen_authorizestrength)
        {
           try
            {
				const string SP = "gen_authorizestrength_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_authorizestrength.SortExpression);
                    FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_authorizestrength, cmd, Database);
                    
                    IList<gen_authorizestrengthEntity> itemList = new List<gen_authorizestrengthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_authorizestrengthEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.GetAllgen_authorizestrength"));
            }	
        }
		
		IList<gen_authorizestrengthEntity> Igen_authorizestrengthDataAccessObjects.GetAllByPages(gen_authorizestrengthEntity gen_authorizestrength)
        {
        try
            {
				const string SP = "gen_authorizestrength_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_authorizestrength.SortExpression);
                    AddPageSizeParameter(cmd, gen_authorizestrength.PageSize);
                    AddCurrentPageParameter(cmd, gen_authorizestrength.CurrentPage);                    
                    FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_authorizestrength, cmd,Database);

                    IList<gen_authorizestrengthEntity> itemList = new List<gen_authorizestrengthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_authorizestrengthEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_authorizestrength.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.GetAllByPagesgen_authorizestrength"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_authorizestrengthEntity Igen_authorizestrengthDataAccessObjects.GetSingle(gen_authorizestrengthEntity gen_authorizestrength)
        {
           try
            {
				const string SP = "gen_authorizestrength_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_authorizestrength, cmd, Database);
                    
                    IList<gen_authorizestrengthEntity> itemList = new List<gen_authorizestrengthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_authorizestrengthEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.GetSinglegen_authorizestrength"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_authorizestrengthEntity> Igen_authorizestrengthDataAccessObjects.GAPgListView(gen_authorizestrengthEntity gen_authorizestrength)
        {
        try
            {
				//const string SP = "gen_authorizestrength_GAPgListView";
				const string SP = "gen_authorizestrength_GAPgListView_Ext";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_authorizestrength.SortExpression);
                    AddPageSizeParameter(cmd, gen_authorizestrength.PageSize);
                    AddCurrentPageParameter(cmd, gen_authorizestrength.CurrentPage);                    
                    FillSequrityParameters(gen_authorizestrength.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_authorizestrength, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_authorizestrength.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_authorizestrength.strCommonSerachParam);

                    IList<gen_authorizestrengthEntity> itemList = new List<gen_authorizestrengthEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            gen_authorizestrengthEntity objlist = new gen_authorizestrengthEntity();                                 
                            if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) objlist.okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                            itemList.Add(objlist);
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_authorizestrength.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_authorizestrengthDataAccess.GAPgListViewgen_authorizestrength"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}