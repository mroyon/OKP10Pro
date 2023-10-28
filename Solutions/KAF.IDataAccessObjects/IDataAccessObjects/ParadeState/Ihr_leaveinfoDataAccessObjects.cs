using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_leaveinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_leaveinfoEntity hr_leaveinfo);
		
		long Update(hr_leaveinfoEntity hr_leaveinfo);
        
		long Delete(hr_leaveinfoEntity hr_leaveinfo);
		
        long SaveList(IList<hr_leaveinfoEntity> listAdded, IList<hr_leaveinfoEntity> listUpdated, IList<hr_leaveinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_leaveinfoEntity> GetAll(hr_leaveinfoEntity hr_leaveinfo);
		
		IList<hr_leaveinfoEntity> GetAllByPages(hr_leaveinfoEntity hr_leaveinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_leavemodification(hr_leaveinfoEntity masterEntity, IList<hr_leavemodificationEntity> listAdded, IList<hr_leavemodificationEntity> listUpdated, IList<hr_leavemodificationEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_leaveinfoEntity  GetSingle(hr_leaveinfoEntity hr_leaveinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_leaveinfoEntity> GAPgListView(hr_leaveinfoEntity hr_leaveinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
