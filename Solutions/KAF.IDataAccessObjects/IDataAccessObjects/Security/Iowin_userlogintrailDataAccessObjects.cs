using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userlogintrailDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userlogintrailEntity owin_userlogintrail);
		
		long Update(owin_userlogintrailEntity owin_userlogintrail);
        
		long Delete(owin_userlogintrailEntity owin_userlogintrail);
		
        long SaveList(IList<owin_userlogintrailEntity> listAdded, IList<owin_userlogintrailEntity> listUpdated, IList<owin_userlogintrailEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userlogintrailEntity> GetAll(owin_userlogintrailEntity owin_userlogintrail);
		
		IList<owin_userlogintrailEntity> GetAllByPages(owin_userlogintrailEntity owin_userlogintrail);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userlogintrailEntity  GetSingle(owin_userlogintrailEntity owin_userlogintrail);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userlogintrailEntity> GAPgListView(owin_userlogintrailEntity owin_userlogintrail);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
