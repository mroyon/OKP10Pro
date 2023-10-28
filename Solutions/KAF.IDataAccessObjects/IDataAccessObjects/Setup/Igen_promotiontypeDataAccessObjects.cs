using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_promotiontypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_promotiontypeEntity gen_promotiontype);
		
		long Update(gen_promotiontypeEntity gen_promotiontype);
        
		long Delete(gen_promotiontypeEntity gen_promotiontype);
		
        long SaveList(IList<gen_promotiontypeEntity> listAdded, IList<gen_promotiontypeEntity> listUpdated, IList<gen_promotiontypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_promotiontypeEntity> GetAll(gen_promotiontypeEntity gen_promotiontype);
		
		IList<gen_promotiontypeEntity> GetAllByPages(gen_promotiontypeEntity gen_promotiontype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_promotioninfo(gen_promotiontypeEntity masterEntity, IList<hr_promotioninfoEntity> listAdded, IList<hr_promotioninfoEntity> listUpdated, IList<hr_promotioninfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_promotiontypeEntity  GetSingle(gen_promotiontypeEntity gen_promotiontype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_promotiontypeEntity> GAPgListView(gen_promotiontypeEntity gen_promotiontype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
