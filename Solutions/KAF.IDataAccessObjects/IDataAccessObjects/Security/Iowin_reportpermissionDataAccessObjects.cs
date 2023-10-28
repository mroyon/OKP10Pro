using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_reportpermissionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_reportpermissionEntity owin_reportpermission);
		
		long Update(owin_reportpermissionEntity owin_reportpermission);
        
		long Delete(owin_reportpermissionEntity owin_reportpermission);
		
        long SaveList(IList<owin_reportpermissionEntity> listAdded, IList<owin_reportpermissionEntity> listUpdated, IList<owin_reportpermissionEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_reportpermissionEntity> GetAll(owin_reportpermissionEntity owin_reportpermission);
		
		IList<owin_reportpermissionEntity> GetAllByPages(owin_reportpermissionEntity owin_reportpermission);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_reportpermissionEntity  GetSingle(owin_reportpermissionEntity owin_reportpermission);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_reportpermissionEntity> GAPgListView(owin_reportpermissionEntity owin_reportpermission);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
