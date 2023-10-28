

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_promotiontypeFacadeObjects")]
    public partial interface Igen_promotiontypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_promotiontypeEntity gen_promotiontype);
        
		[OperationContract]
		long Update(gen_promotiontypeEntity gen_promotiontype);
		
		[OperationContract]
		long Delete(gen_promotiontypeEntity gen_promotiontype );
        
        [OperationContract]
        long SaveList(List<gen_promotiontypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_promotiontypeEntity> GetAll(gen_promotiontypeEntity gen_promotiontype);
		
		[OperationContract]
        IList<gen_promotiontypeEntity> GetAllByPages(gen_promotiontypeEntity gen_promotiontype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_promotioninfo(gen_promotiontypeEntity Master, List<hr_promotioninfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_promotiontypeEntity  GetSingle(gen_promotiontypeEntity gen_promotiontype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_promotiontypeEntity> GAPgListView(gen_promotiontypeEntity gen_promotiontype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
