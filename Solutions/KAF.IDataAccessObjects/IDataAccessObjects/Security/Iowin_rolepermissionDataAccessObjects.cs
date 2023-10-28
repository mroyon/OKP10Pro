using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_rolepermissionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_rolepermissionEntity owin_rolepermission);
		
		long Update(owin_rolepermissionEntity owin_rolepermission);
        
		long Delete(owin_rolepermissionEntity owin_rolepermission);
		
        long SaveList(IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_rolepermissionEntity> GetAll(owin_rolepermissionEntity owin_rolepermission);
		
		IList<owin_rolepermissionEntity> GetAllByPages(owin_rolepermissionEntity owin_rolepermission);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_rolepermissionEntity  GetSingle(owin_rolepermissionEntity owin_rolepermission);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_rolepermissionEntity> GAPgListView(owin_rolepermissionEntity owin_rolepermission);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
