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
	
	internal sealed partial class gen_thanaDataAccessObjects : BaseDataAccess, Igen_thanaDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_thanaDataAccessObjects";
        
		public gen_thanaDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_thanaEntity gen_thana, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_thana.thanaid.HasValue)
				Database.AddInParameter(cmd, "@ThanaID", DbType.Int64, gen_thana.thanaid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_thana.thananame)))
				Database.AddInParameter(cmd, "@ThanaName", DbType.String, gen_thana.thananame);
			if (gen_thana.districtid.HasValue)
				Database.AddInParameter(cmd, "@DistrictID", DbType.Int64, gen_thana.districtid);
			if (!(string.IsNullOrEmpty(gen_thana.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_thana.remarks);
			if ((gen_thana.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_thana.ex_date1);
			if ((gen_thana.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_thana.ex_date2);
			if (!(string.IsNullOrEmpty(gen_thana.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_thana.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_thana.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_thana.ex_nvarchar2);
			if (gen_thana.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_thana.ex_bigint1);
			if (gen_thana.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_thana.ex_bigint2);
			if (gen_thana.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_thana.ex_decimal1);
			if (gen_thana.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_thana.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_thanaDataAccessObjects.Add(gen_thanaEntity gen_thana  )
        {
            long returnCode = -99;
            const string SP = "gen_thana_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_thana, cmd,Database);
                FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.Addgen_thana"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_thanaDataAccessObjects.Update(gen_thanaEntity gen_thana )
        {
           long returnCode = -99;
            const string SP = "gen_thana_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_thana, cmd,Database);
                FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.Updategen_thana"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_thanaDataAccessObjects.Delete(gen_thanaEntity gen_thana)
        {
            long returnCode = -99;
           	const string SP = "gen_thana_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_thana, cmd,Database, true);
                FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.Deletegen_thana"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_thanaDataAccessObjects.SaveList(IList<gen_thanaEntity> listAdded, IList<gen_thanaEntity> listUpdated, IList<gen_thanaEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_thana_Ins";
            const string SPUpdate = "gen_thana_Upd";
            const string SPDelete = "gen_thana_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_thanaEntity gen_thana in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_thana, cmd, Database, true);
                            FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_thanaEntity gen_thana in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_thana, cmd, Database);
                            FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_thanaEntity gen_thana in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_thana, cmd, Database);
                            FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.Save_gen_thana"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_thanaEntity> listAdded, IList<gen_thanaEntity> listUpdated, IList<gen_thanaEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_thana_Ins";
            const string SPUpdate = "gen_thana_Upd";
            const string SPDelete = "gen_thana_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_thanaEntity gen_thana in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_thana, cmd, db, true);
                            FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, db);
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
                    foreach (gen_thanaEntity gen_thana in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_thana, cmd, db);
                            FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, db);
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
                    foreach (gen_thanaEntity gen_thana in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_thana, cmd, db);
                            FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.Save_gen_thana"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_thanaEntity> Igen_thanaDataAccessObjects.GetAll(gen_thanaEntity gen_thana)
        {
           try
            {
				const string SP = "gen_thana_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_thana.SortExpression);
                    FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_thana, cmd, Database);
                    
                    IList<gen_thanaEntity> itemList = new List<gen_thanaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_thanaEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.GetAllgen_thana"));
            }	
        }
		
		IList<gen_thanaEntity> Igen_thanaDataAccessObjects.GetAllByPages(gen_thanaEntity gen_thana)
        {
        try
            {
				const string SP = "gen_thana_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_thana.SortExpression);
                    AddPageSizeParameter(cmd, gen_thana.PageSize);
                    AddCurrentPageParameter(cmd, gen_thana.CurrentPage);                    
                    FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_thana, cmd,Database);

                    IList<gen_thanaEntity> itemList = new List<gen_thanaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_thanaEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_thana.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.GetAllByPagesgen_thana"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_thanaDataAccessObjects.SaveMasterDetgen_postoffice(gen_thanaEntity masterEntity, 
        IList<gen_postofficeEntity> listAdded, 
        IList<gen_postofficeEntity> listUpdated,
        IList<gen_postofficeEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_thana_Ins";
            const string MasterSPUpdate = "gen_thana_Upd";
            const string MasterSPDelete = "gen_thana_Del";
            
			
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
                                item.thanaid=PrimaryKeyMaster;
                            }
                        }
                        gen_postofficeDataAccessObjects objgen_postoffice=new gen_postofficeDataAccessObjects(this.Context);
                        objgen_postoffice.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.SaveDsgen_thana"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_thanaDataAccessObjects.SaveMasterDethr_addresschange(gen_thanaEntity masterEntity, 
        IList<hr_addresschangeEntity> listAdded, 
        IList<hr_addresschangeEntity> listUpdated,
        IList<hr_addresschangeEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_thana_Ins";
            const string MasterSPUpdate = "gen_thana_Upd";
            const string MasterSPDelete = "gen_thana_Del";
            
			
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
                                item.bdcurthanaid=PrimaryKeyMaster;
                            }
                        }
                        hr_addresschangeDataAccessObjects objhr_addresschange=new hr_addresschangeDataAccessObjects(this.Context);
                        objhr_addresschange.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.SaveDsgen_thana"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_thanaDataAccessObjects.SaveMasterDethr_emergencycontact(gen_thanaEntity masterEntity, 
        IList<hr_emergencycontactEntity> listAdded, 
        IList<hr_emergencycontactEntity> listUpdated,
        IList<hr_emergencycontactEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_thana_Ins";
            const string MasterSPUpdate = "gen_thana_Upd";
            const string MasterSPDelete = "gen_thana_Del";
            
			
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
                                item.curbdadrressps=PrimaryKeyMaster;
                            }
                        }
                        hr_emergencycontactDataAccessObjects objhr_emergencycontact=new hr_emergencycontactDataAccessObjects(this.Context);
                        objhr_emergencycontact.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.SaveDsgen_thana"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_thanaDataAccessObjects.SaveMasterDethr_personalinfo(gen_thanaEntity masterEntity, 
        IList<hr_personalinfoEntity> listAdded, 
        IList<hr_personalinfoEntity> listUpdated,
        IList<hr_personalinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_thana_Ins";
            const string MasterSPUpdate = "gen_thana_Upd";
            const string MasterSPDelete = "gen_thana_Del";
            
			
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
                                item.bdcurthanaid=PrimaryKeyMaster;
                            }
                        }
                        hr_personalinfoDataAccessObjects objhr_personalinfo=new hr_personalinfoDataAccessObjects(this.Context);
                        objhr_personalinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.SaveDsgen_thana"));
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
        gen_thanaEntity Igen_thanaDataAccessObjects.GetSingle(gen_thanaEntity gen_thana)
        {
           try
            {
				const string SP = "gen_thana_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_thana, cmd, Database);
                    
                    IList<gen_thanaEntity> itemList = new List<gen_thanaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_thanaEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.GetSinglegen_thana"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_thanaEntity> Igen_thanaDataAccessObjects.GAPgListView(gen_thanaEntity gen_thana)
        {
        try
            {
				const string SP = "gen_thana_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_thana.SortExpression);
                    AddPageSizeParameter(cmd, gen_thana.PageSize);
                    AddCurrentPageParameter(cmd, gen_thana.CurrentPage);                    
                    FillSequrityParameters(gen_thana.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_thana, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_thana.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_thana.strCommonSerachParam);

                    IList<gen_thanaEntity> itemList = new List<gen_thanaEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_thanaEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_thana.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_thanaDataAccess.GAPgListViewgen_thana"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}