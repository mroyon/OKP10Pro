

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_replacementinfoFacadeObjects")]
    public partial interface Ihr_replacementinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_replacementinfoEntity hr_replacementinfo);
        
		[OperationContract]
		long Update(hr_replacementinfoEntity hr_replacementinfo);
		
		[OperationContract]
		long Delete(hr_replacementinfoEntity hr_replacementinfo );
        
        [OperationContract]
        long SaveList(List<hr_replacementinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_replacementinfoEntity> GetAll(hr_replacementinfoEntity hr_replacementinfo);
		
		[OperationContract]
        IList<hr_replacementinfoEntity> GetAllByPages(hr_replacementinfoEntity hr_replacementinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_replacementinfodetl(hr_replacementinfoEntity Master, List<hr_replacementinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_reppassportinfo(hr_replacementinfoEntity Master, List<hr_reppassportinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_replacementinfoEntity  GetSingle(hr_replacementinfoEntity hr_replacementinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_replacementinfoEntity> GAPgListView(hr_replacementinfoEntity hr_replacementinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
