

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_emergencycontactFacadeObjects")]
    public partial interface Ihr_emergencycontactFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_emergencycontactEntity hr_emergencycontact);
        
		[OperationContract]
		long Update(hr_emergencycontactEntity hr_emergencycontact);
		
		[OperationContract]
		long Delete(hr_emergencycontactEntity hr_emergencycontact );
        
        [OperationContract]
        long SaveList(List<hr_emergencycontactEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_emergencycontactEntity> GetAll(hr_emergencycontactEntity hr_emergencycontact);
		
		[OperationContract]
        IList<hr_emergencycontactEntity> GetAllByPages(hr_emergencycontactEntity hr_emergencycontact);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_emergencycontactEntity  GetSingle(hr_emergencycontactEntity hr_emergencycontact);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_emergencycontactEntity> GAPgListView(hr_emergencycontactEntity hr_emergencycontact);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
