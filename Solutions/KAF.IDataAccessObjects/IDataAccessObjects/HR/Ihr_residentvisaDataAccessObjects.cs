using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_residentvisaDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_residentvisaEntity hr_residentvisa);
		
		long Update(hr_residentvisaEntity hr_residentvisa);
        
		long Delete(hr_residentvisaEntity hr_residentvisa);
		
        long SaveList(IList<hr_residentvisaEntity> listAdded, IList<hr_residentvisaEntity> listUpdated, IList<hr_residentvisaEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_residentvisaEntity> GetAll(hr_residentvisaEntity hr_residentvisa);
		
		IList<hr_residentvisaEntity> GetAllByPages(hr_residentvisaEntity hr_residentvisa);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_residentvisaEntity  GetSingle(hr_residentvisaEntity hr_residentvisa);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_residentvisaEntity> GAPgListView(hr_residentvisaEntity hr_residentvisa);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
