

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Itran_manpowerstatedetlFacadeObjects")]
    public partial interface Itran_manpowerstatedetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
        
		[OperationContract]
		long Update(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
		
		[OperationContract]
		long Delete(tran_manpowerstatedetlEntity tran_manpowerstatedetl );
        
        [OperationContract]
        long SaveList(List<tran_manpowerstatedetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<tran_manpowerstatedetlEntity> GetAll(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
		
		[OperationContract]
        IList<tran_manpowerstatedetlEntity> GetAllByPages(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        tran_manpowerstatedetlEntity  GetSingle(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<tran_manpowerstatedetlEntity> GAPgListView(tran_manpowerstatedetlEntity tran_manpowerstatedetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
