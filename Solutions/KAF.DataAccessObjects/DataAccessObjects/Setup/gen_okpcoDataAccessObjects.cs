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
	
	internal sealed partial class gen_okpcoDataAccessObjects : BaseDataAccess, Igen_okpcoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_okpcoDataAccessObjects";
        
		public gen_okpcoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_okpcoEntity gen_okpco, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_okpco.okpcoid.HasValue)
				Database.AddInParameter(cmd, "@OkpCoID", DbType.Int64, gen_okpco.okpcoid);
            if (forDelete) return;
			if (gen_okpco.okpid.HasValue)
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, gen_okpco.okpid);
			if (gen_okpco.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, gen_okpco.hrbasicid);
			if ((gen_okpco.fromdate.HasValue))
				Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, gen_okpco.fromdate);
			if ((gen_okpco.todate.HasValue))
				Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, gen_okpco.todate);
			if ((gen_okpco.iscurrent != null))
				Database.AddInParameter(cmd, "@isCurrent", DbType.Boolean, gen_okpco.iscurrent);
			if (!(string.IsNullOrEmpty(gen_okpco.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_okpco.remarks);
			if ((gen_okpco.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_okpco.ex_date1);
			if ((gen_okpco.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_okpco.ex_date2);
			if (!(string.IsNullOrEmpty(gen_okpco.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_okpco.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_okpco.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_okpco.ex_nvarchar2);
			if (gen_okpco.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_okpco.ex_bigint1);
			if (gen_okpco.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_okpco.ex_bigint2);
			if (gen_okpco.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_okpco.ex_decimal1);
			if (gen_okpco.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_okpco.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_okpcoDataAccessObjects.Add(gen_okpcoEntity gen_okpco  )
        {
            long returnCode = -99;
            const string SP = "gen_okpco_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_okpco, cmd,Database);
                FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.Addgen_okpco"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_okpcoDataAccessObjects.Update(gen_okpcoEntity gen_okpco )
        {
           long returnCode = -99;
            const string SP = "gen_okpco_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_okpco, cmd,Database);
                FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.Updategen_okpco"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_okpcoDataAccessObjects.Delete(gen_okpcoEntity gen_okpco)
        {
            long returnCode = -99;
           	const string SP = "gen_okpco_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_okpco, cmd,Database, true);
                FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.Deletegen_okpco"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_okpcoDataAccessObjects.SaveList(IList<gen_okpcoEntity> listAdded, IList<gen_okpcoEntity> listUpdated, IList<gen_okpcoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_okpco_Ins";
            const string SPUpdate = "gen_okpco_Upd";
            const string SPDelete = "gen_okpco_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_okpcoEntity gen_okpco in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_okpco, cmd, Database, true);
                            FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_okpcoEntity gen_okpco in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_okpco, cmd, Database);
                            FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_okpcoEntity gen_okpco in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_okpco, cmd, Database);
                            FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.Save_gen_okpco"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_okpcoEntity> listAdded, IList<gen_okpcoEntity> listUpdated, IList<gen_okpcoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_okpco_Ins";
            const string SPUpdate = "gen_okpco_Upd";
            const string SPDelete = "gen_okpco_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_okpcoEntity gen_okpco in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_okpco, cmd, db, true);
                            FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, db);
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
                    foreach (gen_okpcoEntity gen_okpco in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_okpco, cmd, db);
                            FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, db);
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
                    foreach (gen_okpcoEntity gen_okpco in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_okpco, cmd, db);
                            FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.Save_gen_okpco"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_okpcoEntity> Igen_okpcoDataAccessObjects.GetAll(gen_okpcoEntity gen_okpco)
        {
           try
            {
				const string SP = "gen_okpco_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_okpco.SortExpression);
                    FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_okpco, cmd, Database);
                    
                    IList<gen_okpcoEntity> itemList = new List<gen_okpcoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpcoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.GetAllgen_okpco"));
            }	
        }
		
		IList<gen_okpcoEntity> Igen_okpcoDataAccessObjects.GetAllByPages(gen_okpcoEntity gen_okpco)
        {
        try
            {
				const string SP = "gen_okpco_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_okpco.SortExpression);
                    AddPageSizeParameter(cmd, gen_okpco.PageSize);
                    AddCurrentPageParameter(cmd, gen_okpco.CurrentPage);                    
                    FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_okpco, cmd,Database);

                    IList<gen_okpcoEntity> itemList = new List<gen_okpcoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpcoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_okpco.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.GetAllByPagesgen_okpco"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_okpcoEntity Igen_okpcoDataAccessObjects.GetSingle(gen_okpcoEntity gen_okpco)
        {
           try
            {
				const string SP = "gen_okpco_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_okpco, cmd, Database);
                    
                    IList<gen_okpcoEntity> itemList = new List<gen_okpcoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpcoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.GetSinglegen_okpco"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_okpcoEntity> Igen_okpcoDataAccessObjects.GAPgListView(gen_okpcoEntity gen_okpco)
        {
        try
            {
				const string SP = "gen_okpco_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_okpco.SortExpression);
                    AddPageSizeParameter(cmd, gen_okpco.PageSize);
                    AddCurrentPageParameter(cmd, gen_okpco.CurrentPage);                    
                    FillSequrityParameters(gen_okpco.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_okpco, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_okpco.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_okpco.strCommonSerachParam);

                    IList<gen_okpcoEntity> itemList = new List<gen_okpcoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpcoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_okpco.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_okpcoDataAccess.GAPgListViewgen_okpco"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}