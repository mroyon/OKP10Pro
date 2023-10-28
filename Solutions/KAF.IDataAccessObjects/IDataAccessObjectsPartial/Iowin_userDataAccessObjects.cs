using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userDataAccessObjects
    {

        #region SearchUser	

        IList<owin_userEntity> SearchUser(owin_userEntity owin_user);

        #endregion SearchUser


    }
}
