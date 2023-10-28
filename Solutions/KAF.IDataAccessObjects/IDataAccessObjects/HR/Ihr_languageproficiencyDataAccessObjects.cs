using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_languageproficiencyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_languageproficiencyEntity hr_languageproficiency);
		
		long Update(hr_languageproficiencyEntity hr_languageproficiency);
        
		long Delete(hr_languageproficiencyEntity hr_languageproficiency);
		
        long SaveList(IList<hr_languageproficiencyEntity> listAdded, IList<hr_languageproficiencyEntity> listUpdated, IList<hr_languageproficiencyEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_languageproficiencyEntity> GetAll(hr_languageproficiencyEntity hr_languageproficiency);
		
		IList<hr_languageproficiencyEntity> GetAllByPages(hr_languageproficiencyEntity hr_languageproficiency);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_languageproficiencyEntity  GetSingle(hr_languageproficiencyEntity hr_languageproficiency);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_languageproficiencyEntity> GAPgListView(hr_languageproficiencyEntity hr_languageproficiency);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
