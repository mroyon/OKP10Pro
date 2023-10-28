
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using KAF.BusinessDataObjects;
using KAF.AppConfiguration.Configuration;
using KAF.DataAccessObjects;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessFacadeObjects
{
    public sealed partial class hr_hospitaladmissioninfoFacadeObjects 
    {


        #region ForListView Paged Method
        hr_hospitaladmissioninfoEntity Ihr_hospitaladmissioninfoFacadeObjects.GetCurrentActive(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
        {
            try
            {
                return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().GetCurrentActive(hr_hospitaladmissioninfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacade.GetCurrentActive"));
            }
        }
        #endregion

    }
}
