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
	
	internal sealed partial class hr_svcinfoDataAccessObjects 
	{
        public static void FillParameters_Ext(hr_svcinfoEntity hr_svcinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (!string.IsNullOrEmpty( hr_svcinfo.militarynobd))
                Database.AddInParameter(cmd, "@MilNoBD", DbType.String, hr_svcinfo.militarynobd);

            if (hr_svcinfo.civilid.HasValue)
                Database.AddInParameter(cmd, "@CivilID", DbType.Int64, hr_svcinfo.civilid);

            if (!string.IsNullOrEmpty(hr_svcinfo.goletterno))
                Database.AddInParameter(cmd, "@GoLetterNo", DbType.String, hr_svcinfo.goletterno);
            if ((hr_svcinfo.godate.HasValue))
                Database.AddInParameter(cmd, "@GoDate", DbType.DateTime, hr_svcinfo.godate);
            if ((hr_svcinfo.goexpdate.HasValue))
                Database.AddInParameter(cmd, "@GoExpDate", DbType.DateTime, hr_svcinfo.goexpdate);
            if ((hr_svcinfo.dateofbirth.HasValue))
                Database.AddInParameter(cmd, "@DateofBirth", DbType.DateTime, hr_svcinfo.dateofbirth);

            

            if (!(string.IsNullOrEmpty(hr_svcinfo.name1)))
                Database.AddInParameter(cmd, "@Name1", DbType.String, hr_svcinfo.name1);
            if (!(string.IsNullOrEmpty(hr_svcinfo.name2)))
                Database.AddInParameter(cmd, "@Name2", DbType.String, hr_svcinfo.name2);
            if (!(string.IsNullOrEmpty(hr_svcinfo.name3)))
                Database.AddInParameter(cmd, "@Name3", DbType.String, hr_svcinfo.name3);
            if (!(string.IsNullOrEmpty(hr_svcinfo.fullname)))
                Database.AddInParameter(cmd, "@FullName", DbType.String, hr_svcinfo.fullname);

            if ((hr_svcinfo.civilidexpiredate.HasValue))
                Database.AddInParameter(cmd, "@CivilIDExpireDate", DbType.DateTime, hr_svcinfo.civilidexpiredate);

            if (!(string.IsNullOrEmpty(hr_svcinfo.profilephoto)))
                Database.AddInParameter(cmd, "@ProfilePhoto", DbType.String, hr_svcinfo.profilephoto);
            if (!(string.IsNullOrEmpty(hr_svcinfo.profilephotofilepath)))
                Database.AddInParameter(cmd, "@ProfilePhotoFilePath", DbType.String, hr_svcinfo.profilephotofilepath);
            if (!(string.IsNullOrEmpty(hr_svcinfo.profilephotofilename)))
                Database.AddInParameter(cmd, "@ProfilePhotoFileName", DbType.String, hr_svcinfo.profilephotofilename);
            if (!(string.IsNullOrEmpty(hr_svcinfo.profilephotofiletype)))
                Database.AddInParameter(cmd, "@ProfilePhotoFileType", DbType.String, hr_svcinfo.profilephotofiletype);
            if (!(string.IsNullOrEmpty(hr_svcinfo.profilephotofileextension)))
                Database.AddInParameter(cmd, "@ProfilePhotoFileExtension", DbType.String, hr_svcinfo.profilephotofileextension);

        }

        #region Add Operation
        long Ihr_svcinfoDataAccessObjects.Add_Ext(hr_svcinfoEntity hr_svcinfo  )
        {
            long returnCode = -99;
            const string SP = "hr_basicprofile_InsExt";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_svcinfo, cmd,Database);
                FillParameters_Ext(hr_svcinfo, cmd, Database);
                FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                  	returnCode =Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Addhr_svcinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        long Ihr_svcinfoDataAccessObjects.Update_Ext(hr_svcinfoEntity hr_svcinfo )
        {
           long returnCode = -99;
            const string SP = "hr_basicprofile_UpdExt";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(hr_svcinfo, cmd,Database);
                FillParameters_Ext(hr_svcinfo, cmd, Database);
                FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Updatehr_svcinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        long Ihr_svcinfoDataAccessObjects.Delete_Ext(hr_svcinfoEntity hr_svcinfo)
        {
            long returnCode = -99;
           	const string SP = "hr_svcinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(hr_svcinfo, cmd,Database, true);
                FillParameters_Ext(hr_svcinfo, cmd, Database);
                FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	returnCode =  Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.Deletehr_svcinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation

		#region GetAll

        IList<hr_svcinfoEntity> Ihr_svcinfoDataAccessObjects.GetAll_Ext(hr_svcinfoEntity hr_svcinfo)
        {
           try
            {
				const string SP = "hr_basicprofile_GAExt";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, hr_svcinfo.SortExpression);
                    FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_svcinfo, cmd, Database);
                    FillParameters_Ext(hr_svcinfo, cmd, Database);

                    IList<hr_svcinfoEntity> itemList = new List<hr_svcinfoEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new hr_svcinfoEntity(reader, true, true));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.GetAllhr_svcinfo"));
            }	
        }

        IList<hr_svcinfoEntity> Ihr_svcinfoDataAccessObjects.GAPgListView_Ext(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                const string SP = "hr_basicprofile_GAPgListViewExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, hr_svcinfo.SortExpression);
                    FillSequrityParameters(hr_svcinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(hr_svcinfo, cmd, Database);
                    FillParameters_Ext(hr_svcinfo, cmd, Database);

                    IList<hr_svcinfoEntity> itemList = new List<hr_svcinfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_svcinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_svcinfoDataAccess.GetAllhr_svcinfo"));
            }
        }

        #endregion
    }
}