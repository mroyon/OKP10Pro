

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Irptm_reportparameterFacadeObjects")]
    public partial interface Irptm_reportparameterFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(rptm_reportparameterEntity rptm_reportparameter);
        
		[OperationContract]
		long Update(rptm_reportparameterEntity rptm_reportparameter);
		
		[OperationContract]
		long Delete(rptm_reportparameterEntity rptm_reportparameter );
        
        [OperationContract]
        long SaveList(List<rptm_reportparameterEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<rptm_reportparameterEntity> GetAll(rptm_reportparameterEntity rptm_reportparameter);
		
		[OperationContract]
        IList<rptm_reportparameterEntity> GetAllByPages(rptm_reportparameterEntity rptm_reportparameter);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        rptm_reportparameterEntity  GetSingle(rptm_reportparameterEntity rptm_reportparameter);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<rptm_reportparameterEntity> GAPgListView(rptm_reportparameterEntity rptm_reportparameter);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
