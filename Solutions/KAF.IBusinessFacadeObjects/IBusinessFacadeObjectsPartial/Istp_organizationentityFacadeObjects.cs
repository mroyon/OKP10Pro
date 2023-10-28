

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial
{
    [ServiceContract(Name = "Istp_organizationentityFacadeObjects")]
    public  interface Istp_organizationentityFacadeObjects : IDisposable
    {


        #region SearchUser	

        [OperationContract]
        IList<stp_organizationentityEntity> SearchUnit(stp_organizationentityEntity owin_user);

        #endregion SearchUser


    }
}
