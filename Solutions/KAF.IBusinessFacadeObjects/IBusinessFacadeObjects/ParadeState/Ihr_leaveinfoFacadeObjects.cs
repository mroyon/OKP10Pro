

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_leaveinfoFacadeObjects")]
    public partial interface Ihr_leaveinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_leaveinfoEntity hr_leaveinfo);
        
		[OperationContract]
		long Update(hr_leaveinfoEntity hr_leaveinfo);
		
		[OperationContract]
		long Delete(hr_leaveinfoEntity hr_leaveinfo );
        
        [OperationContract]
        long SaveList(List<hr_leaveinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_leaveinfoEntity> GetAll(hr_leaveinfoEntity hr_leaveinfo);
		
		[OperationContract]
        IList<hr_leaveinfoEntity> GetAllByPages(hr_leaveinfoEntity hr_leaveinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_leavemodification(hr_leaveinfoEntity Master, List<hr_leavemodificationEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_leaveinfoEntity  GetSingle(hr_leaveinfoEntity hr_leaveinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_leaveinfoEntity> GAPgListView(hr_leaveinfoEntity hr_leaveinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
