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
	
	internal sealed partial class owin_reportpermissionDataAccessObjects : BaseDataAccess, Iowin_reportpermissionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_reportpermissionDataAccessObjects";
        
		public owin_reportpermissionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_reportpermissionEntity owin_reportpermission, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_reportpermission.reportpersmissionid.HasValue)
				Database.AddInParameter(cmd, "@ReportPersmissionID", DbType.Int64, owin_reportpermission.reportpersmissionid);
            if (forDelete) return;
			if (owin_reportpermission.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_reportpermission.masteruserid);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_reportpermission.userid);
			if (owin_reportpermission.reportroleid.HasValue)
				Database.AddInParameter(cmd, "@ReportRoleID", DbType.Int64, owin_reportpermission.reportroleid);
			if (owin_reportpermission.reportid.HasValue)
				Database.AddInParameter(cmd, "@ReportID", DbType.Int64, owin_reportpermission.reportid);
			if ((owin_reportpermission.isaccessible != null))
				Database.AddInParameter(cmd, "@IsAccessible", DbType.Boolean, owin_reportpermission.isaccessible);
			if ((owin_reportpermission.isprintable != null))
				Database.AddInParameter(cmd, "@IsPrintable", DbType.Boolean, owin_reportpermission.isprintable);
			if ((owin_reportpermission.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_reportpermission.ex_date1);
			if ((owin_reportpermission.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_reportpermission.ex_date2);
			if (!(string.IsNullOrEmpty(owin_reportpermission.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_reportpermission.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_reportpermission.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_reportpermission.ex_nvarchar2);
			if (owin_reportpermission.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_reportpermission.ex_bigint1);
			if (owin_reportpermission.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_reportpermission.ex_bigint2);
			if (owin_reportpermission.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_reportpermission.ex_decimal1);
			if (owin_reportpermission.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_reportpermission.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_reportpermissionDataAccessObjects.Add(owin_reportpermissionEntity owin_reportpermission  )
        {
            long returnCode = -99;
            const string SP = "owin_reportpermission_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_reportpermission, cmd,Database);
                FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.Addowin_reportpermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_reportpermissionDataAccessObjects.Update(owin_reportpermissionEntity owin_reportpermission )
        {
           long returnCode = -99;
            const string SP = "owin_reportpermission_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_reportpermission, cmd,Database);
                FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.Updateowin_reportpermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_reportpermissionDataAccessObjects.Delete(owin_reportpermissionEntity owin_reportpermission)
        {
            long returnCode = -99;
           	const string SP = "owin_reportpermission_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_reportpermission, cmd,Database, true);
                FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.Deleteowin_reportpermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_reportpermissionDataAccessObjects.SaveList(IList<owin_reportpermissionEntity> listAdded, IList<owin_reportpermissionEntity> listUpdated, IList<owin_reportpermissionEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_reportpermission_Ins";
            const string SPUpdate = "owin_reportpermission_Upd";
            const string SPDelete = "owin_reportpermission_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_reportpermissionEntity owin_reportpermission in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_reportpermission, cmd, Database, true);
                            FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_reportpermissionEntity owin_reportpermission in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_reportpermission, cmd, Database);
                            FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_reportpermissionEntity owin_reportpermission in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_reportpermission, cmd, Database);
                            FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.Save_owin_reportpermission"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_reportpermissionEntity> listAdded, IList<owin_reportpermissionEntity> listUpdated, IList<owin_reportpermissionEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_reportpermission_Ins";
            const string SPUpdate = "owin_reportpermission_Upd";
            const string SPDelete = "owin_reportpermission_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_reportpermissionEntity owin_reportpermission in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_reportpermission, cmd, db, true);
                            FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, db);
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
                    foreach (owin_reportpermissionEntity owin_reportpermission in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_reportpermission, cmd, db);
                            FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, db);
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
                    foreach (owin_reportpermissionEntity owin_reportpermission in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_reportpermission, cmd, db);
                            FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.Save_owin_reportpermission"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_reportpermissionEntity> Iowin_reportpermissionDataAccessObjects.GetAll(owin_reportpermissionEntity owin_reportpermission)
        {
           try
            {
				const string SP = "owin_reportpermission_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_reportpermission.SortExpression);
                    FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_reportpermission, cmd, Database);
                    
                    IList<owin_reportpermissionEntity> itemList = new List<owin_reportpermissionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportpermissionEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.GetAllowin_reportpermission"));
            }	
        }
		
		IList<owin_reportpermissionEntity> Iowin_reportpermissionDataAccessObjects.GetAllByPages(owin_reportpermissionEntity owin_reportpermission)
        {
        try
            {
				const string SP = "owin_reportpermission_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_reportpermission.SortExpression);
                    AddPageSizeParameter(cmd, owin_reportpermission.PageSize);
                    AddCurrentPageParameter(cmd, owin_reportpermission.CurrentPage);                    
                    FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_reportpermission, cmd,Database);

                    IList<owin_reportpermissionEntity> itemList = new List<owin_reportpermissionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportpermissionEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_reportpermission.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.GetAllByPagesowin_reportpermission"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        owin_reportpermissionEntity Iowin_reportpermissionDataAccessObjects.GetSingle(owin_reportpermissionEntity owin_reportpermission)
        {
           try
            {
				const string SP = "owin_reportpermission_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_reportpermission, cmd, Database);
                    
                    IList<owin_reportpermissionEntity> itemList = new List<owin_reportpermissionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportpermissionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.GetSingleowin_reportpermission"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_reportpermissionEntity> Iowin_reportpermissionDataAccessObjects.GAPgListView(owin_reportpermissionEntity owin_reportpermission)
        {
        try
            {
				const string SP = "owin_reportpermission_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_reportpermission.SortExpression);
                    AddPageSizeParameter(cmd, owin_reportpermission.PageSize);
                    AddCurrentPageParameter(cmd, owin_reportpermission.CurrentPage);                    
                    FillSequrityParameters(owin_reportpermission.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_reportpermission, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_reportpermission.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_reportpermission.strCommonSerachParam);

                    IList<owin_reportpermissionEntity> itemList = new List<owin_reportpermissionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportpermissionEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_reportpermission.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportpermissionDataAccess.GAPgListViewowin_reportpermission"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}