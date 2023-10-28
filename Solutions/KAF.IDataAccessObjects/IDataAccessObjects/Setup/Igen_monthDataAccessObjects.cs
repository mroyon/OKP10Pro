using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_monthDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_monthEntity gen_month);
		
		long Update(gen_monthEntity gen_month);
        
		long Delete(gen_monthEntity gen_month);
		
        long SaveList(IList<gen_monthEntity> listAdded, IList<gen_monthEntity> listUpdated, IList<gen_monthEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_monthEntity> GetAll(gen_monthEntity gen_month);
		
		IList<gen_monthEntity> GetAllByPages(gen_monthEntity gen_month);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_monthEntity  GetSingle(gen_monthEntity gen_month);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_monthEntity> GAPgListView(gen_monthEntity gen_month);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
