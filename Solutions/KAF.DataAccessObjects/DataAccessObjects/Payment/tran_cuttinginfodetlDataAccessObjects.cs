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
	
	internal sealed partial class tran_cuttinginfodetlDataAccessObjects : BaseDataAccess, Itran_cuttinginfodetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_cuttinginfodetlDataAccessObjects";
        
		public tran_cuttinginfodetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_cuttinginfodetlEntity tran_cuttinginfodetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_cuttinginfodetl.cuttinginfodetlid.HasValue)
				Database.AddInParameter(cmd, "@CuttingInfoDetlID", DbType.Int64, tran_cuttinginfodetl.cuttinginfodetlid);
            if (forDelete) return;
			if (tran_cuttinginfodetl.cuttinginfoid.HasValue)
				Database.AddInParameter(cmd, "@CuttingInfoID", DbType.Int64, tran_cuttinginfodetl.cuttinginfoid);
			if (tran_cuttinginfodetl.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, tran_cuttinginfodetl.hrbasicid);
			if (tran_cuttinginfodetl.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, tran_cuttinginfodetl.rankid);
            if (tran_cuttinginfodetl.groupid.HasValue)
                Database.AddInParameter(cmd, "@GroupID", DbType.Int64, tran_cuttinginfodetl.groupid);
            if ((tran_cuttinginfodetl.processdate.HasValue))
				Database.AddInParameter(cmd, "@ProcessDate", DbType.DateTime, tran_cuttinginfodetl.processdate);
			if (tran_cuttinginfodetl.prevbalgovtcutting.HasValue)
				Database.AddInParameter(cmd, "@PrevBalGovtCutting", DbType.Decimal, tran_cuttinginfodetl.prevbalgovtcutting);
			if (tran_cuttinginfodetl.prevbalregcutting.HasValue)
				Database.AddInParameter(cmd, "@PrevBalRegCutting", DbType.Decimal, tran_cuttinginfodetl.prevbalregcutting);
			if (tran_cuttinginfodetl.basicsalary.HasValue)
				Database.AddInParameter(cmd, "@BasicSalary", DbType.Decimal, tran_cuttinginfodetl.basicsalary);
			if (tran_cuttinginfodetl.regimentalcutting.HasValue)
				Database.AddInParameter(cmd, "@RegimentalCutting", DbType.Decimal, tran_cuttinginfodetl.regimentalcutting);
			if (tran_cuttinginfodetl.govtcutting.HasValue)
				Database.AddInParameter(cmd, "@GovtCutting", DbType.Decimal, tran_cuttinginfodetl.govtcutting);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_cuttinginfodetl.remarks);
			if ((tran_cuttinginfodetl.ispaid != null))
				Database.AddInParameter(cmd, "@IsPaid", DbType.Boolean, tran_cuttinginfodetl.ispaid);
			if ((tran_cuttinginfodetl.paiddate.HasValue))
				Database.AddInParameter(cmd, "@PaidDate", DbType.DateTime, tran_cuttinginfodetl.paiddate);
			if (tran_cuttinginfodetl.paidby.HasValue)
				Database.AddInParameter(cmd, "@PaidBy", DbType.Int64, tran_cuttinginfodetl.paidby);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.unpaidremarks)))
				Database.AddInParameter(cmd, "@UnPaidRemarks", DbType.String, tran_cuttinginfodetl.unpaidremarks);
			if ((tran_cuttinginfodetl.isreviewed != null))
				Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, tran_cuttinginfodetl.isreviewed);
			if ((tran_cuttinginfodetl.reviewdate.HasValue))
				Database.AddInParameter(cmd, "@ReviewDate", DbType.DateTime, tran_cuttinginfodetl.reviewdate);
			if (tran_cuttinginfodetl.reviewedby.HasValue)
				Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, tran_cuttinginfodetl.reviewedby);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.reviewremarks)))
				Database.AddInParameter(cmd, "@ReviewRemarks", DbType.String, tran_cuttinginfodetl.reviewremarks);
			if ((tran_cuttinginfodetl.isapprove != null))
				Database.AddInParameter(cmd, "@IsApprove", DbType.Boolean, tran_cuttinginfodetl.isapprove);
			if ((tran_cuttinginfodetl.approvedate.HasValue))
				Database.AddInParameter(cmd, "@ApproveDate", DbType.DateTime, tran_cuttinginfodetl.approvedate);
			if (tran_cuttinginfodetl.approveby.HasValue)
				Database.AddInParameter(cmd, "@ApproveBy", DbType.Int64, tran_cuttinginfodetl.approveby);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.approveremarks)))
				Database.AddInParameter(cmd, "@ApproveRemarks", DbType.String, tran_cuttinginfodetl.approveremarks);
			if ((tran_cuttinginfodetl.isrollback != null))
				Database.AddInParameter(cmd, "@IsRollBack", DbType.Boolean, tran_cuttinginfodetl.isrollback);
			if (tran_cuttinginfodetl.rollbackby.HasValue)
				Database.AddInParameter(cmd, "@RollbackBy", DbType.Int64, tran_cuttinginfodetl.rollbackby);
			if ((tran_cuttinginfodetl.rollbackdate.HasValue))
				Database.AddInParameter(cmd, "@RollBackDate", DbType.DateTime, tran_cuttinginfodetl.rollbackdate);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.rollbackremarks)))
				Database.AddInParameter(cmd, "@RollBackRemarks", DbType.String, tran_cuttinginfodetl.rollbackremarks);
			if ((tran_cuttinginfodetl.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, tran_cuttinginfodetl.ex_date1);
			if ((tran_cuttinginfodetl.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, tran_cuttinginfodetl.ex_date2);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, tran_cuttinginfodetl.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(tran_cuttinginfodetl.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, tran_cuttinginfodetl.ex_nvarchar2);
			if (tran_cuttinginfodetl.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, tran_cuttinginfodetl.ex_bigint1);
			if (tran_cuttinginfodetl.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, tran_cuttinginfodetl.ex_bigint2);
			if (tran_cuttinginfodetl.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, tran_cuttinginfodetl.ex_decimal1);
			if (tran_cuttinginfodetl.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, tran_cuttinginfodetl.ex_decimal2);

        }
		
        
		#region Add Operation

        long Itran_cuttinginfodetlDataAccessObjects.Add(tran_cuttinginfodetlEntity tran_cuttinginfodetl  )
        {
            long returnCode = -99;
            const string SP = "tran_cuttinginfodetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_cuttinginfodetl, cmd,Database);
                FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.Addtran_cuttinginfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Itran_cuttinginfodetlDataAccessObjects.Update(tran_cuttinginfodetlEntity tran_cuttinginfodetl )
        {
           long returnCode = -99;
             string SP = "tran_cuttinginfodetl_Upd";

            if(tran_cuttinginfodetl.paymenttype.HasValue)
            {
                SP = "tran_cuttinginfodetl_Upd_Ext";
            }
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_cuttinginfodetl, cmd,Database);
                FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.Updatetran_cuttinginfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Itran_cuttinginfodetlDataAccessObjects.Delete(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
        {
            long returnCode = -99;
           	const string SP = "tran_cuttinginfodetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_cuttinginfodetl, cmd,Database, true);
                FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.Deletetran_cuttinginfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Itran_cuttinginfodetlDataAccessObjects.SaveList(IList<tran_cuttinginfodetlEntity> listAdded, IList<tran_cuttinginfodetlEntity> listUpdated, IList<tran_cuttinginfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_cuttinginfodetl_Ins";
            const string SPUpdate = "tran_cuttinginfodetl_Upd";
            const string SPDelete = "tran_cuttinginfodetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_cuttinginfodetlEntity tran_cuttinginfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_cuttinginfodetl, cmd, Database, true);
                            FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_cuttinginfodetlEntity tran_cuttinginfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_cuttinginfodetl, cmd, Database);
                            FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_cuttinginfodetlEntity tran_cuttinginfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_cuttinginfodetl, cmd, Database);
                            FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.Save_tran_cuttinginfodetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<tran_cuttinginfodetlEntity> listAdded, IList<tran_cuttinginfodetlEntity> listUpdated, IList<tran_cuttinginfodetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "tran_cuttinginfodetl_Ins";
            const string SPUpdate = "tran_cuttinginfodetl_Upd";
            const string SPDelete = "tran_cuttinginfodetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_cuttinginfodetlEntity tran_cuttinginfodetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_cuttinginfodetl, cmd, db, true);
                            FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (tran_cuttinginfodetlEntity tran_cuttinginfodetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_cuttinginfodetl, cmd, db);
                            FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, db);
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
                    foreach (tran_cuttinginfodetlEntity tran_cuttinginfodetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_cuttinginfodetl, cmd, db);
                            FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.Save_tran_cuttinginfodetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlDataAccessObjects.GetAll(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
        {
           try
            {
				const string SP = "tran_cuttinginfodetl_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_cuttinginfodetl.SortExpression);
                    FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_cuttinginfodetl, cmd, Database);
                    
                    IList<tran_cuttinginfodetlEntity> itemList = new List<tran_cuttinginfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.GetAlltran_cuttinginfodetl"));
            }	
        }
		
		IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlDataAccessObjects.GetAllByPages(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
        {
        try
            {
				const string SP = "tran_cuttinginfodetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_cuttinginfodetl.SortExpression);
                    AddPageSizeParameter(cmd, tran_cuttinginfodetl.PageSize);
                    AddCurrentPageParameter(cmd, tran_cuttinginfodetl.CurrentPage);                    
                    FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_cuttinginfodetl, cmd,Database);

                    IList<tran_cuttinginfodetlEntity> itemList = new List<tran_cuttinginfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_cuttinginfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.GetAllByPagestran_cuttinginfodetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        tran_cuttinginfodetlEntity Itran_cuttinginfodetlDataAccessObjects.GetSingle(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
        {
           try
            {
				const string SP = "tran_cuttinginfodetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_cuttinginfodetl, cmd, Database);
                    
                    IList<tran_cuttinginfodetlEntity> itemList = new List<tran_cuttinginfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfodetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.GetSingletran_cuttinginfodetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlDataAccessObjects.GAPgListView(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
        {
        try
            {
				const string SP = "tran_cuttinginfodetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_cuttinginfodetl.SortExpression);
                    AddPageSizeParameter(cmd, tran_cuttinginfodetl.PageSize);
                    AddCurrentPageParameter(cmd, tran_cuttinginfodetl.CurrentPage);                    
                    FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_cuttinginfodetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_cuttinginfodetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_cuttinginfodetl.strCommonSerachParam);

                    IList<tran_cuttinginfodetlEntity> itemList = new List<tran_cuttinginfodetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfodetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_cuttinginfodetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.GAPgListViewtran_cuttinginfodetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_cuttinginfodetlDataAccessObjects.UpdateReviewed(tran_cuttinginfodetlEntity tran_cuttinginfodetl )
        {
           long returnCode = -99;
            const string SP = "tran_cuttinginfodetl_UpdRev";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_cuttinginfodetl, cmd,Database);
                FillSequrityParameters(tran_cuttinginfodetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_cuttinginfodetlDataAccess.UpdateReviewedtran_cuttinginfodetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }                        
        #endregion
	}
}