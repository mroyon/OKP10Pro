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
	
	internal sealed partial class owin_roleDataAccessObjects : BaseDataAccess, Iowin_roleDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_roleDataAccessObjects";
        
		public owin_roleDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_roleEntity owin_role, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_role.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_role.roleid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_role.rolename)))
				Database.AddInParameter(cmd, "@RoleName", DbType.String, owin_role.rolename);
			if (!(string.IsNullOrEmpty(owin_role.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, owin_role.description);
			if ((owin_role.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_role.ex_date1);
			if ((owin_role.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_role.ex_date2);
			if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_role.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_role.ex_nvarchar2);
			if (owin_role.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_role.ex_bigint1);
			if (owin_role.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_role.ex_bigint2);
			if (owin_role.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_role.ex_decimal1);
			if (owin_role.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_role.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_roleDataAccessObjects.Add(owin_roleEntity owin_role  )
        {
            long returnCode = -99;
            const string SP = "owin_role_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_role, cmd,Database);
                FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Addowin_role"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_roleDataAccessObjects.Update(owin_roleEntity owin_role )
        {
           long returnCode = -99;
            const string SP = "owin_role_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_role, cmd,Database);
                FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Updateowin_role"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_roleDataAccessObjects.Delete(owin_roleEntity owin_role)
        {
            long returnCode = -99;
           	const string SP = "owin_role_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_role, cmd,Database, true);
                FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Deleteowin_role"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_roleDataAccessObjects.SaveList(IList<owin_roleEntity> listAdded, IList<owin_roleEntity> listUpdated, IList<owin_roleEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_role_Ins";
            const string SPUpdate = "owin_role_Upd";
            const string SPDelete = "owin_role_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_roleEntity owin_role in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_role, cmd, Database, true);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_roleEntity owin_role in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_role, cmd, Database);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_roleEntity owin_role in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_role, cmd, Database);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Save_owin_role"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_roleEntity> listAdded, IList<owin_roleEntity> listUpdated, IList<owin_roleEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_role_Ins";
            const string SPUpdate = "owin_role_Upd";
            const string SPDelete = "owin_role_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_roleEntity owin_role in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_role, cmd, db, true);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, db);
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
                    foreach (owin_roleEntity owin_role in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_role, cmd, db);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, db);
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
                    foreach (owin_roleEntity owin_role in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_role, cmd, db);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Save_owin_role"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_roleEntity> Iowin_roleDataAccessObjects.GetAll(owin_roleEntity owin_role)
        {
           try
            {
				const string SP = "owin_role_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_role, cmd, Database);
                    
                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetAllowin_role"));
            }	
        }
		
		IList<owin_roleEntity> Iowin_roleDataAccessObjects.GetAllByPages(owin_roleEntity owin_role)
        {
        try
            {
				const string SP = "owin_role_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    AddPageSizeParameter(cmd, owin_role.PageSize);
                    AddCurrentPageParameter(cmd, owin_role.CurrentPage);                    
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_role, cmd,Database);

                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_role.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetAllByPagesowin_role"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Iowin_roleDataAccessObjects.SaveMasterDetowin_userroledetl(owin_roleEntity masterEntity, 
        IList<owin_userroledetlEntity> listAdded, 
        IList<owin_userroledetlEntity> listUpdated,
        IList<owin_userroledetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_role_Ins";
            const string MasterSPUpdate = "owin_role_Upd";
            const string MasterSPDelete = "owin_role_Del";
            
			
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
                                item.roleid=PrimaryKeyMaster;
                            }
                        }
                        owin_userroledetlDataAccessObjects objowin_userroledetl=new owin_userroledetlDataAccessObjects(this.Context);
                        objowin_userroledetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.SaveDsowin_role"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_roleDataAccessObjects.SaveMasterDetowin_rolepermission(owin_roleEntity masterEntity, 
        IList<owin_rolepermissionEntity> listAdded, 
        IList<owin_rolepermissionEntity> listUpdated,
        IList<owin_rolepermissionEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_role_Ins";
            const string MasterSPUpdate = "owin_role_Upd";
            const string MasterSPDelete = "owin_role_Del";
            
			
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
                                item.roleid=PrimaryKeyMaster;
                            }
                        }
                        owin_rolepermissionDataAccessObjects objowin_rolepermission=new owin_rolepermissionDataAccessObjects(this.Context);
                        objowin_rolepermission.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.SaveDsowin_role"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_roleDataAccessObjects.SaveMasterDetowin_userrole(owin_roleEntity masterEntity, 
        IList<owin_userroleEntity> listAdded, 
        IList<owin_userroleEntity> listUpdated,
        IList<owin_userroleEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_role_Ins";
            const string MasterSPUpdate = "owin_role_Upd";
            const string MasterSPDelete = "owin_role_Del";
            
			
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
                                item.roleid=PrimaryKeyMaster;
                            }
                        }
                        owin_userroleDataAccessObjects objowin_userrole=new owin_userroleDataAccessObjects(this.Context);
                        objowin_userrole.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.SaveDsowin_role"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_roleDataAccessObjects.SaveMasterDetowin_userroledetlentitymap(owin_roleEntity masterEntity, 
        IList<owin_userroledetlentitymapEntity> listAdded, 
        IList<owin_userroledetlentitymapEntity> listUpdated,
        IList<owin_userroledetlentitymapEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_role_Ins";
            const string MasterSPUpdate = "owin_role_Upd";
            const string MasterSPDelete = "owin_role_Del";
            
			
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
                                item.roleid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.SaveDsowin_role"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_roleDataAccessObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_roleEntity masterEntity, 
        IList<owin_userroledetlentityprofilemapEntity> listAdded, 
        IList<owin_userroledetlentityprofilemapEntity> listUpdated,
        IList<owin_userroledetlentityprofilemapEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_role_Ins";
            const string MasterSPUpdate = "owin_role_Upd";
            const string MasterSPDelete = "owin_role_Del";
            
			
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
                                item.roleid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.SaveDsowin_role"));
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
        owin_roleEntity Iowin_roleDataAccessObjects.GetSingle(owin_roleEntity owin_role)
        {
           try
            {
				const string SP = "owin_role_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_role, cmd, Database);
                    
                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetSingleowin_role"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_roleEntity> Iowin_roleDataAccessObjects.GAPgListView(owin_roleEntity owin_role)
        {
        try
            {
				const string SP = "owin_role_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    AddPageSizeParameter(cmd, owin_role.PageSize);
                    AddCurrentPageParameter(cmd, owin_role.CurrentPage);                    
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_role, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_role.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_role.strCommonSerachParam);

                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_role.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GAPgListViewowin_role"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}