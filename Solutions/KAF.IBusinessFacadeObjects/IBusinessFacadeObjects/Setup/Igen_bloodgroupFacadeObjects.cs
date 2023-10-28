

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_bloodgroupFacadeObjects")]
    public partial interface Igen_bloodgroupFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_bloodgroupEntity gen_bloodgroup);
        
		[OperationContract]
		long Update(gen_bloodgroupEntity gen_bloodgroup);
		
		[OperationContract]
		long Delete(gen_bloodgroupEntity gen_bloodgroup );
        
        [OperationContract]
        long SaveList(List<gen_bloodgroupEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_bloodgroupEntity> GetAll(gen_bloodgroupEntity gen_bloodgroup);
		
		[OperationContract]
        IList<gen_bloodgroupEntity> GetAllByPages(gen_bloodgroupEntity gen_bloodgroup);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_bloodgroupEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_bloodgroupEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_bloodgroupEntity  GetSingle(gen_bloodgroupEntity gen_bloodgroup);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_bloodgroupEntity> GAPgListView(gen_bloodgroupEntity gen_bloodgroup);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
