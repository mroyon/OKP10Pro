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
	
	internal sealed partial class hr_attachmentinfoDataAccessObjects : BaseDataAccess, Ihr_attachmentinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_attachmentinfoDataAccessObjects";
        
		public hr_attachmentinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_attachmentinfoEntity hr_attachmentinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_attachmentinfo.attachmentid.HasValue)
				Database.AddInParameter(cmd, "@AttachmentID", DbType.Int64, hr_attachmentinfo.attachmentid);
            if (forDelete) return;
			if (hr_attachmentinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_attachmentinfo.hrbasicid);
			if (hr_attachmentinfo.fromsubunitid.HasValue)
				Database.AddInParameter(cmd, "@FromSubUnitID", DbType.Int64, hr_attachmentinfo.fromsubunitid);
			if (hr_attachmentinfo.fromcampid.HasValue)
				Database.AddInParameter(cmd, "@FromCampID", DbType.Int64, hr_attachmentinfo.fromcampid);
			if (hr_attachmentinfo.subunitid.HasValue)
				Database.AddInParameter(cmd, "@SubUnitID", DbType.Int64, hr_attachmentinfo.subunitid);
			if (hr_attachmentinfo.campid.HasValue)
				Database.AddInParameter(cmd, "@CampID", DbType.Int64, hr_attachmentinfo.campid);
			if ((hr_attachmentinfo.fromdate.HasValue))
				Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, hr_attachmentinfo.fromdate);
			if ((hr_attachmentinfo.todate.HasValue))
				Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, hr_attachmentinfo.todate);
			if (!(string.IsNullOrEmpty(hr_attachmentinfo.reason)))
				Database.AddInParameter(cmd, "@Reason", DbType.String, hr_attachmentinfo.reason);
			if (!(string.IsNullOrEmpty(hr_attachmentinfo.letterno)))
				Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_attachmentinfo.letterno);
			if ((hr_attachmentinfo.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_attachmentinfo.letterdate);
			if ((hr_attachmentinfo.returndate.HasValue))
				Database.AddInParameter(cmd, "@ReturnDate", DbType.DateTime, hr_attachmentinfo.returndate);
			if (!(string.IsNullOrEmpty(hr_attachmentinfo.returnletterno)))
				Database.AddInParameter(cmd, "@ReturnLetterNo", DbType.String, hr_attachmentinfo.returnletterno);
			if ((hr_attachmentinfo.returnletterdate.HasValue))
				Database.AddInParameter(cmd, "@ReturnLetterDate", DbType.DateTime, hr_attachmentinfo.returnletterdate);
			if (hr_attachmentinfo.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, hr_attachmentinfo.countryid);
			if (!(string.IsNullOrEmpty(hr_attachmentinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_attachmentinfo.remarks);
			if ((hr_attachmentinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_attachmentinfo.ex_date1);
			if ((hr_attachmentinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_attachmentinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_attachmentinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_attachmentinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_attachmentinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_attachmentinfo.ex_nvarchar2);
			if (hr_attachmentinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_attachmentinfo.ex_bigint1);
			if (hr_attachmentinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_attachmentinfo.ex_bigint2);
			if (hr_attachmentinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_attachmentinfo.ex_decimal1);
			if (hr_attachmentinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_attachmentinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_attachmentinfoDataAccessObjects.Add(hr_attachmentinfoEntity hr_attachmentinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_attachmentinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_attachmentinfo, cmd,Database);
                FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.Addhr_attachmentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_attachmentinfoDataAccessObjects.Update(hr_attachmentinfoEntity hr_attachmentinfo )
        {
           long returnCode = -99;
            const string SP = "hr_attachmentinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_attachmentinfo, cmd,Database);
                FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.Updatehr_attachmentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_attachmentinfoDataAccessObjects.Delete(hr_attachmentinfoEntity hr_attachmentinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_attachmentinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_attachmentinfo, cmd,Database, true);
                FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.Deletehr_attachmentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_attachmentinfoDataAccessObjects.SaveList(IList<hr_attachmentinfoEntity> listAdded, IList<hr_attachmentinfoEntity> listUpdated, IList<hr_attachmentinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_attachmentinfo_Ins";
            const string SPUpdate = "hr_attachmentinfo_Upd";
            const string SPDelete = "hr_attachmentinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_attachmentinfoEntity hr_attachmentinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_attachmentinfo, cmd, Database, true);
                            FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_attachmentinfoEntity hr_attachmentinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_attachmentinfo, cmd, Database);
                            FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_attachmentinfoEntity hr_attachmentinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_attachmentinfo, cmd, Database);
                            FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.Save_hr_attachmentinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_attachmentinfoEntity> listAdded, IList<hr_attachmentinfoEntity> listUpdated, IList<hr_attachmentinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_attachmentinfo_Ins";
            const string SPUpdate = "hr_attachmentinfo_Upd";
            const string SPDelete = "hr_attachmentinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_attachmentinfoEntity hr_attachmentinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_attachmentinfo, cmd, db, true);
                            FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_attachmentinfoEntity hr_attachmentinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_attachmentinfo, cmd, db);
                            FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_attachmentinfoEntity hr_attachmentinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_attachmentinfo, cmd, db);
                            FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.Save_hr_attachmentinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_attachmentinfoEntity> Ihr_attachmentinfoDataAccessObjects.GetAll(hr_attachmentinfoEntity hr_attachmentinfo)
        {
           try
            {
				const string SP = "hr_attachmentinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_attachmentinfo.SortExpression);
                    FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_attachmentinfo, cmd, Database);
                    
                    IList<hr_attachmentinfoEntity> itemList = new List<hr_attachmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_attachmentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.GetAllhr_attachmentinfo"));
            }	
        }
		
		IList<hr_attachmentinfoEntity> Ihr_attachmentinfoDataAccessObjects.GetAllByPages(hr_attachmentinfoEntity hr_attachmentinfo)
        {
        try
            {
				const string SP = "hr_attachmentinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_attachmentinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_attachmentinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_attachmentinfo.CurrentPage);                    
                    FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_attachmentinfo, cmd,Database);

                    IList<hr_attachmentinfoEntity> itemList = new List<hr_attachmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_attachmentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_attachmentinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.GetAllByPageshr_attachmentinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_attachmentinfoEntity Ihr_attachmentinfoDataAccessObjects.GetSingle(hr_attachmentinfoEntity hr_attachmentinfo)
        {
           try
            {
				const string SP = "hr_attachmentinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_attachmentinfo, cmd, Database);
                    
                    IList<hr_attachmentinfoEntity> itemList = new List<hr_attachmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_attachmentinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.GetSinglehr_attachmentinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_attachmentinfoEntity> Ihr_attachmentinfoDataAccessObjects.GAPgListView(hr_attachmentinfoEntity hr_attachmentinfo)
        {
        try
            {
				const string SP = "hr_attachmentinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_attachmentinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_attachmentinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_attachmentinfo.CurrentPage);                    
                    FillSequrityParameters(hr_attachmentinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_attachmentinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_attachmentinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_attachmentinfo.strCommonSerachParam);

                    IList<hr_attachmentinfoEntity> itemList = new List<hr_attachmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_attachmentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_attachmentinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_attachmentinfoDataAccess.GAPgListViewhr_attachmentinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}