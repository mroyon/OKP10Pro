using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_personalinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_personalinfoEntity hr_personalinfo);
		
		long Update(hr_personalinfoEntity hr_personalinfo);
        
		long Delete(hr_personalinfoEntity hr_personalinfo);
		
        long SaveList(IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_personalinfoEntity> GetAll(hr_personalinfoEntity hr_personalinfo);
		
		IList<hr_personalinfoEntity> GetAllByPages(hr_personalinfoEntity hr_personalinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_personalinfoEntity  GetSingle(hr_personalinfoEntity hr_personalinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_personalinfoEntity> GAPgListView(hr_personalinfoEntity hr_personalinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
