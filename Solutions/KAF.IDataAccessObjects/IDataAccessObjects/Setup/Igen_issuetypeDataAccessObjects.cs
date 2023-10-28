using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_issuetypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_issuetypeEntity gen_issuetype);
		
		long Update(gen_issuetypeEntity gen_issuetype);
        
		long Delete(gen_issuetypeEntity gen_issuetype);
		
        long SaveList(IList<gen_issuetypeEntity> listAdded, IList<gen_issuetypeEntity> listUpdated, IList<gen_issuetypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_issuetypeEntity> GetAll(gen_issuetypeEntity gen_issuetype);
		
		IList<gen_issuetypeEntity> GetAllByPages(gen_issuetypeEntity gen_issuetype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_issuetypeEntity  GetSingle(gen_issuetypeEntity gen_issuetype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_issuetypeEntity> GAPgListView(gen_issuetypeEntity gen_issuetype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
