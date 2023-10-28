

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_leavetypeFacadeObjects")]
    public partial interface Igen_leavetypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_leavetypeEntity gen_leavetype);
        
		[OperationContract]
		long Update(gen_leavetypeEntity gen_leavetype);
		
		[OperationContract]
		long Delete(gen_leavetypeEntity gen_leavetype );
        
        [OperationContract]
        long SaveList(List<gen_leavetypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_leavetypeEntity> GetAll(gen_leavetypeEntity gen_leavetype);
		
		[OperationContract]
        IList<gen_leavetypeEntity> GetAllByPages(gen_leavetypeEntity gen_leavetype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        //[OperationContract]
        //long SaveMasterDetgen_leaveconfig(gen_leavetypeEntity Master, List<gen_leaveconfigEntity> DetailList);

        //[OperationContract]
        //long SaveMasterDethr_leaveinfo(gen_leavetypeEntity Master, List<hr_leaveinfoEntity> DetailList);

        //[OperationContract]
        //long SaveMasterDethr_leavemodification(gen_leavetypeEntity Master, List<hr_leavemodificationEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_leavetypeEntity  GetSingle(gen_leavetypeEntity gen_leavetype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_leavetypeEntity> GAPgListView(gen_leavetypeEntity gen_leavetype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
