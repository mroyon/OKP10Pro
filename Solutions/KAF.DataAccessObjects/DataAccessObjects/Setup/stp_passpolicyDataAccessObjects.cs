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
	
	internal sealed partial class stp_passpolicyDataAccessObjects : BaseDataAccess, Istp_passpolicyDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_passpolicyDataAccessObjects";
        
		public stp_passpolicyDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_passpolicyEntity stp_passpolicy, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_passpolicy.serialnopolicykey.HasValue)
				Database.AddInParameter(cmd, "@SerialNoPolicyKey", DbType.Int64, stp_passpolicy.serialnopolicykey);
            if (forDelete) return;
			if (stp_passpolicy.categoryid.HasValue)
				Database.AddInParameter(cmd, "@CategoryID", DbType.Int64, stp_passpolicy.categoryid);
			if (stp_passpolicy.passexpiredays.HasValue)
				Database.AddInParameter(cmd, "@PassExpireDays", DbType.Int32, stp_passpolicy.passexpiredays);
			if ((stp_passpolicy.passexpiredaysis != null))
				Database.AddInParameter(cmd, "@PassExpireDaysIs", DbType.Boolean, stp_passpolicy.passexpiredaysis);
			if (stp_passpolicy.passmaxlength.HasValue)
				Database.AddInParameter(cmd, "@PassMaxLength", DbType.Int32, stp_passpolicy.passmaxlength);
			if (stp_passpolicy.passminlength.HasValue)
				Database.AddInParameter(cmd, "@PassMinLength", DbType.Int32, stp_passpolicy.passminlength);
			if ((stp_passpolicy.passmcontainchar != null))
				Database.AddInParameter(cmd, "@PassMContainChar", DbType.Boolean, stp_passpolicy.passmcontainchar);
			if ((stp_passpolicy.passmcontainuchar != null))
				Database.AddInParameter(cmd, "@PassMContainUChar", DbType.Boolean, stp_passpolicy.passmcontainuchar);
			if ((stp_passpolicy.passmcontainnum != null))
				Database.AddInParameter(cmd, "@PassMContainNum", DbType.Boolean, stp_passpolicy.passmcontainnum);
			if ((stp_passpolicy.passmcontainspchar != null))
				Database.AddInParameter(cmd, "@PassMContainSPChar", DbType.Boolean, stp_passpolicy.passmcontainspchar);
			if ((stp_passpolicy.oldpasscom != null))
				Database.AddInParameter(cmd, "@OldPassCom", DbType.Boolean, stp_passpolicy.oldpasscom);
			if (stp_passpolicy.newpasscomoldpass.HasValue)
				Database.AddInParameter(cmd, "@NewPassComOldPass", DbType.Int32, stp_passpolicy.newpasscomoldpass);
			if (!(string.IsNullOrEmpty(stp_passpolicy.regpasscontainchar)))
				Database.AddInParameter(cmd, "@RegPassContainChar", DbType.String, stp_passpolicy.regpasscontainchar);
			if (!(string.IsNullOrEmpty(stp_passpolicy.regpasscontainuchar)))
				Database.AddInParameter(cmd, "@RegPassContainUChar", DbType.String, stp_passpolicy.regpasscontainuchar);
			if (!(string.IsNullOrEmpty(stp_passpolicy.regpasscontainnum)))
				Database.AddInParameter(cmd, "@RegPassContainNum", DbType.String, stp_passpolicy.regpasscontainnum);
			if (!(string.IsNullOrEmpty(stp_passpolicy.regpasscontainspchar)))
				Database.AddInParameter(cmd, "@RegPassContainSPChar", DbType.String, stp_passpolicy.regpasscontainspchar);
			if (stp_passpolicy.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_passpolicy.organizationkey);
			if ((stp_passpolicy.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, stp_passpolicy.ex_date1);
			if ((stp_passpolicy.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, stp_passpolicy.ex_date2);
			if (!(string.IsNullOrEmpty(stp_passpolicy.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, stp_passpolicy.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(stp_passpolicy.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, stp_passpolicy.ex_nvarchar2);
			if (stp_passpolicy.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, stp_passpolicy.ex_bigint1);
			if (stp_passpolicy.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, stp_passpolicy.ex_bigint2);
			if (stp_passpolicy.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, stp_passpolicy.ex_decimal1);
			if (stp_passpolicy.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_passpolicy.ex_decimal2);

        }
		
        
		#region Add Operation

        long Istp_passpolicyDataAccessObjects.Add(stp_passpolicyEntity stp_passpolicy  )
        {
            long returnCode = -99;
            const string SP = "stp_passpolicy_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_passpolicy, cmd,Database);
                FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.Addstp_passpolicy"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Istp_passpolicyDataAccessObjects.Update(stp_passpolicyEntity stp_passpolicy )
        {
           long returnCode = -99;
            const string SP = "stp_passpolicy_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_passpolicy, cmd,Database);
                FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.Updatestp_passpolicy"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Istp_passpolicyDataAccessObjects.Delete(stp_passpolicyEntity stp_passpolicy)
        {
            long returnCode = -99;
           	const string SP = "stp_passpolicy_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_passpolicy, cmd,Database, true);
                FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.Deletestp_passpolicy"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Istp_passpolicyDataAccessObjects.SaveList(IList<stp_passpolicyEntity> listAdded, IList<stp_passpolicyEntity> listUpdated, IList<stp_passpolicyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_passpolicy_Ins";
            const string SPUpdate = "stp_passpolicy_Upd";
            const string SPDelete = "stp_passpolicy_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_passpolicyEntity stp_passpolicy in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_passpolicy, cmd, Database, true);
                            FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_passpolicyEntity stp_passpolicy in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_passpolicy, cmd, Database);
                            FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_passpolicyEntity stp_passpolicy in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_passpolicy, cmd, Database);
                            FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.Save_stp_passpolicy"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<stp_passpolicyEntity> listAdded, IList<stp_passpolicyEntity> listUpdated, IList<stp_passpolicyEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "stp_passpolicy_Ins";
            const string SPUpdate = "stp_passpolicy_Upd";
            const string SPDelete = "stp_passpolicy_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_passpolicyEntity stp_passpolicy in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_passpolicy, cmd, db, true);
                            FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, db);
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
                    foreach (stp_passpolicyEntity stp_passpolicy in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_passpolicy, cmd, db);
                            FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, db);
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
                    foreach (stp_passpolicyEntity stp_passpolicy in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_passpolicy, cmd, db);
                            FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.Save_stp_passpolicy"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<stp_passpolicyEntity> Istp_passpolicyDataAccessObjects.GetAll(stp_passpolicyEntity stp_passpolicy)
        {
           try
            {
				const string SP = "stp_passpolicy_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_passpolicy.SortExpression);
                    FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_passpolicy, cmd, Database);
                    
                    IList<stp_passpolicyEntity> itemList = new List<stp_passpolicyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_passpolicyEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.GetAllstp_passpolicy"));
            }	
        }
		
		IList<stp_passpolicyEntity> Istp_passpolicyDataAccessObjects.GetAllByPages(stp_passpolicyEntity stp_passpolicy)
        {
        try
            {
				const string SP = "stp_passpolicy_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_passpolicy.SortExpression);
                    AddPageSizeParameter(cmd, stp_passpolicy.PageSize);
                    AddCurrentPageParameter(cmd, stp_passpolicy.CurrentPage);                    
                    FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_passpolicy, cmd,Database);

                    IList<stp_passpolicyEntity> itemList = new List<stp_passpolicyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_passpolicyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_passpolicy.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.GetAllByPagesstp_passpolicy"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        stp_passpolicyEntity Istp_passpolicyDataAccessObjects.GetSingle(stp_passpolicyEntity stp_passpolicy)
        {
           try
            {
				const string SP = "stp_passpolicy_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_passpolicy, cmd, Database);
                    
                    IList<stp_passpolicyEntity> itemList = new List<stp_passpolicyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_passpolicyEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.GetSinglestp_passpolicy"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<stp_passpolicyEntity> Istp_passpolicyDataAccessObjects.GAPgListView(stp_passpolicyEntity stp_passpolicy)
        {
        try
            {
				const string SP = "stp_passpolicy_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_passpolicy.SortExpression);
                    AddPageSizeParameter(cmd, stp_passpolicy.PageSize);
                    AddCurrentPageParameter(cmd, stp_passpolicy.CurrentPage);                    
                    FillSequrityParameters(stp_passpolicy.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_passpolicy, cmd,Database);
                    
					if (!string.IsNullOrEmpty (stp_passpolicy.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, stp_passpolicy.strCommonSerachParam);

                    IList<stp_passpolicyEntity> itemList = new List<stp_passpolicyEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_passpolicyEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_passpolicy.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_passpolicyDataAccess.GAPgListViewstp_passpolicy"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}