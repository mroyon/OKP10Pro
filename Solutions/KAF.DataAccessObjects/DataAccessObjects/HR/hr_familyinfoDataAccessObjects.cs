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
	
	internal sealed partial class hr_familyinfoDataAccessObjects : BaseDataAccess, Ihr_familyinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "hr_familyinfoDataAccessObjects";
        
		public hr_familyinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(hr_familyinfoEntity hr_familyinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (hr_familyinfo.hrfamilyid.HasValue)
				Database.AddInParameter(cmd, "@HrFamilyID", DbType.Int64, hr_familyinfo.hrfamilyid);
            if (forDelete) return;
			if (hr_familyinfo.hrbasicid.HasValue)
				Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_familyinfo.hrbasicid);
			if (hr_familyinfo.relationshipid.HasValue)
				Database.AddInParameter(cmd, "@RelationshipID", DbType.Int64, hr_familyinfo.relationshipid);
			if (hr_familyinfo.parenthrfamilyid.HasValue)
				Database.AddInParameter(cmd, "@ParentHrFamilyID", DbType.Int64, hr_familyinfo.parenthrfamilyid);
			if (hr_familyinfo.familycivilid.HasValue)
				Database.AddInParameter(cmd, "@FamilyCivilID", DbType.Int64, hr_familyinfo.familycivilid);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familynationalid)))
				Database.AddInParameter(cmd, "@FamilyNationalID", DbType.String, hr_familyinfo.familynationalid);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyname1)))
				Database.AddInParameter(cmd, "@FamilyName1", DbType.String, hr_familyinfo.familyname1);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyname2)))
				Database.AddInParameter(cmd, "@FamilyName2", DbType.String, hr_familyinfo.familyname2);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyname3)))
				Database.AddInParameter(cmd, "@FamilyName3", DbType.String, hr_familyinfo.familyname3);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyname4)))
				Database.AddInParameter(cmd, "@FamilyName4", DbType.String, hr_familyinfo.familyname4);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyname5)))
				Database.AddInParameter(cmd, "@FamilyName5", DbType.String, hr_familyinfo.familyname5);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyfullname)))
				Database.AddInParameter(cmd, "@FamilyFullName", DbType.String, hr_familyinfo.familyfullname);
			if (hr_familyinfo.familygenderid.HasValue)
				Database.AddInParameter(cmd, "@FamilyGenderID", DbType.Int64, hr_familyinfo.familygenderid);
			if (hr_familyinfo.familyreligionid.HasValue)
				Database.AddInParameter(cmd, "@FamilyReligionID", DbType.Int64, hr_familyinfo.familyreligionid);
			if (hr_familyinfo.familybloodgroupid.HasValue)
				Database.AddInParameter(cmd, "@FamilyBloodGroupID", DbType.Int64, hr_familyinfo.familybloodgroupid);
			if ((hr_familyinfo.familybirthdate.HasValue))
				Database.AddInParameter(cmd, "@FamilyBirthDate", DbType.DateTime, hr_familyinfo.familybirthdate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familybirthdocno)))
				Database.AddInParameter(cmd, "@FamilyBirthDocNo", DbType.String, hr_familyinfo.familybirthdocno);
			if ((hr_familyinfo.familybirthdocdate.HasValue))
				Database.AddInParameter(cmd, "@FamilyBirthDocDate", DbType.DateTime, hr_familyinfo.familybirthdocdate);
			if (hr_familyinfo.familycountryid.HasValue)
				Database.AddInParameter(cmd, "@FamilyCountryID", DbType.Int64, hr_familyinfo.familycountryid);
			if (hr_familyinfo.familynationalityid.HasValue)
				Database.AddInParameter(cmd, "@FamilyNationalityID", DbType.Int64, hr_familyinfo.familynationalityid);
			if (hr_familyinfo.familymaritalstatusid.HasValue)
				Database.AddInParameter(cmd, "@FamilyMaritalStatusID", DbType.Int64, hr_familyinfo.familymaritalstatusid);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familycuraddressflatno)))
				Database.AddInParameter(cmd, "@FamilyCurAddressFlatNo", DbType.String, hr_familyinfo.familycuraddressflatno);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familycuraddresshouseno)))
				Database.AddInParameter(cmd, "@FamilyCurAddressHouseNo", DbType.String, hr_familyinfo.familycuraddresshouseno);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familycuraddressstreet)))
				Database.AddInParameter(cmd, "@FamilyCurAddressStreet", DbType.String, hr_familyinfo.familycuraddressstreet);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familycuradrressblock)))
				Database.AddInParameter(cmd, "@FamilyCurAdrressBlock", DbType.String, hr_familyinfo.familycuradrressblock);
			if (hr_familyinfo.familycurcountryid.HasValue)
				Database.AddInParameter(cmd, "@FamilyCurCountryID", DbType.Int64, hr_familyinfo.familycurcountryid);
			if (hr_familyinfo.familycurgovnerid.HasValue)
				Database.AddInParameter(cmd, "@FamilyCurGovnerID", DbType.Int64, hr_familyinfo.familycurgovnerid);
			if (hr_familyinfo.familycurareaid.HasValue)
				Database.AddInParameter(cmd, "@FamilyCurAreaID", DbType.Int64, hr_familyinfo.familycurareaid);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familymobile1)))
				Database.AddInParameter(cmd, "@FamilyMobile1", DbType.String, hr_familyinfo.familymobile1);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familytelephone1)))
				Database.AddInParameter(cmd, "@FamilyTelephone1", DbType.String, hr_familyinfo.familytelephone1);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyperaddressflatno)))
				Database.AddInParameter(cmd, "@FamilyPerAddressFlatNo", DbType.String, hr_familyinfo.familyperaddressflatno);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyperaddresshouseno)))
				Database.AddInParameter(cmd, "@FamilyPerAddressHouseNo", DbType.String, hr_familyinfo.familyperaddresshouseno);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familyperaddressstreet)))
				Database.AddInParameter(cmd, "@FamilyPerAddressStreet", DbType.String, hr_familyinfo.familyperaddressstreet);
			if (hr_familyinfo.familyperadrresspo.HasValue)
				Database.AddInParameter(cmd, "@FamilyPerAdrressPO", DbType.Int64, hr_familyinfo.familyperadrresspo);
			if (hr_familyinfo.familyperadrressps.HasValue)
				Database.AddInParameter(cmd, "@FamilyPerAdrressPS", DbType.Int64, hr_familyinfo.familyperadrressps);
			if (hr_familyinfo.familyperaddressdist.HasValue)
				Database.AddInParameter(cmd, "@FamilyPerAddressDist", DbType.Int64, hr_familyinfo.familyperaddressdist);
			if (hr_familyinfo.familyperaddresscountryid.HasValue)
				Database.AddInParameter(cmd, "@FamilyPerAddressCountryID", DbType.Int64, hr_familyinfo.familyperaddresscountryid);
			if ((hr_familyinfo.familymarriagedate.HasValue))
				Database.AddInParameter(cmd, "@FamilyMarriageDate", DbType.DateTime, hr_familyinfo.familymarriagedate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familymarriagedocno)))
				Database.AddInParameter(cmd, "@FamilyMarriageDocNo", DbType.String, hr_familyinfo.familymarriagedocno);
			if ((hr_familyinfo.familymarriagedocdate.HasValue))
				Database.AddInParameter(cmd, "@FamilyMarriageDocDate", DbType.DateTime, hr_familyinfo.familymarriagedocdate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.marriagefiledescription)))
				Database.AddInParameter(cmd, "@MarriageFileDescription", DbType.String, hr_familyinfo.marriagefiledescription);
			if (!(string.IsNullOrEmpty(hr_familyinfo.marriagefilepath)))
				Database.AddInParameter(cmd, "@MarriageFilePath", DbType.String, hr_familyinfo.marriagefilepath);
			if (!(string.IsNullOrEmpty(hr_familyinfo.marriagefilename)))
				Database.AddInParameter(cmd, "@MarriageFileName", DbType.String, hr_familyinfo.marriagefilename);
			if (!(string.IsNullOrEmpty(hr_familyinfo.marriagefiletype)))
				Database.AddInParameter(cmd, "@MarriageFileType", DbType.String, hr_familyinfo.marriagefiletype);
			if (!(string.IsNullOrEmpty(hr_familyinfo.marriagefileextension)))
				Database.AddInParameter(cmd, "@MarriageFileExtension", DbType.String, hr_familyinfo.marriagefileextension);
			if (hr_familyinfo.marriageserialno.HasValue)
				Database.AddInParameter(cmd, "@MarriageSerialNo", DbType.Int64, hr_familyinfo.marriageserialno);
			if ((hr_familyinfo.divorcedate.HasValue))
				Database.AddInParameter(cmd, "@DivorceDate", DbType.DateTime, hr_familyinfo.divorcedate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.divorcedocno)))
				Database.AddInParameter(cmd, "@DivorceDocNo", DbType.String, hr_familyinfo.divorcedocno);
			if ((hr_familyinfo.divorcedocdate.HasValue))
				Database.AddInParameter(cmd, "@DivorceDocDate", DbType.DateTime, hr_familyinfo.divorcedocdate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.divorcefiledescription)))
				Database.AddInParameter(cmd, "@DivorceFileDescription", DbType.String, hr_familyinfo.divorcefiledescription);
			if (!(string.IsNullOrEmpty(hr_familyinfo.divorcefilepath)))
				Database.AddInParameter(cmd, "@DivorceFilePath", DbType.String, hr_familyinfo.divorcefilepath);
			if (!(string.IsNullOrEmpty(hr_familyinfo.divorcefilename)))
				Database.AddInParameter(cmd, "@DivorceFileName", DbType.String, hr_familyinfo.divorcefilename);
			if (!(string.IsNullOrEmpty(hr_familyinfo.divorcefiletype)))
				Database.AddInParameter(cmd, "@DivorceFileType", DbType.String, hr_familyinfo.divorcefiletype);
			if (!(string.IsNullOrEmpty(hr_familyinfo.divorcefileextension)))
				Database.AddInParameter(cmd, "@DivorceFileExtension", DbType.String, hr_familyinfo.divorcefileextension);
			if (hr_familyinfo.fatherstatusid.HasValue)
				Database.AddInParameter(cmd, "@FatherStatusID", DbType.Int64, hr_familyinfo.fatherstatusid);
			if ((hr_familyinfo.isservedinmilitary != null))
				Database.AddInParameter(cmd, "@IsServedInMilitary", DbType.Boolean, hr_familyinfo.isservedinmilitary);
			if (hr_familyinfo.fathermilitarynokw.HasValue)
				Database.AddInParameter(cmd, "@FatherMilitaryNoKW", DbType.Int64, hr_familyinfo.fathermilitarynokw);
			if (!(string.IsNullOrEmpty(hr_familyinfo.fathermilitarynobd)))
				Database.AddInParameter(cmd, "@FatherMilitaryNoBD", DbType.String, hr_familyinfo.fathermilitarynobd);
			if (!(string.IsNullOrEmpty(hr_familyinfo.workplace)))
				Database.AddInParameter(cmd, "@WorkPlace", DbType.String, hr_familyinfo.workplace);
			if (!(string.IsNullOrEmpty(hr_familyinfo.workdesignation)))
				Database.AddInParameter(cmd, "@WorkDesignation", DbType.String, hr_familyinfo.workdesignation);
			if ((hr_familyinfo.familydeathdate.HasValue))
				Database.AddInParameter(cmd, "@FamilyDeathDate", DbType.DateTime, hr_familyinfo.familydeathdate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familydeathdocno)))
				Database.AddInParameter(cmd, "@FamilyDeathDocNo", DbType.String, hr_familyinfo.familydeathdocno);
			if ((hr_familyinfo.familydeathdocdate.HasValue))
				Database.AddInParameter(cmd, "@FamilyDeathDocDate", DbType.DateTime, hr_familyinfo.familydeathdocdate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familydeathfiledescription)))
				Database.AddInParameter(cmd, "@FamilyDeathFileDescription", DbType.String, hr_familyinfo.familydeathfiledescription);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familydeathfilepath)))
				Database.AddInParameter(cmd, "@FamilyDeathFilePath", DbType.String, hr_familyinfo.familydeathfilepath);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familydeathfilename)))
				Database.AddInParameter(cmd, "@FamilyDeathFileName", DbType.String, hr_familyinfo.familydeathfilename);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familydeathfiletype)))
				Database.AddInParameter(cmd, "@FamilyDeathFileType", DbType.String, hr_familyinfo.familydeathfiletype);
			if (!(string.IsNullOrEmpty(hr_familyinfo.familydeathfileextension)))
				Database.AddInParameter(cmd, "@FamilyDeathFileExtension", DbType.String, hr_familyinfo.familydeathfileextension);
			if ((hr_familyinfo.separetiondate.HasValue))
				Database.AddInParameter(cmd, "@SeparetionDate", DbType.DateTime, hr_familyinfo.separetiondate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.separetionreason)))
				Database.AddInParameter(cmd, "@SeparetionReason", DbType.String, hr_familyinfo.separetionreason);
			if (!(string.IsNullOrEmpty(hr_familyinfo.separetiondocno)))
				Database.AddInParameter(cmd, "@SeparetionDocNo", DbType.String, hr_familyinfo.separetiondocno);
			if ((hr_familyinfo.separetiondocdate.HasValue))
				Database.AddInParameter(cmd, "@SeparetionDocDate", DbType.DateTime, hr_familyinfo.separetiondocdate);
			if (!(string.IsNullOrEmpty(hr_familyinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, hr_familyinfo.remarks);
			if (hr_familyinfo.forreview.HasValue)
				Database.AddInParameter(cmd, "@ForReview", DbType.Int32, hr_familyinfo.forreview);
			if ((hr_familyinfo.ex_date1.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, hr_familyinfo.ex_date1);
			if ((hr_familyinfo.ex_date2.HasValue))
				Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, hr_familyinfo.ex_date2);
			if (!(string.IsNullOrEmpty(hr_familyinfo.ex_nvarchar1)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, hr_familyinfo.ex_nvarchar1);
			if (!(string.IsNullOrEmpty(hr_familyinfo.ex_nvarchar2)))
				Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, hr_familyinfo.ex_nvarchar2);
			if (hr_familyinfo.ex_bigint1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, hr_familyinfo.ex_bigint1);
			if (hr_familyinfo.ex_bigint2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, hr_familyinfo.ex_bigint2);
			if (hr_familyinfo.ex_decimal1.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, hr_familyinfo.ex_decimal1);
			if (hr_familyinfo.ex_decimal2.HasValue)
				Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, hr_familyinfo.ex_decimal2);

        }
		
        
		#region Add Operation

        long Ihr_familyinfoDataAccessObjects.Add(hr_familyinfoEntity hr_familyinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_familyinfo_Ins";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(hr_familyinfo, cmd, Database);
                    FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.Addhr_familyinfo"));
                    }
                    cmd.Dispose();
                }

                if (returnCode > 0)
                {
                    //Passport
                    if (hr_familyinfo.hr_familypassportinfo != null)
                    {
                        hr_familyinfo.hr_familypassportinfo.hrfamilyid = returnCode;

                        string sp_passport = "hr_familypassportinfo_Ins";
                        long returnCode_passport = -99;
                        using (DbCommand cmd = Database.GetStoredProcCommand(sp_passport))
                        {
                            hr_familypassportinfoDataAccessObjects.FillParameters(hr_familyinfo.hr_familypassportinfo, cmd, Database);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            returnCode_passport = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode_passport < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }

                    //CivilId
                    if (hr_familyinfo.hr_familycivilidinfo != null)
                    {
                        hr_familyinfo.hr_familycivilidinfo.hrfamilyid = returnCode;
                        string sp_civilid = "hr_familycivilidinfo_Ins";
                        long returnCode_civilid = -99;
                        using (DbCommand cmd = Database.GetStoredProcCommand(sp_civilid))
                        {
                            hr_familycivilidinfoDataAccessObjects.FillParameters(hr_familyinfo.hr_familycivilidinfo, cmd, Database);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            returnCode_civilid = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode_civilid < 0)
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.Save_hr_familyinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_familyinfoDataAccessObjects.Update(hr_familyinfoEntity hr_familyinfo )
        {
           long returnCode = -99;
            const string SP = "hr_familyinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_familyinfo, cmd,Database);
                FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.Updatehr_familyinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_familyinfoDataAccessObjects.Delete(hr_familyinfoEntity hr_familyinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_familyinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_familyinfo, cmd,Database, true);
                FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.Deletehr_familyinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
		long Ihr_familyinfoDataAccessObjects.SaveList(IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familyinfo_Ins";
            const string SPUpdate = "hr_familyinfo_Upd";
            const string SPDelete = "hr_familyinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familyinfoEntity hr_familyinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familyinfo, cmd, Database, true);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familyinfoEntity hr_familyinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familyinfo, cmd, Database);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (hr_familyinfoEntity hr_familyinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familyinfo, cmd, Database);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.Save_hr_familyinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
        
       public long SaveList(Database db , DbTransaction transaction,IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted)
        {
            long returnCode = -99;

            const string SPInsert = "hr_familyinfo_Ins";
            const string SPUpdate = "hr_familyinfo_Upd";
            const string SPDelete = "hr_familyinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (hr_familyinfoEntity hr_familyinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(hr_familyinfo, cmd, db, true);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familyinfoEntity hr_familyinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(hr_familyinfo, cmd, db);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, db);
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
                    foreach (hr_familyinfoEntity hr_familyinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(hr_familyinfo, cmd, db);
                            FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.Save_hr_familyinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        IList<hr_familyinfoEntity> Ihr_familyinfoDataAccessObjects.GetAll(hr_familyinfoEntity hr_familyinfo)
        {
           try
            {
				const string SP = "hr_familyinfo_GA";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_familyinfo.SortExpression);
                    FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familyinfo, cmd, Database);
                    
                    IList<hr_familyinfoEntity> itemList = new List<hr_familyinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyinfoEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.GetAllhr_familyinfo"));
            }	
        }
		
		IList<hr_familyinfoEntity> Ihr_familyinfoDataAccessObjects.GetAllByPages(hr_familyinfoEntity hr_familyinfo)
        {
        try
            {
				const string SP = "hr_familyinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familyinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familyinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familyinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familyinfo, cmd,Database);

                    IList<hr_familyinfoEntity> itemList = new List<hr_familyinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familyinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.GetAllByPageshr_familyinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
          
        long Ihr_familyinfoDataAccessObjects.SaveMasterDethr_familyinfo(hr_familyinfoEntity masterEntity, 
        IList<hr_familyinfoEntity> listAdded, 
        IList<hr_familyinfoEntity> listUpdated,
        IList<hr_familyinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_familyinfo_Ins";
            const string MasterSPUpdate = "hr_familyinfo_Upd";
            const string MasterSPDelete = "hr_familyinfo_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.parenthrfamilyid=PrimaryKeyMaster;
                            }
                        }
                        hr_familyinfoDataAccessObjects objhr_familyinfo=new hr_familyinfoDataAccessObjects(this.Context);
                        objhr_familyinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.SaveDshr_familyinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
          
        long Ihr_familyinfoDataAccessObjects.SaveMasterDethr_familyjobinfo(hr_familyinfoEntity masterEntity, 
        IList<hr_familyjobinfoEntity> listAdded, 
        IList<hr_familyjobinfoEntity> listUpdated,
        IList<hr_familyjobinfoEntity> listDeleted)
        {
			long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "hr_familyinfo_Ins";
            const string MasterSPUpdate = "hr_familyinfo_Upd";
            const string MasterSPDelete = "hr_familyinfo_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.hrfamilyid=PrimaryKeyMaster;
                            }
                        }
                        hr_familyjobinfoDataAccessObjects objhr_familyjobinfo=new hr_familyjobinfoDataAccessObjects(this.Context);
                        objhr_familyjobinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.SaveDshr_familyinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        hr_familyinfoEntity Ihr_familyinfoDataAccessObjects.GetSingle(hr_familyinfoEntity hr_familyinfo)
        {
           try
            {
				const string SP = "hr_familyinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_familyinfo, cmd, Database);
                    
                    IList<hr_familyinfoEntity> itemList = new List<hr_familyinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.GetSinglehr_familyinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        IList<hr_familyinfoEntity> Ihr_familyinfoDataAccessObjects.GAPgListView(hr_familyinfoEntity hr_familyinfo)
        {
        try
            {
				const string SP = "hr_familyinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, hr_familyinfo.SortExpression);
                    AddPageSizeParameter(cmd, hr_familyinfo.PageSize);
                    AddCurrentPageParameter(cmd, hr_familyinfo.CurrentPage);                    
                    FillSequrityParameters(hr_familyinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(hr_familyinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (hr_familyinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_familyinfo.strCommonSerachParam);

                    IList<hr_familyinfoEntity> itemList = new List<hr_familyinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_familyinfoEntity(reader));
                        }
                        reader.Close();
					}
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						hr_familyinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_familyinfoDataAccess.GAPgListViewhr_familyinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}