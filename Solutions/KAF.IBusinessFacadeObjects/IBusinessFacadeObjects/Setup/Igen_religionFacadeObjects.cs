

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_religionFacadeObjects")]
    public partial interface Igen_religionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_religionEntity gen_religion);
        
		[OperationContract]
		long Update(gen_religionEntity gen_religion);
		
		[OperationContract]
		long Delete(gen_religionEntity gen_religion );
        
        [OperationContract]
        long SaveList(List<gen_religionEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_religionEntity> GetAll(gen_religionEntity gen_religion);
		
		[OperationContract]
        IList<gen_religionEntity> GetAllByPages(gen_religionEntity gen_religion);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_religionEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_religionEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_religionEntity  GetSingle(gen_religionEntity gen_religion);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_religionEntity> GAPgListView(gen_religionEntity gen_religion);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
