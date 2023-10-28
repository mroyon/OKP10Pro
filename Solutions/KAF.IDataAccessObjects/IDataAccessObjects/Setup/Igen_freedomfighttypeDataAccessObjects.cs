using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_freedomfighttypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_freedomfighttypeEntity gen_freedomfighttype);
		
		long Update(gen_freedomfighttypeEntity gen_freedomfighttype);
        
		long Delete(gen_freedomfighttypeEntity gen_freedomfighttype);
		
        long SaveList(IList<gen_freedomfighttypeEntity> listAdded, IList<gen_freedomfighttypeEntity> listUpdated, IList<gen_freedomfighttypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_freedomfighttypeEntity> GetAll(gen_freedomfighttypeEntity gen_freedomfighttype);
		
		IList<gen_freedomfighttypeEntity> GetAllByPages(gen_freedomfighttypeEntity gen_freedomfighttype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_freedomfighttypeEntity  GetSingle(gen_freedomfighttypeEntity gen_freedomfighttype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_freedomfighttypeEntity> GAPgListView(gen_freedomfighttypeEntity gen_freedomfighttype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
