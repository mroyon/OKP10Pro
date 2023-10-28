using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Itran_manpowerstateDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(tran_manpowerstateEntity tran_manpowerstate);
		
		long Update(tran_manpowerstateEntity tran_manpowerstate);
        
		long Delete(tran_manpowerstateEntity tran_manpowerstate);
		
        long SaveList(IList<tran_manpowerstateEntity> listAdded, IList<tran_manpowerstateEntity> listUpdated, IList<tran_manpowerstateEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<tran_manpowerstateEntity> GetAll(tran_manpowerstateEntity tran_manpowerstate);
		
		IList<tran_manpowerstateEntity> GetAllByPages(tran_manpowerstateEntity tran_manpowerstate);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDettran_manpowerstatedetl(tran_manpowerstateEntity masterEntity, IList<tran_manpowerstatedetlEntity> listAdded, IList<tran_manpowerstatedetlEntity> listUpdated, IList<tran_manpowerstatedetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         tran_manpowerstateEntity  GetSingle(tran_manpowerstateEntity tran_manpowerstate);
         #endregion 
         
         #region ForListView Paged Method
         IList<tran_manpowerstateEntity> GAPgListView(tran_manpowerstateEntity tran_manpowerstate);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        long UpdateReviewed(tran_manpowerstateEntity tran_manpowerstate);
        #endregion        
        
    }
}
