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
	
	internal sealed partial class gen_promotiontypeDataAccessObjects : BaseDataAccess, Igen_promotiontypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_promotiontypeDataAccessObjects";
        
		public gen_promotiontypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_promotiontypeEntity gen_promotiontype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_promotiontype.promotiontypeid.HasValue)
				Database.AddInParameter(cmd, "@PromotionTypeID", DbType.Int64, gen_promotiontype.promotiontypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_promotiontype.promotiontype)))
				Database.AddInParameter(cmd, "@PromotionType", DbType.String, gen_promotiontype.promotiontype);
			if (!(string.IsNullOrEmpty(gen_promotiontype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_promotiontype.remarks);
			if ((gen_promotiontype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_promotiontype.ex_date1);
			if ((gen_promotiontype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_promotiontype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_promotiontype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_promotiontype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_promotiontype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_promotiontype.ex_nvarchar2);
			if (gen_promotiontype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_promotiontype.ex_bigint1);
			if (gen_promotiontype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_promotiontype.ex_bigint2);
			if (gen_promotiontype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_promotiontype.ex_decimal1);
			if (gen_promotiontype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_promotiontype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_promotiontypeDataAccessObjects.Add(gen_promotiontypeEntity gen_promotiontype  )
        {
            long returnCode = -99;
            const string SP = "gen_promotiontype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_promotiontype, cmd,Database);
                FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.Addgen_promotiontype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_promotiontypeDataAccessObjects.Update(gen_promotiontypeEntity gen_promotiontype )
        {
           long returnCode = -99;
            const string SP = "gen_promotiontype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_promotiontype, cmd,Database);
                FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.Updategen_promotiontype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_promotiontypeDataAccessObjects.Delete(gen_promotiontypeEntity gen_promotiontype)
        {
            long returnCode = -99;
           	const string SP = "gen_promotiontype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_promotiontype, cmd,Database, true);
                FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.Deletegen_promotiontype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_promotiontypeDataAccessObjects.SaveList(IList<gen_promotiontypeEntity> listAdded, IList<gen_promotiontypeEntity> listUpdated, IList<gen_promotiontypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_promotiontype_Ins";
            const string SPUpdate = "gen_promotiontype_Upd";
            const string SPDelete = "gen_promotiontype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_promotiontypeEntity gen_promotiontype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_promotiontype, cmd, Database, true);
                            FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_promotiontypeEntity gen_promotiontype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_promotiontype, cmd, Database);
                            FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_promotiontypeEntity gen_promotiontype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_promotiontype, cmd, Database);
                            FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.Save_gen_promotiontype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_promotiontypeEntity> listAdded, IList<gen_promotiontypeEntity> listUpdated, IList<gen_promotiontypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_promotiontype_Ins";
            const string SPUpdate = "gen_promotiontype_Upd";
            const string SPDelete = "gen_promotiontype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_promotiontypeEntity gen_promotiontype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_promotiontype, cmd, db, true);
                            FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_promotiontypeEntity gen_promotiontype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_promotiontype, cmd, db);
                            FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_promotiontypeEntity gen_promotiontype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_promotiontype, cmd, db);
                            FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.Save_gen_promotiontype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_promotiontypeEntity> Igen_promotiontypeDataAccessObjects.GetAll(gen_promotiontypeEntity gen_promotiontype)
        {
           try
            {
				const string SP = "gen_promotiontype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_promotiontype.SortExpression);
                    FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_promotiontype, cmd, Database);
                    
                    IList<gen_promotiontypeEntity> itemList = new List<gen_promotiontypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_promotiontypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.GetAllgen_promotiontype"));
            }	
        }
		
		IList<gen_promotiontypeEntity> Igen_promotiontypeDataAccessObjects.GetAllByPages(gen_promotiontypeEntity gen_promotiontype)
        {
        try
            {
				const string SP = "gen_promotiontype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_promotiontype.SortExpression);
                    AddPageSizeParameter(cmd, gen_promotiontype.PageSize);
                    AddCurrentPageParameter(cmd, gen_promotiontype.CurrentPage);                    
                    FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_promotiontype, cmd,Database);

                    IList<gen_promotiontypeEntity> itemList = new List<gen_promotiontypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_promotiontypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_promotiontype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.GetAllByPagesgen_promotiontype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_promotiontypeDataAccessObjects.SaveMasterDethr_promotioninfo(gen_promotiontypeEntity masterEntity, 
        IList<hr_promotioninfoEntity> listAdded, 
        IList<hr_promotioninfoEntity> listUpdated,
        IList<hr_promotioninfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_promotiontype_Ins";
            const string MasterSPUpdate = "gen_promotiontype_Upd";
            const string MasterSPDelete = "gen_promotiontype_Del";
            
			
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
                                item.promotiontypeid=PrimaryKeyMaster;
                            }
                        }
                        hr_promotioninfoDataAccessObjects objhr_promotioninfo=new hr_promotioninfoDataAccessObjects(this.Context);
                        objhr_promotioninfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.SaveDsgen_promotiontype"));
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
        gen_promotiontypeEntity Igen_promotiontypeDataAccessObjects.GetSingle(gen_promotiontypeEntity gen_promotiontype)
        {
           try
            {
				const string SP = "gen_promotiontype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_promotiontype, cmd, Database);
                    
                    IList<gen_promotiontypeEntity> itemList = new List<gen_promotiontypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_promotiontypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.GetSinglegen_promotiontype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_promotiontypeEntity> Igen_promotiontypeDataAccessObjects.GAPgListView(gen_promotiontypeEntity gen_promotiontype)
        {
        try
            {
				const string SP = "gen_promotiontype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_promotiontype.SortExpression);
                    AddPageSizeParameter(cmd, gen_promotiontype.PageSize);
                    AddCurrentPageParameter(cmd, gen_promotiontype.CurrentPage);                    
                    FillSequrityParameters(gen_promotiontype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_promotiontype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_promotiontype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_promotiontype.strCommonSerachParam);

                    IList<gen_promotiontypeEntity> itemList = new List<gen_promotiontypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_promotiontypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_promotiontype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_promotiontypeDataAccess.GAPgListViewgen_promotiontype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}