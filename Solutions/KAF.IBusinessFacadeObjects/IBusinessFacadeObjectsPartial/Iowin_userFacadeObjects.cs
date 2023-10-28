

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial
{
    [ServiceContract(Name = "Iowin_userFacadeObjects")]
    public  interface Iowin_userFacadeObjects : IDisposable
    {


        #region SearchUser	

        [OperationContract]
        IList<owin_userEntity> SearchUser(owin_userEntity owin_user);

        #endregion SearchUser


    }
}
