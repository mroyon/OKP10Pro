

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_grouprankFacadeObjects")]
    public partial interface Igen_grouprankFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_grouprankEntity gen_grouprank);
        
		[OperationContract]
		long Update(gen_grouprankEntity gen_grouprank);
		
		[OperationContract]
		long Delete(gen_grouprankEntity gen_grouprank );
        
        [OperationContract]
        long SaveList(List<gen_grouprankEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_grouprankEntity> GetAll(gen_grouprankEntity gen_grouprank);
		
		[OperationContract]
        IList<gen_grouprankEntity> GetAllByPages(gen_grouprankEntity gen_grouprank);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_grouprankEntity  GetSingle(gen_grouprankEntity gen_grouprank);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_grouprankEntity> GAPgListView(gen_grouprankEntity gen_grouprank);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
