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
	
	internal sealed partial class hr_personalinfoDataAccessObjects : BaseDataAccess, Ihr_personalinfoDataAccessObjects
	{
		
	    
		
        public static void FillParameters_Ext(hr_personalinfoEntity hr_personalinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_personalinfo.militarynokw.HasValue)
				Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, hr_personalinfo.militarynokw);
            

        }
		
        
		#region Add Operation

        long Ihr_personalinfoDataAccessObjects.Add_Ext(hr_personalinfoEntity hr_personalinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_personalinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_personalinfo, cmd,Database);
                FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Addhr_personalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_personalinfoDataAccessObjects.Update_Ext(hr_personalinfoEntity hr_personalinfo )
        {
           long returnCode = -99;
            const string SP = "hr_personalinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_personalinfo, cmd,Database);
                FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Updatehr_personalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_personalinfoDataAccessObjects.Delete_Ext(hr_personalinfoEntity hr_personalinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_personalinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_personalinfo, cmd,Database, true);
                FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Deletehr_personalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_personalinfoDataAccessObjects.SaveList_Ext(IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_personalinfo_Ins";
            const string SPUpdate = "hr_personalinfo_Upd";
            const string SPDelete = "hr_personalinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_personalinfoEntity hr_personalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_personalinfo, cmd, Database, true);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_personalinfo, cmd, Database);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_personalinfo, cmd, Database);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Save_hr_personalinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList_Ext(Database db , DbTransaction transaction,IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_personalinfo_Ins";
            const string SPUpdate = "hr_personalinfo_Upd";
            const string SPDelete = "hr_personalinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_personalinfoEntity hr_personalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_personalinfo, cmd, db, true);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_personalinfo, cmd, db);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_personalinfo, cmd, db);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Save_hr_personalinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_personalinfoEntity> Ihr_personalinfoDataAccessObjects.GetAll_Ext(hr_personalinfoEntity hr_personalinfo)
        {
           try
            {
				const string SP = "hr_personalinfo_GAExt";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					//AddSortExpressionParameter(cmd, hr_personalinfo.SortExpression);
     //               FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters_Ext(hr_personalinfo, cmd, Database);
                    
                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader, true, true));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GetAllhr_personalinfo"));
            }	
        }
		
		IList<hr_personalinfoEntity> Ihr_personalinfoDataAccessObjects.GetAllByPages_Ext(hr_personalinfoEntity hr_personalinfo)
        {
        try
            {
				const string SP = "hr_personalinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_personalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_personalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_personalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_personalinfo, cmd,Database);

                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_personalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GetAllByPageshr_personalinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_personalinfoEntity Ihr_personalinfoDataAccessObjects.GetSingle_Ext(hr_personalinfoEntity hr_personalinfo)
        {
           try
            {
				const string SP = "hr_personalinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_personalinfo, cmd, Database);
                    
                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GetSinglehr_personalinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_personalinfoEntity> Ihr_personalinfoDataAccessObjects.GAPgListView_Ext(hr_personalinfoEntity hr_personalinfo)
        {
        try
            {
				const string SP = "hr_personalinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_personalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_personalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_personalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_personalinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_personalinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_personalinfo.strCommonSerachParam);

                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_personalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GAPgListViewhr_personalinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}