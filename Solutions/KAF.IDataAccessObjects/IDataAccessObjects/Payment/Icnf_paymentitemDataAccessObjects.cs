using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Icnf_paymentitemDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(cnf_paymentitemEntity cnf_paymentitem);
		
		long Update(cnf_paymentitemEntity cnf_paymentitem);
        
		long Delete(cnf_paymentitemEntity cnf_paymentitem);
		
        long SaveList(IList<cnf_paymentitemEntity> listAdded, IList<cnf_paymentitemEntity> listUpdated, IList<cnf_paymentitemEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<cnf_paymentitemEntity> GetAll(cnf_paymentitemEntity cnf_paymentitem);
		
		IList<cnf_paymentitemEntity> GetAllByPages(cnf_paymentitemEntity cnf_paymentitem);
        
		#endregion GetAll
		
		
       
        
         #region Simple load Single Row
         cnf_paymentitemEntity  GetSingle(cnf_paymentitemEntity cnf_paymentitem);
         #endregion 
         
         #region ForListView Paged Method
         IList<cnf_paymentitemEntity> GAPgListView(cnf_paymentitemEntity cnf_paymentitem);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
