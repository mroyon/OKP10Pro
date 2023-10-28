using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_emergencycontactDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_emergencycontactEntity hr_emergencycontact);
		
		long Update(hr_emergencycontactEntity hr_emergencycontact);
        
		long Delete(hr_emergencycontactEntity hr_emergencycontact);
		
        long SaveList(IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_emergencycontactEntity> GetAll(hr_emergencycontactEntity hr_emergencycontact);
		
		IList<hr_emergencycontactEntity> GetAllByPages(hr_emergencycontactEntity hr_emergencycontact);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_emergencycontactEntity  GetSingle(hr_emergencycontactEntity hr_emergencycontact);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_emergencycontactEntity> GAPgListView(hr_emergencycontactEntity hr_emergencycontact);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
