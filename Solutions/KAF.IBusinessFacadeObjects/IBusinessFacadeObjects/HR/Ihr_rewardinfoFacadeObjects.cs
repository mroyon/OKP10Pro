

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_rewardinfoFacadeObjects")]
    public partial interface Ihr_rewardinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_rewardinfoEntity hr_rewardinfo);
        
		[OperationContract]
		long Update(hr_rewardinfoEntity hr_rewardinfo);
		
		[OperationContract]
		long Delete(hr_rewardinfoEntity hr_rewardinfo );
        
        [OperationContract]
        long SaveList(List<hr_rewardinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_rewardinfoEntity> GetAll(hr_rewardinfoEntity hr_rewardinfo);
		
		[OperationContract]
        IList<hr_rewardinfoEntity> GetAllByPages(hr_rewardinfoEntity hr_rewardinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_rewardinfoEntity  GetSingle(hr_rewardinfoEntity hr_rewardinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_rewardinfoEntity> GAPgListView(hr_rewardinfoEntity hr_rewardinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
