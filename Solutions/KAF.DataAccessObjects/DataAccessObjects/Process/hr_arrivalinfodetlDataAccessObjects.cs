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
	
	internal sealed partial class hr_arrivalinfodetlDataAccessObjects : BaseDataAccess, Ihr_arrivalinfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_arrivalinfodetlDataAccessObjects";
        
		public hr_arrivalinfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_arrivalinfodetlEntity hr_arrivalinfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_arrivalinfodetl.arrivaldetlld.HasValue)
				Database.AddInParameter(cmd, "@ArrivalDetllD", DbType.Int64, hr_arrivalinfodetl.arrivaldetlld);
            if (forDelete) return;
			if (hr_arrivalinfodetl.arrivalld.HasValue)
				Database.AddInParameter(cmd, "@ArrivallD", DbType.Int64, hr_arrivalinfodetl.arrivalld);
			if (hr_arrivalinfodetl.flightdetlid.HasValue)
				Database.AddInParameter(cmd, "@FlightDetlID", DbType.Int64, hr_arrivalinfodetl.flightdetlid);
			if (hr_arrivalinfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_arrivalinfodetl.hrbasicid);
			if (hr_arrivalinfodetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_arrivalinfodetl.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_arrivalinfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_arrivalinfodetl.remarks);
			if ((hr_arrivalinfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_arrivalinfodetl.ex_date1);
			if ((hr_arrivalinfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_arrivalinfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_arrivalinfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_arrivalinfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_arrivalinfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_arrivalinfodetl.ex_nvarchar2);
			if (hr_arrivalinfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_arrivalinfodetl.ex_bigint1);
			if (hr_arrivalinfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_arrivalinfodetl.ex_bigint2);
			if (hr_arrivalinfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_arrivalinfodetl.ex_decimal1);
			if (hr_arrivalinfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_arrivalinfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_arrivalinfodetlDataAccessObjects.Add(hr_arrivalinfodetlEntity hr_arrivalinfodetl  )
        {
            long returnCode = -99;
            const string SP = "hr_arrivalinfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_arrivalinfodetl, cmd,Database);
                FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.Addhr_arrivalinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_arrivalinfodetlDataAccessObjects.Update(hr_arrivalinfodetlEntity hr_arrivalinfodetl )
        {
           long returnCode = -99;
            const string SP = "hr_arrivalinfodetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_arrivalinfodetl, cmd,Database);
                FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.Updatehr_arrivalinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_arrivalinfodetlDataAccessObjects.Delete(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
        {
            long returnCode = -99;
           	const string SP = "hr_arrivalinfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_arrivalinfodetl, cmd,Database, true);
                FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.Deletehr_arrivalinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_arrivalinfodetlDataAccessObjects.SaveList(IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_arrivalinfodetl_Ins";
            const string SPUpdate = "hr_arrivalinfodetl_Upd";
            const string SPDelete = "hr_arrivalinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_arrivalinfodetlEntity hr_arrivalinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_arrivalinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_arrivalinfodetlEntity hr_arrivalinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_arrivalinfodetl, cmd, Database);
                            FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_arrivalinfodetlEntity hr_arrivalinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_arrivalinfodetl, cmd, Database);
                            FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.Save_hr_arrivalinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_arrivalinfodetl_Ins";
            const string SPUpdate = "hr_arrivalinfodetl_Upd";
            const string SPDelete = "hr_arrivalinfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_arrivalinfodetlEntity hr_arrivalinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_arrivalinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_arrivalinfodetlEntity hr_arrivalinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_arrivalinfodetl, cmd, db);
                            FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_arrivalinfodetlEntity hr_arrivalinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_arrivalinfodetl, cmd, db);
                            FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.Save_hr_arrivalinfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlDataAccessObjects.GetAll(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
        {
           try
            {
				const string SP = "hr_arrivalinfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_arrivalinfodetl.SortExpression);
                    FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_arrivalinfodetl, cmd, Database);
                    
                    IList<hr_arrivalinfodetlEntity> itemList = new List<hr_arrivalinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.GetAllhr_arrivalinfodetl"));
            }	
        }
		
		IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlDataAccessObjects.GetAllByPages(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
        {
        try
            {
				const string SP = "hr_arrivalinfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_arrivalinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_arrivalinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_arrivalinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_arrivalinfodetl, cmd,Database);

                    IList<hr_arrivalinfodetlEntity> itemList = new List<hr_arrivalinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_arrivalinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.GetAllByPageshr_arrivalinfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_arrivalinfodetlEntity Ihr_arrivalinfodetlDataAccessObjects.GetSingle(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
        {
           try
            {
				const string SP = "hr_arrivalinfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_arrivalinfodetl, cmd, Database);
                    
                    IList<hr_arrivalinfodetlEntity> itemList = new List<hr_arrivalinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.GetSinglehr_arrivalinfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlDataAccessObjects.GAPgListView(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
        {
        try
            {
				const string SP = "hr_arrivalinfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_arrivalinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_arrivalinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_arrivalinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_arrivalinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_arrivalinfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_arrivalinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_arrivalinfodetl.strCommonSerachParam);

                    IList<hr_arrivalinfodetlEntity> itemList = new List<hr_arrivalinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_arrivalinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfodetlDataAccess.GAPgListViewhr_arrivalinfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}