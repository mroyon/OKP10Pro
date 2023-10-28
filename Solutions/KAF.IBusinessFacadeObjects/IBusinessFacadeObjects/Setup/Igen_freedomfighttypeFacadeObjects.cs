

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_freedomfighttypeFacadeObjects")]
    public partial interface Igen_freedomfighttypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_freedomfighttypeEntity gen_freedomfighttype);
        
		[OperationContract]
		long Update(gen_freedomfighttypeEntity gen_freedomfighttype);
		
		[OperationContract]
		long Delete(gen_freedomfighttypeEntity gen_freedomfighttype );
        
        [OperationContract]
        long SaveList(List<gen_freedomfighttypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_freedomfighttypeEntity> GetAll(gen_freedomfighttypeEntity gen_freedomfighttype);
		
		[OperationContract]
        IList<gen_freedomfighttypeEntity> GetAllByPages(gen_freedomfighttypeEntity gen_freedomfighttype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_freedomfighttypeEntity  GetSingle(gen_freedomfighttypeEntity gen_freedomfighttype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_freedomfighttypeEntity> GAPgListView(gen_freedomfighttypeEntity gen_freedomfighttype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
