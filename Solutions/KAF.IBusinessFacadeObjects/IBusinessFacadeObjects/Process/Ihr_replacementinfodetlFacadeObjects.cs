

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_replacementinfodetlFacadeObjects")]
    public partial interface Ihr_replacementinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_replacementinfodetlEntity hr_replacementinfodetl);
        
		[OperationContract]
		long Update(hr_replacementinfodetlEntity hr_replacementinfodetl);
		
		[OperationContract]
		long Delete(hr_replacementinfodetlEntity hr_replacementinfodetl );
        
        [OperationContract]
        long SaveList(List<hr_replacementinfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_replacementinfodetlEntity> GetAll(hr_replacementinfodetlEntity hr_replacementinfodetl);
		
		[OperationContract]
        IList<hr_replacementinfodetlEntity> GetAllByPages(hr_replacementinfodetlEntity hr_replacementinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_reppassportinfodetl(hr_replacementinfodetlEntity Master, List<hr_reppassportinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_replacementinfodetlEntity  GetSingle(hr_replacementinfodetlEntity hr_replacementinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_replacementinfodetlEntity> GAPgListView(hr_replacementinfodetlEntity hr_replacementinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
