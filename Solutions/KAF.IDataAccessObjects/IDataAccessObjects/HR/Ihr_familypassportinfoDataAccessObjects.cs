using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_familypassportinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_familypassportinfoEntity hr_familypassportinfo);
		
		long Update(hr_familypassportinfoEntity hr_familypassportinfo);
        
		long Delete(hr_familypassportinfoEntity hr_familypassportinfo);
		
        long SaveList(IList<hr_familypassportinfoEntity> listAdded, IList<hr_familypassportinfoEntity> listUpdated, IList<hr_familypassportinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_familypassportinfoEntity> GetAll(hr_familypassportinfoEntity hr_familypassportinfo);
		
		IList<hr_familypassportinfoEntity> GetAllByPages(hr_familypassportinfoEntity hr_familypassportinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_familyresidentvisa(hr_familypassportinfoEntity masterEntity, IList<hr_familyresidentvisaEntity> listAdded, IList<hr_familyresidentvisaEntity> listUpdated, IList<hr_familyresidentvisaEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_familypassportinfoEntity  GetSingle(hr_familypassportinfoEntity hr_familypassportinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_familypassportinfoEntity> GAPgListView(hr_familypassportinfoEntity hr_familypassportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
