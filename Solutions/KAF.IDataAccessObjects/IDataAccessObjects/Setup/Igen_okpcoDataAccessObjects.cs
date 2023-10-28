using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_okpcoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_okpcoEntity gen_okpco);
		
		long Update(gen_okpcoEntity gen_okpco);
        
		long Delete(gen_okpcoEntity gen_okpco);
		
        long SaveList(IList<gen_okpcoEntity> listAdded, IList<gen_okpcoEntity> listUpdated, IList<gen_okpcoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_okpcoEntity> GetAll(gen_okpcoEntity gen_okpco);
		
		IList<gen_okpcoEntity> GetAllByPages(gen_okpcoEntity gen_okpco);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_okpcoEntity  GetSingle(gen_okpcoEntity gen_okpco);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_okpcoEntity> GAPgListView(gen_okpcoEntity gen_okpco);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
