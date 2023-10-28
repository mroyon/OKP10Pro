using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_bankbranchDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_bankbranchEntity gen_bankbranch);
		
		long Update(gen_bankbranchEntity gen_bankbranch);
        
		long Delete(gen_bankbranchEntity gen_bankbranch);
		
        long SaveList(IList<gen_bankbranchEntity> listAdded, IList<gen_bankbranchEntity> listUpdated, IList<gen_bankbranchEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_bankbranchEntity> GetAll(gen_bankbranchEntity gen_bankbranch);
		
		IList<gen_bankbranchEntity> GetAllByPages(gen_bankbranchEntity gen_bankbranch);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_bankaccountinfo(gen_bankbranchEntity masterEntity, IList<hr_bankaccountinfoEntity> listAdded, IList<hr_bankaccountinfoEntity> listUpdated, IList<hr_bankaccountinfoEntity> listDeleted);

        long SaveMasterDethr_bankloaninfo(gen_bankbranchEntity masterEntity, IList<hr_bankloaninfoEntity> listAdded, IList<hr_bankloaninfoEntity> listUpdated, IList<hr_bankloaninfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_bankbranchEntity  GetSingle(gen_bankbranchEntity gen_bankbranch);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_bankbranchEntity> GAPgListView(gen_bankbranchEntity gen_bankbranch);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
