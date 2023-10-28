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
    /// Maxima Prince
    /// </summary>
	
	internal sealed partial class stp_organizationentityDataAccessObjects
    {
		
	   
		#region GetAll

        IList<stp_organizationentityEntity> Istp_organizationentityDataAccessObjects.SearchUnit(stp_organizationentityEntity stp_organizationentityEntity)
        {
           try
            {
				const string SP = "KAF_organizationentity_Search";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organizationentityEntity.SortExpression);
                    FillSequrityParameters(stp_organizationentityEntity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentityEntity, cmd, Database);
                    
                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SearchUnit"));
            }	
        }

        #endregion


    }
}