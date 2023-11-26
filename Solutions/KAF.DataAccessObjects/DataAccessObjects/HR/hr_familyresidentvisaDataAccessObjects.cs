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
	
	internal sealed partial class hr_familyresidentvisaDataAccessObjects : BaseDataAccess, Ihr_familyresidentvisaDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_familyresidentvisaDataAccessObjects";
        
		public hr_familyresidentvisaDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_familyresidentvisaEntity hr_familyresidentvisa, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_familyresidentvisa.familyresidentid.HasValue)
				Database.AddInParameter(cmd, "@FamilyResidentID", DbType.Int64, hr_familyresidentvisa.familyresidentid);
            if (forDelete) return;
			if (hr_familyresidentvisa.hrfamilyid.HasValue)
				Database.AddInParameter(cmd, "@HrFamilyID", DbType.Int64, hr_familyresidentvisa.hrfamilyid);
			if (hr_familyresidentvisa.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicId", DbType.Int64, hr_familyresidentvisa.hrbasicid);
			if (hr_familyresidentvisa.familypassportid.HasValue)
				Database.AddInParameter(cmd, "@FamilyPassportID", DbType.Int64, hr_familyresidentvisa.familypassportid);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.residencynumber)))
				Database.AddInParameter(cmd, "@ResidencyNumber", DbType.String, hr_familyresidentvisa.residencynumber);
			if ((hr_familyresidentvisa.issuedate.HasValue))
				Database.AddInParameter(cmd, "@IssueDate", DbType.DateTime, hr_familyresidentvisa.issuedate);
			if ((hr_familyresidentvisa.expirydate.HasValue))
				Database.AddInParameter(cmd, "@ExpiryDate", DbType.DateTime, hr_familyresidentvisa.expirydate);
			if ((hr_familyresidentvisa.isfamilyvisa != null))
				Database.AddInParameter(cmd, "@IsFamilyVISA", DbType.Boolean, hr_familyresidentvisa.isfamilyvisa);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.filedescription)))
				Database.AddInParameter(cmd, "@FileDescription", DbType.String, hr_familyresidentvisa.filedescription);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.filepath)))
				Database.AddInParameter(cmd, "@FilePath", DbType.String, hr_familyresidentvisa.filepath);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.filename)))
				Database.AddInParameter(cmd, "@FileName", DbType.String, hr_familyresidentvisa.filename);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.filetype)))
				Database.AddInParameter(cmd, "@FileType", DbType.String, hr_familyresidentvisa.filetype);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.extension)))
				Database.AddInParameter(cmd, "@Extension", DbType.String, hr_familyresidentvisa.extension);
			
				Database.AddInParameter(cmd, "@FileNo", DbType.Guid, hr_familyresidentvisa.fileno);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_familyresidentvisa.remarks);
			if ((hr_familyresidentvisa.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_familyresidentvisa.ex_date1);
			if ((hr_familyresidentvisa.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_familyresidentvisa.ex_date2);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_familyresidentvisa.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_familyresidentvisa.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_familyresidentvisa.ex_nvarchar2);
			if (hr_familyresidentvisa.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_familyresidentvisa.ex_bigint1);
			if (hr_familyresidentvisa.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_familyresidentvisa.ex_bigint2);
			if (hr_familyresidentvisa.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_familyresidentvisa.ex_decimal1);
			if (hr_familyresidentvisa.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_familyresidentvisa.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_familyresidentvisaDataAccessObjects.Add(hr_familyresidentvisaEntity hr_familyresidentvisa  )
        {
            long returnCode = -99;
            const string SP = "hr_familyresidentvisa_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_familyresidentvisa, cmd,Database);
                FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.Addhr_familyresidentvisa"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_familyresidentvisaDataAccessObjects.Update(hr_familyresidentvisaEntity hr_familyresidentvisa )
        {
           long returnCode = -99;
            const string SP = "hr_familyresidentvisa_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_familyresidentvisa, cmd,Database);
                FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.Updatehr_familyresidentvisa"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_familyresidentvisaDataAccessObjects.Delete(hr_familyresidentvisaEntity hr_familyresidentvisa)
        {
            long returnCode = -99;
           	const string SP = "hr_familyresidentvisa_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_familyresidentvisa, cmd,Database, true);
                FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.Deletehr_familyresidentvisa"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_familyresidentvisaDataAccessObjects.SaveList(IList<hr_familyresidentvisaEntity> listAdded, IList<hr_familyresidentvisaEntity> listUpdated, IList<hr_familyresidentvisaEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familyresidentvisa_Ins";
            const string SPUpdate = "hr_familyresidentvisa_Upd";
            const string SPDelete = "hr_familyresidentvisa_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familyresidentvisaEntity hr_familyresidentvisa in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familyresidentvisa, cmd, Database, true);
                            FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familyresidentvisaEntity hr_familyresidentvisa in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familyresidentvisa, cmd, Database);
                            FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familyresidentvisaEntity hr_familyresidentvisa in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familyresidentvisa, cmd, Database);
                            FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.Save_hr_familyresidentvisa"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_familyresidentvisaEntity> listAdded, IList<hr_familyresidentvisaEntity> listUpdated, IList<hr_familyresidentvisaEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familyresidentvisa_Ins";
            const string SPUpdate = "hr_familyresidentvisa_Upd";
            const string SPDelete = "hr_familyresidentvisa_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familyresidentvisaEntity hr_familyresidentvisa in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familyresidentvisa, cmd, db, true);
                            FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familyresidentvisaEntity hr_familyresidentvisa in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familyresidentvisa, cmd, db);
                            FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familyresidentvisaEntity hr_familyresidentvisa in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familyresidentvisa, cmd, db);
                            FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.Save_hr_familyresidentvisa"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaDataAccessObjects.GetAll(hr_familyresidentvisaEntity hr_familyresidentvisa)
        {
           try
            {
				const string SP = "hr_familyresidentvisa_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_familyresidentvisa.SortExpression);
                    FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familyresidentvisa, cmd, Database);
                    
                    IList<hr_familyresidentvisaEntity> itemList = new List<hr_familyresidentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyresidentvisaEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.GetAllhr_familyresidentvisa"));
            }	
        }
		
		IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaDataAccessObjects.GetAllByPages(hr_familyresidentvisaEntity hr_familyresidentvisa)
        {
        try
            {
				const string SP = "hr_familyresidentvisa_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familyresidentvisa.SortExpression);
                    AddPageSizeParameter(cmd, hr_familyresidentvisa.PageSize);
                    AddCurrentPageParameter(cmd, hr_familyresidentvisa.CurrentPage);                    
                    FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familyresidentvisa, cmd,Database);

                    IList<hr_familyresidentvisaEntity> itemList = new List<hr_familyresidentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyresidentvisaEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familyresidentvisa.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.GetAllByPageshr_familyresidentvisa"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_familyresidentvisaEntity Ihr_familyresidentvisaDataAccessObjects.GetSingle(hr_familyresidentvisaEntity hr_familyresidentvisa)
        {
           try
            {
				const string SP = "hr_familyresidentvisa_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familyresidentvisa, cmd, Database);
                    
                    IList<hr_familyresidentvisaEntity> itemList = new List<hr_familyresidentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyresidentvisaEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.GetSinglehr_familyresidentvisa"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaDataAccessObjects.GAPgListView(hr_familyresidentvisaEntity hr_familyresidentvisa)
        {
        try
            {
				const string SP = "hr_familyresidentvisa_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familyresidentvisa.SortExpression);
                    AddPageSizeParameter(cmd, hr_familyresidentvisa.PageSize);
                    AddCurrentPageParameter(cmd, hr_familyresidentvisa.CurrentPage);                    
                    FillSequrityParameters(hr_familyresidentvisa.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familyresidentvisa, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_familyresidentvisa.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_familyresidentvisa.strCommonSerachParam);

                    IList<hr_familyresidentvisaEntity> itemList = new List<hr_familyresidentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyresidentvisaEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familyresidentvisa.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyresidentvisaDataAccess.GAPgListViewhr_familyresidentvisa"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}