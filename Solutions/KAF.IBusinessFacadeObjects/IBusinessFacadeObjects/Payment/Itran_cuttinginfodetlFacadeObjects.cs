

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Itran_cuttinginfodetlFacadeObjects")]
    public partial interface Itran_cuttinginfodetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
        
		[OperationContract]
		long Update(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
		
		[OperationContract]
		long Delete(tran_cuttinginfodetlEntity tran_cuttinginfodetl );
        
        [OperationContract]
        long SaveList(List<tran_cuttinginfodetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<tran_cuttinginfodetlEntity> GetAll(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
		
		[OperationContract]
        IList<tran_cuttinginfodetlEntity> GetAllByPages(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        tran_cuttinginfodetlEntity  GetSingle(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<tran_cuttinginfodetlEntity> GAPgListView(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        long UpdateReviewed(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
        #endregion 
    }
}
