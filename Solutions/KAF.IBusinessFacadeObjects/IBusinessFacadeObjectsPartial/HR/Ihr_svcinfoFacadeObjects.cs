

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_svcinfoFacadeObjects 
    { 		
		[OperationContract]
		long Add_Ext(hr_svcinfoEntity hr_svcinfo);
        
		[OperationContract]
		long Update_Ext(hr_svcinfoEntity hr_svcinfo);
		
		[OperationContract]
		long Delete_Ext(hr_svcinfoEntity hr_svcinfo );

        [OperationContract]
        IList<hr_svcinfoEntity> GetAll_Ext(hr_svcinfoEntity hr_svcinfo);

        [OperationContract]
        IList<hr_svcinfoEntity> GAPgListView_Ext(hr_svcinfoEntity hr_svcinfo);
    }
}
