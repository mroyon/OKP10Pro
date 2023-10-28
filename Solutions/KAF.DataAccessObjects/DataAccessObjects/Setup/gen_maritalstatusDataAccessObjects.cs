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
	
	internal sealed partial class gen_maritalstatusDataAccessObjects : BaseDataAccess, Igen_maritalstatusDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_maritalstatusDataAccessObjects";
        
		public gen_maritalstatusDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_maritalstatusEntity gen_maritalstatus, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_maritalstatus.maritalstatusid.HasValue)
				Database.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, gen_maritalstatus.maritalstatusid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_maritalstatus.maritalstatus)))
				Database.AddInParameter(cmd, "@MaritalStatus", DbType.String, gen_maritalstatus.maritalstatus);
			if (!(string.IsNullOrEmpty(gen_maritalstatus.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_maritalstatus.remarks);
			if (gen_maritalstatus.priority.HasValue)
				Database.AddInParameter(cmd, "@Priority", DbType.Int64, gen_maritalstatus.priority);
			if ((gen_maritalstatus.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_maritalstatus.ex_date1);
			if ((gen_maritalstatus.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_maritalstatus.ex_date2);
			if (!(string.IsNullOrEmpty(gen_maritalstatus.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_maritalstatus.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_maritalstatus.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_maritalstatus.ex_nvarchar2);
			if (gen_maritalstatus.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_maritalstatus.ex_bigint1);
			if (gen_maritalstatus.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_maritalstatus.ex_bigint2);
			if (gen_maritalstatus.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_maritalstatus.ex_decimal1);
			if (gen_maritalstatus.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_maritalstatus.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_maritalstatusDataAccessObjects.Add(gen_maritalstatusEntity gen_maritalstatus  )
        {
            long returnCode = -99;
            const string SP = "gen_maritalstatus_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_maritalstatus, cmd,Database);
                FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Addgen_maritalstatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_maritalstatusDataAccessObjects.Update(gen_maritalstatusEntity gen_maritalstatus )
        {
           long returnCode = -99;
            const string SP = "gen_maritalstatus_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_maritalstatus, cmd,Database);
                FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Updategen_maritalstatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_maritalstatusDataAccessObjects.Delete(gen_maritalstatusEntity gen_maritalstatus)
        {
            long returnCode = -99;
           	const string SP = "gen_maritalstatus_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_maritalstatus, cmd,Database, true);
                FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Deletegen_maritalstatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_maritalstatusDataAccessObjects.SaveList(IList<gen_maritalstatusEntity> listAdded, IList<gen_maritalstatusEntity> listUpdated, IList<gen_maritalstatusEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_maritalstatus_Ins";
            const string SPUpdate = "gen_maritalstatus_Upd";
            const string SPDelete = "gen_maritalstatus_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_maritalstatus, cmd, Database, true);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_maritalstatus, cmd, Database);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_maritalstatus, cmd, Database);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Save_gen_maritalstatus"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_maritalstatusEntity> listAdded, IList<gen_maritalstatusEntity> listUpdated, IList<gen_maritalstatusEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_maritalstatus_Ins";
            const string SPUpdate = "gen_maritalstatus_Upd";
            const string SPDelete = "gen_maritalstatus_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_maritalstatus, cmd, db, true);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_maritalstatus, cmd, db);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_maritalstatus, cmd, db);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Save_gen_maritalstatus"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_maritalstatusEntity> Igen_maritalstatusDataAccessObjects.GetAll(gen_maritalstatusEntity gen_maritalstatus)
        {
           try
            {
				const string SP = "gen_maritalstatus_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_maritalstatus, cmd, Database);
                    
                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetAllgen_maritalstatus"));
            }	
        }
		
		IList<gen_maritalstatusEntity> Igen_maritalstatusDataAccessObjects.GetAllByPages(gen_maritalstatusEntity gen_maritalstatus)
        {
        try
            {
				const string SP = "gen_maritalstatus_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_maritalstatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_maritalstatus.CurrentPage);                    
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_maritalstatus, cmd,Database);

                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_maritalstatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetAllByPagesgen_maritalstatus"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_maritalstatusDataAccessObjects.SaveMasterDethr_familyinfo(gen_maritalstatusEntity masterEntity, 
        IList<hr_familyinfoEntity> listAdded, 
        IList<hr_familyinfoEntity> listUpdated,
        IList<hr_familyinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_maritalstatus_Ins";
            const string MasterSPUpdate = "gen_maritalstatus_Upd";
            const string MasterSPDelete = "gen_maritalstatus_Del";
            
			
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
                                item.familymaritalstatusid=PrimaryKeyMaster;
                            }
                        }
                        hr_familyinfoDataAccessObjects objhr_familyinfo=new hr_familyinfoDataAccessObjects(this.Context);
                        objhr_familyinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.SaveDsgen_maritalstatus"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_maritalstatusDataAccessObjects.SaveMasterDethr_personalinfo(gen_maritalstatusEntity masterEntity, 
        IList<hr_personalinfoEntity> listAdded, 
        IList<hr_personalinfoEntity> listUpdated,
        IList<hr_personalinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_maritalstatus_Ins";
            const string MasterSPUpdate = "gen_maritalstatus_Upd";
            const string MasterSPDelete = "gen_maritalstatus_Del";
            
			
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
                                item.maritalstatusid=PrimaryKeyMaster;
                            }
                        }
                        hr_personalinfoDataAccessObjects objhr_personalinfo=new hr_personalinfoDataAccessObjects(this.Context);
                        objhr_personalinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.SaveDsgen_maritalstatus"));
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
        gen_maritalstatusEntity Igen_maritalstatusDataAccessObjects.GetSingle(gen_maritalstatusEntity gen_maritalstatus)
        {
           try
            {
				const string SP = "gen_maritalstatus_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_maritalstatus, cmd, Database);
                    
                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetSinglegen_maritalstatus"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_maritalstatusEntity> Igen_maritalstatusDataAccessObjects.GAPgListView(gen_maritalstatusEntity gen_maritalstatus)
        {
        try
            {
				const string SP = "gen_maritalstatus_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_maritalstatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_maritalstatus.CurrentPage);                    
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_maritalstatus, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_maritalstatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_maritalstatus.strCommonSerachParam);

                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_maritalstatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GAPgListViewgen_maritalstatus"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}