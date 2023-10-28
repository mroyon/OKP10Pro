

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_passportinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		[OperationContract]
		long Add_Ext(hr_passportinfoEntity hr_passportinfo);
        
		[OperationContract]
		long Update_Ext(hr_passportinfoEntity hr_passportinfo);
		
		[OperationContract]
		long Delete_Ext(hr_passportinfoEntity hr_passportinfo );
        
        [OperationContract]
        long SaveList_Ext(List<hr_passportinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_passportinfoEntity> GetAll_Ext(hr_passportinfoEntity hr_passportinfo);
		
		[OperationContract]
        IList<hr_passportinfoEntity> GetAllByPages_Ext(hr_passportinfoEntity hr_passportinfo);
     
		#endregion GetAll
		
        
        #region Simple load Single Row
        [OperationContract]
        hr_passportinfoEntity GetSingle_Ext(hr_passportinfoEntity hr_passportinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_passportinfoEntity> GAPgListView_Ext(hr_passportinfoEntity hr_passportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
