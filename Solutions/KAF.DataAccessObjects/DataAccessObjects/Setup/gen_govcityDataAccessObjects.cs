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
	
	internal sealed partial class gen_govcityDataAccessObjects : BaseDataAccess, Igen_govcityDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_govcityDataAccessObjects";
        
		public gen_govcityDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_govcityEntity gen_govcity, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_govcity.cityid.HasValue)
				Database.AddInParameter(cmd, "@CityID", DbType.Int64, gen_govcity.cityid);
            if (forDelete) return;
			if (gen_govcity.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, gen_govcity.parentid);
			if (!(string.IsNullOrEmpty(gen_govcity.cityname)))
				Database.AddInParameter(cmd, "@CityName", DbType.String, gen_govcity.cityname);
			if (!(string.IsNullOrEmpty(gen_govcity.citynamear)))
				Database.AddInParameter(cmd, "@CityNameAr", DbType.String, gen_govcity.citynamear);
			if ((gen_govcity.isgov != null))
				Database.AddInParameter(cmd, "@IsGov", DbType.Boolean, gen_govcity.isgov);
			if (gen_govcity.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_govcity.countryid);
			
				Database.AddInParameter(cmd, "@AREA_CODE_PACI", DbType.Decimal, gen_govcity.area_code_paci);
			if (!(string.IsNullOrEmpty(gen_govcity.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_govcity.remarks);
			if ((gen_govcity.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_govcity.ex_date1);
			if ((gen_govcity.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_govcity.ex_date2);
			if (!(string.IsNullOrEmpty(gen_govcity.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_govcity.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_govcity.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_govcity.ex_nvarchar2);
			if (gen_govcity.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_govcity.ex_bigint1);
			if (gen_govcity.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_govcity.ex_bigint2);
			if (gen_govcity.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_govcity.ex_decimal1);
			if (gen_govcity.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_govcity.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_govcityDataAccessObjects.Add(gen_govcityEntity gen_govcity  )
        {
            long returnCode = -99;
            const string SP = "gen_govcity_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_govcity, cmd,Database);
                FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.Addgen_govcity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_govcityDataAccessObjects.Update(gen_govcityEntity gen_govcity )
        {
           long returnCode = -99;
            const string SP = "gen_govcity_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_govcity, cmd,Database);
                FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.Updategen_govcity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_govcityDataAccessObjects.Delete(gen_govcityEntity gen_govcity)
        {
            long returnCode = -99;
           	const string SP = "gen_govcity_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_govcity, cmd,Database, true);
                FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.Deletegen_govcity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_govcityDataAccessObjects.SaveList(IList<gen_govcityEntity> listAdded, IList<gen_govcityEntity> listUpdated, IList<gen_govcityEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_govcity_Ins";
            const string SPUpdate = "gen_govcity_Upd";
            const string SPDelete = "gen_govcity_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_govcityEntity gen_govcity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_govcity, cmd, Database, true);
                            FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_govcityEntity gen_govcity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_govcity, cmd, Database);
                            FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_govcityEntity gen_govcity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_govcity, cmd, Database);
                            FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.Save_gen_govcity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_govcityEntity> listAdded, IList<gen_govcityEntity> listUpdated, IList<gen_govcityEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_govcity_Ins";
            const string SPUpdate = "gen_govcity_Upd";
            const string SPDelete = "gen_govcity_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_govcityEntity gen_govcity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_govcity, cmd, db, true);
                            FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, db);
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
                    foreach (gen_govcityEntity gen_govcity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_govcity, cmd, db);
                            FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, db);
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
                    foreach (gen_govcityEntity gen_govcity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_govcity, cmd, db);
                            FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.Save_gen_govcity"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_govcityEntity> Igen_govcityDataAccessObjects.GetAll(gen_govcityEntity gen_govcity)
        {
           try
            {
				const string SP = "gen_govcity_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_govcity.SortExpression);
                    FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_govcity, cmd, Database);
                    
                    IList<gen_govcityEntity> itemList = new List<gen_govcityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_govcityEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.GetAllgen_govcity"));
            }	
        }
		
		IList<gen_govcityEntity> Igen_govcityDataAccessObjects.GetAllByPages(gen_govcityEntity gen_govcity)
        {
        try
            {
				const string SP = "gen_govcity_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_govcity.SortExpression);
                    AddPageSizeParameter(cmd, gen_govcity.PageSize);
                    AddCurrentPageParameter(cmd, gen_govcity.CurrentPage);                    
                    FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_govcity, cmd,Database);

                    IList<gen_govcityEntity> itemList = new List<gen_govcityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_govcityEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_govcity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.GetAllByPagesgen_govcity"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_govcityDataAccessObjects.SaveMasterDetgen_building(gen_govcityEntity masterEntity, 
        IList<gen_buildingEntity> listAdded, 
        IList<gen_buildingEntity> listUpdated,
        IList<gen_buildingEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_govcity_Ins";
            const string MasterSPUpdate = "gen_govcity_Upd";
            const string MasterSPDelete = "gen_govcity_Del";
            
			
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
                                item.kwgovid=PrimaryKeyMaster;
                            }
                        }
                        gen_buildingDataAccessObjects objgen_building=new gen_buildingDataAccessObjects(this.Context);
                        objgen_building.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.SaveDsgen_govcity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_govcityDataAccessObjects.SaveMasterDethr_addresschange(gen_govcityEntity masterEntity, 
        IList<hr_addresschangeEntity> listAdded, 
        IList<hr_addresschangeEntity> listUpdated,
        IList<hr_addresschangeEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_govcity_Ins";
            const string MasterSPUpdate = "gen_govcity_Upd";
            const string MasterSPDelete = "gen_govcity_Del";
            
			
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
                                item.kwgovid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.SaveDsgen_govcity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_govcityDataAccessObjects.SaveMasterDethr_emergencycontact(gen_govcityEntity masterEntity, 
        IList<hr_emergencycontactEntity> listAdded, 
        IList<hr_emergencycontactEntity> listUpdated,
        IList<hr_emergencycontactEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_govcity_Ins";
            const string MasterSPUpdate = "gen_govcity_Upd";
            const string MasterSPDelete = "gen_govcity_Del";
            
			
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
                                item.curkwareaid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.SaveDsgen_govcity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_govcityDataAccessObjects.SaveMasterDethr_familyinfo(gen_govcityEntity masterEntity, 
        IList<hr_familyinfoEntity> listAdded, 
        IList<hr_familyinfoEntity> listUpdated,
        IList<hr_familyinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_govcity_Ins";
            const string MasterSPUpdate = "gen_govcity_Upd";
            const string MasterSPDelete = "gen_govcity_Del";
            
			
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
                                item.familycurareaid=PrimaryKeyMaster;
                            }
                        }
                        hr_familyinfoDataAccessObjects objhr_familyinfo=new hr_familyinfoDataAccessObjects(this.Context);
                        objhr_familyinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.SaveDsgen_govcity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_govcityDataAccessObjects.SaveMasterDethr_personalinfo(gen_govcityEntity masterEntity, 
        IList<hr_personalinfoEntity> listAdded, 
        IList<hr_personalinfoEntity> listUpdated,
        IList<hr_personalinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_govcity_Ins";
            const string MasterSPUpdate = "gen_govcity_Upd";
            const string MasterSPDelete = "gen_govcity_Del";
            
			
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
                                item.kwgovid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.SaveDsgen_govcity"));
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
        gen_govcityEntity Igen_govcityDataAccessObjects.GetSingle(gen_govcityEntity gen_govcity)
        {
           try
            {
				const string SP = "gen_govcity_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_govcity, cmd, Database);
                    
                    IList<gen_govcityEntity> itemList = new List<gen_govcityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_govcityEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.GetSinglegen_govcity"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_govcityEntity> Igen_govcityDataAccessObjects.GAPgListView(gen_govcityEntity gen_govcity)
        {
        try
            {
				const string SP = "gen_govcity_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_govcity.SortExpression);
                    AddPageSizeParameter(cmd, gen_govcity.PageSize);
                    AddCurrentPageParameter(cmd, gen_govcity.CurrentPage);                    
                    FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_govcity, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_govcity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_govcity.strCommonSerachParam);

                    IList<gen_govcityEntity> itemList = new List<gen_govcityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_govcityEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_govcity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_govcityDataAccess.GAPgListViewgen_govcity"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}