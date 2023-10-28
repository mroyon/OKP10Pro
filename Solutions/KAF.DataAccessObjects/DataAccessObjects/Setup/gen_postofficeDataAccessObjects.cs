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
	
	internal sealed partial class gen_postofficeDataAccessObjects : BaseDataAccess, Igen_postofficeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_postofficeDataAccessObjects";
        
		public gen_postofficeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_postofficeEntity gen_postoffice, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_postoffice.postofficeid.HasValue)
				Database.AddInParameter(cmd, "@PostOfficeID", DbType.Int64, gen_postoffice.postofficeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_postoffice.postofficename)))
				Database.AddInParameter(cmd, "@PostOfficeName", DbType.String, gen_postoffice.postofficename);
			if (gen_postoffice.thanaid.HasValue)
				Database.AddInParameter(cmd, "@ThanaID", DbType.Int64, gen_postoffice.thanaid);
			if (gen_postoffice.postofficecode.HasValue)
				Database.AddInParameter(cmd, "@PostOfficeCode", DbType.Int64, gen_postoffice.postofficecode);
			if (!(string.IsNullOrEmpty(gen_postoffice.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_postoffice.remarks);
			if ((gen_postoffice.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_postoffice.ex_date1);
			if ((gen_postoffice.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_postoffice.ex_date2);
			if (!(string.IsNullOrEmpty(gen_postoffice.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_postoffice.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_postoffice.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_postoffice.ex_nvarchar2);
			if (gen_postoffice.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_postoffice.ex_bigint1);
			if (gen_postoffice.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_postoffice.ex_bigint2);
			if (gen_postoffice.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_postoffice.ex_decimal1);
			if (gen_postoffice.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_postoffice.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_postofficeDataAccessObjects.Add(gen_postofficeEntity gen_postoffice  )
        {
            long returnCode = -99;
            const string SP = "gen_postoffice_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_postoffice, cmd,Database);
                FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.Addgen_postoffice"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_postofficeDataAccessObjects.Update(gen_postofficeEntity gen_postoffice )
        {
           long returnCode = -99;
            const string SP = "gen_postoffice_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_postoffice, cmd,Database);
                FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.Updategen_postoffice"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_postofficeDataAccessObjects.Delete(gen_postofficeEntity gen_postoffice)
        {
            long returnCode = -99;
           	const string SP = "gen_postoffice_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_postoffice, cmd,Database, true);
                FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.Deletegen_postoffice"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_postofficeDataAccessObjects.SaveList(IList<gen_postofficeEntity> listAdded, IList<gen_postofficeEntity> listUpdated, IList<gen_postofficeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_postoffice_Ins";
            const string SPUpdate = "gen_postoffice_Upd";
            const string SPDelete = "gen_postoffice_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_postofficeEntity gen_postoffice in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_postoffice, cmd, Database, true);
                            FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_postofficeEntity gen_postoffice in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_postoffice, cmd, Database);
                            FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_postofficeEntity gen_postoffice in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_postoffice, cmd, Database);
                            FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.Save_gen_postoffice"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_postofficeEntity> listAdded, IList<gen_postofficeEntity> listUpdated, IList<gen_postofficeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_postoffice_Ins";
            const string SPUpdate = "gen_postoffice_Upd";
            const string SPDelete = "gen_postoffice_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_postofficeEntity gen_postoffice in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_postoffice, cmd, db, true);
                            FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, db);
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
                    foreach (gen_postofficeEntity gen_postoffice in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_postoffice, cmd, db);
                            FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, db);
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
                    foreach (gen_postofficeEntity gen_postoffice in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_postoffice, cmd, db);
                            FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.Save_gen_postoffice"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_postofficeEntity> Igen_postofficeDataAccessObjects.GetAll(gen_postofficeEntity gen_postoffice)
        {
           try
            {
				const string SP = "gen_postoffice_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_postoffice.SortExpression);
                    FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_postoffice, cmd, Database);
                    
                    IList<gen_postofficeEntity> itemList = new List<gen_postofficeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_postofficeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.GetAllgen_postoffice"));
            }	
        }
		
		IList<gen_postofficeEntity> Igen_postofficeDataAccessObjects.GetAllByPages(gen_postofficeEntity gen_postoffice)
        {
        try
            {
				const string SP = "gen_postoffice_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_postoffice.SortExpression);
                    AddPageSizeParameter(cmd, gen_postoffice.PageSize);
                    AddCurrentPageParameter(cmd, gen_postoffice.CurrentPage);                    
                    FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_postoffice, cmd,Database);

                    IList<gen_postofficeEntity> itemList = new List<gen_postofficeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_postofficeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_postoffice.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.GetAllByPagesgen_postoffice"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_postofficeDataAccessObjects.SaveMasterDethr_emergencycontact(gen_postofficeEntity masterEntity, 
        IList<hr_emergencycontactEntity> listAdded, 
        IList<hr_emergencycontactEntity> listUpdated,
        IList<hr_emergencycontactEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_postoffice_Ins";
            const string MasterSPUpdate = "gen_postoffice_Upd";
            const string MasterSPDelete = "gen_postoffice_Del";
            
			
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
                                item.curbdadrresspo=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.SaveDsgen_postoffice"));
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
        gen_postofficeEntity Igen_postofficeDataAccessObjects.GetSingle(gen_postofficeEntity gen_postoffice)
        {
           try
            {
				const string SP = "gen_postoffice_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_postoffice, cmd, Database);
                    
                    IList<gen_postofficeEntity> itemList = new List<gen_postofficeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_postofficeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.GetSinglegen_postoffice"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_postofficeEntity> Igen_postofficeDataAccessObjects.GAPgListView(gen_postofficeEntity gen_postoffice)
        {
        try
            {
				const string SP = "gen_postoffice_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_postoffice.SortExpression);
                    AddPageSizeParameter(cmd, gen_postoffice.PageSize);
                    AddCurrentPageParameter(cmd, gen_postoffice.CurrentPage);                    
                    FillSequrityParameters(gen_postoffice.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_postoffice, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_postoffice.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_postoffice.strCommonSerachParam);

                    IList<gen_postofficeEntity> itemList = new List<gen_postofficeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_postofficeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_postoffice.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_postofficeDataAccess.GAPgListViewgen_postoffice"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}