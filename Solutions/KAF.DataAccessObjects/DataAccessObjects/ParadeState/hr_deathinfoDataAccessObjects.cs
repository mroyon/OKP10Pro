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
	
	internal sealed partial class hr_deathinfoDataAccessObjects : BaseDataAccess, Ihr_deathinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_deathinfoDataAccessObjects";
        
		public hr_deathinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_deathinfoEntity hr_deathinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_deathinfo.deathinfoid.HasValue)
				Database.AddInParameter(cmd, "@DeathInfoID", DbType.Int64, hr_deathinfo.deathinfoid);
            if (forDelete) return;
			if (hr_deathinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HRBasicID", DbType.Int64, hr_deathinfo.hrbasicid);
			if ((hr_deathinfo.deathdate.HasValue))
				Database.AddInParameter(cmd, "@DeathDate", DbType.DateTime, hr_deathinfo.deathdate);
			if (!(string.IsNullOrEmpty(hr_deathinfo.deathreason)))
				Database.AddInParameter(cmd, "@DeathReason", DbType.String, hr_deathinfo.deathreason);
			if (!(string.IsNullOrEmpty(hr_deathinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_deathinfo.remarks);
			if ((hr_deathinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_deathinfo.ex_date1);
			if ((hr_deathinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_deathinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_deathinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_deathinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_deathinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_deathinfo.ex_nvarchar2);
			if (hr_deathinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_deathinfo.ex_bigint1);
			if (hr_deathinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_deathinfo.ex_bigint2);
			if (hr_deathinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_deathinfo.ex_decimal1);
			if (hr_deathinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_deathinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_deathinfoDataAccessObjects.Add(hr_deathinfoEntity hr_deathinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_deathinfo_Ins_Ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_deathinfo, cmd,Database);
                FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.Addhr_deathinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_deathinfoDataAccessObjects.Update(hr_deathinfoEntity hr_deathinfo )
        {
           long returnCode = -99;
            const string SP = "hr_deathinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_deathinfo, cmd,Database);
                FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.Updatehr_deathinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_deathinfoDataAccessObjects.Delete(hr_deathinfoEntity hr_deathinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_deathinfo_Del_Ext";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_deathinfo, cmd,Database, true);
                FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.Deletehr_deathinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_deathinfoDataAccessObjects.SaveList(IList<hr_deathinfoEntity> listAdded, IList<hr_deathinfoEntity> listUpdated, IList<hr_deathinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_deathinfo_Ins";
            const string SPUpdate = "hr_deathinfo_Upd";
            const string SPDelete = "hr_deathinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_deathinfoEntity hr_deathinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_deathinfo, cmd, Database, true);
                            FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_deathinfoEntity hr_deathinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_deathinfo, cmd, Database);
                            FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_deathinfoEntity hr_deathinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_deathinfo, cmd, Database);
                            FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.Save_hr_deathinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_deathinfoEntity> listAdded, IList<hr_deathinfoEntity> listUpdated, IList<hr_deathinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_deathinfo_Ins";
            const string SPUpdate = "hr_deathinfo_Upd";
            const string SPDelete = "hr_deathinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_deathinfoEntity hr_deathinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_deathinfo, cmd, db, true);
                            FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_deathinfoEntity hr_deathinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_deathinfo, cmd, db);
                            FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_deathinfoEntity hr_deathinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_deathinfo, cmd, db);
                            FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.Save_hr_deathinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_deathinfoEntity> Ihr_deathinfoDataAccessObjects.GetAll(hr_deathinfoEntity hr_deathinfo)
        {
           try
            {
				const string SP = "hr_deathinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_deathinfo.SortExpression);
                    FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_deathinfo, cmd, Database);
                    
                    IList<hr_deathinfoEntity> itemList = new List<hr_deathinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_deathinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.GetAllhr_deathinfo"));
            }	
        }
		
		IList<hr_deathinfoEntity> Ihr_deathinfoDataAccessObjects.GetAllByPages(hr_deathinfoEntity hr_deathinfo)
        {
        try
            {
				const string SP = "hr_deathinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_deathinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_deathinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_deathinfo.CurrentPage);                    
                    FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_deathinfo, cmd,Database);

                    IList<hr_deathinfoEntity> itemList = new List<hr_deathinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_deathinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_deathinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.GetAllByPageshr_deathinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_deathinfoEntity Ihr_deathinfoDataAccessObjects.GetSingle(hr_deathinfoEntity hr_deathinfo)
        {
           try
            {
				const string SP = "hr_deathinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_deathinfo, cmd, Database);
                    
                    IList<hr_deathinfoEntity> itemList = new List<hr_deathinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_deathinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.GetSinglehr_deathinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_deathinfoEntity> Ihr_deathinfoDataAccessObjects.GAPgListView(hr_deathinfoEntity hr_deathinfo)
        {
        try
            {
				const string SP = "hr_deathinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_deathinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_deathinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_deathinfo.CurrentPage);                    
                    FillSequrityParameters(hr_deathinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_deathinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_deathinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_deathinfo.strCommonSerachParam);

                    IList<hr_deathinfoEntity> itemList = new List<hr_deathinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_deathinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_deathinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_deathinfoDataAccess.GAPgListViewhr_deathinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}