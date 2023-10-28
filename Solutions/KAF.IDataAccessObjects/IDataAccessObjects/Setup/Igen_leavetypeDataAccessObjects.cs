using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_leavetypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_leavetypeEntity gen_leavetype);
		
		long Update(gen_leavetypeEntity gen_leavetype);
        
		long Delete(gen_leavetypeEntity gen_leavetype);
		
        long SaveList(IList<gen_leavetypeEntity> listAdded, IList<gen_leavetypeEntity> listUpdated, IList<gen_leavetypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_leavetypeEntity> GetAll(gen_leavetypeEntity gen_leavetype);
		
		IList<gen_leavetypeEntity> GetAllByPages(gen_leavetypeEntity gen_leavetype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        //long SaveMasterDetgen_leaveconfig(gen_leavetypeEntity masterEntity, IList<gen_leaveconfigEntity> listAdded, IList<gen_leaveconfigEntity> listUpdated, IList<gen_leaveconfigEntity> listDeleted);

        //long SaveMasterDethr_leaveinfo(gen_leavetypeEntity masterEntity, IList<hr_leaveinfoEntity> listAdded, IList<hr_leaveinfoEntity> listUpdated, IList<hr_leaveinfoEntity> listDeleted);

        //long SaveMasterDethr_leavemodification(gen_leavetypeEntity masterEntity, IList<hr_leavemodificationEntity> listAdded, IList<hr_leavemodificationEntity> listUpdated, IList<hr_leavemodificationEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_leavetypeEntity  GetSingle(gen_leavetypeEntity gen_leavetype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_leavetypeEntity> GAPgListView(gen_leavetypeEntity gen_leavetype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
