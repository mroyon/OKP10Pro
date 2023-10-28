

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_extensioninfoFacadeObjects")]
    public partial interface Ihr_extensioninfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_extensioninfoEntity hr_extensioninfo);
        
		[OperationContract]
		long Update(hr_extensioninfoEntity hr_extensioninfo);
		
		[OperationContract]
		long Delete(hr_extensioninfoEntity hr_extensioninfo );
        
        [OperationContract]
        long SaveList(List<hr_extensioninfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_extensioninfoEntity> GetAll(hr_extensioninfoEntity hr_extensioninfo);
		
		[OperationContract]
        IList<hr_extensioninfoEntity> GetAllByPages(hr_extensioninfoEntity hr_extensioninfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_extensioninfoEntity  GetSingle(hr_extensioninfoEntity hr_extensioninfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_extensioninfoEntity> GAPgListView(hr_extensioninfoEntity hr_extensioninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
