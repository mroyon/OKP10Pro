using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userEntity owin_user);
		
		long Update(owin_userEntity owin_user);
        
		long Delete(owin_userEntity owin_user);
		
        long SaveList(IList<owin_userEntity> listAdded, IList<owin_userEntity> listUpdated, IList<owin_userEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userEntity> GetAll(owin_userEntity owin_user);
		
		IList<owin_userEntity> GetAllByPages(owin_userEntity owin_user);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_lastworkingpage(owin_userEntity masterEntity, IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted);

        long SaveMasterDetowin_reportpermission(owin_userEntity masterEntity, IList<owin_reportpermissionEntity> listAdded, IList<owin_reportpermissionEntity> listUpdated, IList<owin_reportpermissionEntity> listDeleted);

        long SaveMasterDetowin_userroledetl(owin_userEntity masterEntity, IList<owin_userroledetlEntity> listAdded, IList<owin_userroledetlEntity> listUpdated, IList<owin_userroledetlEntity> listDeleted);

        long SaveMasterDetowin_tsv(owin_userEntity masterEntity, IList<owin_tsvEntity> listAdded, IList<owin_tsvEntity> listUpdated, IList<owin_tsvEntity> listDeleted);

        long SaveMasterDetowin_userlogintrail(owin_userEntity masterEntity, IList<owin_userlogintrailEntity> listAdded, IList<owin_userlogintrailEntity> listUpdated, IList<owin_userlogintrailEntity> listDeleted);

        long SaveMasterDetowin_userpasswordresetinfo(owin_userEntity masterEntity, IList<owin_userpasswordresetinfoEntity> listAdded, IList<owin_userpasswordresetinfoEntity> listUpdated, IList<owin_userpasswordresetinfoEntity> listDeleted);

        long SaveMasterDetowin_userprefferencessettings(owin_userEntity masterEntity, IList<owin_userprefferencessettingsEntity> listAdded, IList<owin_userprefferencessettingsEntity> listUpdated, IList<owin_userprefferencessettingsEntity> listDeleted);

        long SaveMasterDetowin_userrole(owin_userEntity masterEntity, IList<owin_userroleEntity> listAdded, IList<owin_userroleEntity> listUpdated, IList<owin_userroleEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentitymap(owin_userEntity masterEntity, IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userEntity masterEntity, IList<owin_userroledetlentityprofilemapEntity> listAdded, IList<owin_userroledetlentityprofilemapEntity> listUpdated, IList<owin_userroledetlentityprofilemapEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userEntity  GetSingle(owin_userEntity owin_user);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userEntity> GAPgListView(owin_userEntity owin_user);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        long UpdateReviewed(owin_userEntity owin_user);
        #endregion        
        
    }
}
