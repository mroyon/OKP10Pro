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
	
	internal sealed partial class hr_leavemodificationDataAccessObjects : BaseDataAccess, Ihr_leavemodificationDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_leavemodificationDataAccessObjects";
        
		public hr_leavemodificationDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_leavemodificationEntity hr_leavemodification, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_leavemodification.leavemodificationid.HasValue)
				Database.AddInParameter(cmd, "@LeaveModificationID", DbType.Int64, hr_leavemodification.leavemodificationid);
            if (forDelete) return;
			if (hr_leavemodification.leaveinfoid.HasValue)
				Database.AddInParameter(cmd, "@LeaveInfoID", DbType.Int64, hr_leavemodification.leaveinfoid);
			if (hr_leavemodification.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_leavemodification.hrbasicid);
			if (hr_leavemodification.leavetypeid.HasValue)
				Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, hr_leavemodification.leavetypeid);
			if ((hr_leavemodification.modificationdate.HasValue))
				Database.AddInParameter(cmd, "@ModificationDate", DbType.DateTime, hr_leavemodification.modificationdate);
			if ((hr_leavemodification.startdate.HasValue))
				Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, hr_leavemodification.startdate);
			if ((hr_leavemodification.enddate.HasValue))
				Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, hr_leavemodification.enddate);
			if (hr_leavemodification.noofdays.HasValue)
				Database.AddInParameter(cmd, "@NoOfDays", DbType.Int64, hr_leavemodification.noofdays);
			if ((hr_leavemodification.leavestartdate.HasValue))
				Database.AddInParameter(cmd, "@LeaveStartDate", DbType.DateTime, hr_leavemodification.leavestartdate);
			if ((hr_leavemodification.leaveenddate.HasValue))
				Database.AddInParameter(cmd, "@LeaveEndDate", DbType.DateTime, hr_leavemodification.leaveenddate);
			if ((hr_leavemodification.leavedays.HasValue))
				Database.AddInParameter(cmd, "@LeaveDays", DbType.Int64, hr_leavemodification.leavedays);
			if (!(string.IsNullOrEmpty(hr_leavemodification.letterno)))
				Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_leavemodification.letterno);
			if ((hr_leavemodification.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_leavemodification.letterdate);
			if ((hr_leavemodification.withgovtticket != null))
				Database.AddInParameter(cmd, "@WithGovtTicket", DbType.Boolean, hr_leavemodification.withgovtticket);
			if (hr_leavemodification.modificationtype.HasValue)
				Database.AddInParameter(cmd, "@ModificationType", DbType.Int64, hr_leavemodification.modificationtype);
			if (!(string.IsNullOrEmpty(hr_leavemodification.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_leavemodification.remarks);
			if ((hr_leavemodification.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_leavemodification.ex_date1);
			if ((hr_leavemodification.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_leavemodification.ex_date2);
			if (!(string.IsNullOrEmpty(hr_leavemodification.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_leavemodification.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_leavemodification.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_leavemodification.ex_nvarchar2);
			if (hr_leavemodification.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_leavemodification.ex_bigint1);
			if (hr_leavemodification.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_leavemodification.ex_bigint2);
			if (hr_leavemodification.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_leavemodification.ex_decimal1);
			if (hr_leavemodification.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_leavemodification.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_leavemodificationDataAccessObjects.Add(hr_leavemodificationEntity hr_leavemodification  )
        {
            long returnCode = -99;
             string SP = "hr_leavemodification_Ins";

            if(hr_leavemodification.isExt==1)
            {
                SP = "hr_leavemodification_Ins_Ext";
            }
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_leavemodification, cmd,Database);
                FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.Addhr_leavemodification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_leavemodificationDataAccessObjects.Update(hr_leavemodificationEntity hr_leavemodification )
        {
           long returnCode = -99;
             string SP = "hr_leavemodification_Upd";

            if(hr_leavemodification.isExt==1)
            {
                SP = "hr_leavemodification_Upd_Ext";
            }
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_leavemodification, cmd,Database);
                FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.Updatehr_leavemodification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_leavemodificationDataAccessObjects.Delete(hr_leavemodificationEntity hr_leavemodification)
        {
            long returnCode = -99;
           	const string SP = "hr_leavemodification_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_leavemodification, cmd,Database, true);
                FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.Deletehr_leavemodification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_leavemodificationDataAccessObjects.SaveList(IList<hr_leavemodificationEntity> listAdded, IList<hr_leavemodificationEntity> listUpdated, IList<hr_leavemodificationEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_leavemodification_Ins";
            const string SPUpdate = "hr_leavemodification_Upd";
            const string SPDelete = "hr_leavemodification_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_leavemodificationEntity hr_leavemodification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_leavemodification, cmd, Database, true);
                            FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_leavemodificationEntity hr_leavemodification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_leavemodification, cmd, Database);
                            FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_leavemodificationEntity hr_leavemodification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_leavemodification, cmd, Database);
                            FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.Save_hr_leavemodification"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_leavemodificationEntity> listAdded, IList<hr_leavemodificationEntity> listUpdated, IList<hr_leavemodificationEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_leavemodification_Ins";
            const string SPUpdate = "hr_leavemodification_Upd";
            const string SPDelete = "hr_leavemodification_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_leavemodificationEntity hr_leavemodification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_leavemodification, cmd, db, true);
                            FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, db);
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
                    foreach (hr_leavemodificationEntity hr_leavemodification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_leavemodification, cmd, db);
                            FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, db);
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
                    foreach (hr_leavemodificationEntity hr_leavemodification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_leavemodification, cmd, db);
                            FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.Save_hr_leavemodification"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_leavemodificationEntity> Ihr_leavemodificationDataAccessObjects.GetAll(hr_leavemodificationEntity hr_leavemodification)
        {
           try
            {
				const string SP = "hr_leavemodification_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_leavemodification.SortExpression);
                    FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_leavemodification, cmd, Database);
                    
                    IList<hr_leavemodificationEntity> itemList = new List<hr_leavemodificationEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leavemodificationEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.GetAllhr_leavemodification"));
            }	
        }
		
		IList<hr_leavemodificationEntity> Ihr_leavemodificationDataAccessObjects.GetAllByPages(hr_leavemodificationEntity hr_leavemodification)
        {
        try
            {
				const string SP = "hr_leavemodification_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_leavemodification.SortExpression);
                    AddPageSizeParameter(cmd, hr_leavemodification.PageSize);
                    AddCurrentPageParameter(cmd, hr_leavemodification.CurrentPage);                    
                    FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_leavemodification, cmd,Database);

                    IList<hr_leavemodificationEntity> itemList = new List<hr_leavemodificationEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leavemodificationEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_leavemodification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.GetAllByPageshr_leavemodification"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_leavemodificationEntity Ihr_leavemodificationDataAccessObjects.GetSingle(hr_leavemodificationEntity hr_leavemodification)
        {
           try
            {
				const string SP = "hr_leavemodification_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_leavemodification, cmd, Database);
                    
                    IList<hr_leavemodificationEntity> itemList = new List<hr_leavemodificationEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leavemodificationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.GetSinglehr_leavemodification"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_leavemodificationEntity> Ihr_leavemodificationDataAccessObjects.GAPgListView(hr_leavemodificationEntity hr_leavemodification)
        {
        try
            {
				const string SP = "hr_leavemodification_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_leavemodification.SortExpression);
                    AddPageSizeParameter(cmd, hr_leavemodification.PageSize);
                    AddCurrentPageParameter(cmd, hr_leavemodification.CurrentPage);                    
                    FillSequrityParameters(hr_leavemodification.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_leavemodification, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_leavemodification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_leavemodification.strCommonSerachParam);

                    IList<hr_leavemodificationEntity> itemList = new List<hr_leavemodificationEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_leavemodificationEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_leavemodification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_leavemodificationDataAccess.GAPgListViewhr_leavemodification"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}