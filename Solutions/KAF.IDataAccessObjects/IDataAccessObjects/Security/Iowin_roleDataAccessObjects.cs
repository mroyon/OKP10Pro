using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_roleDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_roleEntity owin_role);
		
		long Update(owin_roleEntity owin_role);
        
		long Delete(owin_roleEntity owin_role);
		
        long SaveList(IList<owin_roleEntity> listAdded, IList<owin_roleEntity> listUpdated, IList<owin_roleEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_roleEntity> GetAll(owin_roleEntity owin_role);
		
		IList<owin_roleEntity> GetAllByPages(owin_roleEntity owin_role);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_userroledetl(owin_roleEntity masterEntity, IList<owin_userroledetlEntity> listAdded, IList<owin_userroledetlEntity> listUpdated, IList<owin_userroledetlEntity> listDeleted);

        long SaveMasterDetowin_rolepermission(owin_roleEntity masterEntity, IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted);

        long SaveMasterDetowin_userrole(owin_roleEntity masterEntity, IList<owin_userroleEntity> listAdded, IList<owin_userroleEntity> listUpdated, IList<owin_userroleEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentitymap(owin_roleEntity masterEntity, IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentityprofilemap(owin_roleEntity masterEntity, IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_roleEntity  GetSingle(owin_roleEntity owin_role);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_roleEntity> GAPgListView(owin_roleEntity owin_role);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
