using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_civilidinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_civilidinfoEntity hr_civilidinfo);
		
		long Update(hr_civilidinfoEntity hr_civilidinfo);
        
		long Delete(hr_civilidinfoEntity hr_civilidinfo);
		
        long SaveList(IList<hr_civilidinfoEntity> listAdded, IList<hr_civilidinfoEntity> listUpdated, IList<hr_civilidinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_civilidinfoEntity> GetAll(hr_civilidinfoEntity hr_civilidinfo);
		
		IList<hr_civilidinfoEntity> GetAllByPages(hr_civilidinfoEntity hr_civilidinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_civilidinfoEntity  GetSingle(hr_civilidinfoEntity hr_civilidinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_civilidinfoEntity> GAPgListView(hr_civilidinfoEntity hr_civilidinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
