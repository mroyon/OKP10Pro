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
	
	internal sealed partial class rptm_reportparameterDataAccessObjects : BaseDataAccess, Irptm_reportparameterDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "rptm_reportparameterDataAccessObjects";
        
		public rptm_reportparameterDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(rptm_reportparameterEntity rptm_reportparameter, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (rptm_reportparameter.reportparamid.HasValue)
				Database.AddInParameter(cmd, "@ReportParamID", DbType.Int64, rptm_reportparameter.reportparamid);
            if (forDelete) return;
			if (rptm_reportparameter.reportid.HasValue)
				Database.AddInParameter(cmd, "@ReportID", DbType.Int64, rptm_reportparameter.reportid);
			if (!(string.IsNullOrEmpty(rptm_reportparameter.reportparamname)))
				Database.AddInParameter(cmd, "@ReportParamName", DbType.String, rptm_reportparameter.reportparamname);
			if (!(string.IsNullOrEmpty(rptm_reportparameter.reportparamdatatype)))
				Database.AddInParameter(cmd, "@ReportParamDatatype", DbType.String, rptm_reportparameter.reportparamdatatype);
			if (!(string.IsNullOrEmpty(rptm_reportparameter.reportparamdescription)))
				Database.AddInParameter(cmd, "@ReportParamDescription", DbType.String, rptm_reportparameter.reportparamdescription);
			if ((rptm_reportparameter.reportparamoptionalid != null))
				Database.AddInParameter(cmd, "@ReportParamOptionalID", DbType.Boolean, rptm_reportparameter.reportparamoptionalid);
			if ((rptm_reportparameter.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, rptm_reportparameter.ex_date1);
			if ((rptm_reportparameter.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, rptm_reportparameter.ex_date2);
			if (!(string.IsNullOrEmpty(rptm_reportparameter.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, rptm_reportparameter.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(rptm_reportparameter.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, rptm_reportparameter.ex_nvarchar2);
			if (rptm_reportparameter.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, rptm_reportparameter.ex_bigint1);
			if (rptm_reportparameter.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, rptm_reportparameter.ex_bigint2);
			if (rptm_reportparameter.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, rptm_reportparameter.ex_decimal1);
			if (rptm_reportparameter.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, rptm_reportparameter.ex_decimal2);

        }
		
        
		#region Add Operation

        long Irptm_reportparameterDataAccessObjects.Add(rptm_reportparameterEntity rptm_reportparameter  )
        {
            long returnCode = -99;
            const string SP = "rptm_reportparameter_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(rptm_reportparameter, cmd,Database);
                FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.Addrptm_reportparameter"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Irptm_reportparameterDataAccessObjects.Update(rptm_reportparameterEntity rptm_reportparameter )
        {
           long returnCode = -99;
            const string SP = "rptm_reportparameter_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(rptm_reportparameter, cmd,Database);
                FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.Updaterptm_reportparameter"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Irptm_reportparameterDataAccessObjects.Delete(rptm_reportparameterEntity rptm_reportparameter)
        {
            long returnCode = -99;
           	const string SP = "rptm_reportparameter_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(rptm_reportparameter, cmd,Database, true);
                FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.Deleterptm_reportparameter"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Irptm_reportparameterDataAccessObjects.SaveList(IList<rptm_reportparameterEntity> listAdded, IList<rptm_reportparameterEntity> listUpdated, IList<rptm_reportparameterEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "rptm_reportparameter_Ins";
            const string SPUpdate = "rptm_reportparameter_Upd";
            const string SPDelete = "rptm_reportparameter_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (rptm_reportparameterEntity rptm_reportparameter in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(rptm_reportparameter, cmd, Database, true);
                            FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
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
                    foreach (rptm_reportparameterEntity rptm_reportparameter in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(rptm_reportparameter, cmd, Database);
                            FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
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
                    foreach (rptm_reportparameterEntity rptm_reportparameter in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(rptm_reportparameter, cmd, Database);
                            FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.Save_rptm_reportparameter"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<rptm_reportparameterEntity> listAdded, IList<rptm_reportparameterEntity> listUpdated, IList<rptm_reportparameterEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "rptm_reportparameter_Ins";
            const string SPUpdate = "rptm_reportparameter_Upd";
            const string SPDelete = "rptm_reportparameter_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (rptm_reportparameterEntity rptm_reportparameter in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(rptm_reportparameter, cmd, db, true);
                            FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, db);
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
                    foreach (rptm_reportparameterEntity rptm_reportparameter in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(rptm_reportparameter, cmd, db);
                            FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, db);
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
                    foreach (rptm_reportparameterEntity rptm_reportparameter in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(rptm_reportparameter, cmd, db);
                            FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.Save_rptm_reportparameter"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<rptm_reportparameterEntity> Irptm_reportparameterDataAccessObjects.GetAll(rptm_reportparameterEntity rptm_reportparameter)
        {
           try
            {
				const string SP = "rptm_reportparameter_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, rptm_reportparameter.SortExpression);
                    FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
                    FillParameters(rptm_reportparameter, cmd, Database);
                    
                    IList<rptm_reportparameterEntity> itemList = new List<rptm_reportparameterEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportparameterEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.GetAllrptm_reportparameter"));
            }	
        }
		
		IList<rptm_reportparameterEntity> Irptm_reportparameterDataAccessObjects.GetAllByPages(rptm_reportparameterEntity rptm_reportparameter)
        {
        try
            {
				const string SP = "rptm_reportparameter_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, rptm_reportparameter.SortExpression);
                    AddPageSizeParameter(cmd, rptm_reportparameter.PageSize);
                    AddCurrentPageParameter(cmd, rptm_reportparameter.CurrentPage);                    
                    FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
                    
					FillParameters(rptm_reportparameter, cmd,Database);

                    IList<rptm_reportparameterEntity> itemList = new List<rptm_reportparameterEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportparameterEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						rptm_reportparameter.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.GetAllByPagesrptm_reportparameter"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        rptm_reportparameterEntity Irptm_reportparameterDataAccessObjects.GetSingle(rptm_reportparameterEntity rptm_reportparameter)
        {
           try
            {
				const string SP = "rptm_reportparameter_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
                    FillParameters(rptm_reportparameter, cmd, Database);
                    
                    IList<rptm_reportparameterEntity> itemList = new List<rptm_reportparameterEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportparameterEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.GetSinglerptm_reportparameter"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<rptm_reportparameterEntity> Irptm_reportparameterDataAccessObjects.GAPgListView(rptm_reportparameterEntity rptm_reportparameter)
        {
        try
            {
				const string SP = "rptm_reportparameter_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, rptm_reportparameter.SortExpression);
                    AddPageSizeParameter(cmd, rptm_reportparameter.PageSize);
                    AddCurrentPageParameter(cmd, rptm_reportparameter.CurrentPage);                    
                    FillSequrityParameters(rptm_reportparameter.BaseSecurityParam, cmd, Database);
                    
					FillParameters(rptm_reportparameter, cmd,Database);
                    
					if (!string.IsNullOrEmpty (rptm_reportparameter.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, rptm_reportparameter.strCommonSerachParam);

                    IList<rptm_reportparameterEntity> itemList = new List<rptm_reportparameterEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_reportparameterEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						rptm_reportparameter.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Irptm_reportparameterDataAccess.GAPgListViewrptm_reportparameter"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}