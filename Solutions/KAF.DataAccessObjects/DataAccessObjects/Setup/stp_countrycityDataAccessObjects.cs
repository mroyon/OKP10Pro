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
	
	internal sealed partial class stp_countrycityDataAccessObjects : BaseDataAccess, Istp_countrycityDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_countrycityDataAccessObjects";
        
		public stp_countrycityDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_countrycityEntity stp_countrycity, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_countrycity.cityid.HasValue)
				Database.AddInParameter(cmd, "@CityID", DbType.Int64, stp_countrycity.cityid);
            if (forDelete) return;
			if (stp_countrycity.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, stp_countrycity.countryid);
			if (stp_countrycity.parentcityid.HasValue)
				Database.AddInParameter(cmd, "@ParentCityID", DbType.Int64, stp_countrycity.parentcityid);
			if (stp_countrycity.levelnumber.HasValue)
				Database.AddInParameter(cmd, "@LevelNumber", DbType.Int64, stp_countrycity.levelnumber);
			if (!(string.IsNullOrEmpty(stp_countrycity.citynamear)))
				Database.AddInParameter(cmd, "@CityNameAr", DbType.String, stp_countrycity.citynamear);
			if (!(string.IsNullOrEmpty(stp_countrycity.cityname)))
				Database.AddInParameter(cmd, "@CityName", DbType.String, stp_countrycity.cityname);
			if ((stp_countrycity.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, stp_countrycity.ex_date1);
			if ((stp_countrycity.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, stp_countrycity.ex_date2);
			if (!(string.IsNullOrEmpty(stp_countrycity.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, stp_countrycity.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(stp_countrycity.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, stp_countrycity.ex_nvarchar2);
			if (stp_countrycity.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, stp_countrycity.ex_bigint1);
			if (stp_countrycity.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, stp_countrycity.ex_bigint2);
			if (stp_countrycity.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, stp_countrycity.ex_decimal1);
			if (stp_countrycity.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_countrycity.ex_decimal2);

        }
		
        
		#region Add Operation

        long Istp_countrycityDataAccessObjects.Add(stp_countrycityEntity stp_countrycity  )
        {
            long returnCode = -99;
            const string SP = "stp_countrycity_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_countrycity, cmd,Database);
                FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.Addstp_countrycity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Istp_countrycityDataAccessObjects.Update(stp_countrycityEntity stp_countrycity )
        {
           long returnCode = -99;
            const string SP = "stp_countrycity_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_countrycity, cmd,Database);
                FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.Updatestp_countrycity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Istp_countrycityDataAccessObjects.Delete(stp_countrycityEntity stp_countrycity)
        {
            long returnCode = -99;
           	const string SP = "stp_countrycity_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_countrycity, cmd,Database, true);
                FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.Deletestp_countrycity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Istp_countrycityDataAccessObjects.SaveList(IList<stp_countrycityEntity> listAdded, IList<stp_countrycityEntity> listUpdated, IList<stp_countrycityEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_countrycity_Ins";
            const string SPUpdate = "stp_countrycity_Upd";
            const string SPDelete = "stp_countrycity_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_countrycityEntity stp_countrycity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_countrycity, cmd, Database, true);
                            FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_countrycityEntity stp_countrycity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_countrycity, cmd, Database);
                            FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_countrycityEntity stp_countrycity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_countrycity, cmd, Database);
                            FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.Save_stp_countrycity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<stp_countrycityEntity> listAdded, IList<stp_countrycityEntity> listUpdated, IList<stp_countrycityEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_countrycity_Ins";
            const string SPUpdate = "stp_countrycity_Upd";
            const string SPDelete = "stp_countrycity_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_countrycityEntity stp_countrycity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_countrycity, cmd, db, true);
                            FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, db);
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
                    foreach (stp_countrycityEntity stp_countrycity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_countrycity, cmd, db);
                            FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, db);
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
                    foreach (stp_countrycityEntity stp_countrycity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_countrycity, cmd, db);
                            FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.Save_stp_countrycity"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<stp_countrycityEntity> Istp_countrycityDataAccessObjects.GetAll(stp_countrycityEntity stp_countrycity)
        {
           try
            {
				const string SP = "stp_countrycity_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_countrycity.SortExpression);
                    FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_countrycity, cmd, Database);
                    
                    IList<stp_countrycityEntity> itemList = new List<stp_countrycityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countrycityEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.GetAllstp_countrycity"));
            }	
        }
		
		IList<stp_countrycityEntity> Istp_countrycityDataAccessObjects.GetAllByPages(stp_countrycityEntity stp_countrycity)
        {
        try
            {
				const string SP = "stp_countrycity_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_countrycity.SortExpression);
                    AddPageSizeParameter(cmd, stp_countrycity.PageSize);
                    AddCurrentPageParameter(cmd, stp_countrycity.CurrentPage);                    
                    FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_countrycity, cmd,Database);

                    IList<stp_countrycityEntity> itemList = new List<stp_countrycityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countrycityEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_countrycity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.GetAllByPagesstp_countrycity"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Istp_countrycityDataAccessObjects.SaveMasterDetstp_countrycity(stp_countrycityEntity masterEntity, 
        IList<stp_countrycityEntity> listAdded, 
        IList<stp_countrycityEntity> listUpdated,
        IList<stp_countrycityEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_countrycity_Ins";
            const string MasterSPUpdate = "stp_countrycity_Upd";
            const string MasterSPDelete = "stp_countrycity_Del";
            
			
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
                                item.parentcityid=PrimaryKeyMaster;
                            }
                        }
                        stp_countrycityDataAccessObjects objstp_countrycity=new stp_countrycityDataAccessObjects(this.Context);
                        objstp_countrycity.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.SaveDsstp_countrycity"));
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
        stp_countrycityEntity Istp_countrycityDataAccessObjects.GetSingle(stp_countrycityEntity stp_countrycity)
        {
           try
            {
				const string SP = "stp_countrycity_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_countrycity, cmd, Database);
                    
                    IList<stp_countrycityEntity> itemList = new List<stp_countrycityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countrycityEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.GetSinglestp_countrycity"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<stp_countrycityEntity> Istp_countrycityDataAccessObjects.GAPgListView(stp_countrycityEntity stp_countrycity)
        {
        try
            {
				const string SP = "stp_countrycity_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_countrycity.SortExpression);
                    AddPageSizeParameter(cmd, stp_countrycity.PageSize);
                    AddCurrentPageParameter(cmd, stp_countrycity.CurrentPage);                    
                    FillSequrityParameters(stp_countrycity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_countrycity, cmd,Database);

                    IList<stp_countrycityEntity> itemList = new List<stp_countrycityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countrycityEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_countrycity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_countrycityDataAccess.GAPgListViewstp_countrycity"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}