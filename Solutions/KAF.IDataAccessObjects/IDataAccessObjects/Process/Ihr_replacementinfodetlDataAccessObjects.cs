using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_replacementinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_replacementinfodetlEntity hr_replacementinfodetl);
		
		long Update(hr_replacementinfodetlEntity hr_replacementinfodetl);
        
		long Delete(hr_replacementinfodetlEntity hr_replacementinfodetl);
		
        long SaveList(IList<hr_replacementinfodetlEntity> listAdded, IList<hr_replacementinfodetlEntity> listUpdated, IList<hr_replacementinfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_replacementinfodetlEntity> GetAll(hr_replacementinfodetlEntity hr_replacementinfodetl);
		
		IList<hr_replacementinfodetlEntity> GetAllByPages(hr_replacementinfodetlEntity hr_replacementinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_reppassportinfodetl(hr_replacementinfodetlEntity masterEntity, IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_replacementinfodetlEntity  GetSingle(hr_replacementinfodetlEntity hr_replacementinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_replacementinfodetlEntity> GAPgListView(hr_replacementinfodetlEntity hr_replacementinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
