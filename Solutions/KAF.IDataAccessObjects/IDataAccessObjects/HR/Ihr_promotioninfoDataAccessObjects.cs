using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_promotioninfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_promotioninfoEntity hr_promotioninfo);
		
		long Update(hr_promotioninfoEntity hr_promotioninfo);
        
		long Delete(hr_promotioninfoEntity hr_promotioninfo);
		
        long SaveList(IList<hr_promotioninfoEntity> listAdded, IList<hr_promotioninfoEntity> listUpdated, IList<hr_promotioninfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_promotioninfoEntity> GetAll(hr_promotioninfoEntity hr_promotioninfo);
		
		IList<hr_promotioninfoEntity> GetAllByPages(hr_promotioninfoEntity hr_promotioninfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_promotioninfoEntity  GetSingle(hr_promotioninfoEntity hr_promotioninfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_promotioninfoEntity> GAPgListView(hr_promotioninfoEntity hr_promotioninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
