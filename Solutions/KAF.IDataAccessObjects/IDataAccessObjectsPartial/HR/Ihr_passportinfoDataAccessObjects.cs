using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_passportinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add_Ext(hr_passportinfoEntity hr_passportinfo);
		
		long Update_Ext(hr_passportinfoEntity hr_passportinfo);
        
		long Delete_Ext(hr_passportinfoEntity hr_passportinfo);
		
        long SaveList_Ext(IList<hr_passportinfoEntity> listAdded, IList<hr_passportinfoEntity> listUpdated, IList<hr_passportinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_passportinfoEntity> GetAll_Ext(hr_passportinfoEntity hr_passportinfo);
		
		IList<hr_passportinfoEntity> GetAllByPages_Ext(hr_passportinfoEntity hr_passportinfo);
        
		#endregion GetAll
		
		
        
         #region Simple load Single Row
         hr_passportinfoEntity GetSingle_Ext(hr_passportinfoEntity hr_passportinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_passportinfoEntity> GAPgListView_Ext(hr_passportinfoEntity hr_passportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
