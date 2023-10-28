using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_newdemanddetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
		
		long Update_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
        
		long Delete_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
		
        long SaveList_Ext(IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_newdemanddetlEntity> GetAll_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
		
		IList<hr_newdemanddetlEntity> GetAllByPages_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
        
		#endregion GetAll
		
		
        
         #region Simple load Single Row
         hr_newdemanddetlEntity GetSingle_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_newdemanddetlEntity> GAPgListView_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
