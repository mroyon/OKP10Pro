

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_basicprofileFacadeObjects
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add_Ext(hr_basicprofileEntity hr_basicprofile);
        
		[OperationContract]
		long Update_Ext(hr_basicprofileEntity hr_basicprofile);
		
		[OperationContract]
		long Delete_Ext(hr_basicprofileEntity hr_basicprofile );
        
        [OperationContract]
        long SaveList_Ext(List<hr_basicprofileEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_basicprofileEntity> GetAll_Ext(hr_basicprofileEntity hr_basicprofile);
		
		[OperationContract]
        IList<hr_basicprofileEntity> GetAllByPages_Ext(hr_basicprofileEntity hr_basicprofile);
     
		#endregion GetAll
		
        
        
        
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_basicprofileEntity> GAPgListView_Ext(hr_basicprofileEntity hr_basicprofile);
         #endregion
         
        
    }
}
