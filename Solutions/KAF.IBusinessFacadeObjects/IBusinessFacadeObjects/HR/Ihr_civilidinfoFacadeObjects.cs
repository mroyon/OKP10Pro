

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_civilidinfoFacadeObjects")]
    public partial interface Ihr_civilidinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_civilidinfoEntity hr_civilidinfo);
        
		[OperationContract]
		long Update(hr_civilidinfoEntity hr_civilidinfo);
		
		[OperationContract]
		long Delete(hr_civilidinfoEntity hr_civilidinfo );
        
        [OperationContract]
        long SaveList(List<hr_civilidinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_civilidinfoEntity> GetAll(hr_civilidinfoEntity hr_civilidinfo);
		
		[OperationContract]
        IList<hr_civilidinfoEntity> GetAllByPages(hr_civilidinfoEntity hr_civilidinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_civilidinfoEntity  GetSingle(hr_civilidinfoEntity hr_civilidinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_civilidinfoEntity> GAPgListView(hr_civilidinfoEntity hr_civilidinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
