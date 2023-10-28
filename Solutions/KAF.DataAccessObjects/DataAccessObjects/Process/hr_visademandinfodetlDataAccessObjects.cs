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
	
	internal sealed partial class hr_visademandinfodetlDataAccessObjects : BaseDataAccess, Ihr_visademandinfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_visademandinfodetlDataAccessObjects";
        
		public hr_visademandinfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_visademandinfodetlEntity hr_visademandinfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_visademandinfodetl.visademanddetlid.HasValue)
				Database.AddInParameter(cmd, "@VisaDemandDetlID", DbType.Int64, hr_visademandinfodetl.visademanddetlid);
            if (forDelete) return;
			if (hr_visademandinfodetl.visademandid.HasValue)
				Database.AddInParameter(cmd, "@VisaDemandID", DbType.Int64, hr_visademandinfodetl.visademandid);
			if (hr_visademandinfodetl.demandtype.HasValue)
				Database.AddInParameter(cmd, "@DemandType", DbType.Int64, hr_visademandinfodetl.demandtype);
			if (hr_visademandinfodetl.passportdetlid.HasValue)
				Database.AddInParameter(cmd, "@PassportDetlID", DbType.Int64, hr_visademandinfodetl.passportdetlid);
			if (hr_visademandinfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_visademandinfodetl.hrbasicid);
			if (hr_visademandinfodetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_visademandinfodetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_visademandinfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_visademandinfodetl.remarks);
			if ((hr_visademandinfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_visademandinfodetl.ex_date1);
			if ((hr_visademandinfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_visademandinfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_visademandinfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_visademandinfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_visademandinfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_visademandinfodetl.ex_nvarchar2);
			if (hr_visademandinfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_visademandinfodetl.ex_bigint1);
			if (hr_visademandinfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_visademandinfodetl.ex_bigint2);
			if (hr_visademandinfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_visademandinfodetl.ex_decimal1);
			if (hr_visademandinfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_visademandinfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_visademandinfodetlDataAccessObjects.Add(hr_visademandinfodetlEntity hr_visademandinfodetl  )
        {
            long returnCode = -99;
            const string SP = "hr_visademandinfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_visademandinfodetl, cmd,Database);
                FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.Addhr_visademandinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_visademandinfodetlDataAccessObjects.Update(hr_visademandinfodetlEntity hr_visademandinfodetl )
        {
           long returnCode = -99;
            const string SP = "hr_visademandinfodetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_visademandinfodetl, cmd,Database);
                FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.Updatehr_visademandinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_visademandinfodetlDataAccessObjects.Delete(hr_visademandinfodetlEntity hr_visademandinfodetl)
        {
            long returnCode = -99;
           	const string SP = "hr_visademandinfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_visademandinfodetl, cmd,Database, true);
                FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.Deletehr_visademandinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_visademandinfodetlDataAccessObjects.SaveList(IList<hr_visademandinfodetlEntity> listAdded, IList<hr_visademandinfodetlEntity> listUpdated, IList<hr_visademandinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visademandinfodetl_Ins";
            const string SPUpdate = "hr_visademandinfodetl_Upd";
            const string SPDelete = "hr_visademandinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visademandinfodetlEntity hr_visademandinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visademandinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visademandinfodetlEntity hr_visademandinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visademandinfodetl, cmd, Database);
                            FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visademandinfodetlEntity hr_visademandinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visademandinfodetl, cmd, Database);
                            FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.Save_hr_visademandinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_visademandinfodetlEntity> listAdded, IList<hr_visademandinfodetlEntity> listUpdated, IList<hr_visademandinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visademandinfodetl_Ins";
            const string SPUpdate = "hr_visademandinfodetl_Upd";
            const string SPDelete = "hr_visademandinfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visademandinfodetlEntity hr_visademandinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visademandinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visademandinfodetlEntity hr_visademandinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visademandinfodetl, cmd, db);
                            FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visademandinfodetlEntity hr_visademandinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visademandinfodetl, cmd, db);
                            FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.Save_hr_visademandinfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlDataAccessObjects.GetAll(hr_visademandinfodetlEntity hr_visademandinfodetl)
        {
           try
            {
				const string SP = "hr_visademandinfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_visademandinfodetl.SortExpression);
                    FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visademandinfodetl, cmd, Database);
                    
                    IList<hr_visademandinfodetlEntity> itemList = new List<hr_visademandinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.GetAllhr_visademandinfodetl"));
            }	
        }
		
		IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlDataAccessObjects.GetAllByPages(hr_visademandinfodetlEntity hr_visademandinfodetl)
        {
        try
            {
				const string SP = "hr_visademandinfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visademandinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_visademandinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_visademandinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visademandinfodetl, cmd,Database);

                    IList<hr_visademandinfodetlEntity> itemList = new List<hr_visademandinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visademandinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.GetAllByPageshr_visademandinfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_visademandinfodetlDataAccessObjects.SaveMasterDethr_visaissueinfodetl(hr_visademandinfodetlEntity masterEntity, 
        IList<hr_visaissueinfodetlEntity> listAdded, 
        IList<hr_visaissueinfodetlEntity> listUpdated,
        IList<hr_visaissueinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visademandinfodetl_Ins";
            const string MasterSPUpdate = "hr_visademandinfodetl_Upd";
            const string MasterSPDelete = "hr_visademandinfodetl_Del";
            
			
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
                                item.visademanddetlid=PrimaryKeyMaster;
                            }
                        }
                        hr_visaissueinfodetlDataAccessObjects objhr_visaissueinfodetl=new hr_visaissueinfodetlDataAccessObjects(this.Context);
                        objhr_visaissueinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.SaveDshr_visademandinfodetl"));
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
        hr_visademandinfodetlEntity Ihr_visademandinfodetlDataAccessObjects.GetSingle(hr_visademandinfodetlEntity hr_visademandinfodetl)
        {
           try
            {
				const string SP = "hr_visademandinfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visademandinfodetl, cmd, Database);
                    
                    IList<hr_visademandinfodetlEntity> itemList = new List<hr_visademandinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.GetSinglehr_visademandinfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlDataAccessObjects.GAPgListView(hr_visademandinfodetlEntity hr_visademandinfodetl)
        {
        try
            {
				const string SP = "hr_visademandinfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visademandinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_visademandinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_visademandinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_visademandinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visademandinfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_visademandinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_visademandinfodetl.strCommonSerachParam);

                    IList<hr_visademandinfodetlEntity> itemList = new List<hr_visademandinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visademandinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfodetlDataAccess.GAPgListViewhr_visademandinfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}