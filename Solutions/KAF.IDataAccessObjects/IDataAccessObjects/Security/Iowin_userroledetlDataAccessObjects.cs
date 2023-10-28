using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userroledetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userroledetlEntity owin_userroledetl);
		
		long Update(owin_userroledetlEntity owin_userroledetl);
        
		long Delete(owin_userroledetlEntity owin_userroledetl);
		
        long SaveList(IList<owin_userroledetlEntity> listAdded, IList<owin_userroledetlEntity> listUpdated, IList<owin_userroledetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userroledetlEntity> GetAll(owin_userroledetlEntity owin_userroledetl);
		
		IList<owin_userroledetlEntity> GetAllByPages(owin_userroledetlEntity owin_userroledetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_userroledetlentitymap(owin_userroledetlEntity masterEntity, IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlEntity masterEntity, IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userroledetlEntity  GetSingle(owin_userroledetlEntity owin_userroledetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userroledetlEntity> GAPgListView(owin_userroledetlEntity owin_userroledetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
