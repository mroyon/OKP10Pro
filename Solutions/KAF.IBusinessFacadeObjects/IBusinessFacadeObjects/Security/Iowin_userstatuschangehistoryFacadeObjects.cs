

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userstatuschangehistoryFacadeObjects")]
    public partial interface Iowin_userstatuschangehistoryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
        
		[OperationContract]
		long Update(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
		
		[OperationContract]
		long Delete(owin_userstatuschangehistoryEntity owin_userstatuschangehistory );
        
        [OperationContract]
        long SaveList(List<owin_userstatuschangehistoryEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userstatuschangehistoryEntity> GetAll(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
		
		[OperationContract]
        IList<owin_userstatuschangehistoryEntity> GetAllByPages(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userstatuschangehistoryEntity  GetSingle(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userstatuschangehistoryEntity> GAPgListView(owin_userstatuschangehistoryEntity owin_userstatuschangehistory);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
