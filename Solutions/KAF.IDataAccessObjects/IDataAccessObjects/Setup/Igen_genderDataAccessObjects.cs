using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_genderDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_genderEntity gen_gender);
		
		long Update(gen_genderEntity gen_gender);
        
		long Delete(gen_genderEntity gen_gender);
		
        long SaveList(IList<gen_genderEntity> listAdded, IList<gen_genderEntity> listUpdated, IList<gen_genderEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_genderEntity> GetAll(gen_genderEntity gen_gender);
		
		IList<gen_genderEntity> GetAllByPages(gen_genderEntity gen_gender);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_familyinfo(gen_genderEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_genderEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_genderEntity  GetSingle(gen_genderEntity gen_gender);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_genderEntity> GAPgListView(gen_genderEntity gen_gender);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
