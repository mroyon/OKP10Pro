

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_issuetypeFacadeObjects")]
    public partial interface Igen_issuetypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_issuetypeEntity gen_issuetype);
        
		[OperationContract]
		long Update(gen_issuetypeEntity gen_issuetype);
		
		[OperationContract]
		long Delete(gen_issuetypeEntity gen_issuetype );
        
        [OperationContract]
        long SaveList(List<gen_issuetypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_issuetypeEntity> GetAll(gen_issuetypeEntity gen_issuetype);
		
		[OperationContract]
        IList<gen_issuetypeEntity> GetAllByPages(gen_issuetypeEntity gen_issuetype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_issuetypeEntity  GetSingle(gen_issuetypeEntity gen_issuetype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_issuetypeEntity> GAPgListView(gen_issuetypeEntity gen_issuetype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
