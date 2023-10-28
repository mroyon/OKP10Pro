

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_residentvisaFacadeObjects")]
    public partial interface Ihr_residentvisaFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_residentvisaEntity hr_residentvisa);
        
		[OperationContract]
		long Update(hr_residentvisaEntity hr_residentvisa);
		
		[OperationContract]
		long Delete(hr_residentvisaEntity hr_residentvisa );
        
        [OperationContract]
        long SaveList(List<hr_residentvisaEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_residentvisaEntity> GetAll(hr_residentvisaEntity hr_residentvisa);
		
		[OperationContract]
        IList<hr_residentvisaEntity> GetAllByPages(hr_residentvisaEntity hr_residentvisa);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_residentvisaEntity  GetSingle(hr_residentvisaEntity hr_residentvisa);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_residentvisaEntity> GAPgListView(hr_residentvisaEntity hr_residentvisa);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
