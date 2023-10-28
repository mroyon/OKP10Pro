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
	
	internal sealed partial class hr_visademandinfoDataAccessObjects : BaseDataAccess, Ihr_visademandinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_visademandinfoDataAccessObjects";
        
		public hr_visademandinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_visademandinfoEntity hr_visademandinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_visademandinfo.visademandid.HasValue)
				Database.AddInParameter(cmd, "@VisaDemandID", DbType.Int64, hr_visademandinfo.visademandid);
            if (forDelete) return;
			if (hr_visademandinfo.demandtype.HasValue)
				Database.AddInParameter(cmd, "@DemandType", DbType.Int64, hr_visademandinfo.demandtype);
			if (hr_visademandinfo.passportinfoid.HasValue)
				Database.AddInParameter(cmd, "@PassportInfoID", DbType.Int64, hr_visademandinfo.passportinfoid);
			if ((hr_visademandinfo.visademanddate.HasValue))
				Database.AddInParameter(cmd, "@VisaDemandDate", DbType.DateTime, hr_visademandinfo.visademanddate);
			if ((hr_visademandinfo.visademandletterdate.HasValue))
				Database.AddInParameter(cmd, "@VisaDemandLetterDate", DbType.DateTime, hr_visademandinfo.visademandletterdate);
			if (!(string.IsNullOrEmpty(hr_visademandinfo.visademandletterno)))
				Database.AddInParameter(cmd, "@VisaDemandLetterNo", DbType.String, hr_visademandinfo.visademandletterno);
			if (!(string.IsNullOrEmpty(hr_visademandinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_visademandinfo.remarks);
			if ((hr_visademandinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_visademandinfo.ex_date1);
			if ((hr_visademandinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_visademandinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_visademandinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_visademandinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_visademandinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_visademandinfo.ex_nvarchar2);
			if (hr_visademandinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_visademandinfo.ex_bigint1);
			if (hr_visademandinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_visademandinfo.ex_bigint2);
			if (hr_visademandinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_visademandinfo.ex_decimal1);
			if (hr_visademandinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_visademandinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_visademandinfoDataAccessObjects.Add(hr_visademandinfoEntity hr_visademandinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_visademandinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_visademandinfo, cmd,Database);
                FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.Addhr_visademandinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_visademandinfoDataAccessObjects.Update(hr_visademandinfoEntity hr_visademandinfo )
        {
           long returnCode = -99;
            const string SP = "hr_visademandinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_visademandinfo, cmd,Database);
                FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.Updatehr_visademandinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_visademandinfoDataAccessObjects.Delete(hr_visademandinfoEntity hr_visademandinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_visademandinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_visademandinfo, cmd,Database, true);
                FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.Deletehr_visademandinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_visademandinfoDataAccessObjects.SaveList(IList<hr_visademandinfoEntity> listAdded, IList<hr_visademandinfoEntity> listUpdated, IList<hr_visademandinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visademandinfo_Ins";
            const string SPUpdate = "hr_visademandinfo_Upd";
            const string SPDelete = "hr_visademandinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visademandinfoEntity hr_visademandinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visademandinfo, cmd, Database, true);
                            FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visademandinfoEntity hr_visademandinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visademandinfo, cmd, Database);
                            FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_visademandinfoEntity hr_visademandinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visademandinfo, cmd, Database);
                            FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.Save_hr_visademandinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_visademandinfoEntity> listAdded, IList<hr_visademandinfoEntity> listUpdated, IList<hr_visademandinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_visademandinfo_Ins";
            const string SPUpdate = "hr_visademandinfo_Upd";
            const string SPDelete = "hr_visademandinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_visademandinfoEntity hr_visademandinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_visademandinfo, cmd, db, true);
                            FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visademandinfoEntity hr_visademandinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_visademandinfo, cmd, db);
                            FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_visademandinfoEntity hr_visademandinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_visademandinfo, cmd, db);
                            FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.Save_hr_visademandinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_visademandinfoEntity> Ihr_visademandinfoDataAccessObjects.GetAll(hr_visademandinfoEntity hr_visademandinfo)
        {
           try
            {
				const string SP = "hr_visademandinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_visademandinfo.SortExpression);
                    FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visademandinfo, cmd, Database);
                    
                    IList<hr_visademandinfoEntity> itemList = new List<hr_visademandinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.GetAllhr_visademandinfo"));
            }	
        }
		
		IList<hr_visademandinfoEntity> Ihr_visademandinfoDataAccessObjects.GetAllByPages(hr_visademandinfoEntity hr_visademandinfo)
        {
        try
            {
				const string SP = "hr_visademandinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visademandinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_visademandinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_visademandinfo.CurrentPage);                    
                    FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visademandinfo, cmd,Database);

                    IList<hr_visademandinfoEntity> itemList = new List<hr_visademandinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visademandinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.GetAllByPageshr_visademandinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_visademandinfoDataAccessObjects.SaveMasterDethr_visademandinfodetl(hr_visademandinfoEntity masterEntity, 
        IList<hr_visademandinfodetlEntity> listAdded, 
        IList<hr_visademandinfodetlEntity> listUpdated,
        IList<hr_visademandinfodetlEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visademandinfo_Ins";
            const string MasterSPUpdate = "hr_visademandinfo_Upd";
            const string MasterSPDelete = "hr_visademandinfo_Del";
            
			
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
                                item.visademandid=PrimaryKeyMaster;
                            }
                        }
                        hr_visademandinfodetlDataAccessObjects objhr_visademandinfodetl=new hr_visademandinfodetlDataAccessObjects(this.Context);
                        objhr_visademandinfodetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);

                        DataAccessObjectsPartial.ReportExtensionDataAccess objReport = new DataAccessObjectsPartial.ReportExtensionDataAccess(this.Context);
                        objReport.KAFProcess_UpdateLetterStatus(Database, transaction, new BusinessDataObjects.BusinessDataObjectsPartials.KAFProcess_UpdateLetterStatusEntity
                        {
                            LetterID = PrimaryKeyMaster,
                            LetterType = masterEntity.demandtype==1? Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.Replacement) : Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterType.NewDemand),
                            LetterStatus = Convert.ToInt64(KAF.ConstantTypes.clsSystemConstantTypes.LetterStatus.VisaDemand),
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.SaveDshr_visademandinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_visademandinfoDataAccessObjects.SaveMasterDethr_visaissueinfo(hr_visademandinfoEntity masterEntity, 
        IList<hr_visaissueinfoEntity> listAdded, 
        IList<hr_visaissueinfoEntity> listUpdated,
        IList<hr_visaissueinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_visademandinfo_Ins";
            const string MasterSPUpdate = "hr_visademandinfo_Upd";
            const string MasterSPDelete = "hr_visademandinfo_Del";
            
			
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
                                item.visademandid=PrimaryKeyMaster;
                            }
                        }
                        hr_visaissueinfoDataAccessObjects objhr_visaissueinfo=new hr_visaissueinfoDataAccessObjects(this.Context);
                        objhr_visaissueinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.SaveDshr_visademandinfo"));
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
        hr_visademandinfoEntity Ihr_visademandinfoDataAccessObjects.GetSingle(hr_visademandinfoEntity hr_visademandinfo)
        {
           try
            {
				const string SP = "hr_visademandinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_visademandinfo, cmd, Database);
                    
                    IList<hr_visademandinfoEntity> itemList = new List<hr_visademandinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.GetSinglehr_visademandinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_visademandinfoEntity> Ihr_visademandinfoDataAccessObjects.GAPgListView(hr_visademandinfoEntity hr_visademandinfo)
        {
        try
            {
				const string SP = "hr_visademandinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_visademandinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_visademandinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_visademandinfo.CurrentPage);                    
                    FillSequrityParameters(hr_visademandinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_visademandinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_visademandinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_visademandinfo.strCommonSerachParam);

                    IList<hr_visademandinfoEntity> itemList = new List<hr_visademandinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_visademandinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_visademandinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_visademandinfoDataAccess.GAPgListViewhr_visademandinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}