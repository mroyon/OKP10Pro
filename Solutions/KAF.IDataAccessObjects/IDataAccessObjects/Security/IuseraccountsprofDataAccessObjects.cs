using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface IuseraccountsprofDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(useraccountsprofEntity useraccountsprof);
		
		long Update(useraccountsprofEntity useraccountsprof);
        
		long Delete(useraccountsprofEntity useraccountsprof);
		
        long SaveList(IList<useraccountsprofEntity> listAdded, IList<useraccountsprofEntity> listUpdated, IList<useraccountsprofEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<useraccountsprofEntity> GetAll(useraccountsprofEntity useraccountsprof);
		
		IList<useraccountsprofEntity> GetAllByPages(useraccountsprofEntity useraccountsprof);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         useraccountsprofEntity  GetSingle(useraccountsprofEntity useraccountsprof);
         #endregion 
         
         #region ForListView Paged Method
         IList<useraccountsprofEntity> GAPgListView(useraccountsprofEntity useraccountsprof);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
