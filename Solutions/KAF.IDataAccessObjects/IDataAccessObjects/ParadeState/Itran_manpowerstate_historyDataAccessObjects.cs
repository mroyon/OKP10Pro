using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Itran_manpowerstate_historyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(tran_manpowerstate_historyEntity tran_manpowerstate_history);
		
		long Update(tran_manpowerstate_historyEntity tran_manpowerstate_history);
        
		long Delete(tran_manpowerstate_historyEntity tran_manpowerstate_history);
		
        long SaveList(IList<tran_manpowerstate_historyEntity> listAdded, IList<tran_manpowerstate_historyEntity> listUpdated, IList<tran_manpowerstate_historyEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<tran_manpowerstate_historyEntity> GetAll(tran_manpowerstate_historyEntity tran_manpowerstate_history);
		
		IList<tran_manpowerstate_historyEntity> GetAllByPages(tran_manpowerstate_historyEntity tran_manpowerstate_history);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         tran_manpowerstate_historyEntity  GetSingle(tran_manpowerstate_historyEntity tran_manpowerstate_history);
         #endregion 
         
         #region ForListView Paged Method
         IList<tran_manpowerstate_historyEntity> GAPgListView(tran_manpowerstate_historyEntity tran_manpowerstate_history);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        long UpdateReviewed(tran_manpowerstate_historyEntity tran_manpowerstate_history);
        #endregion        
        
    }
}
