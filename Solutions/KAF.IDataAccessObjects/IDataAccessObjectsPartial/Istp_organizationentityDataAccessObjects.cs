using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_organizationentityDataAccessObjects
    {

        #region SearchUser	

        IList<stp_organizationentityEntity> SearchUnit(stp_organizationentityEntity owin_user);

        #endregion SearchUser


    }
}
