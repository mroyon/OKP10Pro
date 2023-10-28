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
	
	internal sealed partial class owin_reportroleDataAccessObjects : BaseDataAccess, Iowin_reportroleDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_reportroleDataAccessObjects";
        
		public owin_reportroleDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_reportroleEntity owin_reportrole, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_reportrole.reportroleid.HasValue)
				Database.AddInParameter(cmd, "@ReportRoleID", DbType.Int64, owin_reportrole.reportroleid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_reportrole.reportrolename)))
				Database.AddInParameter(cmd, "@ReportRoleName", DbType.String, owin_reportrole.reportrolename);
			if (!(string.IsNullOrEmpty(owin_reportrole.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, owin_reportrole.description);
			if ((owin_reportrole.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_reportrole.ex_date1);
			if ((owin_reportrole.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_reportrole.ex_date2);
			if (!(string.IsNullOrEmpty(owin_reportrole.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_reportrole.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_reportrole.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_reportrole.ex_nvarchar2);
			if (owin_reportrole.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_reportrole.ex_bigint1);
			if (owin_reportrole.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_reportrole.ex_bigint2);
			if (owin_reportrole.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_reportrole.ex_decimal1);
			if (owin_reportrole.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_reportrole.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_reportroleDataAccessObjects.Add(owin_reportroleEntity owin_reportrole  )
        {
            long returnCode = -99;
            const string SP = "owin_reportrole_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_reportrole, cmd,Database);
                FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.Addowin_reportrole"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_reportroleDataAccessObjects.Update(owin_reportroleEntity owin_reportrole )
        {
           long returnCode = -99;
            const string SP = "owin_reportrole_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_reportrole, cmd,Database);
                FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.Updateowin_reportrole"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_reportroleDataAccessObjects.Delete(owin_reportroleEntity owin_reportrole)
        {
            long returnCode = -99;
           	const string SP = "owin_reportrole_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_reportrole, cmd,Database, true);
                FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.Deleteowin_reportrole"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_reportroleDataAccessObjects.SaveList(IList<owin_reportroleEntity> listAdded, IList<owin_reportroleEntity> listUpdated, IList<owin_reportroleEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_reportrole_Ins";
            const string SPUpdate = "owin_reportrole_Upd";
            const string SPDelete = "owin_reportrole_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_reportroleEntity owin_reportrole in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_reportrole, cmd, Database, true);
                            FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_reportroleEntity owin_reportrole in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_reportrole, cmd, Database);
                            FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_reportroleEntity owin_reportrole in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_reportrole, cmd, Database);
                            FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.Save_owin_reportrole"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_reportroleEntity> listAdded, IList<owin_reportroleEntity> listUpdated, IList<owin_reportroleEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_reportrole_Ins";
            const string SPUpdate = "owin_reportrole_Upd";
            const string SPDelete = "owin_reportrole_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_reportroleEntity owin_reportrole in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_reportrole, cmd, db, true);
                            FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, db);
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
                    foreach (owin_reportroleEntity owin_reportrole in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_reportrole, cmd, db);
                            FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, db);
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
                    foreach (owin_reportroleEntity owin_reportrole in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_reportrole, cmd, db);
                            FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.Save_owin_reportrole"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_reportroleEntity> Iowin_reportroleDataAccessObjects.GetAll(owin_reportroleEntity owin_reportrole)
        {
           try
            {
				const string SP = "owin_reportrole_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_reportrole.SortExpression);
                    FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_reportrole, cmd, Database);
                    
                    IList<owin_reportroleEntity> itemList = new List<owin_reportroleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroleEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.GetAllowin_reportrole"));
            }	
        }
		
		IList<owin_reportroleEntity> Iowin_reportroleDataAccessObjects.GetAllByPages(owin_reportroleEntity owin_reportrole)
        {
        try
            {
				const string SP = "owin_reportrole_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_reportrole.SortExpression);
                    AddPageSizeParameter(cmd, owin_reportrole.PageSize);
                    AddCurrentPageParameter(cmd, owin_reportrole.CurrentPage);                    
                    FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_reportrole, cmd,Database);

                    IList<owin_reportroleEntity> itemList = new List<owin_reportroleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroleEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_reportrole.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.GetAllByPagesowin_reportrole"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Iowin_reportroleDataAccessObjects.SaveMasterDetowin_reportpermission(owin_reportroleEntity masterEntity, 
        IList<owin_reportpermissionEntity> listAdded, 
        IList<owin_reportpermissionEntity> listUpdated,
        IList<owin_reportpermissionEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_reportrole_Ins";
            const string MasterSPUpdate = "owin_reportrole_Upd";
            const string MasterSPDelete = "owin_reportrole_Del";
            
			
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
                                item.reportroleid=PrimaryKeyMaster;
                            }
                        }
                        owin_reportpermissionDataAccessObjects objowin_reportpermission=new owin_reportpermissionDataAccessObjects(this.Context);
                        objowin_reportpermission.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.SaveDsowin_reportrole"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_reportroleDataAccessObjects.SaveMasterDetowin_reportroletemplate(owin_reportroleEntity masterEntity, 
        IList<owin_reportroletemplateEntity> listAdded, 
        IList<owin_reportroletemplateEntity> listUpdated,
        IList<owin_reportroletemplateEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_reportrole_Ins";
            const string MasterSPUpdate = "owin_reportrole_Upd";
            const string MasterSPDelete = "owin_reportrole_Del";
            
			
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
                                item.reportroleid=PrimaryKeyMaster;
                            }
                        }
                        owin_reportroletemplateDataAccessObjects objowin_reportroletemplate=new owin_reportroletemplateDataAccessObjects(this.Context);
                        objowin_reportroletemplate.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.SaveDsowin_reportrole"));
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
        owin_reportroleEntity Iowin_reportroleDataAccessObjects.GetSingle(owin_reportroleEntity owin_reportrole)
        {
           try
            {
				const string SP = "owin_reportrole_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_reportrole, cmd, Database);
                    
                    IList<owin_reportroleEntity> itemList = new List<owin_reportroleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroleEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.GetSingleowin_reportrole"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_reportroleEntity> Iowin_reportroleDataAccessObjects.GAPgListView(owin_reportroleEntity owin_reportrole)
        {
        try
            {
				const string SP = "owin_reportrole_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_reportrole.SortExpression);
                    AddPageSizeParameter(cmd, owin_reportrole.PageSize);
                    AddCurrentPageParameter(cmd, owin_reportrole.CurrentPage);                    
                    FillSequrityParameters(owin_reportrole.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_reportrole, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_reportrole.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_reportrole.strCommonSerachParam);

                    IList<owin_reportroleEntity> itemList = new List<owin_reportroleEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_reportroleEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_reportrole.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_reportroleDataAccess.GAPgListViewowin_reportrole"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}