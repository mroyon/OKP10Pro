using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_currencyexchagerateDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_currencyexchagerateEntity gen_currencyexchagerate);
		
		long Update(gen_currencyexchagerateEntity gen_currencyexchagerate);
        
		long Delete(gen_currencyexchagerateEntity gen_currencyexchagerate);
		
        long SaveList(IList<gen_currencyexchagerateEntity> listAdded, IList<gen_currencyexchagerateEntity> listUpdated, IList<gen_currencyexchagerateEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_currencyexchagerateEntity> GetAll(gen_currencyexchagerateEntity gen_currencyexchagerate);
		
		IList<gen_currencyexchagerateEntity> GetAllByPages(gen_currencyexchagerateEntity gen_currencyexchagerate);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_currencyexchagerateEntity  GetSingle(gen_currencyexchagerateEntity gen_currencyexchagerate);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_currencyexchagerateEntity> GAPgListView(gen_currencyexchagerateEntity gen_currencyexchagerate);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
