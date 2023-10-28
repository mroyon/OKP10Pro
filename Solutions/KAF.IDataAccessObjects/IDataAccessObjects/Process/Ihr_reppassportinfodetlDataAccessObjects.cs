using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_reppassportinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
		
		long Update(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
        
		long Delete(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
		
        long SaveList(IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_reppassportinfodetlEntity> GetAll(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
		
		IList<hr_reppassportinfodetlEntity> GetAllByPages(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_reppassportinfodetlEntity  GetSingle(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_reppassportinfodetlEntity> GAPgListView(hr_reppassportinfodetlEntity hr_reppassportinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
