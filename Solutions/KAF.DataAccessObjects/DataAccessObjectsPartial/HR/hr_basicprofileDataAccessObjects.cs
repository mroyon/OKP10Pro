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
	
	internal sealed partial class hr_basicprofileDataAccessObjects 
	{
		
	    
		
        public static void FillParameters_Ext(hr_basicprofileEntity hr_basicprofile, DbCommand cmd,Database Database,bool forDelete=false)
        {
			
        }
		
        
		#region Add Operation

        long Ihr_basicprofileDataAccessObjects.Add_Ext(hr_basicprofileEntity hr_basicprofile  )
        {
            long returnCode = -99;
            const string SP = "hr_basicprofile_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_basicprofile, cmd,Database);
                FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.Addhr_basicprofile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_basicprofileDataAccessObjects.Update_Ext(hr_basicprofileEntity hr_basicprofile )
        {
           long returnCode = -99;
            const string SP = "hr_basicprofile_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_basicprofile, cmd,Database);
                FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.Updatehr_basicprofile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_basicprofileDataAccessObjects.Delete_Ext(hr_basicprofileEntity hr_basicprofile)
        {
            long returnCode = -99;
           	const string SP = "hr_basicprofile_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_basicprofile, cmd,Database, true);
                FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.Deletehr_basicprofile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_basicprofileDataAccessObjects.SaveList_Ext(IList<hr_basicprofileEntity> listAdded, IList<hr_basicprofileEntity> listUpdated, IList<hr_basicprofileEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_basicprofile_Ins";
            const string SPUpdate = "hr_basicprofile_Upd";
            const string SPDelete = "hr_basicprofile_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_basicprofileEntity hr_basicprofile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_basicprofile, cmd, Database, true);
                            FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_basicprofileEntity hr_basicprofile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_basicprofile, cmd, Database);
                            FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_basicprofileEntity hr_basicprofile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_basicprofile, cmd, Database);
                            FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.Save_hr_basicprofile"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList_Ext(Database db , DbTransaction transaction,IList<hr_basicprofileEntity> listAdded, IList<hr_basicprofileEntity> listUpdated, IList<hr_basicprofileEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_basicprofile_Ins";
            const string SPUpdate = "hr_basicprofile_Upd";
            const string SPDelete = "hr_basicprofile_Del";

            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_basicprofileEntity hr_basicprofile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_basicprofile, cmd, db, true);
                            FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, db);
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
                    foreach (hr_basicprofileEntity hr_basicprofile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_basicprofile, cmd, db);
                            FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, db);
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
                    foreach (hr_basicprofileEntity hr_basicprofile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_basicprofile, cmd, db);
                            FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.Save_hr_basicprofile"));
            }
            finally
            {
               
            }
            return returnCode;
        }

        

        #endregion SaveList<>

        #region GetAll

        IList<hr_basicprofileEntity> Ihr_basicprofileDataAccessObjects.GetAll_Ext(hr_basicprofileEntity hr_basicprofile)
        {
           try
            {
				const string SP = "hr_basicprofile_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_basicprofile.SortExpression);
                    FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_basicprofile, cmd, Database);
                    
                    IList<hr_basicprofileEntity> itemList = new List<hr_basicprofileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicprofileEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.GetAllhr_basicprofile"));
            }	
        }
		
		IList<hr_basicprofileEntity> Ihr_basicprofileDataAccessObjects.GetAllByPages_Ext(hr_basicprofileEntity hr_basicprofile)
        {
        try
            {
				const string SP = "hr_basicprofile_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_basicprofile.SortExpression);
                    AddPageSizeParameter(cmd, hr_basicprofile.PageSize);
                    AddCurrentPageParameter(cmd, hr_basicprofile.CurrentPage);                    
                    FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_basicprofile, cmd,Database);

                    IList<hr_basicprofileEntity> itemList = new List<hr_basicprofileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicprofileEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_basicprofile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.GetAllByPageshr_basicprofile"));
            }
        }
        
        #endregion
        
        
        
        
        
        
        #region ForListView Paged Method
        IList<hr_basicprofileEntity> Ihr_basicprofileDataAccessObjects.GAPgListView_Ext(hr_basicprofileEntity hr_basicprofile)
        {
        try
            {
				const string SP = "hr_basicprofile_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_basicprofile.SortExpression);
                    AddPageSizeParameter(cmd, hr_basicprofile.PageSize);
                    AddCurrentPageParameter(cmd, hr_basicprofile.CurrentPage);                    
                    FillSequrityParameters(hr_basicprofile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_basicprofile, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_basicprofile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_basicprofile.strCommonSerachParam);

                    IList<hr_basicprofileEntity> itemList = new List<hr_basicprofileEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_basicprofileEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_basicprofile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_basicprofileDataAccess.GAPgListViewhr_basicprofile"));
            }
        }
        #endregion
        
        
	}
}