using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Irptm_reportparameterDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(rptm_reportparameterEntity rptm_reportparameter);
		
		long Update(rptm_reportparameterEntity rptm_reportparameter);
        
		long Delete(rptm_reportparameterEntity rptm_reportparameter);
		
        long SaveList(IList<rptm_reportparameterEntity> listAdded, IList<rptm_reportparameterEntity> listUpdated, IList<rptm_reportparameterEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<rptm_reportparameterEntity> GetAll(rptm_reportparameterEntity rptm_reportparameter);
		
		IList<rptm_reportparameterEntity> GetAllByPages(rptm_reportparameterEntity rptm_reportparameter);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         rptm_reportparameterEntity  GetSingle(rptm_reportparameterEntity rptm_reportparameter);
         #endregion 
         
         #region ForListView Paged Method
         IList<rptm_reportparameterEntity> GAPgListView(rptm_reportparameterEntity rptm_reportparameter);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
