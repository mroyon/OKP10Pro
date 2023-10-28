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
	
	internal sealed partial class hr_flightinfoDataAccessObjects : BaseDataAccess, Ihr_flightinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_flightinfoDataAccessObjects";
        
		public hr_flightinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_flightinfoEntity hr_flightinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_flightinfo.flightid.HasValue)
				Database.AddInParameter(cmd, "@FlightID", DbType.Int64, hr_flightinfo.flightid);
            if (forDelete) return;
			if (hr_flightinfo.ptademandid.HasValue)
				Database.AddInParameter(cmd, "@PTIID", DbType.Int64, hr_flightinfo.ptademandid);
			if ((hr_flightinfo.flightdate.HasValue))
				Database.AddInParameter(cmd, "@FlightDate", DbType.DateTime, hr_flightinfo.flightdate);
			if ((hr_flightinfo.flightletterdate.HasValue))
				Database.AddInParameter(cmd, "@FlightLetterDate", DbType.DateTime, hr_flightinfo.flightletterdate);
			if (!(string.IsNullOrEmpty(hr_flightinfo.flightletterno)))
				Database.AddInParameter(cmd, "@FlightLetterNo", DbType.String, hr_flightinfo.flightletterno);
			if (hr_flightinfo.airlinesid.HasValue)
				Database.AddInParameter(cmd, "@AirlinesID", DbType.Int64, hr_flightinfo.airlinesid);
			if (!(string.IsNullOrEmpty(hr_flightinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_flightinfo.remarks);
			if ((hr_flightinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_flightinfo.ex_date1);
			if ((hr_flightinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_flightinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_flightinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_flightinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_flightinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_flightinfo.ex_nvarchar2);
			if (hr_flightinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_flightinfo.ex_bigint1);
			if (hr_flightinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_flightinfo.ex_bigint2);
			if (hr_flightinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_flightinfo.ex_decimal1);
			if (hr_flightinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_flightinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_flightinfoDataAccessObjects.Add(hr_flightinfoEntity hr_flightinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_flightinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_flightinfo, cmd,Database);
                FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Addhr_flightinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_flightinfoDataAccessObjects.Update(hr_flightinfoEntity hr_flightinfo )
        {
           long returnCode = -99;
            const string SP = "hr_flightinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_flightinfo, cmd,Database);
                FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Updatehr_flightinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_flightinfoDataAccessObjects.Delete(hr_flightinfoEntity hr_flightinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_flightinfo_Del_ReIssuedFlight";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_flightinfo, cmd,Database, true);
                FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Deletehr_flightinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_flightinfoDataAccessObjects.SaveList(IList<hr_flightinfoEntity> listAdded, IList<hr_flightinfoEntity> listUpdated, IList<hr_flightinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_flightinfo_Ins";
            const string SPUpdate = "hr_flightinfo_Upd";
            const string SPDelete = "hr_flightinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_flightinfoEntity hr_flightinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_flightinfo, cmd, Database, true);
                            FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_flightinfoEntity hr_flightinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_flightinfo, cmd, Database);
                            FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_flightinfoEntity hr_flightinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_flightinfo, cmd, Database);
                            FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Save_hr_flightinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_flightinfoEntity> listAdded, IList<hr_flightinfoEntity> listUpdated, IList<hr_flightinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_flightinfo_Ins";
            const string SPUpdate = "hr_flightinfo_Upd";
            const string SPDelete = "hr_flightinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_flightinfoEntity hr_flightinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_flightinfo, cmd, db, true);
                            FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_flightinfoEntity hr_flightinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_flightinfo, cmd, db);
                            FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_flightinfoEntity hr_flightinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_flightinfo, cmd, db);
                            FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Save_hr_flightinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_flightinfoEntity> Ihr_flightinfoDataAccessObjects.GetAll(hr_flightinfoEntity hr_flightinfo)
        {
           try
            {
				const string SP = "hr_flightinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_flightinfo.SortExpression);
                    FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_flightinfo, cmd, Database);
                    
                    IList<hr_flightinfoEntity> itemList = new List<hr_flightinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.GetAllhr_flightinfo"));
            }	
        }
		
		IList<hr_flightinfoEntity> Ihr_flightinfoDataAccessObjects.GetAllByPages(hr_flightinfoEntity hr_flightinfo)
        {
        try
            {
				const string SP = "hr_flightinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_flightinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_flightinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_flightinfo.CurrentPage);                    
                    FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_flightinfo, cmd,Database);

                    IList<hr_flightinfoEntity> itemList = new List<hr_flightinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_flightinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.GetAllByPageshr_flightinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_flightinfoDataAccessObjects.SaveMasterDethr_arrivalinfo(hr_flightinfoEntity masterEntity, 
        IList<hr_arrivalinfoEntity> listAdded, 
        IList<hr_arrivalinfoEntity> listUpdated,
        IList<hr_arrivalinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_flightinfo_Ins";
            const string MasterSPUpdate = "hr_flightinfo_Upd";
            const string MasterSPDelete = "hr_flightinfo_Del";
            
			
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
                                item.flightid=PrimaryKeyMaster;
                            }
                        }
                        hr_arrivalinfoDataAccessObjects objhr_arrivalinfo=new hr_arrivalinfoDataAccessObjects(this.Context);
                        objhr_arrivalinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.SaveDshr_flightinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_flightinfoDataAccessObjects.SaveMasterDethr_flightinfodetl(hr_flightinfoEntity masterEntity, 
        IList<hr_flightinfodetlEntity> listAdded, 
        IList<hr_flightinfodetlEntity> listUpdated,
        IList<hr_flightinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_flightinfo_Ins";
            const string MasterSPUpdate = "hr_flightinfo_Upd";
            const string MasterSPDelete = "hr_flightinfo_Del";
            
			
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
                                item.flightid=PrimaryKeyMaster;
                            }
                        }
                        hr_flightinfodetlDataAccessObjects objhr_flightinfodetl=new hr_flightinfodetlDataAccessObjects(this.Context);
                        objhr_flightinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        Int64 LetterStatus = -99;
                        if (masterEntity.iscancel != null && masterEntity.iscancel == true)
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.FlightCancel);
                        else if (masterEntity.reissued != null && masterEntity.reissued == true)
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.FlightReIssued);
                        else
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.FlightConfirmed);


                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            //LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                            LetterStatus = LetterStatus,
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.SaveDshr_flightinfo"));
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
        hr_flightinfoEntity Ihr_flightinfoDataAccessObjects.GetSingle(hr_flightinfoEntity hr_flightinfo)
        {
           try
            {
				const string SP = "hr_flightinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_flightinfo, cmd, Database);
                    
                    IList<hr_flightinfoEntity> itemList = new List<hr_flightinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.GetSinglehr_flightinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_flightinfoEntity> Ihr_flightinfoDataAccessObjects.GAPgListView(hr_flightinfoEntity hr_flightinfo)
        {
        try
            {
				 string SP = "hr_flightinfo_GAPgListView";

                if(hr_flightinfo.iscancel==true)
                    SP = "hr_flightinfo_GAPgListView_Cancel";

                if (hr_flightinfo.iscancel == true && hr_flightinfo.reissued==true)
                    SP = "hr_flightinfo_GAPgListView_CancelReissue";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_flightinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_flightinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_flightinfo.CurrentPage);                    
                    FillSequrityParameters(hr_flightinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_flightinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_flightinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_flightinfo.strCommonSerachParam);

                    IList<hr_flightinfoEntity> itemList = new List<hr_flightinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_flightinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.GAPgListViewhr_flightinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}