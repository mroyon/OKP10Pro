

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_familyinfoFacadeObjects")]
    public partial interface Ihr_familyinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_familyinfoEntity hr_familyinfo);
        
		[OperationContract]
		long Update(hr_familyinfoEntity hr_familyinfo);
		
		[OperationContract]
		long Delete(hr_familyinfoEntity hr_familyinfo );
        
        [OperationContract]
        long SaveList(List<hr_familyinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_familyinfoEntity> GetAll(hr_familyinfoEntity hr_familyinfo);
		
		[OperationContract]
        IList<hr_familyinfoEntity> GetAllByPages(hr_familyinfoEntity hr_familyinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_familyinfo(hr_familyinfoEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_familyjobinfo(hr_familyinfoEntity Master, List<hr_familyjobinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_familyinfoEntity  GetSingle(hr_familyinfoEntity hr_familyinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_familyinfoEntity> GAPgListView(hr_familyinfoEntity hr_familyinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
