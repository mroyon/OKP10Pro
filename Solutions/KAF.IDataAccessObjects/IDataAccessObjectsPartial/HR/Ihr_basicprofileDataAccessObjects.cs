using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_basicprofileDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add_Ext(hr_basicprofileEntity hr_basicprofile);
		
		long Update_Ext(hr_basicprofileEntity hr_basicprofile);
        
		long Delete_Ext(hr_basicprofileEntity hr_basicprofile);
		
        long SaveList_Ext(IList<hr_basicprofileEntity> listAdded, IList<hr_basicprofileEntity> listUpdated, IList<hr_basicprofileEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_basicprofileEntity> GetAll_Ext(hr_basicprofileEntity hr_basicprofile);
		
		IList<hr_basicprofileEntity> GetAllByPages_Ext(hr_basicprofileEntity hr_basicprofile);
        
		#endregion GetAll
		
		
        
         
         
         #region ForListView Paged Method
         IList<hr_basicprofileEntity> GAPgListView_Ext(hr_basicprofileEntity hr_basicprofile);
         #endregion
         
        
        
    }
}
