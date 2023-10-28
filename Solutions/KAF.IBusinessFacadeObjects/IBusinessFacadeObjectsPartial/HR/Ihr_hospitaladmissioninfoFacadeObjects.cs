using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_hospitaladmissioninfoFacadeObjects
    {
       

        #region GetAll	

        [OperationContract]
        hr_hospitaladmissioninfoEntity GetCurrentActive(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);

        #endregion GetAll

    }
}