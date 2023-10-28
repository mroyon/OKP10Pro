

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userroledetlentityprofilemapFacadeObjects")]
    public partial interface Iowin_userroledetlentityprofilemapFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
        
		[OperationContract]
		long Update(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
		
		[OperationContract]
		long Delete(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap );
        
        [OperationContract]
        long SaveList(List<owin_userroledetlentityprofilemapEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userroledetlentityprofilemapEntity> GetAll(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
		
		[OperationContract]
        IList<owin_userroledetlentityprofilemapEntity> GetAllByPages(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userroledetlentityprofilemapEntity  GetSingle(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userroledetlentityprofilemapEntity> GAPgListView(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
