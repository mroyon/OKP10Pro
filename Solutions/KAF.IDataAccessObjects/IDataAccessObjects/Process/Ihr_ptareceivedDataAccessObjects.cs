using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_ptareceivedDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_ptareceivedEntity hr_ptareceived);
		
		long Update(hr_ptareceivedEntity hr_ptareceived);
        
		long Delete(hr_ptareceivedEntity hr_ptareceived);
		
        long SaveList(IList<hr_ptareceivedEntity> listAdded, IList<hr_ptareceivedEntity> listUpdated, IList<hr_ptareceivedEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_ptareceivedEntity> GetAll(hr_ptareceivedEntity hr_ptareceived);
		
		IList<hr_ptareceivedEntity> GetAllByPages(hr_ptareceivedEntity hr_ptareceived);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_flightinfo(hr_ptareceivedEntity masterEntity, IList<hr_flightinfoEntity> listAdded, IList<hr_flightinfoEntity> listUpdated, IList<hr_flightinfoEntity> listDeleted);

        long SaveMasterDethr_ptareceiveddetl(hr_ptareceivedEntity masterEntity, IList<hr_ptareceiveddetlEntity> listAdded, IList<hr_ptareceiveddetlEntity> listUpdated, IList<hr_ptareceiveddetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_ptareceivedEntity  GetSingle(hr_ptareceivedEntity hr_ptareceived);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_ptareceivedEntity> GAPgListView(hr_ptareceivedEntity hr_ptareceived);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
