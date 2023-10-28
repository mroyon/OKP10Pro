

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Itran_cuttinginfoFacadeObjects")]
    public partial interface Itran_cuttinginfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(tran_cuttinginfoEntity tran_cuttinginfo);
        
		[OperationContract]
		long Update(tran_cuttinginfoEntity tran_cuttinginfo);
		
		[OperationContract]
		long Delete(tran_cuttinginfoEntity tran_cuttinginfo );
        
        [OperationContract]
        long SaveList(List<tran_cuttinginfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<tran_cuttinginfoEntity> GetAll(tran_cuttinginfoEntity tran_cuttinginfo);
		
		[OperationContract]
        IList<tran_cuttinginfoEntity> GetAllByPages(tran_cuttinginfoEntity tran_cuttinginfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDettran_cuttinginfodetl(tran_cuttinginfoEntity Master, List<tran_cuttinginfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        tran_cuttinginfoEntity  GetSingle(tran_cuttinginfoEntity tran_cuttinginfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<tran_cuttinginfoEntity> GAPgListView(tran_cuttinginfoEntity tran_cuttinginfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        long UpdateReviewed(tran_cuttinginfoEntity tran_cuttinginfo);
        #endregion 
    }
}
