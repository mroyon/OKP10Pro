

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_monthFacadeObjects")]
    public partial interface Igen_monthFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_monthEntity gen_month);
        
		[OperationContract]
		long Update(gen_monthEntity gen_month);
		
		[OperationContract]
		long Delete(gen_monthEntity gen_month );
        
        [OperationContract]
        long SaveList(List<gen_monthEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_monthEntity> GetAll(gen_monthEntity gen_month);
		
		[OperationContract]
        IList<gen_monthEntity> GetAllByPages(gen_monthEntity gen_month);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_monthEntity  GetSingle(gen_monthEntity gen_month);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_monthEntity> GAPgListView(gen_monthEntity gen_month);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
