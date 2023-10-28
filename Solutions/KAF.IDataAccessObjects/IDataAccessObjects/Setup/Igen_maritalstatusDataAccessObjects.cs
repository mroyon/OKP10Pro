using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_maritalstatusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_maritalstatusEntity gen_maritalstatus);
		
		long Update(gen_maritalstatusEntity gen_maritalstatus);
        
		long Delete(gen_maritalstatusEntity gen_maritalstatus);
		
        long SaveList(IList<gen_maritalstatusEntity> listAdded, IList<gen_maritalstatusEntity> listUpdated, IList<gen_maritalstatusEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_maritalstatusEntity> GetAll(gen_maritalstatusEntity gen_maritalstatus);
		
		IList<gen_maritalstatusEntity> GetAllByPages(gen_maritalstatusEntity gen_maritalstatus);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_familyinfo(gen_maritalstatusEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_maritalstatusEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_maritalstatusEntity  GetSingle(gen_maritalstatusEntity gen_maritalstatus);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_maritalstatusEntity> GAPgListView(gen_maritalstatusEntity gen_maritalstatus);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
