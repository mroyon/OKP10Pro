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
	
	internal sealed partial class gen_tradeDataAccessObjects : BaseDataAccess, Igen_tradeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_tradeDataAccessObjects";
        
		public gen_tradeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_tradeEntity gen_trade, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_trade.tradeid.HasValue)
				Database.AddInParameter(cmd, "@TradeID", DbType.Int64, gen_trade.tradeid);
            if (forDelete) return;
			if (gen_trade.forceid.HasValue)
				Database.AddInParameter(cmd, "@ForceID", DbType.Int64, gen_trade.forceid);
			if (gen_trade.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_trade.countryid);
			if (!(string.IsNullOrEmpty(gen_trade.tradename)))
				Database.AddInParameter(cmd, "@TradeName", DbType.String, gen_trade.tradename);
			if (!(string.IsNullOrEmpty(gen_trade.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_trade.remarks);
			if ((gen_trade.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_trade.ex_date1);
			if ((gen_trade.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_trade.ex_date2);
			if (!(string.IsNullOrEmpty(gen_trade.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_trade.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_trade.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_trade.ex_nvarchar2);
			if (gen_trade.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_trade.ex_bigint1);
			if (gen_trade.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_trade.ex_bigint2);
			if (gen_trade.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_trade.ex_decimal1);
			if (gen_trade.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_trade.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_tradeDataAccessObjects.Add(gen_tradeEntity gen_trade  )
        {
            long returnCode = -99;
            const string SP = "gen_trade_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_trade, cmd,Database);
                FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.Addgen_trade"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_tradeDataAccessObjects.Update(gen_tradeEntity gen_trade )
        {
           long returnCode = -99;
            const string SP = "gen_trade_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_trade, cmd,Database);
                FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.Updategen_trade"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_tradeDataAccessObjects.Delete(gen_tradeEntity gen_trade)
        {
            long returnCode = -99;
           	const string SP = "gen_trade_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_trade, cmd,Database, true);
                FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.Deletegen_trade"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_tradeDataAccessObjects.SaveList(IList<gen_tradeEntity> listAdded, IList<gen_tradeEntity> listUpdated, IList<gen_tradeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_trade_Ins";
            const string SPUpdate = "gen_trade_Upd";
            const string SPDelete = "gen_trade_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_tradeEntity gen_trade in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_trade, cmd, Database, true);
                            FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_tradeEntity gen_trade in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_trade, cmd, Database);
                            FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_tradeEntity gen_trade in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_trade, cmd, Database);
                            FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.Save_gen_trade"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_tradeEntity> listAdded, IList<gen_tradeEntity> listUpdated, IList<gen_tradeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_trade_Ins";
            const string SPUpdate = "gen_trade_Upd";
            const string SPDelete = "gen_trade_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_tradeEntity gen_trade in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_trade, cmd, db, true);
                            FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, db);
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
                    foreach (gen_tradeEntity gen_trade in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_trade, cmd, db);
                            FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, db);
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
                    foreach (gen_tradeEntity gen_trade in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_trade, cmd, db);
                            FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.Save_gen_trade"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_tradeEntity> Igen_tradeDataAccessObjects.GetAll(gen_tradeEntity gen_trade)
        {
           try
            {
				const string SP = "gen_trade_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_trade.SortExpression);
                    FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_trade, cmd, Database);
                    
                    IList<gen_tradeEntity> itemList = new List<gen_tradeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_tradeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.GetAllgen_trade"));
            }	
        }
		
		IList<gen_tradeEntity> Igen_tradeDataAccessObjects.GetAllByPages(gen_tradeEntity gen_trade)
        {
        try
            {
				const string SP = "gen_trade_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_trade.SortExpression);
                    AddPageSizeParameter(cmd, gen_trade.PageSize);
                    AddCurrentPageParameter(cmd, gen_trade.CurrentPage);                    
                    FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_trade, cmd,Database);

                    IList<gen_tradeEntity> itemList = new List<gen_tradeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_tradeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_trade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.GetAllByPagesgen_trade"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_tradeDataAccessObjects.SaveMasterDethr_newdemanddetl(gen_tradeEntity masterEntity, 
        IList<hr_newdemanddetlEntity> listAdded, 
        IList<hr_newdemanddetlEntity> listUpdated,
        IList<hr_newdemanddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_trade_Ins";
            const string MasterSPUpdate = "gen_trade_Upd";
            const string MasterSPDelete = "gen_trade_Del";
            
			
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
                                item.tradeid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.SaveDsgen_trade"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_tradeDataAccessObjects.SaveMasterDethr_svcinfo(gen_tradeEntity masterEntity, 
        IList<hr_svcinfoEntity> listAdded, 
        IList<hr_svcinfoEntity> listUpdated,
        IList<hr_svcinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_trade_Ins";
            const string MasterSPUpdate = "gen_trade_Upd";
            const string MasterSPDelete = "gen_trade_Del";
            
			
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
                                item.tradeidkw=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.SaveDsgen_trade"));
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
        gen_tradeEntity Igen_tradeDataAccessObjects.GetSingle(gen_tradeEntity gen_trade)
        {
           try
            {
				const string SP = "gen_trade_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_trade, cmd, Database);
                    
                    IList<gen_tradeEntity> itemList = new List<gen_tradeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_tradeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.GetSinglegen_trade"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_tradeEntity> Igen_tradeDataAccessObjects.GAPgListView(gen_tradeEntity gen_trade)
        {
        try
            {
				const string SP = "gen_trade_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_trade.SortExpression);
                    AddPageSizeParameter(cmd, gen_trade.PageSize);
                    AddCurrentPageParameter(cmd, gen_trade.CurrentPage);                    
                    FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_trade, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_trade.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_trade.strCommonSerachParam);

                    IList<gen_tradeEntity> itemList = new List<gen_tradeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_tradeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_trade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_tradeDataAccess.GAPgListViewgen_trade"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}