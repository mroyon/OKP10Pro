

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_armsFacadeObjects")]
    public partial interface Igen_armsFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_armsEntity gen_arms);
        
		[OperationContract]
		long Update(gen_armsEntity gen_arms);
		
		[OperationContract]
		long Delete(gen_armsEntity gen_arms );
        
        [OperationContract]
        long SaveList(List<gen_armsEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_armsEntity> GetAll(gen_armsEntity gen_arms);
		
		[OperationContract]
        IList<gen_armsEntity> GetAllByPages(gen_armsEntity gen_arms);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_svcinfo(gen_armsEntity Master, List<hr_svcinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_armsEntity  GetSingle(gen_armsEntity gen_arms);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_armsEntity> GAPgListView(gen_armsEntity gen_arms);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
