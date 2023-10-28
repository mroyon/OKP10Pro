

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_newdemanddetlFacadeObjects")]
    public partial interface Ihr_newdemanddetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_newdemanddetlEntity hr_newdemanddetl);
        
		[OperationContract]
		long Update(hr_newdemanddetlEntity hr_newdemanddetl);
		
		[OperationContract]
		long Delete(hr_newdemanddetlEntity hr_newdemanddetl );
        
        [OperationContract]
        long SaveList(List<hr_newdemanddetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_newdemanddetlEntity> GetAll(hr_newdemanddetlEntity hr_newdemanddetl);
		
		[OperationContract]
        IList<hr_newdemanddetlEntity> GetAllByPages(hr_newdemanddetlEntity hr_newdemanddetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_demanddetlpassport(hr_newdemanddetlEntity Master, List<hr_demanddetlpassportEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_newdemanddetlEntity  GetSingle(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_newdemanddetlEntity> GAPgListView(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
