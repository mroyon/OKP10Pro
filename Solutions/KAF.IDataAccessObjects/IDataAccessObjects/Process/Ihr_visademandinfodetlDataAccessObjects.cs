using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_visademandinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_visademandinfodetlEntity hr_visademandinfodetl);
		
		long Update(hr_visademandinfodetlEntity hr_visademandinfodetl);
        
		long Delete(hr_visademandinfodetlEntity hr_visademandinfodetl);
		
        long SaveList(IList<hr_visademandinfodetlEntity> listAdded, IList<hr_visademandinfodetlEntity> listUpdated, IList<hr_visademandinfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_visademandinfodetlEntity> GetAll(hr_visademandinfodetlEntity hr_visademandinfodetl);
		
		IList<hr_visademandinfodetlEntity> GetAllByPages(hr_visademandinfodetlEntity hr_visademandinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_visaissueinfodetl(hr_visademandinfodetlEntity masterEntity, IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_visademandinfodetlEntity  GetSingle(hr_visademandinfodetlEntity hr_visademandinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_visademandinfodetlEntity> GAPgListView(hr_visademandinfodetlEntity hr_visademandinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
