

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Itran_manpowerstate_historyFacadeObjects")]
    public partial interface Itran_manpowerstate_historyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(tran_manpowerstate_historyEntity tran_manpowerstate_history);
        
		[OperationContract]
		long Update(tran_manpowerstate_historyEntity tran_manpowerstate_history);
		
		[OperationContract]
		long Delete(tran_manpowerstate_historyEntity tran_manpowerstate_history );
        
        [OperationContract]
        long SaveList(List<tran_manpowerstate_historyEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<tran_manpowerstate_historyEntity> GetAll(tran_manpowerstate_historyEntity tran_manpowerstate_history);
		
		[OperationContract]
        IList<tran_manpowerstate_historyEntity> GetAllByPages(tran_manpowerstate_historyEntity tran_manpowerstate_history);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        tran_manpowerstate_historyEntity  GetSingle(tran_manpowerstate_historyEntity tran_manpowerstate_history);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<tran_manpowerstate_historyEntity> GAPgListView(tran_manpowerstate_historyEntity tran_manpowerstate_history);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        long UpdateReviewed(tran_manpowerstate_historyEntity tran_manpowerstate_history);
        #endregion 
    }
}
