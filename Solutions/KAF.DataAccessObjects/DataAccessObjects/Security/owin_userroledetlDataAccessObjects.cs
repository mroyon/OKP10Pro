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
	
	internal sealed partial class owin_userroledetlDataAccessObjects : BaseDataAccess, Iowin_userroledetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userroledetlDataAccessObjects";
        
		public owin_userroledetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userroledetlEntity owin_userroledetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userroledetl.userroledetlid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleDetlID", DbType.Int64, owin_userroledetl.userroledetlid);
            if (forDelete) return;
			if (owin_userroledetl.userroleid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleID", DbType.Int64, owin_userroledetl.userroleid);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userroledetl.userid);
			if (owin_userroledetl.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_userroledetl.roleid);
			if ((owin_userroledetl.fromdate.HasValue))
				Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, owin_userroledetl.fromdate);
			if ((owin_userroledetl.todate.HasValue))
				Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, owin_userroledetl.todate);
			if ((owin_userroledetl.iscurrent != null))
				Database.AddInParameter(cmd, "@IsCurrent", DbType.Boolean, owin_userroledetl.iscurrent);
			if ((owin_userroledetl.iscentraladmin != null))
				Database.AddInParameter(cmd, "@IsCentralAdmin", DbType.Boolean, owin_userroledetl.iscentraladmin);
			if ((owin_userroledetl.allchild != null))
				Database.AddInParameter(cmd, "@AllChild", DbType.Boolean, owin_userroledetl.allchild);
			if ((owin_userroledetl.isunitadmin != null))
				Database.AddInParameter(cmd, "@IsUnitAdmin", DbType.Boolean, owin_userroledetl.isunitadmin);
			if (!(string.IsNullOrEmpty(owin_userroledetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, owin_userroledetl.remarks);
			if ((owin_userroledetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_userroledetl.ex_date1);
			if ((owin_userroledetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_userroledetl.ex_date2);
			if (!(string.IsNullOrEmpty(owin_userroledetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_userroledetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_userroledetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_userroledetl.ex_nvarchar2);
			if (owin_userroledetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_userroledetl.ex_bigint1);
			if (owin_userroledetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_userroledetl.ex_bigint2);
			if (owin_userroledetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_userroledetl.ex_decimal1);
			if (owin_userroledetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_userroledetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_userroledetlDataAccessObjects.Add(owin_userroledetlEntity owin_userroledetl  )
        {
            long returnCode = -99;
            const string SP = "owin_userroledetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userroledetl, cmd,Database);
                FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.Addowin_userroledetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_userroledetlDataAccessObjects.Update(owin_userroledetlEntity owin_userroledetl )
        {
           long returnCode = -99;
            const string SP = "owin_userroledetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userroledetl, cmd,Database);
                FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.Updateowin_userroledetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_userroledetlDataAccessObjects.Delete(owin_userroledetlEntity owin_userroledetl)
        {
            long returnCode = -99;
           	const string SP = "owin_userroledetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userroledetl, cmd,Database, true);
                FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.Deleteowin_userroledetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_userroledetlDataAccessObjects.SaveList(IList<owin_userroledetlEntity> listAdded, IList<owin_userroledetlEntity> listUpdated, IList<owin_userroledetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroledetl_Ins";
            const string SPUpdate = "owin_userroledetl_Upd";
            const string SPDelete = "owin_userroledetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroledetlEntity owin_userroledetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroledetl, cmd, Database, true);
                            FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroledetlEntity owin_userroledetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroledetl, cmd, Database);
                            FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroledetlEntity owin_userroledetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroledetl, cmd, Database);
                            FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.Save_owin_userroledetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_userroledetlEntity> listAdded, IList<owin_userroledetlEntity> listUpdated, IList<owin_userroledetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroledetl_Ins";
            const string SPUpdate = "owin_userroledetl_Upd";
            const string SPDelete = "owin_userroledetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroledetlEntity owin_userroledetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroledetl, cmd, db, true);
                            FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroledetlEntity owin_userroledetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroledetl, cmd, db);
                            FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroledetlEntity owin_userroledetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroledetl, cmd, db);
                            FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.Save_owin_userroledetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_userroledetlEntity> Iowin_userroledetlDataAccessObjects.GetAll(owin_userroledetlEntity owin_userroledetl)
        {
           try
            {
				const string SP = "owin_userroledetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userroledetl.SortExpression);
                    FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroledetl, cmd, Database);
                    
                    IList<owin_userroledetlEntity> itemList = new List<owin_userroledetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.GetAllowin_userroledetl"));
            }	
        }
		
		IList<owin_userroledetlEntity> Iowin_userroledetlDataAccessObjects.GetAllByPages(owin_userroledetlEntity owin_userroledetl)
        {
        try
            {
				const string SP = "owin_userroledetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroledetl.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroledetl.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroledetl.CurrentPage);                    
                    FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroledetl, cmd,Database);

                    IList<owin_userroledetlEntity> itemList = new List<owin_userroledetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroledetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.GetAllByPagesowin_userroledetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Iowin_userroledetlDataAccessObjects.SaveMasterDetowin_userroledetlentitymap(owin_userroledetlEntity masterEntity, 
        IList<owin_userroledetlentitymapEntity> listAdded, 
        IList<owin_userroledetlentitymapEntity> listUpdated,
        IList<owin_userroledetlentitymapEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_userroledetl_Ins";
            const string MasterSPUpdate = "owin_userroledetl_Upd";
            const string MasterSPDelete = "owin_userroledetl_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.userroledetlid=PrimaryKeyMaster;
                            }
                        }
                        owin_userroledetlentitymapDataAccessObjects objowin_userroledetlentitymap=new owin_userroledetlentitymapDataAccessObjects(this.Context);
                        objowin_userroledetlentitymap.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.SaveDsowin_userroledetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_userroledetlDataAccessObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlEntity masterEntity, 
        IList<owin_userroledetlentityprofilemapEntity> listAdded, 
        IList<owin_userroledetlentityprofilemapEntity> listUpdated,
        IList<owin_userroledetlentityprofilemapEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_userroledetl_Ins";
            const string MasterSPUpdate = "owin_userroledetl_Upd";
            const string MasterSPDelete = "owin_userroledetl_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.userroledetlid=PrimaryKeyMaster;
                            }
                        }
                        owin_userroledetlentityprofilemapDataAccessObjects objowin_userroledetlentityprofilemap=new owin_userroledetlentityprofilemapDataAccessObjects(this.Context);
                        objowin_userroledetlentityprofilemap.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.SaveDsowin_userroledetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        owin_userroledetlEntity Iowin_userroledetlDataAccessObjects.GetSingle(owin_userroledetlEntity owin_userroledetl)
        {
           try
            {
				const string SP = "owin_userroledetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroledetl, cmd, Database);
                    
                    IList<owin_userroledetlEntity> itemList = new List<owin_userroledetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.GetSingleowin_userroledetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_userroledetlEntity> Iowin_userroledetlDataAccessObjects.GAPgListView(owin_userroledetlEntity owin_userroledetl)
        {
        try
            {
				const string SP = "owin_userroledetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroledetl.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroledetl.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroledetl.CurrentPage);                    
                    FillSequrityParameters(owin_userroledetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroledetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userroledetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_userroledetl.strCommonSerachParam);

                    IList<owin_userroledetlEntity> itemList = new List<owin_userroledetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroledetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlDataAccess.GAPgListViewowin_userroledetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}