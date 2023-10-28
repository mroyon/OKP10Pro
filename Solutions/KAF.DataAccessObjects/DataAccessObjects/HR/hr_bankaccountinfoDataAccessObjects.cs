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
	
	internal sealed partial class hr_bankaccountinfoDataAccessObjects : BaseDataAccess, Ihr_bankaccountinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_bankaccountinfoDataAccessObjects";
        
		public hr_bankaccountinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_bankaccountinfoEntity hr_bankaccountinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_bankaccountinfo.hrbankaccountid.HasValue)
				Database.AddInParameter(cmd, "@HrBankAccountID", DbType.Int64, hr_bankaccountinfo.hrbankaccountid);
            if (forDelete) return;
			if (hr_bankaccountinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_bankaccountinfo.hrbasicid);
			if (hr_bankaccountinfo.bankid.HasValue)
				Database.AddInParameter(cmd, "@BankID", DbType.Int64, hr_bankaccountinfo.bankid);
			if (hr_bankaccountinfo.branchid.HasValue)
				Database.AddInParameter(cmd, "@BranchID", DbType.Int64, hr_bankaccountinfo.branchid);
			if (!(string.IsNullOrEmpty(hr_bankaccountinfo.accountno)))
				Database.AddInParameter(cmd, "@AccountNo", DbType.String, hr_bankaccountinfo.accountno);
			if (!(string.IsNullOrEmpty(hr_bankaccountinfo.accountname)))
				Database.AddInParameter(cmd, "@AccountName", DbType.String, hr_bankaccountinfo.accountname);
			if (!(string.IsNullOrEmpty(hr_bankaccountinfo.accountdescription)))
				Database.AddInParameter(cmd, "@AccountDescription", DbType.String, hr_bankaccountinfo.accountdescription);
			if (!(string.IsNullOrEmpty(hr_bankaccountinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_bankaccountinfo.remarks);
			if (hr_bankaccountinfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_bankaccountinfo.forreview);
			if ((hr_bankaccountinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_bankaccountinfo.ex_date1);
			if ((hr_bankaccountinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_bankaccountinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_bankaccountinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_bankaccountinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_bankaccountinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_bankaccountinfo.ex_nvarchar2);
			if (hr_bankaccountinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_bankaccountinfo.ex_bigint1);
			if (hr_bankaccountinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_bankaccountinfo.ex_bigint2);
			if (hr_bankaccountinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_bankaccountinfo.ex_decimal1);
			if (hr_bankaccountinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_bankaccountinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_bankaccountinfoDataAccessObjects.Add(hr_bankaccountinfoEntity hr_bankaccountinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_bankaccountinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_bankaccountinfo, cmd,Database);
                FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.Addhr_bankaccountinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_bankaccountinfoDataAccessObjects.Update(hr_bankaccountinfoEntity hr_bankaccountinfo )
        {
           long returnCode = -99;
            const string SP = "hr_bankaccountinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_bankaccountinfo, cmd,Database);
                FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.Updatehr_bankaccountinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_bankaccountinfoDataAccessObjects.Delete(hr_bankaccountinfoEntity hr_bankaccountinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_bankaccountinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_bankaccountinfo, cmd,Database, true);
                FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.Deletehr_bankaccountinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_bankaccountinfoDataAccessObjects.SaveList(IList<hr_bankaccountinfoEntity> listAdded, IList<hr_bankaccountinfoEntity> listUpdated, IList<hr_bankaccountinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_bankaccountinfo_Ins";
            const string SPUpdate = "hr_bankaccountinfo_Upd";
            const string SPDelete = "hr_bankaccountinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_bankaccountinfoEntity hr_bankaccountinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_bankaccountinfo, cmd, Database, true);
                            FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_bankaccountinfoEntity hr_bankaccountinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_bankaccountinfo, cmd, Database);
                            FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_bankaccountinfoEntity hr_bankaccountinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_bankaccountinfo, cmd, Database);
                            FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.Save_hr_bankaccountinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_bankaccountinfoEntity> listAdded, IList<hr_bankaccountinfoEntity> listUpdated, IList<hr_bankaccountinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_bankaccountinfo_Ins";
            const string SPUpdate = "hr_bankaccountinfo_Upd";
            const string SPDelete = "hr_bankaccountinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_bankaccountinfoEntity hr_bankaccountinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_bankaccountinfo, cmd, db, true);
                            FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_bankaccountinfoEntity hr_bankaccountinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_bankaccountinfo, cmd, db);
                            FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_bankaccountinfoEntity hr_bankaccountinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_bankaccountinfo, cmd, db);
                            FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.Save_hr_bankaccountinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoDataAccessObjects.GetAll(hr_bankaccountinfoEntity hr_bankaccountinfo)
        {
           try
            {
				const string SP = "hr_bankaccountinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_bankaccountinfo.SortExpression);
                    FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_bankaccountinfo, cmd, Database);
                    
                    IList<hr_bankaccountinfoEntity> itemList = new List<hr_bankaccountinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankaccountinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.GetAllhr_bankaccountinfo"));
            }	
        }
		
		IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoDataAccessObjects.GetAllByPages(hr_bankaccountinfoEntity hr_bankaccountinfo)
        {
        try
            {
				const string SP = "hr_bankaccountinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_bankaccountinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_bankaccountinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_bankaccountinfo.CurrentPage);                    
                    FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_bankaccountinfo, cmd,Database);

                    IList<hr_bankaccountinfoEntity> itemList = new List<hr_bankaccountinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankaccountinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_bankaccountinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.GetAllByPageshr_bankaccountinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_bankaccountinfoEntity Ihr_bankaccountinfoDataAccessObjects.GetSingle(hr_bankaccountinfoEntity hr_bankaccountinfo)
        {
           try
            {
				const string SP = "hr_bankaccountinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_bankaccountinfo, cmd, Database);
                    
                    IList<hr_bankaccountinfoEntity> itemList = new List<hr_bankaccountinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankaccountinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.GetSinglehr_bankaccountinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoDataAccessObjects.GAPgListView(hr_bankaccountinfoEntity hr_bankaccountinfo)
        {
        try
            {
				const string SP = "hr_bankaccountinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_bankaccountinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_bankaccountinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_bankaccountinfo.CurrentPage);                    
                    FillSequrityParameters(hr_bankaccountinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_bankaccountinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_bankaccountinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_bankaccountinfo.strCommonSerachParam);

                    IList<hr_bankaccountinfoEntity> itemList = new List<hr_bankaccountinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankaccountinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_bankaccountinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankaccountinfoDataAccess.GAPgListViewhr_bankaccountinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}