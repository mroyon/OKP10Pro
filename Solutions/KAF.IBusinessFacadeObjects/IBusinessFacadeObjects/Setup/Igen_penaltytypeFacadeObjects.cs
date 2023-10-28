

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_penaltytypeFacadeObjects")]
    public partial interface Igen_penaltytypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_penaltytypeEntity gen_penaltytype);
        
		[OperationContract]
		long Update(gen_penaltytypeEntity gen_penaltytype);
		
		[OperationContract]
		long Delete(gen_penaltytypeEntity gen_penaltytype );
        
        [OperationContract]
        long SaveList(List<gen_penaltytypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_penaltytypeEntity> GetAll(gen_penaltytypeEntity gen_penaltytype);
		
		[OperationContract]
        IList<gen_penaltytypeEntity> GetAllByPages(gen_penaltytypeEntity gen_penaltytype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_penaltytypeEntity  GetSingle(gen_penaltytypeEntity gen_penaltytype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_penaltytypeEntity> GAPgListView(gen_penaltytypeEntity gen_penaltytype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
