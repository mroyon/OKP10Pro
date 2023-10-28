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
	
	internal sealed partial class owin_formactionDataAccessObjects : BaseDataAccess, Iowin_formactionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_formactionDataAccessObjects";
        
		public owin_formactionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_formactionEntity owin_formaction, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_formaction.formactionid.HasValue)
				Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, owin_formaction.formactionid);
            if (forDelete) return;
			if (owin_formaction.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, owin_formaction.appformid);
			if (!(string.IsNullOrEmpty(owin_formaction.actionname)))
				Database.AddInParameter(cmd, "@ActionName", DbType.String, owin_formaction.actionname);
			if ((owin_formaction.isview != null))
				Database.AddInParameter(cmd, "@IsView", DbType.Boolean, owin_formaction.isview);
			if (!(string.IsNullOrEmpty(owin_formaction.eventname)))
				Database.AddInParameter(cmd, "@EventName", DbType.String, owin_formaction.eventname);
			if (owin_formaction.sequence.HasValue)
				Database.AddInParameter(cmd, "@Sequence", DbType.Int32, owin_formaction.sequence);
			if ((owin_formaction.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_formaction.ex_date1);
			if ((owin_formaction.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_formaction.ex_date2);
			if (!(string.IsNullOrEmpty(owin_formaction.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_formaction.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(owin_formaction.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_formaction.ex_nvarchar2);
			if (owin_formaction.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_formaction.ex_bigint1);
			if (owin_formaction.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_formaction.ex_bigint2);
			if (owin_formaction.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_formaction.ex_decimal1);
			if (owin_formaction.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_formaction.ex_decimal2);

        }
		
        
		#region Add Operation

        long Iowin_formactionDataAccessObjects.Add(owin_formactionEntity owin_formaction  )
        {
            long returnCode = -99;
            const string SP = "owin_formaction_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_formaction, cmd,Database);
                FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Addowin_formaction"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Iowin_formactionDataAccessObjects.Update(owin_formactionEntity owin_formaction )
        {
           long returnCode = -99;
            const string SP = "owin_formaction_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_formaction, cmd,Database);
                FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Updateowin_formaction"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Iowin_formactionDataAccessObjects.Delete(owin_formactionEntity owin_formaction)
        {
            long returnCode = -99;
           	const string SP = "owin_formaction_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_formaction, cmd,Database, true);
                FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Deleteowin_formaction"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Iowin_formactionDataAccessObjects.SaveList(IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_formaction_Ins";
            const string SPUpdate = "owin_formaction_Upd";
            const string SPDelete = "owin_formaction_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_formactionEntity owin_formaction in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_formaction, cmd, Database, true);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_formactionEntity owin_formaction in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_formaction, cmd, Database);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_formactionEntity owin_formaction in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_formaction, cmd, Database);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Save_owin_formaction"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "owin_formaction_Ins";
            const string SPUpdate = "owin_formaction_Upd";
            const string SPDelete = "owin_formaction_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_formactionEntity owin_formaction in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_formaction, cmd, db, true);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, db);
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
                    foreach (owin_formactionEntity owin_formaction in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_formaction, cmd, db);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, db);
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
                    foreach (owin_formactionEntity owin_formaction in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_formaction, cmd, db);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Save_owin_formaction"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<owin_formactionEntity> Iowin_formactionDataAccessObjects.GetAll(owin_formactionEntity owin_formaction)
        {
           try
            {
				const string SP = "owin_formaction_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_formaction, cmd, Database);
                    
                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetAllowin_formaction"));
            }	
        }
		
		IList<owin_formactionEntity> Iowin_formactionDataAccessObjects.GetAllByPages(owin_formactionEntity owin_formaction)
        {
        try
            {
				const string SP = "owin_formaction_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    AddPageSizeParameter(cmd, owin_formaction.PageSize);
                    AddCurrentPageParameter(cmd, owin_formaction.CurrentPage);                    
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_formaction, cmd,Database);

                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_formaction.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetAllByPagesowin_formaction"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Iowin_formactionDataAccessObjects.SaveMasterDetowin_rolepermission(owin_formactionEntity masterEntity, 
        IList<owin_rolepermissionEntity> listAdded, 
        IList<owin_rolepermissionEntity> listUpdated,
        IList<owin_rolepermissionEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_formaction_Ins";
            const string MasterSPUpdate = "owin_formaction_Upd";
            const string MasterSPDelete = "owin_formaction_Del";
            
			
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
                                item.formactionid=PrimaryKeyMaster;
                            }
                        }
                        owin_rolepermissionDataAccessObjects objowin_rolepermission=new owin_rolepermissionDataAccessObjects(this.Context);
                        objowin_rolepermission.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.SaveDsowin_formaction"));
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
        owin_formactionEntity Iowin_formactionDataAccessObjects.GetSingle(owin_formactionEntity owin_formaction)
        {
           try
            {
				const string SP = "owin_formaction_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_formaction, cmd, Database);
                    
                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetSingleowin_formaction"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<owin_formactionEntity> Iowin_formactionDataAccessObjects.GAPgListView(owin_formactionEntity owin_formaction)
        {
        try
            {
				const string SP = "owin_formaction_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    AddPageSizeParameter(cmd, owin_formaction.PageSize);
                    AddCurrentPageParameter(cmd, owin_formaction.CurrentPage);                    
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_formaction, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_formaction.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, owin_formaction.strCommonSerachParam);

                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_formaction.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GAPgListViewowin_formaction"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}