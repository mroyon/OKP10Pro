using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Istp_countryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(stp_countryEntity stp_country);
		
		long Update(stp_countryEntity stp_country);
        
		long Delete(stp_countryEntity stp_country);
		
        long SaveList(IList<stp_countryEntity> listAdded, IList<stp_countryEntity> listUpdated, IList<stp_countryEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<stp_countryEntity> GetAll(stp_countryEntity stp_country);
		
		IList<stp_countryEntity> GetAllByPages(stp_countryEntity stp_country);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetstp_countrycity(stp_countryEntity masterEntity, IList<stp_countrycityEntity> listAdded, IList<stp_countrycityEntity> listUpdated, IList<stp_countrycityEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         stp_countryEntity  GetSingle(stp_countryEntity stp_country);
         #endregion 
         
         #region ForListView Paged Method
         IList<stp_countryEntity> GAPgListView(stp_countryEntity stp_country);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
