using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_attachmentinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_attachmentinfoEntity hr_attachmentinfo);
		
		long Update(hr_attachmentinfoEntity hr_attachmentinfo);
        
		long Delete(hr_attachmentinfoEntity hr_attachmentinfo);
		
        long SaveList(IList<hr_attachmentinfoEntity> listAdded, IList<hr_attachmentinfoEntity> listUpdated, IList<hr_attachmentinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_attachmentinfoEntity> GetAll(hr_attachmentinfoEntity hr_attachmentinfo);
		
		IList<hr_attachmentinfoEntity> GetAllByPages(hr_attachmentinfoEntity hr_attachmentinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_attachmentinfoEntity  GetSingle(hr_attachmentinfoEntity hr_attachmentinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_attachmentinfoEntity> GAPgListView(hr_attachmentinfoEntity hr_attachmentinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
