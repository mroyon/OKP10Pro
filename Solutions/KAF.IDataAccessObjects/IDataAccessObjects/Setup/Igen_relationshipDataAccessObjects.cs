using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_relationshipDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_relationshipEntity gen_relationship);
		
		long Update(gen_relationshipEntity gen_relationship);
        
		long Delete(gen_relationshipEntity gen_relationship);
		
        long SaveList(IList<gen_relationshipEntity> listAdded, IList<gen_relationshipEntity> listUpdated, IList<gen_relationshipEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_relationshipEntity> GetAll(gen_relationshipEntity gen_relationship);
		
		IList<gen_relationshipEntity> GetAllByPages(gen_relationshipEntity gen_relationship);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_emergencycontact(gen_relationshipEntity masterEntity, IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);

        long SaveMasterDethr_familyinfo(gen_relationshipEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_relationshipEntity  GetSingle(gen_relationshipEntity gen_relationship);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_relationshipEntity> GAPgListView(gen_relationshipEntity gen_relationship);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
