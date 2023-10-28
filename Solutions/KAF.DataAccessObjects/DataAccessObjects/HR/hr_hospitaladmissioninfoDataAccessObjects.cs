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
	
	internal sealed partial class hr_hospitaladmissioninfoDataAccessObjects : BaseDataAccess, Ihr_hospitaladmissioninfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_hospitaladmissioninfoDataAccessObjects";
        
		public hr_hospitaladmissioninfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_hospitaladmissioninfo.hospitaladmissionid.HasValue)
				Database.AddInParameter(cmd, "@HospitalAdmissionID", DbType.Int64, hr_hospitaladmissioninfo.hospitaladmissionid);
            if (forDelete) return;
			if (hr_hospitaladmissioninfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_hospitaladmissioninfo.hrbasicid);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.hospitalname)))
				Database.AddInParameter(cmd, "@HospitalName", DbType.String, hr_hospitaladmissioninfo.hospitalname);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.diseasename)))
				Database.AddInParameter(cmd, "@DiseaseName", DbType.String, hr_hospitaladmissioninfo.diseasename);
			if ((hr_hospitaladmissioninfo.hospitaladmissiondate.HasValue))
				Database.AddInParameter(cmd, "@HospitalAdmissionDate", DbType.DateTime, hr_hospitaladmissioninfo.hospitaladmissiondate);
			if ((hr_hospitaladmissioninfo.hospitalreleasedate.HasValue))
				Database.AddInParameter(cmd, "@HospitalReleaseDate", DbType.DateTime, hr_hospitaladmissioninfo.hospitalreleasedate);
			if (hr_hospitaladmissioninfo.hospitalcountryid.HasValue)
				Database.AddInParameter(cmd, "@HospitalCountryID", DbType.Int64, hr_hospitaladmissioninfo.hospitalcountryid);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, hr_hospitaladmissioninfo.description);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.releasenote)))
				Database.AddInParameter(cmd, "@ReleaseNote", DbType.String, hr_hospitaladmissioninfo.releasenote);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_hospitaladmissioninfo.remarks);
			if ((hr_hospitaladmissioninfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_hospitaladmissioninfo.ex_date1);
			if ((hr_hospitaladmissioninfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_hospitaladmissioninfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_hospitaladmissioninfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_hospitaladmissioninfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_hospitaladmissioninfo.ex_nvarchar2);
			if (hr_hospitaladmissioninfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_hospitaladmissioninfo.ex_bigint1);
			if (hr_hospitaladmissioninfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_hospitaladmissioninfo.ex_bigint2);
			if (hr_hospitaladmissioninfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_hospitaladmissioninfo.ex_decimal1);
			if (hr_hospitaladmissioninfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_hospitaladmissioninfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_hospitaladmissioninfoDataAccessObjects.Add(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo  )
        {
            long returnCode = -99;
            const string SP = "hr_hospitaladmissioninfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_hospitaladmissioninfo, cmd,Database);
                FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.Addhr_hospitaladmissioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_hospitaladmissioninfoDataAccessObjects.Update(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo )
        {
           long returnCode = -99;
            const string SP = "hr_hospitaladmissioninfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_hospitaladmissioninfo, cmd,Database);
                FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.Updatehr_hospitaladmissioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_hospitaladmissioninfoDataAccessObjects.Delete(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
            long returnCode = -99;
           	const string SP = "hr_hospitaladmissioninfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_hospitaladmissioninfo, cmd,Database, true);
                FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.Deletehr_hospitaladmissioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_hospitaladmissioninfoDataAccessObjects.SaveList(IList<hr_hospitaladmissioninfoEntity> listAdded, IList<hr_hospitaladmissioninfoEntity> listUpdated, IList<hr_hospitaladmissioninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_hospitaladmissioninfo_Ins";
            const string SPUpdate = "hr_hospitaladmissioninfo_Upd";
            const string SPDelete = "hr_hospitaladmissioninfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_hospitaladmissioninfo, cmd, Database, true);
                            FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_hospitaladmissioninfo, cmd, Database);
                            FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_hospitaladmissioninfo, cmd, Database);
                            FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.Save_hr_hospitaladmissioninfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_hospitaladmissioninfoEntity> listAdded, IList<hr_hospitaladmissioninfoEntity> listUpdated, IList<hr_hospitaladmissioninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_hospitaladmissioninfo_Ins";
            const string SPUpdate = "hr_hospitaladmissioninfo_Upd";
            const string SPDelete = "hr_hospitaladmissioninfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_hospitaladmissioninfo, cmd, db, true);
                            FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_hospitaladmissioninfo, cmd, db);
                            FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_hospitaladmissioninfo, cmd, db);
                            FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.Save_hr_hospitaladmissioninfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoDataAccessObjects.GetAll(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
           try
            {
				const string SP = "hr_hospitaladmissioninfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_hospitaladmissioninfo.SortExpression);
                    FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_hospitaladmissioninfo, cmd, Database);
                    
                    IList<hr_hospitaladmissioninfoEntity> itemList = new List<hr_hospitaladmissioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_hospitaladmissioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.GetAllhr_hospitaladmissioninfo"));
            }	
        }
		
		IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoDataAccessObjects.GetAllByPages(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
        try
            {
				const string SP = "hr_hospitaladmissioninfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_hospitaladmissioninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_hospitaladmissioninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_hospitaladmissioninfo.CurrentPage);                    
                    FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_hospitaladmissioninfo, cmd,Database);

                    IList<hr_hospitaladmissioninfoEntity> itemList = new List<hr_hospitaladmissioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_hospitaladmissioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_hospitaladmissioninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.GetAllByPageshr_hospitaladmissioninfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_hospitaladmissioninfoEntity Ihr_hospitaladmissioninfoDataAccessObjects.GetSingle(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
           try
            {
				const string SP = "hr_hospitaladmissioninfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_hospitaladmissioninfo, cmd, Database);
                    
                    IList<hr_hospitaladmissioninfoEntity> itemList = new List<hr_hospitaladmissioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_hospitaladmissioninfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.GetSinglehr_hospitaladmissioninfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoDataAccessObjects.GAPgListView(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
        try
            {
				const string SP = "hr_hospitaladmissioninfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_hospitaladmissioninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_hospitaladmissioninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_hospitaladmissioninfo.CurrentPage);                    
                    FillSequrityParameters(hr_hospitaladmissioninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_hospitaladmissioninfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_hospitaladmissioninfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_hospitaladmissioninfo.strCommonSerachParam);

                    IList<hr_hospitaladmissioninfoEntity> itemList = new List<hr_hospitaladmissioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_hospitaladmissioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_hospitaladmissioninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.GAPgListViewhr_hospitaladmissioninfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}