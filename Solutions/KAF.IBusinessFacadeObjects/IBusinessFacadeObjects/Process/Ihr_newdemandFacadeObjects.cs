

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_newdemandFacadeObjects")]
    public partial interface Ihr_newdemandFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_newdemandEntity hr_newdemand);
        
		[OperationContract]
		long Update(hr_newdemandEntity hr_newdemand);
		
		[OperationContract]
		long Delete(hr_newdemandEntity hr_newdemand );
        
        [OperationContract]
        long SaveList(List<hr_newdemandEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_newdemandEntity> GetAll(hr_newdemandEntity hr_newdemand);
		
		[OperationContract]
        IList<hr_newdemandEntity> GetAllByPages(hr_newdemandEntity hr_newdemand);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_newdemanddetl(hr_newdemandEntity Master, List<hr_newdemanddetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_newdemandEntity  GetSingle(hr_newdemandEntity hr_newdemand);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_newdemandEntity> GAPgListView(hr_newdemandEntity hr_newdemand);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
