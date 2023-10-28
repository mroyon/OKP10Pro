

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_arrivalinfodetlFacadeObjects")]
    public partial interface Ihr_arrivalinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
        
		[OperationContract]
		long Update(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
		
		[OperationContract]
		long Delete(hr_arrivalinfodetlEntity hr_arrivalinfodetl );
        
        [OperationContract]
        long SaveList(List<hr_arrivalinfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_arrivalinfodetlEntity> GetAll(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
		
		[OperationContract]
        IList<hr_arrivalinfodetlEntity> GetAllByPages(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_arrivalinfodetlEntity  GetSingle(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_arrivalinfodetlEntity> GAPgListView(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
