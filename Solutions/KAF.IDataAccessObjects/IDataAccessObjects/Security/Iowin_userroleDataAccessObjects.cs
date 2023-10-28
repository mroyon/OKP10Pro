using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userroleDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userroleEntity owin_userrole);
		
		long Update(owin_userroleEntity owin_userrole);
        
		long Delete(owin_userroleEntity owin_userrole);
		
        long SaveList(IList<owin_userroleEntity> listAdded, IList<owin_userroleEntity> listUpdated, IList<owin_userroleEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userroleEntity> GetAll(owin_userroleEntity owin_userrole);
		
		IList<owin_userroleEntity> GetAllByPages(owin_userroleEntity owin_userrole);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_userroledetl(owin_userroleEntity masterEntity, IList<owin_userroledetlEntity> listAdded, IList<owin_userroledetlEntity> listUpdated, IList<owin_userroledetlEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentitymap(owin_userroleEntity masterEntity, IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userroleEntity masterEntity, IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userroleEntity  GetSingle(owin_userroleEntity owin_userrole);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userroleEntity> GAPgListView(owin_userroleEntity owin_userrole);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
