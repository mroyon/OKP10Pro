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
	
	internal sealed partial class hr_medicalinfoDataAccessObjects : BaseDataAccess, Ihr_medicalinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_medicalinfoDataAccessObjects";
        
		public hr_medicalinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_medicalinfoEntity hr_medicalinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_medicalinfo.miltmedicalid.HasValue)
				Database.AddInParameter(cmd, "@MiltMedicalID", DbType.Int64, hr_medicalinfo.miltmedicalid);
            if (forDelete) return;
			if (hr_medicalinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_medicalinfo.hrbasicid);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissionno)))
				Database.AddInParameter(cmd, "@MedCommissionNo", DbType.String, hr_medicalinfo.medcommissionno);
			if ((hr_medicalinfo.medcommsisiondate.HasValue))
				Database.AddInParameter(cmd, "@MedCommsisionDate", DbType.DateTime, hr_medicalinfo.medcommsisiondate);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissionfiledescription)))
				Database.AddInParameter(cmd, "@MedCommissionFileDescription", DbType.String, hr_medicalinfo.medcommissionfiledescription);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissionfilepath)))
				Database.AddInParameter(cmd, "@MedCommissionFilePath", DbType.String, hr_medicalinfo.medcommissionfilepath);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissionfilename)))
				Database.AddInParameter(cmd, "@MedCommissionFileName", DbType.String, hr_medicalinfo.medcommissionfilename);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissionfiletype)))
				Database.AddInParameter(cmd, "@MedCommissionFileType", DbType.String, hr_medicalinfo.medcommissionfiletype);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissionextension)))
				Database.AddInParameter(cmd, "@MedCommissionExtension", DbType.String, hr_medicalinfo.medcommissionextension);
			
				Database.AddInParameter(cmd, "@MedCommissionFileNo", DbType.Guid, hr_medicalinfo.medcommissionfileno);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medcommissiondesc)))
				Database.AddInParameter(cmd, "@MedCommissionDesc", DbType.String, hr_medicalinfo.medcommissiondesc);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.docno)))
				Database.AddInParameter(cmd, "@DocNo", DbType.String, hr_medicalinfo.docno);
			if ((hr_medicalinfo.docdate.HasValue))
				Database.AddInParameter(cmd, "@DocDate", DbType.DateTime, hr_medicalinfo.docdate);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.docfiledescription)))
				Database.AddInParameter(cmd, "@DocFileDescription", DbType.String, hr_medicalinfo.docfiledescription);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.docfilepath)))
				Database.AddInParameter(cmd, "@DocFilePath", DbType.String, hr_medicalinfo.docfilepath);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.docfilename)))
				Database.AddInParameter(cmd, "@DocFileName", DbType.String, hr_medicalinfo.docfilename);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.docfiletype)))
				Database.AddInParameter(cmd, "@DocFileType", DbType.String, hr_medicalinfo.docfiletype);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.docextension)))
				Database.AddInParameter(cmd, "@DocExtension", DbType.String, hr_medicalinfo.docextension);
			
				Database.AddInParameter(cmd, "@DocFileNo", DbType.Guid, hr_medicalinfo.docfileno);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.medaction)))
				Database.AddInParameter(cmd, "@MedAction", DbType.String, hr_medicalinfo.medaction);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_medicalinfo.remarks);
			if ((hr_medicalinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_medicalinfo.ex_date1);
			if ((hr_medicalinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_medicalinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_medicalinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_medicalinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_medicalinfo.ex_nvarchar2);
			if (hr_medicalinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_medicalinfo.ex_bigint1);
			if (hr_medicalinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_medicalinfo.ex_bigint2);
			if (hr_medicalinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_medicalinfo.ex_decimal1);
			if (hr_medicalinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_medicalinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_medicalinfoDataAccessObjects.Add(hr_medicalinfoEntity hr_medicalinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_medicalinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_medicalinfo, cmd,Database);
                FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.Addhr_medicalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_medicalinfoDataAccessObjects.Update(hr_medicalinfoEntity hr_medicalinfo )
        {
           long returnCode = -99;
            const string SP = "hr_medicalinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_medicalinfo, cmd,Database);
                FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.Updatehr_medicalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_medicalinfoDataAccessObjects.Delete(hr_medicalinfoEntity hr_medicalinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_medicalinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_medicalinfo, cmd,Database, true);
                FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.Deletehr_medicalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_medicalinfoDataAccessObjects.SaveList(IList<hr_medicalinfoEntity> listAdded, IList<hr_medicalinfoEntity> listUpdated, IList<hr_medicalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_medicalinfo_Ins";
            const string SPUpdate = "hr_medicalinfo_Upd";
            const string SPDelete = "hr_medicalinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_medicalinfoEntity hr_medicalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_medicalinfo, cmd, Database, true);
                            FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_medicalinfoEntity hr_medicalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_medicalinfo, cmd, Database);
                            FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_medicalinfoEntity hr_medicalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_medicalinfo, cmd, Database);
                            FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.Save_hr_medicalinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_medicalinfoEntity> listAdded, IList<hr_medicalinfoEntity> listUpdated, IList<hr_medicalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_medicalinfo_Ins";
            const string SPUpdate = "hr_medicalinfo_Upd";
            const string SPDelete = "hr_medicalinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_medicalinfoEntity hr_medicalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_medicalinfo, cmd, db, true);
                            FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_medicalinfoEntity hr_medicalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_medicalinfo, cmd, db);
                            FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_medicalinfoEntity hr_medicalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_medicalinfo, cmd, db);
                            FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.Save_hr_medicalinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_medicalinfoEntity> Ihr_medicalinfoDataAccessObjects.GetAll(hr_medicalinfoEntity hr_medicalinfo)
        {
           try
            {
				const string SP = "hr_medicalinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_medicalinfo.SortExpression);
                    FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_medicalinfo, cmd, Database);
                    
                    IList<hr_medicalinfoEntity> itemList = new List<hr_medicalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_medicalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.GetAllhr_medicalinfo"));
            }	
        }
		
		IList<hr_medicalinfoEntity> Ihr_medicalinfoDataAccessObjects.GetAllByPages(hr_medicalinfoEntity hr_medicalinfo)
        {
        try
            {
				const string SP = "hr_medicalinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_medicalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_medicalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_medicalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_medicalinfo, cmd,Database);

                    IList<hr_medicalinfoEntity> itemList = new List<hr_medicalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_medicalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_medicalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.GetAllByPageshr_medicalinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_medicalinfoEntity Ihr_medicalinfoDataAccessObjects.GetSingle(hr_medicalinfoEntity hr_medicalinfo)
        {
           try
            {
				const string SP = "hr_medicalinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_medicalinfo, cmd, Database);
                    
                    IList<hr_medicalinfoEntity> itemList = new List<hr_medicalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_medicalinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.GetSinglehr_medicalinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_medicalinfoEntity> Ihr_medicalinfoDataAccessObjects.GAPgListView(hr_medicalinfoEntity hr_medicalinfo)
        {
        try
            {
				const string SP = "hr_medicalinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_medicalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_medicalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_medicalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_medicalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_medicalinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_medicalinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_medicalinfo.strCommonSerachParam);

                    IList<hr_medicalinfoEntity> itemList = new List<hr_medicalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_medicalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_medicalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_medicalinfoDataAccess.GAPgListViewhr_medicalinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}