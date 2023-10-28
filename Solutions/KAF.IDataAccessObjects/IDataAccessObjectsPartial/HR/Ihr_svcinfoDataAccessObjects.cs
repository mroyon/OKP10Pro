using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_svcinfoDataAccessObjects
    {
        
		long Add_Ext(hr_svcinfoEntity hr_svcinfo);
		
		long Update_Ext(hr_svcinfoEntity hr_svcinfo);
        
		long Delete_Ext(hr_svcinfoEntity hr_svcinfo);
        IList<hr_svcinfoEntity> GetAll_Ext(hr_svcinfoEntity hr_svcinfo);
        IList<hr_svcinfoEntity> GAPgListView_Ext(hr_svcinfoEntity hr_svcinfo);
        
    }
}
