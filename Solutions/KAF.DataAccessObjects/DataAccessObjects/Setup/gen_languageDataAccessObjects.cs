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
	
	internal sealed partial class gen_languageDataAccessObjects : BaseDataAccess, Igen_languageDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_languageDataAccessObjects";
        
		public gen_languageDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_languageEntity gen_language, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_language.languageid.HasValue)
				Database.AddInParameter(cmd, "@LanguageID", DbType.Int64, gen_language.languageid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_language.languagename)))
				Database.AddInParameter(cmd, "@LanguageName", DbType.String, gen_language.languagename);
			if (!(string.IsNullOrEmpty(gen_language.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_language.remarks);
			if ((gen_language.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_language.ex_date1);
			if ((gen_language.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_language.ex_date2);
			if (!(string.IsNullOrEmpty(gen_language.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_language.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_language.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_language.ex_nvarchar2);
			if (gen_language.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_language.ex_bigint1);
			if (gen_language.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_language.ex_bigint2);
			if (gen_language.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_language.ex_decimal1);
			if (gen_language.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_language.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_languageDataAccessObjects.Add(gen_languageEntity gen_language  )
        {
            long returnCode = -99;
            const string SP = "gen_language_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_language, cmd,Database);
                FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.Addgen_language"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_languageDataAccessObjects.Update(gen_languageEntity gen_language )
        {
           long returnCode = -99;
            const string SP = "gen_language_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_language, cmd,Database);
                FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.Updategen_language"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_languageDataAccessObjects.Delete(gen_languageEntity gen_language)
        {
            long returnCode = -99;
           	const string SP = "gen_language_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_language, cmd,Database, true);
                FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.Deletegen_language"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_languageDataAccessObjects.SaveList(IList<gen_languageEntity> listAdded, IList<gen_languageEntity> listUpdated, IList<gen_languageEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_language_Ins";
            const string SPUpdate = "gen_language_Upd";
            const string SPDelete = "gen_language_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_languageEntity gen_language in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_language, cmd, Database, true);
                            FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_languageEntity gen_language in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_language, cmd, Database);
                            FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_languageEntity gen_language in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_language, cmd, Database);
                            FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.Save_gen_language"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_languageEntity> listAdded, IList<gen_languageEntity> listUpdated, IList<gen_languageEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_language_Ins";
            const string SPUpdate = "gen_language_Upd";
            const string SPDelete = "gen_language_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_languageEntity gen_language in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_language, cmd, db, true);
                            FillSequrityParameters(gen_language.BaseSecurityParam, cmd, db);
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
                    foreach (gen_languageEntity gen_language in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_language, cmd, db);
                            FillSequrityParameters(gen_language.BaseSecurityParam, cmd, db);
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
                    foreach (gen_languageEntity gen_language in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_language, cmd, db);
                            FillSequrityParameters(gen_language.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.Save_gen_language"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_languageEntity> Igen_languageDataAccessObjects.GetAll(gen_languageEntity gen_language)
        {
           try
            {
				const string SP = "gen_language_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_language.SortExpression);
                    FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_language, cmd, Database);
                    
                    IList<gen_languageEntity> itemList = new List<gen_languageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.GetAllgen_language"));
            }	
        }
		
		IList<gen_languageEntity> Igen_languageDataAccessObjects.GetAllByPages(gen_languageEntity gen_language)
        {
        try
            {
				const string SP = "gen_language_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_language.SortExpression);
                    AddPageSizeParameter(cmd, gen_language.PageSize);
                    AddCurrentPageParameter(cmd, gen_language.CurrentPage);                    
                    FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_language, cmd,Database);

                    IList<gen_languageEntity> itemList = new List<gen_languageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_language.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.GetAllByPagesgen_language"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_languageDataAccessObjects.SaveMasterDethr_languageproficiency(gen_languageEntity masterEntity, 
        IList<hr_languageproficiencyEntity> listAdded, 
        IList<hr_languageproficiencyEntity> listUpdated,
        IList<hr_languageproficiencyEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_language_Ins";
            const string MasterSPUpdate = "gen_language_Upd";
            const string MasterSPDelete = "gen_language_Del";
            
			
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
                                item.languageid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.SaveDsgen_language"));
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
        gen_languageEntity Igen_languageDataAccessObjects.GetSingle(gen_languageEntity gen_language)
        {
           try
            {
				const string SP = "gen_language_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_language, cmd, Database);
                    
                    IList<gen_languageEntity> itemList = new List<gen_languageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.GetSinglegen_language"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_languageEntity> Igen_languageDataAccessObjects.GAPgListView(gen_languageEntity gen_language)
        {
        try
            {
				const string SP = "gen_language_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_language.SortExpression);
                    AddPageSizeParameter(cmd, gen_language.PageSize);
                    AddCurrentPageParameter(cmd, gen_language.CurrentPage);                    
                    FillSequrityParameters(gen_language.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_language, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_language.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_language.strCommonSerachParam);

                    IList<gen_languageEntity> itemList = new List<gen_languageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_language.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_languageDataAccess.GAPgListViewgen_language"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}