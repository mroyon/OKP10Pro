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
	
	internal sealed partial class gen_languageproficiencyDataAccessObjects : BaseDataAccess, Igen_languageproficiencyDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_languageproficiencyDataAccessObjects";
        
		public gen_languageproficiencyDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_languageproficiencyEntity gen_languageproficiency, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_languageproficiency.proficiencyid.HasValue)
				Database.AddInParameter(cmd, "@ProficiencyID", DbType.Int64, gen_languageproficiency.proficiencyid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_languageproficiency.proficiencyname)))
				Database.AddInParameter(cmd, "@ProficiencyName", DbType.String, gen_languageproficiency.proficiencyname);
			if (!(string.IsNullOrEmpty(gen_languageproficiency.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_languageproficiency.remarks);
			if ((gen_languageproficiency.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_languageproficiency.ex_date1);
			if ((gen_languageproficiency.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_languageproficiency.ex_date2);
			if (!(string.IsNullOrEmpty(gen_languageproficiency.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_languageproficiency.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_languageproficiency.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_languageproficiency.ex_nvarchar2);
			if (gen_languageproficiency.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_languageproficiency.ex_bigint1);
			if (gen_languageproficiency.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_languageproficiency.ex_bigint2);
			if (gen_languageproficiency.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_languageproficiency.ex_decimal1);
			if (gen_languageproficiency.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_languageproficiency.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_languageproficiencyDataAccessObjects.Add(gen_languageproficiencyEntity gen_languageproficiency  )
        {
            long returnCode = -99;
            const string SP = "gen_languageproficiency_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_languageproficiency, cmd,Database);
                FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.Addgen_languageproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_languageproficiencyDataAccessObjects.Update(gen_languageproficiencyEntity gen_languageproficiency )
        {
           long returnCode = -99;
            const string SP = "gen_languageproficiency_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_languageproficiency, cmd,Database);
                FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.Updategen_languageproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_languageproficiencyDataAccessObjects.Delete(gen_languageproficiencyEntity gen_languageproficiency)
        {
            long returnCode = -99;
           	const string SP = "gen_languageproficiency_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_languageproficiency, cmd,Database, true);
                FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.Deletegen_languageproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_languageproficiencyDataAccessObjects.SaveList(IList<gen_languageproficiencyEntity> listAdded, IList<gen_languageproficiencyEntity> listUpdated, IList<gen_languageproficiencyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_languageproficiency_Ins";
            const string SPUpdate = "gen_languageproficiency_Upd";
            const string SPDelete = "gen_languageproficiency_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_languageproficiencyEntity gen_languageproficiency in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_languageproficiency, cmd, Database, true);
                            FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_languageproficiencyEntity gen_languageproficiency in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_languageproficiency, cmd, Database);
                            FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_languageproficiencyEntity gen_languageproficiency in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_languageproficiency, cmd, Database);
                            FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.Save_gen_languageproficiency"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_languageproficiencyEntity> listAdded, IList<gen_languageproficiencyEntity> listUpdated, IList<gen_languageproficiencyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_languageproficiency_Ins";
            const string SPUpdate = "gen_languageproficiency_Upd";
            const string SPDelete = "gen_languageproficiency_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_languageproficiencyEntity gen_languageproficiency in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_languageproficiency, cmd, db, true);
                            FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, db);
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
                    foreach (gen_languageproficiencyEntity gen_languageproficiency in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_languageproficiency, cmd, db);
                            FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, db);
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
                    foreach (gen_languageproficiencyEntity gen_languageproficiency in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_languageproficiency, cmd, db);
                            FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.Save_gen_languageproficiency"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_languageproficiencyEntity> Igen_languageproficiencyDataAccessObjects.GetAll(gen_languageproficiencyEntity gen_languageproficiency)
        {
           try
            {
				const string SP = "gen_languageproficiency_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_languageproficiency.SortExpression);
                    FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_languageproficiency, cmd, Database);
                    
                    IList<gen_languageproficiencyEntity> itemList = new List<gen_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageproficiencyEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.GetAllgen_languageproficiency"));
            }	
        }
		
		IList<gen_languageproficiencyEntity> Igen_languageproficiencyDataAccessObjects.GetAllByPages(gen_languageproficiencyEntity gen_languageproficiency)
        {
        try
            {
				const string SP = "gen_languageproficiency_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_languageproficiency.SortExpression);
                    AddPageSizeParameter(cmd, gen_languageproficiency.PageSize);
                    AddCurrentPageParameter(cmd, gen_languageproficiency.CurrentPage);                    
                    FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_languageproficiency, cmd,Database);

                    IList<gen_languageproficiencyEntity> itemList = new List<gen_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageproficiencyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_languageproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.GetAllByPagesgen_languageproficiency"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_languageproficiencyDataAccessObjects.SaveMasterDethr_languageproficiency(gen_languageproficiencyEntity masterEntity, 
        IList<hr_languageproficiencyEntity> listAdded, 
        IList<hr_languageproficiencyEntity> listUpdated,
        IList<hr_languageproficiencyEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_languageproficiency_Ins";
            const string MasterSPUpdate = "gen_languageproficiency_Upd";
            const string MasterSPDelete = "gen_languageproficiency_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.readingproficiencyid=PrimaryKeyMaster;
                            }
                        }
                        hr_languageproficiencyDataAccessObjects objhr_languageproficiency=new hr_languageproficiencyDataAccessObjects(this.Context);
                        objhr_languageproficiency.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.SaveDsgen_languageproficiency"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        gen_languageproficiencyEntity Igen_languageproficiencyDataAccessObjects.GetSingle(gen_languageproficiencyEntity gen_languageproficiency)
        {
           try
            {
				const string SP = "gen_languageproficiency_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_languageproficiency, cmd, Database);
                    
                    IList<gen_languageproficiencyEntity> itemList = new List<gen_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageproficiencyEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.GetSinglegen_languageproficiency"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_languageproficiencyEntity> Igen_languageproficiencyDataAccessObjects.GAPgListView(gen_languageproficiencyEntity gen_languageproficiency)
        {
        try
            {
				const string SP = "gen_languageproficiency_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_languageproficiency.SortExpression);
                    AddPageSizeParameter(cmd, gen_languageproficiency.PageSize);
                    AddCurrentPageParameter(cmd, gen_languageproficiency.CurrentPage);                    
                    FillSequrityParameters(gen_languageproficiency.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_languageproficiency, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_languageproficiency.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_languageproficiency.strCommonSerachParam);

                    IList<gen_languageproficiencyEntity> itemList = new List<gen_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageproficiencyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_languageproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_languageproficiencyDataAccess.GAPgListViewgen_languageproficiency"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}