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
	
	internal sealed partial class owin_userroledetlentityprofilemapDataAccessObjects : BaseDataAccess, Iowin_userroledetlentityprofilemapDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userroledetlentityprofilemapDataAccessObjects";
        
		public owin_userroledetlentityprofilemapDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userroledetlentityprofilemap.entityprofiletypeid.HasValue)
				Database.AddInParameter(cmd, "@EntityProfileTypeID", DbType.Int64, owin_userroledetlentityprofilemap.entityprofiletypeid);
            if (forDelete) return;
			if (owin_userroledetlentityprofilemap.userroledetentitymaplid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleDetEntityMaplID", DbType.Int64, owin_userroledetlentityprofilemap.userroledetentitymaplid);
			if (owin_userroledetlentityprofilemap.userroledetlid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleDetlID", DbType.Int64, owin_userroledetlentityprofilemap.userroledetlid);
			if (owin_userroledetlentityprofilemap.userroleid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleID", DbType.Int64, owin_userroledetlentityprofilemap.userroleid);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userroledetlentityprofilemap.userid);
			if (owin_userroledetlentityprofilemap.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_userroledetlentityprofilemap.roleid);
			if (owin_userroledetlentityprofilemap.profiletype.HasValue)
				Database.AddInParameter(cmd, "@ProfileType", DbType.Int64, owin_userroledetlentityprofilemap.profiletype);
			if (!(string.IsNullOrEmpty(owin_userroledetlentityprofilemap.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, owin_userroledetlentityprofilemap.remarks);
			if ((owin_userroledetlentityprofilemap.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_userroledetlentityprofilemap.ex_date1);
			if ((owin_userroledetlentityprofilemap.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_userroledetlentityprofilemap.ex_date2);
			if (!(string.IsNullOrEmpty(owin_userroledetlentityprofilemap.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_userroledetlentityprofilemap.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_userroledetlentityprofilemap.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_userroledetlentityprofilemap.ex_nvarchar2);
			if (owin_userroledetlentityprofilemap.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_userroledetlentityprofilemap.ex_bigint1);
			if (owin_userroledetlentityprofilemap.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_userroledetlentityprofilemap.ex_bigint2);
			if (owin_userroledetlentityprofilemap.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_userroledetlentityprofilemap.ex_decimal1);
			if (owin_userroledetlentityprofilemap.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_userroledetlentityprofilemap.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_userroledetlentityprofilemapDataAccessObjects.Add(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap  )
        {
            long returnCode = -99;
            const string SP = "owin_userroledetlentityprofilemap_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userroledetlentityprofilemap, cmd,Database);
                FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.Addowin_userroledetlentityprofilemap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_userroledetlentityprofilemapDataAccessObjects.Update(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap )
        {
           long returnCode = -99;
            const string SP = "owin_userroledetlentityprofilemap_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userroledetlentityprofilemap, cmd,Database);
                FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.Updateowin_userroledetlentityprofilemap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_userroledetlentityprofilemapDataAccessObjects.Delete(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
        {
            long returnCode = -99;
           	const string SP = "owin_userroledetlentityprofilemap_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userroledetlentityprofilemap, cmd,Database, true);
                FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.Deleteowin_userroledetlentityprofilemap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_userroledetlentityprofilemapDataAccessObjects.SaveList(IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroledetlentityprofilemap_Ins";
            const string SPUpdate = "owin_userroledetlentityprofilemap_Upd";
            const string SPDelete = "owin_userroledetlentityprofilemap_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroledetlentityprofilemap, cmd, Database, true);
                            FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroledetlentityprofilemap, cmd, Database);
                            FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroledetlentityprofilemap, cmd, Database);
                            FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.Save_owin_userroledetlentityprofilemap"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroledetlentityprofilemap_Ins";
            const string SPUpdate = "owin_userroledetlentityprofilemap_Upd";
            const string SPDelete = "owin_userroledetlentityprofilemap_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroledetlentityprofilemap, cmd, db, true);
                            FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroledetlentityprofilemap, cmd, db);
                            FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroledetlentityprofilemap, cmd, db);
                            FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.Save_owin_userroledetlentityprofilemap"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapDataAccessObjects.GetAll(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
        {
           try
            {
				const string SP = "owin_userroledetlentityprofilemap_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userroledetlentityprofilemap.SortExpression);
                    FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroledetlentityprofilemap, cmd, Database);
                    
                    IList<owin_userroledetlentityprofilemapEntity> itemList = new List<owin_userroledetlentityprofilemapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentityprofilemapEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.GetAllowin_userroledetlentityprofilemap"));
            }	
        }
		
		IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapDataAccessObjects.GetAllByPages(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
        {
        try
            {
				const string SP = "owin_userroledetlentityprofilemap_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroledetlentityprofilemap.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroledetlentityprofilemap.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroledetlentityprofilemap.CurrentPage);                    
                    FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroledetlentityprofilemap, cmd,Database);

                    IList<owin_userroledetlentityprofilemapEntity> itemList = new List<owin_userroledetlentityprofilemapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentityprofilemapEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroledetlentityprofilemap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.GetAllByPagesowin_userroledetlentityprofilemap"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        owin_userroledetlentityprofilemapEntity Iowin_userroledetlentityprofilemapDataAccessObjects.GetSingle(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
        {
           try
            {
				const string SP = "owin_userroledetlentityprofilemap_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroledetlentityprofilemap, cmd, Database);
                    
                    IList<owin_userroledetlentityprofilemapEntity> itemList = new List<owin_userroledetlentityprofilemapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentityprofilemapEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.GetSingleowin_userroledetlentityprofilemap"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapDataAccessObjects.GAPgListView(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
        {
        try
            {
				const string SP = "owin_userroledetlentityprofilemap_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroledetlentityprofilemap.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroledetlentityprofilemap.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroledetlentityprofilemap.CurrentPage);                    
                    FillSequrityParameters(owin_userroledetlentityprofilemap.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroledetlentityprofilemap, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userroledetlentityprofilemap.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_userroledetlentityprofilemap.strCommonSerachParam);

                    IList<owin_userroledetlentityprofilemapEntity> itemList = new List<owin_userroledetlentityprofilemapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentityprofilemapEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroledetlentityprofilemap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentityprofilemapDataAccess.GAPgListViewowin_userroledetlentityprofilemap"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}