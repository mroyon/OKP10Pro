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
	
	internal sealed partial class hr_passportinfoDataAccessObjects : BaseDataAccess, Ihr_passportinfoDataAccessObjects
	{
		
        public static void FillParameters_Ext(hr_passportinfoEntity hr_passportinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
            if (hr_passportinfo.militarynokw.HasValue)
                Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, hr_passportinfo.militarynokw);
        }
		
        
		#region Add Operation

        long Ihr_passportinfoDataAccessObjects.Add_Ext(hr_passportinfoEntity hr_passportinfo)
        {
            long returnCode = -99;
            const string SP = "hr_passportinfo_InsExt";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_passportinfo, cmd,Database);
                FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Addhr_passportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_passportinfoDataAccessObjects.Update_Ext(hr_passportinfoEntity hr_passportinfo )
        {
           long returnCode = -99;
            const string SP = "hr_passportinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_passportinfo, cmd,Database);
                FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Updatehr_passportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_passportinfoDataAccessObjects.Delete_Ext(hr_passportinfoEntity hr_passportinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_passportinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_passportinfo, cmd,Database, true);
                FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Deletehr_passportinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_passportinfoDataAccessObjects.SaveList_Ext(IList<hr_passportinfoEntity> listAdded, IList<hr_passportinfoEntity> listUpdated, IList<hr_passportinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_passportinfo_Ins";
            const string SPUpdate = "hr_passportinfo_Upd";
            const string SPDelete = "hr_passportinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_passportinfoEntity hr_passportinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_passportinfo, cmd, Database, true);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_passportinfoEntity hr_passportinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_passportinfo, cmd, Database);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_passportinfoEntity hr_passportinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_passportinfo, cmd, Database);
                            FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.Save_hr_passportinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_passportinfoEntity> Ihr_passportinfoDataAccessObjects.GetAll_Ext(hr_passportinfoEntity hr_passportinfo)
        {
           try
            {
				const string SP = "KAF_GetMilPersonPassportInfo";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					//AddSortExpressionParameter(cmd, hr_passportinfo.SortExpression);
     //               FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_passportinfo, cmd, Database);
                    FillParameters_Ext(hr_passportinfo, cmd, Database);

                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader,true,true));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GetAllhr_passportinfo"));
            }	
        }
		
		IList<hr_passportinfoEntity> Ihr_passportinfoDataAccessObjects.GetAllByPages_Ext(hr_passportinfoEntity hr_passportinfo)
        {
        try
            {
				const string SP = "hr_passportinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_passportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_passportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_passportinfo.CurrentPage);                    
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_passportinfo, cmd,Database);

                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_passportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GetAllByPageshr_passportinfo"));
            }
        }
        
        #endregion
        
        
        
        
        #region Simple load Single Row
        hr_passportinfoEntity Ihr_passportinfoDataAccessObjects.GetSingle_Ext(hr_passportinfoEntity hr_passportinfo)
        {
           try
            {
				const string SP = "hr_passportinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_passportinfo, cmd, Database);
                    
                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GetSinglehr_passportinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_passportinfoEntity> Ihr_passportinfoDataAccessObjects.GAPgListView_Ext(hr_passportinfoEntity hr_passportinfo)
        {
        try
            {
				const string SP = "hr_passportinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_passportinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_passportinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_passportinfo.CurrentPage);                    
                    FillSequrityParameters(hr_passportinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_passportinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_passportinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_passportinfo.strCommonSerachParam);

                    IList<hr_passportinfoEntity> itemList = new List<hr_passportinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_passportinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_passportinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_passportinfoDataAccess.GAPgListViewhr_passportinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}