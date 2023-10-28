using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_armsDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_armsEntity gen_arms);
		
		long Update(gen_armsEntity gen_arms);
        
		long Delete(gen_armsEntity gen_arms);
		
        long SaveList(IList<gen_armsEntity> listAdded, IList<gen_armsEntity> listUpdated, IList<gen_armsEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_armsEntity> GetAll(gen_armsEntity gen_arms);
		
		IList<gen_armsEntity> GetAllByPages(gen_armsEntity gen_arms);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_svcinfo(gen_armsEntity masterEntity, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_armsEntity  GetSingle(gen_armsEntity gen_arms);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_armsEntity> GAPgListView(gen_armsEntity gen_arms);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
