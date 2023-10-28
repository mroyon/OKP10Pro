

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_documenttypeFacadeObjects")]
    public partial interface Igen_documenttypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_documenttypeEntity gen_documenttype);
        
		[OperationContract]
		long Update(gen_documenttypeEntity gen_documenttype);
		
		[OperationContract]
		long Delete(gen_documenttypeEntity gen_documenttype );
        
        [OperationContract]
        long SaveList(List<gen_documenttypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_documenttypeEntity> GetAll(gen_documenttypeEntity gen_documenttype);
		
		[OperationContract]
        IList<gen_documenttypeEntity> GetAllByPages(gen_documenttypeEntity gen_documenttype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_documenttypeEntity  GetSingle(gen_documenttypeEntity gen_documenttype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_documenttypeEntity> GAPgListView(gen_documenttypeEntity gen_documenttype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
