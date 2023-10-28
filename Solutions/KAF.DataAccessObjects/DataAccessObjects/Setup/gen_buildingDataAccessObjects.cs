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
	
	internal sealed partial class gen_buildingDataAccessObjects : BaseDataAccess, Igen_buildingDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_buildingDataAccessObjects";
        
		public gen_buildingDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_buildingEntity gen_building, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_building.buildingid.HasValue)
				Database.AddInParameter(cmd, "@BuildingID", DbType.Int64, gen_building.buildingid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_building.buildingname)))
				Database.AddInParameter(cmd, "@BuildingName", DbType.String, gen_building.buildingname);
			if (gen_building.kwgovid.HasValue)
				Database.AddInParameter(cmd, "@KWGovID", DbType.Int64, gen_building.kwgovid);
			if (gen_building.kwareaid.HasValue)
				Database.AddInParameter(cmd, "@KWAreaID", DbType.Int64, gen_building.kwareaid);
			if (!(string.IsNullOrEmpty(gen_building.kwblockno)))
				Database.AddInParameter(cmd, "@KWBlockNo", DbType.String, gen_building.kwblockno);
			if (!(string.IsNullOrEmpty(gen_building.kwstreet)))
				Database.AddInParameter(cmd, "@KWStreet", DbType.String, gen_building.kwstreet);
			if (!(string.IsNullOrEmpty(gen_building.kwhouseno)))
				Database.AddInParameter(cmd, "@KWHouseNo", DbType.String, gen_building.kwhouseno);
			if ((gen_building.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_building.isactive);
			if (!(string.IsNullOrEmpty(gen_building.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_building.remarks);
			if ((gen_building.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_building.ex_date1);
			if ((gen_building.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_building.ex_date2);
			if (!(string.IsNullOrEmpty(gen_building.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_building.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_building.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_building.ex_nvarchar2);
			if (gen_building.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_building.ex_bigint1);
			if (gen_building.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_building.ex_bigint2);
			if (gen_building.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_building.ex_decimal1);
			if (gen_building.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_building.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_buildingDataAccessObjects.Add(gen_buildingEntity gen_building  )
        {
            long returnCode = -99;
            const string SP = "gen_building_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_building, cmd,Database);
                FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.Addgen_building"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_buildingDataAccessObjects.Update(gen_buildingEntity gen_building )
        {
           long returnCode = -99;
            const string SP = "gen_building_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_building, cmd,Database);
                FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.Updategen_building"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_buildingDataAccessObjects.Delete(gen_buildingEntity gen_building)
        {
            long returnCode = -99;
           	const string SP = "gen_building_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_building, cmd,Database, true);
                FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.Deletegen_building"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_buildingDataAccessObjects.SaveList(IList<gen_buildingEntity> listAdded, IList<gen_buildingEntity> listUpdated, IList<gen_buildingEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_building_Ins";
            const string SPUpdate = "gen_building_Upd";
            const string SPDelete = "gen_building_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_buildingEntity gen_building in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_building, cmd, Database, true);
                            FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_buildingEntity gen_building in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_building, cmd, Database);
                            FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_buildingEntity gen_building in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_building, cmd, Database);
                            FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.Save_gen_building"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_buildingEntity> listAdded, IList<gen_buildingEntity> listUpdated, IList<gen_buildingEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_building_Ins";
            const string SPUpdate = "gen_building_Upd";
            const string SPDelete = "gen_building_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_buildingEntity gen_building in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_building, cmd, db, true);
                            FillSequrityParameters(gen_building.BaseSecurityParam, cmd, db);
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
                    foreach (gen_buildingEntity gen_building in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_building, cmd, db);
                            FillSequrityParameters(gen_building.BaseSecurityParam, cmd, db);
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
                    foreach (gen_buildingEntity gen_building in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_building, cmd, db);
                            FillSequrityParameters(gen_building.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.Save_gen_building"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_buildingEntity> Igen_buildingDataAccessObjects.GetAll(gen_buildingEntity gen_building)
        {
           try
            {
				const string SP = "gen_building_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_building.SortExpression);
                    FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_building, cmd, Database);
                    
                    IList<gen_buildingEntity> itemList = new List<gen_buildingEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_buildingEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.GetAllgen_building"));
            }	
        }
		
		IList<gen_buildingEntity> Igen_buildingDataAccessObjects.GetAllByPages(gen_buildingEntity gen_building)
        {
        try
            {
				const string SP = "gen_building_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_building.SortExpression);
                    AddPageSizeParameter(cmd, gen_building.PageSize);
                    AddCurrentPageParameter(cmd, gen_building.CurrentPage);                    
                    FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_building, cmd,Database);

                    IList<gen_buildingEntity> itemList = new List<gen_buildingEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_buildingEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_building.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.GetAllByPagesgen_building"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_buildingDataAccessObjects.SaveMasterDethr_addresschange(gen_buildingEntity masterEntity, 
        IList<hr_addresschangeEntity> listAdded, 
        IList<hr_addresschangeEntity> listUpdated,
        IList<hr_addresschangeEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_building_Ins";
            const string MasterSPUpdate = "gen_building_Upd";
            const string MasterSPDelete = "gen_building_Del";
            
			
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
                                item.buildingid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.SaveDsgen_building"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Igen_buildingDataAccessObjects.SaveMasterDethr_personalinfo(gen_buildingEntity masterEntity, 
        IList<hr_personalinfoEntity> listAdded, 
        IList<hr_personalinfoEntity> listUpdated,
        IList<hr_personalinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_building_Ins";
            const string MasterSPUpdate = "gen_building_Upd";
            const string MasterSPDelete = "gen_building_Del";
            
			
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
                                item.buildingid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.SaveDsgen_building"));
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
        gen_buildingEntity Igen_buildingDataAccessObjects.GetSingle(gen_buildingEntity gen_building)
        {
           try
            {
				const string SP = "gen_building_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_building, cmd, Database);
                    
                    IList<gen_buildingEntity> itemList = new List<gen_buildingEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_buildingEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.GetSinglegen_building"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_buildingEntity> Igen_buildingDataAccessObjects.GAPgListView(gen_buildingEntity gen_building)
        {
        try
            {
				const string SP = "gen_building_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_building.SortExpression);
                    AddPageSizeParameter(cmd, gen_building.PageSize);
                    AddCurrentPageParameter(cmd, gen_building.CurrentPage);                    
                    FillSequrityParameters(gen_building.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_building, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_building.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_building.strCommonSerachParam);

                    IList<gen_buildingEntity> itemList = new List<gen_buildingEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_buildingEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_building.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_buildingDataAccess.GAPgListViewgen_building"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}