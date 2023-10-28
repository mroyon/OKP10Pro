using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_medicalinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_medicalinfoEntity hr_medicalinfo);
		
		long Update(hr_medicalinfoEntity hr_medicalinfo);
        
		long Delete(hr_medicalinfoEntity hr_medicalinfo);
		
        long SaveList(IList<hr_medicalinfoEntity> listAdded, IList<hr_medicalinfoEntity> listUpdated, IList<hr_medicalinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_medicalinfoEntity> GetAll(hr_medicalinfoEntity hr_medicalinfo);
		
		IList<hr_medicalinfoEntity> GetAllByPages(hr_medicalinfoEntity hr_medicalinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_medicalinfoEntity  GetSingle(hr_medicalinfoEntity hr_medicalinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_medicalinfoEntity> GAPgListView(hr_medicalinfoEntity hr_medicalinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
