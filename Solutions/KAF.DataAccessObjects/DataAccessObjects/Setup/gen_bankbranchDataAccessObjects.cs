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
	
	internal sealed partial class gen_bankbranchDataAccessObjects : BaseDataAccess, Igen_bankbranchDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_bankbranchDataAccessObjects";
        
		public gen_bankbranchDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_bankbranchEntity gen_bankbranch, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_bankbranch.branchid.HasValue)
				Database.AddInParameter(cmd, "@BranchID", DbType.Int64, gen_bankbranch.branchid);
            if (forDelete) return;
			if (gen_bankbranch.bankid.HasValue)
				Database.AddInParameter(cmd, "@BankID", DbType.Int64, gen_bankbranch.bankid);
			if (!(string.IsNullOrEmpty(gen_bankbranch.branchname)))
				Database.AddInParameter(cmd, "@BranchName", DbType.String, gen_bankbranch.branchname);
			if (!(string.IsNullOrEmpty(gen_bankbranch.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_bankbranch.remarks);
			if ((gen_bankbranch.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_bankbranch.ex_date1);
			if ((gen_bankbranch.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_bankbranch.ex_date2);
			if (!(string.IsNullOrEmpty(gen_bankbranch.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_bankbranch.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_bankbranch.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_bankbranch.ex_nvarchar2);
			if (gen_bankbranch.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_bankbranch.ex_bigint1);
			if (gen_bankbranch.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_bankbranch.ex_bigint2);
			if (gen_bankbranch.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_bankbranch.ex_decimal1);
			if (gen_bankbranch.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_bankbranch.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_bankbranchDataAccessObjects.Add(gen_bankbranchEntity gen_bankbranch  )
        {
            long returnCode = -99;
            const string SP = "gen_bankbranch_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_bankbranch, cmd,Database);
                FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.Addgen_bankbranch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_bankbranchDataAccessObjects.Update(gen_bankbranchEntity gen_bankbranch )
        {
           long returnCode = -99;
            const string SP = "gen_bankbranch_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_bankbranch, cmd,Database);
                FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.Updategen_bankbranch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_bankbranchDataAccessObjects.Delete(gen_bankbranchEntity gen_bankbranch)
        {
            long returnCode = -99;
           	const string SP = "gen_bankbranch_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_bankbranch, cmd,Database, true);
                FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.Deletegen_bankbranch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_bankbranchDataAccessObjects.SaveList(IList<gen_bankbranchEntity> listAdded, IList<gen_bankbranchEntity> listUpdated, IList<gen_bankbranchEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_bankbranch_Ins";
            const string SPUpdate = "gen_bankbranch_Upd";
            const string SPDelete = "gen_bankbranch_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_bankbranchEntity gen_bankbranch in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_bankbranch, cmd, Database, true);
                            FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_bankbranchEntity gen_bankbranch in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_bankbranch, cmd, Database);
                            FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_bankbranchEntity gen_bankbranch in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_bankbranch, cmd, Database);
                            FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.Save_gen_bankbranch"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_bankbranchEntity> listAdded, IList<gen_bankbranchEntity> listUpdated, IList<gen_bankbranchEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_bankbranch_Ins";
            const string SPUpdate = "gen_bankbranch_Upd";
            const string SPDelete = "gen_bankbranch_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_bankbranchEntity gen_bankbranch in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_bankbranch, cmd, db, true);
                            FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, db);
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
                    foreach (gen_bankbranchEntity gen_bankbranch in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_bankbranch, cmd, db);
                            FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, db);
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
                    foreach (gen_bankbranchEntity gen_bankbranch in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_bankbranch, cmd, db);
                            FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.Save_gen_bankbranch"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_bankbranchEntity> Igen_bankbranchDataAccessObjects.GetAll(gen_bankbranchEntity gen_bankbranch)
        {
           try
            {
				const string SP = "gen_bankbranch_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_bankbranch.SortExpression);
                    FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bankbranch, cmd, Database);
                    
                    IList<gen_bankbranchEntity> itemList = new List<gen_bankbranchEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankbranchEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.GetAllgen_bankbranch"));
            }	
        }
		
		IList<gen_bankbranchEntity> Igen_bankbranchDataAccessObjects.GetAllByPages(gen_bankbranchEntity gen_bankbranch)
        {
        try
            {
				const string SP = "gen_bankbranch_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bankbranch.SortExpression);
                    AddPageSizeParameter(cmd, gen_bankbranch.PageSize);
                    AddCurrentPageParameter(cmd, gen_bankbranch.CurrentPage);                    
                    FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_bankbranch, cmd,Database);

                    IList<gen_bankbranchEntity> itemList = new List<gen_bankbranchEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankbranchEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_bankbranch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.GetAllByPagesgen_bankbranch"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_bankbranchDataAccessObjects.SaveMasterDethr_bankaccountinfo(gen_bankbranchEntity masterEntity, 
        IList<hr_bankaccountinfoEntity> listAdded, 
        IList<hr_bankaccountinfoEntity> listUpdated,
        IList<hr_bankaccountinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_bankbranch_Ins";
            const string MasterSPUpdate = "gen_bankbranch_Upd";
            const string MasterSPDelete = "gen_bankbranch_Del";
            
			
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
                                item.branchid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.SaveDsgen_bankbranch"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_bankbranchDataAccessObjects.SaveMasterDethr_bankloaninfo(gen_bankbranchEntity masterEntity, 
        IList<hr_bankloaninfoEntity> listAdded, 
        IList<hr_bankloaninfoEntity> listUpdated,
        IList<hr_bankloaninfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_bankbranch_Ins";
            const string MasterSPUpdate = "gen_bankbranch_Upd";
            const string MasterSPDelete = "gen_bankbranch_Del";
            
			
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
                                item.branchid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.SaveDsgen_bankbranch"));
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
        gen_bankbranchEntity Igen_bankbranchDataAccessObjects.GetSingle(gen_bankbranchEntity gen_bankbranch)
        {
           try
            {
				const string SP = "gen_bankbranch_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bankbranch, cmd, Database);
                    
                    IList<gen_bankbranchEntity> itemList = new List<gen_bankbranchEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankbranchEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.GetSinglegen_bankbranch"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_bankbranchEntity> Igen_bankbranchDataAccessObjects.GAPgListView(gen_bankbranchEntity gen_bankbranch)
        {
        try
            {
				const string SP = "gen_bankbranch_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bankbranch.SortExpression);
                    AddPageSizeParameter(cmd, gen_bankbranch.PageSize);
                    AddCurrentPageParameter(cmd, gen_bankbranch.CurrentPage);                    
                    FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_bankbranch, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_bankbranch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_bankbranch.strCommonSerachParam);

                    IList<gen_bankbranchEntity> itemList = new List<gen_bankbranchEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankbranchEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_bankbranch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bankbranchDataAccess.GAPgListViewgen_bankbranch"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}