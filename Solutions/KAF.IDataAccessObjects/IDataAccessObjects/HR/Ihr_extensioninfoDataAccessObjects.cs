using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_extensioninfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_extensioninfoEntity hr_extensioninfo);
		
		long Update(hr_extensioninfoEntity hr_extensioninfo);
        
		long Delete(hr_extensioninfoEntity hr_extensioninfo);
		
        long SaveList(IList<hr_extensioninfoEntity> listAdded, IList<hr_extensioninfoEntity> listUpdated, IList<hr_extensioninfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_extensioninfoEntity> GetAll(hr_extensioninfoEntity hr_extensioninfo);
		
		IList<hr_extensioninfoEntity> GetAllByPages(hr_extensioninfoEntity hr_extensioninfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_extensioninfoEntity  GetSingle(hr_extensioninfoEntity hr_extensioninfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_extensioninfoEntity> GAPgListView(hr_extensioninfoEntity hr_extensioninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
