using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_documentuploadDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_documentuploadEntity hr_documentupload);
		
		long Update(hr_documentuploadEntity hr_documentupload);
        
		long Delete(hr_documentuploadEntity hr_documentupload);
		
        long SaveList(IList<hr_documentuploadEntity> listAdded, IList<hr_documentuploadEntity> listUpdated, IList<hr_documentuploadEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_documentuploadEntity> GetAll(hr_documentuploadEntity hr_documentupload);
		
		IList<hr_documentuploadEntity> GetAllByPages(hr_documentuploadEntity hr_documentupload);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_documentuploadEntity  GetSingle(hr_documentuploadEntity hr_documentupload);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_documentuploadEntity> GAPgListView(hr_documentuploadEntity hr_documentupload);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
