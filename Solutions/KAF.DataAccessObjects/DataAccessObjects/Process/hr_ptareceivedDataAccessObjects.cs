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
	
	internal sealed partial class hr_ptareceivedDataAccessObjects : BaseDataAccess, Ihr_ptareceivedDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_ptareceivedDataAccessObjects";
        
		public hr_ptareceivedDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_ptareceivedEntity hr_ptareceived, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_ptareceived.ptiid.HasValue)
				Database.AddInParameter(cmd, "@PTIID", DbType.Int64, hr_ptareceived.ptiid);
            if (forDelete) return;
			if (hr_ptareceived.ptademandid.HasValue)
				Database.AddInParameter(cmd, "@PTADemandID", DbType.Int64, hr_ptareceived.ptademandid);
			if ((hr_ptareceived.ptidate.HasValue))
				Database.AddInParameter(cmd, "@PTIDate", DbType.DateTime, hr_ptareceived.ptidate);
			if ((hr_ptareceived.ptiletterdate.HasValue))
				Database.AddInParameter(cmd, "@PTILetterDate", DbType.DateTime, hr_ptareceived.ptiletterdate);
			if (!(string.IsNullOrEmpty(hr_ptareceived.ptiletterno)))
				Database.AddInParameter(cmd, "@PTILetterNo", DbType.String, hr_ptareceived.ptiletterno);
			if (!(string.IsNullOrEmpty(hr_ptareceived.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_ptareceived.remarks);
			if (hr_ptareceived.letterstatus.HasValue)
				Database.AddInParameter(cmd, "@LetterStatus", DbType.Int64, hr_ptareceived.letterstatus);
			if ((hr_ptareceived.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_ptareceived.ex_date1);
			if ((hr_ptareceived.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_ptareceived.ex_date2);
			if (!(string.IsNullOrEmpty(hr_ptareceived.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_ptareceived.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_ptareceived.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_ptareceived.ex_nvarchar2);
			if (hr_ptareceived.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_ptareceived.ex_bigint1);
			if (hr_ptareceived.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_ptareceived.ex_bigint2);
			if (hr_ptareceived.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_ptareceived.ex_decimal1);
			if (hr_ptareceived.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_ptareceived.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_ptareceivedDataAccessObjects.Add(hr_ptareceivedEntity hr_ptareceived  )
        {
            long returnCode = -99;
            const string SP = "hr_ptareceived_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_ptareceived, cmd,Database);
                FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.Addhr_ptareceived"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_ptareceivedDataAccessObjects.Update(hr_ptareceivedEntity hr_ptareceived )
        {
           long returnCode = -99;
            const string SP = "hr_ptareceived_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_ptareceived, cmd,Database);
                FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.Updatehr_ptareceived"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_ptareceivedDataAccessObjects.Delete(hr_ptareceivedEntity hr_ptareceived)
        {
            long returnCode = -99;
           	const string SP = "hr_ptareceived_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_ptareceived, cmd,Database, true);
                FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.Deletehr_ptareceived"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_ptareceivedDataAccessObjects.SaveList(IList<hr_ptareceivedEntity> listAdded, IList<hr_ptareceivedEntity> listUpdated, IList<hr_ptareceivedEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptareceived_Ins";
            const string SPUpdate = "hr_ptareceived_Upd";
            const string SPDelete = "hr_ptareceived_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptareceivedEntity hr_ptareceived in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptareceived, cmd, Database, true);
                            FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptareceivedEntity hr_ptareceived in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptareceived, cmd, Database);
                            FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptareceivedEntity hr_ptareceived in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptareceived, cmd, Database);
                            FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.Save_hr_ptareceived"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_ptareceivedEntity> listAdded, IList<hr_ptareceivedEntity> listUpdated, IList<hr_ptareceivedEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptareceived_Ins";
            const string SPUpdate = "hr_ptareceived_Upd";
            const string SPDelete = "hr_ptareceived_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptareceivedEntity hr_ptareceived in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptareceived, cmd, db, true);
                            FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptareceivedEntity hr_ptareceived in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptareceived, cmd, db);
                            FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptareceivedEntity hr_ptareceived in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptareceived, cmd, db);
                            FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.Save_hr_ptareceived"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_ptareceivedEntity> Ihr_ptareceivedDataAccessObjects.GetAll(hr_ptareceivedEntity hr_ptareceived)
        {
           try
            {
				const string SP = "hr_ptareceived_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_ptareceived.SortExpression);
                    FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptareceived, cmd, Database);
                    
                    IList<hr_ptareceivedEntity> itemList = new List<hr_ptareceivedEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceivedEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.GetAllhr_ptareceived"));
            }	
        }
		
		IList<hr_ptareceivedEntity> Ihr_ptareceivedDataAccessObjects.GetAllByPages(hr_ptareceivedEntity hr_ptareceived)
        {
        try
            {
				const string SP = "hr_ptareceived_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptareceived.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptareceived.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptareceived.CurrentPage);                    
                    FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptareceived, cmd,Database);

                    IList<hr_ptareceivedEntity> itemList = new List<hr_ptareceivedEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceivedEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptareceived.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.GetAllByPageshr_ptareceived"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_ptareceivedDataAccessObjects.SaveMasterDethr_flightinfo(hr_ptareceivedEntity masterEntity, 
        IList<hr_flightinfoEntity> listAdded, 
        IList<hr_flightinfoEntity> listUpdated,
        IList<hr_flightinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_ptareceived_Ins";
            const string MasterSPUpdate = "hr_ptareceived_Upd";
            const string MasterSPDelete = "hr_ptareceived_Del";
            
			
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
                                item.ptademandid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.SaveDshr_ptareceived"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_ptareceivedDataAccessObjects.SaveMasterDethr_ptareceiveddetl(hr_ptareceivedEntity masterEntity, 
        IList<hr_ptareceiveddetlEntity> listAdded, 
        IList<hr_ptareceiveddetlEntity> listUpdated,
        IList<hr_ptareceiveddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_ptareceived_Ins";
            const string MasterSPUpdate = "hr_ptareceived_Upd";
            const string MasterSPDelete = "hr_ptareceived_Del";
            
			
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
                                item.ptiid=PrimaryKeyMaster;
                            }
                        }
                        hr_ptareceiveddetlDataAccessObjects objhr_ptareceiveddetl=new hr_ptareceiveddetlDataAccessObjects(this.Context);
                        objhr_ptareceiveddetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            //LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.PTAReceived),
                        }

                        );
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.SaveDshr_ptareceived"));
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
        hr_ptareceivedEntity Ihr_ptareceivedDataAccessObjects.GetSingle(hr_ptareceivedEntity hr_ptareceived)
        {
           try
            {
				const string SP = "hr_ptareceived_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptareceived, cmd, Database);
                    
                    IList<hr_ptareceivedEntity> itemList = new List<hr_ptareceivedEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceivedEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.GetSinglehr_ptareceived"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_ptareceivedEntity> Ihr_ptareceivedDataAccessObjects.GAPgListView(hr_ptareceivedEntity hr_ptareceived)
        {
        try
            {
				const string SP = "hr_ptareceived_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptareceived.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptareceived.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptareceived.CurrentPage);                    
                    FillSequrityParameters(hr_ptareceived.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptareceived, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_ptareceived.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_ptareceived.strCommonSerachParam);

                    IList<hr_ptareceivedEntity> itemList = new List<hr_ptareceivedEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptareceivedEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptareceived.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptareceivedDataAccess.GAPgListViewhr_ptareceived"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}