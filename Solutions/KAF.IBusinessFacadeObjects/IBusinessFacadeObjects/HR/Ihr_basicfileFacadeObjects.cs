

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_basicfileFacadeObjects")]
    public partial interface Ihr_basicfileFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_basicfileEntity hr_basicfile);
        
		[OperationContract]
		long Update(hr_basicfileEntity hr_basicfile);
		
		[OperationContract]
		long Delete(hr_basicfileEntity hr_basicfile );
        
        [OperationContract]
        long SaveList(List<hr_basicfileEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_basicfileEntity> GetAll(hr_basicfileEntity hr_basicfile);
		
		[OperationContract]
        IList<hr_basicfileEntity> GetAllByPages(hr_basicfileEntity hr_basicfile);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_basicfileEntity  GetSingle(hr_basicfileEntity hr_basicfile);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_basicfileEntity> GAPgListView(hr_basicfileEntity hr_basicfile);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
