using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_passpolicyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(stp_passpolicyEntity stp_passpolicy);
		
		long Update(stp_passpolicyEntity stp_passpolicy);
        
		long Delete(stp_passpolicyEntity stp_passpolicy);
		
        long SaveList(IList<stp_passpolicyEntity> listAdded, IList<stp_passpolicyEntity> listUpdated, IList<stp_passpolicyEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<stp_passpolicyEntity> GetAll(stp_passpolicyEntity stp_passpolicy);
		
		IList<stp_passpolicyEntity> GetAllByPages(stp_passpolicyEntity stp_passpolicy);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         stp_passpolicyEntity  GetSingle(stp_passpolicyEntity stp_passpolicy);
         #endregion 
         
         #region ForListView Paged Method
         IList<stp_passpolicyEntity> GAPgListView(stp_passpolicyEntity stp_passpolicy);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
