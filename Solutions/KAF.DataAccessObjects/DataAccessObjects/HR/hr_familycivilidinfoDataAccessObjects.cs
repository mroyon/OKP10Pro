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
	
	internal sealed partial class hr_familycivilidinfoDataAccessObjects : BaseDataAccess, Ihr_familycivilidinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_familycivilidinfoDataAccessObjects";
        
		public hr_familycivilidinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_familycivilidinfoEntity hr_familycivilidinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_familycivilidinfo.familycivilid.HasValue)
				Database.AddInParameter(cmd, "@FamilyCivilID", DbType.Int64, hr_familycivilidinfo.familycivilid);
            if (forDelete) return;
			if (hr_familycivilidinfo.hrfamilyid.HasValue)
				Database.AddInParameter(cmd, "@HrFamilyID", DbType.Int64, hr_familycivilidinfo.hrfamilyid);
			if (hr_familycivilidinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_familycivilidinfo.hrbasicid);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidno)))
				Database.AddInParameter(cmd, "@FamilyCivilIDNo", DbType.String, hr_familycivilidinfo.familycivilidno);
			if (hr_familycivilidinfo.serialno.HasValue)
				Database.AddInParameter(cmd, "@SerialNo", DbType.Int64, hr_familycivilidinfo.serialno);
			if ((hr_familycivilidinfo.familycivilidissuedate.HasValue))
				Database.AddInParameter(cmd, "@FamilyCivilIDIssueDate", DbType.DateTime, hr_familycivilidinfo.familycivilidissuedate);
			if ((hr_familycivilidinfo.familycivilidexpirydate.HasValue))
				Database.AddInParameter(cmd, "@FamilyCivilIDExpiryDate", DbType.DateTime, hr_familycivilidinfo.familycivilidexpirydate);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfiledescription)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFileDescription", DbType.String, hr_familycivilidinfo.familycivilidfiledescription);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfilepath)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFilePath", DbType.String, hr_familycivilidinfo.familycivilidfilepath);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfilename)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFileName", DbType.String, hr_familycivilidinfo.familycivilidfilename);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfiletype)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFileType", DbType.String, hr_familycivilidinfo.familycivilidfiletype);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidextension)))
				Database.AddInParameter(cmd, "@FamilyCivilIDExtension", DbType.String, hr_familycivilidinfo.familycivilidextension);
			
				Database.AddInParameter(cmd, "@FamilyCivilIDFileID", DbType.Guid, hr_familycivilidinfo.familycivilidfileid);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfiledescription_2)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFileDescription_2", DbType.String, hr_familycivilidinfo.familycivilidfiledescription_2);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfilepath_2)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFilePath_2", DbType.String, hr_familycivilidinfo.familycivilidfilepath_2);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfilename_2)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFileName_2", DbType.String, hr_familycivilidinfo.familycivilidfilename_2);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidfiletype_2)))
				Database.AddInParameter(cmd, "@FamilyCivilIDFileType_2", DbType.String, hr_familycivilidinfo.familycivilidfiletype_2);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.familycivilidextension_2)))
				Database.AddInParameter(cmd, "@FamilyCivilIDExtension_2", DbType.String, hr_familycivilidinfo.familycivilidextension_2);
			
				Database.AddInParameter(cmd, "@FamilyCivilIDFileID_2", DbType.Guid, hr_familycivilidinfo.familycivilidfileid_2);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_familycivilidinfo.remarks);
			if (hr_familycivilidinfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_familycivilidinfo.forreview);
			if ((hr_familycivilidinfo.iscurrent != null))
				Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, hr_familycivilidinfo.iscurrent);
			if ((hr_familycivilidinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_familycivilidinfo.ex_date1);
			if ((hr_familycivilidinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_familycivilidinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_familycivilidinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_familycivilidinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_familycivilidinfo.ex_nvarchar2);
			if (hr_familycivilidinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_familycivilidinfo.ex_bigint1);
			if (hr_familycivilidinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_familycivilidinfo.ex_bigint2);
			if (hr_familycivilidinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_familycivilidinfo.ex_decimal1);
			if (hr_familycivilidinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_familycivilidinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_familycivilidinfoDataAccessObjects.Add(hr_familycivilidinfoEntity hr_familycivilidinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_familycivilidinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_familycivilidinfo, cmd,Database);
                FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.Addhr_familycivilidinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_familycivilidinfoDataAccessObjects.Update(hr_familycivilidinfoEntity hr_familycivilidinfo )
        {
           long returnCode = -99;
            const string SP = "hr_familycivilidinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_familycivilidinfo, cmd,Database);
                FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.Updatehr_familycivilidinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_familycivilidinfoDataAccessObjects.Delete(hr_familycivilidinfoEntity hr_familycivilidinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_familycivilidinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_familycivilidinfo, cmd,Database, true);
                FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.Deletehr_familycivilidinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_familycivilidinfoDataAccessObjects.SaveList(IList<hr_familycivilidinfoEntity> listAdded, IList<hr_familycivilidinfoEntity> listUpdated, IList<hr_familycivilidinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familycivilidinfo_Ins";
            const string SPUpdate = "hr_familycivilidinfo_Upd";
            const string SPDelete = "hr_familycivilidinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familycivilidinfoEntity hr_familycivilidinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familycivilidinfo, cmd, Database, true);
                            FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familycivilidinfoEntity hr_familycivilidinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familycivilidinfo, cmd, Database);
                            FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familycivilidinfoEntity hr_familycivilidinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familycivilidinfo, cmd, Database);
                            FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.Save_hr_familycivilidinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_familycivilidinfoEntity> listAdded, IList<hr_familycivilidinfoEntity> listUpdated, IList<hr_familycivilidinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familycivilidinfo_Ins";
            const string SPUpdate = "hr_familycivilidinfo_Upd";
            const string SPDelete = "hr_familycivilidinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familycivilidinfoEntity hr_familycivilidinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familycivilidinfo, cmd, db, true);
                            FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familycivilidinfoEntity hr_familycivilidinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familycivilidinfo, cmd, db);
                            FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familycivilidinfoEntity hr_familycivilidinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familycivilidinfo, cmd, db);
                            FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.Save_hr_familycivilidinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoDataAccessObjects.GetAll(hr_familycivilidinfoEntity hr_familycivilidinfo)
        {
           try
            {
				const string SP = "hr_familycivilidinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_familycivilidinfo.SortExpression);
                    FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familycivilidinfo, cmd, Database);
                    
                    IList<hr_familycivilidinfoEntity> itemList = new List<hr_familycivilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familycivilidinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.GetAllhr_familycivilidinfo"));
            }	
        }
		
		IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoDataAccessObjects.GetAllByPages(hr_familycivilidinfoEntity hr_familycivilidinfo)
        {
        try
            {
				const string SP = "hr_familycivilidinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familycivilidinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familycivilidinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familycivilidinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familycivilidinfo, cmd,Database);

                    IList<hr_familycivilidinfoEntity> itemList = new List<hr_familycivilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familycivilidinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familycivilidinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.GetAllByPageshr_familycivilidinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_familycivilidinfoEntity Ihr_familycivilidinfoDataAccessObjects.GetSingle(hr_familycivilidinfoEntity hr_familycivilidinfo)
        {
           try
            {
				const string SP = "hr_familycivilidinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familycivilidinfo, cmd, Database);
                    
                    IList<hr_familycivilidinfoEntity> itemList = new List<hr_familycivilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familycivilidinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.GetSinglehr_familycivilidinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoDataAccessObjects.GAPgListView(hr_familycivilidinfoEntity hr_familycivilidinfo)
        {
        try
            {
				const string SP = "hr_familycivilidinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familycivilidinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familycivilidinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familycivilidinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familycivilidinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familycivilidinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_familycivilidinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_familycivilidinfo.strCommonSerachParam);

                    IList<hr_familycivilidinfoEntity> itemList = new List<hr_familycivilidinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familycivilidinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familycivilidinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familycivilidinfoDataAccess.GAPgListViewhr_familycivilidinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}