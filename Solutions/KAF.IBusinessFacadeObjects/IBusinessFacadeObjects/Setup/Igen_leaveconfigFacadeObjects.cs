

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_leaveconfigFacadeObjects")]
    public partial interface Igen_leaveconfigFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_leaveconfigEntity gen_leaveconfig);
        
		[OperationContract]
		long Update(gen_leaveconfigEntity gen_leaveconfig);
		
		[OperationContract]
		long Delete(gen_leaveconfigEntity gen_leaveconfig );
        
        [OperationContract]
        long SaveList(List<gen_leaveconfigEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_leaveconfigEntity> GetAll(gen_leaveconfigEntity gen_leaveconfig);
		
		[OperationContract]
        IList<gen_leaveconfigEntity> GetAllByPages(gen_leaveconfigEntity gen_leaveconfig);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_leaveconfigEntity  GetSingle(gen_leaveconfigEntity gen_leaveconfig);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_leaveconfigEntity> GAPgListView(gen_leaveconfigEntity gen_leaveconfig);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
