using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_ptademandDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_ptademandEntity hr_ptademand);
		
		long Update(hr_ptademandEntity hr_ptademand);
        
		long Delete(hr_ptademandEntity hr_ptademand);
		
        long SaveList(IList<hr_ptademandEntity> listAdded, IList<hr_ptademandEntity> listUpdated, IList<hr_ptademandEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_ptademandEntity> GetAll(hr_ptademandEntity hr_ptademand);
		
		IList<hr_ptademandEntity> GetAllByPages(hr_ptademandEntity hr_ptademand);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_ptademanddetl(hr_ptademandEntity masterEntity, IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted);

        long SaveMasterDethr_ptareceived(hr_ptademandEntity masterEntity, IList<hr_ptareceivedEntity> listAdded, IList<hr_ptareceivedEntity> listUpdated, IList<hr_ptareceivedEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_ptademandEntity  GetSingle(hr_ptademandEntity hr_ptademand);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_ptademandEntity> GAPgListView(hr_ptademandEntity hr_ptademand);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
