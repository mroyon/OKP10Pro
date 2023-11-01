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
	
	internal sealed partial class hr_civilidinfoDataAccessObjects : BaseDataAccess, Ihr_civilidinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_civilidinfoDataAccessObjects";
        
		public hr_civilidinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_civilidinfoEntity hr_civilidinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_civilidinfo.civilid.HasValue)
				Database.AddInParameter(cmd, "@CivilID", DbType.Int64, hr_civilidinfo.civilid);
            if (forDelete) return;
			if (hr_civilidinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_civilidinfo.hrbasicid);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidno)))
				Database.AddInParameter(cmd, "@CivilIDNo", DbType.String, hr_civilidinfo.civilidno);
			if (hr_civilidinfo.serialno.HasValue)
				Database.AddInParameter(cmd, "@SerialNo", DbType.String, hr_civilidinfo.serialno);
			if ((hr_civilidinfo.civilidissuedate.HasValue))
				Database.AddInParameter(cmd, "@CivilIDIssueDate", DbType.DateTime, hr_civilidinfo.civilidissuedate);
			if ((hr_civilidinfo.civilidexpirydate.HasValue))
				Database.AddInParameter(cmd, "@CivilIDExpiryDate", DbType.DateTime, hr_civilidinfo.civilidexpirydate);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfiledescription)))
				Database.AddInParameter(cmd, "@CivilIDFileDescription", DbType.String, hr_civilidinfo.civilidfiledescription);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfilepath)))
				Database.AddInParameter(cmd, "@CivilIDFilePath", DbType.String, hr_civilidinfo.civilidfilepath);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfilename)))
				Database.AddInParameter(cmd, "@CivilIDFileName", DbType.String, hr_civilidinfo.civilidfilename);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfiletype)))
				Database.AddInParameter(cmd, "@CivilIDFileType", DbType.String, hr_civilidinfo.civilidfiletype);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidextension)))
				Database.AddInParameter(cmd, "@CivilIDExtension", DbType.String, hr_civilidinfo.civilidextension);
			
				Database.AddInParameter(cmd, "@CivilIDFileID", DbType.Guid, hr_civilidinfo.civilidfileid);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfiledescription_2)))
				Database.AddInParameter(cmd, "@CivilIDFileDescription_2", DbType.String, hr_civilidinfo.civilidfiledescription_2);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfilepath_2)))
				Database.AddInParameter(cmd, "@CivilIDFilePath_2", DbType.String, hr_civilidinfo.civilidfilepath_2);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfilename_2)))
				Database.AddInParameter(cmd, "@CivilIDFileName_2", DbType.String, hr_civilidinfo.civilidfilename_2);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidfiletype_2)))
				Database.AddInParameter(cmd, "@CivilIDFileType_2", DbType.String, hr_civilidinfo.civilidfiletype_2);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.civilidextension_2)))
				Database.AddInParameter(cmd, "@CivilIDExtension_2", DbType.String, hr_civilidinfo.civilidextension_2);
			
				Database.AddInParameter(cmd, "@CivilIDFileID_2", DbType.Guid, hr_civilidinfo.civilidfileid_2);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_civilidinfo.remarks);
			if (hr_civilidinfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_civilidinfo.forreview);
			if ((hr_civilidinfo.iscurrent != null))
				Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hr_civilidinfo.iscurrent);
			if ((hr_civilidinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_civilidinfo.ex_date1);
			if ((hr_civilidinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_civilidinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_civilidinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_civilidinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_civilidinfo.ex_nvarchar2);
			if (hr_civilidinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_civilidinfo.ex_bigint1);
			if (hr_civilidinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_civilidinfo.ex_bigint2);
			if (hr_civilidinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_civilidinfo.ex_decimal1);
			if (hr_civilidinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_civilidinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_civilidinfoDataAccessObjects.Add(hr_civilidinfoEntity hr_civilidinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_civilidinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_civilidinfo, cmd,Database);
                FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.Addhr_civilidinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_civilidinfoDataAccessObjects.Update(hr_civilidinfoEntity hr_civilidinfo )
        {
           long returnCode = -99;
            const string SP = "hr_civilidinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_civilidinfo, cmd,Database);
                FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.Updatehr_civilidinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_civilidinfoDataAccessObjects.Delete(hr_civilidinfoEntity hr_civilidinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_civilidinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_civilidinfo, cmd,Database, true);
                FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.Deletehr_civilidinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_civilidinfoDataAccessObjects.SaveList(IList<hr_civilidinfoEntity> listAdded, IList<hr_civilidinfoEntity> listUpdated, IList<hr_civilidinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_civilidinfo_Ins";
            const string SPUpdate = "hr_civilidinfo_Upd";
            const string SPDelete = "hr_civilidinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_civilidinfoEntity hr_civilidinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_civilidinfo, cmd, Database, true);
                            FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_civilidinfoEntity hr_civilidinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_civilidinfo, cmd, Database);
                            FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_civilidinfoEntity hr_civilidinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_civilidinfo, cmd, Database);
                            FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.Save_hr_civilidinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_civilidinfoEntity> listAdded, IList<hr_civilidinfoEntity> listUpdated, IList<hr_civilidinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_civilidinfo_Ins";
            const string SPUpdate = "hr_civilidinfo_Upd";
            const string SPDelete = "hr_civilidinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_civilidinfoEntity hr_civilidinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_civilidinfo, cmd, db, true);
                            FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_civilidinfoEntity hr_civilidinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_civilidinfo, cmd, db);
                            FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_civilidinfoEntity hr_civilidinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_civilidinfo, cmd, db);
                            FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.Save_hr_civilidinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_civilidinfoEntity> Ihr_civilidinfoDataAccessObjects.GetAll(hr_civilidinfoEntity hr_civilidinfo)
        {
           try
            {
				const string SP = "hr_civilidinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_civilidinfo.SortExpression);
                    FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_civilidinfo, cmd, Database);
                    
                    IList<hr_civilidinfoEntity> itemList = new List<hr_civilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_civilidinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.GetAllhr_civilidinfo"));
            }	
        }
		
		IList<hr_civilidinfoEntity> Ihr_civilidinfoDataAccessObjects.GetAllByPages(hr_civilidinfoEntity hr_civilidinfo)
        {
        try
            {
				const string SP = "hr_civilidinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_civilidinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_civilidinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_civilidinfo.CurrentPage);                    
                    FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_civilidinfo, cmd,Database);

                    IList<hr_civilidinfoEntity> itemList = new List<hr_civilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_civilidinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_civilidinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.GetAllByPageshr_civilidinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_civilidinfoEntity Ihr_civilidinfoDataAccessObjects.GetSingle(hr_civilidinfoEntity hr_civilidinfo)
        {
           try
            {
				const string SP = "hr_civilidinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_civilidinfo, cmd, Database);
                    
                    IList<hr_civilidinfoEntity> itemList = new List<hr_civilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_civilidinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.GetSinglehr_civilidinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_civilidinfoEntity> Ihr_civilidinfoDataAccessObjects.GAPgListView(hr_civilidinfoEntity hr_civilidinfo)
        {
        try
            {
				const string SP = "hr_civilidinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_civilidinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_civilidinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_civilidinfo.CurrentPage);                    
                    FillSequrityParameters(hr_civilidinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_civilidinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_civilidinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_civilidinfo.strCommonSerachParam);

                    IList<hr_civilidinfoEntity> itemList = new List<hr_civilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_civilidinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_civilidinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_civilidinfoDataAccess.GAPgListViewhr_civilidinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}