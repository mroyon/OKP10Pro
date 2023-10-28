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
	
	internal sealed partial class hr_okptransferinfoDataAccessObjects : BaseDataAccess, Ihr_okptransferinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_okptransferinfoDataAccessObjects";
        
		public hr_okptransferinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_okptransferinfoEntity hr_okptransferinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_okptransferinfo.okptransferid.HasValue)
				Database.AddInParameter(cmd, "@OkpTransferID", DbType.Int64, hr_okptransferinfo.okptransferid);
            if (forDelete) return;
			if (hr_okptransferinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrbasicID", DbType.Int64, hr_okptransferinfo.hrbasicid);
			if (hr_okptransferinfo.fromkopid.HasValue)
				Database.AddInParameter(cmd, "@FromKopID", DbType.Int64, hr_okptransferinfo.fromkopid);
			if (hr_okptransferinfo.tookpid.HasValue)
				Database.AddInParameter(cmd, "@ToOkpID", DbType.Int64, hr_okptransferinfo.tookpid);
			if (hr_okptransferinfo.subunitid.HasValue)
				Database.AddInParameter(cmd, "@SubUnitID", DbType.Int64, hr_okptransferinfo.subunitid);
			if (hr_okptransferinfo.campid.HasValue)
				Database.AddInParameter(cmd, "@CampID", DbType.Int64, hr_okptransferinfo.campid);
			if ((hr_okptransferinfo.transferdate.HasValue))
				Database.AddInParameter(cmd, "@TransferDate", DbType.DateTime, hr_okptransferinfo.transferdate);
			if (!(string.IsNullOrEmpty(hr_okptransferinfo.reason)))
				Database.AddInParameter(cmd, "@Reason", DbType.String, hr_okptransferinfo.reason);
			if (!(string.IsNullOrEmpty(hr_okptransferinfo.letterno)))
				Database.AddInParameter(cmd, "@LetterNO", DbType.String, hr_okptransferinfo.letterno);
			if ((hr_okptransferinfo.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_okptransferinfo.letterdate);
			if (!(string.IsNullOrEmpty(hr_okptransferinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_okptransferinfo.remarks);
			if ((hr_okptransferinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_okptransferinfo.ex_date1);
			if ((hr_okptransferinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_okptransferinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_okptransferinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_okptransferinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_okptransferinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_okptransferinfo.ex_nvarchar2);
			if (hr_okptransferinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_okptransferinfo.ex_bigint1);
			if (hr_okptransferinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_okptransferinfo.ex_bigint2);
			if (hr_okptransferinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_okptransferinfo.ex_decimal1);
			if (hr_okptransferinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_okptransferinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_okptransferinfoDataAccessObjects.Add(hr_okptransferinfoEntity hr_okptransferinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_okptransferinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_okptransferinfo, cmd,Database);
                FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Addhr_okptransferinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_okptransferinfoDataAccessObjects.Update(hr_okptransferinfoEntity hr_okptransferinfo )
        {
           long returnCode = -99;
            const string SP = "hr_okptransferinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_okptransferinfo, cmd,Database);
                FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Updatehr_okptransferinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_okptransferinfoDataAccessObjects.Delete(hr_okptransferinfoEntity hr_okptransferinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_okptransferinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_okptransferinfo, cmd,Database, true);
                FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Deletehr_okptransferinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_okptransferinfoDataAccessObjects.SaveList(IList<hr_okptransferinfoEntity> listAdded, IList<hr_okptransferinfoEntity> listUpdated, IList<hr_okptransferinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_okptransferinfo_Ins";
            const string SPUpdate = "hr_okptransferinfo_Upd";
            const string SPDelete = "hr_okptransferinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_okptransferinfoEntity hr_okptransferinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_okptransferinfo, cmd, Database, true);
                            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_okptransferinfoEntity hr_okptransferinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_okptransferinfo, cmd, Database);
                            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_okptransferinfoEntity hr_okptransferinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_okptransferinfo, cmd, Database);
                            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Save_hr_okptransferinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_okptransferinfoEntity> listAdded, IList<hr_okptransferinfoEntity> listUpdated, IList<hr_okptransferinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_okptransferinfo_Ins";
            const string SPUpdate = "hr_okptransferinfo_Upd";
            const string SPDelete = "hr_okptransferinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_okptransferinfoEntity hr_okptransferinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_okptransferinfo, cmd, db, true);
                            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_okptransferinfoEntity hr_okptransferinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_okptransferinfo, cmd, db);
                            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_okptransferinfoEntity hr_okptransferinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_okptransferinfo, cmd, db);
                            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Save_hr_okptransferinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_okptransferinfoEntity> Ihr_okptransferinfoDataAccessObjects.GetAll(hr_okptransferinfoEntity hr_okptransferinfo)
        {
           try
            {
				const string SP = "hr_okptransferinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_okptransferinfo.SortExpression);
                    FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_okptransferinfo, cmd, Database);
                    
                    IList<hr_okptransferinfoEntity> itemList = new List<hr_okptransferinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_okptransferinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.GetAllhr_okptransferinfo"));
            }	
        }
		
		IList<hr_okptransferinfoEntity> Ihr_okptransferinfoDataAccessObjects.GetAllByPages(hr_okptransferinfoEntity hr_okptransferinfo)
        {
        try
            {
				const string SP = "hr_okptransferinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_okptransferinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_okptransferinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_okptransferinfo.CurrentPage);                    
                    FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_okptransferinfo, cmd,Database);

                    IList<hr_okptransferinfoEntity> itemList = new List<hr_okptransferinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_okptransferinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_okptransferinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.GetAllByPageshr_okptransferinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_okptransferinfoEntity Ihr_okptransferinfoDataAccessObjects.GetSingle(hr_okptransferinfoEntity hr_okptransferinfo)
        {
           try
            {
				const string SP = "hr_okptransferinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_okptransferinfo, cmd, Database);
                    
                    IList<hr_okptransferinfoEntity> itemList = new List<hr_okptransferinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_okptransferinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.GetSinglehr_okptransferinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_okptransferinfoEntity> Ihr_okptransferinfoDataAccessObjects.GAPgListView(hr_okptransferinfoEntity hr_okptransferinfo)
        {
        try
            {
				const string SP = "hr_okptransferinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_okptransferinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_okptransferinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_okptransferinfo.CurrentPage);                    
                    FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_okptransferinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_okptransferinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_okptransferinfo.strCommonSerachParam);

                    IList<hr_okptransferinfoEntity> itemList = new List<hr_okptransferinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_okptransferinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_okptransferinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.GAPgListViewhr_okptransferinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}