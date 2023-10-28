

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_rankFacadeObjects")]
    public partial interface Igen_rankFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_rankEntity gen_rank);
        
		[OperationContract]
		long Update(gen_rankEntity gen_rank);
		
		[OperationContract]
		long Delete(gen_rankEntity gen_rank );
        
        [OperationContract]
        long SaveList(List<gen_rankEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_rankEntity> GetAll(gen_rankEntity gen_rank);
		
		[OperationContract]
        IList<gen_rankEntity> GetAllByPages(gen_rankEntity gen_rank);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_promotioninfo(gen_rankEntity Master, List<hr_promotioninfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_newdemanddetl(gen_rankEntity Master, List<hr_newdemanddetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_svcinfo(gen_rankEntity Master, List<hr_svcinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_rankEntity  GetSingle(gen_rankEntity gen_rank);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_rankEntity> GAPgListView(gen_rankEntity gen_rank);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
