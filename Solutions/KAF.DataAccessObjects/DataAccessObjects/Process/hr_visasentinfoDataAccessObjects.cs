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
	
	internal sealed partial class hr_visasentinfoDataAccessObjects : BaseDataAccess, Ihr_visasentinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_visasentinfoDataAccessObjects";
        
		public hr_visasentinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_visasentinfoEntity hr_visasentinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_visasentinfo.visasentid.HasValue)
				Database.AddInParameter(cmd, "@VisaSentID", DbType.Int64, hr_visasentinfo.visasentid);
            if (forDelete) return;
			if (hr_visasentinfo.visaissueid.HasValue)
				Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, hr_visasentinfo.visaissueid);
			if ((hr_visasentinfo.visasentdate.HasValue))
				Database.AddInParameter(cmd, "@VisaSentDate", DbType.DateTime, hr_visasentinfo.visasentdate);
			if ((hr_visasentinfo.visasentletterdate.HasValue))
				Database.AddInParameter(cmd, "@VisaSentLetterDate", DbType.DateTime, hr_visasentinfo.visasentletterdate);
			if (!(string.IsNullOrEmpty(hr_visasentinfo.visasentletterno)))
				Database.AddInParameter(cmd, "@VisaSentLetterNo", DbType.String, hr_visasentinfo.visasentletterno);
			if (!(string.IsNullOrEmpty(hr_visasentinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_visasentinfo.remarks);
			if ((hr_visasentinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_visasentinfo.ex_date1);
			if ((hr_visasentinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_visasentinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_visasentinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_visasentinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_visasentinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_visasentinfo.ex_nvarchar2);
			if (hr_visasentinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_visasentinfo.ex_bigint1);
			if (hr_visasentinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_visasentinfo.ex_bigint2);
			if (hr_visasentinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_visasentinfo.ex_decimal1);
			if (hr_visasentinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_visasentinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_visasentinfoDataAccessObjects.Add(hr_visasentinfoEntity hr_visasentinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_visasentinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_visasentinfo, cmd,Database);
                FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.Addhr_visasentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_visasentinfoDataAccessObjects.Update(hr_visasentinfoEntity hr_visasentinfo )
        {
           long returnCode = -99;
            const string SP = "hr_visasentinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_visasentinfo, cmd,Database);
                FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.Updatehr_visasentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_visasentinfoDataAccessObjects.Delete(hr_visasentinfoEntity hr_visasentinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_visasentinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_visasentinfo, cmd,Database, true);
                FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.Deletehr_visasentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_visasentinfoDataAccessObjects.SaveList(IList<hr_visasentinfoEntity> listAdded, IList<hr_visasentinfoEntity> listUpdated, IList<hr_visasentinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visasentinfo_Ins";
            const string SPUpdate = "hr_visasentinfo_Upd";
            const string SPDelete = "hr_visasentinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visasentinfoEntity hr_visasentinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visasentinfo, cmd, Database, true);
                            FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visasentinfoEntity hr_visasentinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visasentinfo, cmd, Database);
                            FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visasentinfoEntity hr_visasentinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visasentinfo, cmd, Database);
                            FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.Save_hr_visasentinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_visasentinfoEntity> listAdded, IList<hr_visasentinfoEntity> listUpdated, IList<hr_visasentinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visasentinfo_Ins";
            const string SPUpdate = "hr_visasentinfo_Upd";
            const string SPDelete = "hr_visasentinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visasentinfoEntity hr_visasentinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visasentinfo, cmd, db, true);
                            FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visasentinfoEntity hr_visasentinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visasentinfo, cmd, db);
                            FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visasentinfoEntity hr_visasentinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visasentinfo, cmd, db);
                            FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.Save_hr_visasentinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_visasentinfoEntity> Ihr_visasentinfoDataAccessObjects.GetAll(hr_visasentinfoEntity hr_visasentinfo)
        {
           try
            {
				const string SP = "hr_visasentinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_visasentinfo.SortExpression);
                    FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visasentinfo, cmd, Database);
                    
                    IList<hr_visasentinfoEntity> itemList = new List<hr_visasentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.GetAllhr_visasentinfo"));
            }	
        }
		
		IList<hr_visasentinfoEntity> Ihr_visasentinfoDataAccessObjects.GetAllByPages(hr_visasentinfoEntity hr_visasentinfo)
        {
        try
            {
				const string SP = "hr_visasentinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visasentinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_visasentinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_visasentinfo.CurrentPage);                    
                    FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visasentinfo, cmd,Database);

                    IList<hr_visasentinfoEntity> itemList = new List<hr_visasentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visasentinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.GetAllByPageshr_visasentinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_visasentinfoDataAccessObjects.SaveMasterDethr_ptademand(hr_visasentinfoEntity masterEntity, 
        IList<hr_ptademandEntity> listAdded, 
        IList<hr_ptademandEntity> listUpdated,
        IList<hr_ptademandEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visasentinfo_Ins";
            const string MasterSPUpdate = "hr_visasentinfo_Upd";
            const string MasterSPDelete = "hr_visasentinfo_Del";
            
			
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
                                item.visasentid=PrimaryKeyMaster;
                            }
                        }
                        hr_ptademandDataAccessObjects objhr_ptademand=new hr_ptademandDataAccessObjects(this.Context);
                        objhr_ptademand.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.SaveDshr_visasentinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_visasentinfoDataAccessObjects.SaveMasterDethr_visasentinfodetl(hr_visasentinfoEntity masterEntity, 
        IList<hr_visasentinfodetlEntity> listAdded, 
        IList<hr_visasentinfodetlEntity> listUpdated,
        IList<hr_visasentinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visasentinfo_Ins";
            const string MasterSPUpdate = "hr_visasentinfo_Upd";
            const string MasterSPDelete = "hr_visasentinfo_Del";
            
			
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
                                item.visasentid=PrimaryKeyMaster;
                            }
                        }
                        hr_visasentinfodetlDataAccessObjects objhr_visasentinfodetl=new hr_visasentinfodetlDataAccessObjects(this.Context);
                        objhr_visasentinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            //LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.VisaSent),
                        }

                        );
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.SaveDshr_visasentinfo"));
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
        hr_visasentinfoEntity Ihr_visasentinfoDataAccessObjects.GetSingle(hr_visasentinfoEntity hr_visasentinfo)
        {
           try
            {
				const string SP = "hr_visasentinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visasentinfo, cmd, Database);
                    
                    IList<hr_visasentinfoEntity> itemList = new List<hr_visasentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.GetSinglehr_visasentinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_visasentinfoEntity> Ihr_visasentinfoDataAccessObjects.GAPgListView(hr_visasentinfoEntity hr_visasentinfo)
        {
        try
            {
				const string SP = "hr_visasentinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visasentinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_visasentinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_visasentinfo.CurrentPage);                    
                    FillSequrityParameters(hr_visasentinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visasentinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_visasentinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_visasentinfo.strCommonSerachParam);

                    IList<hr_visasentinfoEntity> itemList = new List<hr_visasentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visasentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visasentinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visasentinfoDataAccess.GAPgListViewhr_visasentinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}