

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_visaissueinfodetlFacadeObjects")]
    public partial interface Ihr_visaissueinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
        
		[OperationContract]
		long Update(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
		
		[OperationContract]
		long Delete(hr_visaissueinfodetlEntity hr_visaissueinfodetl );
        
        [OperationContract]
        long SaveList(List<hr_visaissueinfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_visaissueinfodetlEntity> GetAll(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
		
		[OperationContract]
        IList<hr_visaissueinfodetlEntity> GetAllByPages(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_visasentinfodetl(hr_visaissueinfodetlEntity Master, List<hr_visasentinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_visaissueinfodetlEntity  GetSingle(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_visaissueinfodetlEntity> GAPgListView(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
