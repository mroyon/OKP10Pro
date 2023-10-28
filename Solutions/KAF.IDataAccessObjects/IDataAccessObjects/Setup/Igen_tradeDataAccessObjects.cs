using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_tradeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_tradeEntity gen_trade);
		
		long Update(gen_tradeEntity gen_trade);
        
		long Delete(gen_tradeEntity gen_trade);
		
        long SaveList(IList<gen_tradeEntity> listAdded, IList<gen_tradeEntity> listUpdated, IList<gen_tradeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_tradeEntity> GetAll(gen_tradeEntity gen_trade);
		
		IList<gen_tradeEntity> GetAllByPages(gen_tradeEntity gen_trade);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_newdemanddetl(gen_tradeEntity masterEntity, IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted);

        long SaveMasterDethr_svcinfo(gen_tradeEntity masterEntity, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_tradeEntity  GetSingle(gen_tradeEntity gen_trade);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_tradeEntity> GAPgListView(gen_tradeEntity gen_trade);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
