

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Icnf_paymentitemFacadeObjects")]
    public partial interface Icnf_paymentitemFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(cnf_paymentitemEntity cnf_paymentitem);
        
		[OperationContract]
		long Update(cnf_paymentitemEntity cnf_paymentitem);
		
		[OperationContract]
		long Delete(cnf_paymentitemEntity cnf_paymentitem );
        
        [OperationContract]
        long SaveList(List<cnf_paymentitemEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<cnf_paymentitemEntity> GetAll(cnf_paymentitemEntity cnf_paymentitem);
		
		[OperationContract]
        IList<cnf_paymentitemEntity> GetAllByPages(cnf_paymentitemEntity cnf_paymentitem);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
       
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        cnf_paymentitemEntity  GetSingle(cnf_paymentitemEntity cnf_paymentitem);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<cnf_paymentitemEntity> GAPgListView(cnf_paymentitemEntity cnf_paymentitem);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
