

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_familyjobinfoFacadeObjects")]
    public partial interface Ihr_familyjobinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_familyjobinfoEntity hr_familyjobinfo);
        
		[OperationContract]
		long Update(hr_familyjobinfoEntity hr_familyjobinfo);
		
		[OperationContract]
		long Delete(hr_familyjobinfoEntity hr_familyjobinfo );
        
        [OperationContract]
        long SaveList(List<hr_familyjobinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_familyjobinfoEntity> GetAll(hr_familyjobinfoEntity hr_familyjobinfo);
		
		[OperationContract]
        IList<hr_familyjobinfoEntity> GetAllByPages(hr_familyjobinfoEntity hr_familyjobinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_familyjobinfoEntity  GetSingle(hr_familyjobinfoEntity hr_familyjobinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_familyjobinfoEntity> GAPgListView(hr_familyjobinfoEntity hr_familyjobinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
