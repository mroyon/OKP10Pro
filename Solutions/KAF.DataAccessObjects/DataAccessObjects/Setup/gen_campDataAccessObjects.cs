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
	
	internal sealed partial class gen_campDataAccessObjects : BaseDataAccess, Igen_campDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_campDataAccessObjects";
        
		public gen_campDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_campEntity gen_camp, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_camp.campid.HasValue)
				Database.AddInParameter(cmd, "@CampID", DbType.Int64, gen_camp.campid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_camp.campname)))
				Database.AddInParameter(cmd, "@CampName", DbType.String, gen_camp.campname);
			if (gen_camp.okpid.HasValue)
				Database.AddInParameter(cmd, "@OKpID", DbType.Int64, gen_camp.okpid);
			if (!(string.IsNullOrEmpty(gen_camp.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_camp.remarks);
			if ((gen_camp.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_camp.ex_date1);
			if ((gen_camp.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_camp.ex_date2);
			if (!(string.IsNullOrEmpty(gen_camp.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_camp.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_camp.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_camp.ex_nvarchar2);
			if (gen_camp.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_camp.ex_bigint1);
			if (gen_camp.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_camp.ex_bigint2);
			if (gen_camp.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_camp.ex_decimal1);
			if (gen_camp.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_camp.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_campDataAccessObjects.Add(gen_campEntity gen_camp  )
        {
            long returnCode = -99;
            const string SP = "gen_camp_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_camp, cmd,Database);
                FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.Addgen_camp"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_campDataAccessObjects.Update(gen_campEntity gen_camp )
        {
           long returnCode = -99;
            const string SP = "gen_camp_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_camp, cmd,Database);
                FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.Updategen_camp"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_campDataAccessObjects.Delete(gen_campEntity gen_camp)
        {
            long returnCode = -99;
           	const string SP = "gen_camp_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_camp, cmd,Database, true);
                FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.Deletegen_camp"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_campDataAccessObjects.SaveList(IList<gen_campEntity> listAdded, IList<gen_campEntity> listUpdated, IList<gen_campEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_camp_Ins";
            const string SPUpdate = "gen_camp_Upd";
            const string SPDelete = "gen_camp_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_campEntity gen_camp in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_camp, cmd, Database, true);
                            FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_campEntity gen_camp in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_camp, cmd, Database);
                            FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_campEntity gen_camp in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_camp, cmd, Database);
                            FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.Save_gen_camp"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_campEntity> listAdded, IList<gen_campEntity> listUpdated, IList<gen_campEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_camp_Ins";
            const string SPUpdate = "gen_camp_Upd";
            const string SPDelete = "gen_camp_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_campEntity gen_camp in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_camp, cmd, db, true);
                            FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, db);
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
                    foreach (gen_campEntity gen_camp in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_camp, cmd, db);
                            FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, db);
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
                    foreach (gen_campEntity gen_camp in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_camp, cmd, db);
                            FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.Save_gen_camp"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_campEntity> Igen_campDataAccessObjects.GetAll(gen_campEntity gen_camp)
        {
           try
            {
				const string SP = "gen_camp_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_camp.SortExpression);
                    FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_camp, cmd, Database);
                    
                    IList<gen_campEntity> itemList = new List<gen_campEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_campEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.GetAllgen_camp"));
            }	
        }
		
		IList<gen_campEntity> Igen_campDataAccessObjects.GetAllByPages(gen_campEntity gen_camp)
        {
        try
            {
				const string SP = "gen_camp_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_camp.SortExpression);
                    AddPageSizeParameter(cmd, gen_camp.PageSize);
                    AddCurrentPageParameter(cmd, gen_camp.CurrentPage);                    
                    FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_camp, cmd,Database);

                    IList<gen_campEntity> itemList = new List<gen_campEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_campEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_camp.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.GetAllByPagesgen_camp"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
  //      long Igen_campDataAccessObjects.SaveMasterDethr_attachmentinfo(gen_campEntity masterEntity, 
  //      IList<hr_attachmentinfoEntity> listAdded, 
  //      IList<hr_attachmentinfoEntity> listUpdated,
  //      IList<hr_attachmentinfoEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_camp_Ins";
  //          const string MasterSPUpdate = "gen_camp_Upd";
  //          const string MasterSPDelete = "gen_camp_Del";
            
			
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
  //                              item.campid=PrimaryKeyMaster;
  //                          }
  //                      }
  //                      hr_attachmentinfoDataAccessObjects objhr_attachmentinfo=new hr_attachmentinfoDataAccessObjects(this.Context);
  //                      objhr_attachmentinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.SaveDsgen_camp"));
  //          }
  //          finally
  //          {
  //              transaction.Dispose();
  //              connection.Close();
  //              connection = null;
  //          }
  //          return returnCode;
		//}
        
          
  //      long Igen_campDataAccessObjects.SaveMasterDethr_okptransferinfo(gen_campEntity masterEntity, 
  //      IList<hr_okptransferinfoEntity> listAdded, 
  //      IList<hr_okptransferinfoEntity> listUpdated,
  //      IList<hr_okptransferinfoEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_camp_Ins";
  //          const string MasterSPUpdate = "gen_camp_Upd";
  //          const string MasterSPDelete = "gen_camp_Del";
            
			
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
  //                              item.campid=PrimaryKeyMaster;
  //                          }
  //                      }
  //                      hr_okptransferinfoDataAccessObjects objhr_okptransferinfo=new hr_okptransferinfoDataAccessObjects(this.Context);
  //                      objhr_okptransferinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.SaveDsgen_camp"));
  //          }
  //          finally
  //          {
  //              transaction.Dispose();
  //              connection.Close();
  //              connection = null;
  //          }
  //          return returnCode;
		//}
        
        #endregion
        
        
        #region Simple load Single Row
        gen_campEntity Igen_campDataAccessObjects.GetSingle(gen_campEntity gen_camp)
        {
           try
            {
				const string SP = "gen_camp_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_camp, cmd, Database);
                    
                    IList<gen_campEntity> itemList = new List<gen_campEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_campEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.GetSinglegen_camp"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_campEntity> Igen_campDataAccessObjects.GAPgListView(gen_campEntity gen_camp)
        {
        try
            {
				const string SP = "gen_camp_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_camp.SortExpression);
                    AddPageSizeParameter(cmd, gen_camp.PageSize);
                    AddCurrentPageParameter(cmd, gen_camp.CurrentPage);                    
                    FillSequrityParameters(gen_camp.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_camp, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_camp.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_camp.strCommonSerachParam);

                    IList<gen_campEntity> itemList = new List<gen_campEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_campEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_camp.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_campDataAccess.GAPgListViewgen_camp"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}