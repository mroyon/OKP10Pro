using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_buildingDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_buildingEntity gen_building);
		
		long Update(gen_buildingEntity gen_building);
        
		long Delete(gen_buildingEntity gen_building);
		
        long SaveList(IList<gen_buildingEntity> listAdded, IList<gen_buildingEntity> listUpdated, IList<gen_buildingEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_buildingEntity> GetAll(gen_buildingEntity gen_building);
		
		IList<gen_buildingEntity> GetAllByPages(gen_buildingEntity gen_building);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_addresschange(gen_buildingEntity masterEntity, IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_buildingEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_buildingEntity  GetSingle(gen_buildingEntity gen_building);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_buildingEntity> GAPgListView(gen_buildingEntity gen_building);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
