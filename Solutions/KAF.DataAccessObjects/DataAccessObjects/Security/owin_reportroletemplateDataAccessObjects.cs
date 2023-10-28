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
	
	internal sealed partial class owin_reportroletemplateDataAccessObjects : BaseDataAccess, Iowin_reportroletemplateDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_reportroletemplateDataAccessObjects";
        
		public owin_reportroletemplateDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_reportroletemplateEntity owin_reportroletemplate, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_reportroletemplate.reportroletemplateid.HasValue)
				Database.AddInParameter(cmd, "@ReportRoleTemplateID", DbType.Int64, owin_reportroletemplate.reportroletemplateid);
            if (forDelete) return;
			if (owin_reportroletemplate.reportroleid.HasValue)
				Database.AddInParameter(cmd, "@ReportRoleID", DbType.Int64, owin_reportroletemplate.reportroleid);
			if (owin_reportroletemplate.reportid.HasValue)
				Database.AddInParameter(cmd, "@ReportID", DbType.Int64, owin_reportroletemplate.reportid);
			if ((owin_reportroletemplate.status != null))
				Database.AddInParameter(cmd, "@Status", DbType.Boolean, owin_reportroletemplate.status);
			if ((owin_reportroletemplate.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_reportroletemplate.ex_date1);
			if ((owin_reportroletemplate.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_reportroletemplate.ex_date2);
			if (!(string.IsNullOrEmpty(owin_reportroletemplate.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_reportroletemplate.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_reportroletemplate.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_reportroletemplate.ex_nvarchar2);
			if (owin_reportroletemplate.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_reportroletemplate.ex_bigint1);
			if (owin_reportroletemplate.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_reportroletemplate.ex_bigint2);
			if (owin_reportroletemplate.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_reportroletemplate.ex_decimal1);
			if (owin_reportroletemplate.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_reportroletemplate.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_reportroletemplateDataAccessObjects.Add(owin_reportroletemplateEntity owin_reportroletemplate  )
        {
            long returnCode = -99;
            const string SP = "owin_reportroletemplate_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_reportroletemplate, cmd,Database);
                FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.Addowin_reportroletemplate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_reportroletemplateDataAccessObjects.Update(owin_reportroletemplateEntity owin_reportroletemplate )
        {
           long returnCode = -99;
            const string SP = "owin_reportroletemplate_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_reportroletemplate, cmd,Database);
                FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.Updateowin_reportroletemplate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_reportroletemplateDataAccessObjects.Delete(owin_reportroletemplateEntity owin_reportroletemplate)
        {
            long returnCode = -99;
           	const string SP = "owin_reportroletemplate_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_reportroletemplate, cmd,Database, true);
                FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.Deleteowin_reportroletemplate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_reportroletemplateDataAccessObjects.SaveList(IList<owin_reportroletemplateEntity> listAdded, IList<owin_reportroletemplateEntity> listUpdated, IList<owin_reportroletemplateEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_reportroletemplate_Ins";
            const string SPUpdate = "owin_reportroletemplate_Upd";
            const string SPDelete = "owin_reportroletemplate_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_reportroletemplateEntity owin_reportroletemplate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_reportroletemplate, cmd, Database, true);
                            FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_reportroletemplateEntity owin_reportroletemplate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_reportroletemplate, cmd, Database);
                            FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_reportroletemplateEntity owin_reportroletemplate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_reportroletemplate, cmd, Database);
                            FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.Save_owin_reportroletemplate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_reportroletemplateEntity> listAdded, IList<owin_reportroletemplateEntity> listUpdated, IList<owin_reportroletemplateEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_reportroletemplate_Ins";
            const string SPUpdate = "owin_reportroletemplate_Upd";
            const string SPDelete = "owin_reportroletemplate_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_reportroletemplateEntity owin_reportroletemplate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_reportroletemplate, cmd, db, true);
                            FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, db);
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
                    foreach (owin_reportroletemplateEntity owin_reportroletemplate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_reportroletemplate, cmd, db);
                            FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, db);
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
                    foreach (owin_reportroletemplateEntity owin_reportroletemplate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_reportroletemplate, cmd, db);
                            FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.Save_owin_reportroletemplate"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_reportroletemplateEntity> Iowin_reportroletemplateDataAccessObjects.GetAll(owin_reportroletemplateEntity owin_reportroletemplate)
        {
           try
            {
				const string SP = "owin_reportroletemplate_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_reportroletemplate.SortExpression);
                    FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_reportroletemplate, cmd, Database);
                    
                    IList<owin_reportroletemplateEntity> itemList = new List<owin_reportroletemplateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroletemplateEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.GetAllowin_reportroletemplate"));
            }	
        }
		
		IList<owin_reportroletemplateEntity> Iowin_reportroletemplateDataAccessObjects.GetAllByPages(owin_reportroletemplateEntity owin_reportroletemplate)
        {
        try
            {
				const string SP = "owin_reportroletemplate_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_reportroletemplate.SortExpression);
                    AddPageSizeParameter(cmd, owin_reportroletemplate.PageSize);
                    AddCurrentPageParameter(cmd, owin_reportroletemplate.CurrentPage);                    
                    FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_reportroletemplate, cmd,Database);

                    IList<owin_reportroletemplateEntity> itemList = new List<owin_reportroletemplateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroletemplateEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_reportroletemplate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.GetAllByPagesowin_reportroletemplate"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        owin_reportroletemplateEntity Iowin_reportroletemplateDataAccessObjects.GetSingle(owin_reportroletemplateEntity owin_reportroletemplate)
        {
           try
            {
				const string SP = "owin_reportroletemplate_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_reportroletemplate, cmd, Database);
                    
                    IList<owin_reportroletemplateEntity> itemList = new List<owin_reportroletemplateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroletemplateEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.GetSingleowin_reportroletemplate"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_reportroletemplateEntity> Iowin_reportroletemplateDataAccessObjects.GAPgListView(owin_reportroletemplateEntity owin_reportroletemplate)
        {
        try
            {
				const string SP = "owin_reportroletemplate_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_reportroletemplate.SortExpression);
                    AddPageSizeParameter(cmd, owin_reportroletemplate.PageSize);
                    AddCurrentPageParameter(cmd, owin_reportroletemplate.CurrentPage);                    
                    FillSequrityParameters(owin_reportroletemplate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_reportroletemplate, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_reportroletemplate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_reportroletemplate.strCommonSerachParam);

                    IList<owin_reportroletemplateEntity> itemList = new List<owin_reportroletemplateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroletemplateEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_reportroletemplate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroletemplateDataAccess.GAPgListViewowin_reportroletemplate"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}