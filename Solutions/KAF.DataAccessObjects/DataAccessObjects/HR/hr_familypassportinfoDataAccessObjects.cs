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
	
	internal sealed partial class hr_familypassportinfoDataAccessObjects : BaseDataAccess, Ihr_familypassportinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_familypassportinfoDataAccessObjects";
        
		public hr_familypassportinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_familypassportinfoEntity hr_familypassportinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_familypassportinfo.familypassportid.HasValue)
				Database.AddInParameter(cmd, "@FamilyPassportID", DbType.Int64, hr_familypassportinfo.familypassportid);
            if (forDelete) return;
			if (hr_familypassportinfo.hrfamilyid.HasValue)
				Database.AddInParameter(cmd, "@HrFamilyID", DbType.Int64, hr_familypassportinfo.hrfamilyid);
			if (hr_familypassportinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_familypassportinfo.hrbasicid);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.familypassportno)))
				Database.AddInParameter(cmd, "@FamilyPassportNo", DbType.String, hr_familypassportinfo.familypassportno);
			if ((hr_familypassportinfo.familypassportissuedate.HasValue))
				Database.AddInParameter(cmd, "@FamilyPassportIssueDate", DbType.DateTime, hr_familypassportinfo.familypassportissuedate);
			if ((hr_familypassportinfo.familypassportexpirydate.HasValue))
				Database.AddInParameter(cmd, "@FamilyPassportExpiryDate", DbType.DateTime, hr_familypassportinfo.familypassportexpirydate);
			if (hr_familypassportinfo.familypassportissuecountryid.HasValue)
				Database.AddInParameter(cmd, "@FamilyPassportIssueCountryID", DbType.Int64, hr_familypassportinfo.familypassportissuecountryid);
			if ((hr_familypassportinfo.isfamilyfamilypassport != null))
				Database.AddInParameter(cmd, "@IsFamilyFamilyPassport", DbType.Boolean, hr_familypassportinfo.isfamilyfamilypassport);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.familypassportfiledescription)))
				Database.AddInParameter(cmd, "@FamilyPassportFileDescription", DbType.String, hr_familypassportinfo.familypassportfiledescription);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.familypassportfilepath)))
				Database.AddInParameter(cmd, "@FamilyPassportFilePath", DbType.String, hr_familypassportinfo.familypassportfilepath);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.familypassportfilename)))
				Database.AddInParameter(cmd, "@FamilyPassportFileName", DbType.String, hr_familypassportinfo.familypassportfilename);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.familypassportfiletype)))
				Database.AddInParameter(cmd, "@FamilyPassportFileType", DbType.String, hr_familypassportinfo.familypassportfiletype);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.familypassportextension)))
				Database.AddInParameter(cmd, "@FamilyPassportExtension", DbType.String, hr_familypassportinfo.familypassportextension);
			
				Database.AddInParameter(cmd, "@FamilyPassportFileID", DbType.Guid, hr_familypassportinfo.familypassportfileid);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_familypassportinfo.remarks);
			if (hr_familypassportinfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_familypassportinfo.forreview);
			if ((hr_familypassportinfo.iscurrent != null))
				Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hr_familypassportinfo.iscurrent);
			if ((hr_familypassportinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_familypassportinfo.ex_date1);
			if ((hr_familypassportinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_familypassportinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_familypassportinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_familypassportinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_familypassportinfo.ex_nvarchar2);
			if (hr_familypassportinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_familypassportinfo.ex_bigint1);
			if (hr_familypassportinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_familypassportinfo.ex_bigint2);
			if (hr_familypassportinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_familypassportinfo.ex_decimal1);
			if (hr_familypassportinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_familypassportinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_familypassportinfoDataAccessObjects.Add(hr_familypassportinfoEntity hr_familypassportinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_familypassportinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_familypassportinfo, cmd,Database);
                FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.Addhr_familypassportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_familypassportinfoDataAccessObjects.Update(hr_familypassportinfoEntity hr_familypassportinfo )
        {
           long returnCode = -99;
            const string SP = "hr_familypassportinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_familypassportinfo, cmd,Database);
                FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.Updatehr_familypassportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_familypassportinfoDataAccessObjects.Delete(hr_familypassportinfoEntity hr_familypassportinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_familypassportinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_familypassportinfo, cmd,Database, true);
                FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.Deletehr_familypassportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_familypassportinfoDataAccessObjects.SaveList(IList<hr_familypassportinfoEntity> listAdded, IList<hr_familypassportinfoEntity> listUpdated, IList<hr_familypassportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familypassportinfo_Ins";
            const string SPUpdate = "hr_familypassportinfo_Upd";
            const string SPDelete = "hr_familypassportinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familypassportinfoEntity hr_familypassportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familypassportinfo, cmd, Database, true);
                            FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familypassportinfoEntity hr_familypassportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familypassportinfo, cmd, Database);
                            FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familypassportinfoEntity hr_familypassportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familypassportinfo, cmd, Database);
                            FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.Save_hr_familypassportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_familypassportinfoEntity> listAdded, IList<hr_familypassportinfoEntity> listUpdated, IList<hr_familypassportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familypassportinfo_Ins";
            const string SPUpdate = "hr_familypassportinfo_Upd";
            const string SPDelete = "hr_familypassportinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familypassportinfoEntity hr_familypassportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familypassportinfo, cmd, db, true);
                            FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familypassportinfoEntity hr_familypassportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familypassportinfo, cmd, db);
                            FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familypassportinfoEntity hr_familypassportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familypassportinfo, cmd, db);
                            FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.Save_hr_familypassportinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_familypassportinfoEntity> Ihr_familypassportinfoDataAccessObjects.GetAll(hr_familypassportinfoEntity hr_familypassportinfo)
        {
           try
            {
				const string SP = "hr_familypassportinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_familypassportinfo.SortExpression);
                    FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familypassportinfo, cmd, Database);
                    
                    IList<hr_familypassportinfoEntity> itemList = new List<hr_familypassportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familypassportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.GetAllhr_familypassportinfo"));
            }	
        }
		
		IList<hr_familypassportinfoEntity> Ihr_familypassportinfoDataAccessObjects.GetAllByPages(hr_familypassportinfoEntity hr_familypassportinfo)
        {
        try
            {
				const string SP = "hr_familypassportinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familypassportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familypassportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familypassportinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familypassportinfo, cmd,Database);

                    IList<hr_familypassportinfoEntity> itemList = new List<hr_familypassportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familypassportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familypassportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.GetAllByPageshr_familypassportinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_familypassportinfoDataAccessObjects.SaveMasterDethr_familyresidentvisa(hr_familypassportinfoEntity masterEntity, 
        IList<hr_familyresidentvisaEntity> listAdded, 
        IList<hr_familyresidentvisaEntity> listUpdated,
        IList<hr_familyresidentvisaEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_familypassportinfo_Ins";
            const string MasterSPUpdate = "hr_familypassportinfo_Upd";
            const string MasterSPDelete = "hr_familypassportinfo_Del";
            
			
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
                                item.familypassportid=PrimaryKeyMaster;
                            }
                        }
                        hr_familyresidentvisaDataAccessObjects objhr_familyresidentvisa=new hr_familyresidentvisaDataAccessObjects(this.Context);
                        objhr_familyresidentvisa.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.SaveDshr_familypassportinfo"));
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
        hr_familypassportinfoEntity Ihr_familypassportinfoDataAccessObjects.GetSingle(hr_familypassportinfoEntity hr_familypassportinfo)
        {
           try
            {
				const string SP = "hr_familypassportinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familypassportinfo, cmd, Database);
                    
                    IList<hr_familypassportinfoEntity> itemList = new List<hr_familypassportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familypassportinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.GetSinglehr_familypassportinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_familypassportinfoEntity> Ihr_familypassportinfoDataAccessObjects.GAPgListView(hr_familypassportinfoEntity hr_familypassportinfo)
        {
        try
            {
				const string SP = "hr_familypassportinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familypassportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familypassportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familypassportinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familypassportinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familypassportinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_familypassportinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_familypassportinfo.strCommonSerachParam);

                    IList<hr_familypassportinfoEntity> itemList = new List<hr_familypassportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familypassportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familypassportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familypassportinfoDataAccess.GAPgListViewhr_familypassportinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}