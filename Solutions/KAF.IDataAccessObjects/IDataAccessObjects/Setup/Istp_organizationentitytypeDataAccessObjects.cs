using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_organizationentitytypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(stp_organizationentitytypeEntity stp_organizationentitytype);
		
		long Update(stp_organizationentitytypeEntity stp_organizationentitytype);
        
		long Delete(stp_organizationentitytypeEntity stp_organizationentitytype);
		
        long SaveList(IList<stp_organizationentitytypeEntity> listAdded, IList<stp_organizationentitytypeEntity> listUpdated, IList<stp_organizationentitytypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<stp_organizationentitytypeEntity> GetAll(stp_organizationentitytypeEntity stp_organizationentitytype);
		
		IList<stp_organizationentitytypeEntity> GetAllByPages(stp_organizationentitytypeEntity stp_organizationentitytype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetstp_organizationentity(stp_organizationentitytypeEntity masterEntity, IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         stp_organizationentitytypeEntity  GetSingle(stp_organizationentitytypeEntity stp_organizationentitytype);
         #endregion 
         
         #region ForListView Paged Method
         IList<stp_organizationentitytypeEntity> GAPgListView(stp_organizationentitytypeEntity stp_organizationentitytype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
