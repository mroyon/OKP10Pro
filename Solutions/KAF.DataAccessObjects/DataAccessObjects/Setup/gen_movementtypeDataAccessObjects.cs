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
	
	internal sealed partial class gen_movementtypeDataAccessObjects : BaseDataAccess, Igen_movementtypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_movementtypeDataAccessObjects";
        
		public gen_movementtypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_movementtypeEntity gen_movementtype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_movementtype.movementtypeid.HasValue)
				Database.AddInParameter(cmd, "@MovementTypeID", DbType.Int64, gen_movementtype.movementtypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_movementtype.movementtype)))
				Database.AddInParameter(cmd, "@MovementType", DbType.String, gen_movementtype.movementtype);
			if (gen_movementtype.movementfor.HasValue)
				Database.AddInParameter(cmd, "@MovementFor", DbType.Int64, gen_movementtype.movementfor);
			if (!(string.IsNullOrEmpty(gen_movementtype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_movementtype.remarks);
			if ((gen_movementtype.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_movementtype.ex_date1);
			if ((gen_movementtype.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_movementtype.ex_date2);
			if (!(string.IsNullOrEmpty(gen_movementtype.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_movementtype.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(gen_movementtype.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_movementtype.ex_nvarchar2);
			if (gen_movementtype.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_movementtype.ex_bigint1);
			if (gen_movementtype.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_movementtype.ex_bigint2);
			if (gen_movementtype.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_movementtype.ex_decimal1);
			if (gen_movementtype.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_movementtype.ex_decimal2);

        }
		
        
		#region Add Operation

        long Igen_movementtypeDataAccessObjects.Add(gen_movementtypeEntity gen_movementtype  )
        {
            long returnCode = -99;
            const string SP = "gen_movementtype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_movementtype, cmd,Database);
                FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.Addgen_movementtype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Igen_movementtypeDataAccessObjects.Update(gen_movementtypeEntity gen_movementtype )
        {
           long returnCode = -99;
            const string SP = "gen_movementtype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_movementtype, cmd,Database);
                FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.Updategen_movementtype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Igen_movementtypeDataAccessObjects.Delete(gen_movementtypeEntity gen_movementtype)
        {
            long returnCode = -99;
           	const string SP = "gen_movementtype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_movementtype, cmd,Database, true);
                FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.Deletegen_movementtype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Igen_movementtypeDataAccessObjects.SaveList(IList<gen_movementtypeEntity> listAdded, IList<gen_movementtypeEntity> listUpdated, IList<gen_movementtypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_movementtype_Ins";
            const string SPUpdate = "gen_movementtype_Upd";
            const string SPDelete = "gen_movementtype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_movementtypeEntity gen_movementtype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_movementtype, cmd, Database, true);
                            FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_movementtypeEntity gen_movementtype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_movementtype, cmd, Database);
                            FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_movementtypeEntity gen_movementtype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_movementtype, cmd, Database);
                            FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.Save_gen_movementtype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<gen_movementtypeEntity> listAdded, IList<gen_movementtypeEntity> listUpdated, IList<gen_movementtypeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "gen_movementtype_Ins";
            const string SPUpdate = "gen_movementtype_Upd";
            const string SPDelete = "gen_movementtype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_movementtypeEntity gen_movementtype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_movementtype, cmd, db, true);
                            FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_movementtypeEntity gen_movementtype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_movementtype, cmd, db);
                            FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_movementtypeEntity gen_movementtype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_movementtype, cmd, db);
                            FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.Save_gen_movementtype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<gen_movementtypeEntity> Igen_movementtypeDataAccessObjects.GetAll(gen_movementtypeEntity gen_movementtype)
        {
           try
            {
				const string SP = "gen_movementtype_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_movementtype.SortExpression);
                    FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_movementtype, cmd, Database);
                    
                    IList<gen_movementtypeEntity> itemList = new List<gen_movementtypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_movementtypeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.GetAllgen_movementtype"));
            }	
        }
		
		IList<gen_movementtypeEntity> Igen_movementtypeDataAccessObjects.GetAllByPages(gen_movementtypeEntity gen_movementtype)
        {
        try
            {
				const string SP = "gen_movementtype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_movementtype.SortExpression);
                    AddPageSizeParameter(cmd, gen_movementtype.PageSize);
                    AddCurrentPageParameter(cmd, gen_movementtype.CurrentPage);                    
                    FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_movementtype, cmd,Database);

                    IList<gen_movementtypeEntity> itemList = new List<gen_movementtypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_movementtypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_movementtype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.GetAllByPagesgen_movementtype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        gen_movementtypeEntity Igen_movementtypeDataAccessObjects.GetSingle(gen_movementtypeEntity gen_movementtype)
        {
           try
            {
				const string SP = "gen_movementtype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_movementtype, cmd, Database);
                    
                    IList<gen_movementtypeEntity> itemList = new List<gen_movementtypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_movementtypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.GetSinglegen_movementtype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<gen_movementtypeEntity> Igen_movementtypeDataAccessObjects.GAPgListView(gen_movementtypeEntity gen_movementtype)
        {
        try
            {
				const string SP = "gen_movementtype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_movementtype.SortExpression);
                    AddPageSizeParameter(cmd, gen_movementtype.PageSize);
                    AddCurrentPageParameter(cmd, gen_movementtype.CurrentPage);                    
                    FillSequrityParameters(gen_movementtype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_movementtype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_movementtype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_movementtype.strCommonSerachParam);

                    IList<gen_movementtypeEntity> itemList = new List<gen_movementtypeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new gen_movementtypeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_movementtype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_movementtypeDataAccess.GAPgListViewgen_movementtype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}