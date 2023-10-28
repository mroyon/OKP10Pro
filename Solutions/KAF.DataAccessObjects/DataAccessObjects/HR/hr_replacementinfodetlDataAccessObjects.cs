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
	
	internal sealed partial class hr_replacementinfodetlDataAccessObjects : BaseDataAccess, Ihr_replacementinfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_replacementinfodetlDataAccessObjects";
        
		public hr_replacementinfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_replacementinfodetlEntity hr_replacementinfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_replacementinfodetl.replacementdetlid.HasValue)
				Database.AddInParameter(cmd, "@ReplacementDetlID", DbType.Int64, hr_replacementinfodetl.replacementdetlid);
            if (forDelete) return;
			if (hr_replacementinfodetl.replacementid.HasValue)
				Database.AddInParameter(cmd, "@ReplacementID", DbType.Int64, hr_replacementinfodetl.replacementid);
			if (hr_replacementinfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_replacementinfodetl.hrbasicid);
			if (hr_replacementinfodetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_replacementinfodetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_replacementinfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_replacementinfodetl.remarks);
			if ((hr_replacementinfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_replacementinfodetl.ex_date1);
			if ((hr_replacementinfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_replacementinfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_replacementinfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_replacementinfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_replacementinfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_replacementinfodetl.ex_nvarchar2);
			if (hr_replacementinfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_replacementinfodetl.ex_bigint1);
			if (hr_replacementinfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_replacementinfodetl.ex_bigint2);
			if (hr_replacementinfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_replacementinfodetl.ex_decimal1);
			if (hr_replacementinfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_replacementinfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_replacementinfodetlDataAccessObjects.Add(hr_replacementinfodetlEntity hr_replacementinfodetl  )
        {
            long returnCode = -99;
            const string SP = "hr_replacementinfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_replacementinfodetl, cmd,Database);
                FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.Addhr_replacementinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_replacementinfodetlDataAccessObjects.Update(hr_replacementinfodetlEntity hr_replacementinfodetl )
        {
           long returnCode = -99;
            const string SP = "hr_replacementinfodetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_replacementinfodetl, cmd,Database);
                FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.Updatehr_replacementinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_replacementinfodetlDataAccessObjects.Delete(hr_replacementinfodetlEntity hr_replacementinfodetl)
        {
            long returnCode = -99;
           	const string SP = "hr_replacementinfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_replacementinfodetl, cmd,Database, true);
                FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.Deletehr_replacementinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_replacementinfodetlDataAccessObjects.SaveList(IList<hr_replacementinfodetlEntity> listAdded, IList<hr_replacementinfodetlEntity> listUpdated, IList<hr_replacementinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_replacementinfodetl_Ins";
            const string SPUpdate = "hr_replacementinfodetl_Upd";
            const string SPDelete = "hr_replacementinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_replacementinfodetlEntity hr_replacementinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_replacementinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_replacementinfodetlEntity hr_replacementinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_replacementinfodetl, cmd, Database);
                            FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_replacementinfodetlEntity hr_replacementinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_replacementinfodetl, cmd, Database);
                            FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.Save_hr_replacementinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_replacementinfodetlEntity> listAdded, IList<hr_replacementinfodetlEntity> listUpdated, IList<hr_replacementinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_replacementinfodetl_Ins";
            const string SPUpdate = "hr_replacementinfodetl_Upd";
            const string SPDelete = "hr_replacementinfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_replacementinfodetlEntity hr_replacementinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_replacementinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_replacementinfodetlEntity hr_replacementinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_replacementinfodetl, cmd, db);
                            FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_replacementinfodetlEntity hr_replacementinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_replacementinfodetl, cmd, db);
                            FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.Save_hr_replacementinfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlDataAccessObjects.GetAll(hr_replacementinfodetlEntity hr_replacementinfodetl)
        {
           try
            {
				const string SP = "hr_replacementinfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_replacementinfodetl.SortExpression);
                    FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_replacementinfodetl, cmd, Database);
                    
                    IList<hr_replacementinfodetlEntity> itemList = new List<hr_replacementinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.GetAllhr_replacementinfodetl"));
            }	
        }
		
		IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlDataAccessObjects.GetAllByPages(hr_replacementinfodetlEntity hr_replacementinfodetl)
        {
        try
            {
				const string SP = "hr_replacementinfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_replacementinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_replacementinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_replacementinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_replacementinfodetl, cmd,Database);

                    IList<hr_replacementinfodetlEntity> itemList = new List<hr_replacementinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_replacementinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.GetAllByPageshr_replacementinfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_replacementinfodetlDataAccessObjects.SaveMasterDethr_reppassportinfodetl(hr_replacementinfodetlEntity masterEntity, 
        IList<hr_reppassportinfodetlEntity> listAdded, 
        IList<hr_reppassportinfodetlEntity> listUpdated,
        IList<hr_reppassportinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_replacementinfodetl_Ins";
            const string MasterSPUpdate = "hr_replacementinfodetl_Upd";
            const string MasterSPDelete = "hr_replacementinfodetl_Del";
            
			
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
                                item.replacementdetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_reppassportinfodetlDataAccessObjects objhr_reppassportinfodetl=new hr_reppassportinfodetlDataAccessObjects(this.Context);
                        objhr_reppassportinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.SaveDshr_replacementinfodetl"));
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
        hr_replacementinfodetlEntity Ihr_replacementinfodetlDataAccessObjects.GetSingle(hr_replacementinfodetlEntity hr_replacementinfodetl)
        {
           try
            {
				const string SP = "hr_replacementinfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_replacementinfodetl, cmd, Database);
                    
                    IList<hr_replacementinfodetlEntity> itemList = new List<hr_replacementinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.GetSinglehr_replacementinfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlDataAccessObjects.GAPgListView(hr_replacementinfodetlEntity hr_replacementinfodetl)
        {
        try
            {
				const string SP = "hr_replacementinfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_replacementinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_replacementinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_replacementinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_replacementinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_replacementinfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_replacementinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_replacementinfodetl.strCommonSerachParam);

                    IList<hr_replacementinfodetlEntity> itemList = new List<hr_replacementinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_replacementinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_replacementinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_replacementinfodetlDataAccess.GAPgListViewhr_replacementinfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}