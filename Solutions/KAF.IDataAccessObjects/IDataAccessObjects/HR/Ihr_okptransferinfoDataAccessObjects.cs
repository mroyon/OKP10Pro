using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_okptransferinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_okptransferinfoEntity hr_okptransferinfo);
		
		long Update(hr_okptransferinfoEntity hr_okptransferinfo);
        
		long Delete(hr_okptransferinfoEntity hr_okptransferinfo);
		
        long SaveList(IList<hr_okptransferinfoEntity> listAdded, IList<hr_okptransferinfoEntity> listUpdated, IList<hr_okptransferinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_okptransferinfoEntity> GetAll(hr_okptransferinfoEntity hr_okptransferinfo);
		
		IList<hr_okptransferinfoEntity> GetAllByPages(hr_okptransferinfoEntity hr_okptransferinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_okptransferinfoEntity  GetSingle(hr_okptransferinfoEntity hr_okptransferinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_okptransferinfoEntity> GAPgListView(hr_okptransferinfoEntity hr_okptransferinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
