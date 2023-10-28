

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_currencyexchagerateFacadeObjects")]
    public partial interface Igen_currencyexchagerateFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_currencyexchagerateEntity gen_currencyexchagerate);
        
		[OperationContract]
		long Update(gen_currencyexchagerateEntity gen_currencyexchagerate);
		
		[OperationContract]
		long Delete(gen_currencyexchagerateEntity gen_currencyexchagerate );
        
        [OperationContract]
        long SaveList(List<gen_currencyexchagerateEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_currencyexchagerateEntity> GetAll(gen_currencyexchagerateEntity gen_currencyexchagerate);
		
		[OperationContract]
        IList<gen_currencyexchagerateEntity> GetAllByPages(gen_currencyexchagerateEntity gen_currencyexchagerate);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_currencyexchagerateEntity  GetSingle(gen_currencyexchagerateEntity gen_currencyexchagerate);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_currencyexchagerateEntity> GAPgListView(gen_currencyexchagerateEntity gen_currencyexchagerate);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
