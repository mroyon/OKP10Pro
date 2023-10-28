using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_bankDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_bankEntity gen_bank);
		
		long Update(gen_bankEntity gen_bank);
        
		long Delete(gen_bankEntity gen_bank);
		
        long SaveList(IList<gen_bankEntity> listAdded, IList<gen_bankEntity> listUpdated, IList<gen_bankEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_bankEntity> GetAll(gen_bankEntity gen_bank);
		
		IList<gen_bankEntity> GetAllByPages(gen_bankEntity gen_bank);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_bankbranch(gen_bankEntity masterEntity, IList<gen_bankbranchEntity> listAdded, IList<gen_bankbranchEntity> listUpdated, IList<gen_bankbranchEntity> listDeleted);

        long SaveMasterDethr_bankaccountinfo(gen_bankEntity masterEntity, IList<hr_bankaccountinfoEntity> listAdded, IList<hr_bankaccountinfoEntity> listUpdated, IList<hr_bankaccountinfoEntity> listDeleted);

        long SaveMasterDethr_bankloaninfo(gen_bankEntity masterEntity, IList<hr_bankloaninfoEntity> listAdded, IList<hr_bankloaninfoEntity> listUpdated, IList<hr_bankloaninfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_bankEntity  GetSingle(gen_bankEntity gen_bank);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_bankEntity> GAPgListView(gen_bankEntity gen_bank);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
