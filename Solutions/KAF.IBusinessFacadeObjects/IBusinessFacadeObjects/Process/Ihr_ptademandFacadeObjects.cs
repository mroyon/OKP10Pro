

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_ptademandFacadeObjects")]
    public partial interface Ihr_ptademandFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_ptademandEntity hr_ptademand);
        
		[OperationContract]
		long Update(hr_ptademandEntity hr_ptademand);
		
		[OperationContract]
		long Delete(hr_ptademandEntity hr_ptademand );
        
        [OperationContract]
        long SaveList(List<hr_ptademandEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_ptademandEntity> GetAll(hr_ptademandEntity hr_ptademand);
		
		[OperationContract]
        IList<hr_ptademandEntity> GetAllByPages(hr_ptademandEntity hr_ptademand);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_ptademanddetl(hr_ptademandEntity Master, List<hr_ptademanddetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_ptareceived(hr_ptademandEntity Master, List<hr_ptareceivedEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_ptademandEntity  GetSingle(hr_ptademandEntity hr_ptademand);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_ptademandEntity> GAPgListView(hr_ptademandEntity hr_ptademand);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
