using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_govcityDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_govcityEntity gen_govcity);
		
		long Update(gen_govcityEntity gen_govcity);
        
		long Delete(gen_govcityEntity gen_govcity);
		
        long SaveList(IList<gen_govcityEntity> listAdded, IList<gen_govcityEntity> listUpdated, IList<gen_govcityEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_govcityEntity> GetAll(gen_govcityEntity gen_govcity);
		
		IList<gen_govcityEntity> GetAllByPages(gen_govcityEntity gen_govcity);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_building(gen_govcityEntity masterEntity, IList<gen_buildingEntity> listAdded, IList<gen_buildingEntity> listUpdated, IList<gen_buildingEntity> listDeleted);

        long SaveMasterDethr_addresschange(gen_govcityEntity masterEntity, IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted);

        long SaveMasterDethr_emergencycontact(gen_govcityEntity masterEntity, IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);

        long SaveMasterDethr_familyinfo(gen_govcityEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_govcityEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_govcityEntity  GetSingle(gen_govcityEntity gen_govcity);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_govcityEntity> GAPgListView(gen_govcityEntity gen_govcity);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
