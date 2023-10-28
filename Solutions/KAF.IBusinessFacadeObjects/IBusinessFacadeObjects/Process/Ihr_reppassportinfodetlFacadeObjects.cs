

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_reppassportinfodetlFacadeObjects")]
    public partial interface Ihr_reppassportinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
        
		[OperationContract]
		long Update(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
		
		[OperationContract]
		long Delete(hr_reppassportinfodetlEntity hr_reppassportinfodetl );
        
        [OperationContract]
        long SaveList(List<hr_reppassportinfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_reppassportinfodetlEntity> GetAll(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
		
		[OperationContract]
        IList<hr_reppassportinfodetlEntity> GetAllByPages(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_reppassportinfodetlEntity  GetSingle(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_reppassportinfodetlEntity> GAPgListView(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
