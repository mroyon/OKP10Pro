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
	
	internal sealed partial class hr_arrivalinfoDataAccessObjects : BaseDataAccess, Ihr_arrivalinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_arrivalinfoDataAccessObjects";
        
		public hr_arrivalinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_arrivalinfoEntity hr_arrivalinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_arrivalinfo.arrivalld.HasValue)
				Database.AddInParameter(cmd, "@ArrivallD", DbType.Int64, hr_arrivalinfo.arrivalld);
            if (forDelete) return;
			if (hr_arrivalinfo.flightid.HasValue)
				Database.AddInParameter(cmd, "@FlightID", DbType.Int64, hr_arrivalinfo.flightid);
			if ((hr_arrivalinfo.arrivaldate.HasValue))
				Database.AddInParameter(cmd, "@ArrivalDate", DbType.DateTime, hr_arrivalinfo.arrivaldate);
			if ((hr_arrivalinfo.arrivalletterdate.HasValue))
				Database.AddInParameter(cmd, "@ArrivalLetterDate", DbType.DateTime, hr_arrivalinfo.arrivalletterdate);
			if (!(string.IsNullOrEmpty(hr_arrivalinfo.arrivalletterno)))
				Database.AddInParameter(cmd, "@ArrivalLetterNo", DbType.String, hr_arrivalinfo.arrivalletterno);
			if (!(string.IsNullOrEmpty(hr_arrivalinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_arrivalinfo.remarks);
			if ((hr_arrivalinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_arrivalinfo.ex_date1);
			if ((hr_arrivalinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_arrivalinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_arrivalinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_arrivalinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_arrivalinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_arrivalinfo.ex_nvarchar2);
			if (hr_arrivalinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_arrivalinfo.ex_bigint1);
			if (hr_arrivalinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_arrivalinfo.ex_bigint2);
			if (hr_arrivalinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_arrivalinfo.ex_decimal1);
			if (hr_arrivalinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_arrivalinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_arrivalinfoDataAccessObjects.Add(hr_arrivalinfoEntity hr_arrivalinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_arrivalinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_arrivalinfo, cmd,Database);
                FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.Addhr_arrivalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_arrivalinfoDataAccessObjects.Update(hr_arrivalinfoEntity hr_arrivalinfo )
        {
           long returnCode = -99;
            const string SP = "hr_arrivalinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_arrivalinfo, cmd,Database);
                FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.Updatehr_arrivalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_arrivalinfoDataAccessObjects.Delete(hr_arrivalinfoEntity hr_arrivalinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_arrivalinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_arrivalinfo, cmd,Database, true);
                FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.Deletehr_arrivalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_arrivalinfoDataAccessObjects.SaveList(IList<hr_arrivalinfoEntity> listAdded, IList<hr_arrivalinfoEntity> listUpdated, IList<hr_arrivalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_arrivalinfo_Ins";
            const string SPUpdate = "hr_arrivalinfo_Upd";
            const string SPDelete = "hr_arrivalinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_arrivalinfoEntity hr_arrivalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_arrivalinfo, cmd, Database, true);
                            FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_arrivalinfoEntity hr_arrivalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_arrivalinfo, cmd, Database);
                            FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_arrivalinfoEntity hr_arrivalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_arrivalinfo, cmd, Database);
                            FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.Save_hr_arrivalinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_arrivalinfoEntity> listAdded, IList<hr_arrivalinfoEntity> listUpdated, IList<hr_arrivalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_arrivalinfo_Ins";
            const string SPUpdate = "hr_arrivalinfo_Upd";
            const string SPDelete = "hr_arrivalinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_arrivalinfoEntity hr_arrivalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_arrivalinfo, cmd, db, true);
                            FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_arrivalinfoEntity hr_arrivalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_arrivalinfo, cmd, db);
                            FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_arrivalinfoEntity hr_arrivalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_arrivalinfo, cmd, db);
                            FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.Save_hr_arrivalinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_arrivalinfoEntity> Ihr_arrivalinfoDataAccessObjects.GetAll(hr_arrivalinfoEntity hr_arrivalinfo)
        {
           try
            {
				const string SP = "hr_arrivalinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_arrivalinfo.SortExpression);
                    FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_arrivalinfo, cmd, Database);
                    
                    IList<hr_arrivalinfoEntity> itemList = new List<hr_arrivalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.GetAllhr_arrivalinfo"));
            }	
        }
		
		IList<hr_arrivalinfoEntity> Ihr_arrivalinfoDataAccessObjects.GetAllByPages(hr_arrivalinfoEntity hr_arrivalinfo)
        {
        try
            {
				const string SP = "hr_arrivalinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_arrivalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_arrivalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_arrivalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_arrivalinfo, cmd,Database);

                    IList<hr_arrivalinfoEntity> itemList = new List<hr_arrivalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_arrivalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.GetAllByPageshr_arrivalinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_arrivalinfoDataAccessObjects.SaveMasterDethr_arrivalinfodetl(hr_arrivalinfoEntity masterEntity, 
        IList<hr_arrivalinfodetlEntity> listAdded, 
        IList<hr_arrivalinfodetlEntity> listUpdated,
        IList<hr_arrivalinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_arrivalinfo_Ins";
            const string MasterSPUpdate = "hr_arrivalinfo_Upd";
            const string MasterSPDelete = "hr_arrivalinfo_Del";
            
			
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
                                item.arrivalld=PrimaryKeyMaster;
                            }
                        }
                        hr_arrivalinfodetlDataAccessObjects objhr_arrivalinfodetl=new hr_arrivalinfodetlDataAccessObjects(this.Context);
                        objhr_arrivalinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            //LetterType = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement),
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.Arrived),
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.SaveDshr_arrivalinfo"));
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
        hr_arrivalinfoEntity Ihr_arrivalinfoDataAccessObjects.GetSingle(hr_arrivalinfoEntity hr_arrivalinfo)
        {
           try
            {
				const string SP = "hr_arrivalinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_arrivalinfo, cmd, Database);
                    
                    IList<hr_arrivalinfoEntity> itemList = new List<hr_arrivalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.GetSinglehr_arrivalinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_arrivalinfoEntity> Ihr_arrivalinfoDataAccessObjects.GAPgListView(hr_arrivalinfoEntity hr_arrivalinfo)
        {
        try
            {
				const string SP = "hr_arrivalinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_arrivalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_arrivalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_arrivalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_arrivalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_arrivalinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_arrivalinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_arrivalinfo.strCommonSerachParam);

                    IList<hr_arrivalinfoEntity> itemList = new List<hr_arrivalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_arrivalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_arrivalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_arrivalinfoDataAccess.GAPgListViewhr_arrivalinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}