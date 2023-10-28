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
	
	internal sealed partial class gen_divisiondistrictDataAccessObjects : BaseDataAccess, Igen_divisiondistrictDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_divisiondistrictDataAccessObjects";
        
		public gen_divisiondistrictDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_divisiondistrictEntity gen_divisiondistrict, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_divisiondistrict.districtid.HasValue)
				Database.AddInParameter(cmd, "@DistrictID", DbType.Int64, gen_divisiondistrict.districtid);
            if (forDelete) return;
			if (gen_divisiondistrict.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, gen_divisiondistrict.parentid);
			if (!(string.IsNullOrEmpty(gen_divisiondistrict.districtname)))
				Database.AddInParameter(cmd, "@DistrictName", DbType.String, gen_divisiondistrict.districtname);
			if ((gen_divisiondistrict.isdivision != null))
				Database.AddInParameter(cmd, "@IsDivision", DbType.Boolean, gen_divisiondistrict.isdivision);
			if (gen_divisiondistrict.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_divisiondistrict.countryid);
			if (!(string.IsNullOrEmpty(gen_divisiondistrict.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_divisiondistrict.remarks);
			if ((gen_divisiondistrict.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_divisiondistrict.ex_date1);
			if ((gen_divisiondistrict.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_divisiondistrict.ex_date2);
			if (!(string.IsNullOrEmpty(gen_divisiondistrict.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_divisiondistrict.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_divisiondistrict.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_divisiondistrict.ex_nvarchar2);
			if (gen_divisiondistrict.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_divisiondistrict.ex_bigint1);
			if (gen_divisiondistrict.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_divisiondistrict.ex_bigint2);
			if (gen_divisiondistrict.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_divisiondistrict.ex_decimal1);
			if (gen_divisiondistrict.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_divisiondistrict.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_divisiondistrictDataAccessObjects.Add(gen_divisiondistrictEntity gen_divisiondistrict  )
        {
            long returnCode = -99;
            const string SP = "gen_divisiondistrict_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_divisiondistrict, cmd,Database);
                FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.Addgen_divisiondistrict"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_divisiondistrictDataAccessObjects.Update(gen_divisiondistrictEntity gen_divisiondistrict )
        {
           long returnCode = -99;
            const string SP = "gen_divisiondistrict_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_divisiondistrict, cmd,Database);
                FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.Updategen_divisiondistrict"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_divisiondistrictDataAccessObjects.Delete(gen_divisiondistrictEntity gen_divisiondistrict)
        {
            long returnCode = -99;
           	const string SP = "gen_divisiondistrict_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_divisiondistrict, cmd,Database, true);
                FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.Deletegen_divisiondistrict"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_divisiondistrictDataAccessObjects.SaveList(IList<gen_divisiondistrictEntity> listAdded, IList<gen_divisiondistrictEntity> listUpdated, IList<gen_divisiondistrictEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_divisiondistrict_Ins";
            const string SPUpdate = "gen_divisiondistrict_Upd";
            const string SPDelete = "gen_divisiondistrict_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_divisiondistrictEntity gen_divisiondistrict in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_divisiondistrict, cmd, Database, true);
                            FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_divisiondistrictEntity gen_divisiondistrict in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_divisiondistrict, cmd, Database);
                            FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_divisiondistrictEntity gen_divisiondistrict in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_divisiondistrict, cmd, Database);
                            FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.Save_gen_divisiondistrict"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_divisiondistrictEntity> listAdded, IList<gen_divisiondistrictEntity> listUpdated, IList<gen_divisiondistrictEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_divisiondistrict_Ins";
            const string SPUpdate = "gen_divisiondistrict_Upd";
            const string SPDelete = "gen_divisiondistrict_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_divisiondistrictEntity gen_divisiondistrict in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_divisiondistrict, cmd, db, true);
                            FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, db);
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
                    foreach (gen_divisiondistrictEntity gen_divisiondistrict in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_divisiondistrict, cmd, db);
                            FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, db);
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
                    foreach (gen_divisiondistrictEntity gen_divisiondistrict in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_divisiondistrict, cmd, db);
                            FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.Save_gen_divisiondistrict"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_divisiondistrictEntity> Igen_divisiondistrictDataAccessObjects.GetAll(gen_divisiondistrictEntity gen_divisiondistrict)
        {
           try
            {
				const string SP = "gen_divisiondistrict_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_divisiondistrict.SortExpression);
                    FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_divisiondistrict, cmd, Database);
                    
                    IList<gen_divisiondistrictEntity> itemList = new List<gen_divisiondistrictEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_divisiondistrictEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.GetAllgen_divisiondistrict"));
            }	
        }
		
		IList<gen_divisiondistrictEntity> Igen_divisiondistrictDataAccessObjects.GetAllByPages(gen_divisiondistrictEntity gen_divisiondistrict)
        {
        try
            {
				const string SP = "gen_divisiondistrict_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_divisiondistrict.SortExpression);
                    AddPageSizeParameter(cmd, gen_divisiondistrict.PageSize);
                    AddCurrentPageParameter(cmd, gen_divisiondistrict.CurrentPage);                    
                    FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_divisiondistrict, cmd,Database);

                    IList<gen_divisiondistrictEntity> itemList = new List<gen_divisiondistrictEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_divisiondistrictEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_divisiondistrict.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.GetAllByPagesgen_divisiondistrict"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_divisiondistrictDataAccessObjects.SaveMasterDetgen_divisiondistrict(gen_divisiondistrictEntity masterEntity, 
        IList<gen_divisiondistrictEntity> listAdded, 
        IList<gen_divisiondistrictEntity> listUpdated,
        IList<gen_divisiondistrictEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_divisiondistrict_Ins";
            const string MasterSPUpdate = "gen_divisiondistrict_Upd";
            const string MasterSPDelete = "gen_divisiondistrict_Del";
            
			
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
                                item.parentid=PrimaryKeyMaster;
                            }
                        }
                        gen_divisiondistrictDataAccessObjects objgen_divisiondistrict=new gen_divisiondistrictDataAccessObjects(this.Context);
                        objgen_divisiondistrict.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.SaveDsgen_divisiondistrict"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_divisiondistrictDataAccessObjects.SaveMasterDetgen_thana(gen_divisiondistrictEntity masterEntity, 
        IList<gen_thanaEntity> listAdded, 
        IList<gen_thanaEntity> listUpdated,
        IList<gen_thanaEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_divisiondistrict_Ins";
            const string MasterSPUpdate = "gen_divisiondistrict_Upd";
            const string MasterSPDelete = "gen_divisiondistrict_Del";
            
			
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
                                item.districtid=PrimaryKeyMaster;
                            }
                        }
                        gen_thanaDataAccessObjects objgen_thana=new gen_thanaDataAccessObjects(this.Context);
                        objgen_thana.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.SaveDsgen_divisiondistrict"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_divisiondistrictDataAccessObjects.SaveMasterDethr_addresschange(gen_divisiondistrictEntity masterEntity, 
        IList<hr_addresschangeEntity> listAdded, 
        IList<hr_addresschangeEntity> listUpdated,
        IList<hr_addresschangeEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_divisiondistrict_Ins";
            const string MasterSPUpdate = "gen_divisiondistrict_Upd";
            const string MasterSPDelete = "gen_divisiondistrict_Del";
            
			
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
                                item.bdcurdivid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.SaveDsgen_divisiondistrict"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_divisiondistrictDataAccessObjects.SaveMasterDethr_emergencycontact(gen_divisiondistrictEntity masterEntity, 
        IList<hr_emergencycontactEntity> listAdded, 
        IList<hr_emergencycontactEntity> listUpdated,
        IList<hr_emergencycontactEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_divisiondistrict_Ins";
            const string MasterSPUpdate = "gen_divisiondistrict_Upd";
            const string MasterSPDelete = "gen_divisiondistrict_Del";
            
			
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
                                item.curbdaddressdist=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.SaveDsgen_divisiondistrict"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_divisiondistrictDataAccessObjects.SaveMasterDethr_personalinfo(gen_divisiondistrictEntity masterEntity, 
        IList<hr_personalinfoEntity> listAdded, 
        IList<hr_personalinfoEntity> listUpdated,
        IList<hr_personalinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_divisiondistrict_Ins";
            const string MasterSPUpdate = "gen_divisiondistrict_Upd";
            const string MasterSPDelete = "gen_divisiondistrict_Del";
            
			
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
                                item.bdcurdivid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.SaveDsgen_divisiondistrict"));
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
        gen_divisiondistrictEntity Igen_divisiondistrictDataAccessObjects.GetSingle(gen_divisiondistrictEntity gen_divisiondistrict)
        {
           try
            {
				const string SP = "gen_divisiondistrict_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_divisiondistrict, cmd, Database);
                    
                    IList<gen_divisiondistrictEntity> itemList = new List<gen_divisiondistrictEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_divisiondistrictEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.GetSinglegen_divisiondistrict"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_divisiondistrictEntity> Igen_divisiondistrictDataAccessObjects.GAPgListView(gen_divisiondistrictEntity gen_divisiondistrict)
        {
        try
            {
				const string SP = "gen_divisiondistrict_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_divisiondistrict.SortExpression);
                    AddPageSizeParameter(cmd, gen_divisiondistrict.PageSize);
                    AddCurrentPageParameter(cmd, gen_divisiondistrict.CurrentPage);                    
                    FillSequrityParameters(gen_divisiondistrict.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_divisiondistrict, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_divisiondistrict.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_divisiondistrict.strCommonSerachParam);

                    IList<gen_divisiondistrictEntity> itemList = new List<gen_divisiondistrictEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_divisiondistrictEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_divisiondistrict.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_divisiondistrictDataAccess.GAPgListViewgen_divisiondistrict"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}