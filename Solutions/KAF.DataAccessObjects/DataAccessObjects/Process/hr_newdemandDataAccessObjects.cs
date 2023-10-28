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
	
	internal sealed partial class hr_newdemandDataAccessObjects : BaseDataAccess, Ihr_newdemandDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_newdemandDataAccessObjects";
        
		public hr_newdemandDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_newdemandEntity hr_newdemand, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_newdemand.newdemandid.HasValue)
				Database.AddInParameter(cmd, "@NewDemandID", DbType.Int64, hr_newdemand.newdemandid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(hr_newdemand.demandletterno)))
				Database.AddInParameter(cmd, "@DemandLetterNo", DbType.String, hr_newdemand.demandletterno);
			if ((hr_newdemand.demandletterdate.HasValue))
				Database.AddInParameter(cmd, "@DemandLetterDate", DbType.DateTime, hr_newdemand.demandletterdate);
			if (!(string.IsNullOrEmpty(hr_newdemand.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_newdemand.remarks);
			if ((hr_newdemand.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_newdemand.ex_date1);
			if ((hr_newdemand.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_newdemand.ex_date2);
			if (!(string.IsNullOrEmpty(hr_newdemand.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_newdemand.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_newdemand.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_newdemand.ex_nvarchar2);
			if (hr_newdemand.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_newdemand.ex_bigint1);
			if (hr_newdemand.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_newdemand.ex_bigint2);
			if (hr_newdemand.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_newdemand.ex_decimal1);
			if (hr_newdemand.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_newdemand.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_newdemandDataAccessObjects.Add(hr_newdemandEntity hr_newdemand  )
        {
            long returnCode = -99;
            const string SP = "hr_newdemand_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_newdemand, cmd,Database);
                FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Addhr_newdemand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_newdemandDataAccessObjects.Update(hr_newdemandEntity hr_newdemand )
        {
           long returnCode = -99;
            const string SP = "hr_newdemand_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_newdemand, cmd,Database);
                FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Updatehr_newdemand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_newdemandDataAccessObjects.Delete(hr_newdemandEntity hr_newdemand)
        {
            long returnCode = -99;
           	const string SP = "hr_newdemand_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_newdemand, cmd,Database, true);
                FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Deletehr_newdemand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_newdemandDataAccessObjects.SaveList(IList<hr_newdemandEntity> listAdded, IList<hr_newdemandEntity> listUpdated, IList<hr_newdemandEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemand_Ins";
            const string SPUpdate = "hr_newdemand_Upd";
            const string SPDelete = "hr_newdemand_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemandEntity hr_newdemand in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemand, cmd, Database, true);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemandEntity hr_newdemand in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemand, cmd, Database);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemandEntity hr_newdemand in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemand, cmd, Database);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Save_hr_newdemand"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_newdemandEntity> listAdded, IList<hr_newdemandEntity> listUpdated, IList<hr_newdemandEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemand_Ins";
            const string SPUpdate = "hr_newdemand_Upd";
            const string SPDelete = "hr_newdemand_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemandEntity hr_newdemand in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemand, cmd, db, true);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, db);
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
                    foreach (hr_newdemandEntity hr_newdemand in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemand, cmd, db);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, db);
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
                    foreach (hr_newdemandEntity hr_newdemand in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemand, cmd, db);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Save_hr_newdemand"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_newdemandEntity> Ihr_newdemandDataAccessObjects.GetAll(hr_newdemandEntity hr_newdemand)
        {
           try
            {
				const string SP = "hr_newdemand_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_newdemand.SortExpression);
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemand, cmd, Database);
                    
                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GetAllhr_newdemand"));
            }	
        }
		
		IList<hr_newdemandEntity> Ihr_newdemandDataAccessObjects.GetAllByPages(hr_newdemandEntity hr_newdemand)
        {
        try
            {
				const string SP = "hr_newdemand_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemand.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemand.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemand.CurrentPage);                    
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemand, cmd,Database);

                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemand.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GetAllByPageshr_newdemand"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_newdemandDataAccessObjects.SaveMasterDethr_newdemanddetl(hr_newdemandEntity masterEntity, 
        IList<hr_newdemanddetlEntity> listAdded, 
        IList<hr_newdemanddetlEntity> listUpdated,
        IList<hr_newdemanddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_newdemand_Ins";
            const string MasterSPUpdate = "hr_newdemand_Upd";
            const string MasterSPDelete = "hr_newdemand_Del";
            
			
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
                                item.newdemandid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.SaveDshr_newdemand"));
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
        hr_newdemandEntity Ihr_newdemandDataAccessObjects.GetSingle(hr_newdemandEntity hr_newdemand)
        {
           try
            {
				const string SP = "hr_newdemand_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemand, cmd, Database);
                    
                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GetSinglehr_newdemand"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_newdemandEntity> Ihr_newdemandDataAccessObjects.GAPgListView(hr_newdemandEntity hr_newdemand)
        {
        try
            {
				const string SP = "hr_newdemand_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemand.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemand.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemand.CurrentPage);                    
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemand, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_newdemand.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_newdemand.strCommonSerachParam);

                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemand.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GAPgListViewhr_newdemand"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}