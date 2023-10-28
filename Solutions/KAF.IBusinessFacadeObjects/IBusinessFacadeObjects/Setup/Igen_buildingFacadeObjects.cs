

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_buildingFacadeObjects")]
    public partial interface Igen_buildingFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_buildingEntity gen_building);
        
		[OperationContract]
		long Update(gen_buildingEntity gen_building);
		
		[OperationContract]
		long Delete(gen_buildingEntity gen_building );
        
        [OperationContract]
        long SaveList(List<gen_buildingEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_buildingEntity> GetAll(gen_buildingEntity gen_building);
		
		[OperationContract]
        IList<gen_buildingEntity> GetAllByPages(gen_buildingEntity gen_building);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_addresschange(gen_buildingEntity Master, List<hr_addresschangeEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_buildingEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_buildingEntity  GetSingle(gen_buildingEntity gen_building);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_buildingEntity> GAPgListView(gen_buildingEntity gen_building);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
