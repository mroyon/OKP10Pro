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
	
	internal sealed partial class gen_ranktypeDataAccessObjects : BaseDataAccess, Igen_ranktypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_ranktypeDataAccessObjects";
        
		public gen_ranktypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_ranktypeEntity gen_ranktype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_ranktype.ranktypeid.HasValue)
				Database.AddInParameter(cmd, "@RankTypeID", DbType.Int64, gen_ranktype.ranktypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_ranktype.ranktype)))
				Database.AddInParameter(cmd, "@RankType", DbType.String, gen_ranktype.ranktype);
			if (gen_ranktype.priority.HasValue)
				Database.AddInParameter(cmd, "@Priority", DbType.Int64, gen_ranktype.priority);
			if (!(string.IsNullOrEmpty(gen_ranktype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_ranktype.remarks);
			if ((gen_ranktype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_ranktype.ex_date1);
			if ((gen_ranktype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_ranktype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_ranktype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_ranktype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_ranktype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_ranktype.ex_nvarchar2);
			if (gen_ranktype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_ranktype.ex_bigint1);
			if (gen_ranktype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_ranktype.ex_bigint2);
			if (gen_ranktype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_ranktype.ex_decimal1);
			if (gen_ranktype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_ranktype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_ranktypeDataAccessObjects.Add(gen_ranktypeEntity gen_ranktype  )
        {
            long returnCode = -99;
            const string SP = "gen_ranktype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_ranktype, cmd,Database);
                FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.Addgen_ranktype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_ranktypeDataAccessObjects.Update(gen_ranktypeEntity gen_ranktype )
        {
           long returnCode = -99;
            const string SP = "gen_ranktype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_ranktype, cmd,Database);
                FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.Updategen_ranktype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_ranktypeDataAccessObjects.Delete(gen_ranktypeEntity gen_ranktype)
        {
            long returnCode = -99;
           	const string SP = "gen_ranktype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_ranktype, cmd,Database, true);
                FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.Deletegen_ranktype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_ranktypeDataAccessObjects.SaveList(IList<gen_ranktypeEntity> listAdded, IList<gen_ranktypeEntity> listUpdated, IList<gen_ranktypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_ranktype_Ins";
            const string SPUpdate = "gen_ranktype_Upd";
            const string SPDelete = "gen_ranktype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_ranktypeEntity gen_ranktype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_ranktype, cmd, Database, true);
                            FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_ranktypeEntity gen_ranktype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_ranktype, cmd, Database);
                            FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_ranktypeEntity gen_ranktype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_ranktype, cmd, Database);
                            FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.Save_gen_ranktype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_ranktypeEntity> listAdded, IList<gen_ranktypeEntity> listUpdated, IList<gen_ranktypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_ranktype_Ins";
            const string SPUpdate = "gen_ranktype_Upd";
            const string SPDelete = "gen_ranktype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_ranktypeEntity gen_ranktype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_ranktype, cmd, db, true);
                            FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_ranktypeEntity gen_ranktype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_ranktype, cmd, db);
                            FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_ranktypeEntity gen_ranktype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_ranktype, cmd, db);
                            FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.Save_gen_ranktype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_ranktypeEntity> Igen_ranktypeDataAccessObjects.GetAll(gen_ranktypeEntity gen_ranktype)
        {
           try
            {
				const string SP = "gen_ranktype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_ranktype.SortExpression);
                    FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_ranktype, cmd, Database);
                    
                    IList<gen_ranktypeEntity> itemList = new List<gen_ranktypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_ranktypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.GetAllgen_ranktype"));
            }	
        }
		
		IList<gen_ranktypeEntity> Igen_ranktypeDataAccessObjects.GetAllByPages(gen_ranktypeEntity gen_ranktype)
        {
        try
            {
				const string SP = "gen_ranktype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_ranktype.SortExpression);
                    AddPageSizeParameter(cmd, gen_ranktype.PageSize);
                    AddCurrentPageParameter(cmd, gen_ranktype.CurrentPage);                    
                    FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_ranktype, cmd,Database);

                    IList<gen_ranktypeEntity> itemList = new List<gen_ranktypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_ranktypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_ranktype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.GetAllByPagesgen_ranktype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Igen_ranktypeDataAccessObjects.SaveMasterDetgen_rank(gen_ranktypeEntity masterEntity, 
        IList<gen_rankEntity> listAdded, 
        IList<gen_rankEntity> listUpdated,
        IList<gen_rankEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_ranktype_Ins";
            const string MasterSPUpdate = "gen_ranktype_Upd";
            const string MasterSPDelete = "gen_ranktype_Del";
            
			
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
                                item.ranktypeid=PrimaryKeyMaster;
                            }
                        }
                        gen_rankDataAccessObjects objgen_rank=new gen_rankDataAccessObjects(this.Context);
                        objgen_rank.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.SaveDsgen_ranktype"));
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
        gen_ranktypeEntity Igen_ranktypeDataAccessObjects.GetSingle(gen_ranktypeEntity gen_ranktype)
        {
           try
            {
				const string SP = "gen_ranktype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_ranktype, cmd, Database);
                    
                    IList<gen_ranktypeEntity> itemList = new List<gen_ranktypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_ranktypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.GetSinglegen_ranktype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_ranktypeEntity> Igen_ranktypeDataAccessObjects.GAPgListView(gen_ranktypeEntity gen_ranktype)
        {
        try
            {
				const string SP = "gen_ranktype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_ranktype.SortExpression);
                    AddPageSizeParameter(cmd, gen_ranktype.PageSize);
                    AddCurrentPageParameter(cmd, gen_ranktype.CurrentPage);                    
                    FillSequrityParameters(gen_ranktype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_ranktype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_ranktype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_ranktype.strCommonSerachParam);

                    IList<gen_ranktypeEntity> itemList = new List<gen_ranktypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_ranktypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_ranktype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_ranktypeDataAccess.GAPgListViewgen_ranktype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}