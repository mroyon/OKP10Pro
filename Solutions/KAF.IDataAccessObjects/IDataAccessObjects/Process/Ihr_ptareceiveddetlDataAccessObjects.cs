using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_ptareceiveddetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
		
		long Update(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
        
		long Delete(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
		
        long SaveList(IList<hr_ptareceiveddetlEntity> listAdded, IList<hr_ptareceiveddetlEntity> listUpdated, IList<hr_ptareceiveddetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_ptareceiveddetlEntity> GetAll(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
		
		IList<hr_ptareceiveddetlEntity> GetAllByPages(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_flightinfodetl(hr_ptareceiveddetlEntity masterEntity, IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_ptareceiveddetlEntity  GetSingle(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_ptareceiveddetlEntity> GAPgListView(hr_ptareceiveddetlEntity hr_ptareceiveddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
