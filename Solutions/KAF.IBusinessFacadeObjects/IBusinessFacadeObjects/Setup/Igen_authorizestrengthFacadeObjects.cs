

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_authorizestrengthFacadeObjects")]
    public partial interface Igen_authorizestrengthFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_authorizestrengthEntity gen_authorizestrength);
        
		[OperationContract]
		long Update(gen_authorizestrengthEntity gen_authorizestrength);
		
		[OperationContract]
		long Delete(gen_authorizestrengthEntity gen_authorizestrength );
        
        [OperationContract]
        long SaveList(List<gen_authorizestrengthEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_authorizestrengthEntity> GetAll(gen_authorizestrengthEntity gen_authorizestrength);
		
		[OperationContract]
        IList<gen_authorizestrengthEntity> GetAllByPages(gen_authorizestrengthEntity gen_authorizestrength);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_authorizestrengthEntity  GetSingle(gen_authorizestrengthEntity gen_authorizestrength);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_authorizestrengthEntity> GAPgListView(gen_authorizestrengthEntity gen_authorizestrength);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
