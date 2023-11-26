using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_familyresidentvisaDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_familyresidentvisaEntity hr_familyresidentvisa);
		
		long Update(hr_familyresidentvisaEntity hr_familyresidentvisa);
        
		long Delete(hr_familyresidentvisaEntity hr_familyresidentvisa);
		
        long SaveList(IList<hr_familyresidentvisaEntity> listAdded, IList<hr_familyresidentvisaEntity> listUpdated, IList<hr_familyresidentvisaEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_familyresidentvisaEntity> GetAll(hr_familyresidentvisaEntity hr_familyresidentvisa);
		
		IList<hr_familyresidentvisaEntity> GetAllByPages(hr_familyresidentvisaEntity hr_familyresidentvisa);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_familyresidentvisaEntity  GetSingle(hr_familyresidentvisaEntity hr_familyresidentvisa);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_familyresidentvisaEntity> GAPgListView(hr_familyresidentvisaEntity hr_familyresidentvisa);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
