using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_languageDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_languageEntity gen_language);
		
		long Update(gen_languageEntity gen_language);
        
		long Delete(gen_languageEntity gen_language);
		
        long SaveList(IList<gen_languageEntity> listAdded, IList<gen_languageEntity> listUpdated, IList<gen_languageEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_languageEntity> GetAll(gen_languageEntity gen_language);
		
		IList<gen_languageEntity> GetAllByPages(gen_languageEntity gen_language);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_languageproficiency(gen_languageEntity masterEntity, IList<hr_languageproficiencyEntity> listAdded, IList<hr_languageproficiencyEntity> listUpdated, IList<hr_languageproficiencyEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_languageEntity  GetSingle(gen_languageEntity gen_language);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_languageEntity> GAPgListView(gen_languageEntity gen_language);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
