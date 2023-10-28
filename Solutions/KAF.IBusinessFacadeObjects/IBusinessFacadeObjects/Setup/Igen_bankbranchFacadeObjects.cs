

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_bankbranchFacadeObjects")]
    public partial interface Igen_bankbranchFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_bankbranchEntity gen_bankbranch);
        
		[OperationContract]
		long Update(gen_bankbranchEntity gen_bankbranch);
		
		[OperationContract]
		long Delete(gen_bankbranchEntity gen_bankbranch );
        
        [OperationContract]
        long SaveList(List<gen_bankbranchEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_bankbranchEntity> GetAll(gen_bankbranchEntity gen_bankbranch);
		
		[OperationContract]
        IList<gen_bankbranchEntity> GetAllByPages(gen_bankbranchEntity gen_bankbranch);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_bankaccountinfo(gen_bankbranchEntity Master, List<hr_bankaccountinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_bankloaninfo(gen_bankbranchEntity Master, List<hr_bankloaninfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_bankbranchEntity  GetSingle(gen_bankbranchEntity gen_bankbranch);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_bankbranchEntity> GAPgListView(gen_bankbranchEntity gen_bankbranch);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
