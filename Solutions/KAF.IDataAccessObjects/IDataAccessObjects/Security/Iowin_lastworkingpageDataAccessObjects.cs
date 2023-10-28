using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_lastworkingpageDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_lastworkingpageEntity owin_lastworkingpage);
		
		long Update(owin_lastworkingpageEntity owin_lastworkingpage);
        
		long Delete(owin_lastworkingpageEntity owin_lastworkingpage);
		
        long SaveList(IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_lastworkingpageEntity> GetAll(owin_lastworkingpageEntity owin_lastworkingpage);
		
		IList<owin_lastworkingpageEntity> GetAllByPages(owin_lastworkingpageEntity owin_lastworkingpage);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_lastworkingpageEntity  GetSingle(owin_lastworkingpageEntity owin_lastworkingpage);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_lastworkingpageEntity> GAPgListView(owin_lastworkingpageEntity owin_lastworkingpage);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
