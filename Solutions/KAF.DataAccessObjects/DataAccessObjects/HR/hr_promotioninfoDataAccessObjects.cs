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
	
	internal sealed partial class hr_promotioninfoDataAccessObjects : BaseDataAccess, Ihr_promotioninfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_promotioninfoDataAccessObjects";
        
		public hr_promotioninfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_promotioninfoEntity hr_promotioninfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_promotioninfo.promotionid.HasValue)
				Database.AddInParameter(cmd, "@PromotionID", DbType.Int64, hr_promotioninfo.promotionid);
            if (forDelete) return;
			if (hr_promotioninfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicId", DbType.Int64, hr_promotioninfo.hrbasicid);
			if ((hr_promotioninfo.promotiondate.HasValue))
				Database.AddInParameter(cmd, "@PromotionDate", DbType.DateTime, hr_promotioninfo.promotiondate);
			if (hr_promotioninfo.promotiontypeid.HasValue)
				Database.AddInParameter(cmd, "@PromotionTypeID", DbType.Int64, hr_promotioninfo.promotiontypeid);
			if (hr_promotioninfo.torankid.HasValue)
				Database.AddInParameter(cmd, "@ToRankId", DbType.Int64, hr_promotioninfo.torankid);
			if (hr_promotioninfo.promotionno.HasValue)
				Database.AddInParameter(cmd, "@PromotionNo", DbType.Int64, hr_promotioninfo.promotionno);
			if (hr_promotioninfo.promotiondesignation.HasValue)
				Database.AddInParameter(cmd, "@PromotionDesignation", DbType.Int64, hr_promotioninfo.promotiondesignation);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.promotiondelayreason)))
				Database.AddInParameter(cmd, "@PromotionDelayReason", DbType.String, hr_promotioninfo.promotiondelayreason);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.promotiondelaydocno)))
				Database.AddInParameter(cmd, "@PromotionDelayDocNo", DbType.String, hr_promotioninfo.promotiondelaydocno);
			if ((hr_promotioninfo.promotiondelaydocdate.HasValue))
				Database.AddInParameter(cmd, "@PromotionDelayDocDate", DbType.DateTime, hr_promotioninfo.promotiondelaydocdate);
			if ((hr_promotioninfo.promotiondelaystartdate.HasValue))
				Database.AddInParameter(cmd, "@PromotionDelayStartDate", DbType.DateTime, hr_promotioninfo.promotiondelaystartdate);
			if (hr_promotioninfo.promotiondelayperiod.HasValue)
				Database.AddInParameter(cmd, "@PromotionDelayPeriod", DbType.Int64, hr_promotioninfo.promotiondelayperiod);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.orderno)))
				Database.AddInParameter(cmd, "@OrderNo", DbType.String, hr_promotioninfo.orderno);
			if ((hr_promotioninfo.orderdate.HasValue))
				Database.AddInParameter(cmd, "@OrderDate", DbType.DateTime, hr_promotioninfo.orderdate);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.orderfiledescription)))
				Database.AddInParameter(cmd, "@OrderFileDescription", DbType.String, hr_promotioninfo.orderfiledescription);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.orderfilepath)))
				Database.AddInParameter(cmd, "@OrderFilePath", DbType.String, hr_promotioninfo.orderfilepath);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.orderfilename)))
				Database.AddInParameter(cmd, "@OrderFileName", DbType.String, hr_promotioninfo.orderfilename);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.orderfiletype)))
				Database.AddInParameter(cmd, "@OrderFileType", DbType.String, hr_promotioninfo.orderfiletype);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.orderextension)))
				Database.AddInParameter(cmd, "@OrderExtension", DbType.String, hr_promotioninfo.orderextension);
			
				Database.AddInParameter(cmd, "@OrderFileNo", DbType.Guid, hr_promotioninfo.orderfileno);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_promotioninfo.remarks);
			if ((hr_promotioninfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_promotioninfo.ex_date1);
			if ((hr_promotioninfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_promotioninfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_promotioninfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_promotioninfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_promotioninfo.ex_nvarchar2);
			if (hr_promotioninfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_promotioninfo.ex_bigint1);
			if (hr_promotioninfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_promotioninfo.ex_bigint2);
			if (hr_promotioninfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_promotioninfo.ex_decimal1);
			if (hr_promotioninfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_promotioninfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_promotioninfoDataAccessObjects.Add(hr_promotioninfoEntity hr_promotioninfo  )
        {
            long returnCode = -99;
            const string SP = "hr_promotioninfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_promotioninfo, cmd,Database);
                FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.Addhr_promotioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_promotioninfoDataAccessObjects.Update(hr_promotioninfoEntity hr_promotioninfo )
        {
           long returnCode = -99;
            const string SP = "hr_promotioninfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_promotioninfo, cmd,Database);
                FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.Updatehr_promotioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_promotioninfoDataAccessObjects.Delete(hr_promotioninfoEntity hr_promotioninfo)
        {
            long returnCode = -99;
           	const string SP = "hr_promotioninfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_promotioninfo, cmd,Database, true);
                FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.Deletehr_promotioninfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_promotioninfoDataAccessObjects.SaveList(IList<hr_promotioninfoEntity> listAdded, IList<hr_promotioninfoEntity> listUpdated, IList<hr_promotioninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_promotioninfo_Ins";
            const string SPUpdate = "hr_promotioninfo_Upd";
            const string SPDelete = "hr_promotioninfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_promotioninfoEntity hr_promotioninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_promotioninfo, cmd, Database, true);
                            FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_promotioninfoEntity hr_promotioninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_promotioninfo, cmd, Database);
                            FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_promotioninfoEntity hr_promotioninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_promotioninfo, cmd, Database);
                            FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.Save_hr_promotioninfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_promotioninfoEntity> listAdded, IList<hr_promotioninfoEntity> listUpdated, IList<hr_promotioninfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_promotioninfo_Ins";
            const string SPUpdate = "hr_promotioninfo_Upd";
            const string SPDelete = "hr_promotioninfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_promotioninfoEntity hr_promotioninfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_promotioninfo, cmd, db, true);
                            FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_promotioninfoEntity hr_promotioninfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_promotioninfo, cmd, db);
                            FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_promotioninfoEntity hr_promotioninfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_promotioninfo, cmd, db);
                            FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.Save_hr_promotioninfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_promotioninfoEntity> Ihr_promotioninfoDataAccessObjects.GetAll(hr_promotioninfoEntity hr_promotioninfo)
        {
           try
            {
				const string SP = "hr_promotioninfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_promotioninfo.SortExpression);
                    FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_promotioninfo, cmd, Database);
                    
                    IList<hr_promotioninfoEntity> itemList = new List<hr_promotioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_promotioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.GetAllhr_promotioninfo"));
            }	
        }
		
		IList<hr_promotioninfoEntity> Ihr_promotioninfoDataAccessObjects.GetAllByPages(hr_promotioninfoEntity hr_promotioninfo)
        {
        try
            {
				const string SP = "hr_promotioninfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_promotioninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_promotioninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_promotioninfo.CurrentPage);                    
                    FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_promotioninfo, cmd,Database);

                    IList<hr_promotioninfoEntity> itemList = new List<hr_promotioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_promotioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_promotioninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.GetAllByPageshr_promotioninfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_promotioninfoEntity Ihr_promotioninfoDataAccessObjects.GetSingle(hr_promotioninfoEntity hr_promotioninfo)
        {
           try
            {
				const string SP = "hr_promotioninfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_promotioninfo, cmd, Database);
                    
                    IList<hr_promotioninfoEntity> itemList = new List<hr_promotioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_promotioninfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.GetSinglehr_promotioninfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_promotioninfoEntity> Ihr_promotioninfoDataAccessObjects.GAPgListView(hr_promotioninfoEntity hr_promotioninfo)
        {
        try
            {
				const string SP = "hr_promotioninfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_promotioninfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_promotioninfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_promotioninfo.CurrentPage);                    
                    FillSequrityParameters(hr_promotioninfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_promotioninfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_promotioninfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_promotioninfo.strCommonSerachParam);

                    IList<hr_promotioninfoEntity> itemList = new List<hr_promotioninfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_promotioninfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_promotioninfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_promotioninfoDataAccess.GAPgListViewhr_promotioninfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}