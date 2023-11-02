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
	
	internal sealed partial class hr_residentvisaDataAccessObjects : BaseDataAccess, Ihr_residentvisaDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_residentvisaDataAccessObjects";
        
		public hr_residentvisaDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_residentvisaEntity hr_residentvisa, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_residentvisa.residentid.HasValue)
				Database.AddInParameter(cmd, "@ResidentID", DbType.Int64, hr_residentvisa.residentid);
            if (forDelete) return;
			if (hr_residentvisa.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicId", DbType.Int64, hr_residentvisa.hrbasicid);
			if (hr_residentvisa.passportid.HasValue)
				Database.AddInParameter(cmd, "@PassportID", DbType.Int64, hr_residentvisa.passportid);
			if (!(string.IsNullOrEmpty(hr_residentvisa.residencynumber)))
				Database.AddInParameter(cmd, "@ResidencyNumber", DbType.String, hr_residentvisa.residencynumber);
			if ((hr_residentvisa.issuedate.HasValue))
				Database.AddInParameter(cmd, "@IssueDate", DbType.DateTime, hr_residentvisa.issuedate);
			if ((hr_residentvisa.expirydate.HasValue))
				Database.AddInParameter(cmd, "@ExpiryDate", DbType.DateTime, hr_residentvisa.expirydate);
			if ((hr_residentvisa.isfamilyvisa != null))
				Database.AddInParameter(cmd, "@IsFamilyVISA", DbType.Boolean, hr_residentvisa.isfamilyvisa);
			if (!(string.IsNullOrEmpty(hr_residentvisa.filedescription)))
				Database.AddInParameter(cmd, "@FileDescription", DbType.String, hr_residentvisa.filedescription);
			if (!(string.IsNullOrEmpty(hr_residentvisa.filepath)))
				Database.AddInParameter(cmd, "@FilePath", DbType.String, hr_residentvisa.filepath);
			if (!(string.IsNullOrEmpty(hr_residentvisa.filename)))
				Database.AddInParameter(cmd, "@FileName", DbType.String, hr_residentvisa.filename);
			if (!(string.IsNullOrEmpty(hr_residentvisa.filetype)))
				Database.AddInParameter(cmd, "@FileType", DbType.String, hr_residentvisa.filetype);
			if (!(string.IsNullOrEmpty(hr_residentvisa.extension)))
				Database.AddInParameter(cmd, "@Extension", DbType.String, hr_residentvisa.extension);
			
				Database.AddInParameter(cmd, "@FileNo", DbType.Guid, hr_residentvisa.fileno);
			if (!(string.IsNullOrEmpty(hr_residentvisa.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_residentvisa.remarks);
			if ((hr_residentvisa.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_residentvisa.ex_date1);
			if ((hr_residentvisa.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_residentvisa.ex_date2);
			if (!(string.IsNullOrEmpty(hr_residentvisa.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_residentvisa.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_residentvisa.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_residentvisa.ex_nvarchar2);
			if (hr_residentvisa.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_residentvisa.ex_bigint1);
			if (hr_residentvisa.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_residentvisa.ex_bigint2);
			if (hr_residentvisa.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_residentvisa.ex_decimal1);
			if (hr_residentvisa.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_residentvisa.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_residentvisaDataAccessObjects.Add(hr_residentvisaEntity hr_residentvisa  )
        {
            long returnCode = -99;
            const string SP = "hr_residentvisa_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_residentvisa, cmd,Database);
                FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.Addhr_residentvisa"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_residentvisaDataAccessObjects.Update(hr_residentvisaEntity hr_residentvisa )
        {
           long returnCode = -99;
            const string SP = "hr_residentvisa_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_residentvisa, cmd,Database);
                FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.Updatehr_residentvisa"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_residentvisaDataAccessObjects.Delete(hr_residentvisaEntity hr_residentvisa)
        {
            long returnCode = -99;
           	const string SP = "hr_residentvisa_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_residentvisa, cmd,Database, true);
                FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.Deletehr_residentvisa"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_residentvisaDataAccessObjects.SaveList(IList<hr_residentvisaEntity> listAdded, IList<hr_residentvisaEntity> listUpdated, IList<hr_residentvisaEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_residentvisa_Ins";
            const string SPUpdate = "hr_residentvisa_Upd";
            const string SPDelete = "hr_residentvisa_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_residentvisaEntity hr_residentvisa in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_residentvisa, cmd, Database, true);
                            FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_residentvisaEntity hr_residentvisa in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_residentvisa, cmd, Database);
                            FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_residentvisaEntity hr_residentvisa in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_residentvisa, cmd, Database);
                            FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.Save_hr_residentvisa"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_residentvisaEntity> listAdded, IList<hr_residentvisaEntity> listUpdated, IList<hr_residentvisaEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_residentvisa_Ins";
            const string SPUpdate = "hr_residentvisa_Upd";
            const string SPDelete = "hr_residentvisa_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_residentvisaEntity hr_residentvisa in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_residentvisa, cmd, db, true);
                            FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, db);
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
                    foreach (hr_residentvisaEntity hr_residentvisa in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_residentvisa, cmd, db);
                            FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, db);
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
                    foreach (hr_residentvisaEntity hr_residentvisa in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_residentvisa, cmd, db);
                            FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.Save_hr_residentvisa"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_residentvisaEntity> Ihr_residentvisaDataAccessObjects.GetAll(hr_residentvisaEntity hr_residentvisa)
        {
           try
            {
				const string SP = "hr_residentvisa_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_residentvisa.SortExpression);
                    FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_residentvisa, cmd, Database);
                    
                    IList<hr_residentvisaEntity> itemList = new List<hr_residentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            var obj = new hr_residentvisaEntity(reader);
                            if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) obj.militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));

                            itemList.Add(obj);
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.GetAllhr_residentvisa"));
            }	
        }
		
		IList<hr_residentvisaEntity> Ihr_residentvisaDataAccessObjects.GetAllByPages(hr_residentvisaEntity hr_residentvisa)
        {
        try
            {
				const string SP = "hr_residentvisa_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_residentvisa.SortExpression);
                    AddPageSizeParameter(cmd, hr_residentvisa.PageSize);
                    AddCurrentPageParameter(cmd, hr_residentvisa.CurrentPage);                    
                    FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_residentvisa, cmd,Database);

                    IList<hr_residentvisaEntity> itemList = new List<hr_residentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_residentvisaEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_residentvisa.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.GetAllByPageshr_residentvisa"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_residentvisaEntity Ihr_residentvisaDataAccessObjects.GetSingle(hr_residentvisaEntity hr_residentvisa)
        {
           try
            {
				const string SP = "hr_residentvisa_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_residentvisa, cmd, Database);
                    
                    IList<hr_residentvisaEntity> itemList = new List<hr_residentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_residentvisaEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.GetSinglehr_residentvisa"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_residentvisaEntity> Ihr_residentvisaDataAccessObjects.GAPgListView(hr_residentvisaEntity hr_residentvisa)
        {
        try
            {
				const string SP = "hr_residentvisa_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_residentvisa.SortExpression);
                    AddPageSizeParameter(cmd, hr_residentvisa.PageSize);
                    AddCurrentPageParameter(cmd, hr_residentvisa.CurrentPage);                    
                    FillSequrityParameters(hr_residentvisa.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_residentvisa, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_residentvisa.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_residentvisa.strCommonSerachParam);

                    IList<hr_residentvisaEntity> itemList = new List<hr_residentvisaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_residentvisaEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_residentvisa.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_residentvisaDataAccess.GAPgListViewhr_residentvisa"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}