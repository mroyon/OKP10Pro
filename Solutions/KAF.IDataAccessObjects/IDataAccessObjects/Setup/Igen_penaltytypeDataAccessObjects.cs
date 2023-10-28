using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_penaltytypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_penaltytypeEntity gen_penaltytype);
		
		long Update(gen_penaltytypeEntity gen_penaltytype);
        
		long Delete(gen_penaltytypeEntity gen_penaltytype);
		
        long SaveList(IList<gen_penaltytypeEntity> listAdded, IList<gen_penaltytypeEntity> listUpdated, IList<gen_penaltytypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_penaltytypeEntity> GetAll(gen_penaltytypeEntity gen_penaltytype);
		
		IList<gen_penaltytypeEntity> GetAllByPages(gen_penaltytypeEntity gen_penaltytype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_penaltytypeEntity  GetSingle(gen_penaltytypeEntity gen_penaltytype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_penaltytypeEntity> GAPgListView(gen_penaltytypeEntity gen_penaltytype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
