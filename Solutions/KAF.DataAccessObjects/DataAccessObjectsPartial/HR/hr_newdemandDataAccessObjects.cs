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
	
	internal sealed partial class hr_newdemandDataAccessObjects
	{		
        public static void FillParameters_Ext(hr_newdemandEntity hr_newdemand, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (!(string.IsNullOrEmpty(hr_newdemand.strValue1)))
				Database.AddInParameter(cmd, "@String", DbType.String, hr_newdemand.strValue1);
        }
		
        
		#region Add Operation

        long Ihr_newdemandDataAccessObjects.Add_Ext(hr_newdemandEntity hr_newdemand  )
        {
            long returnCode = -99;
            const string SP = "hr_newdemand_InsEXT";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_newdemand, cmd,Database);
                FillParameters_Ext(hr_newdemand, cmd, Database);
                FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Addhr_newdemand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_newdemandDataAccessObjects.Update_Ext(hr_newdemandEntity hr_newdemand )
        {
           long returnCode = -99;
            const string SP = "hr_newdemand_InsEXT";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_newdemand, cmd,Database);
                FillParameters_Ext(hr_newdemand, cmd, Database);
                FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Updatehr_newdemand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_newdemandDataAccessObjects.Delete_Ext(hr_newdemandEntity hr_newdemand)
        {
            long returnCode = -99;
           	const string SP = "hr_newdemand_Del_Ext";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_newdemand, cmd,Database, true);
                FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Deletehr_newdemand"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_newdemandDataAccessObjects.SaveList_Ext(IList<hr_newdemandEntity> listAdded, IList<hr_newdemandEntity> listUpdated, IList<hr_newdemandEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_newdemand_Ins";
            const string SPUpdate = "hr_newdemand_Upd";
            const string SPDelete = "hr_newdemand_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_newdemandEntity hr_newdemand in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_newdemand, cmd, Database, true);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemandEntity hr_newdemand in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_newdemand, cmd, Database);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_newdemandEntity hr_newdemand in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_newdemand, cmd, Database);
                            FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.Save_hr_newdemand"));
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

        IList<hr_newdemandEntity> Ihr_newdemandDataAccessObjects.GetAll_Ext(hr_newdemandEntity hr_newdemand)
        {
           try
            {
				const string SP = "hr_newdemand_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_newdemand.SortExpression);
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_newdemand, cmd, Database);
                    
                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GetAllhr_newdemand"));
            }	
        }
		
		IList<hr_newdemandEntity> Ihr_newdemandDataAccessObjects.GetAllByPages_Ext(hr_newdemandEntity hr_newdemand)
        {
        try
            {
				const string SP = "hr_newdemand_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemand.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemand.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemand.CurrentPage);                    
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_newdemand, cmd,Database);

                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_newdemand.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GetAllByPageshr_newdemand"));
            }
        }

        IList<hr_newdemandEntity> Ihr_newdemandDataAccessObjects.GAPgListView_Ext(hr_newdemandEntity hr_newdemand)
        {
            try
            {
                const string SP = "KAF_GetNoOfVacanciesAgainstNewDemand";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_newdemand.SortExpression);
                    AddPageSizeParameter(cmd, hr_newdemand.PageSize);
                    AddCurrentPageParameter(cmd, hr_newdemand.CurrentPage);
                    FillSequrityParameters(hr_newdemand.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_newdemand, cmd, Database);

                    if (!string.IsNullOrEmpty(hr_newdemand.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_newdemand.strCommonSerachParam);

                    IList<hr_newdemandEntity> itemList = new List<hr_newdemandEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_newdemandEntity(reader, true, true));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_newdemand.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_newdemandDataAccess.GAPgListViewhr_newdemand"));
            }
        }

        #endregion
    }
}