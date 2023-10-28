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
	
	internal sealed partial class hr_visasentinfodetlDataAccessObjects : BaseDataAccess, Ihr_visasentinfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_visasentinfodetlDataAccessObjects";
        
		public hr_visasentinfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_visasentinfodetlEntity hr_visasentinfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_visasentinfodetl.visasentdetlid.HasValue)
				Database.AddInParameter(cmd, "@VisaSentDetlID", DbType.Int64, hr_visasentinfodetl.visasentdetlid);
            if (forDelete) return;
			if (hr_visasentinfodetl.visasentid.HasValue)
				Database.AddInParameter(cmd, "@VisaSentID", DbType.Int64, hr_visasentinfodetl.visasentid);
			if (hr_visasentinfodetl.visaissuedetlid.HasValue)
				Database.AddInParameter(cmd, "@VisaIssueDetlID", DbType.Int64, hr_visasentinfodetl.visaissuedetlid);
			if (hr_visasentinfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_visasentinfodetl.hrbasicid);
			if (hr_visasentinfodetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_visasentinfodetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_visasentinfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_visasentinfodetl.remarks);
			if ((hr_visasentinfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_visasentinfodetl.ex_date1);
			if ((hr_visasentinfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_visasentinfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_visasentinfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_visasentinfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_visasentinfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_visasentinfodetl.ex_nvarchar2);
			if (hr_visasentinfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_visasentinfodetl.ex_bigint1);
			if (hr_visasentinfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_visasentinfodetl.ex_bigint2);
			if (hr_visasentinfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_visasentinfodetl.ex_decimal1);
			if (hr_visasentinfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_visasentinfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_visasentinfodetlDataAccessObjects.Add(hr_visasentinfodetlEntity hr_visasentinfodetl  )
        {
            long returnCode = -99;
            const string SP = "hr_visasentinfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_visasentinfodetl, cmd,Database);
                FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.Addhr_visasentinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_visasentinfodetlDataAccessObjects.Update(hr_visasentinfodetlEntity hr_visasentinfodetl )
        {
           long returnCode = -99;
            const string SP = "hr_visasentinfodetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_visasentinfodetl, cmd,Database);
                FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.Updatehr_visasentinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_visasentinfodetlDataAccessObjects.Delete(hr_visasentinfodetlEntity hr_visasentinfodetl)
        {
            long returnCode = -99;
           	const string SP = "hr_visasentinfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_visasentinfodetl, cmd,Database, true);
                FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.Deletehr_visasentinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_visasentinfodetlDataAccessObjects.SaveList(IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visasentinfodetl_Ins";
            const string SPUpdate = "hr_visasentinfodetl_Upd";
            const string SPDelete = "hr_visasentinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visasentinfodetlEntity hr_visasentinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visasentinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visasentinfodetlEntity hr_visasentinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visasentinfodetl, cmd, Database);
                            FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visasentinfodetlEntity hr_visasentinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visasentinfodetl, cmd, Database);
                            FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.Save_hr_visasentinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visasentinfodetl_Ins";
            const string SPUpdate = "hr_visasentinfodetl_Upd";
            const string SPDelete = "hr_visasentinfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visasentinfodetlEntity hr_visasentinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visasentinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visasentinfodetlEntity hr_visasentinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visasentinfodetl, cmd, db);
                            FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visasentinfodetlEntity hr_visasentinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visasentinfodetl, cmd, db);
                            FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.Save_hr_visasentinfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlDataAccessObjects.GetAll(hr_visasentinfodetlEntity hr_visasentinfodetl)
        {
           try
            {
				const string SP = "hr_visasentinfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_visasentinfodetl.SortExpression);
                    FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visasentinfodetl, cmd, Database);
                    
                    IList<hr_visasentinfodetlEntity> itemList = new List<hr_visasentinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.GetAllhr_visasentinfodetl"));
            }	
        }
		
		IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlDataAccessObjects.GetAllByPages(hr_visasentinfodetlEntity hr_visasentinfodetl)
        {
        try
            {
				const string SP = "hr_visasentinfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visasentinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_visasentinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_visasentinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visasentinfodetl, cmd,Database);

                    IList<hr_visasentinfodetlEntity> itemList = new List<hr_visasentinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visasentinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.GetAllByPageshr_visasentinfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_visasentinfodetlDataAccessObjects.SaveMasterDethr_ptademanddetl(hr_visasentinfodetlEntity masterEntity, 
        IList<hr_ptademanddetlEntity> listAdded, 
        IList<hr_ptademanddetlEntity> listUpdated,
        IList<hr_ptademanddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visasentinfodetl_Ins";
            const string MasterSPUpdate = "hr_visasentinfodetl_Upd";
            const string MasterSPDelete = "hr_visasentinfodetl_Del";
            
			
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
                                item.visasentdetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_ptademanddetlDataAccessObjects objhr_ptademanddetl=new hr_ptademanddetlDataAccessObjects(this.Context);
                        objhr_ptademanddetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.SaveDshr_visasentinfodetl"));
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
        hr_visasentinfodetlEntity Ihr_visasentinfodetlDataAccessObjects.GetSingle(hr_visasentinfodetlEntity hr_visasentinfodetl)
        {
           try
            {
				const string SP = "hr_visasentinfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visasentinfodetl, cmd, Database);
                    
                    IList<hr_visasentinfodetlEntity> itemList = new List<hr_visasentinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.GetSinglehr_visasentinfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlDataAccessObjects.GAPgListView(hr_visasentinfodetlEntity hr_visasentinfodetl)
        {
        try
            {
				const string SP = "hr_visasentinfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visasentinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_visasentinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_visasentinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_visasentinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visasentinfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_visasentinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_visasentinfodetl.strCommonSerachParam);

                    IList<hr_visasentinfodetlEntity> itemList = new List<hr_visasentinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visasentinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfodetlDataAccess.GAPgListViewhr_visasentinfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}