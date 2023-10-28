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
	
	internal sealed partial class hr_ptareceiveddetlDataAccessObjects : BaseDataAccess, Ihr_ptareceiveddetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_ptareceiveddetlDataAccessObjects";
        
		public hr_ptareceiveddetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_ptareceiveddetlEntity hr_ptareceiveddetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_ptareceiveddetl.ptidetlid.HasValue)
				Database.AddInParameter(cmd, "@PTIDetlID", DbType.Int64, hr_ptareceiveddetl.ptidetlid);
            if (forDelete) return;
			if (hr_ptareceiveddetl.ptidemanddetlid.HasValue)
				Database.AddInParameter(cmd, "@PTIDemandDetlID", DbType.Int64, hr_ptareceiveddetl.ptidemanddetlid);
			if (hr_ptareceiveddetl.ptiid.HasValue)
				Database.AddInParameter(cmd, "@PTIID", DbType.Int64, hr_ptareceiveddetl.ptiid);
			if (hr_ptareceiveddetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_ptareceiveddetl.hrbasicid);
			if (hr_ptareceiveddetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_ptareceiveddetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_ptareceiveddetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_ptareceiveddetl.remarks);
			if (hr_ptareceiveddetl.letterstatus.HasValue)
				Database.AddInParameter(cmd, "@LetterStatus", DbType.Int64, hr_ptareceiveddetl.letterstatus);
			if ((hr_ptareceiveddetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_ptareceiveddetl.ex_date1);
			if ((hr_ptareceiveddetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_ptareceiveddetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_ptareceiveddetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_ptareceiveddetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_ptareceiveddetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_ptareceiveddetl.ex_nvarchar2);
			if (hr_ptareceiveddetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_ptareceiveddetl.ex_bigint1);
			if (hr_ptareceiveddetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_ptareceiveddetl.ex_bigint2);
			if (hr_ptareceiveddetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_ptareceiveddetl.ex_decimal1);
			if (hr_ptareceiveddetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_ptareceiveddetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_ptareceiveddetlDataAccessObjects.Add(hr_ptareceiveddetlEntity hr_ptareceiveddetl  )
        {
            long returnCode = -99;
            const string SP = "hr_ptareceiveddetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_ptareceiveddetl, cmd,Database);
                FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.Addhr_ptareceiveddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_ptareceiveddetlDataAccessObjects.Update(hr_ptareceiveddetlEntity hr_ptareceiveddetl )
        {
           long returnCode = -99;
            const string SP = "hr_ptareceiveddetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_ptareceiveddetl, cmd,Database);
                FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.Updatehr_ptareceiveddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_ptareceiveddetlDataAccessObjects.Delete(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
        {
            long returnCode = -99;
           	const string SP = "hr_ptareceiveddetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_ptareceiveddetl, cmd,Database, true);
                FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.Deletehr_ptareceiveddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_ptareceiveddetlDataAccessObjects.SaveList(IList<hr_ptareceiveddetlEntity> listAdded, IList<hr_ptareceiveddetlEntity> listUpdated, IList<hr_ptareceiveddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptareceiveddetl_Ins";
            const string SPUpdate = "hr_ptareceiveddetl_Upd";
            const string SPDelete = "hr_ptareceiveddetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptareceiveddetlEntity hr_ptareceiveddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptareceiveddetl, cmd, Database, true);
                            FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptareceiveddetlEntity hr_ptareceiveddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptareceiveddetl, cmd, Database);
                            FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptareceiveddetlEntity hr_ptareceiveddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptareceiveddetl, cmd, Database);
                            FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.Save_hr_ptareceiveddetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_ptareceiveddetlEntity> listAdded, IList<hr_ptareceiveddetlEntity> listUpdated, IList<hr_ptareceiveddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptareceiveddetl_Ins";
            const string SPUpdate = "hr_ptareceiveddetl_Upd";
            const string SPDelete = "hr_ptareceiveddetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptareceiveddetlEntity hr_ptareceiveddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptareceiveddetl, cmd, db, true);
                            FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptareceiveddetlEntity hr_ptareceiveddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptareceiveddetl, cmd, db);
                            FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptareceiveddetlEntity hr_ptareceiveddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptareceiveddetl, cmd, db);
                            FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.Save_hr_ptareceiveddetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlDataAccessObjects.GetAll(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
        {
           try
            {
				const string SP = "hr_ptareceiveddetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_ptareceiveddetl.SortExpression);
                    FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptareceiveddetl, cmd, Database);
                    
                    IList<hr_ptareceiveddetlEntity> itemList = new List<hr_ptareceiveddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceiveddetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.GetAllhr_ptareceiveddetl"));
            }	
        }
		
		IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlDataAccessObjects.GetAllByPages(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
        {
        try
            {
				const string SP = "hr_ptareceiveddetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptareceiveddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptareceiveddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptareceiveddetl.CurrentPage);                    
                    FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptareceiveddetl, cmd,Database);

                    IList<hr_ptareceiveddetlEntity> itemList = new List<hr_ptareceiveddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceiveddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptareceiveddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.GetAllByPageshr_ptareceiveddetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_ptareceiveddetlDataAccessObjects.SaveMasterDethr_flightinfodetl(hr_ptareceiveddetlEntity masterEntity, 
        IList<hr_flightinfodetlEntity> listAdded, 
        IList<hr_flightinfodetlEntity> listUpdated,
        IList<hr_flightinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_ptareceiveddetl_Ins";
            const string MasterSPUpdate = "hr_ptareceiveddetl_Upd";
            const string MasterSPDelete = "hr_ptareceiveddetl_Del";
            
			
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
                                item.ptidetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_flightinfodetlDataAccessObjects objhr_flightinfodetl=new hr_flightinfodetlDataAccessObjects(this.Context);
                        objhr_flightinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.SaveDshr_ptareceiveddetl"));
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
        hr_ptareceiveddetlEntity Ihr_ptareceiveddetlDataAccessObjects.GetSingle(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
        {
           try
            {
				const string SP = "hr_ptareceiveddetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptareceiveddetl, cmd, Database);
                    
                    IList<hr_ptareceiveddetlEntity> itemList = new List<hr_ptareceiveddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceiveddetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.GetSinglehr_ptareceiveddetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlDataAccessObjects.GAPgListView(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
        {
        try
            {
				const string SP = "hr_ptareceiveddetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptareceiveddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptareceiveddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptareceiveddetl.CurrentPage);                    
                    FillSequrityParameters(hr_ptareceiveddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptareceiveddetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_ptareceiveddetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_ptareceiveddetl.strCommonSerachParam);

                    IList<hr_ptareceiveddetlEntity> itemList = new List<hr_ptareceiveddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceiveddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptareceiveddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceiveddetlDataAccess.GAPgListViewhr_ptareceiveddetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}