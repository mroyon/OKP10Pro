

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_okpcoFacadeObjects")]
    public partial interface Igen_okpcoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_okpcoEntity gen_okpco);
        
		[OperationContract]
		long Update(gen_okpcoEntity gen_okpco);
		
		[OperationContract]
		long Delete(gen_okpcoEntity gen_okpco );
        
        [OperationContract]
        long SaveList(List<gen_okpcoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_okpcoEntity> GetAll(gen_okpcoEntity gen_okpco);
		
		[OperationContract]
        IList<gen_okpcoEntity> GetAllByPages(gen_okpcoEntity gen_okpco);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_okpcoEntity  GetSingle(gen_okpcoEntity gen_okpco);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_okpcoEntity> GAPgListView(gen_okpcoEntity gen_okpco);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
