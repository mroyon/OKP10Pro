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
	
	internal sealed partial class hr_ptademandDataAccessObjects : BaseDataAccess, Ihr_ptademandDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_ptademandDataAccessObjects";
        
		public hr_ptademandDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_ptademandEntity hr_ptademand, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_ptademand.ptademandid.HasValue)
				Database.AddInParameter(cmd, "@PTADemandID", DbType.Int64, hr_ptademand.ptademandid);
            if (forDelete) return;
			if (hr_ptademand.visasentid.HasValue)
				Database.AddInParameter(cmd, "@VisaSentID", DbType.Int64, hr_ptademand.visasentid);
			if ((hr_ptademand.ptidate.HasValue))
				Database.AddInParameter(cmd, "@PTIDate", DbType.DateTime, hr_ptademand.ptidate);
			if ((hr_ptademand.ptiletterdate.HasValue))
				Database.AddInParameter(cmd, "@PTILetterDate", DbType.DateTime, hr_ptademand.ptiletterdate);
			if (!(string.IsNullOrEmpty(hr_ptademand.ptiletterno)))
				Database.AddInParameter(cmd, "@PTILetterNo", DbType.String, hr_ptademand.ptiletterno);
			if (!(string.IsNullOrEmpty(hr_ptademand.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_ptademand.remarks);
			if (hr_ptademand.letterstatus.HasValue)
				Database.AddInParameter(cmd, "@LetterStatus", DbType.Int64, hr_ptademand.letterstatus);
			if ((hr_ptademand.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_ptademand.ex_date1);
			if ((hr_ptademand.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_ptademand.ex_date2);
			if (!(string.IsNullOrEmpty(hr_ptademand.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_ptademand.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_ptademand.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_ptademand.ex_nvarchar2);
			if (hr_ptademand.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_ptademand.ex_bigint1);
			if (hr_ptademand.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_ptademand.ex_bigint2);
			if (hr_ptademand.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_ptademand.ex_decimal1);
			if (hr_ptademand.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_ptademand.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_ptademandDataAccessObjects.Add(hr_ptademandEntity hr_ptademand  )
        {
            long returnCode = -99;
            const string SP = "hr_ptademand_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_ptademand, cmd,Database);
                FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.Addhr_ptademand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_ptademandDataAccessObjects.Update(hr_ptademandEntity hr_ptademand )
        {
           long returnCode = -99;
            const string SP = "hr_ptademand_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_ptademand, cmd,Database);
                FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.Updatehr_ptademand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_ptademandDataAccessObjects.Delete(hr_ptademandEntity hr_ptademand)
        {
            long returnCode = -99;
           	const string SP = "hr_ptademand_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_ptademand, cmd,Database, true);
                FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.Deletehr_ptademand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_ptademandDataAccessObjects.SaveList(IList<hr_ptademandEntity> listAdded, IList<hr_ptademandEntity> listUpdated, IList<hr_ptademandEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptademand_Ins";
            const string SPUpdate = "hr_ptademand_Upd";
            const string SPDelete = "hr_ptademand_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptademandEntity hr_ptademand in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptademand, cmd, Database, true);
                            FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptademandEntity hr_ptademand in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptademand, cmd, Database);
                            FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_ptademandEntity hr_ptademand in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptademand, cmd, Database);
                            FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.Save_hr_ptademand"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_ptademandEntity> listAdded, IList<hr_ptademandEntity> listUpdated, IList<hr_ptademandEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_ptademand_Ins";
            const string SPUpdate = "hr_ptademand_Upd";
            const string SPDelete = "hr_ptademand_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_ptademandEntity hr_ptademand in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_ptademand, cmd, db, true);
                            FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptademandEntity hr_ptademand in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_ptademand, cmd, db);
                            FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, db);
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
                    foreach (hr_ptademandEntity hr_ptademand in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_ptademand, cmd, db);
                            FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.Save_hr_ptademand"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_ptademandEntity> Ihr_ptademandDataAccessObjects.GetAll(hr_ptademandEntity hr_ptademand)
        {
           try
            {
				const string SP = "hr_ptademand_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_ptademand.SortExpression);
                    FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptademand, cmd, Database);
                    
                    IList<hr_ptademandEntity> itemList = new List<hr_ptademandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademandEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.GetAllhr_ptademand"));
            }	
        }
		
		IList<hr_ptademandEntity> Ihr_ptademandDataAccessObjects.GetAllByPages(hr_ptademandEntity hr_ptademand)
        {
        try
            {
				const string SP = "hr_ptademand_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptademand.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptademand.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptademand.CurrentPage);                    
                    FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptademand, cmd,Database);

                    IList<hr_ptademandEntity> itemList = new List<hr_ptademandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademandEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptademand.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.GetAllByPageshr_ptademand"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_ptademandDataAccessObjects.SaveMasterDethr_ptademanddetl(hr_ptademandEntity masterEntity, 
        IList<hr_ptademanddetlEntity> listAdded, 
        IList<hr_ptademanddetlEntity> listUpdated,
        IList<hr_ptademanddetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_ptademand_Ins";
            const string MasterSPUpdate = "hr_ptademand_Upd";
            const string MasterSPDelete = "hr_ptademand_Del";
            
			
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
                        hr_ptademanddetlDataAccessObjects objhr_ptademanddetl=new hr_ptademanddetlDataAccessObjects(this.Context);
                        objhr_ptademanddetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            //LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.PTADemand),
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.SaveDshr_ptademand"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_ptademandDataAccessObjects.SaveMasterDethr_ptareceived(hr_ptademandEntity masterEntity, 
        IList<hr_ptareceivedEntity> listAdded, 
        IList<hr_ptareceivedEntity> listUpdated,
        IList<hr_ptareceivedEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_ptademand_Ins";
            const string MasterSPUpdate = "hr_ptademand_Upd";
            const string MasterSPDelete = "hr_ptademand_Del";
            
			
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
                        hr_ptareceivedDataAccessObjects objhr_ptareceived=new hr_ptareceivedDataAccessObjects(this.Context);
                        objhr_ptareceived.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.SaveDshr_ptademand"));
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
        hr_ptademandEntity Ihr_ptademandDataAccessObjects.GetSingle(hr_ptademandEntity hr_ptademand)
        {
           try
            {
				const string SP = "hr_ptademand_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_ptademand, cmd, Database);
                    
                    IList<hr_ptademandEntity> itemList = new List<hr_ptademandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademandEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.GetSinglehr_ptademand"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_ptademandEntity> Ihr_ptademandDataAccessObjects.GAPgListView(hr_ptademandEntity hr_ptademand)
        {
        try
            {
				const string SP = "hr_ptademand_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_ptademand.SortExpression);
                    AddPageSizeParameter(cmd, hr_ptademand.PageSize);
                    AddCurrentPageParameter(cmd, hr_ptademand.CurrentPage);                    
                    FillSequrityParameters(hr_ptademand.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_ptademand, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_ptademand.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_ptademand.strCommonSerachParam);

                    IList<hr_ptademandEntity> itemList = new List<hr_ptademandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_ptademandEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_ptademand.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_ptademandDataAccess.GAPgListViewhr_ptademand"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}