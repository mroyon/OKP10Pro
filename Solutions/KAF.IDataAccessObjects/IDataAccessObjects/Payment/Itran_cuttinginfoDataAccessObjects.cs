using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Itran_cuttinginfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(tran_cuttinginfoEntity tran_cuttinginfo);
		
		long Update(tran_cuttinginfoEntity tran_cuttinginfo);
        
		long Delete(tran_cuttinginfoEntity tran_cuttinginfo);
		
        long SaveList(IList<tran_cuttinginfoEntity> listAdded, IList<tran_cuttinginfoEntity> listUpdated, IList<tran_cuttinginfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<tran_cuttinginfoEntity> GetAll(tran_cuttinginfoEntity tran_cuttinginfo);
		
		IList<tran_cuttinginfoEntity> GetAllByPages(tran_cuttinginfoEntity tran_cuttinginfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDettran_cuttinginfodetl(tran_cuttinginfoEntity masterEntity, IList<tran_cuttinginfodetlEntity> listAdded, IList<tran_cuttinginfodetlEntity> listUpdated, IList<tran_cuttinginfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         tran_cuttinginfoEntity  GetSingle(tran_cuttinginfoEntity tran_cuttinginfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<tran_cuttinginfoEntity> GAPgListView(tran_cuttinginfoEntity tran_cuttinginfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        long UpdateReviewed(tran_cuttinginfoEntity tran_cuttinginfo);
        #endregion        
        
    }
}
