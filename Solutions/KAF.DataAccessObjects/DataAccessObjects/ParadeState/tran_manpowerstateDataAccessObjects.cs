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
	
	internal sealed partial class tran_manpowerstateDataAccessObjects : BaseDataAccess, Itran_manpowerstateDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_manpowerstateDataAccessObjects";
        
		public tran_manpowerstateDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_manpowerstateEntity tran_manpowerstate, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_manpowerstate.manpowerstateid.HasValue)
				Database.AddInParameter(cmd, "@ManpowerStateID", DbType.Int64, tran_manpowerstate.manpowerstateid);
            if (forDelete) return;
			if (tran_manpowerstate.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, tran_manpowerstate.okpid);
			if ((tran_manpowerstate.manpowerstatedate.HasValue))
				Database.AddInParameter(cmd, "@ManpowerStateDate", DbType.DateTime, tran_manpowerstate.manpowerstatedate);
			//if ((tran_manpowerstate.isprepared != null))
				Database.AddInParameter(cmd, "@IsPrepared", DbType.Boolean, tran_manpowerstate.isprepared);
			//if ((tran_manpowerstate.prepareddate.HasValue))
				Database.AddInParameter(cmd, "@PreparedDate", DbType.DateTime, tran_manpowerstate.prepareddate);
			//if (tran_manpowerstate.preparedby.HasValue)
				Database.AddInParameter(cmd, "@PreparedBy", DbType.Int64, tran_manpowerstate.preparedby);
			//if ((tran_manpowerstate.isreviewed != null))
				Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, tran_manpowerstate.isreviewed);
			//if ((tran_manpowerstate.reviewdate.HasValue))
				Database.AddInParameter(cmd, "@ReviewDate", DbType.DateTime, tran_manpowerstate.reviewdate);
			//if (tran_manpowerstate.reviewedby.HasValue)
				Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, tran_manpowerstate.reviewedby);
			if (!(string.IsNullOrEmpty(tran_manpowerstate.reviewremarks)))
				Database.AddInParameter(cmd, "@ReviewRemarks", DbType.String, tran_manpowerstate.reviewremarks);
			//if ((tran_manpowerstate.isapproved != null))
				Database.AddInParameter(cmd, "@IsApproved", DbType.Boolean, tran_manpowerstate.isapproved);
			//if ((tran_manpowerstate.approvedate.HasValue))
				Database.AddInParameter(cmd, "@ApproveDate", DbType.DateTime, tran_manpowerstate.approvedate);
			//if (tran_manpowerstate.approveby.HasValue)
				Database.AddInParameter(cmd, "@ApproveBy", DbType.Int64, tran_manpowerstate.approveby);
			if (!(string.IsNullOrEmpty(tran_manpowerstate.approveremarks)))
				Database.AddInParameter(cmd, "@ApproveRemarks", DbType.String, tran_manpowerstate.approveremarks);
			if ((tran_manpowerstate.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, tran_manpowerstate.ex_date1);
			if ((tran_manpowerstate.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, tran_manpowerstate.ex_date2);
			if (!(string.IsNullOrEmpty(tran_manpowerstate.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, tran_manpowerstate.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(tran_manpowerstate.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, tran_manpowerstate.ex_nvarchar2);
			if (tran_manpowerstate.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, tran_manpowerstate.ex_bigint1);
			if (tran_manpowerstate.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, tran_manpowerstate.ex_bigint2);
			if (tran_manpowerstate.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, tran_manpowerstate.ex_decimal1);
			if (tran_manpowerstate.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, tran_manpowerstate.ex_decimal2);

        }
		
        
		#region Add Operation

        long Itran_manpowerstateDataAccessObjects.Add(tran_manpowerstateEntity tran_manpowerstate  )
        {
            long returnCode = -99;
            const string SP = "tran_manpowerstate_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_manpowerstate, cmd,Database);
                FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.Addtran_manpowerstate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Itran_manpowerstateDataAccessObjects.Update(tran_manpowerstateEntity tran_manpowerstate )
        {
           long returnCode = -99;
            const string SP = "tran_manpowerstate_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_manpowerstate, cmd,Database);
                FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.Updatetran_manpowerstate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Itran_manpowerstateDataAccessObjects.Delete(tran_manpowerstateEntity tran_manpowerstate)
        {
            long returnCode = -99;
           	const string SP = "tran_manpowerstate_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_manpowerstate, cmd,Database, true);
                FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.Deletetran_manpowerstate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Itran_manpowerstateDataAccessObjects.SaveList(IList<tran_manpowerstateEntity> listAdded, IList<tran_manpowerstateEntity> listUpdated, IList<tran_manpowerstateEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstate_Ins";
            const string SPUpdate = "tran_manpowerstate_Upd";
            const string SPDelete = "tran_manpowerstate_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstateEntity tran_manpowerstate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstate, cmd, Database, true);
                            FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_manpowerstateEntity tran_manpowerstate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstate, cmd, Database);
                            FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_manpowerstateEntity tran_manpowerstate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstate, cmd, Database);
                            FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.Save_tran_manpowerstate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<tran_manpowerstateEntity> listAdded, IList<tran_manpowerstateEntity> listUpdated, IList<tran_manpowerstateEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_manpowerstate_Ins";
            const string SPUpdate = "tran_manpowerstate_Upd";
            const string SPDelete = "tran_manpowerstate_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_manpowerstateEntity tran_manpowerstate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_manpowerstate, cmd, db, true);
                            FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, db);
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
                    foreach (tran_manpowerstateEntity tran_manpowerstate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_manpowerstate, cmd, db);
                            FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, db);
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
                    foreach (tran_manpowerstateEntity tran_manpowerstate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_manpowerstate, cmd, db);
                            FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.Save_tran_manpowerstate"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<tran_manpowerstateEntity> Itran_manpowerstateDataAccessObjects.GetAll(tran_manpowerstateEntity tran_manpowerstate)
        {
           try
            {
				const string SP = "tran_manpowerstate_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_manpowerstate.SortExpression);
                    FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstate, cmd, Database);
                    
                    IList<tran_manpowerstateEntity> itemList = new List<tran_manpowerstateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstateEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.GetAlltran_manpowerstate"));
            }	
        }
		
		IList<tran_manpowerstateEntity> Itran_manpowerstateDataAccessObjects.GetAllByPages(tran_manpowerstateEntity tran_manpowerstate)
        {
        try
            {
				const string SP = "tran_manpowerstate_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstate.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstate.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstate.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstate, cmd,Database);

                    IList<tran_manpowerstateEntity> itemList = new List<tran_manpowerstateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstateEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.GetAllByPagestran_manpowerstate"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Itran_manpowerstateDataAccessObjects.SaveMasterDettran_manpowerstatedetl(tran_manpowerstateEntity masterEntity, 
        IList<tran_manpowerstatedetlEntity> listAdded, 
        IList<tran_manpowerstatedetlEntity> listUpdated,
        IList<tran_manpowerstatedetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "tran_manpowerstate_Ins";
            const string MasterSPUpdate = "tran_manpowerstate_Upd";
            const string MasterSPDelete = "tran_manpowerstate_Del";
            
			
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
                                item.manpowerstateid=PrimaryKeyMaster;
                            }
                        }
                        tran_manpowerstatedetlDataAccessObjects objtran_manpowerstatedetl=new tran_manpowerstatedetlDataAccessObjects(this.Context);
                        objtran_manpowerstatedetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.SaveDstran_manpowerstate"));
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
        tran_manpowerstateEntity Itran_manpowerstateDataAccessObjects.GetSingle(tran_manpowerstateEntity tran_manpowerstate)
        {
           try
            {
				const string SP = "tran_manpowerstate_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_manpowerstate, cmd, Database);
                    
                    IList<tran_manpowerstateEntity> itemList = new List<tran_manpowerstateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstateEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.GetSingletran_manpowerstate"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<tran_manpowerstateEntity> Itran_manpowerstateDataAccessObjects.GAPgListView(tran_manpowerstateEntity tran_manpowerstate)
        {
        try
            {
				const string SP = "tran_manpowerstate_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_manpowerstate.SortExpression);
                    AddPageSizeParameter(cmd, tran_manpowerstate.PageSize);
                    AddCurrentPageParameter(cmd, tran_manpowerstate.CurrentPage);                    
                    FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_manpowerstate, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_manpowerstate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_manpowerstate.strCommonSerachParam);

                    IList<tran_manpowerstateEntity> itemList = new List<tran_manpowerstateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_manpowerstateEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_manpowerstate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.GAPgListViewtran_manpowerstate"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_manpowerstateDataAccessObjects.UpdateReviewed(tran_manpowerstateEntity tran_manpowerstate )
        {
           long returnCode = -99;
            const string SP = "tran_manpowerstate_UpdRev";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_manpowerstate, cmd,Database);
                FillSequrityParameters(tran_manpowerstate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_manpowerstateDataAccess.UpdateReviewedtran_manpowerstate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }                        
        #endregion
	}
}