using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userstatuschangehistoryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
		
		long Update(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
        
		long Delete(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
		
        long SaveList(IList<owin_userstatuschangehistoryEntity> listAdded, IList<owin_userstatuschangehistoryEntity> listUpdated, IList<owin_userstatuschangehistoryEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userstatuschangehistoryEntity> GetAll(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
		
		IList<owin_userstatuschangehistoryEntity> GetAllByPages(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userstatuschangehistoryEntity  GetSingle(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userstatuschangehistoryEntity> GAPgListView(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
