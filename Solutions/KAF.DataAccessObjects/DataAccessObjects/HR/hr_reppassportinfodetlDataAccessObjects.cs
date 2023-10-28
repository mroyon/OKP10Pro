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
	
	internal sealed partial class hr_reppassportinfodetlDataAccessObjects : BaseDataAccess, Ihr_reppassportinfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_reppassportinfodetlDataAccessObjects";
        
		public hr_reppassportinfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_reppassportinfodetlEntity hr_reppassportinfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_reppassportinfodetl.reppassportdetlid.HasValue)
				Database.AddInParameter(cmd, "@RepPassportDetlID", DbType.Int64, hr_reppassportinfodetl.reppassportdetlid);
            if (forDelete) return;
			if (hr_reppassportinfodetl.reppassportid.HasValue)
				Database.AddInParameter(cmd, "@RepPassportID", DbType.Int64, hr_reppassportinfodetl.reppassportid);
			if (hr_reppassportinfodetl.replacementdetlid.HasValue)
				Database.AddInParameter(cmd, "@ReplacementDetlID", DbType.Int64, hr_reppassportinfodetl.replacementdetlid);
			if (hr_reppassportinfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_reppassportinfodetl.hrbasicid);
			if (hr_reppassportinfodetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_reppassportinfodetl.hrsvcid);
			if (hr_reppassportinfodetl.newhrbasicid.HasValue)
				Database.AddInParameter(cmd, "@NewHrBasicID", DbType.Int64, hr_reppassportinfodetl.newhrbasicid);
			if (hr_reppassportinfodetl.newhrsvcid.HasValue)
				Database.AddInParameter(cmd, "@NewHrSvcID", DbType.Int64, hr_reppassportinfodetl.newhrsvcid);
			if (!(string.IsNullOrEmpty(hr_reppassportinfodetl.newpassportno)))
				Database.AddInParameter(cmd, "@NewPassportNo", DbType.String, hr_reppassportinfodetl.newpassportno);
			if (!(string.IsNullOrEmpty(hr_reppassportinfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_reppassportinfodetl.remarks);
			if ((hr_reppassportinfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_reppassportinfodetl.ex_date1);
			if ((hr_reppassportinfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_reppassportinfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(hr_reppassportinfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_reppassportinfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_reppassportinfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_reppassportinfodetl.ex_nvarchar2);
			if (hr_reppassportinfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_reppassportinfodetl.ex_bigint1);
			if (hr_reppassportinfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_reppassportinfodetl.ex_bigint2);
			if (hr_reppassportinfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_reppassportinfodetl.ex_decimal1);
			if (hr_reppassportinfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_reppassportinfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_reppassportinfodetlDataAccessObjects.Add(hr_reppassportinfodetlEntity hr_reppassportinfodetl  )
        {
            long returnCode = -99;
            const string SP = "hr_reppassportinfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_reppassportinfodetl, cmd,Database);
                FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.Addhr_reppassportinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_reppassportinfodetlDataAccessObjects.Update(hr_reppassportinfodetlEntity hr_reppassportinfodetl )
        {
           long returnCode = -99;
            const string SP = "hr_reppassportinfodetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_reppassportinfodetl, cmd,Database);
                FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.Updatehr_reppassportinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_reppassportinfodetlDataAccessObjects.Delete(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
        {
            long returnCode = -99;
           	const string SP = "hr_reppassportinfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_reppassportinfodetl, cmd,Database, true);
                FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.Deletehr_reppassportinfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_reppassportinfodetlDataAccessObjects.SaveList(IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_reppassportinfodetl_Ins";
            const string SPUpdate = "hr_reppassportinfodetl_Upd";
            const string SPDelete = "hr_reppassportinfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_reppassportinfodetlEntity hr_reppassportinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_reppassportinfodetl, cmd, Database, true);
                            FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_reppassportinfodetlEntity hr_reppassportinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_reppassportinfodetl, cmd, Database);
                            FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_reppassportinfodetlEntity hr_reppassportinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_reppassportinfodetl, cmd, Database);
                            FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.Save_hr_reppassportinfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_reppassportinfodetl_Ins";
            const string SPUpdate = "hr_reppassportinfodetl_Upd";
            const string SPDelete = "hr_reppassportinfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_reppassportinfodetlEntity hr_reppassportinfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_reppassportinfodetl, cmd, db, true);
                            FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_reppassportinfodetlEntity hr_reppassportinfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_reppassportinfodetl, cmd, db);
                            FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_reppassportinfodetlEntity hr_reppassportinfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_reppassportinfodetl, cmd, db);
                            FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.Save_hr_reppassportinfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlDataAccessObjects.GetAll(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
        {
           try
            {
				const string SP = "hr_reppassportinfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_reppassportinfodetl.SortExpression);
                    FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_reppassportinfodetl, cmd, Database);
                    
                    IList<hr_reppassportinfodetlEntity> itemList = new List<hr_reppassportinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.GetAllhr_reppassportinfodetl"));
            }	
        }
		
		IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlDataAccessObjects.GetAllByPages(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
        {
        try
            {
				const string SP = "hr_reppassportinfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_reppassportinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_reppassportinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_reppassportinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_reppassportinfodetl, cmd,Database);

                    IList<hr_reppassportinfodetlEntity> itemList = new List<hr_reppassportinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_reppassportinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.GetAllByPageshr_reppassportinfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_reppassportinfodetlEntity Ihr_reppassportinfodetlDataAccessObjects.GetSingle(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
        {
           try
            {
				const string SP = "hr_reppassportinfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_reppassportinfodetl, cmd, Database);
                    
                    IList<hr_reppassportinfodetlEntity> itemList = new List<hr_reppassportinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.GetSinglehr_reppassportinfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlDataAccessObjects.GAPgListView(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
        {
        try
            {
				const string SP = "hr_reppassportinfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_reppassportinfodetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_reppassportinfodetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_reppassportinfodetl.CurrentPage);                    
                    FillSequrityParameters(hr_reppassportinfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_reppassportinfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_reppassportinfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_reppassportinfodetl.strCommonSerachParam);

                    IList<hr_reppassportinfodetlEntity> itemList = new List<hr_reppassportinfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_reppassportinfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_reppassportinfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_reppassportinfodetlDataAccess.GAPgListViewhr_reppassportinfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}