using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_rankDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_rankEntity gen_rank);
		
		long Update(gen_rankEntity gen_rank);
        
		long Delete(gen_rankEntity gen_rank);
		
        long SaveList(IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_rankEntity> GetAll(gen_rankEntity gen_rank);
		
		IList<gen_rankEntity> GetAllByPages(gen_rankEntity gen_rank);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_promotioninfo(gen_rankEntity masterEntity, IList<hr_promotioninfoEntity> listAdded, IList<hr_promotioninfoEntity> listUpdated, IList<hr_promotioninfoEntity> listDeleted);

        long SaveMasterDethr_newdemanddetl(gen_rankEntity masterEntity, IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted);

        long SaveMasterDethr_svcinfo(gen_rankEntity masterEntity, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_rankEntity  GetSingle(gen_rankEntity gen_rank);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_rankEntity> GAPgListView(gen_rankEntity gen_rank);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
