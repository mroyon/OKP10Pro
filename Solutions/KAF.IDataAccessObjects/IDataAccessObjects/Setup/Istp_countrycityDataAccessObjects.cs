using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_countrycityDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(stp_countrycityEntity stp_countrycity);
		
		long Update(stp_countrycityEntity stp_countrycity);
        
		long Delete(stp_countrycityEntity stp_countrycity);
		
        long SaveList(IList<stp_countrycityEntity> listAdded, IList<stp_countrycityEntity> listUpdated, IList<stp_countrycityEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<stp_countrycityEntity> GetAll(stp_countrycityEntity stp_countrycity);
		
		IList<stp_countrycityEntity> GetAllByPages(stp_countrycityEntity stp_countrycity);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetstp_countrycity(stp_countrycityEntity masterEntity, IList<stp_countrycityEntity> listAdded, IList<stp_countrycityEntity> listUpdated, IList<stp_countrycityEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         stp_countrycityEntity  GetSingle(stp_countrycityEntity stp_countrycity);
         #endregion 
         
         #region ForListView Paged Method
         IList<stp_countrycityEntity> GAPgListView(stp_countrycityEntity stp_countrycity);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
