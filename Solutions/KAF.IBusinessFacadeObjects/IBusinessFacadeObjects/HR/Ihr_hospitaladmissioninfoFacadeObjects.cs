

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_hospitaladmissioninfoFacadeObjects")]
    public partial interface Ihr_hospitaladmissioninfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
        
		[OperationContract]
		long Update(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
		
		[OperationContract]
		long Delete(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo );
        
        [OperationContract]
        long SaveList(List<hr_hospitaladmissioninfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_hospitaladmissioninfoEntity> GetAll(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
		
		[OperationContract]
        IList<hr_hospitaladmissioninfoEntity> GetAllByPages(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_hospitaladmissioninfoEntity  GetSingle(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_hospitaladmissioninfoEntity> GAPgListView(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
