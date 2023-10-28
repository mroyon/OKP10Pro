using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_newdemandDataAccessObjects
    {
		long Add_Ext(hr_newdemandEntity hr_newdemand);
		long Update_Ext(hr_newdemandEntity hr_newdemand);
		long Delete_Ext(hr_newdemandEntity hr_newdemand);
        long SaveList_Ext(IList<hr_newdemandEntity> listAdded, IList<hr_newdemandEntity> listUpdated, IList<hr_newdemandEntity> listDeleted);               
		IList<hr_newdemandEntity> GetAll_Ext(hr_newdemandEntity hr_newdemand);
		IList<hr_newdemandEntity> GetAllByPages_Ext(hr_newdemandEntity hr_newdemand);
        IList<hr_newdemandEntity> GAPgListView_Ext(hr_newdemandEntity hr_newdemand);
    }
}
