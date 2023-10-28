

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_ptareceiveddetlFacadeObjects")]
    public partial interface Ihr_ptareceiveddetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
        
		[OperationContract]
		long Update(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
		
		[OperationContract]
		long Delete(hr_ptareceiveddetlEntity hr_ptareceiveddetl );
        
        [OperationContract]
        long SaveList(List<hr_ptareceiveddetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_ptareceiveddetlEntity> GetAll(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
		
		[OperationContract]
        IList<hr_ptareceiveddetlEntity> GetAllByPages(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_flightinfodetl(hr_ptareceiveddetlEntity Master, List<hr_flightinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_ptareceiveddetlEntity  GetSingle(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_ptareceiveddetlEntity> GAPgListView(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
