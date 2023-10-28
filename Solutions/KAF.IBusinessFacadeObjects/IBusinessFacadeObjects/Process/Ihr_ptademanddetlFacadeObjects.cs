

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_ptademanddetlFacadeObjects")]
    public partial interface Ihr_ptademanddetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_ptademanddetlEntity hr_ptademanddetl);
        
		[OperationContract]
		long Update(hr_ptademanddetlEntity hr_ptademanddetl);
		
		[OperationContract]
		long Delete(hr_ptademanddetlEntity hr_ptademanddetl );
        
        [OperationContract]
        long SaveList(List<hr_ptademanddetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_ptademanddetlEntity> GetAll(hr_ptademanddetlEntity hr_ptademanddetl);
		
		[OperationContract]
        IList<hr_ptademanddetlEntity> GetAllByPages(hr_ptademanddetlEntity hr_ptademanddetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_ptareceiveddetl(hr_ptademanddetlEntity Master, List<hr_ptareceiveddetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_ptademanddetlEntity  GetSingle(hr_ptademanddetlEntity hr_ptademanddetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_ptademanddetlEntity> GAPgListView(hr_ptademanddetlEntity hr_ptademanddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
