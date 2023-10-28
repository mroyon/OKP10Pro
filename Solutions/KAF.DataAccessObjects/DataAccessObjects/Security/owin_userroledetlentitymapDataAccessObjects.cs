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
	
	internal sealed partial class owin_userroledetlentitymapDataAccessObjects : BaseDataAccess, Iowin_userroledetlentitymapDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userroledetlentitymapDataAccessObjects";
        
		public owin_userroledetlentitymapDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userroledetlentitymapEntity owin_userroledetlentitymap, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userroledetlentitymap.userroledetentitymaplid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleDetEntityMaplID", DbType.Int64, owin_userroledetlentitymap.userroledetentitymaplid);
            if (forDelete) return;
			if (owin_userroledetlentitymap.userroledetlid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleDetlID", DbType.Int64, owin_userroledetlentitymap.userroledetlid);
			if (owin_userroledetlentitymap.userroleid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleID", DbType.Int64, owin_userroledetlentitymap.userroleid);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userroledetlentitymap.userid);
			if (owin_userroledetlentitymap.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_userroledetlentitymap.roleid);
			if (owin_userroledetlentitymap.entitykey.HasValue)
				Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, owin_userroledetlentitymap.entitykey);
			if ((owin_userroledetlentitymap.allchild != null))
				Database.AddInParameter(cmd, "@AllChild", DbType.Boolean, owin_userroledetlentitymap.allchild);
			if ((owin_userroledetlentitymap.isunitadmin != null))
				Database.AddInParameter(cmd, "@IsUnitAdmin", DbType.Boolean, owin_userroledetlentitymap.isunitadmin);
			if ((owin_userroledetlentitymap.allunit != null))
				Database.AddInParameter(cmd, "@AllUnit", DbType.Boolean, owin_userroledetlentitymap.allunit);
			if ((owin_userroledetlentitymap.allprofile != null))
				Database.AddInParameter(cmd, "@AllProfile", DbType.Boolean, owin_userroledetlentitymap.allprofile);
			if (!(string.IsNullOrEmpty(owin_userroledetlentitymap.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, owin_userroledetlentitymap.remarks);
			if ((owin_userroledetlentitymap.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_userroledetlentitymap.ex_date1);
			if ((owin_userroledetlentitymap.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_userroledetlentitymap.ex_date2);
			if (!(string.IsNullOrEmpty(owin_userroledetlentitymap.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_userroledetlentitymap.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_userroledetlentitymap.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_userroledetlentitymap.ex_nvarchar2);
			if (owin_userroledetlentitymap.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_userroledetlentitymap.ex_bigint1);
			if (owin_userroledetlentitymap.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_userroledetlentitymap.ex_bigint2);
			if (owin_userroledetlentitymap.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_userroledetlentitymap.ex_decimal1);
			if (owin_userroledetlentitymap.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_userroledetlentitymap.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_userroledetlentitymapDataAccessObjects.Add(owin_userroledetlentitymapEntity owin_userroledetlentitymap  )
        {
            long returnCode = -99;
            const string SP = "owin_userroledetlentitymap_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userroledetlentitymap, cmd,Database);
                FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.Addowin_userroledetlentitymap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_userroledetlentitymapDataAccessObjects.Update(owin_userroledetlentitymapEntity owin_userroledetlentitymap )
        {
           long returnCode = -99;
            const string SP = "owin_userroledetlentitymap_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userroledetlentitymap, cmd,Database);
                FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.Updateowin_userroledetlentitymap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_userroledetlentitymapDataAccessObjects.Delete(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
        {
            long returnCode = -99;
           	const string SP = "owin_userroledetlentitymap_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userroledetlentitymap, cmd,Database, true);
                FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.Deleteowin_userroledetlentitymap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_userroledetlentitymapDataAccessObjects.SaveList(IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroledetlentitymap_Ins";
            const string SPUpdate = "owin_userroledetlentitymap_Upd";
            const string SPDelete = "owin_userroledetlentitymap_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroledetlentitymapEntity owin_userroledetlentitymap in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroledetlentitymap, cmd, Database, true);
                            FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroledetlentitymapEntity owin_userroledetlentitymap in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroledetlentitymap, cmd, Database);
                            FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroledetlentitymapEntity owin_userroledetlentitymap in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroledetlentitymap, cmd, Database);
                            FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.Save_owin_userroledetlentitymap"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroledetlentitymap_Ins";
            const string SPUpdate = "owin_userroledetlentitymap_Upd";
            const string SPDelete = "owin_userroledetlentitymap_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroledetlentitymapEntity owin_userroledetlentitymap in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroledetlentitymap, cmd, db, true);
                            FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroledetlentitymapEntity owin_userroledetlentitymap in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroledetlentitymap, cmd, db);
                            FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroledetlentitymapEntity owin_userroledetlentitymap in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroledetlentitymap, cmd, db);
                            FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.Save_owin_userroledetlentitymap"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapDataAccessObjects.GetAll(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
        {
           try
            {
				const string SP = "owin_userroledetlentitymap_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userroledetlentitymap.SortExpression);
                    FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroledetlentitymap, cmd, Database);
                    
                    IList<owin_userroledetlentitymapEntity> itemList = new List<owin_userroledetlentitymapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentitymapEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.GetAllowin_userroledetlentitymap"));
            }	
        }
		
		IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapDataAccessObjects.GetAllByPages(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
        {
        try
            {
				const string SP = "owin_userroledetlentitymap_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroledetlentitymap.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroledetlentitymap.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroledetlentitymap.CurrentPage);                    
                    FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroledetlentitymap, cmd,Database);

                    IList<owin_userroledetlentitymapEntity> itemList = new List<owin_userroledetlentitymapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentitymapEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroledetlentitymap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.GetAllByPagesowin_userroledetlentitymap"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Iowin_userroledetlentitymapDataAccessObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlentitymapEntity masterEntity, 
        IList<owin_userroledetlentityprofilemapEntity> listAdded, 
        IList<owin_userroledetlentityprofilemapEntity> listUpdated,
        IList<owin_userroledetlentityprofilemapEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_userroledetlentitymap_Ins";
            const string MasterSPUpdate = "owin_userroledetlentitymap_Upd";
            const string MasterSPDelete = "owin_userroledetlentitymap_Del";
            
			
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
                                item.userroledetentitymaplid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.SaveDsowin_userroledetlentitymap"));
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
        owin_userroledetlentitymapEntity Iowin_userroledetlentitymapDataAccessObjects.GetSingle(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
        {
           try
            {
				const string SP = "owin_userroledetlentitymap_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroledetlentitymap, cmd, Database);
                    
                    IList<owin_userroledetlentitymapEntity> itemList = new List<owin_userroledetlentitymapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentitymapEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.GetSingleowin_userroledetlentitymap"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapDataAccessObjects.GAPgListView(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
        {
        try
            {
				const string SP = "owin_userroledetlentitymap_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroledetlentitymap.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroledetlentitymap.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroledetlentitymap.CurrentPage);                    
                    FillSequrityParameters(owin_userroledetlentitymap.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroledetlentitymap, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userroledetlentitymap.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_userroledetlentitymap.strCommonSerachParam);

                    IList<owin_userroledetlentitymapEntity> itemList = new List<owin_userroledetlentitymapEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroledetlentitymapEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroledetlentitymap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroledetlentitymapDataAccess.GAPgListViewowin_userroledetlentitymap"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}