using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_okpDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_okpEntity gen_okp);
		
		long Update(gen_okpEntity gen_okp);
        
		long Delete(gen_okpEntity gen_okp);
		
        long SaveList(IList<gen_okpEntity> listAdded, IList<gen_okpEntity> listUpdated, IList<gen_okpEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_okpEntity> GetAll(gen_okpEntity gen_okp);
		
		IList<gen_okpEntity> GetAllByPages(gen_okpEntity gen_okp);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_okpco(gen_okpEntity masterEntity, IList<gen_okpcoEntity> listAdded, IList<gen_okpcoEntity> listUpdated, IList<gen_okpcoEntity> listDeleted);

        long SaveMasterDethr_newdemanddetl(gen_okpEntity masterEntity, IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted);

        long SaveMasterDethr_svcinfo(gen_okpEntity masterEntity, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_okpEntity  GetSingle(gen_okpEntity gen_okp);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_okpEntity> GAPgListView(gen_okpEntity gen_okp);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
