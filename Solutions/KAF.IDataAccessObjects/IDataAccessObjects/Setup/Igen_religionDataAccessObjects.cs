using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_religionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_religionEntity gen_religion);
		
		long Update(gen_religionEntity gen_religion);
        
		long Delete(gen_religionEntity gen_religion);
		
        long SaveList(IList<gen_religionEntity> listAdded, IList<gen_religionEntity> listUpdated, IList<gen_religionEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_religionEntity> GetAll(gen_religionEntity gen_religion);
		
		IList<gen_religionEntity> GetAllByPages(gen_religionEntity gen_religion);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_familyinfo(gen_religionEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_religionEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_religionEntity  GetSingle(gen_religionEntity gen_religion);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_religionEntity> GAPgListView(gen_religionEntity gen_religion);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
