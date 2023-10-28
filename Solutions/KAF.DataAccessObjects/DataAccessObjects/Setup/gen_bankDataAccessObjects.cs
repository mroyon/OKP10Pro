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
	
	internal sealed partial class gen_bankDataAccessObjects : BaseDataAccess, Igen_bankDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_bankDataAccessObjects";
        
		public gen_bankDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_bankEntity gen_bank, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_bank.bankid.HasValue)
				Database.AddInParameter(cmd, "@BankID", DbType.Int64, gen_bank.bankid);
            if (forDelete) return;
			if (gen_bank.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_bank.countryid);
			if (!(string.IsNullOrEmpty(gen_bank.bankname)))
				Database.AddInParameter(cmd, "@BankName", DbType.String, gen_bank.bankname);
			if (!(string.IsNullOrEmpty(gen_bank.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_bank.remarks);
			if ((gen_bank.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_bank.ex_date1);
			if ((gen_bank.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_bank.ex_date2);
			if (!(string.IsNullOrEmpty(gen_bank.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_bank.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_bank.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_bank.ex_nvarchar2);
			if (gen_bank.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_bank.ex_bigint1);
			if (gen_bank.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_bank.ex_bigint2);
			if (gen_bank.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_bank.ex_decimal1);
			if (gen_bank.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_bank.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_bankDataAccessObjects.Add(gen_bankEntity gen_bank  )
        {
            long returnCode = -99;
            const string SP = "gen_bank_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_bank, cmd,Database);
                FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.Addgen_bank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_bankDataAccessObjects.Update(gen_bankEntity gen_bank )
        {
           long returnCode = -99;
            const string SP = "gen_bank_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_bank, cmd,Database);
                FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.Updategen_bank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_bankDataAccessObjects.Delete(gen_bankEntity gen_bank)
        {
            long returnCode = -99;
           	const string SP = "gen_bank_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_bank, cmd,Database, true);
                FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.Deletegen_bank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_bankDataAccessObjects.SaveList(IList<gen_bankEntity> listAdded, IList<gen_bankEntity> listUpdated, IList<gen_bankEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_bank_Ins";
            const string SPUpdate = "gen_bank_Upd";
            const string SPDelete = "gen_bank_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_bankEntity gen_bank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_bank, cmd, Database, true);
                            FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_bankEntity gen_bank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_bank, cmd, Database);
                            FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_bankEntity gen_bank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_bank, cmd, Database);
                            FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.Save_gen_bank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_bankEntity> listAdded, IList<gen_bankEntity> listUpdated, IList<gen_bankEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_bank_Ins";
            const string SPUpdate = "gen_bank_Upd";
            const string SPDelete = "gen_bank_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_bankEntity gen_bank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_bank, cmd, db, true);
                            FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_bankEntity gen_bank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_bank, cmd, db);
                            FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_bankEntity gen_bank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_bank, cmd, db);
                            FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.Save_gen_bank"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_bankEntity> Igen_bankDataAccessObjects.GetAll(gen_bankEntity gen_bank)
        {
           try
            {
				const string SP = "gen_bank_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_bank.SortExpression);
                    FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bank, cmd, Database);
                    
                    IList<gen_bankEntity> itemList = new List<gen_bankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.GetAllgen_bank"));
            }	
        }
		
		IList<gen_bankEntity> Igen_bankDataAccessObjects.GetAllByPages(gen_bankEntity gen_bank)
        {
        try
            {
				const string SP = "gen_bank_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bank.SortExpression);
                    AddPageSizeParameter(cmd, gen_bank.PageSize);
                    AddCurrentPageParameter(cmd, gen_bank.CurrentPage);                    
                    FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_bank, cmd,Database);

                    IList<gen_bankEntity> itemList = new List<gen_bankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_bank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.GetAllByPagesgen_bank"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_bankDataAccessObjects.SaveMasterDetgen_bankbranch(gen_bankEntity masterEntity, 
        IList<gen_bankbranchEntity> listAdded, 
        IList<gen_bankbranchEntity> listUpdated,
        IList<gen_bankbranchEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_bank_Ins";
            const string MasterSPUpdate = "gen_bank_Upd";
            const string MasterSPDelete = "gen_bank_Del";
            
			
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
                                item.bankid=PrimaryKeyMaster;
                            }
                        }
                        gen_bankbranchDataAccessObjects objgen_bankbranch=new gen_bankbranchDataAccessObjects(this.Context);
                        objgen_bankbranch.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.SaveDsgen_bank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_bankDataAccessObjects.SaveMasterDethr_bankaccountinfo(gen_bankEntity masterEntity, 
        IList<hr_bankaccountinfoEntity> listAdded, 
        IList<hr_bankaccountinfoEntity> listUpdated,
        IList<hr_bankaccountinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_bank_Ins";
            const string MasterSPUpdate = "gen_bank_Upd";
            const string MasterSPDelete = "gen_bank_Del";
            
			
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
                                item.bankid=PrimaryKeyMaster;
                            }
                        }
                        hr_bankaccountinfoDataAccessObjects objhr_bankaccountinfo=new hr_bankaccountinfoDataAccessObjects(this.Context);
                        objhr_bankaccountinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.SaveDsgen_bank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_bankDataAccessObjects.SaveMasterDethr_bankloaninfo(gen_bankEntity masterEntity, 
        IList<hr_bankloaninfoEntity> listAdded, 
        IList<hr_bankloaninfoEntity> listUpdated,
        IList<hr_bankloaninfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_bank_Ins";
            const string MasterSPUpdate = "gen_bank_Upd";
            const string MasterSPDelete = "gen_bank_Del";
            
			
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
                                item.bankid=PrimaryKeyMaster;
                            }
                        }
                        hr_bankloaninfoDataAccessObjects objhr_bankloaninfo=new hr_bankloaninfoDataAccessObjects(this.Context);
                        objhr_bankloaninfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.SaveDsgen_bank"));
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
        gen_bankEntity Igen_bankDataAccessObjects.GetSingle(gen_bankEntity gen_bank)
        {
           try
            {
				const string SP = "gen_bank_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bank, cmd, Database);
                    
                    IList<gen_bankEntity> itemList = new List<gen_bankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.GetSinglegen_bank"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_bankEntity> Igen_bankDataAccessObjects.GAPgListView(gen_bankEntity gen_bank)
        {
        try
            {
				const string SP = "gen_bank_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bank.SortExpression);
                    AddPageSizeParameter(cmd, gen_bank.PageSize);
                    AddCurrentPageParameter(cmd, gen_bank.CurrentPage);                    
                    FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_bank, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_bank.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_bank.strCommonSerachParam);

                    IList<gen_bankEntity> itemList = new List<gen_bankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_bank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bankDataAccess.GAPgListViewgen_bank"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}