using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_authorizestrengthDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_authorizestrengthEntity gen_authorizestrength);
		
		long Update(gen_authorizestrengthEntity gen_authorizestrength);
        
		long Delete(gen_authorizestrengthEntity gen_authorizestrength);
		
        long SaveList(IList<gen_authorizestrengthEntity> listAdded, IList<gen_authorizestrengthEntity> listUpdated, IList<gen_authorizestrengthEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_authorizestrengthEntity> GetAll(gen_authorizestrengthEntity gen_authorizestrength);
		
		IList<gen_authorizestrengthEntity> GetAllByPages(gen_authorizestrengthEntity gen_authorizestrength);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_authorizestrengthEntity  GetSingle(gen_authorizestrengthEntity gen_authorizestrength);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_authorizestrengthEntity> GAPgListView(gen_authorizestrengthEntity gen_authorizestrength);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
