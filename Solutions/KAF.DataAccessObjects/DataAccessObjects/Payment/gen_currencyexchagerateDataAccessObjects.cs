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
	
	internal sealed partial class gen_currencyexchagerateDataAccessObjects : BaseDataAccess, Igen_currencyexchagerateDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_currencyexchagerateDataAccessObjects";
        
		public gen_currencyexchagerateDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_currencyexchagerateEntity gen_currencyexchagerate, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_currencyexchagerate.currencyexchagerateid.HasValue)
				Database.AddInParameter(cmd, "@CurrencyExchageRateID", DbType.Int64, gen_currencyexchagerate.currencyexchagerateid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_currencyexchagerate.fromcurrencyname)))
				Database.AddInParameter(cmd, "@FromCurrencyName", DbType.String, gen_currencyexchagerate.fromcurrencyname);
			if (!(string.IsNullOrEmpty(gen_currencyexchagerate.tocurrencyname)))
				Database.AddInParameter(cmd, "@ToCurrencyName", DbType.String, gen_currencyexchagerate.tocurrencyname);
			if (gen_currencyexchagerate.rate.HasValue)
				Database.AddInParameter(cmd, "@Rate", DbType.Decimal, gen_currencyexchagerate.rate);
			if ((gen_currencyexchagerate.ratedatefrom.HasValue))
				Database.AddInParameter(cmd, "@RateDateFrom", DbType.DateTime, gen_currencyexchagerate.ratedatefrom);
			if ((gen_currencyexchagerate.ratedateto.HasValue))
				Database.AddInParameter(cmd, "@RateDateTo", DbType.DateTime, gen_currencyexchagerate.ratedateto);
			if (!(string.IsNullOrEmpty(gen_currencyexchagerate.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_currencyexchagerate.remarks);
			if ((gen_currencyexchagerate.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_currencyexchagerate.ex_date1);
			if ((gen_currencyexchagerate.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_currencyexchagerate.ex_date2);
			if (!(string.IsNullOrEmpty(gen_currencyexchagerate.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_currencyexchagerate.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_currencyexchagerate.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_currencyexchagerate.ex_nvarchar2);
			if (gen_currencyexchagerate.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_currencyexchagerate.ex_bigint1);
			if (gen_currencyexchagerate.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_currencyexchagerate.ex_bigint2);
			if (gen_currencyexchagerate.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_currencyexchagerate.ex_decimal1);
			if (gen_currencyexchagerate.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_currencyexchagerate.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_currencyexchagerateDataAccessObjects.Add(gen_currencyexchagerateEntity gen_currencyexchagerate  )
        {
            long returnCode = -99;
            const string SP = "gen_currencyexchagerate_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_currencyexchagerate, cmd,Database);
                FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.Addgen_currencyexchagerate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_currencyexchagerateDataAccessObjects.Update(gen_currencyexchagerateEntity gen_currencyexchagerate )
        {
           long returnCode = -99;
            const string SP = "gen_currencyexchagerate_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_currencyexchagerate, cmd,Database);
                FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.Updategen_currencyexchagerate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_currencyexchagerateDataAccessObjects.Delete(gen_currencyexchagerateEntity gen_currencyexchagerate)
        {
            long returnCode = -99;
           	const string SP = "gen_currencyexchagerate_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_currencyexchagerate, cmd,Database, true);
                FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.Deletegen_currencyexchagerate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_currencyexchagerateDataAccessObjects.SaveList(IList<gen_currencyexchagerateEntity> listAdded, IList<gen_currencyexchagerateEntity> listUpdated, IList<gen_currencyexchagerateEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_currencyexchagerate_Ins";
            const string SPUpdate = "gen_currencyexchagerate_Upd";
            const string SPDelete = "gen_currencyexchagerate_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_currencyexchagerateEntity gen_currencyexchagerate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_currencyexchagerate, cmd, Database, true);
                            FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_currencyexchagerateEntity gen_currencyexchagerate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_currencyexchagerate, cmd, Database);
                            FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_currencyexchagerateEntity gen_currencyexchagerate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_currencyexchagerate, cmd, Database);
                            FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.Save_gen_currencyexchagerate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_currencyexchagerateEntity> listAdded, IList<gen_currencyexchagerateEntity> listUpdated, IList<gen_currencyexchagerateEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_currencyexchagerate_Ins";
            const string SPUpdate = "gen_currencyexchagerate_Upd";
            const string SPDelete = "gen_currencyexchagerate_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_currencyexchagerateEntity gen_currencyexchagerate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_currencyexchagerate, cmd, db, true);
                            FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, db);
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
                    foreach (gen_currencyexchagerateEntity gen_currencyexchagerate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_currencyexchagerate, cmd, db);
                            FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, db);
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
                    foreach (gen_currencyexchagerateEntity gen_currencyexchagerate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_currencyexchagerate, cmd, db);
                            FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.Save_gen_currencyexchagerate"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateDataAccessObjects.GetAll(gen_currencyexchagerateEntity gen_currencyexchagerate)
        {
           try
            {
				 string SP = "gen_currencyexchagerate_GA";

                if(gen_currencyexchagerate.isCurrent == true)
                    SP = "gen_currencyexchagerate_GA_Ext";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_currencyexchagerate.SortExpression);
                    FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_currencyexchagerate, cmd, Database);
                    
                    IList<gen_currencyexchagerateEntity> itemList = new List<gen_currencyexchagerateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_currencyexchagerateEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.GetAllgen_currencyexchagerate"));
            }	
        }
		
		IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateDataAccessObjects.GetAllByPages(gen_currencyexchagerateEntity gen_currencyexchagerate)
        {
        try
            {
				const string SP = "gen_currencyexchagerate_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_currencyexchagerate.SortExpression);
                    AddPageSizeParameter(cmd, gen_currencyexchagerate.PageSize);
                    AddCurrentPageParameter(cmd, gen_currencyexchagerate.CurrentPage);                    
                    FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_currencyexchagerate, cmd,Database);

                    IList<gen_currencyexchagerateEntity> itemList = new List<gen_currencyexchagerateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_currencyexchagerateEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_currencyexchagerate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.GetAllByPagesgen_currencyexchagerate"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_currencyexchagerateEntity Igen_currencyexchagerateDataAccessObjects.GetSingle(gen_currencyexchagerateEntity gen_currencyexchagerate)
        {
           try
            {
				const string SP = "gen_currencyexchagerate_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_currencyexchagerate, cmd, Database);
                    
                    IList<gen_currencyexchagerateEntity> itemList = new List<gen_currencyexchagerateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_currencyexchagerateEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.GetSinglegen_currencyexchagerate"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateDataAccessObjects.GAPgListView(gen_currencyexchagerateEntity gen_currencyexchagerate)
        {
        try
            {
				const string SP = "gen_currencyexchagerate_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_currencyexchagerate.SortExpression);
                    AddPageSizeParameter(cmd, gen_currencyexchagerate.PageSize);
                    AddCurrentPageParameter(cmd, gen_currencyexchagerate.CurrentPage);                    
                    FillSequrityParameters(gen_currencyexchagerate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_currencyexchagerate, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_currencyexchagerate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_currencyexchagerate.strCommonSerachParam);

                    IList<gen_currencyexchagerateEntity> itemList = new List<gen_currencyexchagerateEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_currencyexchagerateEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_currencyexchagerate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_currencyexchagerateDataAccess.GAPgListViewgen_currencyexchagerate"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}