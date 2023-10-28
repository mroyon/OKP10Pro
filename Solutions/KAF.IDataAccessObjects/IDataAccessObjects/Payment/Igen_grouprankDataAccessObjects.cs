using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_grouprankDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_grouprankEntity gen_grouprank);
		
		long Update(gen_grouprankEntity gen_grouprank);
        
		long Delete(gen_grouprankEntity gen_grouprank);
		
        long SaveList(IList<gen_grouprankEntity> listAdded, IList<gen_grouprankEntity> listUpdated, IList<gen_grouprankEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_grouprankEntity> GetAll(gen_grouprankEntity gen_grouprank);
		
		IList<gen_grouprankEntity> GetAllByPages(gen_grouprankEntity gen_grouprank);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_grouprankEntity  GetSingle(gen_grouprankEntity gen_grouprank);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_grouprankEntity> GAPgListView(gen_grouprankEntity gen_grouprank);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
