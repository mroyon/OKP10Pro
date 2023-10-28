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
	
	internal sealed partial class hr_leaveinfoDataAccessObjects : BaseDataAccess, Ihr_leaveinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_leaveinfoDataAccessObjects";
        
		public hr_leaveinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_leaveinfoEntity hr_leaveinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_leaveinfo.leaveinfoid.HasValue)
				Database.AddInParameter(cmd, "@LeaveInfoID", DbType.Int64, hr_leaveinfo.leaveinfoid);
            if (forDelete) return;
			if (hr_leaveinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_leaveinfo.hrbasicid);
			if (hr_leaveinfo.leavetypeid.HasValue)
				Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, hr_leaveinfo.leavetypeid);
			if ((hr_leaveinfo.startdate.HasValue))
				Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, hr_leaveinfo.startdate);
			if ((hr_leaveinfo.enddate.HasValue))
				Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, hr_leaveinfo.enddate);
			if (hr_leaveinfo.noofdays.HasValue)
				Database.AddInParameter(cmd, "@NoOfDays", DbType.Int64, hr_leaveinfo.noofdays);
			if ((hr_leaveinfo.leavestartdate.HasValue))
				Database.AddInParameter(cmd, "@LeaveStartDate", DbType.DateTime, hr_leaveinfo.leavestartdate);
			if ((hr_leaveinfo.leaveenddate.HasValue))
				Database.AddInParameter(cmd, "@LeaveEndDate", DbType.DateTime, hr_leaveinfo.leaveenddate);
			if ((hr_leaveinfo.leavedays.HasValue))
				Database.AddInParameter(cmd, "@LeaveDays", DbType.Int64, hr_leaveinfo.leavedays);
			if (!(string.IsNullOrEmpty(hr_leaveinfo.letterno)))
				Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_leaveinfo.letterno);
			if ((hr_leaveinfo.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_leaveinfo.letterdate);
			if ((hr_leaveinfo.withgovtticket != null))
				Database.AddInParameter(cmd, "@WithGovtTicket", DbType.Boolean, hr_leaveinfo.withgovtticket);
			if ((hr_leaveinfo.iscancel != null))
				Database.AddInParameter(cmd, "@IsCancel", DbType.Boolean, hr_leaveinfo.iscancel);
			if ((hr_leaveinfo.ismodified != null))
				Database.AddInParameter(cmd, "@IsModified", DbType.Boolean, hr_leaveinfo.ismodified);
			if ((hr_leaveinfo.isreturn != null))
				Database.AddInParameter(cmd, "@IsReturn", DbType.Boolean, hr_leaveinfo.isreturn);
			if ((hr_leaveinfo.returndate.HasValue))
				Database.AddInParameter(cmd, "@ReturnDate", DbType.DateTime, hr_leaveinfo.returndate);
			if (!(string.IsNullOrEmpty(hr_leaveinfo.returnletterno)))
				Database.AddInParameter(cmd, "@ReturnLetterNo", DbType.String, hr_leaveinfo.returnletterno);
			if ((hr_leaveinfo.returnletterdate.HasValue))
				Database.AddInParameter(cmd, "@ReturnLetterDate", DbType.DateTime, hr_leaveinfo.returnletterdate);
			if (!(string.IsNullOrEmpty(hr_leaveinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_leaveinfo.remarks);
			if ((hr_leaveinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_leaveinfo.ex_date1);
			if ((hr_leaveinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_leaveinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_leaveinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_leaveinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_leaveinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_leaveinfo.ex_nvarchar2);
			if (hr_leaveinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_leaveinfo.ex_bigint1);
			if (hr_leaveinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_leaveinfo.ex_bigint2);
			if (hr_leaveinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_leaveinfo.ex_decimal1);
			if (hr_leaveinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_leaveinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_leaveinfoDataAccessObjects.Add(hr_leaveinfoEntity hr_leaveinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_leaveinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_leaveinfo, cmd,Database);
                FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.Addhr_leaveinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_leaveinfoDataAccessObjects.Update(hr_leaveinfoEntity hr_leaveinfo )
        {
           long returnCode = -99;
            const string SP = "hr_leaveinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_leaveinfo, cmd,Database);
                FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.Updatehr_leaveinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_leaveinfoDataAccessObjects.Delete(hr_leaveinfoEntity hr_leaveinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_leaveinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_leaveinfo, cmd,Database, true);
                FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.Deletehr_leaveinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_leaveinfoDataAccessObjects.SaveList(IList<hr_leaveinfoEntity> listAdded, IList<hr_leaveinfoEntity> listUpdated, IList<hr_leaveinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_leaveinfo_Ins";
            const string SPUpdate = "hr_leaveinfo_Upd";
            const string SPDelete = "hr_leaveinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_leaveinfoEntity hr_leaveinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_leaveinfo, cmd, Database, true);
                            FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_leaveinfoEntity hr_leaveinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_leaveinfo, cmd, Database);
                            FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_leaveinfoEntity hr_leaveinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_leaveinfo, cmd, Database);
                            FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.Save_hr_leaveinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_leaveinfoEntity> listAdded, IList<hr_leaveinfoEntity> listUpdated, IList<hr_leaveinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_leaveinfo_Ins";
            const string SPUpdate = "hr_leaveinfo_Upd";
            const string SPDelete = "hr_leaveinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_leaveinfoEntity hr_leaveinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_leaveinfo, cmd, db, true);
                            FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_leaveinfoEntity hr_leaveinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_leaveinfo, cmd, db);
                            FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_leaveinfoEntity hr_leaveinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_leaveinfo, cmd, db);
                            FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.Save_hr_leaveinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_leaveinfoEntity> Ihr_leaveinfoDataAccessObjects.GetAll(hr_leaveinfoEntity hr_leaveinfo)
        {
           try
            {
				const string SP = "hr_leaveinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_leaveinfo.SortExpression);
                    FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_leaveinfo, cmd, Database);
                    
                    IList<hr_leaveinfoEntity> itemList = new List<hr_leaveinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leaveinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.GetAllhr_leaveinfo"));
            }	
        }
		
		IList<hr_leaveinfoEntity> Ihr_leaveinfoDataAccessObjects.GetAllByPages(hr_leaveinfoEntity hr_leaveinfo)
        {
        try
            {
				const string SP = "hr_leaveinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_leaveinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_leaveinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_leaveinfo.CurrentPage);                    
                    FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_leaveinfo, cmd,Database);

                    IList<hr_leaveinfoEntity> itemList = new List<hr_leaveinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leaveinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_leaveinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.GetAllByPageshr_leaveinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_leaveinfoDataAccessObjects.SaveMasterDethr_leavemodification(hr_leaveinfoEntity masterEntity, 
        IList<hr_leavemodificationEntity> listAdded, 
        IList<hr_leavemodificationEntity> listUpdated,
        IList<hr_leavemodificationEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_leaveinfo_Ins";
            const string MasterSPUpdate = "hr_leaveinfo_Upd";
            const string MasterSPDelete = "hr_leaveinfo_Del";
            
			
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
                                item.leaveinfoid=PrimaryKeyMaster;
                            }
                        }
                        hr_leavemodificationDataAccessObjects objhr_leavemodification=new hr_leavemodificationDataAccessObjects(this.Context);
                        objhr_leavemodification.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.SaveDshr_leaveinfo"));
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
        hr_leaveinfoEntity Ihr_leaveinfoDataAccessObjects.GetSingle(hr_leaveinfoEntity hr_leaveinfo)
        {
           try
            {
				const string SP = "hr_leaveinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_leaveinfo, cmd, Database);
                    
                    IList<hr_leaveinfoEntity> itemList = new List<hr_leaveinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leaveinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.GetSinglehr_leaveinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_leaveinfoEntity> Ihr_leaveinfoDataAccessObjects.GAPgListView(hr_leaveinfoEntity hr_leaveinfo)
        {
        try
            {
				 string SP = "hr_leaveinfo_GAPgListView";

                if(hr_leaveinfo.isExt==1)
                {
                    SP = "hr_leaveinfo_GAPgListView_Ext";
                }
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_leaveinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_leaveinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_leaveinfo.CurrentPage);                    
                    FillSequrityParameters(hr_leaveinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_leaveinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_leaveinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_leaveinfo.strCommonSerachParam);

                    IList<hr_leaveinfoEntity> itemList = new List<hr_leaveinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leaveinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_leaveinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_leaveinfoDataAccess.GAPgListViewhr_leaveinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}