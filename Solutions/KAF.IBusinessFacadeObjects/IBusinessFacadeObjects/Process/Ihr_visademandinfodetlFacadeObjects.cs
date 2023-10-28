

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_visademandinfodetlFacadeObjects")]
    public partial interface Ihr_visademandinfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_visademandinfodetlEntity hr_visademandinfodetl);
        
		[OperationContract]
		long Update(hr_visademandinfodetlEntity hr_visademandinfodetl);
		
		[OperationContract]
		long Delete(hr_visademandinfodetlEntity hr_visademandinfodetl );
        
        [OperationContract]
        long SaveList(List<hr_visademandinfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_visademandinfodetlEntity> GetAll(hr_visademandinfodetlEntity hr_visademandinfodetl);
		
		[OperationContract]
        IList<hr_visademandinfodetlEntity> GetAllByPages(hr_visademandinfodetlEntity hr_visademandinfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_visaissueinfodetl(hr_visademandinfodetlEntity Master, List<hr_visaissueinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_visademandinfodetlEntity  GetSingle(hr_visademandinfodetlEntity hr_visademandinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_visademandinfodetlEntity> GAPgListView(hr_visademandinfodetlEntity hr_visademandinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
