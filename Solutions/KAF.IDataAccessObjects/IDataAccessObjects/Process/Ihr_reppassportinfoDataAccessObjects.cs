using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_reppassportinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_reppassportinfoEntity hr_reppassportinfo);
		
		long Update(hr_reppassportinfoEntity hr_reppassportinfo);
        
		long Delete(hr_reppassportinfoEntity hr_reppassportinfo);
		
        long SaveList(IList<hr_reppassportinfoEntity> listAdded, IList<hr_reppassportinfoEntity> listUpdated, IList<hr_reppassportinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_reppassportinfoEntity> GetAll(hr_reppassportinfoEntity hr_reppassportinfo);
		
		IList<hr_reppassportinfoEntity> GetAllByPages(hr_reppassportinfoEntity hr_reppassportinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_reppassportinfodetl(hr_reppassportinfoEntity masterEntity, IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_reppassportinfoEntity  GetSingle(hr_reppassportinfoEntity hr_reppassportinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_reppassportinfoEntity> GAPgListView(hr_reppassportinfoEntity hr_reppassportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
