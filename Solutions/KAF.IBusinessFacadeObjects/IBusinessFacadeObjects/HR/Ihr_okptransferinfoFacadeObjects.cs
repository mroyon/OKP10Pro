

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_okptransferinfoFacadeObjects")]
    public partial interface Ihr_okptransferinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_okptransferinfoEntity hr_okptransferinfo);
        
		[OperationContract]
		long Update(hr_okptransferinfoEntity hr_okptransferinfo);
		
		[OperationContract]
		long Delete(hr_okptransferinfoEntity hr_okptransferinfo );
        
        [OperationContract]
        long SaveList(List<hr_okptransferinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_okptransferinfoEntity> GetAll(hr_okptransferinfoEntity hr_okptransferinfo);
		
		[OperationContract]
        IList<hr_okptransferinfoEntity> GetAllByPages(hr_okptransferinfoEntity hr_okptransferinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_okptransferinfoEntity  GetSingle(hr_okptransferinfoEntity hr_okptransferinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_okptransferinfoEntity> GAPgListView(hr_okptransferinfoEntity hr_okptransferinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
