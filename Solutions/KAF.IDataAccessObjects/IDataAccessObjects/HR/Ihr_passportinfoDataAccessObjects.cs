using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_passportinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_passportinfoEntity hr_passportinfo);
		
		long Update(hr_passportinfoEntity hr_passportinfo);
        
		long Delete(hr_passportinfoEntity hr_passportinfo);
		
        long SaveList(IList<hr_passportinfoEntity> listAdded, IList<hr_passportinfoEntity> listUpdated, IList<hr_passportinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_passportinfoEntity> GetAll(hr_passportinfoEntity hr_passportinfo);
		
		IList<hr_passportinfoEntity> GetAllByPages(hr_passportinfoEntity hr_passportinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_residentvisa(hr_passportinfoEntity masterEntity, IList<hr_residentvisaEntity> listAdded, IList<hr_residentvisaEntity> listUpdated, IList<hr_residentvisaEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_passportinfoEntity  GetSingle(hr_passportinfoEntity hr_passportinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_passportinfoEntity> GAPgListView(hr_passportinfoEntity hr_passportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
