using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_arrivalinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
		
		long Update(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
        
		long Delete(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
		
        long SaveList(IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_arrivalinfodetlEntity> GetAll(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
		
		IList<hr_arrivalinfodetlEntity> GetAllByPages(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_arrivalinfodetlEntity  GetSingle(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_arrivalinfodetlEntity> GAPgListView(hr_arrivalinfodetlEntity hr_arrivalinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
