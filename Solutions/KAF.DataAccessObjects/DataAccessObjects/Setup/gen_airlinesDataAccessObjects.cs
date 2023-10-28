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
	
	internal sealed partial class gen_airlinesDataAccessObjects : BaseDataAccess, Igen_airlinesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_airlinesDataAccessObjects";
        
		public gen_airlinesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_airlinesEntity gen_airlines, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_airlines.airlinesid.HasValue)
				Database.AddInParameter(cmd, "@AirlinesID", DbType.Int64, gen_airlines.airlinesid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_airlines.airlinesname)))
				Database.AddInParameter(cmd, "@AirlinesName", DbType.String, gen_airlines.airlinesname);
			if (!(string.IsNullOrEmpty(gen_airlines.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_airlines.remarks);
			if ((gen_airlines.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_airlines.ex_date1);
			if ((gen_airlines.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_airlines.ex_date2);
			if (!(string.IsNullOrEmpty(gen_airlines.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_airlines.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_airlines.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_airlines.ex_nvarchar2);
			if (gen_airlines.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_airlines.ex_bigint1);
			if (gen_airlines.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_airlines.ex_bigint2);
			if (gen_airlines.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_airlines.ex_decimal1);
			if (gen_airlines.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_airlines.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_airlinesDataAccessObjects.Add(gen_airlinesEntity gen_airlines  )
        {
            long returnCode = -99;
            const string SP = "gen_airlines_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_airlines, cmd,Database);
                FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.Addgen_airlines"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_airlinesDataAccessObjects.Update(gen_airlinesEntity gen_airlines )
        {
           long returnCode = -99;
            const string SP = "gen_airlines_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_airlines, cmd,Database);
                FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.Updategen_airlines"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_airlinesDataAccessObjects.Delete(gen_airlinesEntity gen_airlines)
        {
            long returnCode = -99;
           	const string SP = "gen_airlines_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_airlines, cmd,Database, true);
                FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.Deletegen_airlines"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_airlinesDataAccessObjects.SaveList(IList<gen_airlinesEntity> listAdded, IList<gen_airlinesEntity> listUpdated, IList<gen_airlinesEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_airlines_Ins";
            const string SPUpdate = "gen_airlines_Upd";
            const string SPDelete = "gen_airlines_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_airlinesEntity gen_airlines in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_airlines, cmd, Database, true);
                            FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_airlinesEntity gen_airlines in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_airlines, cmd, Database);
                            FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_airlinesEntity gen_airlines in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_airlines, cmd, Database);
                            FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.Save_gen_airlines"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_airlinesEntity> listAdded, IList<gen_airlinesEntity> listUpdated, IList<gen_airlinesEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_airlines_Ins";
            const string SPUpdate = "gen_airlines_Upd";
            const string SPDelete = "gen_airlines_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_airlinesEntity gen_airlines in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_airlines, cmd, db, true);
                            FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, db);
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
                    foreach (gen_airlinesEntity gen_airlines in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_airlines, cmd, db);
                            FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, db);
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
                    foreach (gen_airlinesEntity gen_airlines in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_airlines, cmd, db);
                            FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.Save_gen_airlines"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_airlinesEntity> Igen_airlinesDataAccessObjects.GetAll(gen_airlinesEntity gen_airlines)
        {
           try
            {
				const string SP = "gen_airlines_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_airlines.SortExpression);
                    FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_airlines, cmd, Database);
                    
                    IList<gen_airlinesEntity> itemList = new List<gen_airlinesEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_airlinesEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.GetAllgen_airlines"));
            }	
        }
		
		IList<gen_airlinesEntity> Igen_airlinesDataAccessObjects.GetAllByPages(gen_airlinesEntity gen_airlines)
        {
        try
            {
				const string SP = "gen_airlines_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_airlines.SortExpression);
                    AddPageSizeParameter(cmd, gen_airlines.PageSize);
                    AddCurrentPageParameter(cmd, gen_airlines.CurrentPage);                    
                    FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_airlines, cmd,Database);

                    IList<gen_airlinesEntity> itemList = new List<gen_airlinesEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_airlinesEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_airlines.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.GetAllByPagesgen_airlines"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_airlinesDataAccessObjects.SaveMasterDethr_flightinfo(gen_airlinesEntity masterEntity, 
        IList<hr_flightinfoEntity> listAdded, 
        IList<hr_flightinfoEntity> listUpdated,
        IList<hr_flightinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_airlines_Ins";
            const string MasterSPUpdate = "gen_airlines_Upd";
            const string MasterSPDelete = "gen_airlines_Del";
            
			
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
                                item.airlinesid=PrimaryKeyMaster;
                            }
                        }
                        hr_flightinfoDataAccessObjects objhr_flightinfo=new hr_flightinfoDataAccessObjects(this.Context);
                        objhr_flightinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.SaveDsgen_airlines"));
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
        gen_airlinesEntity Igen_airlinesDataAccessObjects.GetSingle(gen_airlinesEntity gen_airlines)
        {
           try
            {
				const string SP = "gen_airlines_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_airlines, cmd, Database);
                    
                    IList<gen_airlinesEntity> itemList = new List<gen_airlinesEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_airlinesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.GetSinglegen_airlines"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_airlinesEntity> Igen_airlinesDataAccessObjects.GAPgListView(gen_airlinesEntity gen_airlines)
        {
        try
            {
				const string SP = "gen_airlines_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_airlines.SortExpression);
                    AddPageSizeParameter(cmd, gen_airlines.PageSize);
                    AddCurrentPageParameter(cmd, gen_airlines.CurrentPage);                    
                    FillSequrityParameters(gen_airlines.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_airlines, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_airlines.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_airlines.strCommonSerachParam);

                    IList<gen_airlinesEntity> itemList = new List<gen_airlinesEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_airlinesEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_airlines.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_airlinesDataAccess.GAPgListViewgen_airlines"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}