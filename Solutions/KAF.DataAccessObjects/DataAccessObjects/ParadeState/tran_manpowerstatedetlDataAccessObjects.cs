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
	
	internal sealed partial class tran_manpowerstatedetlDataAccessObjects : BaseDataAccess, Itran_manpowerstatedetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_manpowerstatedetlDataAccessObjects";
        
		public tran_manpowerstatedetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_manpowerstatedetlEntity tran_manpowerstatedetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_manpowerstatedetl.manpowerstatedetlid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStateDetlID", DbType.Int64, tran_manpowerstatedetl.manpowerstatedetlid);
            if (forDelete) return;
			if (tran_manpowerstatedetl.manpowerstateid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStateID", DbType.Int64, tran_manpowerstatedetl.manpowerstateid);
			if (tran_manpowerstatedetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, tran_manpowerstatedetl.hrbasicid);
			if (tran_manpowerstatedetl.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, tran_manpowerstatedetl.hrsvcid);
			if (tran_manpowerstatedetl.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, tran_manpowerstatedetl.rankid);
			if (tran_manpowerstatedetl.groupid.HasValue)
				Database.AddInParameter(cmd, "@GroupID", DbType.Int64, tran_manpowerstatedetl.groupid);
			if (tran_manpowerstatedetl.subunitid.HasValue)
				Database.AddInParameter(cmd, "@SubUnitID", DbType.Int64, tran_manpowerstatedetl.subunitid);
			if (tran_manpowerstatedetl.campid.HasValue)
				Database.AddInParameter(cmd, "@CampID", DbType.Int64, tran_manpowerstatedetl.campid);
			if (tran_manpowerstatedetl.manpowerstatusid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStatusID", DbType.Int64, tran_manpowerstatedetl.manpowerstatusid);
			if ((tran_manpowerstatedetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, tran_manpowerstatedetl.ex_date1);
			if ((tran_manpowerstatedetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, tran_manpowerstatedetl.ex_date2);
			if (!(string.IsNullOrEmpty(tran_manpowerstatedetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, tran_manpowerstatedetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(tran_manpowerstatedetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, tran_manpowerstatedetl.ex_nvarchar2);
			if (tran_manpowerstatedetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, tran_manpowerstatedetl.ex_bigint1);
			if (tran_manpowerstatedetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, tran_manpowerstatedetl.ex_bigint2);
			if (tran_manpowerstatedetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, tran_manpowerstatedetl.ex_decimal1);
			if (tran_manpowerstatedetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, tran_manpowerstatedetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Itran_manpowerstatedetlDataAccessObjects.Add(tran_manpowerstatedetlEntity tran_manpowerstatedetl  )
        {
            long returnCode = -99;
            const string SP = "tran_manpowerstatedetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_manpowerstatedetl, cmd,Database);
                FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.Addtran_manpowerstatedetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Itran_manpowerstatedetlDataAccessObjects.Update(tran_manpowerstatedetlEntity tran_manpowerstatedetl )
        {
           long returnCode = -99;
            const string SP = "tran_manpowerstatedetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_manpowerstatedetl, cmd,Database);
                FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.Updatetran_manpowerstatedetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Itran_manpowerstatedetlDataAccessObjects.Delete(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
        {
            long returnCode = -99;
           	const string SP = "tran_manpowerstatedetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_manpowerstatedetl, cmd,Database, true);
                FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.Deletetran_manpowerstatedetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Itran_manpowerstatedetlDataAccessObjects.SaveList(IList<tran_manpowerstatedetlEntity> listAdded, IList<tran_manpowerstatedetlEntity> listUpdated, IList<tran_manpowerstatedetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstatedetl_Ins";
            const string SPUpdate = "tran_manpowerstatedetl_Upd";
            const string SPDelete = "tran_manpowerstatedetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstatedetlEntity tran_manpowerstatedetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstatedetl, cmd, Database, true);
                            FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_manpowerstatedetlEntity tran_manpowerstatedetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstatedetl, cmd, Database);
                            FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_manpowerstatedetlEntity tran_manpowerstatedetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstatedetl, cmd, Database);
                            FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.Save_tran_manpowerstatedetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<tran_manpowerstatedetlEntity> listAdded, IList<tran_manpowerstatedetlEntity> listUpdated, IList<tran_manpowerstatedetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstatedetl_Ins";
            const string SPUpdate = "tran_manpowerstatedetl_Upd";
            const string SPDelete = "tran_manpowerstatedetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstatedetlEntity tran_manpowerstatedetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstatedetl, cmd, db, true);
                            FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, db);
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
                    foreach (tran_manpowerstatedetlEntity tran_manpowerstatedetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstatedetl, cmd, db);
                            FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, db);
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
                    foreach (tran_manpowerstatedetlEntity tran_manpowerstatedetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstatedetl, cmd, db);
                            FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.Save_tran_manpowerstatedetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlDataAccessObjects.GetAll(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
        {
           try
            {
				const string SP = "tran_manpowerstatedetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_manpowerstatedetl.SortExpression);
                    FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstatedetl, cmd, Database);
                    
                    IList<tran_manpowerstatedetlEntity> itemList = new List<tran_manpowerstatedetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.GetAlltran_manpowerstatedetl"));
            }	
        }
		
		IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlDataAccessObjects.GetAllByPages(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
        {
        try
            {
				const string SP = "tran_manpowerstatedetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstatedetl.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstatedetl.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstatedetl.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstatedetl, cmd,Database);

                    IList<tran_manpowerstatedetlEntity> itemList = new List<tran_manpowerstatedetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstatedetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.GetAllByPagestran_manpowerstatedetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        tran_manpowerstatedetlEntity Itran_manpowerstatedetlDataAccessObjects.GetSingle(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
        {
           try
            {
				const string SP = "tran_manpowerstatedetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstatedetl, cmd, Database);
                    
                    IList<tran_manpowerstatedetlEntity> itemList = new List<tran_manpowerstatedetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.GetSingletran_manpowerstatedetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlDataAccessObjects.GAPgListView(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
        {
        try
            {
				const string SP = "tran_manpowerstatedetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstatedetl.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstatedetl.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstatedetl.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstatedetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstatedetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_manpowerstatedetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_manpowerstatedetl.strCommonSerachParam);

                    IList<tran_manpowerstatedetlEntity> itemList = new List<tran_manpowerstatedetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstatedetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstatedetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstatedetlDataAccess.GAPgListViewtran_manpowerstatedetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}