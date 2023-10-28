using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_rewardinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_rewardinfoEntity hr_rewardinfo);
		
		long Update(hr_rewardinfoEntity hr_rewardinfo);
        
		long Delete(hr_rewardinfoEntity hr_rewardinfo);
		
        long SaveList(IList<hr_rewardinfoEntity> listAdded, IList<hr_rewardinfoEntity> listUpdated, IList<hr_rewardinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_rewardinfoEntity> GetAll(hr_rewardinfoEntity hr_rewardinfo);
		
		IList<hr_rewardinfoEntity> GetAllByPages(hr_rewardinfoEntity hr_rewardinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_rewardinfoEntity  GetSingle(hr_rewardinfoEntity hr_rewardinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_rewardinfoEntity> GAPgListView(hr_rewardinfoEntity hr_rewardinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
