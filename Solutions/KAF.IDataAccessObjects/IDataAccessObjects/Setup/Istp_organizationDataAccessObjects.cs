using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_organizationDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(stp_organizationEntity stp_organization);
		
		long Update(stp_organizationEntity stp_organization);
        
		long Delete(stp_organizationEntity stp_organization);
		
        long SaveList(IList<stp_organizationEntity> listAdded, IList<stp_organizationEntity> listUpdated, IList<stp_organizationEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<stp_organizationEntity> GetAll(stp_organizationEntity stp_organization);
		
		IList<stp_organizationEntity> GetAllByPages(stp_organizationEntity stp_organization);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetstp_organizationentity(stp_organizationEntity masterEntity, IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted);

        long SaveMasterDetstp_organizationentitytype(stp_organizationEntity masterEntity, IList<stp_organizationentitytypeEntity> listAdded, IList<stp_organizationentitytypeEntity> listUpdated, IList<stp_organizationentitytypeEntity> listDeleted);

        long SaveMasterDetstp_passpolicy(stp_organizationEntity masterEntity, IList<stp_passpolicyEntity> listAdded, IList<stp_passpolicyEntity> listUpdated, IList<stp_passpolicyEntity> listDeleted);

        long SaveMasterDetuseraccountsprof(stp_organizationEntity masterEntity, IList<useraccountsprofEntity> listAdded, IList<useraccountsprofEntity> listUpdated, IList<useraccountsprofEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         stp_organizationEntity  GetSingle(stp_organizationEntity stp_organization);
         #endregion 
         
         #region ForListView Paged Method
         IList<stp_organizationEntity> GAPgListView(stp_organizationEntity stp_organization);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
