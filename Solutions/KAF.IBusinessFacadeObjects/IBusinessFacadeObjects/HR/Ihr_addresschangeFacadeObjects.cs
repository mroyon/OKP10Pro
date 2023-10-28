

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_addresschangeFacadeObjects")]
    public partial interface Ihr_addresschangeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_addresschangeEntity hr_addresschange);
        
		[OperationContract]
		long Update(hr_addresschangeEntity hr_addresschange);
		
		[OperationContract]
		long Delete(hr_addresschangeEntity hr_addresschange );
        
        [OperationContract]
        long SaveList(List<hr_addresschangeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_addresschangeEntity> GetAll(hr_addresschangeEntity hr_addresschange);
		
		[OperationContract]
        IList<hr_addresschangeEntity> GetAllByPages(hr_addresschangeEntity hr_addresschange);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_addresschangeEntity  GetSingle(hr_addresschangeEntity hr_addresschange);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_addresschangeEntity> GAPgListView(hr_addresschangeEntity hr_addresschange);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
