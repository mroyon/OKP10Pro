

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_tradeFacadeObjects")]
    public partial interface Igen_tradeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_tradeEntity gen_trade);
        
		[OperationContract]
		long Update(gen_tradeEntity gen_trade);
		
		[OperationContract]
		long Delete(gen_tradeEntity gen_trade );
        
        [OperationContract]
        long SaveList(List<gen_tradeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_tradeEntity> GetAll(gen_tradeEntity gen_trade);
		
		[OperationContract]
        IList<gen_tradeEntity> GetAllByPages(gen_tradeEntity gen_trade);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_newdemanddetl(gen_tradeEntity Master, List<hr_newdemanddetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_svcinfo(gen_tradeEntity Master, List<hr_svcinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_tradeEntity  GetSingle(gen_tradeEntity gen_trade);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_tradeEntity> GAPgListView(gen_tradeEntity gen_trade);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
