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
	
	internal sealed partial class hr_demanddetlpassportDataAccessObjects
	{
		
	    
		
        public static void FillParameters_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport, DbCommand cmd,Database Database,bool forDelete=false)
        {
            if (hr_demanddetlpassport.newdemandid.HasValue)
                Database.AddInParameter(cmd, "@NewDemandID", DbType.Int64, hr_demanddetlpassport.newdemandid);
            //if (hr_demanddetlpassport.letterdate.HasValue)
            //    Database.AddInParameter(cmd, "@LetterDate", DbType.DateTime, hr_demanddetlpassport.letterdate);

            if (!(string.IsNullOrEmpty(hr_demanddetlpassport.passportno)))
                Database.AddInParameter(cmd, "@PassportNo", DbType.String, hr_demanddetlpassport.passportno);

            if (!(string.IsNullOrEmpty(hr_demanddetlpassport.name1)))
                Database.AddInParameter(cmd, "@Name1", DbType.String, hr_demanddetlpassport.name1);

            if (!(string.IsNullOrEmpty(hr_demanddetlpassport.name2)))
                Database.AddInParameter(cmd, "@Name2", DbType.String, hr_demanddetlpassport.name2);

            if (hr_demanddetlpassport.isall.HasValue)
                Database.AddInParameter(cmd, "@IsAll", DbType.Int64, hr_demanddetlpassport.isall);
        }
		
        
		#region Add Operation

        long Ihr_demanddetlpassportDataAccessObjects.Add_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport  )
        {
            long returnCode = -99;
            const string SP = "hr_demanddetlpassport_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_demanddetlpassport, cmd,Database);
                FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Addhr_demanddetlpassport"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_demanddetlpassportDataAccessObjects.Update_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport )
        {
           long returnCode = -99;
            const string SP = "hr_demanddetlpassport_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_demanddetlpassport, cmd,Database);
                FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Updatehr_demanddetlpassport"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_demanddetlpassportDataAccessObjects.Delete_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
            long returnCode = -99;
           	const string SP = "hr_demanddetlpassport_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_demanddetlpassport, cmd,Database, true);
                FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Deletehr_demanddetlpassport"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_demanddetlpassportDataAccessObjects.SaveList_Ext(IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted)
        {
            long returnCode = -99;
            long primaryid = -99;

            const string SPInsert = "hr_demanddetlpassport_InsExt";
            const string SPUpdate = "hr_demanddetlpassport_UpdExt";
            const string SPDelete = "hr_demanddetlpassport_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                   // primaryid = listDeleted[0].newdemandid.Value;

                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, Database, true);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
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
                    //primaryid = listUpdated[0].newdemandid.Value;

                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, Database);
                            FillParameters_Ext(hr_demanddetlpassport, cmd, Database);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
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
                    //primaryid = listAdded[0].newdemandid.Value;

                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, Database);
                            FillParameters_Ext(hr_demanddetlpassport, cmd, Database);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Save_hr_demanddetlpassport"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList_Ext(Database db , DbTransaction transaction,IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_demanddetlpassport_Ins";
            const string SPUpdate = "hr_demanddetlpassport_Upd";
            const string SPDelete = "hr_demanddetlpassport_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, db, true);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, db);
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
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, db);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, db);
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
                    foreach (hr_demanddetlpassportEntity hr_demanddetlpassport in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_demanddetlpassport, cmd, db);
                            FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.Save_hr_demanddetlpassport"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GetAll_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
           try
            {
				const string SP = "hr_demanddetlpassport_GAEXT";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_demanddetlpassport.SortExpression);
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_demanddetlpassport, cmd, Database);
                    FillParameters_Ext(hr_demanddetlpassport, cmd, Database);

                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader, true, true));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GetAllhr_demanddetlpassport"));
            }	
        }
		
		IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GetAllByPages_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
        try
            {
				const string SP = "hr_demanddetlpassport_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_demanddetlpassport.SortExpression);
                    AddPageSizeParameter(cmd, hr_demanddetlpassport.PageSize);
                    AddCurrentPageParameter(cmd, hr_demanddetlpassport.CurrentPage);                    
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_demanddetlpassport, cmd,Database);

                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_demanddetlpassport.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GetAllByPageshr_demanddetlpassport"));
            }
        }
        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GetDemandPassportLetterNoByNewDemandID(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
           try
            {
				const string SP = "hr_newdemandpassportLetterNo_Select2Ext";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{

                    AddPageSizeParameter(cmd, hr_demanddetlpassport.PageSize);
                    AddCurrentPageParameter(cmd, hr_demanddetlpassport.CurrentPage);
                    FillParameters(hr_demanddetlpassport, cmd, Database);

                    FillParameters_Ext(hr_demanddetlpassport, cmd, Database);

                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader, true, true, true));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GetDemandPassportLetterNoByNewDemandID"));
            }	
        }

        #region ForListView Paged Method
        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportDataAccessObjects.GAPgListView_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
            try
            {
                const string SP = "hr_demanddetlpassport_GAPgListViewExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_demanddetlpassport.SortExpression);
                    AddPageSizeParameter(cmd, hr_demanddetlpassport.PageSize);
                    AddCurrentPageParameter(cmd, hr_demanddetlpassport.CurrentPage);
                    FillSequrityParameters(hr_demanddetlpassport.BaseSecurityParam, cmd, Database);

                    FillParameters(hr_demanddetlpassport, cmd, Database);

                    if (!string.IsNullOrEmpty(hr_demanddetlpassport.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_demanddetlpassport.strCommonSerachParam);

                    IList<hr_demanddetlpassportEntity> itemList = new List<hr_demanddetlpassportEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_demanddetlpassportEntity(reader, 1));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        hr_demanddetlpassport.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_demanddetlpassportDataAccess.GAPgListViewhr_demanddetlpassport"));
            }
        }
        #endregion

        #endregion
    }
}