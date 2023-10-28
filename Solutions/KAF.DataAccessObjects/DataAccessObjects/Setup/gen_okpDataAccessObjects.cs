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
	
	internal sealed partial class gen_okpDataAccessObjects : BaseDataAccess, Igen_okpDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_okpDataAccessObjects";
        
		public gen_okpDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_okpEntity gen_okp, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_okp.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, gen_okp.okpid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_okp.okpname)))
				Database.AddInParameter(cmd, "@OkpName", DbType.String, gen_okp.okpname);
			
				Database.AddInParameter(cmd, "@Description", DbType.String, gen_okp.description);
			if ((gen_okp.raisingdate.HasValue))
				Database.AddInParameter(cmd, "@RaisingDate", DbType.DateTime, gen_okp.raisingdate);
			if (!(string.IsNullOrEmpty(gen_okp.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_okp.remarks);
			if ((gen_okp.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_okp.ex_date1);
			if ((gen_okp.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_okp.ex_date2);
			if (!(string.IsNullOrEmpty(gen_okp.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_okp.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_okp.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_okp.ex_nvarchar2);
			if (gen_okp.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_okp.ex_bigint1);
			if (gen_okp.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_okp.ex_bigint2);
			if (gen_okp.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_okp.ex_decimal1);
			if (gen_okp.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_okp.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_okpDataAccessObjects.Add(gen_okpEntity gen_okp  )
        {
            long returnCode = -99;
            const string SP = "gen_okp_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_okp, cmd,Database);
                FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.Addgen_okp"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_okpDataAccessObjects.Update(gen_okpEntity gen_okp )
        {
           long returnCode = -99;
            const string SP = "gen_okp_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_okp, cmd,Database);
                FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.Updategen_okp"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_okpDataAccessObjects.Delete(gen_okpEntity gen_okp)
        {
            long returnCode = -99;
           	const string SP = "gen_okp_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_okp, cmd,Database, true);
                FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.Deletegen_okp"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_okpDataAccessObjects.SaveList(IList<gen_okpEntity> listAdded, IList<gen_okpEntity> listUpdated, IList<gen_okpEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_okp_Ins";
            const string SPUpdate = "gen_okp_Upd";
            const string SPDelete = "gen_okp_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_okpEntity gen_okp in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_okp, cmd, Database, true);
                            FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_okpEntity gen_okp in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_okp, cmd, Database);
                            FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_okpEntity gen_okp in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_okp, cmd, Database);
                            FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.Save_gen_okp"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_okpEntity> listAdded, IList<gen_okpEntity> listUpdated, IList<gen_okpEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_okp_Ins";
            const string SPUpdate = "gen_okp_Upd";
            const string SPDelete = "gen_okp_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_okpEntity gen_okp in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_okp, cmd, db, true);
                            FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, db);
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
                    foreach (gen_okpEntity gen_okp in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_okp, cmd, db);
                            FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, db);
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
                    foreach (gen_okpEntity gen_okp in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_okp, cmd, db);
                            FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.Save_gen_okp"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_okpEntity> Igen_okpDataAccessObjects.GetAll(gen_okpEntity gen_okp)
        {
           try
            {
				const string SP = "gen_okp_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_okp.SortExpression);
                    FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_okp, cmd, Database);
                    
                    IList<gen_okpEntity> itemList = new List<gen_okpEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.GetAllgen_okp"));
            }	
        }
		
		IList<gen_okpEntity> Igen_okpDataAccessObjects.GetAllByPages(gen_okpEntity gen_okp)
        {
        try
            {
				const string SP = "gen_okp_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_okp.SortExpression);
                    AddPageSizeParameter(cmd, gen_okp.PageSize);
                    AddCurrentPageParameter(cmd, gen_okp.CurrentPage);                    
                    FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_okp, cmd,Database);

                    IList<gen_okpEntity> itemList = new List<gen_okpEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_okp.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.GetAllByPagesgen_okp"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_okpDataAccessObjects.SaveMasterDetgen_okpco(gen_okpEntity masterEntity, 
        IList<gen_okpcoEntity> listAdded, 
        IList<gen_okpcoEntity> listUpdated,
        IList<gen_okpcoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_okp_Ins";
            const string MasterSPUpdate = "gen_okp_Upd";
            const string MasterSPDelete = "gen_okp_Del";
            
			
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
                                item.okpid=PrimaryKeyMaster;
                            }
                        }
                        gen_okpcoDataAccessObjects objgen_okpco=new gen_okpcoDataAccessObjects(this.Context);
                        objgen_okpco.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.SaveDsgen_okp"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_okpDataAccessObjects.SaveMasterDethr_newdemanddetl(gen_okpEntity masterEntity, 
        IList<hr_newdemanddetlEntity> listAdded, 
        IList<hr_newdemanddetlEntity> listUpdated,
        IList<hr_newdemanddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_okp_Ins";
            const string MasterSPUpdate = "gen_okp_Upd";
            const string MasterSPDelete = "gen_okp_Del";
            
			
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
                                item.okpid=PrimaryKeyMaster;
                            }
                        }
                        hr_newdemanddetlDataAccessObjects objhr_newdemanddetl=new hr_newdemanddetlDataAccessObjects(this.Context);
                        objhr_newdemanddetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.SaveDsgen_okp"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_okpDataAccessObjects.SaveMasterDethr_svcinfo(gen_okpEntity masterEntity, 
        IList<hr_svcinfoEntity> listAdded, 
        IList<hr_svcinfoEntity> listUpdated,
        IList<hr_svcinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_okp_Ins";
            const string MasterSPUpdate = "gen_okp_Upd";
            const string MasterSPDelete = "gen_okp_Del";
            
			
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
                                item.okpid=PrimaryKeyMaster;
                            }
                        }
                        hr_svcinfoDataAccessObjects objhr_svcinfo=new hr_svcinfoDataAccessObjects(this.Context);
                        objhr_svcinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.SaveDsgen_okp"));
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
        gen_okpEntity Igen_okpDataAccessObjects.GetSingle(gen_okpEntity gen_okp)
        {
           try
            {
				const string SP = "gen_okp_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_okp, cmd, Database);
                    
                    IList<gen_okpEntity> itemList = new List<gen_okpEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.GetSinglegen_okp"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_okpEntity> Igen_okpDataAccessObjects.GAPgListView(gen_okpEntity gen_okp)
        {
        try
            {
				const string SP = "gen_okp_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_okp.SortExpression);
                    AddPageSizeParameter(cmd, gen_okp.PageSize);
                    AddCurrentPageParameter(cmd, gen_okp.CurrentPage);                    
                    FillSequrityParameters(gen_okp.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_okp, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_okp.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_okp.strCommonSerachParam);

                    IList<gen_okpEntity> itemList = new List<gen_okpEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_okp.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_okpDataAccess.GAPgListViewgen_okp"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}