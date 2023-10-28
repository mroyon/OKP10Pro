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
	
	internal sealed partial class rptm_reportdatasourceDataAccessObjects : BaseDataAccess, Irptm_reportdatasourceDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "rptm_reportdatasourceDataAccessObjects";
        
		public rptm_reportdatasourceDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(rptm_reportdatasourceEntity rptm_reportdatasource, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (rptm_reportdatasource.reportdatasourceid.HasValue)
				Database.AddInParameter(cmd, "@ReportDataSourceID", DbType.Int64, rptm_reportdatasource.reportdatasourceid);
            if (forDelete) return;
			if (rptm_reportdatasource.reportid.HasValue)
				Database.AddInParameter(cmd, "@ReportID", DbType.Int64, rptm_reportdatasource.reportid);
			if (!(string.IsNullOrEmpty(rptm_reportdatasource.reportdatasourcename)))
				Database.AddInParameter(cmd, "@ReportDataSourceName", DbType.String, rptm_reportdatasource.reportdatasourcename);
			if (!(string.IsNullOrEmpty(rptm_reportdatasource.reportdatasourcespname)))
				Database.AddInParameter(cmd, "@ReportDataSourceSPName", DbType.String, rptm_reportdatasource.reportdatasourcespname);
			if (!(string.IsNullOrEmpty(rptm_reportdatasource.reportdatasourcedescription)))
				Database.AddInParameter(cmd, "@ReportDataSourceDescription", DbType.String, rptm_reportdatasource.reportdatasourcedescription);
			if ((rptm_reportdatasource.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, rptm_reportdatasource.ex_date1);
			if ((rptm_reportdatasource.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, rptm_reportdatasource.ex_date2);
			if (!(string.IsNullOrEmpty(rptm_reportdatasource.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, rptm_reportdatasource.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(rptm_reportdatasource.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, rptm_reportdatasource.ex_nvarchar2);
			if (rptm_reportdatasource.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, rptm_reportdatasource.ex_bigint1);
			if (rptm_reportdatasource.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, rptm_reportdatasource.ex_bigint2);
			if (rptm_reportdatasource.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, rptm_reportdatasource.ex_decimal1);
			if (rptm_reportdatasource.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, rptm_reportdatasource.ex_decimal2);

        }
		
        
		#region Add Operation

        long Irptm_reportdatasourceDataAccessObjects.Add(rptm_reportdatasourceEntity rptm_reportdatasource  )
        {
            long returnCode = -99;
            const string SP = "rptm_reportdatasource_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(rptm_reportdatasource, cmd,Database);
                FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.Addrptm_reportdatasource"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Irptm_reportdatasourceDataAccessObjects.Update(rptm_reportdatasourceEntity rptm_reportdatasource )
        {
           long returnCode = -99;
            const string SP = "rptm_reportdatasource_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(rptm_reportdatasource, cmd,Database);
                FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.Updaterptm_reportdatasource"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Irptm_reportdatasourceDataAccessObjects.Delete(rptm_reportdatasourceEntity rptm_reportdatasource)
        {
            long returnCode = -99;
           	const string SP = "rptm_reportdatasource_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(rptm_reportdatasource, cmd,Database, true);
                FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.Deleterptm_reportdatasource"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Irptm_reportdatasourceDataAccessObjects.SaveList(IList<rptm_reportdatasourceEntity> listAdded, IList<rptm_reportdatasourceEntity> listUpdated, IList<rptm_reportdatasourceEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "rptm_reportdatasource_Ins";
            const string SPUpdate = "rptm_reportdatasource_Upd";
            const string SPDelete = "rptm_reportdatasource_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (rptm_reportdatasourceEntity rptm_reportdatasource in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(rptm_reportdatasource, cmd, Database, true);
                            FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
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
                    foreach (rptm_reportdatasourceEntity rptm_reportdatasource in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(rptm_reportdatasource, cmd, Database);
                            FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
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
                    foreach (rptm_reportdatasourceEntity rptm_reportdatasource in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(rptm_reportdatasource, cmd, Database);
                            FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.Save_rptm_reportdatasource"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<rptm_reportdatasourceEntity> listAdded, IList<rptm_reportdatasourceEntity> listUpdated, IList<rptm_reportdatasourceEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "rptm_reportdatasource_Ins";
            const string SPUpdate = "rptm_reportdatasource_Upd";
            const string SPDelete = "rptm_reportdatasource_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (rptm_reportdatasourceEntity rptm_reportdatasource in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(rptm_reportdatasource, cmd, db, true);
                            FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, db);
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
                    foreach (rptm_reportdatasourceEntity rptm_reportdatasource in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(rptm_reportdatasource, cmd, db);
                            FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, db);
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
                    foreach (rptm_reportdatasourceEntity rptm_reportdatasource in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(rptm_reportdatasource, cmd, db);
                            FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.Save_rptm_reportdatasource"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceDataAccessObjects.GetAll(rptm_reportdatasourceEntity rptm_reportdatasource)
        {
           try
            {
				const string SP = "rptm_reportdatasource_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, rptm_reportdatasource.SortExpression);
                    FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
                    FillParameters(rptm_reportdatasource, cmd, Database);
                    
                    IList<rptm_reportdatasourceEntity> itemList = new List<rptm_reportdatasourceEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportdatasourceEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.GetAllrptm_reportdatasource"));
            }	
        }
		
		IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceDataAccessObjects.GetAllByPages(rptm_reportdatasourceEntity rptm_reportdatasource)
        {
        try
            {
				const string SP = "rptm_reportdatasource_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, rptm_reportdatasource.SortExpression);
                    AddPageSizeParameter(cmd, rptm_reportdatasource.PageSize);
                    AddCurrentPageParameter(cmd, rptm_reportdatasource.CurrentPage);                    
                    FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
                    
					FillParameters(rptm_reportdatasource, cmd,Database);

                    IList<rptm_reportdatasourceEntity> itemList = new List<rptm_reportdatasourceEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportdatasourceEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						rptm_reportdatasource.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.GetAllByPagesrptm_reportdatasource"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        rptm_reportdatasourceEntity Irptm_reportdatasourceDataAccessObjects.GetSingle(rptm_reportdatasourceEntity rptm_reportdatasource)
        {
           try
            {
				const string SP = "rptm_reportdatasource_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
                    FillParameters(rptm_reportdatasource, cmd, Database);
                    
                    IList<rptm_reportdatasourceEntity> itemList = new List<rptm_reportdatasourceEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportdatasourceEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.GetSinglerptm_reportdatasource"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceDataAccessObjects.GAPgListView(rptm_reportdatasourceEntity rptm_reportdatasource)
        {
        try
            {
				const string SP = "rptm_reportdatasource_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, rptm_reportdatasource.SortExpression);
                    AddPageSizeParameter(cmd, rptm_reportdatasource.PageSize);
                    AddCurrentPageParameter(cmd, rptm_reportdatasource.CurrentPage);                    
                    FillSequrityParameters(rptm_reportdatasource.BaseSecurityParam, cmd, Database);
                    
					FillParameters(rptm_reportdatasource, cmd,Database);
                    
					if (!string.IsNullOrEmpty (rptm_reportdatasource.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, rptm_reportdatasource.strCommonSerachParam);

                    IList<rptm_reportdatasourceEntity> itemList = new List<rptm_reportdatasourceEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportdatasourceEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						rptm_reportdatasource.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportdatasourceDataAccess.GAPgListViewrptm_reportdatasource"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}