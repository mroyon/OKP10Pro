

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_flightinfoFacadeObjects")]
    public partial interface Ihr_flightinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_flightinfoEntity hr_flightinfo);
        
		[OperationContract]
		long Update(hr_flightinfoEntity hr_flightinfo);
		
		[OperationContract]
		long Delete(hr_flightinfoEntity hr_flightinfo );
        
        [OperationContract]
        long SaveList(List<hr_flightinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_flightinfoEntity> GetAll(hr_flightinfoEntity hr_flightinfo);
		
		[OperationContract]
        IList<hr_flightinfoEntity> GetAllByPages(hr_flightinfoEntity hr_flightinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_arrivalinfo(hr_flightinfoEntity Master, List<hr_arrivalinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_flightinfodetl(hr_flightinfoEntity Master, List<hr_flightinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_flightinfoEntity  GetSingle(hr_flightinfoEntity hr_flightinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_flightinfoEntity> GAPgListView(hr_flightinfoEntity hr_flightinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
