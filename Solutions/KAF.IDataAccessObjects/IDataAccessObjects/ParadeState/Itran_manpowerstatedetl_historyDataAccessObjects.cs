using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Itran_manpowerstatedetl_historyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
		
		long Update(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
        
		long Delete(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
		
        long SaveList(IList<tran_manpowerstatedetl_historyEntity> listAdded, IList<tran_manpowerstatedetl_historyEntity> listUpdated, IList<tran_manpowerstatedetl_historyEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<tran_manpowerstatedetl_historyEntity> GetAll(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
		
		IList<tran_manpowerstatedetl_historyEntity> GetAllByPages(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         tran_manpowerstatedetl_historyEntity  GetSingle(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
         #endregion 
         
         #region ForListView Paged Method
         IList<tran_manpowerstatedetl_historyEntity> GAPgListView(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
