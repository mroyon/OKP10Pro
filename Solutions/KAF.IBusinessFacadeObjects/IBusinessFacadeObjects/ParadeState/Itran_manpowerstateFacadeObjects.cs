

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Itran_manpowerstateFacadeObjects")]
    public partial interface Itran_manpowerstateFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(tran_manpowerstateEntity tran_manpowerstate);
        
		[OperationContract]
		long Update(tran_manpowerstateEntity tran_manpowerstate);
		
		[OperationContract]
		long Delete(tran_manpowerstateEntity tran_manpowerstate );
        
        [OperationContract]
        long SaveList(List<tran_manpowerstateEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<tran_manpowerstateEntity> GetAll(tran_manpowerstateEntity tran_manpowerstate);
		
		[OperationContract]
        IList<tran_manpowerstateEntity> GetAllByPages(tran_manpowerstateEntity tran_manpowerstate);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDettran_manpowerstatedetl(tran_manpowerstateEntity Master, List<tran_manpowerstatedetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        tran_manpowerstateEntity  GetSingle(tran_manpowerstateEntity tran_manpowerstate);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<tran_manpowerstateEntity> GAPgListView(tran_manpowerstateEntity tran_manpowerstate);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        long UpdateReviewed(tran_manpowerstateEntity tran_manpowerstate);
        #endregion 
    }
}
