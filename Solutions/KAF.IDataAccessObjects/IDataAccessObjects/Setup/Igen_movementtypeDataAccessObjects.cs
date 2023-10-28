using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_movementtypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_movementtypeEntity gen_movementtype);
		
		long Update(gen_movementtypeEntity gen_movementtype);
        
		long Delete(gen_movementtypeEntity gen_movementtype);
		
        long SaveList(IList<gen_movementtypeEntity> listAdded, IList<gen_movementtypeEntity> listUpdated, IList<gen_movementtypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_movementtypeEntity> GetAll(gen_movementtypeEntity gen_movementtype);
		
		IList<gen_movementtypeEntity> GetAllByPages(gen_movementtypeEntity gen_movementtype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_movementtypeEntity  GetSingle(gen_movementtypeEntity gen_movementtype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_movementtypeEntity> GAPgListView(gen_movementtypeEntity gen_movementtype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
