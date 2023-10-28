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
	
	internal sealed partial class hr_passportinfoDataAccessObjects : BaseDataAccess, Ihr_passportinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_passportinfoDataAccessObjects";
        
		public hr_passportinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_passportinfoEntity hr_passportinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_passportinfo.passportid.HasValue)
				Database.AddInParameter(cmd, "@PassportID", DbType.Int64, hr_passportinfo.passportid);
            if (forDelete) return;
			if (hr_passportinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_passportinfo.hrbasicid);
			if (!(string.IsNullOrEmpty(hr_passportinfo.passportno)))
				Database.AddInParameter(cmd, "@PassportNo", DbType.String, hr_passportinfo.passportno);
			if ((hr_passportinfo.passportissuedate.HasValue))
				Database.AddInParameter(cmd, "@PassportIssueDate", DbType.DateTime, hr_passportinfo.passportissuedate);
			if ((hr_passportinfo.passportexpirydate.HasValue))
				Database.AddInParameter(cmd, "@PassportExpiryDate", DbType.DateTime, hr_passportinfo.passportexpirydate);
			if (hr_passportinfo.passportissuecountryid.HasValue)
				Database.AddInParameter(cmd, "@PassportIssueCountryID", DbType.Int64, hr_passportinfo.passportissuecountryid);
			if ((hr_passportinfo.isfamilypassport != null))
				Database.AddInParameter(cmd, "@IsFamilyPassport", DbType.Boolean, hr_passportinfo.isfamilypassport);
			if (!(string.IsNullOrEmpty(hr_passportinfo.passportfiledescription)))
				Database.AddInParameter(cmd, "@PassportFileDescription", DbType.String, hr_passportinfo.passportfiledescription);
			if (!(string.IsNullOrEmpty(hr_passportinfo.passportfilepath)))
				Database.AddInParameter(cmd, "@PassportFilePath", DbType.String, hr_passportinfo.passportfilepath);
			if (!(string.IsNullOrEmpty(hr_passportinfo.passportfilename)))
				Database.AddInParameter(cmd, "@PassportFileName", DbType.String, hr_passportinfo.passportfilename);
			if (!(string.IsNullOrEmpty(hr_passportinfo.passportfiletype)))
				Database.AddInParameter(cmd, "@PassportFileType", DbType.String, hr_passportinfo.passportfiletype);
			if (!(string.IsNullOrEmpty(hr_passportinfo.passportextension)))
				Database.AddInParameter(cmd, "@PassportExtension", DbType.String, hr_passportinfo.passportextension);
            if ((hr_passportinfo.passportfileid.HasValue))
                Database.AddInParameter(cmd, "@PassportFileID", DbType.Guid, hr_passportinfo.passportfileid);
			if (!(string.IsNullOrEmpty(hr_passportinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_passportinfo.remarks);
			if (hr_passportinfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_passportinfo.forreview);
			if ((hr_passportinfo.iscurrent != null))
				Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hr_passportinfo.iscurrent);
			if ((hr_passportinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_passportinfo.ex_date1);
			if ((hr_passportinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_passportinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_passportinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_passportinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_passportinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_passportinfo.ex_nvarchar2);
			if (hr_passportinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_passportinfo.ex_bigint1);
			if (hr_passportinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_passportinfo.ex_bigint2);
			if (hr_passportinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_passportinfo.ex_decimal1);
			if (hr_passportinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_passportinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_passportinfoDataAccessObjects.Add(hr_passportinfoEntity hr_passportinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_passportinfo_InsExt";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_passportinfo, cmd,Database);
                FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Addhr_passportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_passportinfoDataAccessObjects.Update(hr_passportinfoEntity hr_passportinfo )
        {
           long returnCode = -99;
            const string SP = "hr_passportinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_passportinfo, cmd,Database);
                FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Updatehr_passportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_passportinfoDataAccessObjects.Delete(hr_passportinfoEntity hr_passportinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_passportinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_passportinfo, cmd,Database, true);
                FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Deletehr_passportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_passportinfoDataAccessObjects.SaveList(IList<hr_passportinfoEntity> listAdded, IList<hr_passportinfoEntity> listUpdated, IList<hr_passportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_passportinfo_Ins";
            const string SPUpdate = "hr_passportinfo_Upd";
            const string SPDelete = "hr_passportinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_passportinfoEntity hr_passportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_passportinfo, cmd, Database, true);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_passportinfoEntity hr_passportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_passportinfo, cmd, Database);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_passportinfoEntity hr_passportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_passportinfo, cmd, Database);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Save_hr_passportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_passportinfoEntity> listAdded, IList<hr_passportinfoEntity> listUpdated, IList<hr_passportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_passportinfo_Ins";
            const string SPUpdate = "hr_passportinfo_Upd";
            const string SPDelete = "hr_passportinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_passportinfoEntity hr_passportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_passportinfo, cmd, db, true);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_passportinfoEntity hr_passportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_passportinfo, cmd, db);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_passportinfoEntity hr_passportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_passportinfo, cmd, db);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Save_hr_passportinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_passportinfoEntity> Ihr_passportinfoDataAccessObjects.GetAll(hr_passportinfoEntity hr_passportinfo)
        {
           try
            {
				const string SP = "hr_passportinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_passportinfo.SortExpression);
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_passportinfo, cmd, Database);
                    
                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GetAllhr_passportinfo"));
            }	
        }
		
		IList<hr_passportinfoEntity> Ihr_passportinfoDataAccessObjects.GetAllByPages(hr_passportinfoEntity hr_passportinfo)
        {
        try
            {
				const string SP = "hr_passportinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_passportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_passportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_passportinfo.CurrentPage);                    
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_passportinfo, cmd,Database);

                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_passportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GetAllByPageshr_passportinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_passportinfoDataAccessObjects.SaveMasterDethr_residentvisa(hr_passportinfoEntity masterEntity, 
        IList<hr_residentvisaEntity> listAdded, 
        IList<hr_residentvisaEntity> listUpdated,
        IList<hr_residentvisaEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_passportinfo_Ins";
            const string MasterSPUpdate = "hr_passportinfo_Upd";
            const string MasterSPDelete = "hr_passportinfo_Del";
            
			
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
                                item.passportid=PrimaryKeyMaster;
                            }
                        }
                        hr_residentvisaDataAccessObjects objhr_residentvisa=new hr_residentvisaDataAccessObjects(this.Context);
                        objhr_residentvisa.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.SaveDshr_passportinfo"));
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
        hr_passportinfoEntity Ihr_passportinfoDataAccessObjects.GetSingle(hr_passportinfoEntity hr_passportinfo)
        {
           try
            {
				const string SP = "hr_passportinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_passportinfo, cmd, Database);
                    
                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GetSinglehr_passportinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_passportinfoEntity> Ihr_passportinfoDataAccessObjects.GAPgListView(hr_passportinfoEntity hr_passportinfo)
        {
        try
            {
				const string SP = "hr_passportinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_passportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_passportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_passportinfo.CurrentPage);                    
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_passportinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_passportinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_passportinfo.strCommonSerachParam);

                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_passportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GAPgListViewhr_passportinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}