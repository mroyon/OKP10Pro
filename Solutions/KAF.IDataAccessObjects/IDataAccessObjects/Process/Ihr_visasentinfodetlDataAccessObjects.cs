using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_visasentinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_visasentinfodetlEntity hr_visasentinfodetl);
		
		long Update(hr_visasentinfodetlEntity hr_visasentinfodetl);
        
		long Delete(hr_visasentinfodetlEntity hr_visasentinfodetl);
		
        long SaveList(IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_visasentinfodetlEntity> GetAll(hr_visasentinfodetlEntity hr_visasentinfodetl);
		
		IList<hr_visasentinfodetlEntity> GetAllByPages(hr_visasentinfodetlEntity hr_visasentinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_ptademanddetl(hr_visasentinfodetlEntity masterEntity, IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_visasentinfodetlEntity  GetSingle(hr_visasentinfodetlEntity hr_visasentinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_visasentinfodetlEntity> GAPgListView(hr_visasentinfodetlEntity hr_visasentinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
