using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_bankloaninfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_bankloaninfoEntity hr_bankloaninfo);
		
		long Update(hr_bankloaninfoEntity hr_bankloaninfo);
        
		long Delete(hr_bankloaninfoEntity hr_bankloaninfo);
		
        long SaveList(IList<hr_bankloaninfoEntity> listAdded, IList<hr_bankloaninfoEntity> listUpdated, IList<hr_bankloaninfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_bankloaninfoEntity> GetAll(hr_bankloaninfoEntity hr_bankloaninfo);
		
		IList<hr_bankloaninfoEntity> GetAllByPages(hr_bankloaninfoEntity hr_bankloaninfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_bankloaninfoEntity  GetSingle(hr_bankloaninfoEntity hr_bankloaninfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_bankloaninfoEntity> GAPgListView(hr_bankloaninfoEntity hr_bankloaninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
