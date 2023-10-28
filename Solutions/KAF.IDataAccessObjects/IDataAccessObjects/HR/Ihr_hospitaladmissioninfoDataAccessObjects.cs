using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_hospitaladmissioninfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
		
		long Update(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
        
		long Delete(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
		
        long SaveList(IList<hr_hospitaladmissioninfoEntity> listAdded, IList<hr_hospitaladmissioninfoEntity> listUpdated, IList<hr_hospitaladmissioninfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_hospitaladmissioninfoEntity> GetAll(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
		
		IList<hr_hospitaladmissioninfoEntity> GetAllByPages(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_hospitaladmissioninfoEntity  GetSingle(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_hospitaladmissioninfoEntity> GAPgListView(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
