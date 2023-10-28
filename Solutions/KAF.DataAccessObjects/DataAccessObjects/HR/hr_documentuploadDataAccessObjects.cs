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
	
	internal sealed partial class hr_documentuploadDataAccessObjects : BaseDataAccess, Ihr_documentuploadDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_documentuploadDataAccessObjects";
        
		public hr_documentuploadDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_documentuploadEntity hr_documentupload, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_documentupload.docuploadid.HasValue)
				Database.AddInParameter(cmd, "@DocUploadID", DbType.Int64, hr_documentupload.docuploadid);
            if (forDelete) return;
			if (hr_documentupload.doctypeid.HasValue)
				Database.AddInParameter(cmd, "@DocTypeID", DbType.Int64, hr_documentupload.doctypeid);
			if (hr_documentupload.filetypeid.HasValue)
				Database.AddInParameter(cmd, "@FileTypeID", DbType.Int64, hr_documentupload.filetypeid);
			if (!(string.IsNullOrEmpty(hr_documentupload.docname)))
				Database.AddInParameter(cmd, "@DocName", DbType.String, hr_documentupload.docname);
			if (hr_documentupload.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HRBasicID", DbType.Int64, hr_documentupload.hrbasicid);
			if (hr_documentupload.orderno.HasValue)
				Database.AddInParameter(cmd, "@OrderNo", DbType.Int64, hr_documentupload.orderno);
			if ((hr_documentupload.orderdate.HasValue))
				Database.AddInParameter(cmd, "@OrderDate", DbType.DateTime, hr_documentupload.orderdate);
			if (!(string.IsNullOrEmpty(hr_documentupload.filedescription)))
				Database.AddInParameter(cmd, "@FileDescription", DbType.String, hr_documentupload.filedescription);
			if (!(string.IsNullOrEmpty(hr_documentupload.filepath)))
				Database.AddInParameter(cmd, "@FilePath", DbType.String, hr_documentupload.filepath);
			if (!(string.IsNullOrEmpty(hr_documentupload.filename)))
				Database.AddInParameter(cmd, "@FileName", DbType.String, hr_documentupload.filename);
			if (!(string.IsNullOrEmpty(hr_documentupload.filetype)))
				Database.AddInParameter(cmd, "@FileType", DbType.String, hr_documentupload.filetype);
			if (!(string.IsNullOrEmpty(hr_documentupload.extension)))
				Database.AddInParameter(cmd, "@Extension", DbType.String, hr_documentupload.extension);
			if (!(string.IsNullOrEmpty(hr_documentupload.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_documentupload.remarks);
			if ((hr_documentupload.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_documentupload.ex_date1);
			if ((hr_documentupload.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_documentupload.ex_date2);
			if (!(string.IsNullOrEmpty(hr_documentupload.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_documentupload.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_documentupload.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_documentupload.ex_nvarchar2);
			if (hr_documentupload.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_documentupload.ex_bigint1);
			if (hr_documentupload.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_documentupload.ex_bigint2);
			if (hr_documentupload.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_documentupload.ex_decimal1);
			if (hr_documentupload.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_documentupload.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_documentuploadDataAccessObjects.Add(hr_documentuploadEntity hr_documentupload  )
        {
            long returnCode = -99;
            const string SP = "hr_documentupload_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_documentupload, cmd,Database);
                FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.Addhr_documentupload"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_documentuploadDataAccessObjects.Update(hr_documentuploadEntity hr_documentupload )
        {
           long returnCode = -99;
            const string SP = "hr_documentupload_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_documentupload, cmd,Database);
                FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.Updatehr_documentupload"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_documentuploadDataAccessObjects.Delete(hr_documentuploadEntity hr_documentupload)
        {
            long returnCode = -99;
           	const string SP = "hr_documentupload_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_documentupload, cmd,Database, true);
                FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.Deletehr_documentupload"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_documentuploadDataAccessObjects.SaveList(IList<hr_documentuploadEntity> listAdded, IList<hr_documentuploadEntity> listUpdated, IList<hr_documentuploadEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_documentupload_Ins";
            const string SPUpdate = "hr_documentupload_Upd";
            const string SPDelete = "hr_documentupload_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_documentuploadEntity hr_documentupload in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_documentupload, cmd, Database, true);
                            FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_documentuploadEntity hr_documentupload in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_documentupload, cmd, Database);
                            FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_documentuploadEntity hr_documentupload in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_documentupload, cmd, Database);
                            FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.Save_hr_documentupload"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_documentuploadEntity> listAdded, IList<hr_documentuploadEntity> listUpdated, IList<hr_documentuploadEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_documentupload_Ins";
            const string SPUpdate = "hr_documentupload_Upd";
            const string SPDelete = "hr_documentupload_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_documentuploadEntity hr_documentupload in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_documentupload, cmd, db, true);
                            FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, db);
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
                    foreach (hr_documentuploadEntity hr_documentupload in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_documentupload, cmd, db);
                            FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, db);
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
                    foreach (hr_documentuploadEntity hr_documentupload in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_documentupload, cmd, db);
                            FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.Save_hr_documentupload"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_documentuploadEntity> Ihr_documentuploadDataAccessObjects.GetAll(hr_documentuploadEntity hr_documentupload)
        {
           try
            {
				const string SP = "hr_documentupload_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_documentupload.SortExpression);
                    FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_documentupload, cmd, Database);
                    
                    IList<hr_documentuploadEntity> itemList = new List<hr_documentuploadEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_documentuploadEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.GetAllhr_documentupload"));
            }	
        }
		
		IList<hr_documentuploadEntity> Ihr_documentuploadDataAccessObjects.GetAllByPages(hr_documentuploadEntity hr_documentupload)
        {
        try
            {
				const string SP = "hr_documentupload_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_documentupload.SortExpression);
                    AddPageSizeParameter(cmd, hr_documentupload.PageSize);
                    AddCurrentPageParameter(cmd, hr_documentupload.CurrentPage);                    
                    FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_documentupload, cmd,Database);

                    IList<hr_documentuploadEntity> itemList = new List<hr_documentuploadEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_documentuploadEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_documentupload.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.GetAllByPageshr_documentupload"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_documentuploadEntity Ihr_documentuploadDataAccessObjects.GetSingle(hr_documentuploadEntity hr_documentupload)
        {
           try
            {
				const string SP = "hr_documentupload_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_documentupload, cmd, Database);
                    
                    IList<hr_documentuploadEntity> itemList = new List<hr_documentuploadEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_documentuploadEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.GetSinglehr_documentupload"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_documentuploadEntity> Ihr_documentuploadDataAccessObjects.GAPgListView(hr_documentuploadEntity hr_documentupload)
        {
        try
            {
				const string SP = "hr_documentupload_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_documentupload.SortExpression);
                    AddPageSizeParameter(cmd, hr_documentupload.PageSize);
                    AddCurrentPageParameter(cmd, hr_documentupload.CurrentPage);                    
                    FillSequrityParameters(hr_documentupload.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_documentupload, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_documentupload.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_documentupload.strCommonSerachParam);

                    IList<hr_documentuploadEntity> itemList = new List<hr_documentuploadEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_documentuploadEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_documentupload.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_documentuploadDataAccess.GAPgListViewhr_documentupload"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}