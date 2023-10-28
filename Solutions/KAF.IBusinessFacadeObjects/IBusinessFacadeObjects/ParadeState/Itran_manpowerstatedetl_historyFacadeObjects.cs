

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Itran_manpowerstatedetl_historyFacadeObjects")]
    public partial interface Itran_manpowerstatedetl_historyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
        
		[OperationContract]
		long Update(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
		
		[OperationContract]
		long Delete(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history );
        
        [OperationContract]
        long SaveList(List<tran_manpowerstatedetl_historyEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<tran_manpowerstatedetl_historyEntity> GetAll(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
		
		[OperationContract]
        IList<tran_manpowerstatedetl_historyEntity> GetAllByPages(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        tran_manpowerstatedetl_historyEntity  GetSingle(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<tran_manpowerstatedetl_historyEntity> GAPgListView(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
