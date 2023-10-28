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
	
	internal sealed partial class gen_subunitDataAccessObjects : BaseDataAccess, Igen_subunitDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_subunitDataAccessObjects";
        
		public gen_subunitDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_subunitEntity gen_subunit, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_subunit.subunitid.HasValue)
				Database.AddInParameter(cmd, "@SubUnitID", DbType.Int64, gen_subunit.subunitid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_subunit.subunit)))
				Database.AddInParameter(cmd, "@SubUnit", DbType.String, gen_subunit.subunit);
			if (gen_subunit.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, gen_subunit.okpid);
            if (gen_subunit.outsidekuwait.HasValue)
                Database.AddInParameter(cmd, "@OutSideKuwait", DbType.Boolean, gen_subunit.outsidekuwait);
            if (!(string.IsNullOrEmpty(gen_subunit.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_subunit.remarks);
			if ((gen_subunit.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_subunit.ex_date1);
			if ((gen_subunit.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_subunit.ex_date2);
			if (!(string.IsNullOrEmpty(gen_subunit.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_subunit.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_subunit.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_subunit.ex_nvarchar2);
			if (gen_subunit.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_subunit.ex_bigint1);
			if (gen_subunit.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_subunit.ex_bigint2);
			if (gen_subunit.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_subunit.ex_decimal1);
			if (gen_subunit.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_subunit.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_subunitDataAccessObjects.Add(gen_subunitEntity gen_subunit  )
        {
            long returnCode = -99;
            const string SP = "gen_subunit_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_subunit, cmd,Database);
                FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.Addgen_subunit"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_subunitDataAccessObjects.Update(gen_subunitEntity gen_subunit )
        {
           long returnCode = -99;
            const string SP = "gen_subunit_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_subunit, cmd,Database);
                FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.Updategen_subunit"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_subunitDataAccessObjects.Delete(gen_subunitEntity gen_subunit)
        {
            long returnCode = -99;
           	const string SP = "gen_subunit_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_subunit, cmd,Database, true);
                FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.Deletegen_subunit"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_subunitDataAccessObjects.SaveList(IList<gen_subunitEntity> listAdded, IList<gen_subunitEntity> listUpdated, IList<gen_subunitEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_subunit_Ins";
            const string SPUpdate = "gen_subunit_Upd";
            const string SPDelete = "gen_subunit_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_subunitEntity gen_subunit in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_subunit, cmd, Database, true);
                            FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_subunitEntity gen_subunit in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_subunit, cmd, Database);
                            FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_subunitEntity gen_subunit in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_subunit, cmd, Database);
                            FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.Save_gen_subunit"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_subunitEntity> listAdded, IList<gen_subunitEntity> listUpdated, IList<gen_subunitEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_subunit_Ins";
            const string SPUpdate = "gen_subunit_Upd";
            const string SPDelete = "gen_subunit_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_subunitEntity gen_subunit in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_subunit, cmd, db, true);
                            FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, db);
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
                    foreach (gen_subunitEntity gen_subunit in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_subunit, cmd, db);
                            FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, db);
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
                    foreach (gen_subunitEntity gen_subunit in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_subunit, cmd, db);
                            FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.Save_gen_subunit"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_subunitEntity> Igen_subunitDataAccessObjects.GetAll(gen_subunitEntity gen_subunit)
        {
           try
            {
				const string SP = "gen_subunit_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_subunit.SortExpression);
                    FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_subunit, cmd, Database);
                    
                    IList<gen_subunitEntity> itemList = new List<gen_subunitEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_subunitEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.GetAllgen_subunit"));
            }	
        }
		
		IList<gen_subunitEntity> Igen_subunitDataAccessObjects.GetAllByPages(gen_subunitEntity gen_subunit)
        {
        try
            {
				const string SP = "gen_subunit_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_subunit.SortExpression);
                    AddPageSizeParameter(cmd, gen_subunit.PageSize);
                    AddCurrentPageParameter(cmd, gen_subunit.CurrentPage);                    
                    FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_subunit, cmd,Database);

                    IList<gen_subunitEntity> itemList = new List<gen_subunitEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_subunitEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_subunit.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.GetAllByPagesgen_subunit"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
  //      long Igen_subunitDataAccessObjects.SaveMasterDethr_attachmentinfo(gen_subunitEntity masterEntity, 
  //      IList<hr_attachmentinfoEntity> listAdded, 
  //      IList<hr_attachmentinfoEntity> listUpdated,
  //      IList<hr_attachmentinfoEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_subunit_Ins";
  //          const string MasterSPUpdate = "gen_subunit_Upd";
  //          const string MasterSPDelete = "gen_subunit_Del";
            
			
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
  //                              item.subunitid=PrimaryKeyMaster;
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.SaveDsgen_subunit"));
  //          }
  //          finally
  //          {
  //              transaction.Dispose();
  //              connection.Close();
  //              connection = null;
  //          }
  //          return returnCode;
		//}
        
          
  //      long Igen_subunitDataAccessObjects.SaveMasterDethr_okptransferinfo(gen_subunitEntity masterEntity, 
  //      IList<hr_okptransferinfoEntity> listAdded, 
  //      IList<hr_okptransferinfoEntity> listUpdated,
  //      IList<hr_okptransferinfoEntity> listDeleted)
  //      {
		//	long returnCode = -99;
  //          Int64 PrimaryKeyMaster = -99;
            
  //          string SP = "";
  //          const string MasterSPInsert = "gen_subunit_Ins";
  //          const string MasterSPUpdate = "gen_subunit_Upd";
  //          const string MasterSPDelete = "gen_subunit_Del";
            
			
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
  //                              item.subunitid=PrimaryKeyMaster;
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
  //              throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.SaveDsgen_subunit"));
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
        gen_subunitEntity Igen_subunitDataAccessObjects.GetSingle(gen_subunitEntity gen_subunit)
        {
           try
            {
				const string SP = "gen_subunit_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_subunit, cmd, Database);
                    
                    IList<gen_subunitEntity> itemList = new List<gen_subunitEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_subunitEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.GetSinglegen_subunit"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_subunitEntity> Igen_subunitDataAccessObjects.GAPgListView(gen_subunitEntity gen_subunit)
        {
        try
            {
				const string SP = "gen_subunit_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_subunit.SortExpression);
                    AddPageSizeParameter(cmd, gen_subunit.PageSize);
                    AddCurrentPageParameter(cmd, gen_subunit.CurrentPage);                    
                    FillSequrityParameters(gen_subunit.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_subunit, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_subunit.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_subunit.strCommonSerachParam);

                    IList<gen_subunitEntity> itemList = new List<gen_subunitEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_subunitEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_subunit.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_subunitDataAccess.GAPgListViewgen_subunit"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}