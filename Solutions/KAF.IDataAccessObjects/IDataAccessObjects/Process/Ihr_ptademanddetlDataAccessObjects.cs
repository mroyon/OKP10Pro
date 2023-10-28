using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_ptademanddetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_ptademanddetlEntity hr_ptademanddetl);
		
		long Update(hr_ptademanddetlEntity hr_ptademanddetl);
        
		long Delete(hr_ptademanddetlEntity hr_ptademanddetl);
		
        long SaveList(IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_ptademanddetlEntity> GetAll(hr_ptademanddetlEntity hr_ptademanddetl);
		
		IList<hr_ptademanddetlEntity> GetAllByPages(hr_ptademanddetlEntity hr_ptademanddetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_ptareceiveddetl(hr_ptademanddetlEntity masterEntity, IList<hr_ptareceiveddetlEntity> listAdded, IList<hr_ptareceiveddetlEntity> listUpdated, IList<hr_ptareceiveddetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_ptademanddetlEntity  GetSingle(hr_ptademanddetlEntity hr_ptademanddetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_ptademanddetlEntity> GAPgListView(hr_ptademanddetlEntity hr_ptademanddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
