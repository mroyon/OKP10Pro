using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_punishmentinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_punishmentinfoEntity hr_punishmentinfo);
		
		long Update(hr_punishmentinfoEntity hr_punishmentinfo);
        
		long Delete(hr_punishmentinfoEntity hr_punishmentinfo);
		
        long SaveList(IList<hr_punishmentinfoEntity> listAdded, IList<hr_punishmentinfoEntity> listUpdated, IList<hr_punishmentinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_punishmentinfoEntity> GetAll(hr_punishmentinfoEntity hr_punishmentinfo);
		
		IList<hr_punishmentinfoEntity> GetAllByPages(hr_punishmentinfoEntity hr_punishmentinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_punishmentinfoEntity  GetSingle(hr_punishmentinfoEntity hr_punishmentinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_punishmentinfoEntity> GAPgListView(hr_punishmentinfoEntity hr_punishmentinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
