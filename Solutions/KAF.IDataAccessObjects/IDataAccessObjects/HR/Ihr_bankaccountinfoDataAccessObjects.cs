using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_bankaccountinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_bankaccountinfoEntity hr_bankaccountinfo);
		
		long Update(hr_bankaccountinfoEntity hr_bankaccountinfo);
        
		long Delete(hr_bankaccountinfoEntity hr_bankaccountinfo);
		
        long SaveList(IList<hr_bankaccountinfoEntity> listAdded, IList<hr_bankaccountinfoEntity> listUpdated, IList<hr_bankaccountinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_bankaccountinfoEntity> GetAll(hr_bankaccountinfoEntity hr_bankaccountinfo);
		
		IList<hr_bankaccountinfoEntity> GetAllByPages(hr_bankaccountinfoEntity hr_bankaccountinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_bankaccountinfoEntity  GetSingle(hr_bankaccountinfoEntity hr_bankaccountinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_bankaccountinfoEntity> GAPgListView(hr_bankaccountinfoEntity hr_bankaccountinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
