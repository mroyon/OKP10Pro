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
	
	internal sealed partial class useraccountsprofDataAccessObjects : BaseDataAccess, IuseraccountsprofDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "useraccountsprofDataAccessObjects";
        
		public useraccountsprofDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(useraccountsprofEntity useraccountsprof, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (useraccountsprof.userkey.HasValue)
				Database.AddInParameter(cmd, "@UserKey", DbType.Int64, useraccountsprof.userkey);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(useraccountsprof.firstname)))
				Database.AddInParameter(cmd, "@FirstName", DbType.String, useraccountsprof.firstname);
			if (!(string.IsNullOrEmpty(useraccountsprof.middlename)))
				Database.AddInParameter(cmd, "@MiddleName", DbType.String, useraccountsprof.middlename);
			if (!(string.IsNullOrEmpty(useraccountsprof.lastname)))
				Database.AddInParameter(cmd, "@LastName", DbType.String, useraccountsprof.lastname);
			if (!(string.IsNullOrEmpty(useraccountsprof.photo)))
				Database.AddInParameter(cmd, "@Photo", DbType.String, useraccountsprof.photo);
			if (useraccountsprof.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, useraccountsprof.organizationkey);
			if (useraccountsprof.entitykey.HasValue)
				Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, useraccountsprof.entitykey);
			if ((useraccountsprof.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, useraccountsprof.ex_date1);
			if ((useraccountsprof.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, useraccountsprof.ex_date2);
			if (!(string.IsNullOrEmpty(useraccountsprof.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, useraccountsprof.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(useraccountsprof.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, useraccountsprof.ex_nvarchar2);
			if (useraccountsprof.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, useraccountsprof.ex_bigint1);
			if (useraccountsprof.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, useraccountsprof.ex_bigint2);
			if (useraccountsprof.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, useraccountsprof.ex_decimal1);
			if (useraccountsprof.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, useraccountsprof.ex_decimal2);

        }
		
        
		#region Add Operation

        long IuseraccountsprofDataAccessObjects.Add(useraccountsprofEntity useraccountsprof  )
        {
            long returnCode = -99;
            const string SP = "useraccountsprof_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(useraccountsprof, cmd,Database);
                FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.Adduseraccountsprof"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long IuseraccountsprofDataAccessObjects.Update(useraccountsprofEntity useraccountsprof )
        {
           long returnCode = -99;
            const string SP = "useraccountsprof_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(useraccountsprof, cmd,Database);
                FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.Updateuseraccountsprof"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long IuseraccountsprofDataAccessObjects.Delete(useraccountsprofEntity useraccountsprof)
        {
            long returnCode = -99;
           	const string SP = "useraccountsprof_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(useraccountsprof, cmd,Database, true);
                FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.Deleteuseraccountsprof"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long IuseraccountsprofDataAccessObjects.SaveList(IList<useraccountsprofEntity> listAdded, IList<useraccountsprofEntity> listUpdated, IList<useraccountsprofEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "useraccountsprof_Ins";
            const string SPUpdate = "useraccountsprof_Upd";
            const string SPDelete = "useraccountsprof_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (useraccountsprofEntity useraccountsprof in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(useraccountsprof, cmd, Database, true);
                            FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
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
                    foreach (useraccountsprofEntity useraccountsprof in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(useraccountsprof, cmd, Database);
                            FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
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
                    foreach (useraccountsprofEntity useraccountsprof in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(useraccountsprof, cmd, Database);
                            FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.Save_useraccountsprof"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<useraccountsprofEntity> listAdded, IList<useraccountsprofEntity> listUpdated, IList<useraccountsprofEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "useraccountsprof_Ins";
            const string SPUpdate = "useraccountsprof_Upd";
            const string SPDelete = "useraccountsprof_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (useraccountsprofEntity useraccountsprof in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(useraccountsprof, cmd, db, true);
                            FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, db);
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
                    foreach (useraccountsprofEntity useraccountsprof in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(useraccountsprof, cmd, db);
                            FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, db);
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
                    foreach (useraccountsprofEntity useraccountsprof in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(useraccountsprof, cmd, db);
                            FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.Save_useraccountsprof"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<useraccountsprofEntity> IuseraccountsprofDataAccessObjects.GetAll(useraccountsprofEntity useraccountsprof)
        {
           try
            {
				const string SP = "useraccountsprof_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, useraccountsprof.SortExpression);
                    FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
                    FillParameters(useraccountsprof, cmd, Database);
                    
                    IList<useraccountsprofEntity> itemList = new List<useraccountsprofEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new useraccountsprofEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.GetAlluseraccountsprof"));
            }	
        }
		
		IList<useraccountsprofEntity> IuseraccountsprofDataAccessObjects.GetAllByPages(useraccountsprofEntity useraccountsprof)
        {
        try
            {
				const string SP = "useraccountsprof_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, useraccountsprof.SortExpression);
                    AddPageSizeParameter(cmd, useraccountsprof.PageSize);
                    AddCurrentPageParameter(cmd, useraccountsprof.CurrentPage);                    
                    FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
                    
					FillParameters(useraccountsprof, cmd,Database);

                    IList<useraccountsprofEntity> itemList = new List<useraccountsprofEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new useraccountsprofEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						useraccountsprof.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.GetAllByPagesuseraccountsprof"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        useraccountsprofEntity IuseraccountsprofDataAccessObjects.GetSingle(useraccountsprofEntity useraccountsprof)
        {
           try
            {
				const string SP = "useraccountsprof_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
                    FillParameters(useraccountsprof, cmd, Database);
                    
                    IList<useraccountsprofEntity> itemList = new List<useraccountsprofEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new useraccountsprofEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.GetSingleuseraccountsprof"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<useraccountsprofEntity> IuseraccountsprofDataAccessObjects.GAPgListView(useraccountsprofEntity useraccountsprof)
        {
        try
            {
				const string SP = "useraccountsprof_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, useraccountsprof.SortExpression);
                    AddPageSizeParameter(cmd, useraccountsprof.PageSize);
                    AddCurrentPageParameter(cmd, useraccountsprof.CurrentPage);                    
                    FillSequrityParameters(useraccountsprof.BaseSecurityParam, cmd, Database);
                    
					FillParameters(useraccountsprof, cmd,Database);
                    
					if (!string.IsNullOrEmpty (useraccountsprof.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, useraccountsprof.strCommonSerachParam);

                    IList<useraccountsprofEntity> itemList = new List<useraccountsprofEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new useraccountsprofEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						useraccountsprof.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IuseraccountsprofDataAccess.GAPgListViewuseraccountsprof"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}