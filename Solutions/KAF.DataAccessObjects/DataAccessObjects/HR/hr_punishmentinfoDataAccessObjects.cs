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
	
	internal sealed partial class hr_punishmentinfoDataAccessObjects : BaseDataAccess, Ihr_punishmentinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_punishmentinfoDataAccessObjects";
        
		public hr_punishmentinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_punishmentinfoEntity hr_punishmentinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_punishmentinfo.punishmentid.HasValue)
				Database.AddInParameter(cmd, "@PunishmentID", DbType.Int64, hr_punishmentinfo.punishmentid);
            if (forDelete) return;
			if (hr_punishmentinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicId", DbType.Int64, hr_punishmentinfo.hrbasicid);
			if (hr_punishmentinfo.punishmenttype.HasValue)
				Database.AddInParameter(cmd, "@PunishmentType", DbType.Int64, hr_punishmentinfo.punishmenttype);
			if ((hr_punishmentinfo.punishmentdate.HasValue))
				Database.AddInParameter(cmd, "@PunishmentDate", DbType.DateTime, hr_punishmentinfo.punishmentdate);
			if (!(string.IsNullOrEmpty(hr_punishmentinfo.offence)))
				Database.AddInParameter(cmd, "@Offence", DbType.String, hr_punishmentinfo.offence);
			if (!(string.IsNullOrEmpty(hr_punishmentinfo.punishment)))
				Database.AddInParameter(cmd, "@Punishment", DbType.String, hr_punishmentinfo.punishment);
			if (!(string.IsNullOrEmpty(hr_punishmentinfo.punishmentdetails)))
				Database.AddInParameter(cmd, "@PunishmentDetails", DbType.String, hr_punishmentinfo.punishmentdetails);
			if (!(string.IsNullOrEmpty(hr_punishmentinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_punishmentinfo.remarks);
			if ((hr_punishmentinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_punishmentinfo.ex_date1);
			if ((hr_punishmentinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_punishmentinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_punishmentinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_punishmentinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_punishmentinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_punishmentinfo.ex_nvarchar2);
			if (hr_punishmentinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_punishmentinfo.ex_bigint1);
			if (hr_punishmentinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_punishmentinfo.ex_bigint2);
			if (hr_punishmentinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_punishmentinfo.ex_decimal1);
			if (hr_punishmentinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_punishmentinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_punishmentinfoDataAccessObjects.Add(hr_punishmentinfoEntity hr_punishmentinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_punishmentinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_punishmentinfo, cmd,Database);
                FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.Addhr_punishmentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_punishmentinfoDataAccessObjects.Update(hr_punishmentinfoEntity hr_punishmentinfo )
        {
           long returnCode = -99;
            const string SP = "hr_punishmentinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_punishmentinfo, cmd,Database);
                FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.Updatehr_punishmentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_punishmentinfoDataAccessObjects.Delete(hr_punishmentinfoEntity hr_punishmentinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_punishmentinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_punishmentinfo, cmd,Database, true);
                FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.Deletehr_punishmentinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_punishmentinfoDataAccessObjects.SaveList(IList<hr_punishmentinfoEntity> listAdded, IList<hr_punishmentinfoEntity> listUpdated, IList<hr_punishmentinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_punishmentinfo_Ins";
            const string SPUpdate = "hr_punishmentinfo_Upd";
            const string SPDelete = "hr_punishmentinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_punishmentinfoEntity hr_punishmentinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_punishmentinfo, cmd, Database, true);
                            FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_punishmentinfoEntity hr_punishmentinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_punishmentinfo, cmd, Database);
                            FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_punishmentinfoEntity hr_punishmentinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_punishmentinfo, cmd, Database);
                            FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.Save_hr_punishmentinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_punishmentinfoEntity> listAdded, IList<hr_punishmentinfoEntity> listUpdated, IList<hr_punishmentinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_punishmentinfo_Ins";
            const string SPUpdate = "hr_punishmentinfo_Upd";
            const string SPDelete = "hr_punishmentinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_punishmentinfoEntity hr_punishmentinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_punishmentinfo, cmd, db, true);
                            FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_punishmentinfoEntity hr_punishmentinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_punishmentinfo, cmd, db);
                            FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_punishmentinfoEntity hr_punishmentinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_punishmentinfo, cmd, db);
                            FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.Save_hr_punishmentinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_punishmentinfoEntity> Ihr_punishmentinfoDataAccessObjects.GetAll(hr_punishmentinfoEntity hr_punishmentinfo)
        {
           try
            {
				const string SP = "hr_punishmentinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_punishmentinfo.SortExpression);
                    FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_punishmentinfo, cmd, Database);
                    
                    IList<hr_punishmentinfoEntity> itemList = new List<hr_punishmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_punishmentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.GetAllhr_punishmentinfo"));
            }	
        }
		
		IList<hr_punishmentinfoEntity> Ihr_punishmentinfoDataAccessObjects.GetAllByPages(hr_punishmentinfoEntity hr_punishmentinfo)
        {
        try
            {
				const string SP = "hr_punishmentinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_punishmentinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_punishmentinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_punishmentinfo.CurrentPage);                    
                    FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_punishmentinfo, cmd,Database);

                    IList<hr_punishmentinfoEntity> itemList = new List<hr_punishmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_punishmentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_punishmentinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.GetAllByPageshr_punishmentinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_punishmentinfoEntity Ihr_punishmentinfoDataAccessObjects.GetSingle(hr_punishmentinfoEntity hr_punishmentinfo)
        {
           try
            {
				const string SP = "hr_punishmentinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_punishmentinfo, cmd, Database);
                    
                    IList<hr_punishmentinfoEntity> itemList = new List<hr_punishmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_punishmentinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.GetSinglehr_punishmentinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_punishmentinfoEntity> Ihr_punishmentinfoDataAccessObjects.GAPgListView(hr_punishmentinfoEntity hr_punishmentinfo)
        {
        try
            {
				const string SP = "hr_punishmentinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_punishmentinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_punishmentinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_punishmentinfo.CurrentPage);                    
                    FillSequrityParameters(hr_punishmentinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_punishmentinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_punishmentinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_punishmentinfo.strCommonSerachParam);

                    IList<hr_punishmentinfoEntity> itemList = new List<hr_punishmentinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_punishmentinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_punishmentinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_punishmentinfoDataAccess.GAPgListViewhr_punishmentinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}