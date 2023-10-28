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
	
	internal sealed partial class hr_emergencycontactDataAccessObjects : BaseDataAccess, Ihr_emergencycontactDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_emergencycontactDataAccessObjects";
        
		public hr_emergencycontactDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_emergencycontactEntity hr_emergencycontact, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_emergencycontact.emergencycontactid.HasValue)
				Database.AddInParameter(cmd, "@EmergencyContactID", DbType.Int64, hr_emergencycontact.emergencycontactid);
            if (forDelete) return;
			if (hr_emergencycontact.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_emergencycontact.hrbasicid);
			if (hr_emergencycontact.relationshipid.HasValue)
				Database.AddInParameter(cmd, "@RelationshipID", DbType.Int64, hr_emergencycontact.relationshipid);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.name1)))
				Database.AddInParameter(cmd, "@Name1", DbType.String, hr_emergencycontact.name1);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.name2)))
				Database.AddInParameter(cmd, "@Name2", DbType.String, hr_emergencycontact.name2);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.name3)))
				Database.AddInParameter(cmd, "@Name3", DbType.String, hr_emergencycontact.name3);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.name4)))
				Database.AddInParameter(cmd, "@Name4", DbType.String, hr_emergencycontact.name4);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.name5)))
				Database.AddInParameter(cmd, "@Name5", DbType.String, hr_emergencycontact.name5);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.fullname)))
				Database.AddInParameter(cmd, "@FullName", DbType.String, hr_emergencycontact.fullname);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curbdaddressflatno)))
				Database.AddInParameter(cmd, "@CurBDAddressFlatNo", DbType.String, hr_emergencycontact.curbdaddressflatno);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curbdaddresshouseno)))
				Database.AddInParameter(cmd, "@CurBDAddressHouseNo", DbType.String, hr_emergencycontact.curbdaddresshouseno);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curbdaddressstreet)))
				Database.AddInParameter(cmd, "@CurBDAddressStreet", DbType.String, hr_emergencycontact.curbdaddressstreet);
			if (hr_emergencycontact.curbdadrresspo.HasValue)
				Database.AddInParameter(cmd, "@CurBDAdrressPO", DbType.Int64, hr_emergencycontact.curbdadrresspo);
			if (hr_emergencycontact.curbdadrressps.HasValue)
				Database.AddInParameter(cmd, "@CurBDAdrressPS", DbType.Int64, hr_emergencycontact.curbdadrressps);
			if (hr_emergencycontact.curbdaddressdist.HasValue)
				Database.AddInParameter(cmd, "@CurBDAddressDist", DbType.Int64, hr_emergencycontact.curbdaddressdist);
			if (hr_emergencycontact.curbdaddressdivision.HasValue)
				Database.AddInParameter(cmd, "@CurBDAddressDivision", DbType.Int64, hr_emergencycontact.curbdaddressdivision);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.mobilebd)))
				Database.AddInParameter(cmd, "@MobileBD", DbType.String, hr_emergencycontact.mobilebd);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.telephonebd)))
				Database.AddInParameter(cmd, "@TelephoneBD", DbType.String, hr_emergencycontact.telephonebd);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.perbdaddressflatno)))
				Database.AddInParameter(cmd, "@PerBDAddressFlatNo", DbType.String, hr_emergencycontact.perbdaddressflatno);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.perbdaddresshouseno)))
				Database.AddInParameter(cmd, "@PerBDAddressHouseNo", DbType.String, hr_emergencycontact.perbdaddresshouseno);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.perbdaddressstreet)))
				Database.AddInParameter(cmd, "@PerBDAddressStreet", DbType.String, hr_emergencycontact.perbdaddressstreet);
			if (hr_emergencycontact.perbdadrresspo.HasValue)
				Database.AddInParameter(cmd, "@PerBDAdrressPO", DbType.Int64, hr_emergencycontact.perbdadrresspo);
			if (hr_emergencycontact.perbdadrressps.HasValue)
				Database.AddInParameter(cmd, "@PerBDAdrressPS", DbType.Int64, hr_emergencycontact.perbdadrressps);
			if (hr_emergencycontact.perbdaddressdivision.HasValue)
				Database.AddInParameter(cmd, "@PerBDAddressDivision", DbType.Int64, hr_emergencycontact.perbdaddressdivision);
			if (hr_emergencycontact.perbdaddressdist.HasValue)
				Database.AddInParameter(cmd, "@PerBDAddressDist", DbType.Int64, hr_emergencycontact.perbdaddressdist);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curkwaddressflatno)))
				Database.AddInParameter(cmd, "@CurKWAddressFlatNo", DbType.String, hr_emergencycontact.curkwaddressflatno);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curkwaddresshouseno)))
				Database.AddInParameter(cmd, "@CurKWAddressHouseNo", DbType.String, hr_emergencycontact.curkwaddresshouseno);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curkwaddressstreet)))
				Database.AddInParameter(cmd, "@CurKWAddressStreet", DbType.String, hr_emergencycontact.curkwaddressstreet);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curkwadrressblock)))
				Database.AddInParameter(cmd, "@CurKWAdrressBlock", DbType.String, hr_emergencycontact.curkwadrressblock);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.curkwadrressavenue)))
				Database.AddInParameter(cmd, "@CurKWAdrressAvenue", DbType.String, hr_emergencycontact.curkwadrressavenue);
			if (hr_emergencycontact.curkwgovnerid.HasValue)
				Database.AddInParameter(cmd, "@CurKWGovnerID", DbType.Int64, hr_emergencycontact.curkwgovnerid);
			if (hr_emergencycontact.curkwareaid.HasValue)
				Database.AddInParameter(cmd, "@CurKWAreaID", DbType.Int64, hr_emergencycontact.curkwareaid);
			if (hr_emergencycontact.curkwpacino.HasValue)
				Database.AddInParameter(cmd, "@CurKWPACINo", DbType.Int64, hr_emergencycontact.curkwpacino);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.mobilekw)))
				Database.AddInParameter(cmd, "@MobileKW", DbType.String, hr_emergencycontact.mobilekw);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.telephonekw)))
				Database.AddInParameter(cmd, "@TelephoneKW", DbType.String, hr_emergencycontact.telephonekw);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_emergencycontact.remarks);
			if ((hr_emergencycontact.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_emergencycontact.ex_date1);
			if ((hr_emergencycontact.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_emergencycontact.ex_date2);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_emergencycontact.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_emergencycontact.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_emergencycontact.ex_nvarchar2);
			if (hr_emergencycontact.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_emergencycontact.ex_bigint1);
			if (hr_emergencycontact.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_emergencycontact.ex_bigint2);
			if (hr_emergencycontact.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_emergencycontact.ex_decimal1);
			if (hr_emergencycontact.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_emergencycontact.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_emergencycontactDataAccessObjects.Add(hr_emergencycontactEntity hr_emergencycontact  )
        {
            long returnCode = -99;
            const string SP = "hr_emergencycontact_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_emergencycontact, cmd,Database);
                FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.Addhr_emergencycontact"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_emergencycontactDataAccessObjects.Update(hr_emergencycontactEntity hr_emergencycontact )
        {
           long returnCode = -99;
            const string SP = "hr_emergencycontact_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_emergencycontact, cmd,Database);
                FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.Updatehr_emergencycontact"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_emergencycontactDataAccessObjects.Delete(hr_emergencycontactEntity hr_emergencycontact)
        {
            long returnCode = -99;
           	const string SP = "hr_emergencycontact_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_emergencycontact, cmd,Database, true);
                FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.Deletehr_emergencycontact"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_emergencycontactDataAccessObjects.SaveList(IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_emergencycontact_Ins";
            const string SPUpdate = "hr_emergencycontact_Upd";
            const string SPDelete = "hr_emergencycontact_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_emergencycontactEntity hr_emergencycontact in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_emergencycontact, cmd, Database, true);
                            FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_emergencycontactEntity hr_emergencycontact in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_emergencycontact, cmd, Database);
                            FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_emergencycontactEntity hr_emergencycontact in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_emergencycontact, cmd, Database);
                            FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.Save_hr_emergencycontact"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_emergencycontact_Ins";
            const string SPUpdate = "hr_emergencycontact_Upd";
            const string SPDelete = "hr_emergencycontact_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_emergencycontactEntity hr_emergencycontact in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_emergencycontact, cmd, db, true);
                            FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, db);
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
                    foreach (hr_emergencycontactEntity hr_emergencycontact in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_emergencycontact, cmd, db);
                            FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, db);
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
                    foreach (hr_emergencycontactEntity hr_emergencycontact in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_emergencycontact, cmd, db);
                            FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.Save_hr_emergencycontact"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_emergencycontactEntity> Ihr_emergencycontactDataAccessObjects.GetAll(hr_emergencycontactEntity hr_emergencycontact)
        {
           try
            {
				const string SP = "hr_emergencycontact_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_emergencycontact.SortExpression);
                    FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_emergencycontact, cmd, Database);
                    
                    IList<hr_emergencycontactEntity> itemList = new List<hr_emergencycontactEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_emergencycontactEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.GetAllhr_emergencycontact"));
            }	
        }
		
		IList<hr_emergencycontactEntity> Ihr_emergencycontactDataAccessObjects.GetAllByPages(hr_emergencycontactEntity hr_emergencycontact)
        {
        try
            {
				const string SP = "hr_emergencycontact_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_emergencycontact.SortExpression);
                    AddPageSizeParameter(cmd, hr_emergencycontact.PageSize);
                    AddCurrentPageParameter(cmd, hr_emergencycontact.CurrentPage);                    
                    FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_emergencycontact, cmd,Database);

                    IList<hr_emergencycontactEntity> itemList = new List<hr_emergencycontactEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_emergencycontactEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_emergencycontact.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.GetAllByPageshr_emergencycontact"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_emergencycontactEntity Ihr_emergencycontactDataAccessObjects.GetSingle(hr_emergencycontactEntity hr_emergencycontact)
        {
           try
            {
				const string SP = "hr_emergencycontact_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_emergencycontact, cmd, Database);
                    
                    IList<hr_emergencycontactEntity> itemList = new List<hr_emergencycontactEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_emergencycontactEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.GetSinglehr_emergencycontact"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_emergencycontactEntity> Ihr_emergencycontactDataAccessObjects.GAPgListView(hr_emergencycontactEntity hr_emergencycontact)
        {
        try
            {
				const string SP = "hr_emergencycontact_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_emergencycontact.SortExpression);
                    AddPageSizeParameter(cmd, hr_emergencycontact.PageSize);
                    AddCurrentPageParameter(cmd, hr_emergencycontact.CurrentPage);                    
                    FillSequrityParameters(hr_emergencycontact.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_emergencycontact, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_emergencycontact.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_emergencycontact.strCommonSerachParam);

                    IList<hr_emergencycontactEntity> itemList = new List<hr_emergencycontactEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_emergencycontactEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_emergencycontact.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_emergencycontactDataAccess.GAPgListViewhr_emergencycontact"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}