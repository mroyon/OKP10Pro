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
	
	internal sealed partial class hr_addresschangeDataAccessObjects : BaseDataAccess, Ihr_addresschangeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_addresschangeDataAccessObjects";
        
		public hr_addresschangeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_addresschangeEntity hr_addresschange, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_addresschange.addresschangeid.HasValue)
				Database.AddInParameter(cmd, "@AddressChangeID", DbType.Int64, hr_addresschange.addresschangeid);
            if (forDelete) return;
			if (hr_addresschange.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_addresschange.hrbasicid);
			if (hr_addresschange.buildingid.HasValue)
				Database.AddInParameter(cmd, "@BuildingID", DbType.Int64, hr_addresschange.buildingid);
			if (hr_addresschange.kwgovid.HasValue)
				Database.AddInParameter(cmd, "@KWGovID", DbType.Int64, hr_addresschange.kwgovid);
			if (hr_addresschange.kwareaid.HasValue)
				Database.AddInParameter(cmd, "@KWAreaID", DbType.Int64, hr_addresschange.kwareaid);
			if (!(string.IsNullOrEmpty(hr_addresschange.kwblockno)))
				Database.AddInParameter(cmd, "@KWBlockNo", DbType.String, hr_addresschange.kwblockno);
			if (!(string.IsNullOrEmpty(hr_addresschange.kwstreet)))
				Database.AddInParameter(cmd, "@KWStreet", DbType.String, hr_addresschange.kwstreet);
			if (!(string.IsNullOrEmpty(hr_addresschange.kwhouseno)))
				Database.AddInParameter(cmd, "@KWHouseNo", DbType.String, hr_addresschange.kwhouseno);
			if (!(string.IsNullOrEmpty(hr_addresschange.kwflatno)))
				Database.AddInParameter(cmd, "@KWFlatNo", DbType.String, hr_addresschange.kwflatno);
			if (!(string.IsNullOrEmpty(hr_addresschange.kwmobile)))
				Database.AddInParameter(cmd, "@KWMobile", DbType.String, hr_addresschange.kwmobile);
			if (!(string.IsNullOrEmpty(hr_addresschange.kwviber)))
				Database.AddInParameter(cmd, "@KWViber", DbType.String, hr_addresschange.kwviber);
			if (!(string.IsNullOrEmpty(hr_addresschange.personalemail)))
				Database.AddInParameter(cmd, "@PersonalEmail", DbType.String, hr_addresschange.personalemail);
			if (!(string.IsNullOrEmpty(hr_addresschange.officialemail)))
				Database.AddInParameter(cmd, "@OfficialEmail", DbType.String, hr_addresschange.officialemail);
			if (hr_addresschange.bdcurdivid.HasValue)
				Database.AddInParameter(cmd, "@BDCurDivID", DbType.Int64, hr_addresschange.bdcurdivid);
			if (hr_addresschange.bdcurcityid.HasValue)
				Database.AddInParameter(cmd, "@BDCurCityID", DbType.Int64, hr_addresschange.bdcurcityid);
			if (hr_addresschange.bdcurthanaid.HasValue)
				Database.AddInParameter(cmd, "@BDCurThanaID", DbType.Int64, hr_addresschange.bdcurthanaid);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdcurpostoffice)))
				Database.AddInParameter(cmd, "@BDCurPostOffice", DbType.String, hr_addresschange.bdcurpostoffice);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdcurroad)))
				Database.AddInParameter(cmd, "@BDCurRoad", DbType.String, hr_addresschange.bdcurroad);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdcurhouse)))
				Database.AddInParameter(cmd, "@BDCurHouse", DbType.String, hr_addresschange.bdcurhouse);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdcurflatno)))
				Database.AddInParameter(cmd, "@BDCurFlatNo", DbType.String, hr_addresschange.bdcurflatno);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdmob1)))
				Database.AddInParameter(cmd, "@BDMob1", DbType.String, hr_addresschange.bdmob1);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdmob2)))
				Database.AddInParameter(cmd, "@BDMob2", DbType.String, hr_addresschange.bdmob2);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdhomephone)))
				Database.AddInParameter(cmd, "@BDHomePhone", DbType.String, hr_addresschange.bdhomephone);
			if (hr_addresschange.bdperdivid.HasValue)
				Database.AddInParameter(cmd, "@BDPerDivID", DbType.Int64, hr_addresschange.bdperdivid);
			if (hr_addresschange.bdpercityid.HasValue)
				Database.AddInParameter(cmd, "@BDPerCityID", DbType.Int64, hr_addresschange.bdpercityid);
			if (hr_addresschange.bdperthanaid.HasValue)
				Database.AddInParameter(cmd, "@BDPerThanaID", DbType.Int64, hr_addresschange.bdperthanaid);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdperpostoffice)))
				Database.AddInParameter(cmd, "@BDPerPostOffice", DbType.String, hr_addresschange.bdperpostoffice);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdperroad)))
				Database.AddInParameter(cmd, "@BDPerRoad", DbType.String, hr_addresschange.bdperroad);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdperhouse)))
				Database.AddInParameter(cmd, "@BDPerHouse", DbType.String, hr_addresschange.bdperhouse);
			if (!(string.IsNullOrEmpty(hr_addresschange.bdperflatno)))
				Database.AddInParameter(cmd, "@BDPerFlatNo", DbType.String, hr_addresschange.bdperflatno);
			if (!(string.IsNullOrEmpty(hr_addresschange.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_addresschange.remarks);
			if ((hr_addresschange.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_addresschange.ex_date1);
			if ((hr_addresschange.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_addresschange.ex_date2);
			if (!(string.IsNullOrEmpty(hr_addresschange.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_addresschange.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_addresschange.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_addresschange.ex_nvarchar2);
			if (hr_addresschange.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_addresschange.ex_bigint1);
			if (hr_addresschange.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_addresschange.ex_bigint2);
			if (hr_addresschange.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_addresschange.ex_decimal1);
			if (hr_addresschange.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_addresschange.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_addresschangeDataAccessObjects.Add(hr_addresschangeEntity hr_addresschange  )
        {
            long returnCode = -99;
            const string SP = "hr_addresschange_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_addresschange, cmd,Database);
                FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.Addhr_addresschange"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_addresschangeDataAccessObjects.Update(hr_addresschangeEntity hr_addresschange )
        {
           long returnCode = -99;
            const string SP = "hr_addresschange_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_addresschange, cmd,Database);
                FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.Updatehr_addresschange"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_addresschangeDataAccessObjects.Delete(hr_addresschangeEntity hr_addresschange)
        {
            long returnCode = -99;
           	const string SP = "hr_addresschange_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_addresschange, cmd,Database, true);
                FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.Deletehr_addresschange"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_addresschangeDataAccessObjects.SaveList(IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_addresschange_Ins";
            const string SPUpdate = "hr_addresschange_Upd";
            const string SPDelete = "hr_addresschange_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_addresschangeEntity hr_addresschange in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_addresschange, cmd, Database, true);
                            FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_addresschangeEntity hr_addresschange in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_addresschange, cmd, Database);
                            FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_addresschangeEntity hr_addresschange in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_addresschange, cmd, Database);
                            FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.Save_hr_addresschange"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_addresschange_Ins";
            const string SPUpdate = "hr_addresschange_Upd";
            const string SPDelete = "hr_addresschange_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_addresschangeEntity hr_addresschange in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_addresschange, cmd, db, true);
                            FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, db);
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
                    foreach (hr_addresschangeEntity hr_addresschange in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_addresschange, cmd, db);
                            FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, db);
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
                    foreach (hr_addresschangeEntity hr_addresschange in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_addresschange, cmd, db);
                            FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.Save_hr_addresschange"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_addresschangeEntity> Ihr_addresschangeDataAccessObjects.GetAll(hr_addresschangeEntity hr_addresschange)
        {
           try
            {
				const string SP = "hr_addresschange_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_addresschange.SortExpression);
                    FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_addresschange, cmd, Database);
                    
                    IList<hr_addresschangeEntity> itemList = new List<hr_addresschangeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_addresschangeEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.GetAllhr_addresschange"));
            }	
        }
		
		IList<hr_addresschangeEntity> Ihr_addresschangeDataAccessObjects.GetAllByPages(hr_addresschangeEntity hr_addresschange)
        {
        try
            {
				const string SP = "hr_addresschange_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_addresschange.SortExpression);
                    AddPageSizeParameter(cmd, hr_addresschange.PageSize);
                    AddCurrentPageParameter(cmd, hr_addresschange.CurrentPage);                    
                    FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_addresschange, cmd,Database);

                    IList<hr_addresschangeEntity> itemList = new List<hr_addresschangeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_addresschangeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_addresschange.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.GetAllByPageshr_addresschange"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_addresschangeEntity Ihr_addresschangeDataAccessObjects.GetSingle(hr_addresschangeEntity hr_addresschange)
        {
           try
            {
				const string SP = "hr_addresschange_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_addresschange, cmd, Database);
                    
                    IList<hr_addresschangeEntity> itemList = new List<hr_addresschangeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_addresschangeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.GetSinglehr_addresschange"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_addresschangeEntity> Ihr_addresschangeDataAccessObjects.GAPgListView(hr_addresschangeEntity hr_addresschange)
        {
        try
            {
				const string SP = "hr_addresschange_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_addresschange.SortExpression);
                    AddPageSizeParameter(cmd, hr_addresschange.PageSize);
                    AddCurrentPageParameter(cmd, hr_addresschange.CurrentPage);                    
                    FillSequrityParameters(hr_addresschange.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_addresschange, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_addresschange.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_addresschange.strCommonSerachParam);

                    IList<hr_addresschangeEntity> itemList = new List<hr_addresschangeEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_addresschangeEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_addresschange.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_addresschangeDataAccess.GAPgListViewhr_addresschange"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}