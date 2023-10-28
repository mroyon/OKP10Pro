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
	
	internal sealed partial class stp_organizationentityDataAccessObjects : BaseDataAccess, Istp_organizationentityDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_organizationentityDataAccessObjects";
        
		public stp_organizationentityDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_organizationentityEntity stp_organizationentity, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_organizationentity.entitykey.HasValue)
				Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, stp_organizationentity.entitykey);
            if (forDelete) return;
			if (stp_organizationentity.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_organizationentity.organizationkey);
			if (stp_organizationentity.parentkey.HasValue)
				Database.AddInParameter(cmd, "@ParentKey", DbType.Int64, stp_organizationentity.parentkey);
			if (stp_organizationentity.entirytypekey.HasValue)
				Database.AddInParameter(cmd, "@EntityTypeKey", DbType.Int64, stp_organizationentity.entirytypekey);
			if (stp_organizationentity.entitylevel.HasValue)
				Database.AddInParameter(cmd, "@EntityLevel", DbType.Int32, stp_organizationentity.entitylevel);
			if (!(string.IsNullOrEmpty(stp_organizationentity.seqfirstindex)))
				Database.AddInParameter(cmd, "@SeqFirstIndex", DbType.String, stp_organizationentity.seqfirstindex);
			if (!(string.IsNullOrEmpty(stp_organizationentity.seqfullindex)))
				Database.AddInParameter(cmd, "@SeqFullIndex", DbType.String, stp_organizationentity.seqfullindex);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitycode)))
				Database.AddInParameter(cmd, "@EntityCode", DbType.String, stp_organizationentity.entitycode);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entityname)))
				Database.AddInParameter(cmd, "@EntityName", DbType.String, stp_organizationentity.entityname);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitynamear)))
				Database.AddInParameter(cmd, "@EntityNameAr", DbType.String, stp_organizationentity.entitynamear);
			if (!(string.IsNullOrEmpty(stp_organizationentity.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, stp_organizationentity.description);
			if ((stp_organizationentity.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, stp_organizationentity.isactive);
			if (stp_organizationentity.entitystatus.HasValue)
				Database.AddInParameter(cmd, "@EntityStatus", DbType.Int64, stp_organizationentity.entitystatus);
			if (stp_organizationentity.entityseniority.HasValue)
				Database.AddInParameter(cmd, "@EntitySeniority", DbType.Int64, stp_organizationentity.entityseniority);
			if ((stp_organizationentity.entityidentitycode != null))
				Database.AddInParameter(cmd, "@EntityIdentityCode", DbType.String, stp_organizationentity.entityidentitycode);
			if ((stp_organizationentity.adidentitycode != null))
				Database.AddInParameter(cmd, "@ADIdentityCode", DbType.String, stp_organizationentity.adidentitycode);
			if (!(string.IsNullOrEmpty(stp_organizationentity.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, stp_organizationentity.remarks);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitylogo)))
				Database.AddInParameter(cmd, "@EntityLogo", DbType.String, stp_organizationentity.entitylogo);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitylogofiledescription)))
				Database.AddInParameter(cmd, "@EntityLogoFileDescription", DbType.String, stp_organizationentity.entitylogofiledescription);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitylogofilepath)))
				Database.AddInParameter(cmd, "@EntityLogoFilePath", DbType.String, stp_organizationentity.entitylogofilepath);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitylogofilename)))
				Database.AddInParameter(cmd, "@EntityLogoFileName", DbType.String, stp_organizationentity.entitylogofilename);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitylogofiletype)))
				Database.AddInParameter(cmd, "@EntityLogoFileType", DbType.String, stp_organizationentity.entitylogofiletype);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitylogoextension)))
				Database.AddInParameter(cmd, "@EntityLogoExtension", DbType.String, stp_organizationentity.entitylogoextension);
			
				Database.AddInParameter(cmd, "@EntityLogoFileNo", DbType.Guid, stp_organizationentity.entitylogofileno);
			if ((stp_organizationentity.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, stp_organizationentity.ex_date1);
			if ((stp_organizationentity.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, stp_organizationentity.ex_date2);
			if (!(string.IsNullOrEmpty(stp_organizationentity.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, stp_organizationentity.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(stp_organizationentity.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, stp_organizationentity.ex_nvarchar2);
			if (stp_organizationentity.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, stp_organizationentity.ex_bigint1);
			if (stp_organizationentity.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, stp_organizationentity.ex_bigint2);
			if (stp_organizationentity.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, stp_organizationentity.ex_decimal1);
			if (stp_organizationentity.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_organizationentity.ex_decimal2);

        }
		
        
		#region Add Operation

        long Istp_organizationentityDataAccessObjects.Add(stp_organizationentityEntity stp_organizationentity  )
        {
            long returnCode = -99;
            const string SP = "stp_organizationentity_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_organizationentity, cmd,Database);
                FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Addstp_organizationentity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Istp_organizationentityDataAccessObjects.Update(stp_organizationentityEntity stp_organizationentity )
        {
           long returnCode = -99;
            const string SP = "stp_organizationentity_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_organizationentity, cmd,Database);
                FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Updatestp_organizationentity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Istp_organizationentityDataAccessObjects.Delete(stp_organizationentityEntity stp_organizationentity)
        {
            long returnCode = -99;
           	const string SP = "stp_organizationentity_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_organizationentity, cmd,Database, true);
                FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Deletestp_organizationentity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Istp_organizationentityDataAccessObjects.SaveList(IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_organizationentity_Ins";
            const string SPUpdate = "stp_organizationentity_Upd";
            const string SPDelete = "stp_organizationentity_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationentityEntity stp_organizationentity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organizationentity, cmd, Database, true);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organizationentity, cmd, Database);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organizationentity, cmd, Database);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Save_stp_organizationentity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_organizationentity_Ins";
            const string SPUpdate = "stp_organizationentity_Upd";
            const string SPDelete = "stp_organizationentity_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationentityEntity stp_organizationentity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organizationentity, cmd, db, true);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organizationentity, cmd, db);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organizationentity, cmd, db);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Save_stp_organizationentity"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<stp_organizationentityEntity> Istp_organizationentityDataAccessObjects.GetAll(stp_organizationentityEntity stp_organizationentity)
        {
           try
            {
				const string SP = "stp_organizationentity_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentity, cmd, Database);
                    
                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetAllstp_organizationentity"));
            }	
        }
		
		IList<stp_organizationentityEntity> Istp_organizationentityDataAccessObjects.GetAllByPages(stp_organizationentityEntity stp_organizationentity)
        {
        try
            {
				const string SP = "stp_organizationentity_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentity.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentity.CurrentPage);                    
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organizationentity, cmd,Database);

                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organizationentity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetAllByPagesstp_organizationentity"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Istp_organizationentityDataAccessObjects.SaveMasterDetgen_arms(stp_organizationentityEntity masterEntity, 
        IList<gen_armsEntity> listAdded, 
        IList<gen_armsEntity> listUpdated,
        IList<gen_armsEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";
            
			
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
                                item.forceid=PrimaryKeyMaster;
                            }
                        }
                        gen_armsDataAccessObjects objgen_arms=new gen_armsDataAccessObjects(this.Context);
                        objgen_arms.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}


        long Istp_organizationentityDataAccessObjects.SaveMasterDethr_svcinfo(stp_organizationentityEntity masterEntity,
        IList<hr_svcinfoEntity> listAdded,
        IList<hr_svcinfoEntity> listUpdated,
        IList<hr_svcinfoEntity> listDeleted)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";


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

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.entitykey = PrimaryKeyMaster;
                            }
                        }
                        hr_svcinfoDataAccessObjects objhr_svcinfo = new hr_svcinfoDataAccessObjects(this.Context);
                        objhr_svcinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

  //      long Istp_organizationentityDataAccessObjects.SaveMasterDethr_relativesworkinginmod(stp_organizationentityEntity masterEntity, 
  //      IList<hr_relativesworkinginmodEntity> listAdded, 
  //      IList<hr_relativesworkinginmodEntity> listUpdated,
  //      IList<hr_relativesworkinginmodEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "stp_organizationentity_Ins";
  //          const string MasterSPUpdate = "stp_organizationentity_Upd";
  //          const string MasterSPDelete = "stp_organizationentity_Del";
            
			
  //          DbConnection connection = Database.CreateConnection();
  //          connection.Open();
  //          DbTransaction transaction = connection.BeginTransaction();
			
  //          if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
  //              SP = MasterSPInsert;
  //          else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
  //              SP = MasterSPUpdate;
  //          else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
  //               SP = MasterSPDelete;
  //          else
  //          {
  //              throw new Exception("Nothing to save.");
  //          }
  //          DateTime dt = DateTime.Now;
            
  //          try
  //          {
  //              using (DbCommand cmd = Database.GetStoredProcCommand(SP))
		//		{
  //                  if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
  //                  {
  //                      FillParameters(masterEntity, cmd, Database);
  //                  }
  //                  else
  //                  {
  //                      FillParameters(masterEntity, cmd, Database, true);
  //                  }
  //                  FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
  //                  AddOutputParameter(cmd, Database);
					
		//			if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
  //                  {
  //                      returnCode = Database.ExecuteNonQuery(cmd, transaction);
  //                      PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
  //                      masterEntity.RETURN_KEY = PrimaryKeyMaster;
  //                  }
  //                  else
  //                  {
  //                      returnCode = 1;
  //                  }
				
  //                  if (returnCode>0)
  //                  {
  //                      if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
  //                      {
  //                          foreach (var item in listAdded)
  //                          {
  //                              item.entitykey=PrimaryKeyMaster;
  //                          }
  //                      }
  //                      hr_relativesworkinginmodDataAccessObjects objhr_relativesworkinginmod=new hr_relativesworkinginmodDataAccessObjects(this.Context);
  //                      objhr_relativesworkinginmod.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
  //                  }
  //                  if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
  //                      returnCode = Database.ExecuteNonQuery(cmd, transaction);
  //                      cmd.Dispose();
  //              }
		//		transaction.Commit();                
		//	}
		//	catch (Exception ex)
  //          {
  //              transaction.Rollback();
  //              throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
  //          }
  //          finally
  //          {
  //              transaction.Dispose();
  //              connection.Close();
  //              connection = null;
  //          }
  //          return returnCode;
		//}
        
          
        long Istp_organizationentityDataAccessObjects.SaveMasterDetowin_userroledetlentitymap(stp_organizationentityEntity masterEntity, 
        IList<owin_userroledetlentitymapEntity> listAdded, 
        IList<owin_userroledetlentitymapEntity> listUpdated,
        IList<owin_userroledetlentitymapEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";
            
			
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
                                item.entitykey=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Istp_organizationentityDataAccessObjects.SaveMasterDetstp_organizationentity(stp_organizationentityEntity masterEntity, 
        IList<stp_organizationentityEntity> listAdded, 
        IList<stp_organizationentityEntity> listUpdated,
        IList<stp_organizationentityEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";
            
			
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
                                item.parentkey=PrimaryKeyMaster;
                            }
                        }
                        stp_organizationentityDataAccessObjects objstp_organizationentity=new stp_organizationentityDataAccessObjects(this.Context);
                        objstp_organizationentity.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Istp_organizationentityDataAccessObjects.SaveMasterDetuseraccountsprof(stp_organizationentityEntity masterEntity, 
        IList<useraccountsprofEntity> listAdded, 
        IList<useraccountsprofEntity> listUpdated,
        IList<useraccountsprofEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";
            
			
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
                                item.entitykey=PrimaryKeyMaster;
                            }
                        }
                        useraccountsprofDataAccessObjects objuseraccountsprof=new useraccountsprofDataAccessObjects(this.Context);
                        objuseraccountsprof.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
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
        stp_organizationentityEntity Istp_organizationentityDataAccessObjects.GetSingle(stp_organizationentityEntity stp_organizationentity)
        {
           try
            {
				const string SP = "stp_organizationentity_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentity, cmd, Database);
                    
                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetSinglestp_organizationentity"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<stp_organizationentityEntity> Istp_organizationentityDataAccessObjects.GAPgListView(stp_organizationentityEntity stp_organizationentity)
        {
        try
            {
				const string SP = "stp_organizationentity_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentity.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentity.CurrentPage);                    
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organizationentity, cmd,Database);
                    
					if (!string.IsNullOrEmpty (stp_organizationentity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, stp_organizationentity.strCommonSerachParam);

                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organizationentity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GAPgListViewstp_organizationentity"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}