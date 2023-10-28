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
	
	internal sealed partial class cnf_paymentitemDataAccessObjects : BaseDataAccess, Icnf_paymentitemDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_paymentitemDataAccessObjects";
        
		public cnf_paymentitemDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_paymentitemEntity cnf_paymentitem, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_paymentitem.payallceid.HasValue)
				Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, cnf_paymentitem.payallceid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(cnf_paymentitem.itemname)))
				Database.AddInParameter(cmd, "@ItemName", DbType.String, cnf_paymentitem.itemname);
			if (cnf_paymentitem.type.HasValue)
				Database.AddInParameter(cmd, "@Type", DbType.Int64, cnf_paymentitem.type);
			if (!(string.IsNullOrEmpty(cnf_paymentitem.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_paymentitem.remarks);
			if ((cnf_paymentitem.ispercentage != null))
				Database.AddInParameter(cmd, "@IsPercentage", DbType.Boolean, cnf_paymentitem.ispercentage);
			if (cnf_paymentitem.amount.HasValue)
				Database.AddInParameter(cmd, "@Amount", DbType.Decimal, cnf_paymentitem.amount);
			if ((cnf_paymentitem.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, cnf_paymentitem.ex_date1);
			if ((cnf_paymentitem.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, cnf_paymentitem.ex_date2);
			if (!(string.IsNullOrEmpty(cnf_paymentitem.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, cnf_paymentitem.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(cnf_paymentitem.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, cnf_paymentitem.ex_nvarchar2);
			if (cnf_paymentitem.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, cnf_paymentitem.ex_bigint1);
			if (cnf_paymentitem.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, cnf_paymentitem.ex_bigint2);
			if (cnf_paymentitem.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, cnf_paymentitem.ex_decimal1);
			if (cnf_paymentitem.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, cnf_paymentitem.ex_decimal2);

        }
		
        
		#region Add Operation

        long Icnf_paymentitemDataAccessObjects.Add(cnf_paymentitemEntity cnf_paymentitem  )
        {
            long returnCode = -99;
            const string SP = "cnf_paymentitem_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_paymentitem, cmd,Database);
                FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.Addcnf_paymentitem"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Icnf_paymentitemDataAccessObjects.Update(cnf_paymentitemEntity cnf_paymentitem )
        {
           long returnCode = -99;
            const string SP = "cnf_paymentitem_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_paymentitem, cmd,Database);
                FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.Updatecnf_paymentitem"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Icnf_paymentitemDataAccessObjects.Delete(cnf_paymentitemEntity cnf_paymentitem)
        {
            long returnCode = -99;
           	const string SP = "cnf_paymentitem_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_paymentitem, cmd,Database, true);
                FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.Deletecnf_paymentitem"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Icnf_paymentitemDataAccessObjects.SaveList(IList<cnf_paymentitemEntity> listAdded, IList<cnf_paymentitemEntity> listUpdated, IList<cnf_paymentitemEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_paymentitem_Ins";
            const string SPUpdate = "cnf_paymentitem_Upd";
            const string SPDelete = "cnf_paymentitem_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_paymentitemEntity cnf_paymentitem in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_paymentitem, cmd, Database, true);
                            FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_paymentitemEntity cnf_paymentitem in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_paymentitem, cmd, Database);
                            FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_paymentitemEntity cnf_paymentitem in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_paymentitem, cmd, Database);
                            FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.Save_cnf_paymentitem"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<cnf_paymentitemEntity> listAdded, IList<cnf_paymentitemEntity> listUpdated, IList<cnf_paymentitemEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_paymentitem_Ins";
            const string SPUpdate = "cnf_paymentitem_Upd";
            const string SPDelete = "cnf_paymentitem_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_paymentitemEntity cnf_paymentitem in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_paymentitem, cmd, db, true);
                            FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_paymentitemEntity cnf_paymentitem in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_paymentitem, cmd, db);
                            FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_paymentitemEntity cnf_paymentitem in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_paymentitem, cmd, db);
                            FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.Save_cnf_paymentitem"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<cnf_paymentitemEntity> Icnf_paymentitemDataAccessObjects.GetAll(cnf_paymentitemEntity cnf_paymentitem)
        {
           try
            {
				const string SP = "cnf_paymentitem_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_paymentitem.SortExpression);
                    FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_paymentitem, cmd, Database);
                    
                    IList<cnf_paymentitemEntity> itemList = new List<cnf_paymentitemEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_paymentitemEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.GetAllcnf_paymentitem"));
            }	
        }
		
		IList<cnf_paymentitemEntity> Icnf_paymentitemDataAccessObjects.GetAllByPages(cnf_paymentitemEntity cnf_paymentitem)
        {
        try
            {
				const string SP = "cnf_paymentitem_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_paymentitem.SortExpression);
                    AddPageSizeParameter(cmd, cnf_paymentitem.PageSize);
                    AddCurrentPageParameter(cmd, cnf_paymentitem.CurrentPage);                    
                    FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_paymentitem, cmd,Database);

                    IList<cnf_paymentitemEntity> itemList = new List<cnf_paymentitemEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_paymentitemEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_paymentitem.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.GetAllByPagescnf_paymentitem"));
            }
        }
        
        #endregion
        
   
        
        #region Simple load Single Row
        cnf_paymentitemEntity Icnf_paymentitemDataAccessObjects.GetSingle(cnf_paymentitemEntity cnf_paymentitem)
        {
           try
            {
				const string SP = "cnf_paymentitem_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_paymentitem, cmd, Database);
                    
                    IList<cnf_paymentitemEntity> itemList = new List<cnf_paymentitemEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_paymentitemEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.GetSinglecnf_paymentitem"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<cnf_paymentitemEntity> Icnf_paymentitemDataAccessObjects.GAPgListView(cnf_paymentitemEntity cnf_paymentitem)
        {
        try
            {
				const string SP = "cnf_paymentitem_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_paymentitem.SortExpression);
                    AddPageSizeParameter(cmd, cnf_paymentitem.PageSize);
                    AddCurrentPageParameter(cmd, cnf_paymentitem.CurrentPage);                    
                    FillSequrityParameters(cnf_paymentitem.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_paymentitem, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_paymentitem.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, cnf_paymentitem.strCommonSerachParam);

                    IList<cnf_paymentitemEntity> itemList = new List<cnf_paymentitemEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_paymentitemEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_paymentitem.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_paymentitemDataAccess.GAPgListViewcnf_paymentitem"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}