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
	
	internal sealed partial class hr_visaissueinfodetlDataAccessObjects : BaseDataAccess, Ihr_visaissueinfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_visaissueinfodetlDataAccessObjects";
        
		public hr_visaissueinfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_visaissueinfodetlEntity hr_visaissueinfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_visaissueinfodetl.visaissuedetlid.HasValue)
				Database.AddInParameter(cmd, "@VisaIssueDetlID", DbType.Int64, hr_visaissueinfodetl.visaissuedetlid);
            if (forDelete) return;
			if (hr_visaissueinfodetl.visaissueid.HasValue)
				Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, hr_visaissueinfodetl.visaissueid);
			if (hr_visaissueinfodetl.visademanddetlid.HasValue)
				Database.AddInParameter(cmd, "@VisaDemandDetlID", DbType.Int64, hr_visaissueinfodetl.visademanddetlid);
			if (hr_visaissueinfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_visaissueinfodetl.hrbasicid);
			if (hr_visaissueinfodetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_visaissueinfodetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_visaissueinfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_visaissueinfodetl.remarks);
			if ((hr_visaissueinfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_visaissueinfodetl.ex_date1);
			if ((hr_visaissueinfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_visaissueinfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_visaissueinfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_visaissueinfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_visaissueinfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_visaissueinfodetl.ex_nvarchar2);
			if (hr_visaissueinfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_visaissueinfodetl.ex_bigint1);
			if (hr_visaissueinfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_visaissueinfodetl.ex_bigint2);
			if (hr_visaissueinfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_visaissueinfodetl.ex_decimal1);
			if (hr_visaissueinfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_visaissueinfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_visaissueinfodetlDataAccessObjects.Add(hr_visaissueinfodetlEntity hr_visaissueinfodetl  )
        {
            long returnCode = -99;
            const string SP = "hr_visaissueinfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_visaissueinfodetl, cmd,Database);
                FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.Addhr_visaissueinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_visaissueinfodetlDataAccessObjects.Update(hr_visaissueinfodetlEntity hr_visaissueinfodetl )
        {
           long returnCode = -99;
            const string SP = "hr_visaissueinfodetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_visaissueinfodetl, cmd,Database);
                FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.Updatehr_visaissueinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_visaissueinfodetlDataAccessObjects.Delete(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
        {
            long returnCode = -99;
           	const string SP = "hr_visaissueinfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_visaissueinfodetl, cmd,Database, true);
                FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.Deletehr_visaissueinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_visaissueinfodetlDataAccessObjects.SaveList(IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visaissueinfodetl_Ins";
            const string SPUpdate = "hr_visaissueinfodetl_Upd";
            const string SPDelete = "hr_visaissueinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visaissueinfodetlEntity hr_visaissueinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visaissueinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visaissueinfodetlEntity hr_visaissueinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visaissueinfodetl, cmd, Database);
                            FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visaissueinfodetlEntity hr_visaissueinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visaissueinfodetl, cmd, Database);
                            FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.Save_hr_visaissueinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visaissueinfodetl_Ins";
            const string SPUpdate = "hr_visaissueinfodetl_Upd";
            const string SPDelete = "hr_visaissueinfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visaissueinfodetlEntity hr_visaissueinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visaissueinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visaissueinfodetlEntity hr_visaissueinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visaissueinfodetl, cmd, db);
                            FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visaissueinfodetlEntity hr_visaissueinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visaissueinfodetl, cmd, db);
                            FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.Save_hr_visaissueinfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlDataAccessObjects.GetAll(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
        {
           try
            {
				const string SP = "hr_visaissueinfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_visaissueinfodetl.SortExpression);
                    FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visaissueinfodetl, cmd, Database);
                    
                    IList<hr_visaissueinfodetlEntity> itemList = new List<hr_visaissueinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.GetAllhr_visaissueinfodetl"));
            }	
        }
		
		IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlDataAccessObjects.GetAllByPages(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
        {
        try
            {
				const string SP = "hr_visaissueinfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visaissueinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_visaissueinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_visaissueinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visaissueinfodetl, cmd,Database);

                    IList<hr_visaissueinfodetlEntity> itemList = new List<hr_visaissueinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visaissueinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.GetAllByPageshr_visaissueinfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_visaissueinfodetlDataAccessObjects.SaveMasterDethr_visasentinfodetl(hr_visaissueinfodetlEntity masterEntity, 
        IList<hr_visasentinfodetlEntity> listAdded, 
        IList<hr_visasentinfodetlEntity> listUpdated,
        IList<hr_visasentinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visaissueinfodetl_Ins";
            const string MasterSPUpdate = "hr_visaissueinfodetl_Upd";
            const string MasterSPDelete = "hr_visaissueinfodetl_Del";
            
			
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
                                item.visaissuedetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_visasentinfodetlDataAccessObjects objhr_visasentinfodetl=new hr_visasentinfodetlDataAccessObjects(this.Context);
                        objhr_visasentinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.SaveDshr_visaissueinfodetl"));
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
        hr_visaissueinfodetlEntity Ihr_visaissueinfodetlDataAccessObjects.GetSingle(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
        {
           try
            {
				const string SP = "hr_visaissueinfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visaissueinfodetl, cmd, Database);
                    
                    IList<hr_visaissueinfodetlEntity> itemList = new List<hr_visaissueinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.GetSinglehr_visaissueinfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlDataAccessObjects.GAPgListView(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
        {
        try
            {
				const string SP = "hr_visaissueinfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visaissueinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_visaissueinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_visaissueinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_visaissueinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visaissueinfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_visaissueinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_visaissueinfodetl.strCommonSerachParam);

                    IList<hr_visaissueinfodetlEntity> itemList = new List<hr_visaissueinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visaissueinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfodetlDataAccess.GAPgListViewhr_visaissueinfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}