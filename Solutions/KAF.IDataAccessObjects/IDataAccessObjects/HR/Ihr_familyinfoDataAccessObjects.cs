using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_familyinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_familyinfoEntity hr_familyinfo);
		
		long Update(hr_familyinfoEntity hr_familyinfo);
        
		long Delete(hr_familyinfoEntity hr_familyinfo);
		
        long SaveList(IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_familyinfoEntity> GetAll(hr_familyinfoEntity hr_familyinfo);
		
		IList<hr_familyinfoEntity> GetAllByPages(hr_familyinfoEntity hr_familyinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_familyinfo(hr_familyinfoEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_familyjobinfo(hr_familyinfoEntity masterEntity, IList<hr_familyjobinfoEntity> listAdded, IList<hr_familyjobinfoEntity> listUpdated, IList<hr_familyjobinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_familyinfoEntity  GetSingle(hr_familyinfoEntity hr_familyinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_familyinfoEntity> GAPgListView(hr_familyinfoEntity hr_familyinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
