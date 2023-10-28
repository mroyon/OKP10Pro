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
	
	internal sealed partial class hr_extensioninfoDataAccessObjects : BaseDataAccess, Ihr_extensioninfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_extensioninfoDataAccessObjects";
        
		public hr_extensioninfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_extensioninfoEntity hr_extensioninfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_extensioninfo.hrextensionid.HasValue)
				Database.AddInParameter(cmd, "@HrExtensionID", DbType.Int64, hr_extensioninfo.hrextensionid);
            if (forDelete) return;
			if (hr_extensioninfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_extensioninfo.hrbasicid);
			if ((hr_extensioninfo.repatriationdate.HasValue))
				Database.AddInParameter(cmd, "@RepatriationDate", DbType.DateTime, hr_extensioninfo.repatriationdate);
			if ((hr_extensioninfo.extensiontill.HasValue))
				Database.AddInParameter(cmd, "@ExtensionTill", DbType.DateTime, hr_extensioninfo.extensiontill);
			if ((hr_extensioninfo.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_extensioninfo.letterdate);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.letterno)))
				Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_extensioninfo.letterno);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.letternofilepath)))
				Database.AddInParameter(cmd, "@LetterNoFilePath", DbType.String, hr_extensioninfo.letternofilepath);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.letternofilename)))
				Database.AddInParameter(cmd, "@LetterNoFileName", DbType.String, hr_extensioninfo.letternofilename);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.letternofiletype)))
				Database.AddInParameter(cmd, "@LetterNoFileType", DbType.String, hr_extensioninfo.letternofiletype);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.letternofileextension)))
				Database.AddInParameter(cmd, "@LetterNoFileExtension", DbType.String, hr_extensioninfo.letternofileextension);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_extensioninfo.remarks);
			if ((hr_extensioninfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_extensioninfo.ex_date1);
			if ((hr_extensioninfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_extensioninfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_extensioninfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_extensioninfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_extensioninfo.ex_nvarchar2);
			if (hr_extensioninfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_extensioninfo.ex_bigint1);
			if (hr_extensioninfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_extensioninfo.ex_bigint2);
			if (hr_extensioninfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_extensioninfo.ex_decimal1);
			if (hr_extensioninfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_extensioninfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_extensioninfoDataAccessObjects.Add(hr_extensioninfoEntity hr_extensioninfo  )
        {
            long returnCode = -99;
            const string SP = "hr_extensioninfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_extensioninfo, cmd,Database);
                FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.Addhr_extensioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_extensioninfoDataAccessObjects.Update(hr_extensioninfoEntity hr_extensioninfo )
        {
           long returnCode = -99;
            const string SP = "hr_extensioninfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_extensioninfo, cmd,Database);
                FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.Updatehr_extensioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_extensioninfoDataAccessObjects.Delete(hr_extensioninfoEntity hr_extensioninfo)
        {
            long returnCode = -99;
           	const string SP = "hr_extensioninfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_extensioninfo, cmd,Database, true);
                FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.Deletehr_extensioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_extensioninfoDataAccessObjects.SaveList(IList<hr_extensioninfoEntity> listAdded, IList<hr_extensioninfoEntity> listUpdated, IList<hr_extensioninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_extensioninfo_Ins";
            const string SPUpdate = "hr_extensioninfo_Upd";
            const string SPDelete = "hr_extensioninfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_extensioninfoEntity hr_extensioninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_extensioninfo, cmd, Database, true);
                            FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_extensioninfoEntity hr_extensioninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_extensioninfo, cmd, Database);
                            FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_extensioninfoEntity hr_extensioninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_extensioninfo, cmd, Database);
                            FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.Save_hr_extensioninfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_extensioninfoEntity> listAdded, IList<hr_extensioninfoEntity> listUpdated, IList<hr_extensioninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_extensioninfo_Ins";
            const string SPUpdate = "hr_extensioninfo_Upd";
            const string SPDelete = "hr_extensioninfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_extensioninfoEntity hr_extensioninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_extensioninfo, cmd, db, true);
                            FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_extensioninfoEntity hr_extensioninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_extensioninfo, cmd, db);
                            FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_extensioninfoEntity hr_extensioninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_extensioninfo, cmd, db);
                            FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.Save_hr_extensioninfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_extensioninfoEntity> Ihr_extensioninfoDataAccessObjects.GetAll(hr_extensioninfoEntity hr_extensioninfo)
        {
           try
            {
				const string SP = "hr_extensioninfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_extensioninfo.SortExpression);
                    FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_extensioninfo, cmd, Database);
                    
                    IList<hr_extensioninfoEntity> itemList = new List<hr_extensioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_extensioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.GetAllhr_extensioninfo"));
            }	
        }
		
		IList<hr_extensioninfoEntity> Ihr_extensioninfoDataAccessObjects.GetAllByPages(hr_extensioninfoEntity hr_extensioninfo)
        {
        try
            {
				const string SP = "hr_extensioninfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_extensioninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_extensioninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_extensioninfo.CurrentPage);                    
                    FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_extensioninfo, cmd,Database);

                    IList<hr_extensioninfoEntity> itemList = new List<hr_extensioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_extensioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_extensioninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.GetAllByPageshr_extensioninfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_extensioninfoEntity Ihr_extensioninfoDataAccessObjects.GetSingle(hr_extensioninfoEntity hr_extensioninfo)
        {
           try
            {
				const string SP = "hr_extensioninfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_extensioninfo, cmd, Database);
                    
                    IList<hr_extensioninfoEntity> itemList = new List<hr_extensioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_extensioninfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.GetSinglehr_extensioninfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_extensioninfoEntity> Ihr_extensioninfoDataAccessObjects.GAPgListView(hr_extensioninfoEntity hr_extensioninfo)
        {
        try
            {
				const string SP = "hr_extensioninfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_extensioninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_extensioninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_extensioninfo.CurrentPage);                    
                    FillSequrityParameters(hr_extensioninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_extensioninfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_extensioninfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_extensioninfo.strCommonSerachParam);

                    IList<hr_extensioninfoEntity> itemList = new List<hr_extensioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_extensioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_extensioninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_extensioninfoDataAccess.GAPgListViewhr_extensioninfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}