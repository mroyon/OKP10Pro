

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userroledetlFacadeObjects")]
    public partial interface Iowin_userroledetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userroledetlEntity owin_userroledetl);
        
		[OperationContract]
		long Update(owin_userroledetlEntity owin_userroledetl);
		
		[OperationContract]
		long Delete(owin_userroledetlEntity owin_userroledetl );
        
        [OperationContract]
        long SaveList(List<owin_userroledetlEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userroledetlEntity> GetAll(owin_userroledetlEntity owin_userroledetl);
		
		[OperationContract]
        IList<owin_userroledetlEntity> GetAllByPages(owin_userroledetlEntity owin_userroledetl);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_userroledetlentitymap(owin_userroledetlEntity Master, List<owin_userroledetlentitymapEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userroledetlEntity  GetSingle(owin_userroledetlEntity owin_userroledetl);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userroledetlEntity> GAPgListView(owin_userroledetlEntity owin_userroledetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
