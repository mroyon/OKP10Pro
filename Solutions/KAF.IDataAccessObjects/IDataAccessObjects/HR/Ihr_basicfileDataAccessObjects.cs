using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_basicfileDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_basicfileEntity hr_basicfile);
		
		long Update(hr_basicfileEntity hr_basicfile);
        
		long Delete(hr_basicfileEntity hr_basicfile);
		
        long SaveList(IList<hr_basicfileEntity> listAdded, IList<hr_basicfileEntity> listUpdated, IList<hr_basicfileEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_basicfileEntity> GetAll(hr_basicfileEntity hr_basicfile);
		
		IList<hr_basicfileEntity> GetAllByPages(hr_basicfileEntity hr_basicfile);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_basicfileEntity  GetSingle(hr_basicfileEntity hr_basicfile);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_basicfileEntity> GAPgListView(hr_basicfileEntity hr_basicfile);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
