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
	
	internal sealed partial class hr_bankloaninfoDataAccessObjects : BaseDataAccess, Ihr_bankloaninfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_bankloaninfoDataAccessObjects";
        
		public hr_bankloaninfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_bankloaninfoEntity hr_bankloaninfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_bankloaninfo.hrbankloanid.HasValue)
				Database.AddInParameter(cmd, "@HrBankLoanID", DbType.Int64, hr_bankloaninfo.hrbankloanid);
            if (forDelete) return;
			if (hr_bankloaninfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_bankloaninfo.hrbasicid);
			if (hr_bankloaninfo.bankid.HasValue)
				Database.AddInParameter(cmd, "@BankID", DbType.Int64, hr_bankloaninfo.bankid);
			if (hr_bankloaninfo.branchid.HasValue)
				Database.AddInParameter(cmd, "@BranchID", DbType.Int64, hr_bankloaninfo.branchid);
			if (hr_bankloaninfo.loanamount.HasValue)
				Database.AddInParameter(cmd, "@LoanAmount", DbType.Decimal, hr_bankloaninfo.loanamount);
			if ((hr_bankloaninfo.lastpaiddate.HasValue))
				Database.AddInParameter(cmd, "@LastPaidDate", DbType.DateTime, hr_bankloaninfo.lastpaiddate);
			if ((hr_bankloaninfo.islastinstallmentpaid != null))
				Database.AddInParameter(cmd, "@IsLastInstallmentPaid", DbType.Boolean, hr_bankloaninfo.islastinstallmentpaid);
			if (!(string.IsNullOrEmpty(hr_bankloaninfo.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, hr_bankloaninfo.description);
			if (!(string.IsNullOrEmpty(hr_bankloaninfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_bankloaninfo.remarks);
			if (hr_bankloaninfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_bankloaninfo.forreview);
			if ((hr_bankloaninfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_bankloaninfo.ex_date1);
			if ((hr_bankloaninfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_bankloaninfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_bankloaninfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_bankloaninfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_bankloaninfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_bankloaninfo.ex_nvarchar2);
			if (hr_bankloaninfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_bankloaninfo.ex_bigint1);
			if (hr_bankloaninfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_bankloaninfo.ex_bigint2);
			if (hr_bankloaninfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_bankloaninfo.ex_decimal1);
			if (hr_bankloaninfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_bankloaninfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_bankloaninfoDataAccessObjects.Add(hr_bankloaninfoEntity hr_bankloaninfo  )
        {
            long returnCode = -99;
            const string SP = "hr_bankloaninfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_bankloaninfo, cmd,Database);
                FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.Addhr_bankloaninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_bankloaninfoDataAccessObjects.Update(hr_bankloaninfoEntity hr_bankloaninfo )
        {
           long returnCode = -99;
            const string SP = "hr_bankloaninfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_bankloaninfo, cmd,Database);
                FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.Updatehr_bankloaninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_bankloaninfoDataAccessObjects.Delete(hr_bankloaninfoEntity hr_bankloaninfo)
        {
            long returnCode = -99;
           	const string SP = "hr_bankloaninfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_bankloaninfo, cmd,Database, true);
                FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.Deletehr_bankloaninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_bankloaninfoDataAccessObjects.SaveList(IList<hr_bankloaninfoEntity> listAdded, IList<hr_bankloaninfoEntity> listUpdated, IList<hr_bankloaninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_bankloaninfo_Ins";
            const string SPUpdate = "hr_bankloaninfo_Upd";
            const string SPDelete = "hr_bankloaninfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_bankloaninfoEntity hr_bankloaninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_bankloaninfo, cmd, Database, true);
                            FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_bankloaninfoEntity hr_bankloaninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_bankloaninfo, cmd, Database);
                            FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_bankloaninfoEntity hr_bankloaninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_bankloaninfo, cmd, Database);
                            FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.Save_hr_bankloaninfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_bankloaninfoEntity> listAdded, IList<hr_bankloaninfoEntity> listUpdated, IList<hr_bankloaninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_bankloaninfo_Ins";
            const string SPUpdate = "hr_bankloaninfo_Upd";
            const string SPDelete = "hr_bankloaninfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_bankloaninfoEntity hr_bankloaninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_bankloaninfo, cmd, db, true);
                            FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_bankloaninfoEntity hr_bankloaninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_bankloaninfo, cmd, db);
                            FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_bankloaninfoEntity hr_bankloaninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_bankloaninfo, cmd, db);
                            FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.Save_hr_bankloaninfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_bankloaninfoEntity> Ihr_bankloaninfoDataAccessObjects.GetAll(hr_bankloaninfoEntity hr_bankloaninfo)
        {
           try
            {
				const string SP = "hr_bankloaninfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_bankloaninfo.SortExpression);
                    FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_bankloaninfo, cmd, Database);
                    
                    IList<hr_bankloaninfoEntity> itemList = new List<hr_bankloaninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankloaninfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.GetAllhr_bankloaninfo"));
            }	
        }
		
		IList<hr_bankloaninfoEntity> Ihr_bankloaninfoDataAccessObjects.GetAllByPages(hr_bankloaninfoEntity hr_bankloaninfo)
        {
        try
            {
				const string SP = "hr_bankloaninfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_bankloaninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_bankloaninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_bankloaninfo.CurrentPage);                    
                    FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_bankloaninfo, cmd,Database);

                    IList<hr_bankloaninfoEntity> itemList = new List<hr_bankloaninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankloaninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_bankloaninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.GetAllByPageshr_bankloaninfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_bankloaninfoEntity Ihr_bankloaninfoDataAccessObjects.GetSingle(hr_bankloaninfoEntity hr_bankloaninfo)
        {
           try
            {
				const string SP = "hr_bankloaninfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_bankloaninfo, cmd, Database);
                    
                    IList<hr_bankloaninfoEntity> itemList = new List<hr_bankloaninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankloaninfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.GetSinglehr_bankloaninfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_bankloaninfoEntity> Ihr_bankloaninfoDataAccessObjects.GAPgListView(hr_bankloaninfoEntity hr_bankloaninfo)
        {
        try
            {
				const string SP = "hr_bankloaninfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_bankloaninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_bankloaninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_bankloaninfo.CurrentPage);                    
                    FillSequrityParameters(hr_bankloaninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_bankloaninfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_bankloaninfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_bankloaninfo.strCommonSerachParam);

                    IList<hr_bankloaninfoEntity> itemList = new List<hr_bankloaninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_bankloaninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_bankloaninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_bankloaninfoDataAccess.GAPgListViewhr_bankloaninfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}