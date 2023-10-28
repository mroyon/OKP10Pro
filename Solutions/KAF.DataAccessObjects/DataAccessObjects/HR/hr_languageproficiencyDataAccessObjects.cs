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
	
	internal sealed partial class hr_languageproficiencyDataAccessObjects : BaseDataAccess, Ihr_languageproficiencyDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_languageproficiencyDataAccessObjects";
        
		public hr_languageproficiencyDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_languageproficiencyEntity hr_languageproficiency, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_languageproficiency.languageproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@LanguageProficiencyID", DbType.Int64, hr_languageproficiency.languageproficiencyid);
            if (forDelete) return;
			if (hr_languageproficiency.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_languageproficiency.hrbasicid);
			if (hr_languageproficiency.languageid.HasValue)
				Database.AddInParameter(cmd, "@LanguageID", DbType.Int64, hr_languageproficiency.languageid);
			if (hr_languageproficiency.readingproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@ReadingProficiencyID", DbType.Int64, hr_languageproficiency.readingproficiencyid);
			if (hr_languageproficiency.writingproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@WritingProficiencyID", DbType.Int64, hr_languageproficiency.writingproficiencyid);
			if (hr_languageproficiency.speakingproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@SpeakingProficiencyID", DbType.Int64, hr_languageproficiency.speakingproficiencyid);
			if (!(string.IsNullOrEmpty(hr_languageproficiency.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_languageproficiency.remarks);
			if ((hr_languageproficiency.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_languageproficiency.ex_date1);
			if ((hr_languageproficiency.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_languageproficiency.ex_date2);
			if (!(string.IsNullOrEmpty(hr_languageproficiency.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_languageproficiency.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_languageproficiency.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_languageproficiency.ex_nvarchar2);
			if (hr_languageproficiency.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_languageproficiency.ex_bigint1);
			if (hr_languageproficiency.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_languageproficiency.ex_bigint2);
			if (hr_languageproficiency.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_languageproficiency.ex_decimal1);
			if (hr_languageproficiency.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_languageproficiency.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_languageproficiencyDataAccessObjects.Add(hr_languageproficiencyEntity hr_languageproficiency  )
        {
            long returnCode = -99;
            const string SP = "hr_languageproficiency_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_languageproficiency, cmd,Database);
                FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.Addhr_languageproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_languageproficiencyDataAccessObjects.Update(hr_languageproficiencyEntity hr_languageproficiency )
        {
           long returnCode = -99;
            const string SP = "hr_languageproficiency_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_languageproficiency, cmd,Database);
                FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.Updatehr_languageproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_languageproficiencyDataAccessObjects.Delete(hr_languageproficiencyEntity hr_languageproficiency)
        {
            long returnCode = -99;
           	const string SP = "hr_languageproficiency_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_languageproficiency, cmd,Database, true);
                FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.Deletehr_languageproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_languageproficiencyDataAccessObjects.SaveList(IList<hr_languageproficiencyEntity> listAdded, IList<hr_languageproficiencyEntity> listUpdated, IList<hr_languageproficiencyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_languageproficiency_Ins";
            const string SPUpdate = "hr_languageproficiency_Upd";
            const string SPDelete = "hr_languageproficiency_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_languageproficiencyEntity hr_languageproficiency in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_languageproficiency, cmd, Database, true);
                            FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_languageproficiencyEntity hr_languageproficiency in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_languageproficiency, cmd, Database);
                            FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_languageproficiencyEntity hr_languageproficiency in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_languageproficiency, cmd, Database);
                            FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.Save_hr_languageproficiency"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_languageproficiencyEntity> listAdded, IList<hr_languageproficiencyEntity> listUpdated, IList<hr_languageproficiencyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_languageproficiency_Ins";
            const string SPUpdate = "hr_languageproficiency_Upd";
            const string SPDelete = "hr_languageproficiency_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_languageproficiencyEntity hr_languageproficiency in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_languageproficiency, cmd, db, true);
                            FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, db);
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
                    foreach (hr_languageproficiencyEntity hr_languageproficiency in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_languageproficiency, cmd, db);
                            FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, db);
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
                    foreach (hr_languageproficiencyEntity hr_languageproficiency in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_languageproficiency, cmd, db);
                            FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.Save_hr_languageproficiency"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_languageproficiencyEntity> Ihr_languageproficiencyDataAccessObjects.GetAll(hr_languageproficiencyEntity hr_languageproficiency)
        {
           try
            {
				const string SP = "hr_languageproficiency_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_languageproficiency.SortExpression);
                    FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_languageproficiency, cmd, Database);
                    
                    IList<hr_languageproficiencyEntity> itemList = new List<hr_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_languageproficiencyEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.GetAllhr_languageproficiency"));
            }	
        }
		
		IList<hr_languageproficiencyEntity> Ihr_languageproficiencyDataAccessObjects.GetAllByPages(hr_languageproficiencyEntity hr_languageproficiency)
        {
        try
            {
				const string SP = "hr_languageproficiency_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_languageproficiency.SortExpression);
                    AddPageSizeParameter(cmd, hr_languageproficiency.PageSize);
                    AddCurrentPageParameter(cmd, hr_languageproficiency.CurrentPage);                    
                    FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_languageproficiency, cmd,Database);

                    IList<hr_languageproficiencyEntity> itemList = new List<hr_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_languageproficiencyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_languageproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.GetAllByPageshr_languageproficiency"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_languageproficiencyEntity Ihr_languageproficiencyDataAccessObjects.GetSingle(hr_languageproficiencyEntity hr_languageproficiency)
        {
           try
            {
				const string SP = "hr_languageproficiency_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_languageproficiency, cmd, Database);
                    
                    IList<hr_languageproficiencyEntity> itemList = new List<hr_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_languageproficiencyEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.GetSinglehr_languageproficiency"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_languageproficiencyEntity> Ihr_languageproficiencyDataAccessObjects.GAPgListView(hr_languageproficiencyEntity hr_languageproficiency)
        {
        try
            {
				const string SP = "hr_languageproficiency_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_languageproficiency.SortExpression);
                    AddPageSizeParameter(cmd, hr_languageproficiency.PageSize);
                    AddCurrentPageParameter(cmd, hr_languageproficiency.CurrentPage);                    
                    FillSequrityParameters(hr_languageproficiency.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_languageproficiency, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_languageproficiency.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_languageproficiency.strCommonSerachParam);

                    IList<hr_languageproficiencyEntity> itemList = new List<hr_languageproficiencyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_languageproficiencyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_languageproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_languageproficiencyDataAccess.GAPgListViewhr_languageproficiency"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}