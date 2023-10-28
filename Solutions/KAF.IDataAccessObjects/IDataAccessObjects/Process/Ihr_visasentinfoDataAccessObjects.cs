using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_visasentinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_visasentinfoEntity hr_visasentinfo);
		
		long Update(hr_visasentinfoEntity hr_visasentinfo);
        
		long Delete(hr_visasentinfoEntity hr_visasentinfo);
		
        long SaveList(IList<hr_visasentinfoEntity> listAdded, IList<hr_visasentinfoEntity> listUpdated, IList<hr_visasentinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_visasentinfoEntity> GetAll(hr_visasentinfoEntity hr_visasentinfo);
		
		IList<hr_visasentinfoEntity> GetAllByPages(hr_visasentinfoEntity hr_visasentinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_ptademand(hr_visasentinfoEntity masterEntity, IList<hr_ptademandEntity> listAdded, IList<hr_ptademandEntity> listUpdated, IList<hr_ptademandEntity> listDeleted);

        long SaveMasterDethr_visasentinfodetl(hr_visasentinfoEntity masterEntity, IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_visasentinfoEntity  GetSingle(hr_visasentinfoEntity hr_visasentinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_visasentinfoEntity> GAPgListView(hr_visasentinfoEntity hr_visasentinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
