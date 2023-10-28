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
	
	internal sealed partial class owin_lastworkingpageDataAccessObjects : BaseDataAccess, Iowin_lastworkingpageDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_lastworkingpageDataAccessObjects";
        
		public owin_lastworkingpageDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_lastworkingpageEntity owin_lastworkingpage, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_lastworkingpage.lastpageid.HasValue)
				Database.AddInParameter(cmd, "@LastPageID", DbType.Int64, owin_lastworkingpage.lastpageid);
            if (forDelete) return;
			if (owin_lastworkingpage.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, owin_lastworkingpage.appformid);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_lastworkingpage.userid);
			if (owin_lastworkingpage.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_lastworkingpage.masteruserid);
			if ((owin_lastworkingpage.lastentrydate.HasValue))
				Database.AddInParameter(cmd, "@LastEntryDate", DbType.DateTime, owin_lastworkingpage.lastentrydate);
			if ((owin_lastworkingpage.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_lastworkingpage.ex_date1);
			if ((owin_lastworkingpage.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_lastworkingpage.ex_date2);
			if (!(string.IsNullOrEmpty(owin_lastworkingpage.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_lastworkingpage.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_lastworkingpage.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_lastworkingpage.ex_nvarchar2);
			if (owin_lastworkingpage.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_lastworkingpage.ex_bigint1);
			if (owin_lastworkingpage.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_lastworkingpage.ex_bigint2);
			if (owin_lastworkingpage.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_lastworkingpage.ex_decimal1);
			if (owin_lastworkingpage.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_lastworkingpage.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_lastworkingpageDataAccessObjects.Add(owin_lastworkingpageEntity owin_lastworkingpage  )
        {
            long returnCode = -99;
            const string SP = "owin_lastworkingpage_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_lastworkingpage, cmd,Database);
                FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.Addowin_lastworkingpage"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_lastworkingpageDataAccessObjects.Update(owin_lastworkingpageEntity owin_lastworkingpage )
        {
           long returnCode = -99;
            const string SP = "owin_lastworkingpage_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_lastworkingpage, cmd,Database);
                FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.Updateowin_lastworkingpage"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_lastworkingpageDataAccessObjects.Delete(owin_lastworkingpageEntity owin_lastworkingpage)
        {
            long returnCode = -99;
           	const string SP = "owin_lastworkingpage_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_lastworkingpage, cmd,Database, true);
                FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.Deleteowin_lastworkingpage"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_lastworkingpageDataAccessObjects.SaveList(IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_lastworkingpage_Ins";
            const string SPUpdate = "owin_lastworkingpage_Upd";
            const string SPDelete = "owin_lastworkingpage_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_lastworkingpageEntity owin_lastworkingpage in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_lastworkingpage, cmd, Database, true);
                            FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_lastworkingpageEntity owin_lastworkingpage in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_lastworkingpage, cmd, Database);
                            FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_lastworkingpageEntity owin_lastworkingpage in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_lastworkingpage, cmd, Database);
                            FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.Save_owin_lastworkingpage"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_lastworkingpage_Ins";
            const string SPUpdate = "owin_lastworkingpage_Upd";
            const string SPDelete = "owin_lastworkingpage_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_lastworkingpageEntity owin_lastworkingpage in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_lastworkingpage, cmd, db, true);
                            FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, db);
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
                    foreach (owin_lastworkingpageEntity owin_lastworkingpage in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_lastworkingpage, cmd, db);
                            FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, db);
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
                    foreach (owin_lastworkingpageEntity owin_lastworkingpage in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_lastworkingpage, cmd, db);
                            FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.Save_owin_lastworkingpage"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_lastworkingpageEntity> Iowin_lastworkingpageDataAccessObjects.GetAll(owin_lastworkingpageEntity owin_lastworkingpage)
        {
           try
            {
				const string SP = "owin_lastworkingpage_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_lastworkingpage.SortExpression);
                    FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_lastworkingpage, cmd, Database);
                    
                    IList<owin_lastworkingpageEntity> itemList = new List<owin_lastworkingpageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_lastworkingpageEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.GetAllowin_lastworkingpage"));
            }	
        }
		
		IList<owin_lastworkingpageEntity> Iowin_lastworkingpageDataAccessObjects.GetAllByPages(owin_lastworkingpageEntity owin_lastworkingpage)
        {
        try
            {
				const string SP = "owin_lastworkingpage_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_lastworkingpage.SortExpression);
                    AddPageSizeParameter(cmd, owin_lastworkingpage.PageSize);
                    AddCurrentPageParameter(cmd, owin_lastworkingpage.CurrentPage);                    
                    FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_lastworkingpage, cmd,Database);

                    IList<owin_lastworkingpageEntity> itemList = new List<owin_lastworkingpageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_lastworkingpageEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_lastworkingpage.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.GetAllByPagesowin_lastworkingpage"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        owin_lastworkingpageEntity Iowin_lastworkingpageDataAccessObjects.GetSingle(owin_lastworkingpageEntity owin_lastworkingpage)
        {
           try
            {
				const string SP = "owin_lastworkingpage_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_lastworkingpage, cmd, Database);
                    
                    IList<owin_lastworkingpageEntity> itemList = new List<owin_lastworkingpageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_lastworkingpageEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.GetSingleowin_lastworkingpage"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_lastworkingpageEntity> Iowin_lastworkingpageDataAccessObjects.GAPgListView(owin_lastworkingpageEntity owin_lastworkingpage)
        {
        try
            {
				const string SP = "owin_lastworkingpage_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_lastworkingpage.SortExpression);
                    AddPageSizeParameter(cmd, owin_lastworkingpage.PageSize);
                    AddCurrentPageParameter(cmd, owin_lastworkingpage.CurrentPage);                    
                    FillSequrityParameters(owin_lastworkingpage.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_lastworkingpage, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_lastworkingpage.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_lastworkingpage.strCommonSerachParam);

                    IList<owin_lastworkingpageEntity> itemList = new List<owin_lastworkingpageEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_lastworkingpageEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_lastworkingpage.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_lastworkingpageDataAccess.GAPgListViewowin_lastworkingpage"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}