﻿using System;
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
	
	internal sealed partial class owin_forminfoDataAccessObjects : BaseDataAccess, Iowin_forminfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_forminfoDataAccessObjects";
        
		public owin_forminfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_forminfoEntity owin_forminfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_forminfo.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, owin_forminfo.appformid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_forminfo.formname)))
				Database.AddInParameter(cmd, "@FormName", DbType.String, owin_forminfo.formname);
			if (owin_forminfo.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, owin_forminfo.parentid);
			if (owin_forminfo.levelid.HasValue)
				Database.AddInParameter(cmd, "@LevelID", DbType.Int32, owin_forminfo.levelid);
			if (!(string.IsNullOrEmpty(owin_forminfo.menulevel)))
				Database.AddInParameter(cmd, "@MenuLevel", DbType.String, owin_forminfo.menulevel);
			if (!(string.IsNullOrEmpty(owin_forminfo.formnamear)))
				Database.AddInParameter(cmd, "@FormNameAr", DbType.String, owin_forminfo.formnamear);
			if ((owin_forminfo.hasdirectchild != null))
				Database.AddInParameter(cmd, "@HasDirectChild", DbType.Boolean, owin_forminfo.hasdirectchild);
			
				Database.AddInParameter(cmd, "@Icon", DbType.Binary, owin_forminfo.icon);
			if (!(string.IsNullOrEmpty(owin_forminfo.classicon)))
				Database.AddInParameter(cmd, "@ClassIcon", DbType.String, owin_forminfo.classicon);
			if (owin_forminfo.sequence.HasValue)
				Database.AddInParameter(cmd, "@Sequence", DbType.Int32, owin_forminfo.sequence);
			if (!(string.IsNullOrEmpty(owin_forminfo.url)))
				Database.AddInParameter(cmd, "@URL", DbType.String, owin_forminfo.url);
			if ((owin_forminfo.isview != null))
				Database.AddInParameter(cmd, "@IsView", DbType.Boolean, owin_forminfo.isview);
			if ((owin_forminfo.isdynamic != null))
				Database.AddInParameter(cmd, "@IsDynamic", DbType.Boolean, owin_forminfo.isdynamic);
			if ((owin_forminfo.issuperadmin != null))
				Database.AddInParameter(cmd, "@IsSuperAdmin", DbType.Boolean, owin_forminfo.issuperadmin);
			if ((owin_forminfo.isvisibleinmenu != null))
				Database.AddInParameter(cmd, "@IsVisibleInMenu", DbType.Boolean, owin_forminfo.isvisibleinmenu);
			if (owin_forminfo.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, owin_forminfo.organizationkey);
			if ((owin_forminfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_forminfo.ex_date1);
			if ((owin_forminfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_forminfo.ex_date2);
			if (!(string.IsNullOrEmpty(owin_forminfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_forminfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_forminfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_forminfo.ex_nvarchar2);
			if (owin_forminfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_forminfo.ex_bigint1);
			if (owin_forminfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_forminfo.ex_bigint2);
			if (owin_forminfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_forminfo.ex_decimal1);
			if (owin_forminfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_forminfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_forminfoDataAccessObjects.Add(owin_forminfoEntity owin_forminfo  )
        {
            long returnCode = -99;
            const string SP = "owin_forminfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_forminfo, cmd,Database);
                FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Addowin_forminfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_forminfoDataAccessObjects.Update(owin_forminfoEntity owin_forminfo )
        {
           long returnCode = -99;
            const string SP = "owin_forminfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_forminfo, cmd,Database);
                FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Updateowin_forminfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_forminfoDataAccessObjects.Delete(owin_forminfoEntity owin_forminfo)
        {
            long returnCode = -99;
           	const string SP = "owin_forminfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_forminfo, cmd,Database, true);
                FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Deleteowin_forminfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_forminfoDataAccessObjects.SaveList(IList<owin_forminfoEntity> listAdded, IList<owin_forminfoEntity> listUpdated, IList<owin_forminfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_forminfo_Ins";
            const string SPUpdate = "owin_forminfo_Upd";
            const string SPDelete = "owin_forminfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_forminfoEntity owin_forminfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_forminfo, cmd, Database, true);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_forminfoEntity owin_forminfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_forminfo, cmd, Database);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_forminfoEntity owin_forminfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_forminfo, cmd, Database);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Save_owin_forminfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_forminfoEntity> listAdded, IList<owin_forminfoEntity> listUpdated, IList<owin_forminfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_forminfo_Ins";
            const string SPUpdate = "owin_forminfo_Upd";
            const string SPDelete = "owin_forminfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_forminfoEntity owin_forminfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_forminfo, cmd, db, true);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, db);
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
                    foreach (owin_forminfoEntity owin_forminfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_forminfo, cmd, db);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, db);
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
                    foreach (owin_forminfoEntity owin_forminfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_forminfo, cmd, db);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Save_owin_forminfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_forminfoEntity> Iowin_forminfoDataAccessObjects.GetAll(owin_forminfoEntity owin_forminfo)
        {
           try
            {
				const string SP = "owin_forminfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_forminfo, cmd, Database);
                    
                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetAllowin_forminfo"));
            }	
        }
		
		IList<owin_forminfoEntity> Iowin_forminfoDataAccessObjects.GetAllByPages(owin_forminfoEntity owin_forminfo)
        {
        try
            {
				const string SP = "owin_forminfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
                    AddPageSizeParameter(cmd, owin_forminfo.PageSize);
                    AddCurrentPageParameter(cmd, owin_forminfo.CurrentPage);                    
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_forminfo, cmd,Database);

                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_forminfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetAllByPagesowin_forminfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Iowin_forminfoDataAccessObjects.SaveMasterDetowin_formaction(owin_forminfoEntity masterEntity, 
        IList<owin_formactionEntity> listAdded, 
        IList<owin_formactionEntity> listUpdated,
        IList<owin_formactionEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_forminfo_Ins";
            const string MasterSPUpdate = "owin_forminfo_Upd";
            const string MasterSPDelete = "owin_forminfo_Del";
            
			
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
                                item.appformid=PrimaryKeyMaster;
                            }
                        }
                        owin_formactionDataAccessObjects objowin_formaction=new owin_formactionDataAccessObjects(this.Context);
                        objowin_formaction.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.SaveDsowin_forminfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_forminfoDataAccessObjects.SaveMasterDetowin_lastworkingpage(owin_forminfoEntity masterEntity, 
        IList<owin_lastworkingpageEntity> listAdded, 
        IList<owin_lastworkingpageEntity> listUpdated,
        IList<owin_lastworkingpageEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_forminfo_Ins";
            const string MasterSPUpdate = "owin_forminfo_Upd";
            const string MasterSPDelete = "owin_forminfo_Del";
            
			
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
                                item.appformid=PrimaryKeyMaster;
                            }
                        }
                        owin_lastworkingpageDataAccessObjects objowin_lastworkingpage=new owin_lastworkingpageDataAccessObjects(this.Context);
                        objowin_lastworkingpage.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.SaveDsowin_forminfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Iowin_forminfoDataAccessObjects.SaveMasterDetowin_rolepermission(owin_forminfoEntity masterEntity, 
        IList<owin_rolepermissionEntity> listAdded, 
        IList<owin_rolepermissionEntity> listUpdated,
        IList<owin_rolepermissionEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_forminfo_Ins";
            const string MasterSPUpdate = "owin_forminfo_Upd";
            const string MasterSPDelete = "owin_forminfo_Del";
            
			
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
                                item.appformid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.SaveDsowin_forminfo"));
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
        owin_forminfoEntity Iowin_forminfoDataAccessObjects.GetSingle(owin_forminfoEntity owin_forminfo)
        {
           try
            {
				const string SP = "owin_forminfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_forminfo, cmd, Database);
                    
                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetSingleowin_forminfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_forminfoEntity> Iowin_forminfoDataAccessObjects.GAPgListView(owin_forminfoEntity owin_forminfo)
        {
        try
            {
				const string SP = "owin_forminfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
                    AddPageSizeParameter(cmd, owin_forminfo.PageSize);
                    AddCurrentPageParameter(cmd, owin_forminfo.CurrentPage);                    
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_forminfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_forminfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_forminfo.strCommonSerachParam);

                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_forminfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GAPgListViewowin_forminfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}