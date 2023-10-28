using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_arrivalinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_arrivalinfoEntity hr_arrivalinfo);
		
		long Update(hr_arrivalinfoEntity hr_arrivalinfo);
        
		long Delete(hr_arrivalinfoEntity hr_arrivalinfo);
		
        long SaveList(IList<hr_arrivalinfoEntity> listAdded, IList<hr_arrivalinfoEntity> listUpdated, IList<hr_arrivalinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_arrivalinfoEntity> GetAll(hr_arrivalinfoEntity hr_arrivalinfo);
		
		IList<hr_arrivalinfoEntity> GetAllByPages(hr_arrivalinfoEntity hr_arrivalinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_arrivalinfodetl(hr_arrivalinfoEntity masterEntity, IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_arrivalinfoEntity  GetSingle(hr_arrivalinfoEntity hr_arrivalinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_arrivalinfoEntity> GAPgListView(hr_arrivalinfoEntity hr_arrivalinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
