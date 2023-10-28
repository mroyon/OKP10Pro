

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_leavemodificationFacadeObjects")]
    public partial interface Ihr_leavemodificationFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_leavemodificationEntity hr_leavemodification);
        
		[OperationContract]
		long Update(hr_leavemodificationEntity hr_leavemodification);
		
		[OperationContract]
		long Delete(hr_leavemodificationEntity hr_leavemodification );
        
        [OperationContract]
        long SaveList(List<hr_leavemodificationEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_leavemodificationEntity> GetAll(hr_leavemodificationEntity hr_leavemodification);
		
		[OperationContract]
        IList<hr_leavemodificationEntity> GetAllByPages(hr_leavemodificationEntity hr_leavemodification);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_leavemodificationEntity  GetSingle(hr_leavemodificationEntity hr_leavemodification);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_leavemodificationEntity> GAPgListView(hr_leavemodificationEntity hr_leavemodification);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
