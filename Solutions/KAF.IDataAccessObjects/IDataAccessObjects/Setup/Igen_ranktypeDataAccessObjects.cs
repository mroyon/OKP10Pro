using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_ranktypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_ranktypeEntity gen_ranktype);
		
		long Update(gen_ranktypeEntity gen_ranktype);
        
		long Delete(gen_ranktypeEntity gen_ranktype);
		
        long SaveList(IList<gen_ranktypeEntity> listAdded, IList<gen_ranktypeEntity> listUpdated, IList<gen_ranktypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_ranktypeEntity> GetAll(gen_ranktypeEntity gen_ranktype);
		
		IList<gen_ranktypeEntity> GetAllByPages(gen_ranktypeEntity gen_ranktype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_rank(gen_ranktypeEntity masterEntity, IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_ranktypeEntity  GetSingle(gen_ranktypeEntity gen_ranktype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_ranktypeEntity> GAPgListView(gen_ranktypeEntity gen_ranktype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
