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

    internal sealed partial class hr_hospitaladmissioninfoDataAccessObjects 
    {
        hr_hospitaladmissioninfoEntity Ihr_hospitaladmissioninfoDataAccessObjects.GetCurrentActive(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
            try
            {
                const string SP = "hr_hospitaladmissioninfo_GetCurrentActive";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    if (hr_hospitaladmissioninfo.hrbasicid.HasValue)
                        Database.AddInParameter(cmd, "@HrBasicID", DbType.Int64, hr_hospitaladmissioninfo.hrbasicid);

                    hr_hospitaladmissioninfoEntity itemList = new hr_hospitaladmissioninfoEntity();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList=new hr_hospitaladmissioninfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ihr_hospitaladmissioninfoDataAccess.GetAllhr_hospitaladmissioninfo"));
            }
        }
    }
}
