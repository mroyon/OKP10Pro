using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_bloodgroupDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_bloodgroupEntity gen_bloodgroup);
		
		long Update(gen_bloodgroupEntity gen_bloodgroup);
        
		long Delete(gen_bloodgroupEntity gen_bloodgroup);
		
        long SaveList(IList<gen_bloodgroupEntity> listAdded, IList<gen_bloodgroupEntity> listUpdated, IList<gen_bloodgroupEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_bloodgroupEntity> GetAll(gen_bloodgroupEntity gen_bloodgroup);
		
		IList<gen_bloodgroupEntity> GetAllByPages(gen_bloodgroupEntity gen_bloodgroup);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_familyinfo(gen_bloodgroupEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_bloodgroupEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_bloodgroupEntity  GetSingle(gen_bloodgroupEntity gen_bloodgroup);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_bloodgroupEntity> GAPgListView(gen_bloodgroupEntity gen_bloodgroup);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
