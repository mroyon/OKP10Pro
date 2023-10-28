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
	
	internal sealed partial class gen_rankDataAccessObjects : BaseDataAccess, Igen_rankDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_rankDataAccessObjects";
        
		public gen_rankDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_rankEntity gen_rank, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_rank.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, gen_rank.rankid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_rank.rankname)))
				Database.AddInParameter(cmd, "@RankName", DbType.String, gen_rank.rankname);
			if (gen_rank.ranktypeid.HasValue)
				Database.AddInParameter(cmd, "@RankTypeID", DbType.Int64, gen_rank.ranktypeid);
			if (gen_rank.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_rank.countryid);
			if (gen_rank.typepriority.HasValue)
				Database.AddInParameter(cmd, "@TypePriority", DbType.Int64, gen_rank.typepriority);
			if (gen_rank.priority.HasValue)
				Database.AddInParameter(cmd, "@Priority", DbType.Int64, gen_rank.priority);
			if (!(string.IsNullOrEmpty(gen_rank.comments)))
				Database.AddInParameter(cmd, "@Comments", DbType.String, gen_rank.comments);
			if (!(string.IsNullOrEmpty(gen_rank.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_rank.remarks);
			if ((gen_rank.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_rank.ex_date1);
			if ((gen_rank.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_rank.ex_date2);
			if (!(string.IsNullOrEmpty(gen_rank.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_rank.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_rank.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_rank.ex_nvarchar2);
			if (gen_rank.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_rank.ex_bigint1);
			if (gen_rank.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_rank.ex_bigint2);
			if (gen_rank.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_rank.ex_decimal1);
			if (gen_rank.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_rank.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_rankDataAccessObjects.Add(gen_rankEntity gen_rank  )
        {
            long returnCode = -99;
            const string SP = "gen_rank_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_rank, cmd,Database);
                FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Addgen_rank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_rankDataAccessObjects.Update(gen_rankEntity gen_rank )
        {
           long returnCode = -99;
            const string SP = "gen_rank_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_rank, cmd,Database);
                FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Updategen_rank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_rankDataAccessObjects.Delete(gen_rankEntity gen_rank)
        {
            long returnCode = -99;
           	const string SP = "gen_rank_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_rank, cmd,Database, true);
                FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Deletegen_rank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_rankDataAccessObjects.SaveList(IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_rank_Ins";
            const string SPUpdate = "gen_rank_Upd";
            const string SPDelete = "gen_rank_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_rankEntity gen_rank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_rank, cmd, Database, true);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_rankEntity gen_rank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_rank, cmd, Database);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_rankEntity gen_rank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_rank, cmd, Database);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Save_gen_rank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_rank_Ins";
            const string SPUpdate = "gen_rank_Upd";
            const string SPDelete = "gen_rank_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_rankEntity gen_rank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_rank, cmd, db, true);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_rankEntity gen_rank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_rank, cmd, db);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_rankEntity gen_rank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_rank, cmd, db);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Save_gen_rank"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_rankEntity> Igen_rankDataAccessObjects.GetAll(gen_rankEntity gen_rank)
        {
           try
            {
				const string SP = "gen_rank_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_rank, cmd, Database);
                    
                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GetAllgen_rank"));
            }	
        }
		
		IList<gen_rankEntity> Igen_rankDataAccessObjects.GetAllByPages(gen_rankEntity gen_rank)
        {
        try
            {
				const string SP = "gen_rank_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    AddPageSizeParameter(cmd, gen_rank.PageSize);
                    AddCurrentPageParameter(cmd, gen_rank.CurrentPage);                    
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_rank, cmd,Database);

                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_rank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GetAllByPagesgen_rank"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_rankDataAccessObjects.SaveMasterDethr_promotioninfo(gen_rankEntity masterEntity, 
        IList<hr_promotioninfoEntity> listAdded, 
        IList<hr_promotioninfoEntity> listUpdated,
        IList<hr_promotioninfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_rank_Ins";
            const string MasterSPUpdate = "gen_rank_Upd";
            const string MasterSPDelete = "gen_rank_Del";
            
			
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
                                item.torankid=PrimaryKeyMaster;
                            }
                        }
                        hr_promotioninfoDataAccessObjects objhr_promotioninfo=new hr_promotioninfoDataAccessObjects(this.Context);
                        objhr_promotioninfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.SaveDsgen_rank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_rankDataAccessObjects.SaveMasterDethr_newdemanddetl(gen_rankEntity masterEntity, 
        IList<hr_newdemanddetlEntity> listAdded, 
        IList<hr_newdemanddetlEntity> listUpdated,
        IList<hr_newdemanddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_rank_Ins";
            const string MasterSPUpdate = "gen_rank_Upd";
            const string MasterSPDelete = "gen_rank_Del";
            
			
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
                                item.rankid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.SaveDsgen_rank"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_rankDataAccessObjects.SaveMasterDethr_svcinfo(gen_rankEntity masterEntity, 
        IList<hr_svcinfoEntity> listAdded, 
        IList<hr_svcinfoEntity> listUpdated,
        IList<hr_svcinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_rank_Ins";
            const string MasterSPUpdate = "gen_rank_Upd";
            const string MasterSPDelete = "gen_rank_Del";
            
			
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
                                item.rankidkw=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.SaveDsgen_rank"));
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
        gen_rankEntity Igen_rankDataAccessObjects.GetSingle(gen_rankEntity gen_rank)
        {
           try
            {
				const string SP = "gen_rank_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_rank, cmd, Database);
                    
                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GetSinglegen_rank"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_rankEntity> Igen_rankDataAccessObjects.GAPgListView(gen_rankEntity gen_rank)
        {
        try
            {
				const string SP = "gen_rank_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    AddPageSizeParameter(cmd, gen_rank.PageSize);
                    AddCurrentPageParameter(cmd, gen_rank.CurrentPage);                    
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_rank, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_rank.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_rank.strCommonSerachParam);

                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_rank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GAPgListViewgen_rank"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}