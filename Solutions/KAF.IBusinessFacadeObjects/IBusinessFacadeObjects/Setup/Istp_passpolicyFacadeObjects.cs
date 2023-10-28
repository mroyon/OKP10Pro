

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Istp_passpolicyFacadeObjects")]
    public partial interface Istp_passpolicyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(stp_passpolicyEntity stp_passpolicy);
        
		[OperationContract]
		long Update(stp_passpolicyEntity stp_passpolicy);
		
		[OperationContract]
		long Delete(stp_passpolicyEntity stp_passpolicy );
        
        [OperationContract]
        long SaveList(List<stp_passpolicyEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<stp_passpolicyEntity> GetAll(stp_passpolicyEntity stp_passpolicy);
		
		[OperationContract]
        IList<stp_passpolicyEntity> GetAllByPages(stp_passpolicyEntity stp_passpolicy);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        stp_passpolicyEntity  GetSingle(stp_passpolicyEntity stp_passpolicy);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<stp_passpolicyEntity> GAPgListView(stp_passpolicyEntity stp_passpolicy);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
