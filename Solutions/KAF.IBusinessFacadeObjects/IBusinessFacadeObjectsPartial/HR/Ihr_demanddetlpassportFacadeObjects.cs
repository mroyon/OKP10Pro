

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_demanddetlpassportFacadeObjects
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
        
		[OperationContract]
		long Update_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		[OperationContract]
		long Delete_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport );
        
        [OperationContract]
        long SaveList_Ext(List<hr_demanddetlpassportEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_demanddetlpassportEntity> GetAll_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		[OperationContract]
        IList<hr_demanddetlpassportEntity> GetAllByPages_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);


        [OperationContract]
        IList<hr_demanddetlpassportEntity> GetDemandPassportLetterNoByNewDemandID(hr_demanddetlpassportEntity hr_demanddetlpassport);

        #region ForListView Paged Method
        [OperationContract]
        IList<hr_demanddetlpassportEntity> GAPgListView_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
        #endregion
        #endregion GetAll

    }
}
