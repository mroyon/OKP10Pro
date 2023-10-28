

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_maritalstatusFacadeObjects")]
    public partial interface Igen_maritalstatusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_maritalstatusEntity gen_maritalstatus);
        
		[OperationContract]
		long Update(gen_maritalstatusEntity gen_maritalstatus);
		
		[OperationContract]
		long Delete(gen_maritalstatusEntity gen_maritalstatus );
        
        [OperationContract]
        long SaveList(List<gen_maritalstatusEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_maritalstatusEntity> GetAll(gen_maritalstatusEntity gen_maritalstatus);
		
		[OperationContract]
        IList<gen_maritalstatusEntity> GetAllByPages(gen_maritalstatusEntity gen_maritalstatus);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_maritalstatusEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_maritalstatusEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_maritalstatusEntity  GetSingle(gen_maritalstatusEntity gen_maritalstatus);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_maritalstatusEntity> GAPgListView(gen_maritalstatusEntity gen_maritalstatus);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
