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
	
	internal sealed partial class hr_newdemanddetlDataAccessObjects
	{
        public static void FillParameters_Ext(hr_newdemanddetlEntity hr_newdemanddetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			//if (hr_newdemanddetl.newdemanddetlid.HasValue)
			//	Database.AddInParameter(cmd, "@NewDemandDetlID", DbType.Int64, hr_newdemanddetl.newdemanddetlid);

        }
		
        
		#region Add Operation

        long Ihr_newdemanddetlDataAccessObjects.Add_Ext(hr_newdemanddetlEntity hr_newdemanddetl  )
        {
            long returnCode = -99;
            const string SP = "hr_newdemanddetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_newdemanddetl, cmd,Database);
                FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Addhr_newdemanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_newdemanddetlDataAccessObjects.Update_Ext(hr_newdemanddetlEntity hr_newdemanddetl )
        {
           long returnCode = -99;
            const string SP = "hr_newdemanddetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_newdemanddetl, cmd,Database);
                FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Updatehr_newdemanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_newdemanddetlDataAccessObjects.Delete_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
        {
            long returnCode = -99;
           	const string SP = "hr_newdemanddetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_newdemanddetl, cmd,Database, true);
                FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Deletehr_newdemanddetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_newdemanddetlDataAccessObjects.SaveList_Ext(IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemanddetl_Ins";
            const string SPUpdate = "hr_newdemanddetl_Upd";
            const string SPDelete = "hr_newdemanddetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemanddetl, cmd, Database, true);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemanddetl, cmd, Database);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemanddetl, cmd, Database);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Save_hr_newdemanddetl"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList_Ext(Database db , DbTransaction transaction,IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemanddetl_Ins";
            const string SPUpdate = "hr_newdemanddetl_Upd";
            const string SPDelete = "hr_newdemanddetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemanddetl, cmd, db, true);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemanddetl, cmd, db);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, db);
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
                    foreach (hr_newdemanddetlEntity hr_newdemanddetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemanddetl, cmd, db);
                            FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.Save_hr_newdemanddetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_newdemanddetlEntity> Ihr_newdemanddetlDataAccessObjects.GetAll_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
        {
           try
            {
				const string SP = "hr_newdemanddetl_GAExt";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_newdemanddetl.SortExpression);
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemanddetl, cmd, Database);
                    
                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader, true, true));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GetAllhr_newdemanddetl"));
            }	
        }
		
		IList<hr_newdemanddetlEntity> Ihr_newdemanddetlDataAccessObjects.GetAllByPages_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
        {
        try
            {
				const string SP = "hr_newdemanddetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemanddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemanddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemanddetl.CurrentPage);                    
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemanddetl, cmd,Database);

                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemanddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GetAllByPageshr_newdemanddetl"));
            }
        }
        
        #endregion
        
        
        
        
        #region Simple load Single Row
        hr_newdemanddetlEntity Ihr_newdemanddetlDataAccessObjects.GetSingle_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
        {
           try
            {
				const string SP = "hr_newdemanddetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemanddetl, cmd, Database);
                    
                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GetSinglehr_newdemanddetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_newdemanddetlEntity> Ihr_newdemanddetlDataAccessObjects.GAPgListView_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
        {
        try
            {
				const string SP = "hr_newdemanddetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemanddetl.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemanddetl.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemanddetl.CurrentPage);                    
                    FillSequrityParameters(hr_newdemanddetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemanddetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_newdemanddetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_newdemanddetl.strCommonSerachParam);

                    IList<hr_newdemanddetlEntity> itemList = new List<hr_newdemanddetlEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemanddetlEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemanddetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemanddetlDataAccess.GAPgListViewhr_newdemanddetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}