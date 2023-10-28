using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userroledetlentityprofilemapDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
		
		long Update(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
        
		long Delete(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
		
        long SaveList(IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userroledetlentityprofilemapEntity> GetAll(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
		
		IList<owin_userroledetlentityprofilemapEntity> GetAllByPages(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userroledetlentityprofilemapEntity  GetSingle(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userroledetlentityprofilemapEntity> GAPgListView(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
