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
	
	internal sealed partial class hr_basicfileDataAccessObjects : BaseDataAccess, Ihr_basicfileDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_basicfileDataAccessObjects";
        
		public hr_basicfileDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_basicfileEntity hr_basicfile, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_basicfile.fileuploadid.HasValue)
				Database.AddInParameter(cmd, "@FileUploadID", DbType.Int64, hr_basicfile.fileuploadid);
            if (forDelete) return;
			if (hr_basicfile.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HRBasicID", DbType.Int64, hr_basicfile.hrbasicid);
			if (hr_basicfile.filetypeid.HasValue)
				Database.AddInParameter(cmd, "@FileTypeID", DbType.Int64, hr_basicfile.filetypeid);
			if (!(string.IsNullOrEmpty(hr_basicfile.filedescription)))
				Database.AddInParameter(cmd, "@FileDescription", DbType.String, hr_basicfile.filedescription);
			if (!(string.IsNullOrEmpty(hr_basicfile.filepath)))
				Database.AddInParameter(cmd, "@FilePath", DbType.String, hr_basicfile.filepath);
			if (!(string.IsNullOrEmpty(hr_basicfile.filename)))
				Database.AddInParameter(cmd, "@FileName", DbType.String, hr_basicfile.filename);
			if (!(string.IsNullOrEmpty(hr_basicfile.filetype)))
				Database.AddInParameter(cmd, "@FileType", DbType.String, hr_basicfile.filetype);
			if (!(string.IsNullOrEmpty(hr_basicfile.extension)))
				Database.AddInParameter(cmd, "@Extension", DbType.String, hr_basicfile.extension);
			if (!(string.IsNullOrEmpty(hr_basicfile.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_basicfile.remarks);
			if ((hr_basicfile.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_basicfile.ex_date1);
			if ((hr_basicfile.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_basicfile.ex_date2);
			if (!(string.IsNullOrEmpty(hr_basicfile.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_basicfile.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_basicfile.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_basicfile.ex_nvarchar2);
			if (hr_basicfile.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_basicfile.ex_bigint1);
			if (hr_basicfile.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_basicfile.ex_bigint2);
			if (hr_basicfile.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_basicfile.ex_decimal1);
			if (hr_basicfile.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_basicfile.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_basicfileDataAccessObjects.Add(hr_basicfileEntity hr_basicfile  )
        {
            long returnCode = -99;
            const string SP = "hr_basicfile_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_basicfile, cmd,Database);
                FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.Addhr_basicfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_basicfileDataAccessObjects.Update(hr_basicfileEntity hr_basicfile )
        {
           long returnCode = -99;
            const string SP = "hr_basicfile_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_basicfile, cmd,Database);
                FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.Updatehr_basicfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_basicfileDataAccessObjects.Delete(hr_basicfileEntity hr_basicfile)
        {
            long returnCode = -99;
           	const string SP = "hr_basicfile_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_basicfile, cmd,Database, true);
                FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.Deletehr_basicfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_basicfileDataAccessObjects.SaveList(IList<hr_basicfileEntity> listAdded, IList<hr_basicfileEntity> listUpdated, IList<hr_basicfileEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_basicfile_Ins";
            const string SPUpdate = "hr_basicfile_Upd";
            const string SPDelete = "hr_basicfile_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_basicfileEntity hr_basicfile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_basicfile, cmd, Database, true);
                            FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_basicfileEntity hr_basicfile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_basicfile, cmd, Database);
                            FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_basicfileEntity hr_basicfile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_basicfile, cmd, Database);
                            FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.Save_hr_basicfile"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_basicfileEntity> listAdded, IList<hr_basicfileEntity> listUpdated, IList<hr_basicfileEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_basicfile_Ins";
            const string SPUpdate = "hr_basicfile_Upd";
            const string SPDelete = "hr_basicfile_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_basicfileEntity hr_basicfile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_basicfile, cmd, db, true);
                            FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, db);
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
                    foreach (hr_basicfileEntity hr_basicfile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_basicfile, cmd, db);
                            FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, db);
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
                    foreach (hr_basicfileEntity hr_basicfile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_basicfile, cmd, db);
                            FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.Save_hr_basicfile"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_basicfileEntity> Ihr_basicfileDataAccessObjects.GetAll(hr_basicfileEntity hr_basicfile)
        {
           try
            {
				const string SP = "hr_basicfile_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_basicfile.SortExpression);
                    FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_basicfile, cmd, Database);
                    
                    IList<hr_basicfileEntity> itemList = new List<hr_basicfileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicfileEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.GetAllhr_basicfile"));
            }	
        }
		
		IList<hr_basicfileEntity> Ihr_basicfileDataAccessObjects.GetAllByPages(hr_basicfileEntity hr_basicfile)
        {
        try
            {
				const string SP = "hr_basicfile_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_basicfile.SortExpression);
                    AddPageSizeParameter(cmd, hr_basicfile.PageSize);
                    AddCurrentPageParameter(cmd, hr_basicfile.CurrentPage);                    
                    FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_basicfile, cmd,Database);

                    IList<hr_basicfileEntity> itemList = new List<hr_basicfileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicfileEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_basicfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.GetAllByPageshr_basicfile"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_basicfileEntity Ihr_basicfileDataAccessObjects.GetSingle(hr_basicfileEntity hr_basicfile)
        {
           try
            {
				const string SP = "hr_basicfile_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_basicfile, cmd, Database);
                    
                    IList<hr_basicfileEntity> itemList = new List<hr_basicfileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicfileEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.GetSinglehr_basicfile"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_basicfileEntity> Ihr_basicfileDataAccessObjects.GAPgListView(hr_basicfileEntity hr_basicfile)
        {
        try
            {
				const string SP = "hr_basicfile_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_basicfile.SortExpression);
                    AddPageSizeParameter(cmd, hr_basicfile.PageSize);
                    AddCurrentPageParameter(cmd, hr_basicfile.CurrentPage);                    
                    FillSequrityParameters(hr_basicfile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_basicfile, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_basicfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_basicfile.strCommonSerachParam);

                    IList<hr_basicfileEntity> itemList = new List<hr_basicfileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicfileEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_basicfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicfileDataAccess.GAPgListViewhr_basicfile"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}