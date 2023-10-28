

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_ptareceivedFacadeObjects")]
    public partial interface Ihr_ptareceivedFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_ptareceivedEntity hr_ptareceived);
        
		[OperationContract]
		long Update(hr_ptareceivedEntity hr_ptareceived);
		
		[OperationContract]
		long Delete(hr_ptareceivedEntity hr_ptareceived );
        
        [OperationContract]
        long SaveList(List<hr_ptareceivedEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_ptareceivedEntity> GetAll(hr_ptareceivedEntity hr_ptareceived);
		
		[OperationContract]
        IList<hr_ptareceivedEntity> GetAllByPages(hr_ptareceivedEntity hr_ptareceived);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_flightinfo(hr_ptareceivedEntity Master, List<hr_flightinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_ptareceiveddetl(hr_ptareceivedEntity Master, List<hr_ptareceiveddetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_ptareceivedEntity  GetSingle(hr_ptareceivedEntity hr_ptareceived);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_ptareceivedEntity> GAPgListView(hr_ptareceivedEntity hr_ptareceived);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
