using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_languageproficiencyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_languageproficiencyEntity gen_languageproficiency);
		
		long Update(gen_languageproficiencyEntity gen_languageproficiency);
        
		long Delete(gen_languageproficiencyEntity gen_languageproficiency);
		
        long SaveList(IList<gen_languageproficiencyEntity> listAdded, IList<gen_languageproficiencyEntity> listUpdated, IList<gen_languageproficiencyEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_languageproficiencyEntity> GetAll(gen_languageproficiencyEntity gen_languageproficiency);
		
		IList<gen_languageproficiencyEntity> GetAllByPages(gen_languageproficiencyEntity gen_languageproficiency);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_languageproficiency(gen_languageproficiencyEntity masterEntity, IList<hr_languageproficiencyEntity> listAdded, IList<hr_languageproficiencyEntity> listUpdated, IList<hr_languageproficiencyEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_languageproficiencyEntity  GetSingle(gen_languageproficiencyEntity gen_languageproficiency);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_languageproficiencyEntity> GAPgListView(gen_languageproficiencyEntity gen_languageproficiency);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
