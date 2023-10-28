

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_promotioninfoFacadeObjects")]
    public partial interface Ihr_promotioninfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_promotioninfoEntity hr_promotioninfo);
        
		[OperationContract]
		long Update(hr_promotioninfoEntity hr_promotioninfo);
		
		[OperationContract]
		long Delete(hr_promotioninfoEntity hr_promotioninfo );
        
        [OperationContract]
        long SaveList(List<hr_promotioninfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_promotioninfoEntity> GetAll(hr_promotioninfoEntity hr_promotioninfo);
		
		[OperationContract]
        IList<hr_promotioninfoEntity> GetAllByPages(hr_promotioninfoEntity hr_promotioninfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_promotioninfoEntity  GetSingle(hr_promotioninfoEntity hr_promotioninfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_promotioninfoEntity> GAPgListView(hr_promotioninfoEntity hr_promotioninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
