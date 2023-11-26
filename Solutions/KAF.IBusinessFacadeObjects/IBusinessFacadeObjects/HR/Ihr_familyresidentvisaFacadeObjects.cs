

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_familyresidentvisaFacadeObjects")]
    public partial interface Ihr_familyresidentvisaFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_familyresidentvisaEntity hr_familyresidentvisa);
        
		[OperationContract]
		long Update(hr_familyresidentvisaEntity hr_familyresidentvisa);
		
		[OperationContract]
		long Delete(hr_familyresidentvisaEntity hr_familyresidentvisa );
        
        [OperationContract]
        long SaveList(List<hr_familyresidentvisaEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_familyresidentvisaEntity> GetAll(hr_familyresidentvisaEntity hr_familyresidentvisa);
		
		[OperationContract]
        IList<hr_familyresidentvisaEntity> GetAllByPages(hr_familyresidentvisaEntity hr_familyresidentvisa);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_familyresidentvisaEntity  GetSingle(hr_familyresidentvisaEntity hr_familyresidentvisa);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_familyresidentvisaEntity> GAPgListView(hr_familyresidentvisaEntity hr_familyresidentvisa);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
