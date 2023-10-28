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
	
	internal sealed partial class hr_rewardinfoDataAccessObjects : BaseDataAccess, Ihr_rewardinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_rewardinfoDataAccessObjects";
        
		public hr_rewardinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_rewardinfoEntity hr_rewardinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_rewardinfo.hrrewardid.HasValue)
				Database.AddInParameter(cmd, "@HrRewardID", DbType.Int64, hr_rewardinfo.hrrewardid);
            if (forDelete) return;
			if (hr_rewardinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_rewardinfo.hrbasicid);
			if ((hr_rewardinfo.rewarddate.HasValue))
				Database.AddInParameter(cmd, "@RewardDate", DbType.DateTime, hr_rewardinfo.rewarddate);
			if (!(string.IsNullOrEmpty(hr_rewardinfo.rewardevent)))
				Database.AddInParameter(cmd, "@RewardEvent", DbType.String, hr_rewardinfo.rewardevent);
			if (!(string.IsNullOrEmpty(hr_rewardinfo.reward)))
				Database.AddInParameter(cmd, "@Reward", DbType.String, hr_rewardinfo.reward);
			if (hr_rewardinfo.rewardcountryid.HasValue)
				Database.AddInParameter(cmd, "@RewardCountryID", DbType.Int64, hr_rewardinfo.rewardcountryid);
			if (!(string.IsNullOrEmpty(hr_rewardinfo.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, hr_rewardinfo.description);
			if (!(string.IsNullOrEmpty(hr_rewardinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_rewardinfo.remarks);
			if ((hr_rewardinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_rewardinfo.ex_date1);
			if ((hr_rewardinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_rewardinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_rewardinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_rewardinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_rewardinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_rewardinfo.ex_nvarchar2);
			if (hr_rewardinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_rewardinfo.ex_bigint1);
			if (hr_rewardinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_rewardinfo.ex_bigint2);
			if (hr_rewardinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_rewardinfo.ex_decimal1);
			if (hr_rewardinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_rewardinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_rewardinfoDataAccessObjects.Add(hr_rewardinfoEntity hr_rewardinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_rewardinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_rewardinfo, cmd,Database);
                FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.Addhr_rewardinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_rewardinfoDataAccessObjects.Update(hr_rewardinfoEntity hr_rewardinfo )
        {
           long returnCode = -99;
            const string SP = "hr_rewardinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_rewardinfo, cmd,Database);
                FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.Updatehr_rewardinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_rewardinfoDataAccessObjects.Delete(hr_rewardinfoEntity hr_rewardinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_rewardinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_rewardinfo, cmd,Database, true);
                FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.Deletehr_rewardinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_rewardinfoDataAccessObjects.SaveList(IList<hr_rewardinfoEntity> listAdded, IList<hr_rewardinfoEntity> listUpdated, IList<hr_rewardinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_rewardinfo_Ins";
            const string SPUpdate = "hr_rewardinfo_Upd";
            const string SPDelete = "hr_rewardinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_rewardinfoEntity hr_rewardinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_rewardinfo, cmd, Database, true);
                            FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_rewardinfoEntity hr_rewardinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_rewardinfo, cmd, Database);
                            FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_rewardinfoEntity hr_rewardinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_rewardinfo, cmd, Database);
                            FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.Save_hr_rewardinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_rewardinfoEntity> listAdded, IList<hr_rewardinfoEntity> listUpdated, IList<hr_rewardinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_rewardinfo_Ins";
            const string SPUpdate = "hr_rewardinfo_Upd";
            const string SPDelete = "hr_rewardinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_rewardinfoEntity hr_rewardinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_rewardinfo, cmd, db, true);
                            FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_rewardinfoEntity hr_rewardinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_rewardinfo, cmd, db);
                            FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_rewardinfoEntity hr_rewardinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_rewardinfo, cmd, db);
                            FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.Save_hr_rewardinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_rewardinfoEntity> Ihr_rewardinfoDataAccessObjects.GetAll(hr_rewardinfoEntity hr_rewardinfo)
        {
           try
            {
				const string SP = "hr_rewardinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_rewardinfo.SortExpression);
                    FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_rewardinfo, cmd, Database);
                    
                    IList<hr_rewardinfoEntity> itemList = new List<hr_rewardinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_rewardinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.GetAllhr_rewardinfo"));
            }	
        }
		
		IList<hr_rewardinfoEntity> Ihr_rewardinfoDataAccessObjects.GetAllByPages(hr_rewardinfoEntity hr_rewardinfo)
        {
        try
            {
				const string SP = "hr_rewardinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_rewardinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_rewardinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_rewardinfo.CurrentPage);                    
                    FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_rewardinfo, cmd,Database);

                    IList<hr_rewardinfoEntity> itemList = new List<hr_rewardinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_rewardinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_rewardinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.GetAllByPageshr_rewardinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_rewardinfoEntity Ihr_rewardinfoDataAccessObjects.GetSingle(hr_rewardinfoEntity hr_rewardinfo)
        {
           try
            {
				const string SP = "hr_rewardinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_rewardinfo, cmd, Database);
                    
                    IList<hr_rewardinfoEntity> itemList = new List<hr_rewardinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_rewardinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.GetSinglehr_rewardinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_rewardinfoEntity> Ihr_rewardinfoDataAccessObjects.GAPgListView(hr_rewardinfoEntity hr_rewardinfo)
        {
        try
            {
				const string SP = "hr_rewardinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_rewardinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_rewardinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_rewardinfo.CurrentPage);                    
                    FillSequrityParameters(hr_rewardinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_rewardinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_rewardinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_rewardinfo.strCommonSerachParam);

                    IList<hr_rewardinfoEntity> itemList = new List<hr_rewardinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_rewardinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_rewardinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_rewardinfoDataAccess.GAPgListViewhr_rewardinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}