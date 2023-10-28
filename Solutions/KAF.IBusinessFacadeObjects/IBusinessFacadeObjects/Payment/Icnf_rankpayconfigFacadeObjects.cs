

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Icnf_rankpayconfigFacadeObjects")]
    public partial interface Icnf_rankpayconfigFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(cnf_rankpayconfigEntity cnf_rankpayconfig);
        
		[OperationContract]
		long Update(cnf_rankpayconfigEntity cnf_rankpayconfig);
		
		[OperationContract]
		long Delete(cnf_rankpayconfigEntity cnf_rankpayconfig );
        
        [OperationContract]
        long SaveList(List<cnf_rankpayconfigEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<cnf_rankpayconfigEntity> GetAll(cnf_rankpayconfigEntity cnf_rankpayconfig);
		
		[OperationContract]
        IList<cnf_rankpayconfigEntity> GetAllByPages(cnf_rankpayconfigEntity cnf_rankpayconfig);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        cnf_rankpayconfigEntity  GetSingle(cnf_rankpayconfigEntity cnf_rankpayconfig);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<cnf_rankpayconfigEntity> GAPgListView(cnf_rankpayconfigEntity cnf_rankpayconfig);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
