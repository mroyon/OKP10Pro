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
	
	internal sealed partial class hr_demanddetlpassportDataAccessObjects : BaseDataAccess, Ihr_demanddetlpassportDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_demanddetlpassportDataAccessObjects";
        
		public hr_demanddetlpassportDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_demanddetlpassportEntity hr_demanddetlpassport, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_demanddetlpassport.newdemandpassportid.HasValue)
				Database.AddInParameter(cmd, "@NewDemandPassportID", DbType.Int64, hr_demanddetlpassport.newdemandpassportid);
            if (forDelete) return;
			//if (hr_demanddetlpassport.newdemanddetlid.HasValue)
			//	Database.AddInParameter(cmd, "@NewDemandDetlID", DbType.Int64, hr_demanddetlpassport.newdemanddetlid);
			if (hr_demanddetlpassport.serialno.HasValue)
				Database.AddInParameter(cmd, "@SerialNo", DbType.Int64, hr_demanddetlpassport.serialno);
			if (hr_demanddetlpassport.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_demanddetlpassport.hrbasicid);
			if (hr_demanddetlpassport.hrsvcid.HasValue)
				Database.AddInParameter(cmd, "@HrSvcID", DbType.Int64, hr_demanddetlpassport.hrsvcid);
			if (!(string.IsNullOrEmpty(hr_demanddetlpassport.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_demanddetlpassport.remarks);
			if ((hr_demanddetlpassport.passportrecvdate.HasValue))
				Database.AddInParameter(cmd, "@PassportRecvDate", DbType.DateTime, hr_demanddetlpassport.passportrecvdate);
			if (!(string.IsNullOrEmpty(hr_demanddetlpassport.letterno)))
				Database.AddInParameter(cmd, "@LetterNo", DbType.String, hr_demanddetlpassport.letterno);
			if ((hr_demanddetlpassport.letterdate.HasValue))
				Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_demanddetlpassport.letterdate);
			if ((hr_demanddetlpassport.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_demanddetlpassport.ex_date1);
			if ((hr_demanddetlpassport.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_demanddetlpassport.ex_date2);
			if (!(string.IsNullOrEmpty(hr_demanddetlpassport.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_demanddetlpassport.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_demanddetlpassport.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_demanddetlpassport.ex_nvarchar2);
			if (hr_demanddetlpassport.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_demanddetlpassport.ex_bigint1);
			if (hr_demanddetlpassport.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_demanddetlpassport.ex_bigint2);
			if (hr_demanddetlpassport.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_demanddetlpassport.ex_decimal1);
			if (hr_demanddetlpassport.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_demanddetlpassport.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_demanddetlpassportDataAccessObjects.Add(hr_demanddetlpassportEntity hr_demanddetlpassport  )
        {
            long returnCode = -99;
            const string SP = "hr_demanddetlpassport_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_demanddetlpassport, cmd,Database);
                FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Addhr_demanddetlpassport"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_demanddetlpassportDataAccessObjects.Update(hr_demanddetlpassportEntity hr_demanddetlpassport )
        {
           long returnCode = -99;
            const string SP = "hr_demanddetlpassport_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_demanddetlpassport, cmd,Database);
                FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Updatehr_demanddetlpassport"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_demanddetlpassportDataAccessObjects.Delete(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
            long returnCode = -99;
           	const string SP = "hr_demanddetlpassport_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_demanddetlpassport, cmd,Database, true);
                FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Deletehr_demanddetlpassport"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_demanddetlpassportDataAccessObjects.SaveList(IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_demanddetlpassport_Ins";
            const string SPUpdate = "hr_demanddetlpassport_Upd";
            const string SPDelete = "hr_demanddetlpassport_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, Database, true);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, Database);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, Database);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Save_hr_demanddetlpassport"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_demanddetlpassport_Ins";
            const string SPUpdate = "hr_demanddetlpassport_Upd";
            const string SPDelete = "hr_demanddetlpassport_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, db, true);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, db);
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
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, db);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, db);
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
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, db);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Save_hr_demanddetlpassport"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GetAll(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
           try
            {
				const string SP = "hr_demanddetlpassport_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_demanddetlpassport.SortExpression);
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_demanddetlpassport, cmd, Database);
                    
                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GetAllhr_demanddetlpassport"));
            }	
        }
		
		IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GetAllByPages(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
        try
            {
				const string SP = "hr_demanddetlpassport_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_demanddetlpassport.SortExpression);
                    AddPageSizeParameter(cmd, hr_demanddetlpassport.PageSize);
                    AddCurrentPageParameter(cmd, hr_demanddetlpassport.CurrentPage);                    
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_demanddetlpassport, cmd,Database);

                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_demanddetlpassport.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GetAllByPageshr_demanddetlpassport"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_demanddetlpassportEntity Ihr_demanddetlpassportDataAccessObjects.GetSingle(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
           try
            {
				const string SP = "hr_demanddetlpassport_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_demanddetlpassport, cmd, Database);
                    
                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GetSinglehr_demanddetlpassport"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GAPgListView(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
        try
            {
				const string SP = "hr_demanddetlpassport_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_demanddetlpassport.SortExpression);
                    AddPageSizeParameter(cmd, hr_demanddetlpassport.PageSize);
                    AddCurrentPageParameter(cmd, hr_demanddetlpassport.CurrentPage);                    
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_demanddetlpassport, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_demanddetlpassport.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_demanddetlpassport.strCommonSerachParam);

                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_demanddetlpassport.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GAPgListViewhr_demanddetlpassport"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}