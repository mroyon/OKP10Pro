using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Itran_manpowerstatedetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
		
		long Update(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
        
		long Delete(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
		
        long SaveList(IList<tran_manpowerstatedetlEntity> listAdded, IList<tran_manpowerstatedetlEntity> listUpdated, IList<tran_manpowerstatedetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<tran_manpowerstatedetlEntity> GetAll(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
		
		IList<tran_manpowerstatedetlEntity> GetAllByPages(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         tran_manpowerstatedetlEntity  GetSingle(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<tran_manpowerstatedetlEntity> GAPgListView(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
