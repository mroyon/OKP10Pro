using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_organizationentityDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(stp_organizationentityEntity stp_organizationentity);
		
		long Update(stp_organizationentityEntity stp_organizationentity);
        
		long Delete(stp_organizationentityEntity stp_organizationentity);
		
        long SaveList(IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<stp_organizationentityEntity> GetAll(stp_organizationentityEntity stp_organizationentity);
		
		IList<stp_organizationentityEntity> GetAllByPages(stp_organizationentityEntity stp_organizationentity);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_arms(stp_organizationentityEntity masterEntity, IList<gen_armsEntity> listAdded, IList<gen_armsEntity> listUpdated, IList<gen_armsEntity> listDeleted);

        long SaveMasterDethr_svcinfo(stp_organizationentityEntity masterEntity, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);

        //long SaveMasterDethr_relativesworkinginmod(stp_organizationentityEntity masterEntity, IList<hr_relativesworkinginmodEntity> listAdded, IList<hr_relativesworkinginmodEntity> listUpdated, IList<hr_relativesworkinginmodEntity> listDeleted);

        long SaveMasterDetowin_userroledetlentitymap(stp_organizationentityEntity masterEntity, IList<owin_userroledetlentitymapEntity> listAdded, IList<owin_userroledetlentitymapEntity> listUpdated, IList<owin_userroledetlentitymapEntity> listDeleted);

        long SaveMasterDetstp_organizationentity(stp_organizationentityEntity masterEntity, IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted);

        long SaveMasterDetuseraccountsprof(stp_organizationentityEntity masterEntity, IList<useraccountsprofEntity> listAdded, IList<useraccountsprofEntity> listUpdated, IList<useraccountsprofEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         stp_organizationentityEntity  GetSingle(stp_organizationentityEntity stp_organizationentity);
         #endregion 
         
         #region ForListView Paged Method
         IList<stp_organizationentityEntity> GAPgListView(stp_organizationentityEntity stp_organizationentity);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
