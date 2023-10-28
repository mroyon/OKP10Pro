using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_repatriationinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_repatriationinfoEntity hr_repatriationinfo);
		
		long Update(hr_repatriationinfoEntity hr_repatriationinfo);
        
		long Delete(hr_repatriationinfoEntity hr_repatriationinfo);
		
        long SaveList(IList<hr_repatriationinfoEntity> listAdded, IList<hr_repatriationinfoEntity> listUpdated, IList<hr_repatriationinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_repatriationinfoEntity> GetAll(hr_repatriationinfoEntity hr_repatriationinfo);
		
		IList<hr_repatriationinfoEntity> GetAllByPages(hr_repatriationinfoEntity hr_repatriationinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_repatriationinfoEntity  GetSingle(hr_repatriationinfoEntity hr_repatriationinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_repatriationinfoEntity> GAPgListView(hr_repatriationinfoEntity hr_repatriationinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
