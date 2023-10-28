

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_bankFacadeObjects")]
    public partial interface Igen_bankFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_bankEntity gen_bank);
        
		[OperationContract]
		long Update(gen_bankEntity gen_bank);
		
		[OperationContract]
		long Delete(gen_bankEntity gen_bank );
        
        [OperationContract]
        long SaveList(List<gen_bankEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_bankEntity> GetAll(gen_bankEntity gen_bank);
		
		[OperationContract]
        IList<gen_bankEntity> GetAllByPages(gen_bankEntity gen_bank);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_bankbranch(gen_bankEntity Master, List<gen_bankbranchEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_bankaccountinfo(gen_bankEntity Master, List<hr_bankaccountinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_bankloaninfo(gen_bankEntity Master, List<hr_bankloaninfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_bankEntity  GetSingle(gen_bankEntity gen_bank);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_bankEntity> GAPgListView(gen_bankEntity gen_bank);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
