

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_arrivalinfoFacadeObjects")]
    public partial interface Ihr_arrivalinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_arrivalinfoEntity hr_arrivalinfo);
        
		[OperationContract]
		long Update(hr_arrivalinfoEntity hr_arrivalinfo);
		
		[OperationContract]
		long Delete(hr_arrivalinfoEntity hr_arrivalinfo );
        
        [OperationContract]
        long SaveList(List<hr_arrivalinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_arrivalinfoEntity> GetAll(hr_arrivalinfoEntity hr_arrivalinfo);
		
		[OperationContract]
        IList<hr_arrivalinfoEntity> GetAllByPages(hr_arrivalinfoEntity hr_arrivalinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_arrivalinfodetl(hr_arrivalinfoEntity Master, List<hr_arrivalinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_arrivalinfoEntity  GetSingle(hr_arrivalinfoEntity hr_arrivalinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_arrivalinfoEntity> GAPgListView(hr_arrivalinfoEntity hr_arrivalinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
