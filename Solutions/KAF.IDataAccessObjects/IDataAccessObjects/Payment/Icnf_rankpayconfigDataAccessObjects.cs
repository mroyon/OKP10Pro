using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Icnf_rankpayconfigDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(cnf_rankpayconfigEntity cnf_rankpayconfig);
		
		long Update(cnf_rankpayconfigEntity cnf_rankpayconfig);
        
		long Delete(cnf_rankpayconfigEntity cnf_rankpayconfig);
		
        long SaveList(IList<cnf_rankpayconfigEntity> listAdded, IList<cnf_rankpayconfigEntity> listUpdated, IList<cnf_rankpayconfigEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<cnf_rankpayconfigEntity> GetAll(cnf_rankpayconfigEntity cnf_rankpayconfig);
		
		IList<cnf_rankpayconfigEntity> GetAllByPages(cnf_rankpayconfigEntity cnf_rankpayconfig);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         cnf_rankpayconfigEntity  GetSingle(cnf_rankpayconfigEntity cnf_rankpayconfig);
         #endregion 
         
         #region ForListView Paged Method
         IList<cnf_rankpayconfigEntity> GAPgListView(cnf_rankpayconfigEntity cnf_rankpayconfig);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
