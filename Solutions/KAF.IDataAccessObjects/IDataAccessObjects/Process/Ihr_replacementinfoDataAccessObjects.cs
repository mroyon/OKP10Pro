using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_replacementinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_replacementinfoEntity hr_replacementinfo);
		
		long Update(hr_replacementinfoEntity hr_replacementinfo);
        
		long Delete(hr_replacementinfoEntity hr_replacementinfo);
		
        long SaveList(IList<hr_replacementinfoEntity> listAdded, IList<hr_replacementinfoEntity> listUpdated, IList<hr_replacementinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_replacementinfoEntity> GetAll(hr_replacementinfoEntity hr_replacementinfo);
		
		IList<hr_replacementinfoEntity> GetAllByPages(hr_replacementinfoEntity hr_replacementinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_replacementinfodetl(hr_replacementinfoEntity masterEntity, IList<hr_replacementinfodetlEntity> listAdded, IList<hr_replacementinfodetlEntity> listUpdated, IList<hr_replacementinfodetlEntity> listDeleted);

        long SaveMasterDethr_reppassportinfo(hr_replacementinfoEntity masterEntity, IList<hr_reppassportinfoEntity> listAdded, IList<hr_reppassportinfoEntity> listUpdated, IList<hr_reppassportinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_replacementinfoEntity  GetSingle(hr_replacementinfoEntity hr_replacementinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_replacementinfoEntity> GAPgListView(hr_replacementinfoEntity hr_replacementinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
