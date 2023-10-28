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
	
	internal sealed partial class hr_newdemanddetlDataAccessObjects : BaseDataAccess, Ihr_newdemanddetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_newdemanddetlDataAccessObjects";
        
		public hr_newdemanddetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_newdemanddetlEntity hr_newdemanddetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_newdemanddetl.newdemanddetlid.HasValue)
				Database.AddInParameter(cmd, "@NewDemandDetlID", DbType.Int64, hr_newdemanddetl.newdemanddetlid);
            if (forDelete) return;
			if (hr_newdemanddetl.newdemandid.HasValue)
				Database.AddInParameter(cmd, "@NewDemandID", DbType.Int64, hr_newdemanddetl.newdemandid);
			if (hr_newdemanddetl.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, hr_newdemanddetl.rankid);
			if (hr_newdemanddetl.tradeid.HasValue)
				Database.AddInParameter(cmd, "@TradeID", DbType.Int64, hr_newdemanddetl.tradeid);
			if (hr_newdemanddetl.groupid.HasValue)
				Database.AddInParameter(cmd, "@GroupID", DbType.Int64, hr_newdemanddetl.groupid);
			if (hr_newdemanddetl.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, hr_newdemanddetl.okpid);
			if (hr_newdemanddetl.noofvacancies.HasValue)
				Database.AddInParameter(cmd, "@NoOfVacancies", DbType.Int64, hr_newdemanddetl.noofvacancies);
			if (!(string.IsNullOrEmpty(hr_newdemanddetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_newdemanddetl.remarks);
			if ((hr_newdemanddetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_newdemanddetl.ex_date1);
			if ((hr_newdemanddetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_newdemanddetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_newdemanddetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_newdemanddetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_newdemanddetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_newdemanddetl.ex_nvarchar2);
			if (hr_newdemanddetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_newdemanddetl.ex_bigint1);
			if (hr_newdemanddetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_newdemanddetl.ex_bigint2);
			if (hr_newdemanddetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_newdemanddetl.ex_decimal1);
			if (hr_newdemanddetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_newdemanddetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_newdemanddetlDataAccessObjects.Add(hr_newdemanddetlEntity hr_newdemanddetl  )
        {
            long returnCode = -99;
            const string SP = "hr_newdemanddetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_newdemanddetl, cmd,Database);
                FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Addhr_newdemanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_newdemanddetlDataAccessObjects.Update(hr_newdemanddetlEntity hr_newdemanddetl )
        {
           long returnCode = -99;
            const string SP = "hr_newdemanddetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_newdemanddetl, cmd,Database);
                FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Updatehr_newdemanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_newdemanddetlDataAccessObjects.Delete(hr_newdemanddetlEntity hr_newdemanddetl)
        {
            long returnCode = -99;
           	const string SP = "hr_newdemanddetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_newdemanddetl, cmd,Database, true);
                FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Deletehr_newdemanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_newdemanddetlDataAccessObjects.SaveList(IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemanddetl_Ins";
            const string SPUpdate = "hr_newdemanddetl_Upd";
            const string SPDelete = "hr_newdemanddetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemanddetl, cmd, Database, true);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemanddetl, cmd, Database);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemanddetl, cmd, Database);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Save_hr_newdemanddetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemanddetl_Ins";
            const string SPUpdate = "hr_newdemanddetl_Upd";
            const string SPDelete = "hr_newdemanddetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemanddetl, cmd, db, true);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemanddetl, cmd, db);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemanddetl, cmd, db);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Save_hr_newdemanddetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_newdemanddetlEntity> Ihr_newdemanddetlDataAccessObjects.GetAll(hr_newdemanddetlEntity hr_newdemanddetl)
        {
           try
            {
				const string SP = "hr_newdemanddetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_newdemanddetl.SortExpression);
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemanddetl, cmd, Database);
                    
                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GetAllhr_newdemanddetl"));
            }	
        }
		
		IList<hr_newdemanddetlEntity> Ihr_newdemanddetlDataAccessObjects.GetAllByPages(hr_newdemanddetlEntity hr_newdemanddetl)
        {
        try
            {
				const string SP = "hr_newdemanddetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemanddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemanddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemanddetl.CurrentPage);                    
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemanddetl, cmd,Database);

                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemanddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GetAllByPageshr_newdemanddetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_newdemanddetlDataAccessObjects.SaveMasterDethr_demanddetlpassport(hr_newdemanddetlEntity masterEntity, 
        IList<hr_demanddetlpassportEntity> listAdded, 
        IList<hr_demanddetlpassportEntity> listUpdated,
        IList<hr_demanddetlpassportEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_newdemanddetl_Ins";
            const string MasterSPUpdate = "hr_newdemanddetl_Upd";
            const string MasterSPDelete = "hr_newdemanddetl_Del";
            
			
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
                                item.newdemanddetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_demanddetlpassportDataAccessObjects objhr_demanddetlpassport=new hr_demanddetlpassportDataAccessObjects(this.Context);
                        objhr_demanddetlpassport.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.SaveDshr_newdemanddetl"));
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
        hr_newdemanddetlEntity Ihr_newdemanddetlDataAccessObjects.GetSingle(hr_newdemanddetlEntity hr_newdemanddetl)
        {
           try
            {
				const string SP = "hr_newdemanddetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemanddetl, cmd, Database);
                    
                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GetSinglehr_newdemanddetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_newdemanddetlEntity> Ihr_newdemanddetlDataAccessObjects.GAPgListView(hr_newdemanddetlEntity hr_newdemanddetl)
        {
        try
            {
				const string SP = "hr_newdemanddetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemanddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemanddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemanddetl.CurrentPage);                    
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemanddetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_newdemanddetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_newdemanddetl.strCommonSerachParam);

                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemanddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GAPgListViewhr_newdemanddetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}