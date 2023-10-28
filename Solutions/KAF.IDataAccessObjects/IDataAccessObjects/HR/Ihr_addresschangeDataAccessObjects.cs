using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_addresschangeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_addresschangeEntity hr_addresschange);
		
		long Update(hr_addresschangeEntity hr_addresschange);
        
		long Delete(hr_addresschangeEntity hr_addresschange);
		
        long SaveList(IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_addresschangeEntity> GetAll(hr_addresschangeEntity hr_addresschange);
		
		IList<hr_addresschangeEntity> GetAllByPages(hr_addresschangeEntity hr_addresschange);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_addresschangeEntity  GetSingle(hr_addresschangeEntity hr_addresschange);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_addresschangeEntity> GAPgListView(hr_addresschangeEntity hr_addresschange);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
