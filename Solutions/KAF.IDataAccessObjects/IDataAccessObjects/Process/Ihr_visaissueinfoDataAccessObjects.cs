using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_visaissueinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_visaissueinfoEntity hr_visaissueinfo);
		
		long Update(hr_visaissueinfoEntity hr_visaissueinfo);
        
		long Delete(hr_visaissueinfoEntity hr_visaissueinfo);
		
        long SaveList(IList<hr_visaissueinfoEntity> listAdded, IList<hr_visaissueinfoEntity> listUpdated, IList<hr_visaissueinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_visaissueinfoEntity> GetAll(hr_visaissueinfoEntity hr_visaissueinfo);
		
		IList<hr_visaissueinfoEntity> GetAllByPages(hr_visaissueinfoEntity hr_visaissueinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_visaissueinfodetl(hr_visaissueinfoEntity masterEntity, IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted);

        long SaveMasterDethr_visasentinfo(hr_visaissueinfoEntity masterEntity, IList<hr_visasentinfoEntity> listAdded, IList<hr_visasentinfoEntity> listUpdated, IList<hr_visasentinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_visaissueinfoEntity  GetSingle(hr_visaissueinfoEntity hr_visaissueinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_visaissueinfoEntity> GAPgListView(hr_visaissueinfoEntity hr_visaissueinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
