

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_newdemanddetlFacadeObjects
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
        
		[OperationContract]
		long Update_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
		
		[OperationContract]
		long Delete_Ext(hr_newdemanddetlEntity hr_newdemanddetl );
        
        [OperationContract]
        long SaveList_Ext(List<hr_newdemanddetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_newdemanddetlEntity> GetAll_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
		
		[OperationContract]
        IList<hr_newdemanddetlEntity> GetAllByPages_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
     
		#endregion GetAll
		
        
        
        #region Simple load Single Row
        [OperationContract]
        hr_newdemanddetlEntity GetSingle_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_newdemanddetlEntity> GAPgListView_Ext(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
