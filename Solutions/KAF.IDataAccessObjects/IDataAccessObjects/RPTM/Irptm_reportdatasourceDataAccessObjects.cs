using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Irptm_reportdatasourceDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(rptm_reportdatasourceEntity rptm_reportdatasource);
		
		long Update(rptm_reportdatasourceEntity rptm_reportdatasource);
        
		long Delete(rptm_reportdatasourceEntity rptm_reportdatasource);
		
        long SaveList(IList<rptm_reportdatasourceEntity> listAdded, IList<rptm_reportdatasourceEntity> listUpdated, IList<rptm_reportdatasourceEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<rptm_reportdatasourceEntity> GetAll(rptm_reportdatasourceEntity rptm_reportdatasource);
		
		IList<rptm_reportdatasourceEntity> GetAllByPages(rptm_reportdatasourceEntity rptm_reportdatasource);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         rptm_reportdatasourceEntity  GetSingle(rptm_reportdatasourceEntity rptm_reportdatasource);
         #endregion 
         
         #region ForListView Paged Method
         IList<rptm_reportdatasourceEntity> GAPgListView(rptm_reportdatasourceEntity rptm_reportdatasource);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
