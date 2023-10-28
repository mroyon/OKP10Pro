using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_leavemodificationDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_leavemodificationEntity hr_leavemodification);
		
		long Update(hr_leavemodificationEntity hr_leavemodification);
        
		long Delete(hr_leavemodificationEntity hr_leavemodification);
		
        long SaveList(IList<hr_leavemodificationEntity> listAdded, IList<hr_leavemodificationEntity> listUpdated, IList<hr_leavemodificationEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_leavemodificationEntity> GetAll(hr_leavemodificationEntity hr_leavemodification);
		
		IList<hr_leavemodificationEntity> GetAllByPages(hr_leavemodificationEntity hr_leavemodification);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_leavemodificationEntity  GetSingle(hr_leavemodificationEntity hr_leavemodification);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_leavemodificationEntity> GAPgListView(hr_leavemodificationEntity hr_leavemodification);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
