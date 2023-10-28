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
	
	internal sealed partial class owin_tsvDataAccessObjects : BaseDataAccess, Iowin_tsvDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_tsvDataAccessObjects";
        
		public owin_tsvDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_tsvEntity owin_tsv, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_tsv.serail.HasValue)
				Database.AddInParameter(cmd, "@Serail", DbType.Int64, owin_tsv.serail);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_tsv.userid);
			if ((owin_tsv.tsvtokenrequestdate.HasValue))
				Database.AddInParameter(cmd, "@TSVTokenRequestDate", DbType.DateTime, owin_tsv.tsvtokenrequestdate);
			if (!(string.IsNullOrEmpty(owin_tsv.tsvtoken)))
				Database.AddInParameter(cmd, "@TSVToken", DbType.String, owin_tsv.tsvtoken);
			if ((owin_tsv.isvalid != null))
				Database.AddInParameter(cmd, "@IsValid", DbType.Boolean, owin_tsv.isvalid);
			if (owin_tsv.varificationtried.HasValue)
				Database.AddInParameter(cmd, "@VarificationTried", DbType.Int32, owin_tsv.varificationtried);
			if ((owin_tsv.validdate.HasValue))
				Database.AddInParameter(cmd, "@ValidDate", DbType.DateTime, owin_tsv.validdate);
			if (!(string.IsNullOrEmpty(owin_tsv.usersessionid)))
				Database.AddInParameter(cmd, "@UserSessionID", DbType.String, owin_tsv.usersessionid);
			if (!(string.IsNullOrEmpty(owin_tsv._requestaft)))
				Database.AddInParameter(cmd, "@_RequestAFT", DbType.String, owin_tsv._requestaft);
			if ((owin_tsv.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_tsv.ex_date1);
			if ((owin_tsv.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_tsv.ex_date2);
			if (!(string.IsNullOrEmpty(owin_tsv.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_tsv.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_tsv.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_tsv.ex_nvarchar2);
			if (owin_tsv.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_tsv.ex_bigint1);
			if (owin_tsv.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_tsv.ex_bigint2);
			if (owin_tsv.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_tsv.ex_decimal1);
			if (owin_tsv.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_tsv.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_tsvDataAccessObjects.Add(owin_tsvEntity owin_tsv  )
        {
            long returnCode = -99;
            const string SP = "owin_tsv_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_tsv, cmd,Database);
                FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.Addowin_tsv"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_tsvDataAccessObjects.Update(owin_tsvEntity owin_tsv )
        {
           long returnCode = -99;
            const string SP = "owin_tsv_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_tsv, cmd,Database);
                FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.Updateowin_tsv"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_tsvDataAccessObjects.Delete(owin_tsvEntity owin_tsv)
        {
            long returnCode = -99;
           	const string SP = "owin_tsv_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_tsv, cmd,Database, true);
                FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.Deleteowin_tsv"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_tsvDataAccessObjects.SaveList(IList<owin_tsvEntity> listAdded, IList<owin_tsvEntity> listUpdated, IList<owin_tsvEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_tsv_Ins";
            const string SPUpdate = "owin_tsv_Upd";
            const string SPDelete = "owin_tsv_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_tsvEntity owin_tsv in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_tsv, cmd, Database, true);
                            FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_tsvEntity owin_tsv in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_tsv, cmd, Database);
                            FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_tsvEntity owin_tsv in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_tsv, cmd, Database);
                            FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.Save_owin_tsv"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_tsvEntity> listAdded, IList<owin_tsvEntity> listUpdated, IList<owin_tsvEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_tsv_Ins";
            const string SPUpdate = "owin_tsv_Upd";
            const string SPDelete = "owin_tsv_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_tsvEntity owin_tsv in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_tsv, cmd, db, true);
                            FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, db);
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
                    foreach (owin_tsvEntity owin_tsv in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_tsv, cmd, db);
                            FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, db);
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
                    foreach (owin_tsvEntity owin_tsv in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_tsv, cmd, db);
                            FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.Save_owin_tsv"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_tsvEntity> Iowin_tsvDataAccessObjects.GetAll(owin_tsvEntity owin_tsv)
        {
           try
            {
				const string SP = "owin_tsv_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_tsv.SortExpression);
                    FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_tsv, cmd, Database);
                    
                    IList<owin_tsvEntity> itemList = new List<owin_tsvEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_tsvEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.GetAllowin_tsv"));
            }	
        }
		
		IList<owin_tsvEntity> Iowin_tsvDataAccessObjects.GetAllByPages(owin_tsvEntity owin_tsv)
        {
        try
            {
				const string SP = "owin_tsv_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_tsv.SortExpression);
                    AddPageSizeParameter(cmd, owin_tsv.PageSize);
                    AddCurrentPageParameter(cmd, owin_tsv.CurrentPage);                    
                    FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_tsv, cmd,Database);

                    IList<owin_tsvEntity> itemList = new List<owin_tsvEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_tsvEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_tsv.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.GetAllByPagesowin_tsv"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        owin_tsvEntity Iowin_tsvDataAccessObjects.GetSingle(owin_tsvEntity owin_tsv)
        {
           try
            {
				const string SP = "owin_tsv_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_tsv, cmd, Database);
                    
                    IList<owin_tsvEntity> itemList = new List<owin_tsvEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_tsvEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.GetSingleowin_tsv"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_tsvEntity> Iowin_tsvDataAccessObjects.GAPgListView(owin_tsvEntity owin_tsv)
        {
        try
            {
				const string SP = "owin_tsv_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_tsv.SortExpression);
                    AddPageSizeParameter(cmd, owin_tsv.PageSize);
                    AddCurrentPageParameter(cmd, owin_tsv.CurrentPage);                    
                    FillSequrityParameters(owin_tsv.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_tsv, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_tsv.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_tsv.strCommonSerachParam);

                    IList<owin_tsvEntity> itemList = new List<owin_tsvEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_tsvEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_tsv.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_tsvDataAccess.GAPgListViewowin_tsv"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}