using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_leaveconfigDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_leaveconfigEntity gen_leaveconfig);
		
		long Update(gen_leaveconfigEntity gen_leaveconfig);
        
		long Delete(gen_leaveconfigEntity gen_leaveconfig);
		
        long SaveList(IList<gen_leaveconfigEntity> listAdded, IList<gen_leaveconfigEntity> listUpdated, IList<gen_leaveconfigEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_leaveconfigEntity> GetAll(gen_leaveconfigEntity gen_leaveconfig);
		
		IList<gen_leaveconfigEntity> GetAllByPages(gen_leaveconfigEntity gen_leaveconfig);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_leaveconfigEntity  GetSingle(gen_leaveconfigEntity gen_leaveconfig);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_leaveconfigEntity> GAPgListView(gen_leaveconfigEntity gen_leaveconfig);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
