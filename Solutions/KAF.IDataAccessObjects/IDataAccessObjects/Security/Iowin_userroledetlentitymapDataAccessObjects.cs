using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userroledetlentitymapDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
		
		long Update(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
        
		long Delete(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
		
        long SaveList(IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userroledetlentitymapEntity> GetAll(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
		
		IList<owin_userroledetlentitymapEntity> GetAllByPages(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlentitymapEntity masterEntity, IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userroledetlentitymapEntity  GetSingle(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userroledetlentitymapEntity> GAPgListView(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
