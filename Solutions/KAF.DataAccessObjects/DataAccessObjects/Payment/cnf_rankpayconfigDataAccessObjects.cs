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
	
	internal sealed partial class cnf_rankpayconfigDataAccessObjects : BaseDataAccess, Icnf_rankpayconfigDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_rankpayconfigDataAccessObjects";
        
		public cnf_rankpayconfigDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_rankpayconfigEntity cnf_rankpayconfig, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_rankpayconfig.payconfigid.HasValue)
				Database.AddInParameter(cmd, "@PayConfigID", DbType.Int64, cnf_rankpayconfig.payconfigid);
            if (forDelete) return;
            if (cnf_rankpayconfig.payallceid.HasValue)
                Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, cnf_rankpayconfig.payallceid);
            if (cnf_rankpayconfig.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, cnf_rankpayconfig.rankid);
            if (cnf_rankpayconfig.groupid.HasValue)
                Database.AddInParameter(cmd, "@GroupID", DbType.Int64, cnf_rankpayconfig.groupid);
            if (cnf_rankpayconfig.basicsalary.HasValue)
				Database.AddInParameter(cmd, "@BasicSalary", DbType.Decimal, cnf_rankpayconfig.basicsalary);
            if (cnf_rankpayconfig.govtcutting.HasValue)
                Database.AddInParameter(cmd, "@GovtCutting", DbType.Decimal, cnf_rankpayconfig.govtcutting);
            if (cnf_rankpayconfig.regimentalcutting.HasValue)
				Database.AddInParameter(cmd, "@RegimentalCutting", DbType.Decimal, cnf_rankpayconfig.regimentalcutting);
			if (!(string.IsNullOrEmpty(cnf_rankpayconfig.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_rankpayconfig.remarks);
			if ((cnf_rankpayconfig.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, cnf_rankpayconfig.ex_date1);
			if ((cnf_rankpayconfig.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, cnf_rankpayconfig.ex_date2);
			if (!(string.IsNullOrEmpty(cnf_rankpayconfig.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, cnf_rankpayconfig.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(cnf_rankpayconfig.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, cnf_rankpayconfig.ex_nvarchar2);
			if (cnf_rankpayconfig.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, cnf_rankpayconfig.ex_bigint1);
			if (cnf_rankpayconfig.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, cnf_rankpayconfig.ex_bigint2);
			if (cnf_rankpayconfig.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, cnf_rankpayconfig.ex_decimal1);
			if (cnf_rankpayconfig.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, cnf_rankpayconfig.ex_decimal2);

        }
		
        
		#region Add Operation

        long Icnf_rankpayconfigDataAccessObjects.Add(cnf_rankpayconfigEntity cnf_rankpayconfig  )
        {
            long returnCode = -99;
            const string SP = "cnf_rankpayconfig_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_rankpayconfig, cmd,Database);
                FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.Addcnf_rankpayconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Icnf_rankpayconfigDataAccessObjects.Update(cnf_rankpayconfigEntity cnf_rankpayconfig )
        {
           long returnCode = -99;
            const string SP = "cnf_rankpayconfig_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_rankpayconfig, cmd,Database);
                FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.Updatecnf_rankpayconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Icnf_rankpayconfigDataAccessObjects.Delete(cnf_rankpayconfigEntity cnf_rankpayconfig)
        {
            long returnCode = -99;
           	const string SP = "cnf_rankpayconfig_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_rankpayconfig, cmd,Database, true);
                FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.Deletecnf_rankpayconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Icnf_rankpayconfigDataAccessObjects.SaveList(IList<cnf_rankpayconfigEntity> listAdded, IList<cnf_rankpayconfigEntity> listUpdated, IList<cnf_rankpayconfigEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_rankpayconfig_Ins";
            const string SPUpdate = "cnf_rankpayconfig_Upd";
            const string SPDelete = "cnf_rankpayconfig_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_rankpayconfigEntity cnf_rankpayconfig in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_rankpayconfig, cmd, Database, true);
                            FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_rankpayconfigEntity cnf_rankpayconfig in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_rankpayconfig, cmd, Database);
                            FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_rankpayconfigEntity cnf_rankpayconfig in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_rankpayconfig, cmd, Database);
                            FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.Save_cnf_rankpayconfig"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<cnf_rankpayconfigEntity> listAdded, IList<cnf_rankpayconfigEntity> listUpdated, IList<cnf_rankpayconfigEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_rankpayconfig_Ins";
            const string SPUpdate = "cnf_rankpayconfig_Upd";
            const string SPDelete = "cnf_rankpayconfig_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_rankpayconfigEntity cnf_rankpayconfig in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_rankpayconfig, cmd, db, true);
                            FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_rankpayconfigEntity cnf_rankpayconfig in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_rankpayconfig, cmd, db);
                            FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_rankpayconfigEntity cnf_rankpayconfig in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_rankpayconfig, cmd, db);
                            FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.Save_cnf_rankpayconfig"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigDataAccessObjects.GetAll(cnf_rankpayconfigEntity cnf_rankpayconfig)
        {
           try
            {
				const string SP = "cnf_rankpayconfig_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_rankpayconfig.SortExpression);
                    FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_rankpayconfig, cmd, Database);
                    
                    IList<cnf_rankpayconfigEntity> itemList = new List<cnf_rankpayconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_rankpayconfigEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.GetAllcnf_rankpayconfig"));
            }	
        }
		
		IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigDataAccessObjects.GetAllByPages(cnf_rankpayconfigEntity cnf_rankpayconfig)
        {
        try
            {
				const string SP = "cnf_rankpayconfig_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_rankpayconfig.SortExpression);
                    AddPageSizeParameter(cmd, cnf_rankpayconfig.PageSize);
                    AddCurrentPageParameter(cmd, cnf_rankpayconfig.CurrentPage);                    
                    FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_rankpayconfig, cmd,Database);

                    IList<cnf_rankpayconfigEntity> itemList = new List<cnf_rankpayconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_rankpayconfigEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_rankpayconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.GetAllByPagescnf_rankpayconfig"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        cnf_rankpayconfigEntity Icnf_rankpayconfigDataAccessObjects.GetSingle(cnf_rankpayconfigEntity cnf_rankpayconfig)
        {
           try
            {
				const string SP = "cnf_rankpayconfig_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_rankpayconfig, cmd, Database);
                    
                    IList<cnf_rankpayconfigEntity> itemList = new List<cnf_rankpayconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_rankpayconfigEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.GetSinglecnf_rankpayconfig"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigDataAccessObjects.GAPgListView(cnf_rankpayconfigEntity cnf_rankpayconfig)
        {
        try
            {
				 string SP = "cnf_rankpayconfig_GAPgListView";

                if(cnf_rankpayconfig.isconfig==true)
                {
                    SP = "cnf_rankpayconfig_GAPgListView_Ext";
                }

				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_rankpayconfig.SortExpression);
                    AddPageSizeParameter(cmd, cnf_rankpayconfig.PageSize);
                    AddCurrentPageParameter(cmd, cnf_rankpayconfig.CurrentPage);                    
                    FillSequrityParameters(cnf_rankpayconfig.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_rankpayconfig, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_rankpayconfig.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, cnf_rankpayconfig.strCommonSerachParam);

                    IList<cnf_rankpayconfigEntity> itemList = new List<cnf_rankpayconfigEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_rankpayconfigEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_rankpayconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_rankpayconfigDataAccess.GAPgListViewcnf_rankpayconfig"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}