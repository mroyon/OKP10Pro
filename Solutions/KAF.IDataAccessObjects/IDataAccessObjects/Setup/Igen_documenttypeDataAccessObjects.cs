using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_documenttypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_documenttypeEntity gen_documenttype);
		
		long Update(gen_documenttypeEntity gen_documenttype);
        
		long Delete(gen_documenttypeEntity gen_documenttype);
		
        long SaveList(IList<gen_documenttypeEntity> listAdded, IList<gen_documenttypeEntity> listUpdated, IList<gen_documenttypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_documenttypeEntity> GetAll(gen_documenttypeEntity gen_documenttype);
		
		IList<gen_documenttypeEntity> GetAllByPages(gen_documenttypeEntity gen_documenttype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_documenttypeEntity  GetSingle(gen_documenttypeEntity gen_documenttype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_documenttypeEntity> GAPgListView(gen_documenttypeEntity gen_documenttype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
