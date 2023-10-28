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
	
	internal sealed partial class hr_familyjobinfoDataAccessObjects : BaseDataAccess, Ihr_familyjobinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_familyjobinfoDataAccessObjects";
        
		public hr_familyjobinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_familyjobinfoEntity hr_familyjobinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_familyjobinfo.hrfamilyjobid.HasValue)
				Database.AddInParameter(cmd, "@HrFamilyJobID", DbType.Int64, hr_familyjobinfo.hrfamilyjobid);
            if (forDelete) return;
			if (hr_familyjobinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_familyjobinfo.hrbasicid);
			if (hr_familyjobinfo.hrfamilyid.HasValue)
				Database.AddInParameter(cmd, "@HrFamilyID", DbType.Int64, hr_familyjobinfo.hrfamilyid);
			if (hr_familyjobinfo.jobtype.HasValue)
				Database.AddInParameter(cmd, "@JobType", DbType.Int64, hr_familyjobinfo.jobtype);
			if (!(string.IsNullOrEmpty(hr_familyjobinfo.organization)))
				Database.AddInParameter(cmd, "@Organization", DbType.String, hr_familyjobinfo.organization);
			if (!(string.IsNullOrEmpty(hr_familyjobinfo.designation)))
				Database.AddInParameter(cmd, "@Designation", DbType.String, hr_familyjobinfo.designation);
			if ((hr_familyjobinfo.joiningdate.HasValue))
				Database.AddInParameter(cmd, "@JoiningDate", DbType.DateTime, hr_familyjobinfo.joiningdate);
			if (!(string.IsNullOrEmpty(hr_familyjobinfo.workplaceaddress)))
				Database.AddInParameter(cmd, "@WorkPlaceAddress", DbType.String, hr_familyjobinfo.workplaceaddress);
			if (!(string.IsNullOrEmpty(hr_familyjobinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_familyjobinfo.remarks);
			if ((hr_familyjobinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_familyjobinfo.ex_date1);
			if ((hr_familyjobinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_familyjobinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_familyjobinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_familyjobinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_familyjobinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_familyjobinfo.ex_nvarchar2);
			if (hr_familyjobinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_familyjobinfo.ex_bigint1);
			if (hr_familyjobinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_familyjobinfo.ex_bigint2);
			if (hr_familyjobinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_familyjobinfo.ex_decimal1);
			if (hr_familyjobinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_familyjobinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_familyjobinfoDataAccessObjects.Add(hr_familyjobinfoEntity hr_familyjobinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_familyjobinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_familyjobinfo, cmd,Database);
                FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.Addhr_familyjobinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_familyjobinfoDataAccessObjects.Update(hr_familyjobinfoEntity hr_familyjobinfo )
        {
           long returnCode = -99;
            const string SP = "hr_familyjobinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_familyjobinfo, cmd,Database);
                FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.Updatehr_familyjobinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_familyjobinfoDataAccessObjects.Delete(hr_familyjobinfoEntity hr_familyjobinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_familyjobinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_familyjobinfo, cmd,Database, true);
                FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.Deletehr_familyjobinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_familyjobinfoDataAccessObjects.SaveList(IList<hr_familyjobinfoEntity> listAdded, IList<hr_familyjobinfoEntity> listUpdated, IList<hr_familyjobinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familyjobinfo_Ins";
            const string SPUpdate = "hr_familyjobinfo_Upd";
            const string SPDelete = "hr_familyjobinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familyjobinfoEntity hr_familyjobinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familyjobinfo, cmd, Database, true);
                            FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familyjobinfoEntity hr_familyjobinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familyjobinfo, cmd, Database);
                            FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familyjobinfoEntity hr_familyjobinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familyjobinfo, cmd, Database);
                            FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.Save_hr_familyjobinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_familyjobinfoEntity> listAdded, IList<hr_familyjobinfoEntity> listUpdated, IList<hr_familyjobinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familyjobinfo_Ins";
            const string SPUpdate = "hr_familyjobinfo_Upd";
            const string SPDelete = "hr_familyjobinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familyjobinfoEntity hr_familyjobinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familyjobinfo, cmd, db, true);
                            FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familyjobinfoEntity hr_familyjobinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familyjobinfo, cmd, db);
                            FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familyjobinfoEntity hr_familyjobinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familyjobinfo, cmd, db);
                            FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.Save_hr_familyjobinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_familyjobinfoEntity> Ihr_familyjobinfoDataAccessObjects.GetAll(hr_familyjobinfoEntity hr_familyjobinfo)
        {
           try
            {
				const string SP = "hr_familyjobinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_familyjobinfo.SortExpression);
                    FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familyjobinfo, cmd, Database);
                    
                    IList<hr_familyjobinfoEntity> itemList = new List<hr_familyjobinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyjobinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.GetAllhr_familyjobinfo"));
            }	
        }
		
		IList<hr_familyjobinfoEntity> Ihr_familyjobinfoDataAccessObjects.GetAllByPages(hr_familyjobinfoEntity hr_familyjobinfo)
        {
        try
            {
				const string SP = "hr_familyjobinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familyjobinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familyjobinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familyjobinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familyjobinfo, cmd,Database);

                    IList<hr_familyjobinfoEntity> itemList = new List<hr_familyjobinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyjobinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familyjobinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.GetAllByPageshr_familyjobinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_familyjobinfoEntity Ihr_familyjobinfoDataAccessObjects.GetSingle(hr_familyjobinfoEntity hr_familyjobinfo)
        {
           try
            {
				const string SP = "hr_familyjobinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familyjobinfo, cmd, Database);
                    
                    IList<hr_familyjobinfoEntity> itemList = new List<hr_familyjobinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyjobinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.GetSinglehr_familyjobinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_familyjobinfoEntity> Ihr_familyjobinfoDataAccessObjects.GAPgListView(hr_familyjobinfoEntity hr_familyjobinfo)
        {
        try
            {
				const string SP = "hr_familyjobinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familyjobinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familyjobinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familyjobinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familyjobinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familyjobinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_familyjobinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_familyjobinfo.strCommonSerachParam);

                    IList<hr_familyjobinfoEntity> itemList = new List<hr_familyjobinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyjobinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familyjobinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyjobinfoDataAccess.GAPgListViewhr_familyjobinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}