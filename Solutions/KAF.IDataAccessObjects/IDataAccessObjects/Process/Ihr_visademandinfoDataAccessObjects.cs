using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_visademandinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_visademandinfoEntity hr_visademandinfo);
		
		long Update(hr_visademandinfoEntity hr_visademandinfo);
        
		long Delete(hr_visademandinfoEntity hr_visademandinfo);
		
        long SaveList(IList<hr_visademandinfoEntity> listAdded, IList<hr_visademandinfoEntity> listUpdated, IList<hr_visademandinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_visademandinfoEntity> GetAll(hr_visademandinfoEntity hr_visademandinfo);
		
		IList<hr_visademandinfoEntity> GetAllByPages(hr_visademandinfoEntity hr_visademandinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_visademandinfodetl(hr_visademandinfoEntity masterEntity, IList<hr_visademandinfodetlEntity> listAdded, IList<hr_visademandinfodetlEntity> listUpdated, IList<hr_visademandinfodetlEntity> listDeleted);

        long SaveMasterDethr_visaissueinfo(hr_visademandinfoEntity masterEntity, IList<hr_visaissueinfoEntity> listAdded, IList<hr_visaissueinfoEntity> listUpdated, IList<hr_visaissueinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_visademandinfoEntity  GetSingle(hr_visademandinfoEntity hr_visademandinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_visademandinfoEntity> GAPgListView(hr_visademandinfoEntity hr_visademandinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
