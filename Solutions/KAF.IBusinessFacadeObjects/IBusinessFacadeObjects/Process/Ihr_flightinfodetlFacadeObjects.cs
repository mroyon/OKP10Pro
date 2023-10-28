

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_flightinfodetlFacadeObjects")]
    public partial interface Ihr_flightinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_flightinfodetlEntity hr_flightinfodetl);
        
		[OperationContract]
		long Update(hr_flightinfodetlEntity hr_flightinfodetl);
		
		[OperationContract]
		long Delete(hr_flightinfodetlEntity hr_flightinfodetl );

        [OperationContract]
        long Delete_ReIssue(hr_flightinfodetlEntity hr_flightinfodetl);


        [OperationContract]
        long SaveList(List<hr_flightinfodetlEntity> list);

        [OperationContract]
        long SaveCancelReIssueList(List<hr_flightinfodetlEntity> list);

        #endregion Save Update Delete List

        #region GetAll	

        [OperationContract]
        IList<hr_flightinfodetlEntity> GetAll(hr_flightinfodetlEntity hr_flightinfodetl);
		
		[OperationContract]
        IList<hr_flightinfodetlEntity> GetAllByPages(hr_flightinfodetlEntity hr_flightinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_arrivalinfodetl(hr_flightinfodetlEntity Master, List<hr_arrivalinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_flightinfodetlEntity  GetSingle(hr_flightinfodetlEntity hr_flightinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_flightinfodetlEntity> GAPgListView(hr_flightinfodetlEntity hr_flightinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
