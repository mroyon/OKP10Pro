using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_postofficeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_postofficeEntity gen_postoffice);
		
		long Update(gen_postofficeEntity gen_postoffice);
        
		long Delete(gen_postofficeEntity gen_postoffice);
		
        long SaveList(IList<gen_postofficeEntity> listAdded, IList<gen_postofficeEntity> listUpdated, IList<gen_postofficeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_postofficeEntity> GetAll(gen_postofficeEntity gen_postoffice);
		
		IList<gen_postofficeEntity> GetAllByPages(gen_postofficeEntity gen_postoffice);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_emergencycontact(gen_postofficeEntity masterEntity, IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_postofficeEntity  GetSingle(gen_postofficeEntity gen_postoffice);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_postofficeEntity> GAPgListView(gen_postofficeEntity gen_postoffice);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
