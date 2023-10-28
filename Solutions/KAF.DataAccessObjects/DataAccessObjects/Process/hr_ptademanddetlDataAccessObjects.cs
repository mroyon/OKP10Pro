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
	
	internal sealed partial class hr_ptademanddetlDataAccessObjects : BaseDataAccess, Ihr_ptademanddetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_ptademanddetlDataAccessObjects";
        
		public hr_ptademanddetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_ptademanddetlEntity hr_ptademanddetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_ptademanddetl.ptidemanddetlid.HasValue)
				Database.AddInParameter(cmd, "@PTIDemandDetlID", DbType.Int64, hr_ptademanddetl.ptidemanddetlid);
            if (forDelete) return;
			if (hr_ptademanddetl.visasentdetlid.HasValue)
				Database.AddInParameter(cmd, "@VisaSentDetlID", DbType.Int64, hr_ptademanddetl.visasentdetlid);
			if (hr_ptademanddetl.ptademandid.HasValue)
				Database.AddInParameter(cmd, "@PTADemandID", DbType.Int64, hr_ptademanddetl.ptademandid);
			if (hr_ptademanddetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_ptademanddetl.hrbasicid);
			if (hr_ptademanddetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_ptademanddetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_ptademanddetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_ptademanddetl.remarks);
			if (hr_ptademanddetl.letterstatus.HasValue)
				Database.AddInParameter(cmd, "@LetterStatus", DbType.Int64, hr_ptademanddetl.letterstatus);
			if ((hr_ptademanddetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_ptademanddetl.ex_date1);
			if ((hr_ptademanddetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_ptademanddetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_ptademanddetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_ptademanddetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_ptademanddetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_ptademanddetl.ex_nvarchar2);
			if (hr_ptademanddetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_ptademanddetl.ex_bigint1);
			if (hr_ptademanddetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_ptademanddetl.ex_bigint2);
			if (hr_ptademanddetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_ptademanddetl.ex_decimal1);
			if (hr_ptademanddetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_ptademanddetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_ptademanddetlDataAccessObjects.Add(hr_ptademanddetlEntity hr_ptademanddetl  )
        {
            long returnCode = -99;
            const string SP = "hr_ptademanddetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_ptademanddetl, cmd,Database);
                FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.Addhr_ptademanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_ptademanddetlDataAccessObjects.Update(hr_ptademanddetlEntity hr_ptademanddetl )
        {
           long returnCode = -99;
            const string SP = "hr_ptademanddetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_ptademanddetl, cmd,Database);
                FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.Updatehr_ptademanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_ptademanddetlDataAccessObjects.Delete(hr_ptademanddetlEntity hr_ptademanddetl)
        {
            long returnCode = -99;
           	const string SP = "hr_ptademanddetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_ptademanddetl, cmd,Database, true);
                FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.Deletehr_ptademanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_ptademanddetlDataAccessObjects.SaveList(IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptademanddetl_Ins";
            const string SPUpdate = "hr_ptademanddetl_Upd";
            const string SPDelete = "hr_ptademanddetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptademanddetlEntity hr_ptademanddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptademanddetl, cmd, Database, true);
                            FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptademanddetlEntity hr_ptademanddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptademanddetl, cmd, Database);
                            FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptademanddetlEntity hr_ptademanddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptademanddetl, cmd, Database);
                            FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.Save_hr_ptademanddetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptademanddetl_Ins";
            const string SPUpdate = "hr_ptademanddetl_Upd";
            const string SPDelete = "hr_ptademanddetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptademanddetlEntity hr_ptademanddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptademanddetl, cmd, db, true);
                            FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptademanddetlEntity hr_ptademanddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptademanddetl, cmd, db);
                            FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptademanddetlEntity hr_ptademanddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptademanddetl, cmd, db);
                            FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.Save_hr_ptademanddetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_ptademanddetlEntity> Ihr_ptademanddetlDataAccessObjects.GetAll(hr_ptademanddetlEntity hr_ptademanddetl)
        {
           try
            {
				const string SP = "hr_ptademanddetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_ptademanddetl.SortExpression);
                    FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptademanddetl, cmd, Database);
                    
                    IList<hr_ptademanddetlEntity> itemList = new List<hr_ptademanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.GetAllhr_ptademanddetl"));
            }	
        }
		
		IList<hr_ptademanddetlEntity> Ihr_ptademanddetlDataAccessObjects.GetAllByPages(hr_ptademanddetlEntity hr_ptademanddetl)
        {
        try
            {
				const string SP = "hr_ptademanddetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptademanddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptademanddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptademanddetl.CurrentPage);                    
                    FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptademanddetl, cmd,Database);

                    IList<hr_ptademanddetlEntity> itemList = new List<hr_ptademanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptademanddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.GetAllByPageshr_ptademanddetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_ptademanddetlDataAccessObjects.SaveMasterDethr_ptareceiveddetl(hr_ptademanddetlEntity masterEntity, 
        IList<hr_ptareceiveddetlEntity> listAdded, 
        IList<hr_ptareceiveddetlEntity> listUpdated,
        IList<hr_ptareceiveddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_ptademanddetl_Ins";
            const string MasterSPUpdate = "hr_ptademanddetl_Upd";
            const string MasterSPDelete = "hr_ptademanddetl_Del";
            
			
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
                                item.ptidemanddetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_ptareceiveddetlDataAccessObjects objhr_ptareceiveddetl=new hr_ptareceiveddetlDataAccessObjects(this.Context);
                        objhr_ptareceiveddetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.SaveDshr_ptademanddetl"));
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
        hr_ptademanddetlEntity Ihr_ptademanddetlDataAccessObjects.GetSingle(hr_ptademanddetlEntity hr_ptademanddetl)
        {
           try
            {
				const string SP = "hr_ptademanddetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptademanddetl, cmd, Database);
                    
                    IList<hr_ptademanddetlEntity> itemList = new List<hr_ptademanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademanddetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.GetSinglehr_ptademanddetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_ptademanddetlEntity> Ihr_ptademanddetlDataAccessObjects.GAPgListView(hr_ptademanddetlEntity hr_ptademanddetl)
        {
        try
            {
				const string SP = "hr_ptademanddetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptademanddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptademanddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptademanddetl.CurrentPage);                    
                    FillSequrityParameters(hr_ptademanddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptademanddetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_ptademanddetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_ptademanddetl.strCommonSerachParam);

                    IList<hr_ptademanddetlEntity> itemList = new List<hr_ptademanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptademanddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademanddetlDataAccess.GAPgListViewhr_ptademanddetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}