

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_reppassportinfoFacadeObjects")]
    public partial interface Ihr_reppassportinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_reppassportinfoEntity hr_reppassportinfo);
        
		[OperationContract]
		long Update(hr_reppassportinfoEntity hr_reppassportinfo);
		
		[OperationContract]
		long Delete(hr_reppassportinfoEntity hr_reppassportinfo );
        
        [OperationContract]
        long SaveList(List<hr_reppassportinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_reppassportinfoEntity> GetAll(hr_reppassportinfoEntity hr_reppassportinfo);
		
		[OperationContract]
        IList<hr_reppassportinfoEntity> GetAllByPages(hr_reppassportinfoEntity hr_reppassportinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_reppassportinfodetl(hr_reppassportinfoEntity Master, List<hr_reppassportinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_reppassportinfoEntity  GetSingle(hr_reppassportinfoEntity hr_reppassportinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_reppassportinfoEntity> GAPgListView(hr_reppassportinfoEntity hr_reppassportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
