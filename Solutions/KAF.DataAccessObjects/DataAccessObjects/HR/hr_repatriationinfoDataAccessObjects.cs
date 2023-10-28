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
	
	internal sealed partial class hr_repatriationinfoDataAccessObjects : BaseDataAccess, Ihr_repatriationinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_repatriationinfoDataAccessObjects";
        
		public hr_repatriationinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_repatriationinfoEntity hr_repatriationinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_repatriationinfo.repatriationid.HasValue)
				Database.AddInParameter(cmd, "@RepatriationID", DbType.Int64, hr_repatriationinfo.repatriationid);
            if (forDelete) return;
			if (hr_repatriationinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_repatriationinfo.hrbasicid);
			if (hr_repatriationinfo.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_repatriationinfo.hrsvcid);
			if ((hr_repatriationinfo.soddate.HasValue))
				Database.AddInParameter(cmd, "@SODDate", DbType.DateTime, hr_repatriationinfo.soddate);
			if ((hr_repatriationinfo.flightdate.HasValue))
				Database.AddInParameter(cmd, "@FlightDate", DbType.DateTime, hr_repatriationinfo.flightdate);
			if ((hr_repatriationinfo.salaryreceivedtilldate.HasValue))
				Database.AddInParameter(cmd, "@SalaryReceivedTillDate", DbType.DateTime, hr_repatriationinfo.salaryreceivedtilldate);
			if ((hr_repatriationinfo.rewardavaildate.HasValue))
				Database.AddInParameter(cmd, "@RewardAvailDate", DbType.DateTime, hr_repatriationinfo.rewardavaildate);
			if ((hr_repatriationinfo.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_repatriationinfo.letterdate);
			if (!(string.IsNullOrEmpty(hr_repatriationinfo.letterno)))
				Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_repatriationinfo.letterno);
			if (!(string.IsNullOrEmpty(hr_repatriationinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_repatriationinfo.remarks);
			if ((hr_repatriationinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_repatriationinfo.ex_date1);
			if ((hr_repatriationinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_repatriationinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_repatriationinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_repatriationinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_repatriationinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_repatriationinfo.ex_nvarchar2);
			if (hr_repatriationinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_repatriationinfo.ex_bigint1);
			if (hr_repatriationinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_repatriationinfo.ex_bigint2);
			if (hr_repatriationinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_repatriationinfo.ex_decimal1);
			if (hr_repatriationinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_repatriationinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_repatriationinfoDataAccessObjects.Add(hr_repatriationinfoEntity hr_repatriationinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_repatriationinfo_Ins_Ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_repatriationinfo, cmd,Database);
                FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.Addhr_repatriationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_repatriationinfoDataAccessObjects.Update(hr_repatriationinfoEntity hr_repatriationinfo )
        {
           long returnCode = -99;
            const string SP = "hr_repatriationinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_repatriationinfo, cmd,Database);
                FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.Updatehr_repatriationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_repatriationinfoDataAccessObjects.Delete(hr_repatriationinfoEntity hr_repatriationinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_repatriationinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_repatriationinfo, cmd,Database, true);
                FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.Deletehr_repatriationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_repatriationinfoDataAccessObjects.SaveList(IList<hr_repatriationinfoEntity> listAdded, IList<hr_repatriationinfoEntity> listUpdated, IList<hr_repatriationinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_repatriationinfo_Ins";
            const string SPUpdate = "hr_repatriationinfo_Upd";
            const string SPDelete = "hr_repatriationinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_repatriationinfoEntity hr_repatriationinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_repatriationinfo, cmd, Database, true);
                            FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_repatriationinfoEntity hr_repatriationinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_repatriationinfo, cmd, Database);
                            FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_repatriationinfoEntity hr_repatriationinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_repatriationinfo, cmd, Database);
                            FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.Save_hr_repatriationinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_repatriationinfoEntity> listAdded, IList<hr_repatriationinfoEntity> listUpdated, IList<hr_repatriationinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_repatriationinfo_Ins";
            const string SPUpdate = "hr_repatriationinfo_Upd";
            const string SPDelete = "hr_repatriationinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_repatriationinfoEntity hr_repatriationinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_repatriationinfo, cmd, db, true);
                            FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_repatriationinfoEntity hr_repatriationinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_repatriationinfo, cmd, db);
                            FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_repatriationinfoEntity hr_repatriationinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_repatriationinfo, cmd, db);
                            FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.Save_hr_repatriationinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_repatriationinfoEntity> Ihr_repatriationinfoDataAccessObjects.GetAll(hr_repatriationinfoEntity hr_repatriationinfo)
        {
           try
            {
				const string SP = "hr_repatriationinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_repatriationinfo.SortExpression);
                    FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_repatriationinfo, cmd, Database);
                    
                    IList<hr_repatriationinfoEntity> itemList = new List<hr_repatriationinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_repatriationinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.GetAllhr_repatriationinfo"));
            }	
        }
		
		IList<hr_repatriationinfoEntity> Ihr_repatriationinfoDataAccessObjects.GetAllByPages(hr_repatriationinfoEntity hr_repatriationinfo)
        {
        try
            {
				const string SP = "hr_repatriationinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_repatriationinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_repatriationinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_repatriationinfo.CurrentPage);                    
                    FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_repatriationinfo, cmd,Database);

                    IList<hr_repatriationinfoEntity> itemList = new List<hr_repatriationinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_repatriationinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_repatriationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.GetAllByPageshr_repatriationinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_repatriationinfoEntity Ihr_repatriationinfoDataAccessObjects.GetSingle(hr_repatriationinfoEntity hr_repatriationinfo)
        {
           try
            {
				const string SP = "hr_repatriationinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_repatriationinfo, cmd, Database);
                    
                    IList<hr_repatriationinfoEntity> itemList = new List<hr_repatriationinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_repatriationinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.GetSinglehr_repatriationinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_repatriationinfoEntity> Ihr_repatriationinfoDataAccessObjects.GAPgListView(hr_repatriationinfoEntity hr_repatriationinfo)
        {
        try
            {
				const string SP = "hr_repatriationinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_repatriationinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_repatriationinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_repatriationinfo.CurrentPage);                    
                    FillSequrityParameters(hr_repatriationinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_repatriationinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_repatriationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_repatriationinfo.strCommonSerachParam);

                    IList<hr_repatriationinfoEntity> itemList = new List<hr_repatriationinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_repatriationinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_repatriationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_repatriationinfoDataAccess.GAPgListViewhr_repatriationinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}