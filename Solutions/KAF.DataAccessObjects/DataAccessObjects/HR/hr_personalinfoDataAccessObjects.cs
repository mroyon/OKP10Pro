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
	
	internal sealed partial class hr_personalinfoDataAccessObjects : BaseDataAccess, Ihr_personalinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_personalinfoDataAccessObjects";
        
		public hr_personalinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_personalinfoEntity hr_personalinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_personalinfo.hrpersonalinfoid.HasValue)
				Database.AddInParameter(cmd, "@HrPersonalInfoID", DbType.Int64, hr_personalinfo.hrpersonalinfoid);
            if (forDelete) return;
			if (hr_personalinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_personalinfo.hrbasicid);
			if (hr_personalinfo.religionid.HasValue)
				Database.AddInParameter(cmd, "@ReligionID", DbType.Int64, hr_personalinfo.religionid);
			if (hr_personalinfo.bloodgroupid.HasValue)
				Database.AddInParameter(cmd, "@BloodGroupId", DbType.Int64, hr_personalinfo.bloodgroupid);
			if (hr_personalinfo.maritalstatusid.HasValue)
				Database.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, hr_personalinfo.maritalstatusid);
			if (hr_personalinfo.genderid.HasValue)
				Database.AddInParameter(cmd, "@GenderID", DbType.Int64, hr_personalinfo.genderid);
			if (hr_personalinfo.nationalityid.HasValue)
				Database.AddInParameter(cmd, "@NationalityID", DbType.Int64, hr_personalinfo.nationalityid);
			if (hr_personalinfo.buildingid.HasValue)
				Database.AddInParameter(cmd, "@BuildingID", DbType.Int64, hr_personalinfo.buildingid);
			if (hr_personalinfo.kwgovid.HasValue)
				Database.AddInParameter(cmd, "@KWGovID", DbType.Int64, hr_personalinfo.kwgovid);
			if (hr_personalinfo.kwareaid.HasValue)
				Database.AddInParameter(cmd, "@KWAreaID", DbType.Int64, hr_personalinfo.kwareaid);
			if (!(string.IsNullOrEmpty(hr_personalinfo.kwblockno)))
				Database.AddInParameter(cmd, "@KWBlockNo", DbType.String, hr_personalinfo.kwblockno);
			if (!(string.IsNullOrEmpty(hr_personalinfo.kwstreet)))
				Database.AddInParameter(cmd, "@KWStreet", DbType.String, hr_personalinfo.kwstreet);
			if (!(string.IsNullOrEmpty(hr_personalinfo.kwhouseno)))
				Database.AddInParameter(cmd, "@KWHouseNo", DbType.String, hr_personalinfo.kwhouseno);
			if (!(string.IsNullOrEmpty(hr_personalinfo.kwflatno)))
				Database.AddInParameter(cmd, "@KWFlatNo", DbType.String, hr_personalinfo.kwflatno);
			if (!(string.IsNullOrEmpty(hr_personalinfo.kwmobile)))
				Database.AddInParameter(cmd, "@KWMobile", DbType.String, hr_personalinfo.kwmobile);
			if (!(string.IsNullOrEmpty(hr_personalinfo.kwviber)))
				Database.AddInParameter(cmd, "@KWViber", DbType.String, hr_personalinfo.kwviber);
			if (!(string.IsNullOrEmpty(hr_personalinfo.personalemail)))
				Database.AddInParameter(cmd, "@PersonalEmail", DbType.String, hr_personalinfo.personalemail);
			if (!(string.IsNullOrEmpty(hr_personalinfo.officialemail)))
				Database.AddInParameter(cmd, "@OfficialEmail", DbType.String, hr_personalinfo.officialemail);
			if (hr_personalinfo.bdcurdivid.HasValue)
				Database.AddInParameter(cmd, "@BDCurDivID", DbType.Int64, hr_personalinfo.bdcurdivid);
			if (hr_personalinfo.bdcurcityid.HasValue)
				Database.AddInParameter(cmd, "@BDCurCityID", DbType.Int64, hr_personalinfo.bdcurcityid);
			if (hr_personalinfo.bdcurthanaid.HasValue)
				Database.AddInParameter(cmd, "@BDCurThanaID", DbType.Int64, hr_personalinfo.bdcurthanaid);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdcurpostoffice)))
				Database.AddInParameter(cmd, "@BDCurPostOffice", DbType.String, hr_personalinfo.bdcurpostoffice);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdcurroad)))
				Database.AddInParameter(cmd, "@BDCurRoad", DbType.String, hr_personalinfo.bdcurroad);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdcurhouse)))
				Database.AddInParameter(cmd, "@BDCurHouse", DbType.String, hr_personalinfo.bdcurhouse);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdcurflatno)))
				Database.AddInParameter(cmd, "@BDCurFlatNo", DbType.String, hr_personalinfo.bdcurflatno);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdmob1)))
				Database.AddInParameter(cmd, "@BDMob1", DbType.String, hr_personalinfo.bdmob1);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdmob2)))
				Database.AddInParameter(cmd, "@BDMob2", DbType.String, hr_personalinfo.bdmob2);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdhomephone)))
				Database.AddInParameter(cmd, "@BDHomePhone", DbType.String, hr_personalinfo.bdhomephone);
			if (hr_personalinfo.bdperdivid.HasValue)
				Database.AddInParameter(cmd, "@BDPerDivID", DbType.Int64, hr_personalinfo.bdperdivid);
			if (hr_personalinfo.bdpercityid.HasValue)
				Database.AddInParameter(cmd, "@BDPerCityID", DbType.Int64, hr_personalinfo.bdpercityid);
			if (hr_personalinfo.bdperthanaid.HasValue)
				Database.AddInParameter(cmd, "@BDPerThanaID", DbType.Int64, hr_personalinfo.bdperthanaid);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdperpostoffice)))
				Database.AddInParameter(cmd, "@BDPerPostOffice", DbType.String, hr_personalinfo.bdperpostoffice);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdperroad)))
				Database.AddInParameter(cmd, "@BDPerRoad", DbType.String, hr_personalinfo.bdperroad);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdperhouse)))
				Database.AddInParameter(cmd, "@BDPerHouse", DbType.String, hr_personalinfo.bdperhouse);
			if (!(string.IsNullOrEmpty(hr_personalinfo.bdperflatno)))
				Database.AddInParameter(cmd, "@BDPerFlatNo", DbType.String, hr_personalinfo.bdperflatno);
			if (!(string.IsNullOrEmpty(hr_personalinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_personalinfo.remarks);
			if ((hr_personalinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_personalinfo.ex_date1);
			if ((hr_personalinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_personalinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_personalinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_personalinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_personalinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_personalinfo.ex_nvarchar2);
			if (hr_personalinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_personalinfo.ex_bigint1);
			if (hr_personalinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_personalinfo.ex_bigint2);
			if (hr_personalinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_personalinfo.ex_decimal1);
			if (hr_personalinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_personalinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_personalinfoDataAccessObjects.Add(hr_personalinfoEntity hr_personalinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_personalinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_personalinfo, cmd,Database);
                FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Addhr_personalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_personalinfoDataAccessObjects.Update(hr_personalinfoEntity hr_personalinfo )
        {
           long returnCode = -99;
            const string SP = "hr_personalinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_personalinfo, cmd,Database);
                FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Updatehr_personalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_personalinfoDataAccessObjects.Delete(hr_personalinfoEntity hr_personalinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_personalinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_personalinfo, cmd,Database, true);
                FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Deletehr_personalinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_personalinfoDataAccessObjects.SaveList(IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_personalinfo_Ins";
            const string SPUpdate = "hr_personalinfo_Upd";
            const string SPDelete = "hr_personalinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_personalinfoEntity hr_personalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_personalinfo, cmd, Database, true);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_personalinfo, cmd, Database);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_personalinfo, cmd, Database);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Save_hr_personalinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_personalinfo_Ins";
            const string SPUpdate = "hr_personalinfo_Upd";
            const string SPDelete = "hr_personalinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_personalinfoEntity hr_personalinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_personalinfo, cmd, db, true);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_personalinfo, cmd, db);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_personalinfoEntity hr_personalinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_personalinfo, cmd, db);
                            FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.Save_hr_personalinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_personalinfoEntity> Ihr_personalinfoDataAccessObjects.GetAll(hr_personalinfoEntity hr_personalinfo)
        {
           try
            {
				const string SP = "hr_personalinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_personalinfo.SortExpression);
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_personalinfo, cmd, Database);
                    
                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GetAllhr_personalinfo"));
            }	
        }
		
		IList<hr_personalinfoEntity> Ihr_personalinfoDataAccessObjects.GetAllByPages(hr_personalinfoEntity hr_personalinfo)
        {
        try
            {
				const string SP = "hr_personalinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_personalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_personalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_personalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_personalinfo, cmd,Database);

                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_personalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GetAllByPageshr_personalinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        hr_personalinfoEntity Ihr_personalinfoDataAccessObjects.GetSingle(hr_personalinfoEntity hr_personalinfo)
        {
           try
            {
				const string SP = "hr_personalinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_personalinfo, cmd, Database);
                    
                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GetSinglehr_personalinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_personalinfoEntity> Ihr_personalinfoDataAccessObjects.GAPgListView(hr_personalinfoEntity hr_personalinfo)
        {
        try
            {
				const string SP = "hr_personalinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_personalinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_personalinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_personalinfo.CurrentPage);                    
                    FillSequrityParameters(hr_personalinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_personalinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_personalinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_personalinfo.strCommonSerachParam);

                    IList<hr_personalinfoEntity> itemList = new List<hr_personalinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_personalinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_personalinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_personalinfoDataAccess.GAPgListViewhr_personalinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}