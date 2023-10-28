using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_divisiondistrictDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_divisiondistrictEntity gen_divisiondistrict);
		
		long Update(gen_divisiondistrictEntity gen_divisiondistrict);
        
		long Delete(gen_divisiondistrictEntity gen_divisiondistrict);
		
        long SaveList(IList<gen_divisiondistrictEntity> listAdded, IList<gen_divisiondistrictEntity> listUpdated, IList<gen_divisiondistrictEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_divisiondistrictEntity> GetAll(gen_divisiondistrictEntity gen_divisiondistrict);
		
		IList<gen_divisiondistrictEntity> GetAllByPages(gen_divisiondistrictEntity gen_divisiondistrict);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_divisiondistrict(gen_divisiondistrictEntity masterEntity, IList<gen_divisiondistrictEntity> listAdded, IList<gen_divisiondistrictEntity> listUpdated, IList<gen_divisiondistrictEntity> listDeleted);

        long SaveMasterDetgen_thana(gen_divisiondistrictEntity masterEntity, IList<gen_thanaEntity> listAdded, IList<gen_thanaEntity> listUpdated, IList<gen_thanaEntity> listDeleted);

        long SaveMasterDethr_addresschange(gen_divisiondistrictEntity masterEntity, IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted);

        long SaveMasterDethr_emergencycontact(gen_divisiondistrictEntity masterEntity, IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_divisiondistrictEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_divisiondistrictEntity  GetSingle(gen_divisiondistrictEntity gen_divisiondistrict);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_divisiondistrictEntity> GAPgListView(gen_divisiondistrictEntity gen_divisiondistrict);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
