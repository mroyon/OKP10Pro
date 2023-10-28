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
	
	internal sealed partial class hr_visaissueinfoDataAccessObjects : BaseDataAccess, Ihr_visaissueinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_visaissueinfoDataAccessObjects";
        
		public hr_visaissueinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_visaissueinfoEntity hr_visaissueinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_visaissueinfo.visaissueid.HasValue)
				Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, hr_visaissueinfo.visaissueid);
            if (forDelete) return;
			if (hr_visaissueinfo.visademandid.HasValue)
				Database.AddInParameter(cmd, "@VisaDemandID", DbType.Int64, hr_visaissueinfo.visademandid);
			if ((hr_visaissueinfo.visaissuedate.HasValue))
				Database.AddInParameter(cmd, "@VisaIssueDate", DbType.DateTime, hr_visaissueinfo.visaissuedate);
			if ((hr_visaissueinfo.visaissueletterdate.HasValue))
				Database.AddInParameter(cmd, "@VisaIssueLetterDate", DbType.DateTime, hr_visaissueinfo.visaissueletterdate);
			if (!(string.IsNullOrEmpty(hr_visaissueinfo.visaissueletterno)))
				Database.AddInParameter(cmd, "@VisaIssueLetterNo", DbType.String, hr_visaissueinfo.visaissueletterno);
			if (!(string.IsNullOrEmpty(hr_visaissueinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_visaissueinfo.remarks);
			if ((hr_visaissueinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_visaissueinfo.ex_date1);
			if ((hr_visaissueinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_visaissueinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_visaissueinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_visaissueinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_visaissueinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_visaissueinfo.ex_nvarchar2);
			if (hr_visaissueinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_visaissueinfo.ex_bigint1);
			if (hr_visaissueinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_visaissueinfo.ex_bigint2);
			if (hr_visaissueinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_visaissueinfo.ex_decimal1);
			if (hr_visaissueinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_visaissueinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_visaissueinfoDataAccessObjects.Add(hr_visaissueinfoEntity hr_visaissueinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_visaissueinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_visaissueinfo, cmd,Database);
                FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.Addhr_visaissueinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_visaissueinfoDataAccessObjects.Update(hr_visaissueinfoEntity hr_visaissueinfo )
        {
           long returnCode = -99;
            const string SP = "hr_visaissueinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_visaissueinfo, cmd,Database);
                FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.Updatehr_visaissueinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_visaissueinfoDataAccessObjects.Delete(hr_visaissueinfoEntity hr_visaissueinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_visaissueinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_visaissueinfo, cmd,Database, true);
                FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.Deletehr_visaissueinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_visaissueinfoDataAccessObjects.SaveList(IList<hr_visaissueinfoEntity> listAdded, IList<hr_visaissueinfoEntity> listUpdated, IList<hr_visaissueinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visaissueinfo_Ins";
            const string SPUpdate = "hr_visaissueinfo_Upd";
            const string SPDelete = "hr_visaissueinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visaissueinfoEntity hr_visaissueinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visaissueinfo, cmd, Database, true);
                            FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visaissueinfoEntity hr_visaissueinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visaissueinfo, cmd, Database);
                            FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visaissueinfoEntity hr_visaissueinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visaissueinfo, cmd, Database);
                            FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.Save_hr_visaissueinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_visaissueinfoEntity> listAdded, IList<hr_visaissueinfoEntity> listUpdated, IList<hr_visaissueinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visaissueinfo_Ins";
            const string SPUpdate = "hr_visaissueinfo_Upd";
            const string SPDelete = "hr_visaissueinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visaissueinfoEntity hr_visaissueinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visaissueinfo, cmd, db, true);
                            FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visaissueinfoEntity hr_visaissueinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visaissueinfo, cmd, db);
                            FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visaissueinfoEntity hr_visaissueinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visaissueinfo, cmd, db);
                            FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.Save_hr_visaissueinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_visaissueinfoEntity> Ihr_visaissueinfoDataAccessObjects.GetAll(hr_visaissueinfoEntity hr_visaissueinfo)
        {
           try
            {
				const string SP = "hr_visaissueinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_visaissueinfo.SortExpression);
                    FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visaissueinfo, cmd, Database);
                    
                    IList<hr_visaissueinfoEntity> itemList = new List<hr_visaissueinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.GetAllhr_visaissueinfo"));
            }	
        }
		
		IList<hr_visaissueinfoEntity> Ihr_visaissueinfoDataAccessObjects.GetAllByPages(hr_visaissueinfoEntity hr_visaissueinfo)
        {
        try
            {
				const string SP = "hr_visaissueinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visaissueinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_visaissueinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_visaissueinfo.CurrentPage);                    
                    FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visaissueinfo, cmd,Database);

                    IList<hr_visaissueinfoEntity> itemList = new List<hr_visaissueinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visaissueinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.GetAllByPageshr_visaissueinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_visaissueinfoDataAccessObjects.SaveMasterDethr_visaissueinfodetl(hr_visaissueinfoEntity masterEntity, 
        IList<hr_visaissueinfodetlEntity> listAdded, 
        IList<hr_visaissueinfodetlEntity> listUpdated,
        IList<hr_visaissueinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visaissueinfo_Ins";
            const string MasterSPUpdate = "hr_visaissueinfo_Upd";
            const string MasterSPDelete = "hr_visaissueinfo_Del";
            
			
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
                                item.visaissueid=PrimaryKeyMaster;
                            }
                        }
                        hr_visaissueinfodetlDataAccessObjects objhr_visaissueinfodetl=new hr_visaissueinfodetlDataAccessObjects(this.Context);
                        objhr_visaissueinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            //LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.VisaIssued),
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.SaveDshr_visaissueinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_visaissueinfoDataAccessObjects.SaveMasterDethr_visasentinfo(hr_visaissueinfoEntity masterEntity, 
        IList<hr_visasentinfoEntity> listAdded, 
        IList<hr_visasentinfoEntity> listUpdated,
        IList<hr_visasentinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visaissueinfo_Ins";
            const string MasterSPUpdate = "hr_visaissueinfo_Upd";
            const string MasterSPDelete = "hr_visaissueinfo_Del";
            
			
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
                                item.visaissueid=PrimaryKeyMaster;
                            }
                        }
                        hr_visasentinfoDataAccessObjects objhr_visasentinfo=new hr_visasentinfoDataAccessObjects(this.Context);
                        objhr_visasentinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.SaveDshr_visaissueinfo"));
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
        hr_visaissueinfoEntity Ihr_visaissueinfoDataAccessObjects.GetSingle(hr_visaissueinfoEntity hr_visaissueinfo)
        {
           try
            {
				const string SP = "hr_visaissueinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visaissueinfo, cmd, Database);
                    
                    IList<hr_visaissueinfoEntity> itemList = new List<hr_visaissueinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.GetSinglehr_visaissueinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_visaissueinfoEntity> Ihr_visaissueinfoDataAccessObjects.GAPgListView(hr_visaissueinfoEntity hr_visaissueinfo)
        {
        try
            {
				const string SP = "hr_visaissueinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visaissueinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_visaissueinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_visaissueinfo.CurrentPage);                    
                    FillSequrityParameters(hr_visaissueinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visaissueinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_visaissueinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_visaissueinfo.strCommonSerachParam);

                    IList<hr_visaissueinfoEntity> itemList = new List<hr_visaissueinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visaissueinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visaissueinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visaissueinfoDataAccess.GAPgListViewhr_visaissueinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}