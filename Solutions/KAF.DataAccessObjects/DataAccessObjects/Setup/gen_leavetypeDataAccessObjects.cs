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
	
	internal sealed partial class gen_leavetypeDataAccessObjects : BaseDataAccess, Igen_leavetypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_leavetypeDataAccessObjects";
        
		public gen_leavetypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_leavetypeEntity gen_leavetype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_leavetype.leavetypeid.HasValue)
				Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, gen_leavetype.leavetypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_leavetype.leavetype)))
				Database.AddInParameter(cmd, "@LeaveType", DbType.String, gen_leavetype.leavetype);
			if (!(string.IsNullOrEmpty(gen_leavetype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_leavetype.remarks);
            if (gen_leavetype.isactive.HasValue)
                Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_leavetype.isactive);
            if ((gen_leavetype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_leavetype.ex_date1);
			if ((gen_leavetype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_leavetype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_leavetype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_leavetype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_leavetype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_leavetype.ex_nvarchar2);
			if (gen_leavetype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_leavetype.ex_bigint1);
			if (gen_leavetype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_leavetype.ex_bigint2);
			if (gen_leavetype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_leavetype.ex_decimal1);
			if (gen_leavetype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_leavetype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_leavetypeDataAccessObjects.Add(gen_leavetypeEntity gen_leavetype  )
        {
            long returnCode = -99;
            const string SP = "gen_leavetype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_leavetype, cmd,Database);
                FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.Addgen_leavetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_leavetypeDataAccessObjects.Update(gen_leavetypeEntity gen_leavetype )
        {
           long returnCode = -99;
            const string SP = "gen_leavetype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_leavetype, cmd,Database);
                FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.Updategen_leavetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_leavetypeDataAccessObjects.Delete(gen_leavetypeEntity gen_leavetype)
        {
            long returnCode = -99;
           	const string SP = "gen_leavetype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_leavetype, cmd,Database, true);
                FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.Deletegen_leavetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_leavetypeDataAccessObjects.SaveList(IList<gen_leavetypeEntity> listAdded, IList<gen_leavetypeEntity> listUpdated, IList<gen_leavetypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_leavetype_Ins";
            const string SPUpdate = "gen_leavetype_Upd";
            const string SPDelete = "gen_leavetype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_leavetypeEntity gen_leavetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_leavetype, cmd, Database, true);
                            FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_leavetypeEntity gen_leavetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_leavetype, cmd, Database);
                            FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_leavetypeEntity gen_leavetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_leavetype, cmd, Database);
                            FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.Save_gen_leavetype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_leavetypeEntity> listAdded, IList<gen_leavetypeEntity> listUpdated, IList<gen_leavetypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_leavetype_Ins";
            const string SPUpdate = "gen_leavetype_Upd";
            const string SPDelete = "gen_leavetype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_leavetypeEntity gen_leavetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_leavetype, cmd, db, true);
                            FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_leavetypeEntity gen_leavetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_leavetype, cmd, db);
                            FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_leavetypeEntity gen_leavetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_leavetype, cmd, db);
                            FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.Save_gen_leavetype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_leavetypeEntity> Igen_leavetypeDataAccessObjects.GetAll(gen_leavetypeEntity gen_leavetype)
        {
           try
            {
				const string SP = "gen_leavetype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_leavetype.SortExpression);
                    FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_leavetype, cmd, Database);
                    
                    IList<gen_leavetypeEntity> itemList = new List<gen_leavetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leavetypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.GetAllgen_leavetype"));
            }	
        }
		
		IList<gen_leavetypeEntity> Igen_leavetypeDataAccessObjects.GetAllByPages(gen_leavetypeEntity gen_leavetype)
        {
        try
            {
				const string SP = "gen_leavetype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_leavetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_leavetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_leavetype.CurrentPage);                    
                    FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_leavetype, cmd,Database);

                    IList<gen_leavetypeEntity> itemList = new List<gen_leavetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leavetypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_leavetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.GetAllByPagesgen_leavetype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
  //      long Igen_leavetypeDataAccessObjects.SaveMasterDetgen_leaveconfig(gen_leavetypeEntity masterEntity, 
  //      IList<gen_leaveconfigEntity> listAdded, 
  //      IList<gen_leaveconfigEntity> listUpdated,
  //      IList<gen_leaveconfigEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_leavetype_Ins";
  //          const string MasterSPUpdate = "gen_leavetype_Upd";
  //          const string MasterSPDelete = "gen_leavetype_Del";
            
			
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
  //                              item.leavetypeid=PrimaryKeyMaster;
  //                          }
  //                      }
  //                      gen_leaveconfigDataAccessObjects objgen_leaveconfig=new gen_leaveconfigDataAccessObjects(this.Context);
  //                      objgen_leaveconfig.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.SaveDsgen_leavetype"));
  //          }
  //          finally
  //          {
  //              transaction.Dispose();
  //              connection.Close();
  //              connection = null;
  //          }
  //          return returnCode;
		//}
        
          
  //      long Igen_leavetypeDataAccessObjects.SaveMasterDethr_leaveinfo(gen_leavetypeEntity masterEntity, 
  //      IList<hr_leaveinfoEntity> listAdded, 
  //      IList<hr_leaveinfoEntity> listUpdated,
  //      IList<hr_leaveinfoEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_leavetype_Ins";
  //          const string MasterSPUpdate = "gen_leavetype_Upd";
  //          const string MasterSPDelete = "gen_leavetype_Del";
            
			
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
  //                              item.leavetypeid=PrimaryKeyMaster;
  //                          }
  //                      }
  //                      hr_leaveinfoDataAccessObjects objhr_leaveinfo=new hr_leaveinfoDataAccessObjects(this.Context);
  //                      objhr_leaveinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.SaveDsgen_leavetype"));
  //          }
  //          finally
  //          {
  //              transaction.Dispose();
  //              connection.Close();
  //              connection = null;
  //          }
  //          return returnCode;
		//}
        
          
  //      long Igen_leavetypeDataAccessObjects.SaveMasterDethr_leavemodification(gen_leavetypeEntity masterEntity, 
  //      IList<hr_leavemodificationEntity> listAdded, 
  //      IList<hr_leavemodificationEntity> listUpdated,
  //      IList<hr_leavemodificationEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_leavetype_Ins";
  //          const string MasterSPUpdate = "gen_leavetype_Upd";
  //          const string MasterSPDelete = "gen_leavetype_Del";
            
			
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
  //                              item.leavetypeid=PrimaryKeyMaster;
  //                          }
  //                      }
  //                      hr_leavemodificationDataAccessObjects objhr_leavemodification=new hr_leavemodificationDataAccessObjects(this.Context);
  //                      objhr_leavemodification.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.SaveDsgen_leavetype"));
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
        gen_leavetypeEntity Igen_leavetypeDataAccessObjects.GetSingle(gen_leavetypeEntity gen_leavetype)
        {
           try
            {
				const string SP = "gen_leavetype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_leavetype, cmd, Database);
                    
                    IList<gen_leavetypeEntity> itemList = new List<gen_leavetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leavetypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.GetSinglegen_leavetype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_leavetypeEntity> Igen_leavetypeDataAccessObjects.GAPgListView(gen_leavetypeEntity gen_leavetype)
        {
        try
            {
				const string SP = "gen_leavetype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_leavetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_leavetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_leavetype.CurrentPage);                    
                    FillSequrityParameters(gen_leavetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_leavetype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_leavetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_leavetype.strCommonSerachParam);

                    IList<gen_leavetypeEntity> itemList = new List<gen_leavetypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leavetypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_leavetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_leavetypeDataAccess.GAPgListViewgen_leavetype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}