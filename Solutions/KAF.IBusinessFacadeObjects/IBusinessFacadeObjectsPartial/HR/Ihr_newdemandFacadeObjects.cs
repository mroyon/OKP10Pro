

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_newdemandFacadeObjects
    { 
		
		[OperationContract]
		long Add_Ext(hr_newdemandEntity hr_newdemand);
        
		[OperationContract]
		long Update_Ext(hr_newdemandEntity hr_newdemand);
		
		[OperationContract]
		long Delete_Ext(hr_newdemandEntity hr_newdemand );
        
        [OperationContract]
        long SaveList_Ext(List<hr_newdemandEntity> list );  
		
		[OperationContract]
        IList<hr_newdemandEntity> GetAll_Ext(hr_newdemandEntity hr_newdemand);
		
		[OperationContract]
        IList<hr_newdemandEntity> GetAllByPages_Ext(hr_newdemandEntity hr_newdemand);

        [OperationContract]
        IList<hr_newdemandEntity> GAPgListView_Ext(hr_newdemandEntity hr_newdemand);
    }
}
