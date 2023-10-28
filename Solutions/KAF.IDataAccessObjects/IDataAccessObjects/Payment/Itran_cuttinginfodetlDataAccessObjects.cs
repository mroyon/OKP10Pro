using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Itran_cuttinginfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
		
		long Update(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
        
		long Delete(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
		
        long SaveList(IList<tran_cuttinginfodetlEntity> listAdded, IList<tran_cuttinginfodetlEntity> listUpdated, IList<tran_cuttinginfodetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<tran_cuttinginfodetlEntity> GetAll(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
		
		IList<tran_cuttinginfodetlEntity> GetAllByPages(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         tran_cuttinginfodetlEntity  GetSingle(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<tran_cuttinginfodetlEntity> GAPgListView(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        long UpdateReviewed(tran_cuttinginfodetlEntity tran_cuttinginfodetl);
        #endregion        
        
    }
}
