using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_servicestatusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_servicestatusEntity gen_servicestatus);
		
		long Update(gen_servicestatusEntity gen_servicestatus);
        
		long Delete(gen_servicestatusEntity gen_servicestatus);
		
        long SaveList(IList<gen_servicestatusEntity> listAdded, IList<gen_servicestatusEntity> listUpdated, IList<gen_servicestatusEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_servicestatusEntity> GetAll(gen_servicestatusEntity gen_servicestatus);
		
		IList<gen_servicestatusEntity> GetAllByPages(gen_servicestatusEntity gen_servicestatus);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_servicestatusEntity  GetSingle(gen_servicestatusEntity gen_servicestatus);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_servicestatusEntity> GAPgListView(gen_servicestatusEntity gen_servicestatus);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
