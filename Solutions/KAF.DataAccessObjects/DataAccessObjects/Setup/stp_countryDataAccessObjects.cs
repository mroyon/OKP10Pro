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
	
	internal sealed partial class stp_countryDataAccessObjects : BaseDataAccess, Istp_countryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_countryDataAccessObjects";
        
		public stp_countryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_countryEntity stp_country, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_country.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, stp_country.countryid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(stp_country.countrynamear)))
				Database.AddInParameter(cmd, "@CountryNameAr", DbType.String, stp_country.countrynamear);
			if (!(string.IsNullOrEmpty(stp_country.countryname)))
				Database.AddInParameter(cmd, "@CountryName", DbType.String, stp_country.countryname);
			if ((stp_country.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, stp_country.ex_date1);
			if ((stp_country.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, stp_country.ex_date2);
			if (!(string.IsNullOrEmpty(stp_country.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, stp_country.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(stp_country.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, stp_country.ex_nvarchar2);
			if (stp_country.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, stp_country.ex_bigint1);
			if (stp_country.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, stp_country.ex_bigint2);
			if (stp_country.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, stp_country.ex_decimal1);
			if (stp_country.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_country.ex_decimal2);

        }
		
        
		#region Add Operation

        long Istp_countryDataAccessObjects.Add(stp_countryEntity stp_country  )
        {
            long returnCode = -99;
            const string SP = "stp_country_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_country, cmd,Database);
                FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.Addstp_country"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Istp_countryDataAccessObjects.Update(stp_countryEntity stp_country )
        {
           long returnCode = -99;
            const string SP = "stp_country_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_country, cmd,Database);
                FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.Updatestp_country"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Istp_countryDataAccessObjects.Delete(stp_countryEntity stp_country)
        {
            long returnCode = -99;
           	const string SP = "stp_country_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_country, cmd,Database, true);
                FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.Deletestp_country"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Istp_countryDataAccessObjects.SaveList(IList<stp_countryEntity> listAdded, IList<stp_countryEntity> listUpdated, IList<stp_countryEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_country_Ins";
            const string SPUpdate = "stp_country_Upd";
            const string SPDelete = "stp_country_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_countryEntity stp_country in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_country, cmd, Database, true);
                            FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_countryEntity stp_country in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_country, cmd, Database);
                            FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_countryEntity stp_country in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_country, cmd, Database);
                            FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.Save_stp_country"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<stp_countryEntity> listAdded, IList<stp_countryEntity> listUpdated, IList<stp_countryEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_country_Ins";
            const string SPUpdate = "stp_country_Upd";
            const string SPDelete = "stp_country_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_countryEntity stp_country in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_country, cmd, db, true);
                            FillSequrityParameters(stp_country.BaseSecurityParam, cmd, db);
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
                    foreach (stp_countryEntity stp_country in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_country, cmd, db);
                            FillSequrityParameters(stp_country.BaseSecurityParam, cmd, db);
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
                    foreach (stp_countryEntity stp_country in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_country, cmd, db);
                            FillSequrityParameters(stp_country.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.Save_stp_country"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<stp_countryEntity> Istp_countryDataAccessObjects.GetAll(stp_countryEntity stp_country)
        {
           try
            {
				const string SP = "stp_country_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_country.SortExpression);
                    FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_country, cmd, Database);
                    
                    IList<stp_countryEntity> itemList = new List<stp_countryEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countryEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.GetAllstp_country"));
            }	
        }
		
		IList<stp_countryEntity> Istp_countryDataAccessObjects.GetAllByPages(stp_countryEntity stp_country)
        {
        try
            {
				const string SP = "stp_country_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_country.SortExpression);
                    AddPageSizeParameter(cmd, stp_country.PageSize);
                    AddCurrentPageParameter(cmd, stp_country.CurrentPage);                    
                    FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_country, cmd,Database);

                    IList<stp_countryEntity> itemList = new List<stp_countryEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countryEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_country.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.GetAllByPagesstp_country"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Istp_countryDataAccessObjects.SaveMasterDetstp_countrycity(stp_countryEntity masterEntity, 
        IList<stp_countrycityEntity> listAdded, 
        IList<stp_countrycityEntity> listUpdated,
        IList<stp_countrycityEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_country_Ins";
            const string MasterSPUpdate = "stp_country_Upd";
            const string MasterSPDelete = "stp_country_Del";
            
			
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
                                item.countryid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.SaveDsstp_country"));
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
        stp_countryEntity Istp_countryDataAccessObjects.GetSingle(stp_countryEntity stp_country)
        {
           try
            {
				const string SP = "stp_country_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_country, cmd, Database);
                    
                    IList<stp_countryEntity> itemList = new List<stp_countryEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.GetSinglestp_country"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<stp_countryEntity> Istp_countryDataAccessObjects.GAPgListView(stp_countryEntity stp_country)
        {
        try
            {
				const string SP = "stp_country_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_country.SortExpression);
                    AddPageSizeParameter(cmd, stp_country.PageSize);
                    AddCurrentPageParameter(cmd, stp_country.CurrentPage);                    
                    FillSequrityParameters(stp_country.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_country, cmd,Database);

                    IList<stp_countryEntity> itemList = new List<stp_countryEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_countryEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_country.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_countryDataAccess.GAPgListViewstp_country"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}