

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_movementtypeFacadeObjects")]
    public partial interface Igen_movementtypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_movementtypeEntity gen_movementtype);
        
		[OperationContract]
		long Update(gen_movementtypeEntity gen_movementtype);
		
		[OperationContract]
		long Delete(gen_movementtypeEntity gen_movementtype );
        
        [OperationContract]
        long SaveList(List<gen_movementtypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_movementtypeEntity> GetAll(gen_movementtypeEntity gen_movementtype);
		
		[OperationContract]
        IList<gen_movementtypeEntity> GetAllByPages(gen_movementtypeEntity gen_movementtype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_movementtypeEntity  GetSingle(gen_movementtypeEntity gen_movementtype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_movementtypeEntity> GAPgListView(gen_movementtypeEntity gen_movementtype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
