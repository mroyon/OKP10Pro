

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "IuseraccountsprofFacadeObjects")]
    public partial interface IuseraccountsprofFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(useraccountsprofEntity useraccountsprof);
        
		[OperationContract]
		long Update(useraccountsprofEntity useraccountsprof);
		
		[OperationContract]
		long Delete(useraccountsprofEntity useraccountsprof );
        
        [OperationContract]
        long SaveList(List<useraccountsprofEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<useraccountsprofEntity> GetAll(useraccountsprofEntity useraccountsprof);
		
		[OperationContract]
        IList<useraccountsprofEntity> GetAllByPages(useraccountsprofEntity useraccountsprof);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        useraccountsprofEntity  GetSingle(useraccountsprofEntity useraccountsprof);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<useraccountsprofEntity> GAPgListView(useraccountsprofEntity useraccountsprof);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
