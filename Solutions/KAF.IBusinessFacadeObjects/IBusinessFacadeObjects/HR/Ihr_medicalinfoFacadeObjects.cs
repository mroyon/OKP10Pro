

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_medicalinfoFacadeObjects")]
    public partial interface Ihr_medicalinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_medicalinfoEntity hr_medicalinfo);
        
		[OperationContract]
		long Update(hr_medicalinfoEntity hr_medicalinfo);
		
		[OperationContract]
		long Delete(hr_medicalinfoEntity hr_medicalinfo );
        
        [OperationContract]
        long SaveList(List<hr_medicalinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_medicalinfoEntity> GetAll(hr_medicalinfoEntity hr_medicalinfo);
		
		[OperationContract]
        IList<hr_medicalinfoEntity> GetAllByPages(hr_medicalinfoEntity hr_medicalinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_medicalinfoEntity  GetSingle(hr_medicalinfoEntity hr_medicalinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_medicalinfoEntity> GAPgListView(hr_medicalinfoEntity hr_medicalinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
