using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_visaissueinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
		
		long Update(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
        
		long Delete(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
		
        long SaveList(IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_visaissueinfodetlEntity> GetAll(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
		
		IList<hr_visaissueinfodetlEntity> GetAllByPages(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_visasentinfodetl(hr_visaissueinfodetlEntity masterEntity, IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_visaissueinfodetlEntity  GetSingle(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_visaissueinfodetlEntity> GAPgListView(hr_visaissueinfodetlEntity hr_visaissueinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
