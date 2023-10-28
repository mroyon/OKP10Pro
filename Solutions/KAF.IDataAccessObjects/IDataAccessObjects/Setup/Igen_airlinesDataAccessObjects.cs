using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_airlinesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_airlinesEntity gen_airlines);
		
		long Update(gen_airlinesEntity gen_airlines);
        
		long Delete(gen_airlinesEntity gen_airlines);
		
        long SaveList(IList<gen_airlinesEntity> listAdded, IList<gen_airlinesEntity> listUpdated, IList<gen_airlinesEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_airlinesEntity> GetAll(gen_airlinesEntity gen_airlines);
		
		IList<gen_airlinesEntity> GetAllByPages(gen_airlinesEntity gen_airlines);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_flightinfo(gen_airlinesEntity masterEntity, IList<hr_flightinfoEntity> listAdded, IList<hr_flightinfoEntity> listUpdated, IList<hr_flightinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_airlinesEntity  GetSingle(gen_airlinesEntity gen_airlines);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_airlinesEntity> GAPgListView(gen_airlinesEntity gen_airlines);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
