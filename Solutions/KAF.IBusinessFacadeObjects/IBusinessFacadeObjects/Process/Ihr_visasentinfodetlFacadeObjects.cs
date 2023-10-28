

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_visasentinfodetlFacadeObjects")]
    public partial interface Ihr_visasentinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_visasentinfodetlEntity hr_visasentinfodetl);
        
		[OperationContract]
		long Update(hr_visasentinfodetlEntity hr_visasentinfodetl);
		
		[OperationContract]
		long Delete(hr_visasentinfodetlEntity hr_visasentinfodetl );
        
        [OperationContract]
        long SaveList(List<hr_visasentinfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_visasentinfodetlEntity> GetAll(hr_visasentinfodetlEntity hr_visasentinfodetl);
		
		[OperationContract]
        IList<hr_visasentinfodetlEntity> GetAllByPages(hr_visasentinfodetlEntity hr_visasentinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_ptademanddetl(hr_visasentinfodetlEntity Master, List<hr_ptademanddetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_visasentinfodetlEntity  GetSingle(hr_visasentinfodetlEntity hr_visasentinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_visasentinfodetlEntity> GAPgListView(hr_visasentinfodetlEntity hr_visasentinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
