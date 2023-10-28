using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_familyjobinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_familyjobinfoEntity hr_familyjobinfo);
		
		long Update(hr_familyjobinfoEntity hr_familyjobinfo);
        
		long Delete(hr_familyjobinfoEntity hr_familyjobinfo);
		
        long SaveList(IList<hr_familyjobinfoEntity> listAdded, IList<hr_familyjobinfoEntity> listUpdated, IList<hr_familyjobinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_familyjobinfoEntity> GetAll(hr_familyjobinfoEntity hr_familyjobinfo);
		
		IList<hr_familyjobinfoEntity> GetAllByPages(hr_familyjobinfoEntity hr_familyjobinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_familyjobinfoEntity  GetSingle(hr_familyjobinfoEntity hr_familyjobinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_familyjobinfoEntity> GAPgListView(hr_familyjobinfoEntity hr_familyjobinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
