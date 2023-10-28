

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Irptm_reportdatasourceFacadeObjects")]
    public partial interface Irptm_reportdatasourceFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(rptm_reportdatasourceEntity rptm_reportdatasource);
        
		[OperationContract]
		long Update(rptm_reportdatasourceEntity rptm_reportdatasource);
		
		[OperationContract]
		long Delete(rptm_reportdatasourceEntity rptm_reportdatasource );
        
        [OperationContract]
        long SaveList(List<rptm_reportdatasourceEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<rptm_reportdatasourceEntity> GetAll(rptm_reportdatasourceEntity rptm_reportdatasource);
		
		[OperationContract]
        IList<rptm_reportdatasourceEntity> GetAllByPages(rptm_reportdatasourceEntity rptm_reportdatasource);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        rptm_reportdatasourceEntity  GetSingle(rptm_reportdatasourceEntity rptm_reportdatasource);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<rptm_reportdatasourceEntity> GAPgListView(rptm_reportdatasourceEntity rptm_reportdatasource);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
