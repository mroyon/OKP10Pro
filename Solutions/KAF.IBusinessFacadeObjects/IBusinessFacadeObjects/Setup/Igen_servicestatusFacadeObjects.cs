

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_servicestatusFacadeObjects")]
    public partial interface Igen_servicestatusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_servicestatusEntity gen_servicestatus);
        
		[OperationContract]
		long Update(gen_servicestatusEntity gen_servicestatus);
		
		[OperationContract]
		long Delete(gen_servicestatusEntity gen_servicestatus );
        
        [OperationContract]
        long SaveList(List<gen_servicestatusEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_servicestatusEntity> GetAll(gen_servicestatusEntity gen_servicestatus);
		
		[OperationContract]
        IList<gen_servicestatusEntity> GetAllByPages(gen_servicestatusEntity gen_servicestatus);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_servicestatusEntity  GetSingle(gen_servicestatusEntity gen_servicestatus);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_servicestatusEntity> GAPgListView(gen_servicestatusEntity gen_servicestatus);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
