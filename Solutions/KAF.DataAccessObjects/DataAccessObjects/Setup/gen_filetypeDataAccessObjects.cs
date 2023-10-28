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
	
	internal sealed partial class gen_filetypeDataAccessObjects : BaseDataAccess, Igen_filetypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_filetypeDataAccessObjects";
        
		public gen_filetypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_filetypeEntity gen_filetype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_filetype.filetypeid.HasValue)
				Database.AddInParameter(cmd, "@FileTypeID", DbType.Int64, gen_filetype.filetypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_filetype.filetypename)))
				Database.AddInParameter(cmd, "@FileTypeName", DbType.String, gen_filetype.filetypename);
			if (!(string.IsNullOrEmpty(gen_filetype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_filetype.remarks);
			if ((gen_filetype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_filetype.ex_date1);
			if ((gen_filetype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_filetype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_filetype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_filetype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_filetype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_filetype.ex_nvarchar2);
			if (gen_filetype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_filetype.ex_bigint1);
			if (gen_filetype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_filetype.ex_bigint2);
			if (gen_filetype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_filetype.ex_decimal1);
			if (gen_filetype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_filetype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_filetypeDataAccessObjects.Add(gen_filetypeEntity gen_filetype  )
        {
            long returnCode = -99;
            const string SP = "gen_filetype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_filetype, cmd,Database);
                FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.Addgen_filetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_filetypeDataAccessObjects.Update(gen_filetypeEntity gen_filetype )
        {
           long returnCode = -99;
            const string SP = "gen_filetype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_filetype, cmd,Database);
                FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.Updategen_filetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_filetypeDataAccessObjects.Delete(gen_filetypeEntity gen_filetype)
        {
            long returnCode = -99;
           	const string SP = "gen_filetype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_filetype, cmd,Database, true);
                FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.Deletegen_filetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_filetypeDataAccessObjects.SaveList(IList<gen_filetypeEntity> listAdded, IList<gen_filetypeEntity> listUpdated, IList<gen_filetypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_filetype_Ins";
            const string SPUpdate = "gen_filetype_Upd";
            const string SPDelete = "gen_filetype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_filetypeEntity gen_filetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_filetype, cmd, Database, true);
                            FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_filetypeEntity gen_filetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_filetype, cmd, Database);
                            FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_filetypeEntity gen_filetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_filetype, cmd, Database);
                            FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.Save_gen_filetype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_filetypeEntity> listAdded, IList<gen_filetypeEntity> listUpdated, IList<gen_filetypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_filetype_Ins";
            const string SPUpdate = "gen_filetype_Upd";
            const string SPDelete = "gen_filetype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_filetypeEntity gen_filetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_filetype, cmd, db, true);
                            FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_filetypeEntity gen_filetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_filetype, cmd, db);
                            FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_filetypeEntity gen_filetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_filetype, cmd, db);
                            FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.Save_gen_filetype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_filetypeEntity> Igen_filetypeDataAccessObjects.GetAll(gen_filetypeEntity gen_filetype)
        {
           try
            {
				const string SP = "gen_filetype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_filetype.SortExpression);
                    FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_filetype, cmd, Database);
                    
                    IList<gen_filetypeEntity> itemList = new List<gen_filetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_filetypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.GetAllgen_filetype"));
            }	
        }
		
		IList<gen_filetypeEntity> Igen_filetypeDataAccessObjects.GetAllByPages(gen_filetypeEntity gen_filetype)
        {
        try
            {
				const string SP = "gen_filetype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_filetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_filetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_filetype.CurrentPage);                    
                    FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_filetype, cmd,Database);

                    IList<gen_filetypeEntity> itemList = new List<gen_filetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_filetypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_filetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.GetAllByPagesgen_filetype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_filetypeDataAccessObjects.SaveMasterDethr_basicfile(gen_filetypeEntity masterEntity, 
        IList<hr_basicfileEntity> listAdded, 
        IList<hr_basicfileEntity> listUpdated,
        IList<hr_basicfileEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_filetype_Ins";
            const string MasterSPUpdate = "gen_filetype_Upd";
            const string MasterSPDelete = "gen_filetype_Del";
            
			
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
                                item.filetypeid=PrimaryKeyMaster;
                            }
                        }
                        hr_basicfileDataAccessObjects objhr_basicfile=new hr_basicfileDataAccessObjects(this.Context);
                        objhr_basicfile.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.SaveDsgen_filetype"));
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
        gen_filetypeEntity Igen_filetypeDataAccessObjects.GetSingle(gen_filetypeEntity gen_filetype)
        {
           try
            {
				const string SP = "gen_filetype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_filetype, cmd, Database);
                    
                    IList<gen_filetypeEntity> itemList = new List<gen_filetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_filetypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.GetSinglegen_filetype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_filetypeEntity> Igen_filetypeDataAccessObjects.GAPgListView(gen_filetypeEntity gen_filetype)
        {
        try
            {
				const string SP = "gen_filetype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_filetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_filetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_filetype.CurrentPage);                    
                    FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_filetype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_filetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_filetype.strCommonSerachParam);

                    IList<gen_filetypeEntity> itemList = new List<gen_filetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_filetypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_filetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_filetypeDataAccess.GAPgListViewgen_filetype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}